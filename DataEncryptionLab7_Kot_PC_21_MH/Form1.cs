using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEncryptionLab7_Kot_PC_21_MH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonFileInput_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxFileInput.Text = openFileDialog.FileName;
                }
            }
        }

        private void buttonFileOutput_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFileOutput.Text = saveFileDialog.FileName;
            }
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            var watch = new Stopwatch();
            watch.Start();
            var fileInput = File.ReadAllBytes(textBoxFileInput.Text);

            var resultArray = Array.Empty<byte>();
            if (radioButton3DES.Checked)
            {
                resultArray = Encrypt3DES(fileInput);
            }

            if (radioButtonAES.Checked)
            {
                resultArray = EncryptAES(fileInput);
            }

            File.WriteAllBytes(textBoxFileOutput.Text, resultArray);
            watch.Stop();
            outputSize.Text = resultArray.Length.ToString();
            inputSize.Text = fileInput.Length.ToString();
            codingTime.Text = watch.Elapsed.ToString();
        }

        private byte[] EncryptAES(byte[] data)
        {
            byte[] result;
            using (var aes = Aes.Create())
            {
                var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                
                using(var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(data);
                        }
                        result = msEncrypt.ToArray();
                    }
                }
            }
            return result;
        }

        private byte[] Encrypt3DES(byte[] data)
        {
            byte[] result;
            using (var tripleDES = TripleDES.Create())
            {
                var encryptor = tripleDES.CreateEncryptor(tripleDES.Key, tripleDES.IV);

                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(data);
                        }
                        result = msEncrypt.ToArray();
                    }
                }
            }

            return result;
        }
    }
}
