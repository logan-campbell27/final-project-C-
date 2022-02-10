
namespace hospitalGUI
{
    partial class Form2
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
            this.index_txt = new System.Windows.Forms.TextBox();
            this.indexButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // index_txt
            // 
            this.index_txt.Location = new System.Drawing.Point(94, 22);
            this.index_txt.Name = "index_txt";
            this.index_txt.Size = new System.Drawing.Size(100, 20);
            this.index_txt.TabIndex = 0;
            // 
            // indexButton
            // 
            this.indexButton.Location = new System.Drawing.Point(94, 72);
            this.indexButton.Name = "indexButton";
            this.indexButton.Size = new System.Drawing.Size(100, 23);
            this.indexButton.TabIndex = 1;
            this.indexButton.Text = "OK";
            this.indexButton.UseVisualStyleBackColor = true;
            this.indexButton.Click += new System.EventHandler(this.indexButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 121);
            this.Controls.Add(this.indexButton);
            this.Controls.Add(this.index_txt);
            this.Name = "Form2";
            this.Text = "Enter ID Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox index_txt;
        private System.Windows.Forms.Button indexButton;
    }
}