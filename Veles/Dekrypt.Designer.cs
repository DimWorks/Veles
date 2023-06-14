
namespace Veles
{
    partial class Dekrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dekrypt));
            this.enter = new System.Windows.Forms.Button();
            this.canel = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.TextBox();
            this.keyP = new System.Windows.Forms.TextBox();
            this.keyQ = new System.Windows.Forms.TextBox();
            this.isKeyQ = new System.Windows.Forms.Label();
            this.isKeyP = new System.Windows.Forms.Label();
            this.isKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.Location = new System.Drawing.Point(12, 175);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(115, 28);
            this.enter.TabIndex = 1;
            this.enter.Text = "OK";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // canel
            // 
            this.canel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canel.Location = new System.Drawing.Point(161, 176);
            this.canel.Name = "canel";
            this.canel.Size = new System.Drawing.Size(115, 28);
            this.canel.TabIndex = 2;
            this.canel.Text = "Отмена";
            this.canel.UseVisualStyleBackColor = true;
            this.canel.Click += new System.EventHandler(this.canel_Click);
            // 
            // key
            // 
            this.key.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key.Location = new System.Drawing.Point(24, 24);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(247, 29);
            this.key.TabIndex = 3;
            this.key.Text = "Введите ключ";
            this.key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key.Click += new System.EventHandler(this.key_Click);
            // 
            // keyP
            // 
            this.keyP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyP.Location = new System.Drawing.Point(24, 77);
            this.keyP.Name = "keyP";
            this.keyP.Size = new System.Drawing.Size(247, 29);
            this.keyP.TabIndex = 4;
            this.keyP.Text = "Введите ключ p";
            this.keyP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.keyP.Visible = false;
            this.keyP.Click += new System.EventHandler(this.keyP_Click);
            // 
            // keyQ
            // 
            this.keyQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyQ.Location = new System.Drawing.Point(24, 131);
            this.keyQ.Name = "keyQ";
            this.keyQ.Size = new System.Drawing.Size(247, 29);
            this.keyQ.TabIndex = 5;
            this.keyQ.Text = "Введите ключ q";
            this.keyQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.keyQ.Visible = false;
            this.keyQ.Click += new System.EventHandler(this.keyQ_Click);
            // 
            // isKeyQ
            // 
            this.isKeyQ.AutoSize = true;
            this.isKeyQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isKeyQ.Location = new System.Drawing.Point(277, 131);
            this.isKeyQ.Name = "isKeyQ";
            this.isKeyQ.Size = new System.Drawing.Size(24, 25);
            this.isKeyQ.TabIndex = 13;
            this.isKeyQ.Text = "?";
            this.isKeyQ.Visible = false;
            // 
            // isKeyP
            // 
            this.isKeyP.AutoSize = true;
            this.isKeyP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isKeyP.Location = new System.Drawing.Point(277, 79);
            this.isKeyP.Name = "isKeyP";
            this.isKeyP.Size = new System.Drawing.Size(24, 25);
            this.isKeyP.TabIndex = 12;
            this.isKeyP.Text = "?";
            // 
            // isKey
            // 
            this.isKey.AutoSize = true;
            this.isKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isKey.Location = new System.Drawing.Point(277, 28);
            this.isKey.Name = "isKey";
            this.isKey.Size = new System.Drawing.Size(24, 25);
            this.isKey.TabIndex = 11;
            this.isKey.Text = "?";
            // 
            // Dekrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 243);
            this.Controls.Add(this.isKeyQ);
            this.Controls.Add(this.isKeyP);
            this.Controls.Add(this.isKey);
            this.Controls.Add(this.keyQ);
            this.Controls.Add(this.keyP);
            this.Controls.Add(this.key);
            this.Controls.Add(this.canel);
            this.Controls.Add(this.enter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(326, 282);
            this.MinimumSize = new System.Drawing.Size(326, 282);
            this.Name = "Dekrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dekrypt";
            this.Load += new System.EventHandler(this.Dekrypt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button canel;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.TextBox keyP;
        private System.Windows.Forms.TextBox keyQ;
        private System.Windows.Forms.Label isKeyQ;
        private System.Windows.Forms.Label isKeyP;
        private System.Windows.Forms.Label isKey;
    }
}