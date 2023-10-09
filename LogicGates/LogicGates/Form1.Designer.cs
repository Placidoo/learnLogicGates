
namespace LogicGates
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
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblGate = new System.Windows.Forms.Label();
            this.pblButtons = new System.Windows.Forms.Panel();
            this.btnXNOR = new System.Windows.Forms.Button();
            this.btnXOR = new System.Windows.Forms.Button();
            this.btnNOR = new System.Windows.Forms.Button();
            this.btnNAND = new System.Windows.Forms.Button();
            this.btnOR = new System.Windows.Forms.Button();
            this.btnAND = new System.Windows.Forms.Button();
            this.btnNOT = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.pnlChoices = new System.Windows.Forms.Panel();
            this.switchMystery = new System.Windows.Forms.PictureBox();
            this.switch3 = new System.Windows.Forms.PictureBox();
            this.switch2 = new System.Windows.Forms.PictureBox();
            this.switch1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbTable = new System.Windows.Forms.PictureBox();
            this.pbGate = new System.Windows.Forms.PictureBox();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnTrue = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlDescription.SuspendLayout();
            this.pblButtons.SuspendLayout();
            this.pnlChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchMystery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGate)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.pnlDescription.Controls.Add(this.pbTable);
            this.pnlDescription.Controls.Add(this.btnTest);
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Controls.Add(this.lblGate);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDescription.Location = new System.Drawing.Point(440, 0);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(247, 450);
            this.pnlDescription.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescription.Location = new System.Drawing.Point(16, 88);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(224, 136);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "label1";
            // 
            // lblGate
            // 
            this.lblGate.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGate.Location = new System.Drawing.Point(8, 24);
            this.lblGate.Name = "lblGate";
            this.lblGate.Size = new System.Drawing.Size(232, 48);
            this.lblGate.TabIndex = 0;
            this.lblGate.Text = "NOT GATE";
            // 
            // pblButtons
            // 
            this.pblButtons.Controls.Add(this.pictureBox1);
            this.pblButtons.Controls.Add(this.btnXNOR);
            this.pblButtons.Controls.Add(this.btnXOR);
            this.pblButtons.Controls.Add(this.btnNOR);
            this.pblButtons.Controls.Add(this.btnNAND);
            this.pblButtons.Controls.Add(this.btnOR);
            this.pblButtons.Controls.Add(this.btnAND);
            this.pblButtons.Controls.Add(this.btnNOT);
            this.pblButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pblButtons.Location = new System.Drawing.Point(0, 360);
            this.pblButtons.Name = "pblButtons";
            this.pblButtons.Size = new System.Drawing.Size(440, 90);
            this.pblButtons.TabIndex = 1;
            // 
            // btnXNOR
            // 
            this.btnXNOR.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXNOR.Location = new System.Drawing.Point(208, 48);
            this.btnXNOR.Name = "btnXNOR";
            this.btnXNOR.Size = new System.Drawing.Size(96, 32);
            this.btnXNOR.TabIndex = 0;
            this.btnXNOR.TabStop = false;
            this.btnXNOR.Text = "XNOR";
            this.btnXNOR.UseVisualStyleBackColor = true;
            this.btnXNOR.Click += new System.EventHandler(this.btnGates);
            // 
            // btnXOR
            // 
            this.btnXOR.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOR.Location = new System.Drawing.Point(112, 48);
            this.btnXOR.Name = "btnXOR";
            this.btnXOR.Size = new System.Drawing.Size(96, 32);
            this.btnXOR.TabIndex = 0;
            this.btnXOR.TabStop = false;
            this.btnXOR.Text = "XOR";
            this.btnXOR.UseVisualStyleBackColor = true;
            this.btnXOR.Click += new System.EventHandler(this.btnGates);
            // 
            // btnNOR
            // 
            this.btnNOR.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNOR.Location = new System.Drawing.Point(16, 48);
            this.btnNOR.Name = "btnNOR";
            this.btnNOR.Size = new System.Drawing.Size(96, 32);
            this.btnNOR.TabIndex = 0;
            this.btnNOR.TabStop = false;
            this.btnNOR.Text = "NOR";
            this.btnNOR.UseVisualStyleBackColor = true;
            this.btnNOR.Click += new System.EventHandler(this.btnGates);
            // 
            // btnNAND
            // 
            this.btnNAND.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNAND.Location = new System.Drawing.Point(304, 16);
            this.btnNAND.Name = "btnNAND";
            this.btnNAND.Size = new System.Drawing.Size(96, 32);
            this.btnNAND.TabIndex = 0;
            this.btnNAND.TabStop = false;
            this.btnNAND.Text = "NAND";
            this.btnNAND.UseVisualStyleBackColor = true;
            this.btnNAND.Click += new System.EventHandler(this.btnGates);
            // 
            // btnOR
            // 
            this.btnOR.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOR.Location = new System.Drawing.Point(208, 16);
            this.btnOR.Name = "btnOR";
            this.btnOR.Size = new System.Drawing.Size(96, 32);
            this.btnOR.TabIndex = 0;
            this.btnOR.TabStop = false;
            this.btnOR.Text = "OR";
            this.btnOR.UseVisualStyleBackColor = true;
            this.btnOR.Click += new System.EventHandler(this.btnGates);
            // 
            // btnAND
            // 
            this.btnAND.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAND.Location = new System.Drawing.Point(112, 16);
            this.btnAND.Name = "btnAND";
            this.btnAND.Size = new System.Drawing.Size(96, 32);
            this.btnAND.TabIndex = 0;
            this.btnAND.TabStop = false;
            this.btnAND.Text = "AND";
            this.btnAND.UseVisualStyleBackColor = true;
            this.btnAND.Click += new System.EventHandler(this.btnGates);
            // 
            // btnNOT
            // 
            this.btnNOT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNOT.Location = new System.Drawing.Point(16, 16);
            this.btnNOT.Name = "btnNOT";
            this.btnNOT.Size = new System.Drawing.Size(96, 32);
            this.btnNOT.TabIndex = 0;
            this.btnNOT.TabStop = false;
            this.btnNOT.Text = "NOT";
            this.btnNOT.UseVisualStyleBackColor = true;
            this.btnNOT.Click += new System.EventHandler(this.btnGates);
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.c.Location = new System.Drawing.Point(48, 262);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 4);
            this.c.TabIndex = 4;
            this.c.Text = "label1";
            // 
            // d
            // 
            this.d.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.d.Location = new System.Drawing.Point(144, 200);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(3, 65);
            this.d.TabIndex = 5;
            this.d.Text = "label3";
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.a.Location = new System.Drawing.Point(48, 86);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 4);
            this.a.TabIndex = 4;
            this.a.Text = "label1";
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b.Location = new System.Drawing.Point(144, 88);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(3, 78);
            this.b.TabIndex = 5;
            this.b.Text = "label3";
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.f.Location = new System.Drawing.Point(296, 182);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(100, 4);
            this.f.TabIndex = 4;
            this.f.Text = "label1";
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTest.Location = new System.Drawing.Point(96, 416);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(144, 32);
            this.btnTest.TabIndex = 0;
            this.btnTest.TabStop = false;
            this.btnTest.Text = "Test Your Knowledge";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.test);
            // 
            // pnlChoices
            // 
            this.pnlChoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.pnlChoices.Controls.Add(this.btnContinue);
            this.pnlChoices.Controls.Add(this.btnTrue);
            this.pnlChoices.Controls.Add(this.btnFalse);
            this.pnlChoices.Location = new System.Drawing.Point(0, 360);
            this.pnlChoices.Name = "pnlChoices";
            this.pnlChoices.Size = new System.Drawing.Size(688, 92);
            this.pnlChoices.TabIndex = 6;
            this.pnlChoices.Visible = false;
            // 
            // switchMystery
            // 
            this.switchMystery.Image = global::LogicGates.Properties.Resources.mystery_button;
            this.switchMystery.Location = new System.Drawing.Point(328, 8);
            this.switchMystery.Name = "switchMystery";
            this.switchMystery.Size = new System.Drawing.Size(96, 96);
            this.switchMystery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.switchMystery.TabIndex = 2;
            this.switchMystery.TabStop = false;
            this.switchMystery.Visible = false;
            // 
            // switch3
            // 
            this.switch3.Image = global::LogicGates.Properties.Resources.red_button;
            this.switch3.Location = new System.Drawing.Point(328, 136);
            this.switch3.Name = "switch3";
            this.switch3.Size = new System.Drawing.Size(96, 96);
            this.switch3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.switch3.TabIndex = 2;
            this.switch3.TabStop = false;
            // 
            // switch2
            // 
            this.switch2.Image = global::LogicGates.Properties.Resources.red_button;
            this.switch2.Location = new System.Drawing.Point(17, 216);
            this.switch2.Name = "switch2";
            this.switch2.Size = new System.Drawing.Size(96, 96);
            this.switch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.switch2.TabIndex = 2;
            this.switch2.TabStop = false;
            this.switch2.Click += new System.EventHandler(this.btnSwitch);
            // 
            // switch1
            // 
            this.switch1.Image = global::LogicGates.Properties.Resources.red_button;
            this.switch1.Location = new System.Drawing.Point(16, 40);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(96, 96);
            this.switch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.switch1.TabIndex = 2;
            this.switch1.TabStop = false;
            this.switch1.Click += new System.EventHandler(this.btnSwitch);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pbTable
            // 
            this.pbTable.Location = new System.Drawing.Point(8, 232);
            this.pbTable.Name = "pbTable";
            this.pbTable.Size = new System.Drawing.Size(232, 184);
            this.pbTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTable.TabIndex = 2;
            this.pbTable.TabStop = false;
            // 
            // pbGate
            // 
            this.pbGate.Image = ((System.Drawing.Image)(resources.GetObject("pbGate.Image")));
            this.pbGate.Location = new System.Drawing.Point(136, 112);
            this.pbGate.Name = "pbGate";
            this.pbGate.Size = new System.Drawing.Size(184, 144);
            this.pbGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGate.TabIndex = 3;
            this.pbGate.TabStop = false;
            // 
            // btnFalse
            // 
            this.btnFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnFalse.FlatAppearance.BorderSize = 0;
            this.btnFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFalse.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFalse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFalse.Location = new System.Drawing.Point(348, 22);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(176, 48);
            this.btnFalse.TabIndex = 0;
            this.btnFalse.Text = "False";
            this.btnFalse.UseVisualStyleBackColor = false;
            this.btnFalse.Click += new System.EventHandler(this.btnAnswer);
            // 
            // btnTrue
            // 
            this.btnTrue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnTrue.FlatAppearance.BorderSize = 0;
            this.btnTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTrue.Location = new System.Drawing.Point(164, 22);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(176, 48);
            this.btnTrue.TabIndex = 0;
            this.btnTrue.Text = "True";
            this.btnTrue.UseVisualStyleBackColor = false;
            this.btnTrue.Click += new System.EventHandler(this.btnAnswer);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblScore.Location = new System.Drawing.Point(592, 8);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(83, 25);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score: 0";
            this.lblScore.Visible = false;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnContinue.Location = new System.Drawing.Point(108, 22);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(472, 48);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnAnswer);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Green;
            this.lblResult.Location = new System.Drawing.Point(248, 32);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(190, 50);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "CORRECT";
            this.lblResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnlChoices);
            this.Controls.Add(this.switchMystery);
            this.Controls.Add(this.switch3);
            this.Controls.Add(this.f);
            this.Controls.Add(this.b);
            this.Controls.Add(this.d);
            this.Controls.Add(this.switch2);
            this.Controls.Add(this.switch1);
            this.Controls.Add(this.pblButtons);
            this.Controls.Add(this.pnlDescription);
            this.Controls.Add(this.pbGate);
            this.Controls.Add(this.a);
            this.Controls.Add(this.c);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logic Gates";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlDescription.ResumeLayout(false);
            this.pblButtons.ResumeLayout(false);
            this.pnlChoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.switchMystery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Panel pblButtons;
        private System.Windows.Forms.Button btnNOT;
        private System.Windows.Forms.Button btnXNOR;
        private System.Windows.Forms.Button btnXOR;
        private System.Windows.Forms.Button btnNOR;
        private System.Windows.Forms.Button btnNAND;
        private System.Windows.Forms.Button btnOR;
        private System.Windows.Forms.Button btnAND;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox switch1;
        private System.Windows.Forms.PictureBox switch2;
        private System.Windows.Forms.PictureBox switch3;
        private System.Windows.Forms.PictureBox pbGate;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label lblGate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pbTable;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Panel pnlChoices;
        private System.Windows.Forms.PictureBox switchMystery;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblResult;
    }
}

