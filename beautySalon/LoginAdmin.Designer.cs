
namespace beautySalon
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            this.panelLoginAdmin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.panelLoginAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoginAdmin
            // 
            this.panelLoginAdmin.BackColor = System.Drawing.Color.White;
            this.panelLoginAdmin.Controls.Add(this.btnLogin);
            this.panelLoginAdmin.Controls.Add(this.txtCode);
            this.panelLoginAdmin.Controls.Add(this.btnClose);
            this.panelLoginAdmin.Controls.Add(this.lblCode);
            this.panelLoginAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginAdmin.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.panelLoginAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelLoginAdmin.Name = "panelLoginAdmin";
            this.panelLoginAdmin.Size = new System.Drawing.Size(403, 188);
            this.panelLoginAdmin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(125, 136);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 31);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(86, 88);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(199, 26);
            this.txtCode.TabIndex = 8;
            this.txtCode.UseSystemPasswordChar = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(352, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(36, 32);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(301, 36);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Введите пожалуйста код, \r\nчтобы мы поняли, что Вы администратор:";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 188);
            this.Controls.Add(this.panelLoginAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginAdmin";
            this.Load += new System.EventHandler(this.LoginAdmin_Load);
            this.panelLoginAdmin.ResumeLayout(false);
            this.panelLoginAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoginAdmin;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnLogin;
    }
}