namespace Prison_Management_System
{
    partial class dashboardpanel
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.prisoncount = new System.Windows.Forms.Label();
            this.cellcounts = new System.Windows.Forms.Label();
            this.crimecounts = new System.Windows.Forms.Label();
            this.actioncounts = new System.Windows.Forms.Label();
            this.inmatecounts = new System.Windows.Forms.Label();
            this.releasecounts = new System.Windows.Forms.Label();
            this.timerPrison = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.visitcounts = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "DASHBOARD";
            // 
            // prisoncount
            // 
            this.prisoncount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prisoncount.AutoSize = true;
            this.prisoncount.BackColor = System.Drawing.Color.Transparent;
            this.prisoncount.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisoncount.Location = new System.Drawing.Point(237, 157);
            this.prisoncount.Name = "prisoncount";
            this.prisoncount.Size = new System.Drawing.Size(30, 32);
            this.prisoncount.TabIndex = 12;
            this.prisoncount.Text = "0";
            this.prisoncount.Click += new System.EventHandler(this.prisoncount_Click);
            // 
            // cellcounts
            // 
            this.cellcounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cellcounts.AutoSize = true;
            this.cellcounts.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellcounts.Location = new System.Drawing.Point(538, 157);
            this.cellcounts.Name = "cellcounts";
            this.cellcounts.Size = new System.Drawing.Size(30, 32);
            this.cellcounts.TabIndex = 13;
            this.cellcounts.Text = "0";
            // 
            // crimecounts
            // 
            this.crimecounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crimecounts.AutoSize = true;
            this.crimecounts.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crimecounts.Location = new System.Drawing.Point(843, 157);
            this.crimecounts.Name = "crimecounts";
            this.crimecounts.Size = new System.Drawing.Size(30, 32);
            this.crimecounts.TabIndex = 14;
            this.crimecounts.Text = "0";
            // 
            // actioncounts
            // 
            this.actioncounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actioncounts.AutoSize = true;
            this.actioncounts.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actioncounts.Location = new System.Drawing.Point(1144, 157);
            this.actioncounts.Name = "actioncounts";
            this.actioncounts.Size = new System.Drawing.Size(30, 32);
            this.actioncounts.TabIndex = 15;
            this.actioncounts.Text = "0";
            // 
            // inmatecounts
            // 
            this.inmatecounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inmatecounts.AutoSize = true;
            this.inmatecounts.BackColor = System.Drawing.Color.Transparent;
            this.inmatecounts.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inmatecounts.Location = new System.Drawing.Point(237, 281);
            this.inmatecounts.Name = "inmatecounts";
            this.inmatecounts.Size = new System.Drawing.Size(30, 32);
            this.inmatecounts.TabIndex = 16;
            this.inmatecounts.Text = "0";
            // 
            // releasecounts
            // 
            this.releasecounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.releasecounts.AutoSize = true;
            this.releasecounts.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releasecounts.Location = new System.Drawing.Point(538, 281);
            this.releasecounts.Name = "releasecounts";
            this.releasecounts.Size = new System.Drawing.Size(30, 32);
            this.releasecounts.TabIndex = 17;
            this.releasecounts.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Prison_Management_System.Properties.Resources.cover;
            this.pictureBox1.Location = new System.Drawing.Point(12, 356);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1237, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 14.25F);
            this.button7.Image = global::Prison_Management_System.Properties.Resources.icons8_docx_64;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(617, 224);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(278, 99);
            this.button7.TabIndex = 9;
            this.button7.Text = "Today\'s Visits";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 14.25F);
            this.button6.Image = global::Prison_Management_System.Properties.Resources.icons8_user_50;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(314, 224);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(278, 99);
            this.button6.TabIndex = 8;
            this.button6.Text = "Released Inmates";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.button5.Image = global::Prison_Management_System.Properties.Resources.icons8_user_50;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(12, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(278, 99);
            this.button5.TabIndex = 7;
            this.button5.Text = "Current Inmates";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F);
            this.button4.Image = global::Prison_Management_System.Properties.Resources.icons8_action_50;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(919, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(278, 99);
            this.button4.TabIndex = 6;
            this.button4.Text = "Action";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.button3.Image = global::Prison_Management_System.Properties.Resources.icons8_no_weapons_50;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(617, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 99);
            this.button3.TabIndex = 5;
            this.button3.Text = "Case";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.button2.Image = global::Prison_Management_System.Properties.Resources.icons8_grid_3_50;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(314, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 99);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cell Block";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Prison_Management_System.Properties.Resources.icons8_password_50;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 99);
            this.button1.TabIndex = 3;
            this.button1.Text = "Prison List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // visitcounts
            // 
            this.visitcounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitcounts.AutoSize = true;
            this.visitcounts.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitcounts.Location = new System.Drawing.Point(843, 281);
            this.visitcounts.Name = "visitcounts";
            this.visitcounts.Size = new System.Drawing.Size(30, 32);
            this.visitcounts.TabIndex = 18;
            this.visitcounts.Text = "0";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 71);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1237, 22);
            this.bunifuSeparator1.TabIndex = 76;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // dashboardpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 698);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.visitcounts);
            this.Controls.Add(this.releasecounts);
            this.Controls.Add(this.inmatecounts);
            this.Controls.Add(this.actioncounts);
            this.Controls.Add(this.crimecounts);
            this.Controls.Add(this.cellcounts);
            this.Controls.Add(this.prisoncount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboardpanel";
            this.ShowIcon = false;
            this.Text = "dashboardpanel";
            this.Load += new System.EventHandler(this.Dashboardpanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label prisoncount;
        private System.Windows.Forms.Label cellcounts;
        private System.Windows.Forms.Label crimecounts;
        private System.Windows.Forms.Label actioncounts;
        private System.Windows.Forms.Label inmatecounts;
        private System.Windows.Forms.Label releasecounts;
        private System.Windows.Forms.Timer timerPrison;
        private System.Windows.Forms.Label visitcounts;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}