namespace Prison_Management_System
{
    partial class frmVisitScan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitScan));
            this.txtID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bTxtfname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bTxtcontact = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bTxtRelation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(12, 292);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(289, 31);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtID_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(347, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 58);
            this.label1.TabIndex = 75;
            this.label1.Text = "Visitation Scanner";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(437, 70);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 25);
            this.lblDate.TabIndex = 76;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(527, 97);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(59, 25);
            this.lblTime.TabIndex = 77;
            this.lblTime.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 81;
            this.label2.Text = "Fullname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 82;
            this.label3.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 83;
            this.label4.Text = "Relation:";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Clear";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(504, 289);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 84;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // bTxtfname
            // 
            this.bTxtfname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bTxtfname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bTxtfname.ForeColor = System.Drawing.Color.White;
            this.bTxtfname.HintForeColor = System.Drawing.Color.Empty;
            this.bTxtfname.HintText = "";
            this.bTxtfname.isPassword = false;
            this.bTxtfname.LineFocusedColor = System.Drawing.Color.Blue;
            this.bTxtfname.LineIdleColor = System.Drawing.Color.Gray;
            this.bTxtfname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bTxtfname.LineThickness = 3;
            this.bTxtfname.Location = new System.Drawing.Point(420, 127);
            this.bTxtfname.Margin = new System.Windows.Forms.Padding(4);
            this.bTxtfname.Name = "bTxtfname";
            this.bTxtfname.Size = new System.Drawing.Size(370, 44);
            this.bTxtfname.TabIndex = 85;
            this.bTxtfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bTxtcontact
            // 
            this.bTxtcontact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bTxtcontact.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bTxtcontact.ForeColor = System.Drawing.Color.White;
            this.bTxtcontact.HintForeColor = System.Drawing.Color.Empty;
            this.bTxtcontact.HintText = "";
            this.bTxtcontact.isPassword = false;
            this.bTxtcontact.LineFocusedColor = System.Drawing.Color.Blue;
            this.bTxtcontact.LineIdleColor = System.Drawing.Color.Gray;
            this.bTxtcontact.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bTxtcontact.LineThickness = 3;
            this.bTxtcontact.Location = new System.Drawing.Point(420, 180);
            this.bTxtcontact.Margin = new System.Windows.Forms.Padding(4);
            this.bTxtcontact.Name = "bTxtcontact";
            this.bTxtcontact.Size = new System.Drawing.Size(370, 44);
            this.bTxtcontact.TabIndex = 86;
            this.bTxtcontact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bTxtRelation
            // 
            this.bTxtRelation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bTxtRelation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bTxtRelation.ForeColor = System.Drawing.Color.White;
            this.bTxtRelation.HintForeColor = System.Drawing.Color.Empty;
            this.bTxtRelation.HintText = "";
            this.bTxtRelation.isPassword = false;
            this.bTxtRelation.LineFocusedColor = System.Drawing.Color.Blue;
            this.bTxtRelation.LineIdleColor = System.Drawing.Color.Gray;
            this.bTxtRelation.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bTxtRelation.LineThickness = 3;
            this.bTxtRelation.Location = new System.Drawing.Point(420, 233);
            this.bTxtRelation.Margin = new System.Windows.Forms.Padding(4);
            this.bTxtRelation.Name = "bTxtRelation";
            this.bTxtRelation.Size = new System.Drawing.Size(370, 44);
            this.bTxtRelation.TabIndex = 87;
            this.bTxtRelation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frmVisitScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(810, 331);
            this.Controls.Add(this.bTxtRelation);
            this.Controls.Add(this.bTxtcontact);
            this.Controls.Add(this.bTxtfname);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisitScan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisitScan";
            this.Load += new System.EventHandler(this.FrmVisitScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bTxtfname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bTxtcontact;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bTxtRelation;
    }
}