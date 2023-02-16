namespace Project1
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.txtUseName = new System.Windows.Forms.TextBox();
            this.lblUseName = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.checkbox_GhiNho = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUseName
            // 
            resources.ApplyResources(this.txtUseName, "txtUseName");
            this.txtUseName.Name = "txtUseName";
            // 
            // lblUseName
            // 
            resources.ApplyResources(this.lblUseName, "lblUseName");
            this.lblUseName.BackColor = System.Drawing.Color.Transparent;
            this.lblUseName.ForeColor = System.Drawing.Color.Black;
            this.lblUseName.Name = "lblUseName";
            // 
            // txtPass
            // 
            resources.ApplyResources(this.txtPass, "txtPass");
            this.txtPass.Name = "txtPass";
            // 
            // lblPassWord
            // 
            resources.ApplyResources(this.lblPassWord, "lblPassWord");
            this.lblPassWord.BackColor = System.Drawing.Color.Transparent;
            this.lblPassWord.ForeColor = System.Drawing.Color.Black;
            this.lblPassWord.Name = "lblPassWord";
            // 
            // checkbox_GhiNho
            // 
            resources.ApplyResources(this.checkbox_GhiNho, "checkbox_GhiNho");
            this.checkbox_GhiNho.BackColor = System.Drawing.Color.Transparent;
            this.checkbox_GhiNho.ForeColor = System.Drawing.Color.Black;
            this.checkbox_GhiNho.Name = "checkbox_GhiNho";
            this.checkbox_GhiNho.UseVisualStyleBackColor = false;
            this.checkbox_GhiNho.CheckedChanged += new System.EventHandler(this.checkbox_GhiNho_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // Form_Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.checkbox_GhiNho);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblUseName);
            this.Controls.Add(this.txtUseName);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUseName;
        private System.Windows.Forms.Label lblUseName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.CheckBox checkbox_GhiNho;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
    }
}

