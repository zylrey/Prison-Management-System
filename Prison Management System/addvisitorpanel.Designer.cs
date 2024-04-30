namespace Prison_Management_System
{
    partial class addvisitorpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addvisitorpanel));
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbInmate = new System.Windows.Forms.ComboBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtRelation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboOIC = new System.Windows.Forms.ComboBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButtonGenerate = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(30, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(563, 58);
            this.label12.TabIndex = 16;
            this.label12.Text = "Add New Visitor Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "PDL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Visitor\'s Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Contact #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Relation";
            // 
            // cbInmate
            // 
            this.cbInmate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbInmate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbInmate.FormattingEnabled = true;
            this.cbInmate.Location = new System.Drawing.Point(18, 144);
            this.cbInmate.Name = "cbInmate";
            this.cbInmate.Size = new System.Drawing.Size(353, 26);
            this.cbInmate.TabIndex = 22;
            this.cbInmate.SelectedIndexChanged += new System.EventHandler(this.CbInmate_SelectedIndexChanged);
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(18, 215);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(353, 26);
            this.txtFullname.TabIndex = 23;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(18, 282);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(353, 26);
            this.txtContact.TabIndex = 24;
            // 
            // txtRelation
            // 
            this.txtRelation.Location = new System.Drawing.Point(18, 357);
            this.txtRelation.Name = "txtRelation";
            this.txtRelation.Size = new System.Drawing.Size(353, 26);
            this.txtRelation.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Officer Incharge";
            // 
            // cboOIC
            // 
            this.cboOIC.FormattingEnabled = true;
            this.cboOIC.Location = new System.Drawing.Point(18, 422);
            this.cboOIC.Name = "cboOIC";
            this.cboOIC.Size = new System.Drawing.Size(353, 26);
            this.cboOIC.TabIndex = 37;
            this.cboOIC.SelectedIndexChanged += new System.EventHandler(this.CboOIC_SelectedIndexChanged);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(18, 74);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(592, 27);
            this.bunifuSeparator1.TabIndex = 38;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(445, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(124, 26);
            this.txtId.TabIndex = 43;
            this.txtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(431, 304);
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(100, 26);
            this.txtQRCode.TabIndex = 44;
            // 
            // pbQRCode
            // 
            this.pbQRCode.Location = new System.Drawing.Point(402, 253);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(210, 195);
            this.pbQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQRCode.TabIndex = 39;
            this.pbQRCode.TabStop = false;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Silver;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Cancel";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Red;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.Location = new System.Drawing.Point(244, 456);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(127, 41);
            this.bunifuThinButton22.TabIndex = 42;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.BunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Save";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(107, 456);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(127, 41);
            this.bunifuThinButton21.TabIndex = 41;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click_1);
            // 
            // bunifuThinButtonGenerate
            // 
            this.bunifuThinButtonGenerate.ActiveBorderThickness = 1;
            this.bunifuThinButtonGenerate.ActiveCornerRadius = 20;
            this.bunifuThinButtonGenerate.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuThinButtonGenerate.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButtonGenerate.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuThinButtonGenerate.BackColor = System.Drawing.Color.Silver;
            this.bunifuThinButtonGenerate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButtonGenerate.BackgroundImage")));
            this.bunifuThinButtonGenerate.ButtonText = "Generate QR";
            this.bunifuThinButtonGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButtonGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButtonGenerate.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuThinButtonGenerate.IdleBorderThickness = 1;
            this.bunifuThinButtonGenerate.IdleCornerRadius = 20;
            this.bunifuThinButtonGenerate.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButtonGenerate.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuThinButtonGenerate.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuThinButtonGenerate.Location = new System.Drawing.Point(445, 456);
            this.bunifuThinButtonGenerate.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButtonGenerate.Name = "bunifuThinButtonGenerate";
            this.bunifuThinButtonGenerate.Size = new System.Drawing.Size(124, 41);
            this.bunifuThinButtonGenerate.TabIndex = 40;
            this.bunifuThinButtonGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButtonGenerate.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // addvisitorpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(623, 500);
            this.Controls.Add(this.pbQRCode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuThinButtonGenerate);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.cboOIC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRelation);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.cbInmate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtQRCode);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addvisitorpanel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Addvisitorpanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbInmate;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtRelation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboOIC;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox pbQRCode;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButtonGenerate;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtQRCode;
    }
}