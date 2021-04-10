using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esploristo
{
    static class Shared
    {
        public static int Delay = 60000;
    }
    public partial class MainForm : Form
    {
        public class Note
        {
            public string Word { get; set; }
            public string Translation { get; set; }
        }
        public class JapaneseNote : Note
        {
            //public JapaneseNote(string word, string translation, string on, string kun)
            //{
            //    this.Word = word;
            //    this.Translation = translation;
            //    this.Onyomi = on;
            //    this.Kunyomi = kun;
            //}
            public string Onyomi { get; set; }
            public string Kunyomi { get; set; }
        }

        public List<JapaneseNote> DictionaryJP = new();


        public MainForm()
        {
            InitializeComponent();

            //DictionaryJP.Add(new JapaneseNote(){ Word = "来", Translation = "приходить", Onyomi = "ライ", Kunyomi = "くる" });
            //DictionaryJP.Add(new JapaneseNote(){ Word = "目", Translation = "глаз", Onyomi = "モク", Kunyomi = "め" });
            //DictionaryJP.Add(new JapaneseNote(){ Word = "見", Translation = "видеть", Onyomi = "ケン", Kunyomi = "みる" });
            //DictionaryJP.Add(new JapaneseNote(){ Word = "田", Translation = "рисовое поле", Onyomi = "デン", Kunyomi = "た" });
            //DictionaryJP.Add(new JapaneseNote(){ Word = "心", Translation = "сердце, чувство", Onyomi = "シン", Kunyomi = "こころ" });
            //DictionaryJP.Add(new JapaneseNote(){ Word = "思", Translation = "думать", Onyomi = "シ", Kunyomi = "おもう" });
            //DictionaryJP.Add(new JapaneseNote(){ Word = "分", Translation = "понимать, минута", Onyomi = "ブン、\nフン", Kunyomi = "わかる" });
            //DictionaryJP.Add(new JapaneseNote(){ Word = "時", Translation = "время", Onyomi = "ジ", Kunyomi = "とき" });
            //DictionaryJP.Add(new JapaneseNote(){ Word = "事", Translation = "дело", Onyomi = "ジ", Kunyomi = "こと" });
            //DictionaryJP.Add(new JapaneseNote(){ Word = "木", Translation = "дерево", Onyomi = "モク、\nボク", Kunyomi = "き" });
            DictionaryJP.Add(new JapaneseNote() { Word = "自", Translation = "сам", Onyomi = "ジ", Kunyomi = "みずから" });
            DictionaryJP.Add(new JapaneseNote() { Word = "皮", Translation = "кожа", Onyomi = "ヒ", Kunyomi = "かわ" });
            DictionaryJP.Add(new JapaneseNote() { Word = "彼", Translation = "он", Onyomi = "ヒ", Kunyomi = "かれ" });
            DictionaryJP.Add(new JapaneseNote() { Word = "門", Translation = "ворота", Onyomi = "モン", Kunyomi = "かど" });
        }
        static Form1 form;
        static bool Run;

        private void button1_Click(object sender, EventArgs e)
        {
            if (form != null)
            {
                form.Close();
                Run = false;
            }
            CheckForIllegalCrossThreadCalls = false;
            form = new Form1();
            form.Show();
        }

        async void OpChanger()
        {
            await Task.Run(() =>
            {
                int i = 0;
                while (Run)
                {
                    form.ChangeWords(DictionaryJP[i]);

                    form.Show();
                    while (form.Opacity < 1 && Run)
                    {
                        form.Opacity += 0.01;
                        System.Threading.Thread.Sleep(19);
                    }
                    while (form.Opacity > 0 && Run)
                    {
                        form.Opacity -= 0.01;
                        System.Threading.Thread.Sleep(19);
                    }
                    form.Hide();
                    if (i + 1 < DictionaryJP.Count)
                    {
                        i++;
                    }
                    else
                    {
                        i = 0;
                    }
                    System.Threading.Thread.Sleep(Shared.Delay);
                }
                form.Close();
            });
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Run = true;
            OpChanger();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var set = new Settings();
            set.ShowDialog();
        }
    }
}
