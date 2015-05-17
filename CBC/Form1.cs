using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace CBC
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
        }

        private void fileOpenMenu_Click(object sender, EventArgs e)
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            ofd.FileName = "";
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = @"";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter =
                "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに
            //「テキストファイル」が選択されているようにする
            ofd.FilterIndex = 1;
            //タイトルを設定する
            ofd.Title = "ファイルを開く";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string text = sr.ReadToEnd();
                beforeText.Text = text;
                sr.Close();
                fs.Close();

                afterText.Text = "";
            }
        }

        private void fileSaveMenu_Click(object sender, EventArgs e)
        {
            //SaveFileDialogクラスのインスタンスを作成
            SaveFileDialog sfd = new SaveFileDialog();

            //はじめのファイル名を指定する
            sfd.FileName = "";
            //はじめに表示されるフォルダを指定する
            sfd.InitialDirectory = @"";
            //[ファイルの種類]に表示される選択肢を指定する
            sfd.Filter =
                "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに
            //「すべてのファイル」が選択されているようにする
            sfd.FilterIndex = 1;
            //タイトルを設定する
            sfd.Title = "名前をつけて保存";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            sfd.RestoreDirectory = true;
            //既に存在するファイル名を指定したとき警告する
            //デフォルトでTrueなので指定する必要はない
            sfd.OverwritePrompt = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            sfd.CheckPathExists = true;

            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(afterText.Text);
                sw.Close();
                fs.Close();

                MessageBox.Show("ファイルを保存しました。");
            }
        }

        private void encryptionButton_Click(object sender, EventArgs e)
        {
            if ((passwordTextBox.Text != "") && (beforeText.Text != ""))
            {
                Crypt aes = new Crypt();

                //passwordからkeyとivを作成
                RijndaelManaged rij = new RijndaelManaged();
                byte[] iv, key;
                aes.GenerateKeyFromPassword(passwordTextBox.Text, rij.KeySize, out key, rij.BlockSize, out iv);
                
                aes.setAesIV(iv);
                aes.setAesKey(key);

                //暗号化処理
                afterText.Text = aes.EnCrypt(beforeText.Text);

                passwordTextBox.Text = "";
            }
        }

        private void decryptionButton_Click(object sender, EventArgs e)
        {
            if ((passwordTextBox.Text != "") && (beforeText.Text != ""))
            {
                try
                {
                    Crypt aes = new Crypt();

                    //passwordからkeyとivを作成
                    RijndaelManaged rij = new RijndaelManaged();
                    byte[] iv, key;
                    aes.GenerateKeyFromPassword(passwordTextBox.Text, rij.KeySize, out key, rij.BlockSize, out iv);

                    aes.setAesIV(iv);
                    aes.setAesKey(key);

                    //復号処理
                    afterText.Text = aes.Decrypt(beforeText.Text);

                    passwordTextBox.Text = "";
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Error:ファイルが暗号化されていません");
                    passwordTextBox.Text = "";
                }
            }
        }
    }
}
