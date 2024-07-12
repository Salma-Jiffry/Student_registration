
namespace DitecFinalP
{
    partial class frmlog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlog));
            this.lblsi = new System.Windows.Forms.Label();
            this.grplog = new System.Windows.Forms.GroupBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtun = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblun = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.grplog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsi
            // 
            this.lblsi.AutoSize = true;
            this.lblsi.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsi.Location = new System.Drawing.Point(151, 162);
            this.lblsi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsi.Name = "lblsi";
            this.lblsi.Size = new System.Drawing.Size(299, 45);
            this.lblsi.TabIndex = 0;
            this.lblsi.Text = "Skills International";
            this.lblsi.Click += new System.EventHandler(this.lblsi_Click);
            // 
            // grplog
            // 
            this.grplog.Controls.Add(this.btnlogin);
            this.grplog.Controls.Add(this.btnclear);
            this.grplog.Controls.Add(this.txtpass);
            this.grplog.Controls.Add(this.txtun);
            this.grplog.Controls.Add(this.lblpass);
            this.grplog.Controls.Add(this.lblun);
            this.grplog.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grplog.Location = new System.Drawing.Point(82, 223);
            this.grplog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grplog.Name = "grplog";
            this.grplog.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grplog.Size = new System.Drawing.Size(427, 242);
            this.grplog.TabIndex = 1;
            this.grplog.TabStop = false;
            this.grplog.Text = "Login";
            this.grplog.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(291, 186);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(102, 34);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(40, 186);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(93, 34);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(174, 119);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '#';
            this.txtpass.Size = new System.Drawing.Size(217, 27);
            this.txtpass.TabIndex = 3;
            // 
            // txtun
            // 
            this.txtun.Location = new System.Drawing.Point(174, 52);
            this.txtun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(217, 27);
            this.txtun.TabIndex = 2;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(40, 128);
            this.lblpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(70, 20);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Password";
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.Location = new System.Drawing.Point(40, 61);
            this.lblun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(75, 20);
            this.lblun.TabIndex = 0;
            this.lblun.Text = "Username";
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnexit.Location = new System.Drawing.Point(15, 494);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(96, 41);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // piclogo
            // 
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(198, 15);
            this.piclogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(201, 143);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 3;
            this.piclogo.TabStop = false;
            // 
            // frmlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 559);
            this.Controls.Add(this.piclogo);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.grplog);
            this.Controls.Add(this.lblsi);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlog";
            this.Text = "Login - Skills International";
            this.grplog.ResumeLayout(false);
            this.grplog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsi;
        private System.Windows.Forms.GroupBox grplog;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox piclogo;
    }
}

