
namespace Veles
{
    partial class Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            this.cb_Caesar = new System.Windows.Forms.CheckBox();
            this.cb_Visener = new System.Windows.Forms.CheckBox();
            this.cb_RSA = new System.Windows.Forms.CheckBox();
            this.cb_Gronsfeld = new System.Windows.Forms.CheckBox();
            this.cb_DES = new System.Windows.Forms.CheckBox();
            this.cb_Atbash = new System.Windows.Forms.CheckBox();
            this.cb_Table = new System.Windows.Forms.CheckBox();
            this.cd_Gamal = new System.Windows.Forms.CheckBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skitala = new System.Windows.Forms.CheckBox();
            this.textOrFile = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_RC4 = new System.Windows.Forms.CheckBox();
            this.cb_XXTEA = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textOrFile)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Caesar
            // 
            this.cb_Caesar.AutoSize = true;
            this.cb_Caesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Caesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Caesar.Location = new System.Drawing.Point(13, 13);
            this.cb_Caesar.Name = "cb_Caesar";
            this.cb_Caesar.Size = new System.Drawing.Size(134, 24);
            this.cb_Caesar.TabIndex = 0;
            this.cb_Caesar.Text = "Шифр Цезаря";
            this.cb_Caesar.UseVisualStyleBackColor = true;
            this.cb_Caesar.CheckedChanged += new System.EventHandler(this.cb_Caesar_CheckedChanged);
            // 
            // cb_Visener
            // 
            this.cb_Visener.AutoSize = true;
            this.cb_Visener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Visener.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Visener.Location = new System.Drawing.Point(13, 44);
            this.cb_Visener.Name = "cb_Visener";
            this.cb_Visener.Size = new System.Drawing.Size(154, 24);
            this.cb_Visener.TabIndex = 1;
            this.cb_Visener.Text = "Шифр Виженера";
            this.cb_Visener.UseVisualStyleBackColor = true;
            this.cb_Visener.CheckedChanged += new System.EventHandler(this.cb_Visener_CheckedChanged);
            // 
            // cb_RSA
            // 
            this.cb_RSA.AutoSize = true;
            this.cb_RSA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_RSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_RSA.Location = new System.Drawing.Point(13, 75);
            this.cb_RSA.Name = "cb_RSA";
            this.cb_RSA.Size = new System.Drawing.Size(62, 24);
            this.cb_RSA.TabIndex = 2;
            this.cb_RSA.Text = "RSA";
            this.cb_RSA.UseVisualStyleBackColor = true;
            this.cb_RSA.CheckedChanged += new System.EventHandler(this.cb_RSA_CheckedChanged);
            // 
            // cb_Gronsfeld
            // 
            this.cb_Gronsfeld.AutoSize = true;
            this.cb_Gronsfeld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Gronsfeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Gronsfeld.Location = new System.Drawing.Point(13, 106);
            this.cb_Gronsfeld.Name = "cb_Gronsfeld";
            this.cb_Gronsfeld.Size = new System.Drawing.Size(185, 24);
            this.cb_Gronsfeld.TabIndex = 3;
            this.cb_Gronsfeld.Text = "Шифр Гронсфельда";
            this.cb_Gronsfeld.UseVisualStyleBackColor = true;
            this.cb_Gronsfeld.CheckedChanged += new System.EventHandler(this.cb_Gronsfeld_CheckedChanged);
            // 
            // cb_DES
            // 
            this.cb_DES.AutoSize = true;
            this.cb_DES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_DES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_DES.Location = new System.Drawing.Point(12, 132);
            this.cb_DES.Name = "cb_DES";
            this.cb_DES.Size = new System.Drawing.Size(62, 24);
            this.cb_DES.TabIndex = 5;
            this.cb_DES.Text = "DES";
            this.cb_DES.UseVisualStyleBackColor = true;
            this.cb_DES.CheckedChanged += new System.EventHandler(this.cb_DES_CheckedChanged);
            // 
            // cb_Atbash
            // 
            this.cb_Atbash.AutoSize = true;
            this.cb_Atbash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Atbash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Atbash.Location = new System.Drawing.Point(12, 163);
            this.cb_Atbash.Name = "cb_Atbash";
            this.cb_Atbash.Size = new System.Drawing.Size(129, 24);
            this.cb_Atbash.TabIndex = 6;
            this.cb_Atbash.Text = "Шифр Атбаш";
            this.cb_Atbash.UseVisualStyleBackColor = true;
            this.cb_Atbash.CheckedChanged += new System.EventHandler(this.cb_Atbash_CheckedChanged);
            // 
            // cb_Table
            // 
            this.cb_Table.AutoSize = true;
            this.cb_Table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Table.Location = new System.Drawing.Point(12, 194);
            this.cb_Table.Name = "cb_Table";
            this.cb_Table.Size = new System.Drawing.Size(350, 24);
            this.cb_Table.TabIndex = 7;
            this.cb_Table.Text = "Табличная шифровка с ключевым словом";
            this.cb_Table.UseVisualStyleBackColor = true;
            this.cb_Table.CheckedChanged += new System.EventHandler(this.cb_Table_CheckedChanged);
            // 
            // cd_Gamal
            // 
            this.cd_Gamal.AutoSize = true;
            this.cd_Gamal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cd_Gamal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cd_Gamal.Location = new System.Drawing.Point(12, 224);
            this.cd_Gamal.Name = "cd_Gamal";
            this.cd_Gamal.Size = new System.Drawing.Size(171, 24);
            this.cd_Gamal.TabIndex = 9;
            this.cd_Gamal.Text = "Шифр Эль-Гамаля";
            this.cd_Gamal.UseVisualStyleBackColor = true;
            this.cd_Gamal.CheckedChanged += new System.EventHandler(this.cd_Gamal_CheckedChanged);
            // 
            // Encrypt
            // 
            this.Encrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encrypt.Location = new System.Drawing.Point(13, 384);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(164, 38);
            this.Encrypt.TabIndex = 10;
            this.Encrypt.Text = "Зашифровать";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decrypt.Location = new System.Drawing.Point(199, 384);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(164, 38);
            this.Decrypt.TabIndex = 11;
            this.Decrypt.Text = "Расшифровать";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // skitala
            // 
            this.skitala.AutoSize = true;
            this.skitala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skitala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skitala.Location = new System.Drawing.Point(12, 253);
            this.skitala.Margin = new System.Windows.Forms.Padding(2);
            this.skitala.Name = "skitala";
            this.skitala.Size = new System.Drawing.Size(143, 24);
            this.skitala.TabIndex = 10;
            this.skitala.Text = "Шифр Скитала";
            this.skitala.UseVisualStyleBackColor = true;
            this.skitala.CheckedChanged += new System.EventHandler(this.skitala_CheckedChanged_1);
            // 
            // textOrFile
            // 
            this.textOrFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textOrFile.LargeChange = 1;
            this.textOrFile.Location = new System.Drawing.Point(544, 338);
            this.textOrFile.Maximum = 1;
            this.textOrFile.Name = "textOrFile";
            this.textOrFile.Size = new System.Drawing.Size(68, 45);
            this.textOrFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(618, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(486, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Текст";
            // 
            // cb_RC4
            // 
            this.cb_RC4.AutoSize = true;
            this.cb_RC4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_RC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_RC4.Location = new System.Drawing.Point(12, 281);
            this.cb_RC4.Margin = new System.Windows.Forms.Padding(2);
            this.cb_RC4.Name = "cb_RC4";
            this.cb_RC4.Size = new System.Drawing.Size(60, 24);
            this.cb_RC4.TabIndex = 16;
            this.cb_RC4.Text = "RC4";
            this.cb_RC4.UseVisualStyleBackColor = true;
            this.cb_RC4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cb_XXTEA
            // 
            this.cb_XXTEA.AutoSize = true;
            this.cb_XXTEA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_XXTEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_XXTEA.Location = new System.Drawing.Point(11, 309);
            this.cb_XXTEA.Margin = new System.Windows.Forms.Padding(2);
            this.cb_XXTEA.Name = "cb_XXTEA";
            this.cb_XXTEA.Size = new System.Drawing.Size(154, 24);
            this.cb_XXTEA.TabIndex = 17;
            this.cb_XXTEA.Text = "Шифр Риндаэля";
            this.cb_XXTEA.UseVisualStyleBackColor = true;
            this.cb_XXTEA.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Location = new System.Drawing.Point(0, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 467);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(548, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Сбросить пароль\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(238, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ввести";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(10, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сменить пароль\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(270, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pass
            // 
            this.pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass.Location = new System.Drawing.Point(198, 314);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(400, 29);
            this.pass.TabIndex = 5;
            this.pass.Text = "Введите пароль";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_XXTEA);
            this.Controls.Add(this.cb_RC4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textOrFile);
            this.Controls.Add(this.skitala);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.cd_Gamal);
            this.Controls.Add(this.cb_Table);
            this.Controls.Add(this.cb_Atbash);
            this.Controls.Add(this.cb_DES);
            this.Controls.Add(this.cb_Gronsfeld);
            this.Controls.Add(this.cb_RSA);
            this.Controls.Add(this.cb_Visener);
            this.Controls.Add(this.cb_Caesar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 499);
            this.MinimumSize = new System.Drawing.Size(800, 499);
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textOrFile)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_Caesar;
        private System.Windows.Forms.CheckBox cb_Visener;
        private System.Windows.Forms.CheckBox cb_RSA;
        private System.Windows.Forms.CheckBox cb_Gronsfeld;
        private System.Windows.Forms.CheckBox cb_DES;
        private System.Windows.Forms.CheckBox cb_Atbash;
        private System.Windows.Forms.CheckBox cb_Table;
        private System.Windows.Forms.CheckBox cd_Gamal;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox skitala;
        private System.Windows.Forms.TrackBar textOrFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_RC4;
        private System.Windows.Forms.CheckBox cb_XXTEA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox pass;
    }
}