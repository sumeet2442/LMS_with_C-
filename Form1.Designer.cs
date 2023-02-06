namespace Libraray_Management_System
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.bt_Donate = new System.Windows.Forms.Button();
            this.bt_Lease = new System.Windows.Forms.Button();
            this.bt_Return = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picbox_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Black;
            this.lbl_Title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Title.Location = new System.Drawing.Point(387, 44);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(366, 61);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Shelfish Library";
            this.lbl_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_Desc.Location = new System.Drawing.Point(240, 147);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(558, 56);
            this.lbl_Desc.TabIndex = 2;
            this.lbl_Desc.Text = "Welcome to Shelfish Libray Mangment System\r\n\r\n";
            this.lbl_Desc.Click += new System.EventHandler(this.label2_Click);
            // 
            // bt_Donate
            // 
            this.bt_Donate.BackColor = System.Drawing.Color.PaleVioletRed;
            this.bt_Donate.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Donate.Location = new System.Drawing.Point(92, 242);
            this.bt_Donate.Name = "bt_Donate";
            this.bt_Donate.Size = new System.Drawing.Size(156, 41);
            this.bt_Donate.TabIndex = 3;
            this.bt_Donate.Text = "Add/Donate";
            this.bt_Donate.UseVisualStyleBackColor = false;
            this.bt_Donate.Click += new System.EventHandler(this.bt_Donate_Click);
            // 
            // bt_Lease
            // 
            this.bt_Lease.BackColor = System.Drawing.Color.MediumTurquoise;
            this.bt_Lease.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Lease.Location = new System.Drawing.Point(92, 321);
            this.bt_Lease.Name = "bt_Lease";
            this.bt_Lease.Size = new System.Drawing.Size(156, 41);
            this.bt_Lease.TabIndex = 3;
            this.bt_Lease.Text = "Lease";
            this.bt_Lease.UseVisualStyleBackColor = false;
            this.bt_Lease.Click += new System.EventHandler(this.bt_Lease_Click);
            // 
            // bt_Return
            // 
            this.bt_Return.BackColor = System.Drawing.Color.PaleVioletRed;
            this.bt_Return.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Return.Location = new System.Drawing.Point(92, 404);
            this.bt_Return.Name = "bt_Return";
            this.bt_Return.Size = new System.Drawing.Size(156, 46);
            this.bt_Return.TabIndex = 3;
            this.bt_Return.Text = "Return";
            this.bt_Return.UseVisualStyleBackColor = false;
            this.bt_Return.Click += new System.EventHandler(this.bt_Return_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button4.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(92, 493);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Feedback";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Libraray_Management_System.Properties.Resources.minimal_library___Copy;
            this.pictureBox1.Location = new System.Drawing.Point(343, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // picbox_Logo
            // 
            this.picbox_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox_Logo.Image = global::Libraray_Management_System.Properties.Resources.log;
            this.picbox_Logo.Location = new System.Drawing.Point(273, 44);
            this.picbox_Logo.Name = "picbox_Logo";
            this.picbox_Logo.Size = new System.Drawing.Size(94, 63);
            this.picbox_Logo.TabIndex = 1;
            this.picbox_Logo.TabStop = false;
            this.picbox_Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Exit.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(807, 556);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(156, 41);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1084, 609);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bt_Return);
            this.Controls.Add(this.bt_Lease);
            this.Controls.Add(this.bt_Donate);
            this.Controls.Add(this.lbl_Desc);
            this.Controls.Add(this.picbox_Logo);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox picbox_Logo;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.Button bt_Donate;
        private System.Windows.Forms.Button bt_Lease;
        private System.Windows.Forms.Button bt_Return;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Exit;
    }
}

