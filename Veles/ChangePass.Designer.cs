
namespace Veles
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.oldPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldPass
            // 
            this.oldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPass.Location = new System.Drawing.Point(91, 33);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(286, 29);
            this.oldPass.TabIndex = 0;
            this.oldPass.Text = "Введите старый пароль";
            this.oldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldPass.Click += new System.EventHandler(this.oldPass_Click);
            // 
            // newPass
            // 
            this.newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPass.Location = new System.Drawing.Point(91, 93);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(286, 29);
            this.newPass.TabIndex = 1;
            this.newPass.Text = "Введите новый пароль";
            this.newPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPass.Click += new System.EventHandler(this.newPass_Click);
            // 
            // change
            // 
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change.Location = new System.Drawing.Point(91, 187);
            this.change.MaximumSize = new System.Drawing.Size(285, 39);
            this.change.MinimumSize = new System.Drawing.Size(285, 39);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(285, 39);
            this.change.TabIndex = 2;
            this.change.Text = "Изменить\r\n";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.change);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.oldPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сменить пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Button change;
    }
}