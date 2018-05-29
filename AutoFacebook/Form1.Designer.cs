namespace AutoFacebook
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
            this.btnPost = new System.Windows.Forms.Button();
            this.wvMain = new System.Windows.Forms.WebBrowser();
            this.btnFacebookLogin = new System.Windows.Forms.Button();
            this.btnGetFriend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(970, 518);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(133, 34);
            this.btnPost.TabIndex = 0;
            this.btnPost.Text = "POST TO WALL";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // wvMain
            // 
            this.wvMain.Location = new System.Drawing.Point(12, 43);
            this.wvMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvMain.Name = "wvMain";
            this.wvMain.Size = new System.Drawing.Size(1091, 469);
            this.wvMain.TabIndex = 1;
            this.wvMain.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wvMain_Navigated);
            // 
            // btnFacebookLogin
            // 
            this.btnFacebookLogin.Location = new System.Drawing.Point(12, 13);
            this.btnFacebookLogin.Name = "btnFacebookLogin";
            this.btnFacebookLogin.Size = new System.Drawing.Size(146, 23);
            this.btnFacebookLogin.TabIndex = 2;
            this.btnFacebookLogin.Text = "FACEBOOK LOGIN";
            this.btnFacebookLogin.UseVisualStyleBackColor = true;
            this.btnFacebookLogin.Click += new System.EventHandler(this.btnFacebookLogin_Click);
            // 
            // btnGetFriend
            // 
            this.btnGetFriend.Location = new System.Drawing.Point(164, 12);
            this.btnGetFriend.Name = "btnGetFriend";
            this.btnGetFriend.Size = new System.Drawing.Size(90, 23);
            this.btnGetFriend.TabIndex = 3;
            this.btnGetFriend.Text = "GET FRIENDS";
            this.btnGetFriend.UseVisualStyleBackColor = true;
            this.btnGetFriend.Click += new System.EventHandler(this.btnGetFriend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Link :";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(300, 17);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(0, 13);
            this.lblLink.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 564);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetFriend);
            this.Controls.Add(this.btnFacebookLogin);
            this.Controls.Add(this.wvMain);
            this.Controls.Add(this.btnPost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.WebBrowser wvMain;
        private System.Windows.Forms.Button btnFacebookLogin;
        private System.Windows.Forms.Button btnGetFriend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLink;
    }
}

