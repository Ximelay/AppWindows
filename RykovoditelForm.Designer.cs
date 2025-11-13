namespace AppWindows
{
    partial class RykovoditelForm
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
            System.Windows.Forms.Label famali_RykovoditelLabel;
            System.Windows.Forms.Label name_RykovoditelLabel;
            System.Windows.Forms.Label otchestvo_RykovoditelLabel;
            System.Windows.Forms.Label phone_RykovoditelLabel;
            System.Windows.Forms.Label login_RekovoditelLabel;
            System.Windows.Forms.Label password_RykovoditelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RykovoditelForm));
            this.backMainForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lazutkinDataSet = new AppWindows.LazutkinDataSet();
            this.rykovoditelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rykovoditelsTableAdapter = new AppWindows.LazutkinDataSetTableAdapters.RykovoditelsTableAdapter();
            this.tableAdapterManager = new AppWindows.LazutkinDataSetTableAdapters.TableAdapterManager();
            this.rykovoditelsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rykovoditelsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.famali_RykovoditelTextBox = new System.Windows.Forms.TextBox();
            this.name_RykovoditelTextBox = new System.Windows.Forms.TextBox();
            this.otchestvo_RykovoditelTextBox = new System.Windows.Forms.TextBox();
            this.phone_RykovoditelTextBox = new System.Windows.Forms.TextBox();
            this.login_RekovoditelTextBox = new System.Windows.Forms.TextBox();
            this.password_RykovoditelTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.saveRykovoditelBtn = new System.Windows.Forms.Button();
            this.removeRykovoditelBtn = new System.Windows.Forms.Button();
            this.editRykovoditelBtn = new System.Windows.Forms.Button();
            this.addRykovoditelBtn = new System.Windows.Forms.Button();
            famali_RykovoditelLabel = new System.Windows.Forms.Label();
            name_RykovoditelLabel = new System.Windows.Forms.Label();
            otchestvo_RykovoditelLabel = new System.Windows.Forms.Label();
            phone_RykovoditelLabel = new System.Windows.Forms.Label();
            login_RekovoditelLabel = new System.Windows.Forms.Label();
            password_RykovoditelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lazutkinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rykovoditelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rykovoditelsBindingNavigator)).BeginInit();
            this.rykovoditelsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // famali_RykovoditelLabel
            // 
            famali_RykovoditelLabel.AutoSize = true;
            famali_RykovoditelLabel.Location = new System.Drawing.Point(34, 96);
            famali_RykovoditelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            famali_RykovoditelLabel.Name = "famali_RykovoditelLabel";
            famali_RykovoditelLabel.Size = new System.Drawing.Size(59, 13);
            famali_RykovoditelLabel.TabIndex = 3;
            famali_RykovoditelLabel.Text = "Фамилия:";
            // 
            // name_RykovoditelLabel
            // 
            name_RykovoditelLabel.AutoSize = true;
            name_RykovoditelLabel.Location = new System.Drawing.Point(58, 128);
            name_RykovoditelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            name_RykovoditelLabel.Name = "name_RykovoditelLabel";
            name_RykovoditelLabel.Size = new System.Drawing.Size(32, 13);
            name_RykovoditelLabel.TabIndex = 5;
            name_RykovoditelLabel.Text = "Имя:";
            // 
            // otchestvo_RykovoditelLabel
            // 
            otchestvo_RykovoditelLabel.AutoSize = true;
            otchestvo_RykovoditelLabel.Location = new System.Drawing.Point(31, 162);
            otchestvo_RykovoditelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            otchestvo_RykovoditelLabel.Name = "otchestvo_RykovoditelLabel";
            otchestvo_RykovoditelLabel.Size = new System.Drawing.Size(57, 13);
            otchestvo_RykovoditelLabel.TabIndex = 7;
            otchestvo_RykovoditelLabel.Text = "Отчество:";
            // 
            // phone_RykovoditelLabel
            // 
            phone_RykovoditelLabel.AutoSize = true;
            phone_RykovoditelLabel.Location = new System.Drawing.Point(404, 93);
            phone_RykovoditelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            phone_RykovoditelLabel.Name = "phone_RykovoditelLabel";
            phone_RykovoditelLabel.Size = new System.Drawing.Size(93, 13);
            phone_RykovoditelLabel.TabIndex = 9;
            phone_RykovoditelLabel.Text = "Номер телефона";
            // 
            // login_RekovoditelLabel
            // 
            login_RekovoditelLabel.AutoSize = true;
            login_RekovoditelLabel.Location = new System.Drawing.Point(49, 201);
            login_RekovoditelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            login_RekovoditelLabel.Name = "login_RekovoditelLabel";
            login_RekovoditelLabel.Size = new System.Drawing.Size(41, 13);
            login_RekovoditelLabel.TabIndex = 11;
            login_RekovoditelLabel.Text = "Логин:";
            // 
            // password_RykovoditelLabel
            // 
            password_RykovoditelLabel.AutoSize = true;
            password_RykovoditelLabel.Location = new System.Drawing.Point(41, 235);
            password_RykovoditelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            password_RykovoditelLabel.Name = "password_RykovoditelLabel";
            password_RykovoditelLabel.Size = new System.Drawing.Size(48, 13);
            password_RykovoditelLabel.TabIndex = 13;
            password_RykovoditelLabel.Text = "Пароль:";
            // 
            // backMainForm
            // 
            this.backMainForm.Location = new System.Drawing.Point(173, 308);
            this.backMainForm.Margin = new System.Windows.Forms.Padding(2);
            this.backMainForm.Name = "backMainForm";
            this.backMainForm.Size = new System.Drawing.Size(67, 19);
            this.backMainForm.TabIndex = 0;
            this.backMainForm.Text = "Назад";
            this.backMainForm.UseVisualStyleBackColor = true;
            this.backMainForm.Click += new System.EventHandler(this.backMainForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(300, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Данные руководителя";
            // 
            // lazutkinDataSet
            // 
            this.lazutkinDataSet.DataSetName = "LazutkinDataSet";
            this.lazutkinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rykovoditelsBindingSource
            // 
            this.rykovoditelsBindingSource.DataMember = "Rykovoditels";
            this.rykovoditelsBindingSource.DataSource = this.lazutkinDataSet;
            // 
            // rykovoditelsTableAdapter
            // 
            this.rykovoditelsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Educational_OrganisationsTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = null;
            this.tableAdapterManager.Nomination_OlimpiadsTableAdapter = null;
            this.tableAdapterManager.RykovoditelsTableAdapter = this.rykovoditelsTableAdapter;
            this.tableAdapterManager.UpdateOrder = AppWindows.LazutkinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rykovoditelsBindingNavigator
            // 
            this.rykovoditelsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rykovoditelsBindingNavigator.BindingSource = this.rykovoditelsBindingSource;
            this.rykovoditelsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rykovoditelsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rykovoditelsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rykovoditelsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rykovoditelsBindingNavigatorSaveItem});
            this.rykovoditelsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rykovoditelsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rykovoditelsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rykovoditelsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rykovoditelsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rykovoditelsBindingNavigator.Name = "rykovoditelsBindingNavigator";
            this.rykovoditelsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rykovoditelsBindingNavigator.Size = new System.Drawing.Size(724, 27);
            this.rykovoditelsBindingNavigator.TabIndex = 2;
            this.rykovoditelsBindingNavigator.Text = "bindingNavigator1";
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
            // rykovoditelsBindingNavigatorSaveItem
            // 
            this.rykovoditelsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rykovoditelsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rykovoditelsBindingNavigatorSaveItem.Image")));
            this.rykovoditelsBindingNavigatorSaveItem.Name = "rykovoditelsBindingNavigatorSaveItem";
            this.rykovoditelsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.rykovoditelsBindingNavigatorSaveItem.Text = "Save Data";
            this.rykovoditelsBindingNavigatorSaveItem.Click += new System.EventHandler(this.rykovoditelsBindingNavigatorSaveItem_Click);
            // 
            // famali_RykovoditelTextBox
            // 
            this.famali_RykovoditelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rykovoditelsBindingSource, "Famali_Rykovoditel", true));
            this.famali_RykovoditelTextBox.Location = new System.Drawing.Point(90, 91);
            this.famali_RykovoditelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.famali_RykovoditelTextBox.Name = "famali_RykovoditelTextBox";
            this.famali_RykovoditelTextBox.Size = new System.Drawing.Size(178, 20);
            this.famali_RykovoditelTextBox.TabIndex = 4;
            // 
            // name_RykovoditelTextBox
            // 
            this.name_RykovoditelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rykovoditelsBindingSource, "Name_Rykovoditel", true));
            this.name_RykovoditelTextBox.Location = new System.Drawing.Point(90, 124);
            this.name_RykovoditelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.name_RykovoditelTextBox.Name = "name_RykovoditelTextBox";
            this.name_RykovoditelTextBox.Size = new System.Drawing.Size(178, 20);
            this.name_RykovoditelTextBox.TabIndex = 6;
            // 
            // otchestvo_RykovoditelTextBox
            // 
            this.otchestvo_RykovoditelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rykovoditelsBindingSource, "Otchestvo_Rykovoditel", true));
            this.otchestvo_RykovoditelTextBox.Location = new System.Drawing.Point(90, 157);
            this.otchestvo_RykovoditelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.otchestvo_RykovoditelTextBox.Name = "otchestvo_RykovoditelTextBox";
            this.otchestvo_RykovoditelTextBox.Size = new System.Drawing.Size(178, 20);
            this.otchestvo_RykovoditelTextBox.TabIndex = 8;
            // 
            // phone_RykovoditelTextBox
            // 
            this.phone_RykovoditelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rykovoditelsBindingSource, "Phone_Rykovoditel", true));
            this.phone_RykovoditelTextBox.Location = new System.Drawing.Point(501, 91);
            this.phone_RykovoditelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.phone_RykovoditelTextBox.Name = "phone_RykovoditelTextBox";
            this.phone_RykovoditelTextBox.Size = new System.Drawing.Size(150, 20);
            this.phone_RykovoditelTextBox.TabIndex = 10;
            // 
            // login_RekovoditelTextBox
            // 
            this.login_RekovoditelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rykovoditelsBindingSource, "Login_Rekovoditel", true));
            this.login_RekovoditelTextBox.Location = new System.Drawing.Point(90, 196);
            this.login_RekovoditelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.login_RekovoditelTextBox.Name = "login_RekovoditelTextBox";
            this.login_RekovoditelTextBox.Size = new System.Drawing.Size(178, 20);
            this.login_RekovoditelTextBox.TabIndex = 12;
            // 
            // password_RykovoditelTextBox
            // 
            this.password_RykovoditelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rykovoditelsBindingSource, "Password_Rykovoditel", true));
            this.password_RykovoditelTextBox.Location = new System.Drawing.Point(90, 230);
            this.password_RykovoditelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.password_RykovoditelTextBox.Name = "password_RykovoditelTextBox";
            this.password_RykovoditelTextBox.Size = new System.Drawing.Size(178, 20);
            this.password_RykovoditelTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 19);
            this.button1.TabIndex = 15;
            this.button1.Text = "Все руководители";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(334, 259);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(75, 23);
            this.previousBtn.TabIndex = 44;
            this.previousBtn.Text = "<-";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(415, 259);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 43;
            this.nextBtn.Text = "->";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // saveRykovoditelBtn
            // 
            this.saveRykovoditelBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveRykovoditelBtn.Location = new System.Drawing.Point(593, 306);
            this.saveRykovoditelBtn.Name = "saveRykovoditelBtn";
            this.saveRykovoditelBtn.Size = new System.Drawing.Size(75, 23);
            this.saveRykovoditelBtn.TabIndex = 42;
            this.saveRykovoditelBtn.Text = "Сохранить";
            this.saveRykovoditelBtn.UseVisualStyleBackColor = false;
            this.saveRykovoditelBtn.Click += new System.EventHandler(this.saveRykovoditelBtn_Click);
            // 
            // removeRykovoditelBtn
            // 
            this.removeRykovoditelBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.removeRykovoditelBtn.Location = new System.Drawing.Point(503, 304);
            this.removeRykovoditelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeRykovoditelBtn.Name = "removeRykovoditelBtn";
            this.removeRykovoditelBtn.Size = new System.Drawing.Size(85, 23);
            this.removeRykovoditelBtn.TabIndex = 41;
            this.removeRykovoditelBtn.Text = "Удалить";
            this.removeRykovoditelBtn.UseVisualStyleBackColor = false;
            this.removeRykovoditelBtn.Click += new System.EventHandler(this.removeRykovoditelBtn_Click);
            // 
            // editRykovoditelBtn
            // 
            this.editRykovoditelBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.editRykovoditelBtn.Location = new System.Drawing.Point(414, 304);
            this.editRykovoditelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editRykovoditelBtn.Name = "editRykovoditelBtn";
            this.editRykovoditelBtn.Size = new System.Drawing.Size(85, 23);
            this.editRykovoditelBtn.TabIndex = 40;
            this.editRykovoditelBtn.Text = "Изменить";
            this.editRykovoditelBtn.UseVisualStyleBackColor = false;
            this.editRykovoditelBtn.Click += new System.EventHandler(this.editRykovoditelBtn_Click);
            // 
            // addRykovoditelBtn
            // 
            this.addRykovoditelBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.addRykovoditelBtn.Location = new System.Drawing.Point(324, 304);
            this.addRykovoditelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addRykovoditelBtn.Name = "addRykovoditelBtn";
            this.addRykovoditelBtn.Size = new System.Drawing.Size(85, 23);
            this.addRykovoditelBtn.TabIndex = 39;
            this.addRykovoditelBtn.Text = "Добавить";
            this.addRykovoditelBtn.UseVisualStyleBackColor = false;
            this.addRykovoditelBtn.Click += new System.EventHandler(this.addRykovoditelBtn_Click);
            // 
            // RykovoditelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 384);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.saveRykovoditelBtn);
            this.Controls.Add(this.removeRykovoditelBtn);
            this.Controls.Add(this.editRykovoditelBtn);
            this.Controls.Add(this.addRykovoditelBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(password_RykovoditelLabel);
            this.Controls.Add(this.password_RykovoditelTextBox);
            this.Controls.Add(login_RekovoditelLabel);
            this.Controls.Add(this.login_RekovoditelTextBox);
            this.Controls.Add(phone_RykovoditelLabel);
            this.Controls.Add(this.phone_RykovoditelTextBox);
            this.Controls.Add(otchestvo_RykovoditelLabel);
            this.Controls.Add(this.otchestvo_RykovoditelTextBox);
            this.Controls.Add(name_RykovoditelLabel);
            this.Controls.Add(this.name_RykovoditelTextBox);
            this.Controls.Add(famali_RykovoditelLabel);
            this.Controls.Add(this.famali_RykovoditelTextBox);
            this.Controls.Add(this.rykovoditelsBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backMainForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RykovoditelForm";
            this.Text = "RykovoditelForm";
            this.Load += new System.EventHandler(this.RykovoditelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lazutkinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rykovoditelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rykovoditelsBindingNavigator)).EndInit();
            this.rykovoditelsBindingNavigator.ResumeLayout(false);
            this.rykovoditelsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backMainForm;
        private System.Windows.Forms.Label label1;
        private LazutkinDataSet lazutkinDataSet;
        private System.Windows.Forms.BindingSource rykovoditelsBindingSource;
        private LazutkinDataSetTableAdapters.RykovoditelsTableAdapter rykovoditelsTableAdapter;
        private LazutkinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rykovoditelsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rykovoditelsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox famali_RykovoditelTextBox;
        private System.Windows.Forms.TextBox name_RykovoditelTextBox;
        private System.Windows.Forms.TextBox otchestvo_RykovoditelTextBox;
        private System.Windows.Forms.TextBox phone_RykovoditelTextBox;
        private System.Windows.Forms.TextBox login_RekovoditelTextBox;
        private System.Windows.Forms.TextBox password_RykovoditelTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button saveRykovoditelBtn;
        private System.Windows.Forms.Button removeRykovoditelBtn;
        private System.Windows.Forms.Button editRykovoditelBtn;
        private System.Windows.Forms.Button addRykovoditelBtn;
    }
}