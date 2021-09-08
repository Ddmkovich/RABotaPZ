
namespace RABotaPZ
{
    partial class addStudentForm
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
            this.first_name = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.date_of_birth = new System.Windows.Forms.TextBox();
            this.adress = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.studentFormExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(15, 25);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(207, 20);
            this.first_name.TabIndex = 0;
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(15, 64);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(207, 20);
            this.last_name.TabIndex = 1;
            // 
            // date_of_birth
            // 
            this.date_of_birth.Location = new System.Drawing.Point(15, 103);
            this.date_of_birth.Name = "date_of_birth";
            this.date_of_birth.Size = new System.Drawing.Size(207, 20);
            this.date_of_birth.TabIndex = 2;
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(15, 142);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(207, 20);
            this.adress.TabIndex = 3;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(15, 181);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(207, 20);
            this.email.TabIndex = 4;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(15, 207);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(89, 55);
            this.addStudentButton.TabIndex = 5;
            this.addStudentButton.Text = "Добавить";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // studentFormExit
            // 
            this.studentFormExit.Location = new System.Drawing.Point(170, 333);
            this.studentFormExit.Name = "studentFormExit";
            this.studentFormExit.Size = new System.Drawing.Size(89, 52);
            this.studentFormExit.TabIndex = 6;
            this.studentFormExit.Text = "Выход";
            this.studentFormExit.UseVisualStyleBackColor = true;
            this.studentFormExit.Click += new System.EventHandler(this.studentFormExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(228, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(228, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(228, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Емайл";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Адрес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дата рождения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Фамилия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Имя";
            // 
            // addStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 397);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentFormExit);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.email);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.date_of_birth);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Name = "addStudentForm";
            this.Text = "addStudentForm";
            this.Load += new System.EventHandler(this.addStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox date_of_birth;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button studentFormExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}