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
            this.SuspendLayout();
            // 
            // employeeInfoBtn
            // 
            this.employeeInfoBtn.Location = new System.Drawing.Point(238, 79);
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
            this.rykovoditelInfoBtn.Location = new System.Drawing.Point(238, 126);
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
            this.educationOrgIntoBtn.Location = new System.Drawing.Point(238, 173);
            this.educationOrgIntoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.educationOrgIntoBtn.Name = "educationOrgIntoBtn";
            this.educationOrgIntoBtn.Size = new System.Drawing.Size(137, 43);
            this.educationOrgIntoBtn.TabIndex = 2;
            this.educationOrgIntoBtn.Text = "Заполнить данные ОУ";
            this.educationOrgIntoBtn.UseVisualStyleBackColor = true;
            this.educationOrgIntoBtn.Click += new System.EventHandler(this.educationOrgIntoBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.educationOrgIntoBtn);
            this.Controls.Add(this.rykovoditelInfoBtn);
            this.Controls.Add(this.employeeInfoBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employeeInfoBtn;
        private System.Windows.Forms.Button rykovoditelInfoBtn;
        private System.Windows.Forms.Button educationOrgIntoBtn;
    }
}