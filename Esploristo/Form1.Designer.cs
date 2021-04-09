
namespace Esploristo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Word = new System.Windows.Forms.Label();
            this.Translation = new System.Windows.Forms.Label();
            this.Kunyomi = new System.Windows.Forms.Label();
            this.Onyomi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Word
            // 
            this.Word.AutoSize = true;
            this.Word.Font = new System.Drawing.Font("Segoe UI Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Word.Location = new System.Drawing.Point(80, 9);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(168, 128);
            this.Word.TabIndex = 0;
            this.Word.Text = "来";
            this.Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Translation
            // 
            this.Translation.AutoSize = true;
            this.Translation.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Translation.Location = new System.Drawing.Point(12, 333);
            this.Translation.Name = "Translation";
            this.Translation.Size = new System.Drawing.Size(134, 51);
            this.Translation.TabIndex = 1;
            this.Translation.Text = "Word2";
            this.Translation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kunyomi
            // 
            this.Kunyomi.AutoSize = true;
            this.Kunyomi.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Kunyomi.Location = new System.Drawing.Point(152, 205);
            this.Kunyomi.Name = "Kunyomi";
            this.Kunyomi.Size = new System.Drawing.Size(134, 51);
            this.Kunyomi.TabIndex = 2;
            this.Kunyomi.Text = "Word2";
            this.Kunyomi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Onyomi
            // 
            this.Onyomi.AutoSize = true;
            this.Onyomi.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Onyomi.Location = new System.Drawing.Point(12, 205);
            this.Onyomi.Name = "Onyomi";
            this.Onyomi.Size = new System.Drawing.Size(134, 51);
            this.Onyomi.TabIndex = 3;
            this.Onyomi.Text = "Word2";
            this.Onyomi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 393);
            this.Controls.Add(this.Onyomi);
            this.Controls.Add(this.Kunyomi);
            this.Controls.Add(this.Translation);
            this.Controls.Add(this.Word);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Word;
        private System.Windows.Forms.Label Translation;
        private System.Windows.Forms.Label Kunyomi;
        private System.Windows.Forms.Label Onyomi;
    }
}

