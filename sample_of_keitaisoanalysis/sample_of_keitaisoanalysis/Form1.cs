using NMeCab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sample_of_keitaisoanalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.KeyDown += this.tb_KeyDown;
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //形態素解析されるもとの文章
                string text = richTextBox1.Text;// "私はプログラマーです";

                string[] array_str = text.Split("\n");

                var tagger = MeCabTagger.Create();

                //形態素解析を行い結果を記録
                string result = tagger.Parse(array_str[array_str.Length - 1]);

                richTextBox2.Text = result;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //形態素解析されるもとの文章
            string text = richTextBox1.Text;// "私はプログラマーです";

            var tagger = MeCabTagger.Create();

            //形態素解析を行い結果を記録
            string result = tagger.Parse(text);

            richTextBox2.Text = result;
        }
    }
}
