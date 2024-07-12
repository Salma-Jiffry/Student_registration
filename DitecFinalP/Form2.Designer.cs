
namespace DitecFinalP
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.llbllog = new System.Windows.Forms.LinkLabel();
            this.lblskill = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cborg = new System.Windows.Forms.ComboBox();
            this.btndel = new System.Windows.Forms.Button();
            this.btncclearr = new System.Windows.Forms.Button();
            this.btnupd = new System.Windows.Forms.Button();
            this.btnreg = new System.Windows.Forms.Button();
            this.grppd = new System.Windows.Forms.GroupBox();
            this.txtcn = new System.Windows.Forms.TextBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.txtpn = new System.Windows.Forms.TextBox();
            this.lblcn = new System.Windows.Forms.Label();
            this.lblnic = new System.Windows.Forms.Label();
            this.lblpn = new System.Windows.Forms.Label();
            this.grpcontact = new System.Windows.Forms.GroupBox();
            this.txthp = new System.Windows.Forms.TextBox();
            this.lblhp = new System.Windows.Forms.Label();
            this.txtmp = new System.Windows.Forms.TextBox();
            this.lblmp = new System.Windows.Forms.Label();
            this.txtem = new System.Windows.Forms.TextBox();
            this.lblem = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.lbladd = new System.Windows.Forms.Label();
            this.grpbasic = new System.Windows.Forms.GroupBox();
            this.radfemale = new System.Windows.Forms.RadioButton();
            this.radmale = new System.Windows.Forms.RadioButton();
            this.lblgen = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtln = new System.Windows.Forms.TextBox();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblln = new System.Windows.Forms.Label();
            this.lblfn = new System.Windows.Forms.Label();
            this.lblrg = new System.Windows.Forms.Label();
            this.llblexit = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.grppd.SuspendLayout();
            this.grpcontact.SuspendLayout();
            this.grpbasic.SuspendLayout();
            this.SuspendLayout();
            // 
            // llbllog
            // 
            this.llbllog.AutoSize = true;
            this.llbllog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llbllog.Location = new System.Drawing.Point(12, 9);
            this.llbllog.Name = "llbllog";
            this.llbllog.Size = new System.Drawing.Size(53, 19);
            this.llbllog.TabIndex = 0;
            this.llbllog.TabStop = true;
            this.llbllog.Text = "Logout";
            this.llbllog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbllog_LinkClicked);
            // 
            // lblskill
            // 
            this.lblskill.AutoSize = true;
            this.lblskill.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblskill.Location = new System.Drawing.Point(126, 0);
            this.lblskill.Name = "lblskill";
            this.lblskill.Size = new System.Drawing.Size(321, 46);
            this.lblskill.TabIndex = 1;
            this.lblskill.Text = "Skills International";
            this.lblskill.Click += new System.EventHandler(this.lblskill_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cborg);
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btncclearr);
            this.groupBox1.Controls.Add(this.btnupd);
            this.groupBox1.Controls.Add(this.btnreg);
            this.groupBox1.Controls.Add(this.grppd);
            this.groupBox1.Controls.Add(this.grpcontact);
            this.groupBox1.Controls.Add(this.grpbasic);
            this.groupBox1.Controls.Add(this.lblrg);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(13, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 625);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Registration";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cborg
            // 
            this.cborg.FormattingEnabled = true;
            this.cborg.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "1009",
            "1010",
            "1011",
            "2002",
            "3002"});
            this.cborg.Location = new System.Drawing.Point(182, 23);
            this.cborg.Name = "cborg";
            this.cborg.Size = new System.Drawing.Size(150, 25);
            this.cborg.TabIndex = 9;
            this.cborg.SelectedIndexChanged += new System.EventHandler(this.cborg_SelectedIndexChanged_1);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(450, 578);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(71, 32);
            this.btndel.TabIndex = 8;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btncclearr
            // 
            this.btncclearr.Location = new System.Drawing.Point(357, 578);
            this.btncclearr.Name = "btncclearr";
            this.btncclearr.Size = new System.Drawing.Size(78, 32);
            this.btncclearr.TabIndex = 7;
            this.btncclearr.Text = "Clear";
            this.btncclearr.UseVisualStyleBackColor = true;
            this.btncclearr.Click += new System.EventHandler(this.btncclearr_Click);
            // 
            // btnupd
            // 
            this.btnupd.Location = new System.Drawing.Point(107, 578);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(77, 32);
            this.btnupd.TabIndex = 6;
            this.btnupd.Text = "Update";
            this.btnupd.UseVisualStyleBackColor = true;
            this.btnupd.Click += new System.EventHandler(this.btnupd_Click);
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(21, 578);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(69, 32);
            this.btnreg.TabIndex = 5;
            this.btnreg.Text = "Register";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // grppd
            // 
            this.grppd.Controls.Add(this.txtcn);
            this.grppd.Controls.Add(this.txtnic);
            this.grppd.Controls.Add(this.txtpn);
            this.grppd.Controls.Add(this.lblcn);
            this.grppd.Controls.Add(this.lblnic);
            this.grppd.Controls.Add(this.lblpn);
            this.grppd.Location = new System.Drawing.Point(21, 429);
            this.grppd.Name = "grppd";
            this.grppd.Size = new System.Drawing.Size(500, 143);
            this.grppd.TabIndex = 4;
            this.grppd.TabStop = false;
            this.grppd.Text = "Parent Details";
            // 
            // txtcn
            // 
            this.txtcn.Location = new System.Drawing.Point(161, 104);
            this.txtcn.Name = "txtcn";
            this.txtcn.Size = new System.Drawing.Size(169, 25);
            this.txtcn.TabIndex = 5;
            // 
            // txtnic
            // 
            this.txtnic.Location = new System.Drawing.Point(161, 63);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(169, 25);
            this.txtnic.TabIndex = 4;
            // 
            // txtpn
            // 
            this.txtpn.Location = new System.Drawing.Point(161, 24);
            this.txtpn.Name = "txtpn";
            this.txtpn.Size = new System.Drawing.Size(322, 25);
            this.txtpn.TabIndex = 3;
            // 
            // lblcn
            // 
            this.lblcn.AutoSize = true;
            this.lblcn.Location = new System.Drawing.Point(33, 107);
            this.lblcn.Name = "lblcn";
            this.lblcn.Size = new System.Drawing.Size(111, 19);
            this.lblcn.TabIndex = 2;
            this.lblcn.Text = "Contact Number";
            // 
            // lblnic
            // 
            this.lblnic.AutoSize = true;
            this.lblnic.Location = new System.Drawing.Point(33, 69);
            this.lblnic.Name = "lblnic";
            this.lblnic.Size = new System.Drawing.Size(32, 19);
            this.lblnic.TabIndex = 1;
            this.lblnic.Text = "NIC";
            // 
            // lblpn
            // 
            this.lblpn.AutoSize = true;
            this.lblpn.Location = new System.Drawing.Point(33, 31);
            this.lblpn.Name = "lblpn";
            this.lblpn.Size = new System.Drawing.Size(89, 19);
            this.lblpn.TabIndex = 0;
            this.lblpn.Text = "Parent Name";
            // 
            // grpcontact
            // 
            this.grpcontact.Controls.Add(this.txthp);
            this.grpcontact.Controls.Add(this.lblhp);
            this.grpcontact.Controls.Add(this.txtmp);
            this.grpcontact.Controls.Add(this.lblmp);
            this.grpcontact.Controls.Add(this.txtem);
            this.grpcontact.Controls.Add(this.lblem);
            this.grpcontact.Controls.Add(this.txtadd);
            this.grpcontact.Controls.Add(this.lbladd);
            this.grpcontact.Location = new System.Drawing.Point(21, 241);
            this.grpcontact.Name = "grpcontact";
            this.grpcontact.Size = new System.Drawing.Size(500, 182);
            this.grpcontact.TabIndex = 3;
            this.grpcontact.TabStop = false;
            this.grpcontact.Text = "Contact Details";
            // 
            // txthp
            // 
            this.txthp.Location = new System.Drawing.Point(378, 140);
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(105, 25);
            this.txthp.TabIndex = 7;
            // 
            // lblhp
            // 
            this.lblhp.AutoSize = true;
            this.lblhp.Location = new System.Drawing.Point(270, 143);
            this.lblhp.Name = "lblhp";
            this.lblhp.Size = new System.Drawing.Size(89, 19);
            this.lblhp.TabIndex = 6;
            this.lblhp.Text = "Home Phone";
            // 
            // txtmp
            // 
            this.txtmp.Location = new System.Drawing.Point(161, 140);
            this.txtmp.Name = "txtmp";
            this.txtmp.Size = new System.Drawing.Size(103, 25);
            this.txtmp.TabIndex = 5;
            // 
            // lblmp
            // 
            this.lblmp.AutoSize = true;
            this.lblmp.Location = new System.Drawing.Point(33, 146);
            this.lblmp.Name = "lblmp";
            this.lblmp.Size = new System.Drawing.Size(94, 19);
            this.lblmp.TabIndex = 4;
            this.lblmp.Text = "Mobile Phone";
            // 
            // txtem
            // 
            this.txtem.Location = new System.Drawing.Point(161, 97);
            this.txtem.Name = "txtem";
            this.txtem.Size = new System.Drawing.Size(322, 25);
            this.txtem.TabIndex = 3;
            // 
            // lblem
            // 
            this.lblem.AutoSize = true;
            this.lblem.Location = new System.Drawing.Point(33, 103);
            this.lblem.Name = "lblem";
            this.lblem.Size = new System.Drawing.Size(41, 19);
            this.lblem.TabIndex = 2;
            this.lblem.Text = "Email";
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(161, 27);
            this.txtadd.Multiline = true;
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(322, 54);
            this.txtadd.TabIndex = 1;
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Location = new System.Drawing.Point(33, 30);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(58, 19);
            this.lbladd.TabIndex = 0;
            this.lbladd.Text = "Address";
            // 
            // grpbasic
            // 
            this.grpbasic.Controls.Add(this.radfemale);
            this.grpbasic.Controls.Add(this.radmale);
            this.grpbasic.Controls.Add(this.lblgen);
            this.grpbasic.Controls.Add(this.dateTimePicker1);
            this.grpbasic.Controls.Add(this.txtln);
            this.grpbasic.Controls.Add(this.txtfn);
            this.grpbasic.Controls.Add(this.lbldob);
            this.grpbasic.Controls.Add(this.lblln);
            this.grpbasic.Controls.Add(this.lblfn);
            this.grpbasic.Location = new System.Drawing.Point(21, 54);
            this.grpbasic.Name = "grpbasic";
            this.grpbasic.Size = new System.Drawing.Size(500, 181);
            this.grpbasic.TabIndex = 2;
            this.grpbasic.TabStop = false;
            this.grpbasic.Text = "Basic Details";
            this.grpbasic.Enter += new System.EventHandler(this.grpbasic_Enter);
            // 
            // radfemale
            // 
            this.radfemale.AutoSize = true;
            this.radfemale.Location = new System.Drawing.Point(289, 144);
            this.radfemale.Name = "radfemale";
            this.radfemale.Size = new System.Drawing.Size(70, 23);
            this.radfemale.TabIndex = 8;
            this.radfemale.TabStop = true;
            this.radfemale.Text = "Female";
            this.radfemale.UseVisualStyleBackColor = true;
            // 
            // radmale
            // 
            this.radmale.AutoSize = true;
            this.radmale.Location = new System.Drawing.Point(161, 144);
            this.radmale.Name = "radmale";
            this.radmale.Size = new System.Drawing.Size(57, 23);
            this.radmale.TabIndex = 7;
            this.radmale.TabStop = true;
            this.radmale.Text = "Male";
            this.radmale.UseVisualStyleBackColor = true;
            this.radmale.CheckedChanged += new System.EventHandler(this.radmale_CheckedChanged);
            // 
            // lblgen
            // 
            this.lblgen.AutoSize = true;
            this.lblgen.Location = new System.Drawing.Point(20, 148);
            this.lblgen.Name = "lblgen";
            this.lblgen.Size = new System.Drawing.Size(54, 19);
            this.lblgen.TabIndex = 6;
            this.lblgen.Text = "Gender";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 25);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txtln
            // 
            this.txtln.Location = new System.Drawing.Point(161, 69);
            this.txtln.Name = "txtln";
            this.txtln.Size = new System.Drawing.Size(322, 25);
            this.txtln.TabIndex = 4;
            // 
            // txtfn
            // 
            this.txtfn.Location = new System.Drawing.Point(161, 26);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(322, 25);
            this.txtfn.TabIndex = 3;
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(20, 116);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(87, 19);
            this.lbldob.TabIndex = 2;
            this.lbldob.Text = "Date of Birth";
            // 
            // lblln
            // 
            this.lblln.AutoSize = true;
            this.lblln.Location = new System.Drawing.Point(21, 72);
            this.lblln.Name = "lblln";
            this.lblln.Size = new System.Drawing.Size(74, 19);
            this.lblln.TabIndex = 1;
            this.lblln.Text = "Last Name";
            // 
            // lblfn
            // 
            this.lblfn.AutoSize = true;
            this.lblfn.Location = new System.Drawing.Point(20, 32);
            this.lblfn.Name = "lblfn";
            this.lblfn.Size = new System.Drawing.Size(75, 19);
            this.lblfn.TabIndex = 0;
            this.lblfn.Text = "First Name";
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Location = new System.Drawing.Point(41, 29);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(54, 19);
            this.lblrg.TabIndex = 0;
            this.lblrg.Text = "Reg No";
            // 
            // llblexit
            // 
            this.llblexit.AutoSize = true;
            this.llblexit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llblexit.Location = new System.Drawing.Point(532, 677);
            this.llblexit.Name = "llblexit";
            this.llblexit.Size = new System.Drawing.Size(30, 19);
            this.llblexit.TabIndex = 3;
            this.llblexit.TabStop = true;
            this.llblexit.Text = "Exit";
            this.llblexit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblexit_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 723);
            this.Controls.Add(this.llblexit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblskill);
            this.Controls.Add(this.llbllog);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Student Registration - Skills International";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grppd.ResumeLayout(false);
            this.grppd.PerformLayout();
            this.grpcontact.ResumeLayout(false);
            this.grpcontact.PerformLayout();
            this.grpbasic.ResumeLayout(false);
            this.grpbasic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llbllog;
        private System.Windows.Forms.Label lblskill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btncclearr;
        private System.Windows.Forms.Button btnupd;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.GroupBox grppd;
        private System.Windows.Forms.TextBox txtcn;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.TextBox txtpn;
        private System.Windows.Forms.Label lblcn;
        private System.Windows.Forms.Label lblnic;
        private System.Windows.Forms.Label lblpn;
        private System.Windows.Forms.GroupBox grpcontact;
        private System.Windows.Forms.TextBox txthp;
        private System.Windows.Forms.Label lblhp;
        private System.Windows.Forms.TextBox txtmp;
        private System.Windows.Forms.Label lblmp;
        private System.Windows.Forms.TextBox txtem;
        private System.Windows.Forms.Label lblem;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.GroupBox grpbasic;
        private System.Windows.Forms.RadioButton radfemale;
        private System.Windows.Forms.RadioButton radmale;
        private System.Windows.Forms.Label lblgen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtln;
        private System.Windows.Forms.TextBox txtfn;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblln;
        private System.Windows.Forms.Label lblfn;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.LinkLabel llblexit;
        private System.Windows.Forms.ComboBox cborg;
    }
}