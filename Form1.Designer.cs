
namespace RABotaPZ
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentsDGV = new System.Windows.Forms.DataGridView();
            this.classroomsDGV = new System.Windows.Forms.DataGridView();
            this.classDGV = new System.Windows.Forms.DataGridView();
            this.NameOfDGV = new System.Windows.Forms.Label();
            this.NameOfDGV1 = new System.Windows.Forms.Label();
            this.NameOfDGV2 = new System.Windows.Forms.Label();
            this.exitButn = new System.Windows.Forms.Button();
            this.addStudentButn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsDGV
            // 
            this.studentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDGV.Location = new System.Drawing.Point(656, 25);
            this.studentsDGV.Name = "studentsDGV";
            this.studentsDGV.Size = new System.Drawing.Size(646, 194);
            this.studentsDGV.TabIndex = 0;
            // 
            // classroomsDGV
            // 
            this.classroomsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classroomsDGV.Location = new System.Drawing.Point(656, 258);
            this.classroomsDGV.Name = "classroomsDGV";
            this.classroomsDGV.Size = new System.Drawing.Size(643, 219);
            this.classroomsDGV.TabIndex = 1;
            // 
            // classDGV
            // 
            this.classDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDGV.Location = new System.Drawing.Point(12, 25);
            this.classDGV.Name = "classDGV";
            this.classDGV.Size = new System.Drawing.Size(638, 452);
            this.classDGV.TabIndex = 2;
            // 
            // NameOfDGV
            // 
            this.NameOfDGV.AutoSize = true;
            this.NameOfDGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NameOfDGV.Location = new System.Drawing.Point(12, 9);
            this.NameOfDGV.Name = "NameOfDGV";
            this.NameOfDGV.Size = new System.Drawing.Size(46, 13);
            this.NameOfDGV.TabIndex = 3;
            this.NameOfDGV.Text = "Классы";
            // 
            // NameOfDGV1
            // 
            this.NameOfDGV1.AutoSize = true;
            this.NameOfDGV1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NameOfDGV1.Location = new System.Drawing.Point(653, 9);
            this.NameOfDGV1.Name = "NameOfDGV1";
            this.NameOfDGV1.Size = new System.Drawing.Size(50, 13);
            this.NameOfDGV1.TabIndex = 4;
            this.NameOfDGV1.Text = "Ученики";
            // 
            // NameOfDGV2
            // 
            this.NameOfDGV2.AutoSize = true;
            this.NameOfDGV2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NameOfDGV2.Location = new System.Drawing.Point(653, 242);
            this.NameOfDGV2.Name = "NameOfDGV2";
            this.NameOfDGV2.Size = new System.Drawing.Size(57, 13);
            this.NameOfDGV2.TabIndex = 5;
            this.NameOfDGV2.Text = "Кабинеты";
            // 
            // exitButn
            // 
            this.exitButn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButn.Location = new System.Drawing.Point(1164, 645);
            this.exitButn.Name = "exitButn";
            this.exitButn.Size = new System.Drawing.Size(135, 56);
            this.exitButn.TabIndex = 6;
            this.exitButn.Text = "Выход";
            this.exitButn.UseVisualStyleBackColor = true;
            this.exitButn.Click += new System.EventHandler(this.exitButn_Click);
            // 
            // addStudentButn
            // 
            this.addStudentButn.Location = new System.Drawing.Point(665, 508);
            this.addStudentButn.Name = "addStudentButn";
            this.addStudentButn.Size = new System.Drawing.Size(129, 33);
            this.addStudentButn.TabIndex = 7;
            this.addStudentButn.Text = "Вставить ученика";
            this.addStudentButn.UseVisualStyleBackColor = true;
            this.addStudentButn.Click += new System.EventHandler(this.addStudentButn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "DataReader";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 713);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addStudentButn);
            this.Controls.Add(this.exitButn);
            this.Controls.Add(this.NameOfDGV2);
            this.Controls.Add(this.NameOfDGV1);
            this.Controls.Add(this.NameOfDGV);
            this.Controls.Add(this.classDGV);
            this.Controls.Add(this.classroomsDGV);
            this.Controls.Add(this.studentsDGV);
            this.Name = "MainForm";
            this.Text = "Главное Окно";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsDGV;
        private System.Windows.Forms.DataGridView classroomsDGV;
        private System.Windows.Forms.DataGridView classDGV;
        private System.Windows.Forms.Label NameOfDGV;
        private System.Windows.Forms.Label NameOfDGV1;
        private System.Windows.Forms.Label NameOfDGV2;
        private System.Windows.Forms.Button exitButn;
        private System.Windows.Forms.Button addStudentButn;
        private System.Windows.Forms.Button button1;
    }
}

