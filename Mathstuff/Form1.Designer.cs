namespace Mathstuff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblSol = new System.Windows.Forms.Label();
            this.lblAns = new System.Windows.Forms.Label();
            this.pnlcog = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.lblAnsG = new System.Windows.Forms.Label();
            this.lblSolG = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pbgraph = new System.Windows.Forms.PictureBox();
            this.btncog = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlInput.SuspendLayout();
            this.pnlcog.SuspendLayout();
            this.pnlGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbgraph)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate the Discriminant";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(346, 107);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(220, 48);
            this.lblShow.TabIndex = 1;
            this.lblShow.Text = "b² - 4ac";
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInput
            // 
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.btnCalc);
            this.pnlInput.Controls.Add(this.label6);
            this.pnlInput.Controls.Add(this.txtC);
            this.pnlInput.Controls.Add(this.label5);
            this.pnlInput.Controls.Add(this.txtA);
            this.pnlInput.Controls.Add(this.label4);
            this.pnlInput.Controls.Add(this.txtB);
            this.pnlInput.Location = new System.Drawing.Point(19, 65);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(294, 233);
            this.pnlInput.TabIndex = 9;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(22, 183);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(242, 37);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Value of c:";
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(164, 131);
            this.txtC.MaxLength = 7;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 27);
            this.txtC.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Value of a:";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(164, 81);
            this.txtA.MaxLength = 7;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 27);
            this.txtA.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Value of b:";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(164, 26);
            this.txtB.MaxLength = 7;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 27);
            this.txtB.TabIndex = 9;
            // 
            // lblSol
            // 
            this.lblSol.AutoSize = true;
            this.lblSol.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSol.Location = new System.Drawing.Point(348, 210);
            this.lblSol.Name = "lblSol";
            this.lblSol.Size = new System.Drawing.Size(309, 36);
            this.lblSol.TabIndex = 10;
            this.lblSol.Text = "Number of Solutions:";
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAns.Location = new System.Drawing.Point(348, 166);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(124, 36);
            this.lblAns.TabIndex = 11;
            this.lblAns.Text = "Answer:";
            // 
            // pnlcog
            // 
            this.pnlcog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlcog.Controls.Add(this.checkBox4);
            this.pnlcog.Controls.Add(this.label11);
            this.pnlcog.Controls.Add(this.checkBox3);
            this.pnlcog.Controls.Add(this.checkBox2);
            this.pnlcog.Controls.Add(this.checkBox1);
            this.pnlcog.Controls.Add(this.label8);
            this.pnlcog.Controls.Add(this.label7);
            this.pnlcog.Controls.Add(this.label3);
            this.pnlcog.Controls.Add(this.label2);
            this.pnlcog.Controls.Add(this.btnExit);
            this.pnlcog.Location = new System.Drawing.Point(343, 65);
            this.pnlcog.Name = "pnlcog";
            this.pnlcog.Size = new System.Drawing.Size(388, 233);
            this.pnlcog.TabIndex = 16;
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox4.Location = new System.Drawing.Point(201, 183);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(67, 35);
            this.checkBox4.TabIndex = 26;
            this.checkBox4.Text = "OFF";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 31);
            this.label11.TabIndex = 25;
            this.label11.Text = "Show graph:";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox3.Location = new System.Drawing.Point(215, 142);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(55, 35);
            this.checkBox3.TabIndex = 24;
            this.checkBox3.Text = "ON";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox2.Location = new System.Drawing.Point(241, 96);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 35);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "ON";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(189, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 35);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "OFF";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 31);
            this.label8.TabIndex = 20;
            this.label8.Text = "Show answer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "Show solutions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Dark mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 36);
            this.label2.TabIndex = 17;
            this.label2.Text = "Settings:";
            // 
            // pnlGraph
            // 
            this.pnlGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraph.Controls.Add(this.pbgraph);
            this.pnlGraph.Controls.Add(this.lblAnsG);
            this.pnlGraph.Controls.Add(this.lblSolG);
            this.pnlGraph.Controls.Add(this.label12);
            this.pnlGraph.Location = new System.Drawing.Point(19, 326);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(724, 184);
            this.pnlGraph.TabIndex = 25;
            // 
            // lblAnsG
            // 
            this.lblAnsG.AutoSize = true;
            this.lblAnsG.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAnsG.Location = new System.Drawing.Point(33, 71);
            this.lblAnsG.Name = "lblAnsG";
            this.lblAnsG.Size = new System.Drawing.Size(111, 31);
            this.lblAnsG.TabIndex = 19;
            this.lblAnsG.Text = "Answer:";
            // 
            // lblSolG
            // 
            this.lblSolG.AutoSize = true;
            this.lblSolG.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblSolG.Location = new System.Drawing.Point(33, 115);
            this.lblSolG.Name = "lblSolG";
            this.lblSolG.Size = new System.Drawing.Size(275, 31);
            this.lblSolG.TabIndex = 18;
            this.lblSolG.Text = "Number of Solutions:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 36);
            this.label12.TabIndex = 17;
            this.label12.Text = "Graph:";
            // 
            // pbgraph
            // 
            this.pbgraph.BackColor = System.Drawing.Color.Transparent;
            this.pbgraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbgraph.Location = new System.Drawing.Point(426, 9);
            this.pbgraph.Name = "pbgraph";
            this.pbgraph.Size = new System.Drawing.Size(256, 161);
            this.pbgraph.TabIndex = 26;
            this.pbgraph.TabStop = false;
            // 
            // btncog
            // 
            this.btncog.BackColor = System.Drawing.Color.Transparent;
            this.btncog.BackgroundImage = global::Mathstuff.Properties.Resources.settings;
            this.btncog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncog.FlatAppearance.BorderSize = 0;
            this.btncog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncog.ForeColor = System.Drawing.Color.Transparent;
            this.btncog.Location = new System.Drawing.Point(19, 15);
            this.btncog.Name = "btncog";
            this.btncog.Size = new System.Drawing.Size(41, 40);
            this.btncog.TabIndex = 15;
            this.btncog.UseVisualStyleBackColor = false;
            this.btncog.Click += new System.EventHandler(this.btncog_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Mathstuff.Properties.Resources.exirt;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(332, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 40);
            this.btnExit.TabIndex = 17;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 313);
            this.Controls.Add(this.pnlGraph);
            this.Controls.Add(this.btncog);
            this.Controls.Add(this.pnlcog);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.lblSol);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discriminant Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlcog.ResumeLayout(false);
            this.pnlcog.PerformLayout();
            this.pnlGraph.ResumeLayout(false);
            this.pnlGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbgraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblSol;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Button btncog;
        private System.Windows.Forms.Panel pnlcog;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAnsG;
        private System.Windows.Forms.Label lblSolG;
        private System.Windows.Forms.PictureBox pbgraph;
    }
}

