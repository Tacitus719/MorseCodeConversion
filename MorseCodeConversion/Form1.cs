using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MorseCodeConversion
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultOpenFile = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.Title = "Open Text File";
            openFileDialog1.InitialDirectory = "%USERPROFILE%";
            if (resultOpenFile == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string fileContent = File.ReadAllText(filePath);
                textBox1.Text = fileContent;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string outputText;
            string inputText = textBox1.Text;
            //inputText = inputText.ToUpper();
            //inputText = inputText.Replace("\n", "");
            //inputText = inputText.TrimEnd();

            inputText = Program.CleanWhiteSpaces(inputText);
            inputText = Program.CleanDiacritics(inputText);
            
            textBox1.Text = inputText;
            
            outputText = Program.Txt2Morse(inputText);
            textBox2.Text = outputText;

        }



    }
}
