using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace Main_Menu
{
    public partial class HexEdit : Form
    {
        public HexEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\my games\\borderlands 2\\willowgame\\Config\\WillowInput.ini";
                string[] temp = File.ReadAllLines(path);
                int i;
                for (i = 1; i <= temp.Length; i++)
                {
                    if (temp[i].StartsWith("ConsoleKey="))
                        break;
                }
                temp[i] = "ConsoleKey=" + textBox1.Text;
                File.WriteAllLines(path, temp);
                MessageBox.Show("Console Enabled!");
            }
            if (BL2EXE.ShowDialog() == DialogResult.OK)
            {
                string file = (BL2EXE.FileName);
                if (file.EndsWith("Borderlands2.exe") || file.EndsWith("borderlands2.exe"))
                {
                    try
                    {
                        File.Copy(file, file + ".bk", false);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("You already have a backup. Skipping.");
                    }
                    var stream = new FileStream(file, FileMode.Open, FileAccess.ReadWrite);
                    stream.Position = 0x004F2590;
                    stream.WriteByte(0xff);
                    for (long i = 0x01B94B0C; i <= 0x01B94B10; i++)
                    {
                        stream.Position = i;
                        stream.WriteByte(0x00);
                    }
                    stream.Close();
                    MessageBox.Show("Done!");
                }
                else MessageBox.Show("Incorrect filename. I will only patch Borderlands2.exe or borderlands2.exe files");
            }
        }
    }
}
