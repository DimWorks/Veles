
namespace Veles
{
    partial class Output
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Output));
            this.sometext = new System.Windows.Forms.TextBox();
            this.hat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sometext
            // 
            this.sometext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sometext.Location = new System.Drawing.Point(2, 36);
            this.sometext.Multiline = true;
            this.sometext.Name = "sometext";
            this.sometext.Size = new System.Drawing.Size(480, 276);
            this.sometext.TabIndex = 0;
            // 
            // hat
            // 
            this.hat.AutoSize = true;
            this.hat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hat.Location = new System.Drawing.Point(12, 9);
            this.hat.Name = "hat";
            this.hat.Size = new System.Drawing.Size(0, 24);
            this.hat.TabIndex = 1;
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.hat);
            this.Controls.Add(this.sometext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Output";
            this.Text = "Output";
            this.Load += new System.EventHandler(this.Output_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sometext;
        public System.Windows.Forms.Label hat;
    }
}