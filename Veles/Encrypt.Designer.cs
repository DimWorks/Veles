
namespace Veles
{
    partial class Encrypt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encrypt));
            this.key = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.Canel = new System.Windows.Forms.Button();
            this.keyP = new System.Windows.Forms.TextBox();
            this.keyQ = new System.Windows.Forms.TextBox();
            this.isKey = new System.Windows.Forms.Label();
            this.isKeyP = new System.Windows.Forms.Label();
            this.isKeyQ = new System.Windows.Forms.Label();
            this.poem = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.Mask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // key
            // 
            this.key.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key.Location = new System.Drawing.Point(308, 52);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(231, 29);
            this.key.TabIndex = 2;
            this.key.Text = "Введите ключ";
            this.key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key.Click += new System.EventHandler(this.key_Click);
            // 
            // enter
            // 
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.Location = new System.Drawing.Point(30, 192);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(213, 45);
            this.enter.TabIndex = 3;
            this.enter.Text = "OK";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // Canel
            // 
            this.Canel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Canel.Location = new System.Drawing.Point(308, 192);
            this.Canel.Name = "Canel";
            this.Canel.Size = new System.Drawing.Size(213, 45);
            this.Canel.TabIndex = 4;
            this.Canel.Text = "Отмена";
            this.Canel.UseVisualStyleBackColor = true;
            this.Canel.Click += new System.EventHandler(this.Canel_Click);
            // 
            // keyP
            // 
            this.keyP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyP.Location = new System.Drawing.Point(308, 96);
            this.keyP.Name = "keyP";
            this.keyP.Size = new System.Drawing.Size(231, 29);
            this.keyP.TabIndex = 5;
            this.keyP.Text = "Введите ключ p";
            this.keyP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.keyP.Visible = false;
            this.keyP.Click += new System.EventHandler(this.keyP_Click);
            // 
            // keyQ
            // 
            this.keyQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyQ.Location = new System.Drawing.Point(308, 144);
            this.keyQ.Name = "keyQ";
            this.keyQ.Size = new System.Drawing.Size(231, 29);
            this.keyQ.TabIndex = 6;
            this.keyQ.Text = "Введите ключ q";
            this.keyQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.keyQ.Visible = false;
            this.keyQ.Click += new System.EventHandler(this.keyQ_Click);
            // 
            // isKey
            // 
            this.isKey.AutoSize = true;
            this.isKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isKey.Location = new System.Drawing.Point(545, 54);
            this.isKey.Name = "isKey";
            this.isKey.Size = new System.Drawing.Size(24, 25);
            this.isKey.TabIndex = 8;
            this.isKey.Text = "?";
            // 
            // isKeyP
            // 
            this.isKeyP.AutoSize = true;
            this.isKeyP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isKeyP.Location = new System.Drawing.Point(545, 96);
            this.isKeyP.Name = "isKeyP";
            this.isKeyP.Size = new System.Drawing.Size(24, 25);
            this.isKeyP.TabIndex = 9;
            this.isKeyP.Text = "?";
            // 
            // isKeyQ
            // 
            this.isKeyQ.AutoSize = true;
            this.isKeyQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isKeyQ.Location = new System.Drawing.Point(545, 144);
            this.isKeyQ.Name = "isKeyQ";
            this.isKeyQ.Size = new System.Drawing.Size(24, 25);
            this.isKeyQ.TabIndex = 10;
            this.isKeyQ.Text = "?";
            // 
            // poem
            // 
            this.poem.AutoSize = true;
            this.poem.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poem.Location = new System.Drawing.Point(27, 13);
            this.poem.Name = "poem";
            this.poem.Size = new System.Drawing.Size(216, 176);
            this.poem.TabIndex = 11;
            this.poem.Text = "Я сложную шифровку\r\nПисал почти полдня.\r\nА препод сказал:\r\n«Какая легкотня».\r\nВоз" +
    "ьмусь читать я книжки,\r\nНе стану унывать.\r\nИ скоро будет не легко\r\nМеня расшифро" +
    "вать.";
            this.poem.Visible = false;
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(31, 52);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(212, 121);
            this.text.TabIndex = 12;
            this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Mask
            // 
            this.Mask.AutoSize = true;
            this.Mask.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mask.Location = new System.Drawing.Point(37, 54);
            this.Mask.Name = "Mask";
            this.Mask.Size = new System.Drawing.Size(203, 96);
            this.Mask.TabIndex = 13;
            this.Mask.Text = "       Введите текст     \r\n\r\n     \r\n ";
            this.Mask.Click += new System.EventHandler(this.Mask_Click);
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.Mask);
            this.Controls.Add(this.text);
            this.Controls.Add(this.poem);
            this.Controls.Add(this.isKeyQ);
            this.Controls.Add(this.isKeyP);
            this.Controls.Add(this.isKey);
            this.Controls.Add(this.keyQ);
            this.Controls.Add(this.keyP);
            this.Controls.Add(this.Canel);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.key);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Encrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input";
            this.Load += new System.EventHandler(this.Encrypt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button Canel;
        private System.Windows.Forms.TextBox keyP;
        private System.Windows.Forms.TextBox keyQ;
        private System.Windows.Forms.Label isKey;
        private System.Windows.Forms.Label isKeyP;
        private System.Windows.Forms.Label isKeyQ;
        private System.Windows.Forms.Label poem;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label Mask;
    }
}