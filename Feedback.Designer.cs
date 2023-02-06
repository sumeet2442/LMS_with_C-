namespace Libraray_Management_System
{
    partial class Feedback
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Contact = new System.Windows.Forms.Label();
            this.lbl_Feedback = new System.Windows.Forms.Label();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.txtbox_Phone = new System.Windows.Forms.TextBox();
            this.txtbox_Feedback = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lbl_Title.Font = new System.Drawing.Font("Old English Text MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_Title.Location = new System.Drawing.Point(190, 28);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(479, 48);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Feedback and Suggestions";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(100, 144);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(164, 30);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Your Name :-";
            // 
            // lbl_Contact
            // 
            this.lbl_Contact.AutoSize = true;
            this.lbl_Contact.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contact.Location = new System.Drawing.Point(100, 211);
            this.lbl_Contact.Name = "lbl_Contact";
            this.lbl_Contact.Size = new System.Drawing.Size(152, 30);
            this.lbl_Contact.TabIndex = 1;
            this.lbl_Contact.Text = "Phone No. :-";
            // 
            // lbl_Feedback
            // 
            this.lbl_Feedback.AutoSize = true;
            this.lbl_Feedback.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Feedback.Location = new System.Drawing.Point(101, 287);
            this.lbl_Feedback.Name = "lbl_Feedback";
            this.lbl_Feedback.Size = new System.Drawing.Size(245, 30);
            this.lbl_Feedback.TabIndex = 1;
            this.lbl_Feedback.Text = "Feedback/Suggetion :-";
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtbox_Name.Location = new System.Drawing.Point(426, 144);
            this.txtbox_Name.Multiline = true;
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(262, 32);
            this.txtbox_Name.TabIndex = 2;
            // 
            // txtbox_Phone
            // 
            this.txtbox_Phone.Location = new System.Drawing.Point(426, 209);
            this.txtbox_Phone.Multiline = true;
            this.txtbox_Phone.Name = "txtbox_Phone";
            this.txtbox_Phone.Size = new System.Drawing.Size(262, 32);
            this.txtbox_Phone.TabIndex = 2;
            // 
            // txtbox_Feedback
            // 
            this.txtbox_Feedback.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Feedback.Location = new System.Drawing.Point(426, 287);
            this.txtbox_Feedback.Multiline = true;
            this.txtbox_Feedback.Name = "txtbox_Feedback";
            this.txtbox_Feedback.Size = new System.Drawing.Size(365, 165);
            this.txtbox_Feedback.TabIndex = 2;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Submit.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(426, 474);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(169, 41);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Home.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(629, 474);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(162, 41);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(885, 540);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtbox_Feedback);
            this.Controls.Add(this.txtbox_Phone);
            this.Controls.Add(this.txtbox_Name);
            this.Controls.Add(this.lbl_Feedback);
            this.Controls.Add(this.lbl_Contact);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Feedback";
            this.Text = "Feedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.Label lbl_Feedback;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.TextBox txtbox_Phone;
        private System.Windows.Forms.TextBox txtbox_Feedback;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Home;
    }
}