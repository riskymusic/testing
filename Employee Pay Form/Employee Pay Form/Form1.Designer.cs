namespace Employee_Pay_Form
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
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.bankacc = new System.Windows.Forms.TextBox();
            this.irdnum = new System.Windows.Forms.TextBox();
            this.hrswrk = new System.Windows.Forms.TextBox();
            this.hrlyrate = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.agetext = new System.Windows.Forms.Label();
            this.bankacctext = new System.Windows.Forms.Label();
            this.irdnumtext = new System.Windows.Forms.Label();
            this.hrswrkedtext = new System.Windows.Forms.Label();
            this.hrlyratetext = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(508, 29);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(221, 20);
            this.fname.TabIndex = 0;
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(508, 84);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(221, 20);
            this.lname.TabIndex = 1;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(508, 139);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(221, 20);
            this.age.TabIndex = 2;
            // 
            // bankacc
            // 
            this.bankacc.Location = new System.Drawing.Point(508, 198);
            this.bankacc.Name = "bankacc";
            this.bankacc.Size = new System.Drawing.Size(221, 20);
            this.bankacc.TabIndex = 3;
            // 
            // irdnum
            // 
            this.irdnum.Location = new System.Drawing.Point(508, 255);
            this.irdnum.Name = "irdnum";
            this.irdnum.Size = new System.Drawing.Size(221, 20);
            this.irdnum.TabIndex = 4;
            // 
            // hrswrk
            // 
            this.hrswrk.Location = new System.Drawing.Point(508, 315);
            this.hrswrk.Name = "hrswrk";
            this.hrswrk.Size = new System.Drawing.Size(221, 20);
            this.hrswrk.TabIndex = 5;
            // 
            // hrlyrate
            // 
            this.hrlyrate.Location = new System.Drawing.Point(508, 381);
            this.hrlyrate.Name = "hrlyrate";
            this.hrlyrate.Size = new System.Drawing.Size(221, 20);
            this.hrlyrate.TabIndex = 6;
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(508, 10);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(57, 13);
            this.firstname.TabIndex = 7;
            this.firstname.Text = "First Name";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(508, 65);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(58, 13);
            this.lastname.TabIndex = 8;
            this.lastname.Text = "Last Name";
            // 
            // agetext
            // 
            this.agetext.AutoSize = true;
            this.agetext.Location = new System.Drawing.Point(508, 120);
            this.agetext.Name = "agetext";
            this.agetext.Size = new System.Drawing.Size(26, 13);
            this.agetext.TabIndex = 9;
            this.agetext.Text = "Age";
            // 
            // bankacctext
            // 
            this.bankacctext.AutoSize = true;
            this.bankacctext.Location = new System.Drawing.Point(508, 179);
            this.bankacctext.Name = "bankacctext";
            this.bankacctext.Size = new System.Drawing.Size(56, 13);
            this.bankacctext.TabIndex = 10;
            this.bankacctext.Text = "Bank ACC";
            // 
            // irdnumtext
            // 
            this.irdnumtext.AutoSize = true;
            this.irdnumtext.Location = new System.Drawing.Point(508, 236);
            this.irdnumtext.Name = "irdnumtext";
            this.irdnumtext.Size = new System.Drawing.Size(66, 13);
            this.irdnumtext.TabIndex = 11;
            this.irdnumtext.Text = "IRD Number";
            // 
            // hrswrkedtext
            // 
            this.hrswrkedtext.AutoSize = true;
            this.hrswrkedtext.Location = new System.Drawing.Point(508, 296);
            this.hrswrkedtext.Name = "hrswrkedtext";
            this.hrswrkedtext.Size = new System.Drawing.Size(76, 13);
            this.hrswrkedtext.TabIndex = 12;
            this.hrswrkedtext.Text = "Hours Worked";
            // 
            // hrlyratetext
            // 
            this.hrlyratetext.AutoSize = true;
            this.hrlyratetext.Location = new System.Drawing.Point(508, 362);
            this.hrlyratetext.Name = "hrlyratetext";
            this.hrlyratetext.Size = new System.Drawing.Size(63, 13);
            this.hrlyratetext.TabIndex = 13;
            this.hrlyratetext.Text = "Hourly Rate";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(508, 419);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 14;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(49, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(453, 372);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.hrlyratetext);
            this.Controls.Add(this.hrswrkedtext);
            this.Controls.Add(this.irdnumtext);
            this.Controls.Add(this.bankacctext);
            this.Controls.Add(this.agetext);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.hrlyrate);
            this.Controls.Add(this.hrswrk);
            this.Controls.Add(this.irdnum);
            this.Controls.Add(this.bankacc);
            this.Controls.Add(this.age);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox bankacc;
        private System.Windows.Forms.TextBox irdnum;
        private System.Windows.Forms.TextBox hrswrk;
        private System.Windows.Forms.TextBox hrlyrate;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label agetext;
        private System.Windows.Forms.Label bankacctext;
        private System.Windows.Forms.Label irdnumtext;
        private System.Windows.Forms.Label hrswrkedtext;
        private System.Windows.Forms.Label hrlyratetext;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

