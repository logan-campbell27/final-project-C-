
namespace hospitalGUI
{
    partial class Form1
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
            this.surgeryName_txt = new System.Windows.Forms.TextBox();
            this.surgeonName_txt = new System.Windows.Forms.TextBox();
            this.result_txt = new System.Windows.Forms.TextBox();
            this.cost_txt = new System.Windows.Forms.TextBox();
            this.risk_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.availableBox = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // surgeryName_txt
            // 
            this.surgeryName_txt.Location = new System.Drawing.Point(1878, 21);
            this.surgeryName_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surgeryName_txt.Name = "surgeryName_txt";
            this.surgeryName_txt.Size = new System.Drawing.Size(300, 31);
            this.surgeryName_txt.TabIndex = 1;
            // 
            // surgeonName_txt
            // 
            this.surgeonName_txt.Location = new System.Drawing.Point(1878, 127);
            this.surgeonName_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surgeonName_txt.Name = "surgeonName_txt";
            this.surgeonName_txt.Size = new System.Drawing.Size(300, 31);
            this.surgeonName_txt.TabIndex = 2;
            // 
            // result_txt
            // 
            this.result_txt.Location = new System.Drawing.Point(1878, 233);
            this.result_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.result_txt.Name = "result_txt";
            this.result_txt.Size = new System.Drawing.Size(300, 31);
            this.result_txt.TabIndex = 3;
            // 
            // cost_txt
            // 
            this.cost_txt.Location = new System.Drawing.Point(1878, 340);
            this.cost_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cost_txt.Name = "cost_txt";
            this.cost_txt.Size = new System.Drawing.Size(300, 31);
            this.cost_txt.TabIndex = 4;
            // 
            // risk_txt
            // 
            this.risk_txt.Location = new System.Drawing.Point(1878, 446);
            this.risk_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.risk_txt.Name = "risk_txt";
            this.risk_txt.Size = new System.Drawing.Size(300, 31);
            this.risk_txt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1874, 608);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 79);
            this.button1.TabIndex = 7;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2042, 608);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 79);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1874, 694);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 79);
            this.button3.TabIndex = 9;
            this.button3.Text = "Replace";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(2042, 694);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 79);
            this.button4.TabIndex = 10;
            this.button4.Text = "Change Availabiility";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1682, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Surgery Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1744, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Surgeon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1770, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1782, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1640, 448);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Chance Of Survival:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1730, 554);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Available:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1706, 694);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 79);
            this.button5.TabIndex = 17;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1706, 608);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 79);
            this.button6.TabIndex = 18;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // availableBox
            // 
            this.availableBox.AutoSize = true;
            this.availableBox.Location = new System.Drawing.Point(1878, 554);
            this.availableBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.availableBox.Name = "availableBox";
            this.availableBox.Size = new System.Drawing.Size(216, 29);
            this.availableBox.TabIndex = 19;
            this.availableBox.Text = "Check If Available";
            this.availableBox.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(24, 23);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1568, 829);
            this.listBox1.TabIndex = 20;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1706, 790);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 79);
            this.button7.TabIndex = 21;
            this.button7.Text = "Save Inventory";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(2042, 790);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 79);
            this.button8.TabIndex = 22;
            this.button8.Text = "Load Inventory";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1878, 790);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(136, 79);
            this.button9.TabIndex = 23;
            this.button9.Text = "Exit";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2264, 888);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.availableBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.risk_txt);
            this.Controls.Add(this.cost_txt);
            this.Controls.Add(this.result_txt);
            this.Controls.Add(this.surgeonName_txt);
            this.Controls.Add(this.surgeryName_txt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox surgeryName_txt;
        private System.Windows.Forms.TextBox surgeonName_txt;
        private System.Windows.Forms.TextBox result_txt;
        private System.Windows.Forms.TextBox cost_txt;
        private System.Windows.Forms.TextBox risk_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox availableBox;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

