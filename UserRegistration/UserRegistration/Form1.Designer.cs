namespace UserRegistration
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
            this.FirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Adress = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.Label();
            this.txtUserPasswordConfirm = new System.Windows.Forms.TextBox();
            this.UserPasswordConfirm = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(129, 71);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(84, 20);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(211, 68);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(251, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(211, 139);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(251, 26);
            this.txtLastName.TabIndex = 3;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(129, 142);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(84, 20);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last name";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(211, 214);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(251, 26);
            this.txtContact.TabIndex = 5;
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Location = new System.Drawing.Point(129, 214);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(65, 20);
            this.Contact.TabIndex = 4;
            this.Contact.Text = "Contact";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(211, 282);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(251, 26);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(129, 282);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(68, 20);
            this.Adress.TabIndex = 6;
            this.Adress.Text = "Address";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(211, 423);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(251, 26);
            this.txtUserName.TabIndex = 9;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(129, 426);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(85, 20);
            this.UserName.TabIndex = 8;
            this.UserName.Text = "UserName";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(211, 500);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(251, 26);
            this.txtUserPassword.TabIndex = 11;
            // 
            // UserPassword
            // 
            this.UserPassword.AutoSize = true;
            this.UserPassword.Location = new System.Drawing.Point(129, 503);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(78, 20);
            this.UserPassword.TabIndex = 10;
            this.UserPassword.Text = "Password";
            // 
            // txtUserPasswordConfirm
            // 
            this.txtUserPasswordConfirm.Location = new System.Drawing.Point(211, 574);
            this.txtUserPasswordConfirm.Name = "txtUserPasswordConfirm";
            this.txtUserPasswordConfirm.Size = new System.Drawing.Size(251, 26);
            this.txtUserPasswordConfirm.TabIndex = 13;
            // 
            // UserPasswordConfirm
            // 
            this.UserPasswordConfirm.AutoSize = true;
            this.UserPasswordConfirm.Location = new System.Drawing.Point(71, 577);
            this.UserPasswordConfirm.Name = "UserPasswordConfirm";
            this.UserPasswordConfirm.Size = new System.Drawing.Size(136, 20);
            this.UserPasswordConfirm.TabIndex = 12;
            this.UserPasswordConfirm.Text = "Confirm password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(531, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "__________________________________________________________";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(524, 547);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 50);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(484, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(484, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 675);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUserPasswordConfirm);
            this.Controls.Add(this.UserPasswordConfirm);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.FirstName);
            this.Name = "Form1";
            this.Text = "User Registration or Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.TextBox txtUserPasswordConfirm;
        private System.Windows.Forms.Label UserPasswordConfirm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

