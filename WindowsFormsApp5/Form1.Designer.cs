namespace WindowsFormsApp5
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
            this.lisFName = new System.Windows.Forms.ListBox();
            this.lisLName = new System.Windows.Forms.ListBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.remBtn = new System.Windows.Forms.Button();
            this.remABtn = new System.Windows.Forms.Button();
            this.comFName = new System.Windows.Forms.ComboBox();
            this.comLName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.remACBtn = new System.Windows.Forms.Button();
            this.remCBtn = new System.Windows.Forms.Button();
            this.addCBtn = new System.Windows.Forms.Button();
            this.lblCFName = new System.Windows.Forms.Label();
            this.lblCLName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.ListBox();
            this.first = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.ListBox();
            this.lblLB1Count = new System.Windows.Forms.Label();
            this.lblLB2Count = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lisFName
            // 
            this.lisFName.FormattingEnabled = true;
            this.lisFName.Location = new System.Drawing.Point(251, 29);
            this.lisFName.Margin = new System.Windows.Forms.Padding(2);
            this.lisFName.Name = "lisFName";
            this.lisFName.Size = new System.Drawing.Size(91, 69);
            this.lisFName.TabIndex = 0;
            this.lisFName.SelectedIndexChanged += new System.EventHandler(this.lisFName_SelectedIndexChanged);
            // 
            // lisLName
            // 
            this.lisLName.FormattingEnabled = true;
            this.lisLName.Location = new System.Drawing.Point(356, 29);
            this.lisLName.Margin = new System.Windows.Forms.Padding(2);
            this.lisLName.Name = "lisLName";
            this.lisLName.Size = new System.Drawing.Size(91, 69);
            this.lisLName.TabIndex = 1;
            this.lisLName.SelectedIndexChanged += new System.EventHandler(this.lisLName_SelectedIndexChanged);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(72, 29);
            this.txtFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(93, 20);
            this.txtFname.TabIndex = 2;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(72, 62);
            this.txtLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(93, 20);
            this.txtLname.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(180, 46);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(50, 28);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name";
            // 
            // remBtn
            // 
            this.remBtn.Location = new System.Drawing.Point(468, 29);
            this.remBtn.Margin = new System.Windows.Forms.Padding(2);
            this.remBtn.Name = "remBtn";
            this.remBtn.Size = new System.Drawing.Size(75, 28);
            this.remBtn.TabIndex = 11;
            this.remBtn.Text = "remove";
            this.remBtn.UseVisualStyleBackColor = true;
            this.remBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // remABtn
            // 
            this.remABtn.Location = new System.Drawing.Point(468, 70);
            this.remABtn.Margin = new System.Windows.Forms.Padding(2);
            this.remABtn.Name = "remABtn";
            this.remABtn.Size = new System.Drawing.Size(75, 28);
            this.remABtn.TabIndex = 12;
            this.remABtn.Text = "remove All";
            this.remABtn.UseVisualStyleBackColor = true;
            this.remABtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comFName
            // 
            this.comFName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comFName.FormattingEnabled = true;
            this.comFName.Location = new System.Drawing.Point(72, 178);
            this.comFName.Margin = new System.Windows.Forms.Padding(2);
            this.comFName.Name = "comFName";
            this.comFName.Size = new System.Drawing.Size(92, 21);
            this.comFName.TabIndex = 13;
            this.comFName.SelectedIndexChanged += new System.EventHandler(this.comFName_SelectedIndexChanged);
            // 
            // comLName
            // 
            this.comLName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comLName.FormattingEnabled = true;
            this.comLName.Location = new System.Drawing.Point(72, 215);
            this.comLName.Margin = new System.Windows.Forms.Padding(2);
            this.comLName.Name = "comLName";
            this.comLName.Size = new System.Drawing.Size(92, 21);
            this.comLName.TabIndex = 14;
            this.comLName.SelectedIndexChanged += new System.EventHandler(this.comLName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "First Name";
            // 
            // remACBtn
            // 
            this.remACBtn.Location = new System.Drawing.Point(211, 213);
            this.remACBtn.Margin = new System.Windows.Forms.Padding(2);
            this.remACBtn.Name = "remACBtn";
            this.remACBtn.Size = new System.Drawing.Size(84, 28);
            this.remACBtn.TabIndex = 19;
            this.remACBtn.Text = "remove All com";
            this.remACBtn.UseVisualStyleBackColor = true;
            this.remACBtn.Click += new System.EventHandler(this.remACBtn_Click);
            // 
            // remCBtn
            // 
            this.remCBtn.Location = new System.Drawing.Point(212, 174);
            this.remCBtn.Margin = new System.Windows.Forms.Padding(2);
            this.remCBtn.Name = "remCBtn";
            this.remCBtn.Size = new System.Drawing.Size(84, 28);
            this.remCBtn.TabIndex = 18;
            this.remCBtn.Text = "remove com";
            this.remCBtn.UseVisualStyleBackColor = true;
            this.remCBtn.Click += new System.EventHandler(this.remCBtn_Click);
            // 
            // addCBtn
            // 
            this.addCBtn.Location = new System.Drawing.Point(553, 30);
            this.addCBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addCBtn.Name = "addCBtn";
            this.addCBtn.Size = new System.Drawing.Size(34, 27);
            this.addCBtn.TabIndex = 17;
            this.addCBtn.Text = ">";
            this.addCBtn.UseVisualStyleBackColor = true;
            this.addCBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblCFName
            // 
            this.lblCFName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblCFName.AutoSize = true;
            this.lblCFName.Location = new System.Drawing.Point(177, 218);
            this.lblCFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCFName.Name = "lblCFName";
            this.lblCFName.Size = new System.Drawing.Size(0, 13);
            this.lblCFName.TabIndex = 20;
            // 
            // lblCLName
            // 
            this.lblCLName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblCLName.AutoSize = true;
            this.lblCLName.Location = new System.Drawing.Point(177, 182);
            this.lblCLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCLName.Name = "lblCLName";
            this.lblCLName.Size = new System.Drawing.Size(0, 13);
            this.lblCLName.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 26);
            this.button1.TabIndex = 22;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 24);
            this.button2.TabIndex = 24;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 173);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 29);
            this.button3.TabIndex = 23;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "First Name";
            // 
            // last
            // 
            this.last.FormattingEnabled = true;
            this.last.Location = new System.Drawing.Point(477, 172);
            this.last.Margin = new System.Windows.Forms.Padding(2);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(91, 69);
            this.last.TabIndex = 26;
            this.last.SelectedIndexChanged += new System.EventHandler(this.last_SelectedIndexChanged);
            // 
            // first
            // 
            this.first.FormattingEnabled = true;
            this.first.Location = new System.Drawing.Point(372, 172);
            this.first.Margin = new System.Windows.Forms.Padding(2);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(91, 69);
            this.first.TabIndex = 25;
            this.first.SelectedIndexChanged += new System.EventHandler(this.first_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(633, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "full name";
            // 
            // fullname
            // 
            this.fullname.FormattingEnabled = true;
            this.fullname.Location = new System.Drawing.Point(587, 172);
            this.fullname.Margin = new System.Windows.Forms.Padding(2);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(168, 69);
            this.fullname.TabIndex = 29;
            this.fullname.SelectedIndexChanged += new System.EventHandler(this.fullname_SelectedIndexChanged);
            // 
            // lblLB1Count
            // 
            this.lblLB1Count.AutoSize = true;
            this.lblLB1Count.Location = new System.Drawing.Point(297, 102);
            this.lblLB1Count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLB1Count.Name = "lblLB1Count";
            this.lblLB1Count.Size = new System.Drawing.Size(0, 13);
            this.lblLB1Count.TabIndex = 7;
            // 
            // lblLB2Count
            // 
            this.lblLB2Count.AutoSize = true;
            this.lblLB2Count.Location = new System.Drawing.Point(410, 102);
            this.lblLB2Count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLB2Count.Name = "lblLB2Count";
            this.lblLB2Count.Size = new System.Drawing.Size(0, 13);
            this.lblLB2Count.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(410, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(518, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 324);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCLName);
            this.Controls.Add(this.lblCFName);
            this.Controls.Add(this.remACBtn);
            this.Controls.Add(this.remCBtn);
            this.Controls.Add(this.addCBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comLName);
            this.Controls.Add(this.comFName);
            this.Controls.Add(this.remABtn);
            this.Controls.Add(this.remBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLB2Count);
            this.Controls.Add(this.lblLB1Count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lisLName);
            this.Controls.Add(this.lisFName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lisFName;
        private System.Windows.Forms.ListBox lisLName;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button remBtn;
        private System.Windows.Forms.Button remABtn;
        private System.Windows.Forms.ComboBox comFName;
        private System.Windows.Forms.ComboBox comLName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button remACBtn;
        private System.Windows.Forms.Button remCBtn;
        private System.Windows.Forms.Button addCBtn;
        private System.Windows.Forms.Label lblCFName;
        private System.Windows.Forms.Label lblCLName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox last;
        private System.Windows.Forms.ListBox first;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox fullname;
        private System.Windows.Forms.Label lblLB1Count;
        private System.Windows.Forms.Label lblLB2Count;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

