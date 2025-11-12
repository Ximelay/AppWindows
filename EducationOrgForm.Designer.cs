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
            this.btnSaveOrg = new System.Windows.Forms.Button();
            this.btnChangeOrg = new System.Windows.Forms.Button();
            this.btnDeleteOrg = new System.Windows.Forms.Button();
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
            name_OrganisationLabel.Location = new System.Drawing.Point(262, 123);
            name_OrganisationLabel.Name = "name_OrganisationLabel";
            name_OrganisationLabel.Size = new System.Drawing.Size(106, 16);
            name_OrganisationLabel.TabIndex = 1;
            name_OrganisationLabel.Text = "Наименование";
            // 
            // email_OrganisationLabel
            // 
            email_OrganisationLabel.AutoSize = true;
            email_OrganisationLabel.Location = new System.Drawing.Point(320, 162);
            email_OrganisationLabel.Name = "email_OrganisationLabel";
            email_OrganisationLabel.Size = new System.Drawing.Size(48, 16);
            email_OrganisationLabel.TabIndex = 3;
            email_OrganisationLabel.Text = "Почта";
            // 
            // director_FIO_OrganizationLabel
            // 
            director_FIO_OrganizationLabel.AutoSize = true;
            director_FIO_OrganizationLabel.Location = new System.Drawing.Point(257, 206);
            director_FIO_OrganizationLabel.Name = "director_FIO_OrganizationLabel";
            director_FIO_OrganizationLabel.Size = new System.Drawing.Size(111, 16);
            director_FIO_OrganizationLabel.TabIndex = 5;
            director_FIO_OrganizationLabel.Text = "ФИО директора";
            // 
            // number_Phone_OrganizationLabel
            // 
            number_Phone_OrganizationLabel.AutoSize = true;
            number_Phone_OrganizationLabel.Location = new System.Drawing.Point(249, 248);
            number_Phone_OrganizationLabel.Name = "number_Phone_OrganizationLabel";
            number_Phone_OrganizationLabel.Size = new System.Drawing.Size(119, 16);
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
            this.educational_OrganisationsBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.educational_OrganisationsBindingNavigator.TabIndex = 0;
            this.educational_OrganisationsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // educational_OrganisationsBindingNavigatorSaveItem
            // 
            this.educational_OrganisationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.educational_OrganisationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("educational_OrganisationsBindingNavigatorSaveItem.Image")));
            this.educational_OrganisationsBindingNavigatorSaveItem.Name = "educational_OrganisationsBindingNavigatorSaveItem";
            this.educational_OrganisationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.educational_OrganisationsBindingNavigatorSaveItem.Text = "Save Data";
            this.educational_OrganisationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.educational_OrganisationsBindingNavigatorSaveItem_Click);
            // 
            // name_OrganisationTextBox
            // 
            this.name_OrganisationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educational_OrganisationsBindingSource, "Name_Organisation", true));
            this.name_OrganisationTextBox.Location = new System.Drawing.Point(374, 117);
            this.name_OrganisationTextBox.Name = "name_OrganisationTextBox";
            this.name_OrganisationTextBox.Size = new System.Drawing.Size(264, 22);
            this.name_OrganisationTextBox.TabIndex = 2;
            // 
            // email_OrganisationTextBox
            // 
            this.email_OrganisationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educational_OrganisationsBindingSource, "Email_Organisation", true));
            this.email_OrganisationTextBox.Location = new System.Drawing.Point(374, 156);
            this.email_OrganisationTextBox.Name = "email_OrganisationTextBox";
            this.email_OrganisationTextBox.Size = new System.Drawing.Size(264, 22);
            this.email_OrganisationTextBox.TabIndex = 4;
            // 
            // director_FIO_OrganizationTextBox
            // 
            this.director_FIO_OrganizationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educational_OrganisationsBindingSource, "Director_FIO_Organization", true));
            this.director_FIO_OrganizationTextBox.Location = new System.Drawing.Point(374, 200);
            this.director_FIO_OrganizationTextBox.Name = "director_FIO_OrganizationTextBox";
            this.director_FIO_OrganizationTextBox.Size = new System.Drawing.Size(264, 22);
            this.director_FIO_OrganizationTextBox.TabIndex = 6;
            // 
            // number_Phone_OrganizationTextBox
            // 
            this.number_Phone_OrganizationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educational_OrganisationsBindingSource, "Number_Phone_Organization", true));
            this.number_Phone_OrganizationTextBox.Location = new System.Drawing.Point(374, 242);
            this.number_Phone_OrganizationTextBox.Name = "number_Phone_OrganizationTextBox";
            this.number_Phone_OrganizationTextBox.Size = new System.Drawing.Size(264, 22);
            this.number_Phone_OrganizationTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Данные организации";
            // 
            // btnSaveOrg
            // 
            this.btnSaveOrg.Location = new System.Drawing.Point(493, 333);
            this.btnSaveOrg.Name = "btnSaveOrg";
            this.btnSaveOrg.Size = new System.Drawing.Size(111, 23);
            this.btnSaveOrg.TabIndex = 10;
            this.btnSaveOrg.Text = "Сохранить";
            this.btnSaveOrg.UseVisualStyleBackColor = true;
            // 
            // btnChangeOrg
            // 
            this.btnChangeOrg.Location = new System.Drawing.Point(376, 333);
            this.btnChangeOrg.Name = "btnChangeOrg";
            this.btnChangeOrg.Size = new System.Drawing.Size(111, 23);
            this.btnChangeOrg.TabIndex = 11;
            this.btnChangeOrg.Text = "Изменить";
            this.btnChangeOrg.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOrg
            // 
            this.btnDeleteOrg.Location = new System.Drawing.Point(257, 333);
            this.btnDeleteOrg.Name = "btnDeleteOrg";
            this.btnDeleteOrg.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteOrg.TabIndex = 12;
            this.btnDeleteOrg.Text = "Удалить";
            this.btnDeleteOrg.UseVisualStyleBackColor = true;
            // 
            // EducationOrgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteOrg);
            this.Controls.Add(this.btnChangeOrg);
            this.Controls.Add(this.btnSaveOrg);
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
        private System.Windows.Forms.Button btnSaveOrg;
        private System.Windows.Forms.Button btnChangeOrg;
        private System.Windows.Forms.Button btnDeleteOrg;
    }
}