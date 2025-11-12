namespace AppWindows
{
    partial class EmployeeForm
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
            System.Windows.Forms.Label name_NominationLabel;
            System.Windows.Forms.Label phone_EmployeeLabel;
            System.Windows.Forms.Label otchestvo_EmployeeLabel;
            System.Windows.Forms.Label name_EmpoloyeeLabel;
            System.Windows.Forms.Label famaili_EmployeeLabel;
            System.Windows.Forms.Label login_EmployeeLabel;
            System.Windows.Forms.Label password_EmployeeLabel;
            System.Windows.Forms.Label famali_RykovoditelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.lazutkinDataSet = new AppWindows.LazutkinDataSet();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employesTableAdapter = new AppWindows.LazutkinDataSetTableAdapters.EmployesTableAdapter();
            this.tableAdapterManager = new AppWindows.LazutkinDataSetTableAdapters.TableAdapterManager();
            this.educational_OrganisationsTableAdapter = new AppWindows.LazutkinDataSetTableAdapters.Educational_OrganisationsTableAdapter();
            this.nomination_OlimpiadsTableAdapter = new AppWindows.LazutkinDataSetTableAdapters.Nomination_OlimpiadsTableAdapter();
            this.rykovoditelsTableAdapter = new AppWindows.LazutkinDataSetTableAdapters.RykovoditelsTableAdapter();
            this.employesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.employesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.educationalOrganisationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rykovoditelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nominationOlimpiadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.name_OrganisationComboBox = new System.Windows.Forms.ComboBox();
            this.name_NominationComboBox = new System.Windows.Forms.ComboBox();
            this.nominationOlimpiadsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phone_EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.otchestvo_EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.name_EmpoloyeeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.famaili_EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.BackMainForm = new System.Windows.Forms.Button();
            this.login_EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.password_EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.famali_RykovoditelComboBox = new System.Windows.Forms.ComboBox();
            this.allEmpoyeeBtn = new System.Windows.Forms.Button();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.editEmployeeBtn = new System.Windows.Forms.Button();
            this.removeEmployeeBtn = new System.Windows.Forms.Button();
            name_OrganisationLabel = new System.Windows.Forms.Label();
            name_NominationLabel = new System.Windows.Forms.Label();
            phone_EmployeeLabel = new System.Windows.Forms.Label();
            otchestvo_EmployeeLabel = new System.Windows.Forms.Label();
            name_EmpoloyeeLabel = new System.Windows.Forms.Label();
            famaili_EmployeeLabel = new System.Windows.Forms.Label();
            login_EmployeeLabel = new System.Windows.Forms.Label();
            password_EmployeeLabel = new System.Windows.Forms.Label();
            famali_RykovoditelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lazutkinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingNavigator)).BeginInit();
            this.employesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.educationalOrganisationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rykovoditelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominationOlimpiadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominationOlimpiadsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_OrganisationLabel
            // 
            name_OrganisationLabel.AutoSize = true;
            name_OrganisationLabel.Location = new System.Drawing.Point(476, 250);
            name_OrganisationLabel.Name = "name_OrganisationLabel";
            name_OrganisationLabel.Size = new System.Drawing.Size(98, 16);
            name_OrganisationLabel.TabIndex = 24;
            name_OrganisationLabel.Text = "Название ОУ:";
            // 
            // name_NominationLabel
            // 
            name_NominationLabel.AutoSize = true;
            name_NominationLabel.Location = new System.Drawing.Point(422, 195);
            name_NominationLabel.Name = "name_NominationLabel";
            name_NominationLabel.Size = new System.Drawing.Size(152, 16);
            name_NominationLabel.TabIndex = 22;
            name_NominationLabel.Text = "Название номинации:";
            // 
            // phone_EmployeeLabel
            // 
            phone_EmployeeLabel.AutoSize = true;
            phone_EmployeeLabel.Location = new System.Drawing.Point(464, 120);
            phone_EmployeeLabel.Name = "phone_EmployeeLabel";
            phone_EmployeeLabel.Size = new System.Drawing.Size(122, 16);
            phone_EmployeeLabel.TabIndex = 20;
            phone_EmployeeLabel.Text = "Номер телефона:";
            // 
            // otchestvo_EmployeeLabel
            // 
            otchestvo_EmployeeLabel.AutoSize = true;
            otchestvo_EmployeeLabel.Location = new System.Drawing.Point(30, 192);
            otchestvo_EmployeeLabel.Name = "otchestvo_EmployeeLabel";
            otchestvo_EmployeeLabel.Size = new System.Drawing.Size(73, 16);
            otchestvo_EmployeeLabel.TabIndex = 18;
            otchestvo_EmployeeLabel.Text = "Отчество:";
            // 
            // name_EmpoloyeeLabel
            // 
            name_EmpoloyeeLabel.AutoSize = true;
            name_EmpoloyeeLabel.Location = new System.Drawing.Point(67, 154);
            name_EmpoloyeeLabel.Name = "name_EmpoloyeeLabel";
            name_EmpoloyeeLabel.Size = new System.Drawing.Size(36, 16);
            name_EmpoloyeeLabel.TabIndex = 16;
            name_EmpoloyeeLabel.Text = "Имя:";
            // 
            // famaili_EmployeeLabel
            // 
            famaili_EmployeeLabel.AutoSize = true;
            famaili_EmployeeLabel.Location = new System.Drawing.Point(34, 114);
            famaili_EmployeeLabel.Name = "famaili_EmployeeLabel";
            famaili_EmployeeLabel.Size = new System.Drawing.Size(69, 16);
            famaili_EmployeeLabel.TabIndex = 13;
            famaili_EmployeeLabel.Text = "Фамилия:";
            // 
            // login_EmployeeLabel
            // 
            login_EmployeeLabel.AutoSize = true;
            login_EmployeeLabel.Location = new System.Drawing.Point(54, 236);
            login_EmployeeLabel.Name = "login_EmployeeLabel";
            login_EmployeeLabel.Size = new System.Drawing.Size(49, 16);
            login_EmployeeLabel.TabIndex = 28;
            login_EmployeeLabel.Text = "Логин:";
            // 
            // password_EmployeeLabel
            // 
            password_EmployeeLabel.AutoSize = true;
            password_EmployeeLabel.Location = new System.Drawing.Point(44, 282);
            password_EmployeeLabel.Name = "password_EmployeeLabel";
            password_EmployeeLabel.Size = new System.Drawing.Size(59, 16);
            password_EmployeeLabel.TabIndex = 29;
            password_EmployeeLabel.Text = "Пароль:";
            // 
            // famali_RykovoditelLabel
            // 
            famali_RykovoditelLabel.AutoSize = true;
            famali_RykovoditelLabel.Location = new System.Drawing.Point(412, 302);
            famali_RykovoditelLabel.Name = "famali_RykovoditelLabel";
            famali_RykovoditelLabel.Size = new System.Drawing.Size(162, 16);
            famali_RykovoditelLabel.TabIndex = 30;
            famali_RykovoditelLabel.Text = "Фамилия руководителя";
            // 
            // lazutkinDataSet
            // 
            this.lazutkinDataSet.DataSetName = "LazutkinDataSet";
            this.lazutkinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataMember = "Employes";
            this.employesBindingSource.DataSource = this.lazutkinDataSet;
            // 
            // employesTableAdapter
            // 
            this.employesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Educational_OrganisationsTableAdapter = this.educational_OrganisationsTableAdapter;
            this.tableAdapterManager.EmployesTableAdapter = this.employesTableAdapter;
            this.tableAdapterManager.Nomination_OlimpiadsTableAdapter = this.nomination_OlimpiadsTableAdapter;
            this.tableAdapterManager.RykovoditelsTableAdapter = this.rykovoditelsTableAdapter;
            this.tableAdapterManager.UpdateOrder = AppWindows.LazutkinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // educational_OrganisationsTableAdapter
            // 
            this.educational_OrganisationsTableAdapter.ClearBeforeFill = true;
            // 
            // nomination_OlimpiadsTableAdapter
            // 
            this.nomination_OlimpiadsTableAdapter.ClearBeforeFill = true;
            // 
            // rykovoditelsTableAdapter
            // 
            this.rykovoditelsTableAdapter.ClearBeforeFill = true;
            // 
            // employesBindingNavigator
            // 
            this.employesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employesBindingNavigator.BindingSource = this.employesBindingSource;
            this.employesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.employesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employesBindingNavigatorSaveItem});
            this.employesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employesBindingNavigator.Name = "employesBindingNavigator";
            this.employesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employesBindingNavigator.Size = new System.Drawing.Size(965, 27);
            this.employesBindingNavigator.TabIndex = 1;
            this.employesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // employesBindingNavigatorSaveItem
            // 
            this.employesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employesBindingNavigatorSaveItem.Image")));
            this.employesBindingNavigatorSaveItem.Name = "employesBindingNavigatorSaveItem";
            this.employesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.employesBindingNavigatorSaveItem.Text = "Save Data";
            this.employesBindingNavigatorSaveItem.Click += new System.EventHandler(this.employesBindingNavigatorSaveItem_Click);
            // 
            // educationalOrganisationsBindingSource
            // 
            this.educationalOrganisationsBindingSource.DataMember = "Educational_Organisations";
            this.educationalOrganisationsBindingSource.DataSource = this.lazutkinDataSet;
            // 
            // rykovoditelsBindingSource
            // 
            this.rykovoditelsBindingSource.DataMember = "Rykovoditels";
            this.rykovoditelsBindingSource.DataSource = this.lazutkinDataSet;
            // 
            // nominationOlimpiadsBindingSource
            // 
            this.nominationOlimpiadsBindingSource.DataMember = "Nomination_Olimpiads";
            this.nominationOlimpiadsBindingSource.DataSource = this.lazutkinDataSet;
            // 
            // name_OrganisationComboBox
            // 
            this.name_OrganisationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employesBindingSource, "ID_Organisation", true));
            this.name_OrganisationComboBox.DataSource = this.educationalOrganisationsBindingSource;
            this.name_OrganisationComboBox.DisplayMember = "Name_Organisation";
            this.name_OrganisationComboBox.FormattingEnabled = true;
            this.name_OrganisationComboBox.Location = new System.Drawing.Point(592, 247);
            this.name_OrganisationComboBox.Name = "name_OrganisationComboBox";
            this.name_OrganisationComboBox.Size = new System.Drawing.Size(323, 24);
            this.name_OrganisationComboBox.TabIndex = 25;
            this.name_OrganisationComboBox.ValueMember = "ID_Organisation";
            // 
            // name_NominationComboBox
            // 
            this.name_NominationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employesBindingSource, "ID_Nomination", true));
            this.name_NominationComboBox.DataSource = this.nominationOlimpiadsBindingSource;
            this.name_NominationComboBox.DisplayMember = "Name_Nomination";
            this.name_NominationComboBox.FormattingEnabled = true;
            this.name_NominationComboBox.Location = new System.Drawing.Point(592, 192);
            this.name_NominationComboBox.Name = "name_NominationComboBox";
            this.name_NominationComboBox.Size = new System.Drawing.Size(323, 24);
            this.name_NominationComboBox.TabIndex = 23;
            this.name_NominationComboBox.ValueMember = "ID_Nomination";
            // 
            // nominationOlimpiadsBindingSource1
            // 
            this.nominationOlimpiadsBindingSource1.DataMember = "Nomination_Olimpiads";
            this.nominationOlimpiadsBindingSource1.DataSource = this.lazutkinDataSet;
            // 
            // phone_EmployeeTextBox
            // 
            this.phone_EmployeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Phone_Employee", true));
            this.phone_EmployeeTextBox.Location = new System.Drawing.Point(592, 114);
            this.phone_EmployeeTextBox.Name = "phone_EmployeeTextBox";
            this.phone_EmployeeTextBox.Size = new System.Drawing.Size(184, 22);
            this.phone_EmployeeTextBox.TabIndex = 21;
            // 
            // otchestvo_EmployeeTextBox
            // 
            this.otchestvo_EmployeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Otchestvo_Employee", true));
            this.otchestvo_EmployeeTextBox.Location = new System.Drawing.Point(109, 186);
            this.otchestvo_EmployeeTextBox.Name = "otchestvo_EmployeeTextBox";
            this.otchestvo_EmployeeTextBox.Size = new System.Drawing.Size(221, 22);
            this.otchestvo_EmployeeTextBox.TabIndex = 19;
            // 
            // name_EmpoloyeeTextBox
            // 
            this.name_EmpoloyeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Name_Empoloyee", true));
            this.name_EmpoloyeeTextBox.Location = new System.Drawing.Point(109, 148);
            this.name_EmpoloyeeTextBox.Name = "name_EmpoloyeeTextBox";
            this.name_EmpoloyeeTextBox.Size = new System.Drawing.Size(221, 22);
            this.name_EmpoloyeeTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(409, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Данные участника";
            // 
            // famaili_EmployeeTextBox
            // 
            this.famaili_EmployeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Famaili_Employee", true));
            this.famaili_EmployeeTextBox.Location = new System.Drawing.Point(109, 108);
            this.famaili_EmployeeTextBox.Name = "famaili_EmployeeTextBox";
            this.famaili_EmployeeTextBox.Size = new System.Drawing.Size(221, 22);
            this.famaili_EmployeeTextBox.TabIndex = 14;
            // 
            // BackMainForm
            // 
            this.BackMainForm.Location = new System.Drawing.Point(225, 357);
            this.BackMainForm.Name = "BackMainForm";
            this.BackMainForm.Size = new System.Drawing.Size(75, 23);
            this.BackMainForm.TabIndex = 28;
            this.BackMainForm.Text = "Назад";
            this.BackMainForm.UseVisualStyleBackColor = true;
            this.BackMainForm.Click += new System.EventHandler(this.BackMainForm_Click);
            // 
            // login_EmployeeTextBox
            // 
            this.login_EmployeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Login_Employee", true));
            this.login_EmployeeTextBox.Location = new System.Drawing.Point(109, 230);
            this.login_EmployeeTextBox.Name = "login_EmployeeTextBox";
            this.login_EmployeeTextBox.Size = new System.Drawing.Size(221, 22);
            this.login_EmployeeTextBox.TabIndex = 29;
            // 
            // password_EmployeeTextBox
            // 
            this.password_EmployeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Password_Employee", true));
            this.password_EmployeeTextBox.Location = new System.Drawing.Point(109, 276);
            this.password_EmployeeTextBox.Name = "password_EmployeeTextBox";
            this.password_EmployeeTextBox.PasswordChar = '*';
            this.password_EmployeeTextBox.Size = new System.Drawing.Size(221, 22);
            this.password_EmployeeTextBox.TabIndex = 30;
            // 
            // famali_RykovoditelComboBox
            // 
            this.famali_RykovoditelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rykovoditelsBindingSource, "Famali_Rykovoditel", true));
            this.famali_RykovoditelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employesBindingSource, "ID_Rykovoditel", true));
            this.famali_RykovoditelComboBox.DataSource = this.rykovoditelsBindingSource;
            this.famali_RykovoditelComboBox.DisplayMember = "Famali_Rykovoditel";
            this.famali_RykovoditelComboBox.FormattingEnabled = true;
            this.famali_RykovoditelComboBox.Location = new System.Drawing.Point(592, 294);
            this.famali_RykovoditelComboBox.Name = "famali_RykovoditelComboBox";
            this.famali_RykovoditelComboBox.Size = new System.Drawing.Size(323, 24);
            this.famali_RykovoditelComboBox.TabIndex = 31;
            this.famali_RykovoditelComboBox.ValueMember = "ID_Rykovoditel";
            // 
            // allEmpoyeeBtn
            // 
            this.allEmpoyeeBtn.Location = new System.Drawing.Point(86, 357);
            this.allEmpoyeeBtn.Name = "allEmpoyeeBtn";
            this.allEmpoyeeBtn.Size = new System.Drawing.Size(133, 23);
            this.allEmpoyeeBtn.TabIndex = 32;
            this.allEmpoyeeBtn.Text = "Все участники";
            this.allEmpoyeeBtn.UseVisualStyleBackColor = true;
            this.allEmpoyeeBtn.Click += new System.EventHandler(this.allEmpoyeeBtn_Click);
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.addEmployeeBtn.Location = new System.Drawing.Point(342, 352);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(113, 28);
            this.addEmployeeBtn.TabIndex = 33;
            this.addEmployeeBtn.Text = "Добавить";
            this.addEmployeeBtn.UseVisualStyleBackColor = false;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // editEmployeeBtn
            // 
            this.editEmployeeBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.editEmployeeBtn.Location = new System.Drawing.Point(461, 352);
            this.editEmployeeBtn.Name = "editEmployeeBtn";
            this.editEmployeeBtn.Size = new System.Drawing.Size(113, 28);
            this.editEmployeeBtn.TabIndex = 34;
            this.editEmployeeBtn.Text = "Изменить";
            this.editEmployeeBtn.UseVisualStyleBackColor = false;
            this.editEmployeeBtn.Click += new System.EventHandler(this.editEmployeeBtn_Click);
            // 
            // removeEmployeeBtn
            // 
            this.removeEmployeeBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.removeEmployeeBtn.Location = new System.Drawing.Point(580, 352);
            this.removeEmployeeBtn.Name = "removeEmployeeBtn";
            this.removeEmployeeBtn.Size = new System.Drawing.Size(113, 28);
            this.removeEmployeeBtn.TabIndex = 35;
            this.removeEmployeeBtn.Text = "Удалить";
            this.removeEmployeeBtn.UseVisualStyleBackColor = false;
            this.removeEmployeeBtn.Click += new System.EventHandler(this.removeEmployeeBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 493);
            this.Controls.Add(this.removeEmployeeBtn);
            this.Controls.Add(this.editEmployeeBtn);
            this.Controls.Add(this.addEmployeeBtn);
            this.Controls.Add(this.allEmpoyeeBtn);
            this.Controls.Add(famali_RykovoditelLabel);
            this.Controls.Add(this.famali_RykovoditelComboBox);
            this.Controls.Add(password_EmployeeLabel);
            this.Controls.Add(this.password_EmployeeTextBox);
            this.Controls.Add(login_EmployeeLabel);
            this.Controls.Add(this.login_EmployeeTextBox);
            this.Controls.Add(this.BackMainForm);
            this.Controls.Add(name_OrganisationLabel);
            this.Controls.Add(this.name_OrganisationComboBox);
            this.Controls.Add(name_NominationLabel);
            this.Controls.Add(this.name_NominationComboBox);
            this.Controls.Add(phone_EmployeeLabel);
            this.Controls.Add(this.phone_EmployeeTextBox);
            this.Controls.Add(otchestvo_EmployeeLabel);
            this.Controls.Add(this.otchestvo_EmployeeTextBox);
            this.Controls.Add(name_EmpoloyeeLabel);
            this.Controls.Add(this.name_EmpoloyeeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(famaili_EmployeeLabel);
            this.Controls.Add(this.famaili_EmployeeTextBox);
            this.Controls.Add(this.employesBindingNavigator);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lazutkinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingNavigator)).EndInit();
            this.employesBindingNavigator.ResumeLayout(false);
            this.employesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.educationalOrganisationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rykovoditelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominationOlimpiadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominationOlimpiadsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LazutkinDataSet lazutkinDataSet;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private LazutkinDataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
        private LazutkinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employesBindingNavigatorSaveItem;
        private LazutkinDataSetTableAdapters.Educational_OrganisationsTableAdapter educational_OrganisationsTableAdapter;
        private System.Windows.Forms.BindingSource educationalOrganisationsBindingSource;
        private LazutkinDataSetTableAdapters.RykovoditelsTableAdapter rykovoditelsTableAdapter;
        private System.Windows.Forms.BindingSource rykovoditelsBindingSource;
        private LazutkinDataSetTableAdapters.Nomination_OlimpiadsTableAdapter nomination_OlimpiadsTableAdapter;
        private System.Windows.Forms.BindingSource nominationOlimpiadsBindingSource;
        private System.Windows.Forms.ComboBox name_OrganisationComboBox;
        private System.Windows.Forms.ComboBox name_NominationComboBox;
        private System.Windows.Forms.TextBox phone_EmployeeTextBox;
        private System.Windows.Forms.TextBox otchestvo_EmployeeTextBox;
        private System.Windows.Forms.TextBox name_EmpoloyeeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox famaili_EmployeeTextBox;
        private System.Windows.Forms.Button BackMainForm;
        private System.Windows.Forms.BindingSource nominationOlimpiadsBindingSource1;
        private System.Windows.Forms.TextBox login_EmployeeTextBox;
        private System.Windows.Forms.TextBox password_EmployeeTextBox;
        private System.Windows.Forms.ComboBox famali_RykovoditelComboBox;
        private System.Windows.Forms.Button allEmpoyeeBtn;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button editEmployeeBtn;
        private System.Windows.Forms.Button removeEmployeeBtn;
    }
}