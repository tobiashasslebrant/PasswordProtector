using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PasswordProtector
{
    public partial class MainForm : Form
    {
        private readonly string _fileName = GetFileName();
        private string _loadedText = string.Empty;
        
        private static string GetFileName() 
            => Regex.Match(Application.ExecutablePath, @"(?i)\\([^\\.]+)\.exe$").Groups[1].ToString();

        public MainForm()
        {
            InitializeComponent();
            txtKey.KeyUp += keyUp;
            Closing += closing;
            txtMain.KeyDown += keyDown;
        }
        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape) return;
            BeforeClose();
            Application.Exit();
        }

        private bool errorBox = false;
        void keyUp(object sender, KeyEventArgs e)
        {
            if (errorBox)
            {
                errorBox = false;
                return;
            }
               
            if(e.KeyCode != Keys.Return)
                return;

            if (GetFileContent())
            {
                txtKey.Enabled = false;
                txtMain.Focus();
                FormatText();
            }
            else
            {
                errorBox = true;
                MessageBox.Show("Could not get content");
               
            }
        }

        void BeforeClose()
        {
            if (string.IsNullOrEmpty(txtKey.Text))
                return;
            if (_loadedText == txtMain.Text)
                return;
            var dialogAnswer = MessageBox.Show("Spara?", "Spara", MessageBoxButtons.OKCancel);
            if (dialogAnswer == DialogResult.OK)
                SaveFile();
        }

        void closing(object sender, System.ComponentModel.CancelEventArgs e) => BeforeClose();

        void FormatText()
        {
            var lines = Regex.Split(_loadedText, "\\n");
            var index = 0;
            foreach (var line in lines)
            {
                txtMain.SelectionBackColor = Color.White;
                if(Regex.IsMatch(line,"pwd:(.+)$"))
                    txtMain.SelectionBackColor = Color.Black;
                txtMain.SelectedText = line;
                if (++index != lines.Length)
                    txtMain.SelectedText = "\n";
            }
        }

        bool GetFileContent()
        {
            if(!File.Exists(_fileName))
                return true;

            var encryptedText = File.ReadAllText(_fileName);
            try
            {
                _loadedText = Encrypting.DecryptString(encryptedText, txtKey.Text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        void SaveFile()
        {
            var encryptedText = Encrypting.EncryptString(txtMain.Text, txtKey.Text);
            File.WriteAllText(_fileName, encryptedText);
        }
    }
}
