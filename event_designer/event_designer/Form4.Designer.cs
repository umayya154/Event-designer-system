namespace event_designer
{
    partial class Form4
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtgq = new System.Windows.Forms.TextBox();
            this.txtpaym = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbateofevent = new System.Windows.Forms.TextBox();
            this.txtdayofevent = new System.Windows.Forms.TextBox();
            this.txtcode3 = new System.Windows.Forms.TextBox();
            this.txtcode2 = new System.Windows.Forms.TextBox();
            this.txtloct = new System.Windows.Forms.TextBox();
            this.txtname2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(292, 302);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 13);
            this.linkLabel1.TabIndex = 45;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Event Details";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pending",
            "Ok"});
            this.comboBox1.Location = new System.Drawing.Point(191, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 21);
            this.comboBox1.TabIndex = 44;
            // 
            // txtgq
            // 
            this.txtgq.Location = new System.Drawing.Point(191, 206);
            this.txtgq.Name = "txtgq";
            this.txtgq.Size = new System.Drawing.Size(83, 20);
            this.txtgq.TabIndex = 43;
            // 
            // txtpaym
            // 
            this.txtpaym.Location = new System.Drawing.Point(191, 231);
            this.txtpaym.Name = "txtpaym";
            this.txtpaym.Size = new System.Drawing.Size(83, 20);
            this.txtpaym.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Book Event";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Payment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "GuestQuantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Location";
            // 
            // txtbateofevent
            // 
            this.txtbateofevent.Location = new System.Drawing.Point(191, 50);
            this.txtbateofevent.Name = "txtbateofevent";
            this.txtbateofevent.Size = new System.Drawing.Size(83, 20);
            this.txtbateofevent.TabIndex = 36;
            // 
            // txtdayofevent
            // 
            this.txtdayofevent.Location = new System.Drawing.Point(191, 76);
            this.txtdayofevent.Name = "txtdayofevent";
            this.txtdayofevent.Size = new System.Drawing.Size(83, 20);
            this.txtdayofevent.TabIndex = 35;
            this.txtdayofevent.TextChanged += new System.EventHandler(this.txtdayofevent_TextChanged);
            // 
            // txtcode3
            // 
            this.txtcode3.Location = new System.Drawing.Point(191, 154);
            this.txtcode3.Name = "txtcode3";
            this.txtcode3.Size = new System.Drawing.Size(83, 20);
            this.txtcode3.TabIndex = 34;
            // 
            // txtcode2
            // 
            this.txtcode2.Location = new System.Drawing.Point(191, 128);
            this.txtcode2.Name = "txtcode2";
            this.txtcode2.Size = new System.Drawing.Size(83, 20);
            this.txtcode2.TabIndex = 33;
            // 
            // txtloct
            // 
            this.txtloct.Location = new System.Drawing.Point(191, 180);
            this.txtloct.Name = "txtloct";
            this.txtloct.Size = new System.Drawing.Size(83, 20);
            this.txtloct.TabIndex = 32;
            // 
            // txtname2
            // 
            this.txtname2.Location = new System.Drawing.Point(187, 12);
            this.txtname2.Name = "txtname2";
            this.txtname2.Size = new System.Drawing.Size(83, 20);
            this.txtname2.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Event Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "User Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Event Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Dateofevent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-23, -15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "User Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "User Name";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 369);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtgq);
            this.Controls.Add(this.txtpaym);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbateofevent);
            this.Controls.Add(this.txtdayofevent);
            this.Controls.Add(this.txtcode3);
            this.Controls.Add(this.txtcode2);
            this.Controls.Add(this.txtloct);
            this.Controls.Add(this.txtname2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtgq;
        private System.Windows.Forms.TextBox txtpaym;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbateofevent;
        private System.Windows.Forms.TextBox txtdayofevent;
        private System.Windows.Forms.TextBox txtcode3;
        private System.Windows.Forms.TextBox txtcode2;
        private System.Windows.Forms.TextBox txtloct;
        private System.Windows.Forms.TextBox txtname2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
    }
}