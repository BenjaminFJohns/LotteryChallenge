namespace Lottery.Challenge
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
            this.chkBonusBall = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBoxBonus = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBonusBall
            // 
            this.chkBonusBall.AutoSize = true;
            this.chkBonusBall.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBonusBall.Location = new System.Drawing.Point(37, 40);
            this.chkBonusBall.Name = "chkBonusBall";
            this.chkBonusBall.Size = new System.Drawing.Size(74, 17);
            this.chkBonusBall.TabIndex = 0;
            this.chkBonusBall.Text = "Bonus Ball";
            this.chkBonusBall.UseVisualStyleBackColor = true;
            this.chkBonusBall.CheckedChanged += new System.EventHandler(this.chkBonusBall_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(37, 63);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(143, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(194, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(245, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 21);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(296, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(43, 21);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(347, 66);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(43, 21);
            this.textBox5.TabIndex = 6;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(398, 66);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(43, 21);
            this.textBox6.TabIndex = 7;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxBonus
            // 
            this.textBoxBonus.Location = new System.Drawing.Point(25, 35);
            this.textBoxBonus.Name = "textBoxBonus";
            this.textBoxBonus.Size = new System.Drawing.Size(43, 21);
            this.textBoxBonus.TabIndex = 8;
            this.textBoxBonus.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxBonus);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(458, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 58);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bonus Ball:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lottery Number Generator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 98);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.chkBonusBall);
            this.Name = "Form1";
            this.Text = "Lottery Number Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBonusBall;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBoxBonus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

