namespace AppWindows
{
    partial class MainForm
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
            this.employeeInfoBtn = new System.Windows.Forms.Button();
            this.rykovoditelInfoBtn = new System.Windows.Forms.Button();
            this.educationOrgIntoBtn = new System.Windows.Forms.Button();
            this.NominationInfoBtn = new System.Windows.Forms.Button();
            this.allUsersAndAnotherDataBtn = new System.Windows.Forms.Button();
            this.sortByNominationsBtn = new System.Windows.Forms.Button();
            this.sortByOrganizationsBtn = new System.Windows.Forms.Button();
            this.CountEmplouesAtRykovoditelsBtn = new System.Windows.Forms.Button();
            this.nominationLessThreeEmployes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeInfoBtn
            // 
            this.employeeInfoBtn.Location = new System.Drawing.Point(41, 43);
            this.employeeInfoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.employeeInfoBtn.Name = "employeeInfoBtn";
            this.employeeInfoBtn.Size = new System.Drawing.Size(137, 43);
            this.employeeInfoBtn.TabIndex = 0;
            this.employeeInfoBtn.Text = "Заполнить данные участника";
            this.employeeInfoBtn.UseVisualStyleBackColor = true;
            this.employeeInfoBtn.Click += new System.EventHandler(this.employeeInfoBtn_Click);
            // 
            // rykovoditelInfoBtn
            // 
            this.rykovoditelInfoBtn.Location = new System.Drawing.Point(41, 90);
            this.rykovoditelInfoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.rykovoditelInfoBtn.Name = "rykovoditelInfoBtn";
            this.rykovoditelInfoBtn.Size = new System.Drawing.Size(137, 43);
            this.rykovoditelInfoBtn.TabIndex = 1;
            this.rykovoditelInfoBtn.Text = "Заполнить данные руководителя";
            this.rykovoditelInfoBtn.UseVisualStyleBackColor = true;
            this.rykovoditelInfoBtn.Click += new System.EventHandler(this.rykovoditelInfoBtn_Click);
            // 
            // educationOrgIntoBtn
            // 
            this.educationOrgIntoBtn.Location = new System.Drawing.Point(41, 139);
            this.educationOrgIntoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.educationOrgIntoBtn.Name = "educationOrgIntoBtn";
            this.educationOrgIntoBtn.Size = new System.Drawing.Size(137, 43);
            this.educationOrgIntoBtn.TabIndex = 2;
            this.educationOrgIntoBtn.Text = "Заполнить данные ОУ";
            this.educationOrgIntoBtn.UseVisualStyleBackColor = true;
            this.educationOrgIntoBtn.Click += new System.EventHandler(this.educationOrgIntoBtn_Click);
            // 
            // NominationInfoBtn
            // 
            this.NominationInfoBtn.Location = new System.Drawing.Point(41, 193);
            this.NominationInfoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NominationInfoBtn.Name = "NominationInfoBtn";
            this.NominationInfoBtn.Size = new System.Drawing.Size(137, 43);
            this.NominationInfoBtn.TabIndex = 3;
            this.NominationInfoBtn.Text = "Заполнить данные номинаций";
            this.NominationInfoBtn.UseVisualStyleBackColor = true;
            this.NominationInfoBtn.Click += new System.EventHandler(this.NominationInfoBtn_Click);
            // 
            // allUsersAndAnotherDataBtn
            // 
            this.allUsersAndAnotherDataBtn.Location = new System.Drawing.Point(38, 33);
            this.allUsersAndAnotherDataBtn.Name = "allUsersAndAnotherDataBtn";
            this.allUsersAndAnotherDataBtn.Size = new System.Drawing.Size(184, 43);
            this.allUsersAndAnotherDataBtn.TabIndex = 4;
            this.allUsersAndAnotherDataBtn.Text = "1. Все участники и другие данные";
            this.allUsersAndAnotherDataBtn.UseVisualStyleBackColor = true;
            this.allUsersAndAnotherDataBtn.Click += new System.EventHandler(this.allUsersAndAnotherDataBtn_Click);
            // 
            // sortByNominationsBtn
            // 
            this.sortByNominationsBtn.Location = new System.Drawing.Point(38, 82);
            this.sortByNominationsBtn.Name = "sortByNominationsBtn";
            this.sortByNominationsBtn.Size = new System.Drawing.Size(184, 43);
            this.sortByNominationsBtn.TabIndex = 5;
            this.sortByNominationsBtn.Text = "2. Сортировка по номинациям";
            this.sortByNominationsBtn.UseVisualStyleBackColor = true;
            this.sortByNominationsBtn.Click += new System.EventHandler(this.sortByNominationsBtn_Click);
            // 
            // sortByOrganizationsBtn
            // 
            this.sortByOrganizationsBtn.Location = new System.Drawing.Point(38, 131);
            this.sortByOrganizationsBtn.Name = "sortByOrganizationsBtn";
            this.sortByOrganizationsBtn.Size = new System.Drawing.Size(184, 43);
            this.sortByOrganizationsBtn.TabIndex = 6;
            this.sortByOrganizationsBtn.Text = "3. Сортировка по организациям";
            this.sortByOrganizationsBtn.UseVisualStyleBackColor = true;
            this.sortByOrganizationsBtn.Click += new System.EventHandler(this.sortByOrganizationsBtn_Click);
            // 
            // CountEmplouesAtRykovoditelsBtn
            // 
            this.CountEmplouesAtRykovoditelsBtn.Location = new System.Drawing.Point(38, 180);
            this.CountEmplouesAtRykovoditelsBtn.Name = "CountEmplouesAtRykovoditelsBtn";
            this.CountEmplouesAtRykovoditelsBtn.Size = new System.Drawing.Size(184, 48);
            this.CountEmplouesAtRykovoditelsBtn.TabIndex = 7;
            this.CountEmplouesAtRykovoditelsBtn.Text = "4. Количество участников у руководителя";
            this.CountEmplouesAtRykovoditelsBtn.UseVisualStyleBackColor = true;
            this.CountEmplouesAtRykovoditelsBtn.Click += new System.EventHandler(this.CountEmplouesAtRykovoditelsBtn_Click);
            // 
            // nominationLessThreeEmployes
            // 
            this.nominationLessThreeEmployes.Location = new System.Drawing.Point(38, 234);
            this.nominationLessThreeEmployes.Name = "nominationLessThreeEmployes";
            this.nominationLessThreeEmployes.Size = new System.Drawing.Size(184, 43);
            this.nominationLessThreeEmployes.TabIndex = 8;
            this.nominationLessThreeEmployes.Text = "5. У какой номинации меньше 3 участников";
            this.nominationLessThreeEmployes.UseVisualStyleBackColor = true;
            this.nominationLessThreeEmployes.Click += new System.EventHandler(this.nominationLessThreeEmployes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employeeInfoBtn);
            this.groupBox1.Controls.Add(this.rykovoditelInfoBtn);
            this.groupBox1.Controls.Add(this.educationOrgIntoBtn);
            this.groupBox1.Controls.Add(this.NominationInfoBtn);
            this.groupBox1.Location = new System.Drawing.Point(22, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 321);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основные формы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sortByNominationsBtn);
            this.groupBox2.Controls.Add(this.allUsersAndAnotherDataBtn);
            this.groupBox2.Controls.Add(this.nominationLessThreeEmployes);
            this.groupBox2.Controls.Add(this.sortByOrganizationsBtn);
            this.groupBox2.Controls.Add(this.CountEmplouesAtRykovoditelsBtn);
            this.groupBox2.Location = new System.Drawing.Point(310, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 321);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL-формы";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employeeInfoBtn;
        private System.Windows.Forms.Button rykovoditelInfoBtn;
        private System.Windows.Forms.Button educationOrgIntoBtn;
        private System.Windows.Forms.Button NominationInfoBtn;
        private System.Windows.Forms.Button allUsersAndAnotherDataBtn;
        private System.Windows.Forms.Button sortByNominationsBtn;
        private System.Windows.Forms.Button sortByOrganizationsBtn;
        private System.Windows.Forms.Button CountEmplouesAtRykovoditelsBtn;
        private System.Windows.Forms.Button nominationLessThreeEmployes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}