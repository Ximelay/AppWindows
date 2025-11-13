namespace AppWindows
{
    partial class EducationOrgForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label name_OrganisationLabel;
            System.Windows.Forms.Label email_OrganisationLabel;
            System.Windows.Forms.Label director_FIO_OrganizationLabel;
            System.Windows.Forms.Label number_Phone_OrganizationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationOrgForm));
            this.lazutkinDataSet = new AppWindows.LazutkinDataSet();
            this.educational_OrganisationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educational_OrganisationsTableAdapter = new AppWindows.LazutkinDataSetTableAdapters.Educational_OrganisationsTableAdapter();
            this.tableAdapterManager = new AppWindows.LazutkinDataSetTableAdapters.TableAdapterManager();
            this.educational_OrganisationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.educational_OrganisationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.name_OrganisationTextBox = new System.Windows.Forms.TextBox();
            this.email_OrganisationTextBox = new System.Windows.Forms.TextBox();
            this.director_FIO_OrganizationTextBox = new System.Windows.Forms.TextBox();
            this.number_Phone_OrganizationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backMainForm = new System.Windows.Forms.Button();
            this.addEducationOrgBtn = new System.Windows.Forms.Button();
            this.editEducationOrgBtn = new System.Windows.Forms.Button();
            this.removeEducationOrgBtn = new System.Windows.Forms.Button();
            this.allEducationOrgBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.saveEducOrgBtn = new System.Windows.Forms.Button();
            name_OrganisationLabel = new System.Windows.Forms.Label();
            email_OrganisationLabel = new System.Windows.Forms.Label();
            director_FIO_OrganizationLabel = new System.Windows.Forms.Label();
            number_Phone_OrganizationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lazutkinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educational_OrganisationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educational_OrganisationsBindingNavigator)).BeginInit();
            this.educational_OrganisationsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_OrganisationLabel
            // 
            name_OrganisationLabel.AutoSize = true;
            name_OrganisationLabel.Location = new System.Drawing.Point(142, 95);
            name_OrganisationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            name_OrganisationLabel.Name = "name_OrganisationLabel";
            name_OrganisationLabel.Size = new System.Drawing.Size(83, 13);
            name_OrganisationLabel.TabIndex = 1;
            name_OrganisationLabel.Text = "Наименование";
            // 
            // email_OrganisationLabel
            // 
            email_OrganisationLabel.AutoSize = true;
            email_OrganisationLabel.Location = new System.Drawing.Point(186, 127);
            email_OrganisationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            email_OrganisationLabel.Name = "email_OrganisationLabel";
            email_OrganisationLabel.Size = new System.Drawing.Size(37, 13);
            email_OrganisationLabel.TabIndex = 3;
            email_OrganisationLabel.Text = "Почта";
            // 
            // director_FIO_OrganizationLabel
            // 
            director_FIO_OrganizationLabel.AutoSize = true;
            director_FIO_OrganizationLabel.Location = new System.Drawing.Point(139, 162);
            director_FIO_OrganizationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            director_FIO_OrganizationLabel.Name = "director_FIO_OrganizationLabel";
            director_FIO_OrganizationLabel.Size = new System.Drawing.Size(90, 13);
            director_FIO_OrganizationLabel.TabIndex = 5;
            director_FIO_OrganizationLabel.Text = "ФИО директора";
            // 
            // number_Phone_OrganizationLabel
            // 
            number_Phone_OrganizationLabel.AutoSize = true;
            number_Phone_OrganizationLabel.Location = new System.Drawing.Point(133, 197);
            number_Phone_OrganizationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            number_Phone_OrganizationLabel.Name = "number_Phone_OrganizationLabel";
            number_Phone_OrganizationLabel.Size = new System.Drawing.Size(93, 13);
            number_Phone_OrganizationLabel.TabIndex = 7;
            number_Phone_OrganizationLabel.Text = "Номер телефона";
            // 
            // lazutkinDataSet
            // 
            this.lazutkinDataSet.DataSetName = "LazutkinDataSet";
            this.lazutkinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // educational_OrganisationsBindingSource
            // 
            this.educational_OrganisationsBindingSource.DataMember = "Educational_Organisations";
            this.educational_OrganisationsBindingSource.DataSource = this.lazutkinDataSet;
            // 
            // educational_OrganisationsTableAdapter
            // 
            this.educational_OrganisationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Educational_OrganisationsTableAdapter = this.educational_OrganisationsTableAdapter;
            this.tableAdapterManager.EmployesTableAdapter = null;
            this.tableAdapterManager.Nomination_OlimpiadsTableAdapter = null;
            this.tableAdapterManager.RykovoditelsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppWindows.LazutkinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // educational_OrganisationsBindingNavigator
            // 
            this.educational_OrganisationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.educational_OrganisationsBindingNavigator.BindingSource = this.educational_OrganisationsBindingSource;
            this.educational_OrganisationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.educational_OrganisationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.educational_OrganisationsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.educational_OrganisationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.educational_OrganisationsBindingNavigatorSaveItem});
            this.educational_OrganisationsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.educational_OrganisationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.educational_OrganisationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.educational_OrganisationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.educational_OrganisationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.educational_OrganisationsBindingNavigator.Name = "educational_OrganisationsBindingNavigator";
            this.educational_OrganisationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.educational_OrganisationsBindingNavigator.Size = new System.Drawing.Size(600, 27);
            this.educational_OrganisationsBindingNavigator.TabIndex = 0;
            this.educational_OrganisationsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // educational_OrganisationsBindingNavigatorSaveItem
            // 
            this.educational_OrganisationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.educational_OrganisationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("educational_OrganisationsBindingNavigatorSaveItem.Image")));
            this.educational_OrganisationsBindingNavigatorSaveItem.Name = "educational_OrganisationsBindingNavigatorSaveItem";
            this.educational_OrganisationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.educational_OrganisationsBindingNavigatorSaveItem.Text = "Save Data";
            this.educational_OrganisationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.educational_OrganisationsBindingNavigatorSaveItem_Click);
            // 
            // name_OrganisationTextBox
            // 
            this.name_OrganisationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educational_OrganisationsBindingSource, "Name_Organisation", true));
            this.name_OrganisationTextBox.Location = new System.Drawing.Point(226, 90);
            this.name_OrganisationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.name_OrganisationTextBox.Name = "name_OrganisationTextBox";
            this.name_OrganisationTextBox.Size = new System.Drawing.Size(262, 20);
            this.name_OrganisationTextBox.TabIndex = 2;
            // 
            // email_OrganisationTextBox
            // 
            this.email_OrganisationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educational_OrganisationsBindingSource, "Email_Organisation", true));
            this.email_OrganisationTextBox.Location = new System.Drawing.Point(226, 122);
            this.email_OrganisationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.email_OrganisationTextBox.Name = "email_OrganisationTextBox";
            this.email_OrganisationTextBox.Size = new System.Drawing.Size(262, 20);
            this.email_OrganisationTextBox.TabIndex = 4;
            // 
            // director_FIO_OrganizationTextBox
            // 
            this.director_FIO_OrganizationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educational_OrganisationsBindingSource, "Director_FIO_Organization", true));
            this.director_FIO_OrganizationTextBox.Location = new System.Drawing.Point(226, 157);
            this.director_FIO_OrganizationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.director_FIO_OrganizationTextBox.Name = "director_FIO_OrganizationTextBox";
            this.director_FIO_OrganizationTextBox.Size = new System.Drawing.Size(262, 20);
            this.director_FIO_OrganizationTextBox.TabIndex = 6;
            // 
            // number_Phone_OrganizationTextBox
            // 
            this.number_Phone_OrganizationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educational_OrganisationsBindingSource, "Number_Phone_Organization", true));
            this.number_Phone_OrganizationTextBox.Location = new System.Drawing.Point(226, 192);
            this.number_Phone_OrganizationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.number_Phone_OrganizationTextBox.Name = "number_Phone_OrganizationTextBox";
            this.number_Phone_OrganizationTextBox.Size = new System.Drawing.Size(262, 20);
            this.number_Phone_OrganizationTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(241, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Данные организации";
            // 
            // backMainForm
            // 
            this.backMainForm.Location = new System.Drawing.Point(136, 269);
            this.backMainForm.Name = "backMainForm";
            this.backMainForm.Size = new System.Drawing.Size(75, 23);
            this.backMainForm.TabIndex = 13;
            this.backMainForm.Text = "Назад";
            this.backMainForm.UseVisualStyleBackColor = true;
            this.backMainForm.Click += new System.EventHandler(this.backMainForm_Click);
            // 
            // addEducationOrgBtn
            // 
            this.addEducationOrgBtn.BackColor = System.Drawing.Color.LightGreen;
            this.addEducationOrgBtn.Location = new System.Drawing.Point(255, 269);
            this.addEducationOrgBtn.Name = "addEducationOrgBtn";
            this.addEducationOrgBtn.Size = new System.Drawing.Size(75, 23);
            this.addEducationOrgBtn.TabIndex = 14;
            this.addEducationOrgBtn.Text = "Создать";
            this.addEducationOrgBtn.UseVisualStyleBackColor = false;
            this.addEducationOrgBtn.Click += new System.EventHandler(this.addEducationOrgBtn_Click);
            // 
            // editEducationOrgBtn
            // 
            this.editEducationOrgBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.editEducationOrgBtn.Location = new System.Drawing.Point(336, 269);
            this.editEducationOrgBtn.Name = "editEducationOrgBtn";
            this.editEducationOrgBtn.Size = new System.Drawing.Size(75, 23);
            this.editEducationOrgBtn.TabIndex = 15;
            this.editEducationOrgBtn.Text = "Изменить";
            this.editEducationOrgBtn.UseVisualStyleBackColor = false;
            this.editEducationOrgBtn.Click += new System.EventHandler(this.editEducationOrgBtn_Click);
            // 
            // removeEducationOrgBtn
            // 
            this.removeEducationOrgBtn.BackColor = System.Drawing.Color.Red;
            this.removeEducationOrgBtn.Location = new System.Drawing.Point(417, 269);
            this.removeEducationOrgBtn.Name = "removeEducationOrgBtn";
            this.removeEducationOrgBtn.Size = new System.Drawing.Size(75, 23);
            this.removeEducationOrgBtn.TabIndex = 16;
            this.removeEducationOrgBtn.Text = "Удалить";
            this.removeEducationOrgBtn.UseVisualStyleBackColor = false;
            this.removeEducationOrgBtn.Click += new System.EventHandler(this.removeEducationOrgBtn_Click);
            // 
            // allEducationOrgBtn
            // 
            this.allEducationOrgBtn.Location = new System.Drawing.Point(51, 315);
            this.allEducationOrgBtn.Name = "allEducationOrgBtn";
            this.allEducationOrgBtn.Size = new System.Drawing.Size(75, 23);
            this.allEducationOrgBtn.TabIndex = 17;
            this.allEducationOrgBtn.Text = "Все ОУ";
            this.allEducationOrgBtn.UseVisualStyleBackColor = true;
            this.allEducationOrgBtn.Click += new System.EventHandler(this.allEducationOrgBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(307, 229);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 18;
            this.nextBtn.Text = "->";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(226, 229);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(75, 23);
            this.previousBtn.TabIndex = 19;
            this.previousBtn.Text = "<-";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // saveEducOrgBtn
            // 
            this.saveEducOrgBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveEducOrgBtn.Location = new System.Drawing.Point(498, 269);
            this.saveEducOrgBtn.Name = "saveEducOrgBtn";
            this.saveEducOrgBtn.Size = new System.Drawing.Size(75, 23);
            this.saveEducOrgBtn.TabIndex = 20;
            this.saveEducOrgBtn.Text = "Сохранить";
            this.saveEducOrgBtn.UseVisualStyleBackColor = false;
            this.saveEducOrgBtn.Click += new System.EventHandler(this.saveEducOrgBtn_Click);
            // 
            // EducationOrgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.saveEducOrgBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.allEducationOrgBtn);
            this.Controls.Add(this.removeEducationOrgBtn);
            this.Controls.Add(this.editEducationOrgBtn);
            this.Controls.Add(this.addEducationOrgBtn);
            this.Controls.Add(this.backMainForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(number_Phone_OrganizationLabel);
            this.Controls.Add(this.number_Phone_OrganizationTextBox);
            this.Controls.Add(director_FIO_OrganizationLabel);
            this.Controls.Add(this.director_FIO_OrganizationTextBox);
            this.Controls.Add(email_OrganisationLabel);
            this.Controls.Add(this.email_OrganisationTextBox);
            this.Controls.Add(name_OrganisationLabel);
            this.Controls.Add(this.name_OrganisationTextBox);
            this.Controls.Add(this.educational_OrganisationsBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EducationOrgForm";
            this.Text = "EducationOrgForm";
            this.Load += new System.EventHandler(this.EducationOrgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lazutkinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educational_OrganisationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educational_OrganisationsBindingNavigator)).EndInit();
            this.educational_OrganisationsBindingNavigator.ResumeLayout(false);
            this.educational_OrganisationsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LazutkinDataSet lazutkinDataSet;
        private System.Windows.Forms.BindingSource educational_OrganisationsBindingSource;
        private LazutkinDataSetTableAdapters.Educational_OrganisationsTableAdapter educational_OrganisationsTableAdapter;
        private LazutkinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator educational_OrganisationsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton educational_OrganisationsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox name_OrganisationTextBox;
        private System.Windows.Forms.TextBox email_OrganisationTextBox;
        private System.Windows.Forms.TextBox director_FIO_OrganizationTextBox;
        private System.Windows.Forms.TextBox number_Phone_OrganizationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backMainForm;
        private System.Windows.Forms.Button addEducationOrgBtn;
        private System.Windows.Forms.Button editEducationOrgBtn;
        private System.Windows.Forms.Button removeEducationOrgBtn;
        private System.Windows.Forms.Button allEducationOrgBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button saveEducOrgBtn;
    }
}