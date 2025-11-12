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
            this.SuspendLayout();
            // 
            // employeeInfoBtn
            // 
            this.employeeInfoBtn.Location = new System.Drawing.Point(195, 335);
            this.employeeInfoBtn.Name = "employeeInfoBtn";
            this.employeeInfoBtn.Size = new System.Drawing.Size(221, 23);
            this.employeeInfoBtn.TabIndex = 0;
            this.employeeInfoBtn.Text = "Заполнить данные участника";
            this.employeeInfoBtn.UseVisualStyleBackColor = true;
            this.employeeInfoBtn.Click += new System.EventHandler(this.employeeInfoBtn_Click);
            // 
            // rykovoditelInfoBtn
            // 
            this.rykovoditelInfoBtn.Location = new System.Drawing.Point(422, 335);
            this.rykovoditelInfoBtn.Name = "rykovoditelInfoBtn";
            this.rykovoditelInfoBtn.Size = new System.Drawing.Size(246, 23);
            this.rykovoditelInfoBtn.TabIndex = 1;
            this.rykovoditelInfoBtn.Text = "Заполнить данные руководителя";
            this.rykovoditelInfoBtn.UseVisualStyleBackColor = true;
            this.rykovoditelInfoBtn.Click += new System.EventHandler(this.rykovoditelInfoBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rykovoditelInfoBtn);
            this.Controls.Add(this.employeeInfoBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employeeInfoBtn;
        private System.Windows.Forms.Button rykovoditelInfoBtn;
    }
}