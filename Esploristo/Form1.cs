using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Esploristo.MainForm;

namespace Esploristo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0.5;
            this.TopMost = true;
        }
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        const int GWL_EXSTYLE = -20;
        const int WS_EX_LAYERED = 0x80000;
        const int WS_EX_TRANSPARENT = 0x20;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
        }

        public void ChangeWords(JapaneseNote note)
        {
            this.Word.Text = note.Word;
            this.Translation.Text = note.Translation;
            this.Onyomi.Text = note.Onyomi;
            this.Kunyomi.Text = note.Kunyomi;
        }
    }
}
