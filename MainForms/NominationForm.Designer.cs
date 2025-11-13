namespace AppWindows
{
    partial class NominationForm
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
            System.Windows.Forms.Label name_NominationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NominationForm));
            this.lazutkinDataSet = new AppWindows.LazutkinDataSet();
            this.nomination_OlimpiadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomination_OlimpiadsTableAdapter = new AppWindows.LazutkinDataSetTableAdapters.Nomination_OlimpiadsTableAdapter();
            this.tableAdapterManager = new AppWindows.LazutkinDataSetTableAdapters.TableAdapterManager();
            this.nomination_OlimpiadsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nomination_OlimpiadsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.saveNominationBtn = new System.Windows.Forms.Button();
            this.removeNominationBtn = new System.Windows.Forms.Button();
            this.editNominationBtn = new System.Windows.Forms.Button();
            this.addNominationBtn = new System.Windows.Forms.Button();
            this.AllNominationsBtn = new System.Windows.Forms.Button();
            this.backMainForm = new System.Windows.Forms.Button();
            this.name_NominationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            name_NominationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lazutkinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomination_OlimpiadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomination_OlimpiadsBindingNavigator)).BeginInit();
            this.nomination_OlimpiadsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_NominationLabel
            // 
            name_NominationLabel.AutoSize = true;
            name_NominationLabel.Location = new System.Drawing.Point(214, 108);
            name_NominationLabel.Name = "name_NominationLabel";
            name_NominationLabel.Size = new System.Drawing.Size(119, 13);
            name_NominationLabel.TabIndex = 52;
            name_NominationLabel.Text = "Название номинации:";
            // 
            // lazutkinDataSet
            // 
            this.lazutkinDataSet.DataSetName = "LazutkinDataSet";
            this.lazutkinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nomination_OlimpiadsBindingSource
            // 
            this.nomination_OlimpiadsBindingSource.DataMember = "Nomination_Olimpiads";
            this.nomination_OlimpiadsBindingSource.DataSource = this.lazutkinDataSet;
            // 
            // nomination_OlimpiadsTableAdapter
            // 
            this.nomination_OlimpiadsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Educational_OrganisationsTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = null;
            this.tableAdapterManager.Nomination_OlimpiadsTableAdapter = this.nomination_OlimpiadsTableAdapter;
            this.tableAdapterManager.RykovoditelsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppWindows.LazutkinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nomination_OlimpiadsBindingNavigator
            // 
            this.nomination_OlimpiadsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nomination_OlimpiadsBindingNavigator.BindingSource = this.nomination_OlimpiadsBindingSource;
            this.nomination_OlimpiadsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nomination_OlimpiadsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nomination_OlimpiadsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nomination_OlimpiadsBindingNavigatorSaveItem});
            this.nomination_OlimpiadsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nomination_OlimpiadsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nomination_OlimpiadsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nomination_OlimpiadsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nomination_OlimpiadsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nomination_OlimpiadsBindingNavigator.Name = "nomination_OlimpiadsBindingNavigator";
            this.nomination_OlimpiadsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nomination_OlimpiadsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.nomination_OlimpiadsBindingNavigator.TabIndex = 0;
            this.nomination_OlimpiadsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nomination_OlimpiadsBindingNavigatorSaveItem
            // 
            this.nomination_OlimpiadsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nomination_OlimpiadsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nomination_OlimpiadsBindingNavigatorSaveItem.Image")));
            this.nomination_OlimpiadsBindingNavigatorSaveItem.Name = "nomination_OlimpiadsBindingNavigatorSaveItem";
            this.nomination_OlimpiadsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nomination_OlimpiadsBindingNavigatorSaveItem.Text = "Save Data";
            this.nomination_OlimpiadsBindingNavigatorSaveItem.Click += new System.EventHandler(this.nomination_OlimpiadsBindingNavigatorSaveItem_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(373, 240);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(75, 23);
            this.previousBtn.TabIndex = 52;
            this.previousBtn.Text = "<-";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(454, 240);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 51;
            this.nextBtn.Text = "->";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // saveNominationBtn
            // 
            this.saveNominationBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveNominationBtn.Location = new System.Drawing.Point(632, 287);
            this.saveNominationBtn.Name = "saveNominationBtn";
            this.saveNominationBtn.Size = new System.Drawing.Size(75, 23);
            this.saveNominationBtn.TabIndex = 50;
            this.saveNominationBtn.Text = "Сохранить";
            this.saveNominationBtn.UseVisualStyleBackColor = false;
            this.saveNominationBtn.Click += new System.EventHandler(this.saveNominationBtn_Click);
            // 
            // removeNominationBtn
            // 
            this.removeNominationBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.removeNominationBtn.Location = new System.Drawing.Point(542, 285);
            this.removeNominationBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeNominationBtn.Name = "removeNominationBtn";
            this.removeNominationBtn.Size = new System.Drawing.Size(85, 23);
            this.removeNominationBtn.TabIndex = 49;
            this.removeNominationBtn.Text = "Удалить";
            this.removeNominationBtn.UseVisualStyleBackColor = false;
            this.removeNominationBtn.Click += new System.EventHandler(this.removeNominationBtn_Click);
            // 
            // editNominationBtn
            // 
            this.editNominationBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.editNominationBtn.Location = new System.Drawing.Point(453, 285);
            this.editNominationBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editNominationBtn.Name = "editNominationBtn";
            this.editNominationBtn.Size = new System.Drawing.Size(85, 23);
            this.editNominationBtn.TabIndex = 48;
            this.editNominationBtn.Text = "Изменить";
            this.editNominationBtn.UseVisualStyleBackColor = false;
            this.editNominationBtn.Click += new System.EventHandler(this.editNominationBtn_Click);
            // 
            // addNominationBtn
            // 
            this.addNominationBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.addNominationBtn.Location = new System.Drawing.Point(363, 285);
            this.addNominationBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addNominationBtn.Name = "addNominationBtn";
            this.addNominationBtn.Size = new System.Drawing.Size(85, 23);
            this.addNominationBtn.TabIndex = 47;
            this.addNominationBtn.Text = "Добавить";
            this.addNominationBtn.UseVisualStyleBackColor = false;
            this.addNominationBtn.Click += new System.EventHandler(this.addNominationBtn_Click);
            // 
            // AllNominationsBtn
            // 
            this.AllNominationsBtn.Location = new System.Drawing.Point(90, 289);
            this.AllNominationsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AllNominationsBtn.Name = "AllNominationsBtn";
            this.AllNominationsBtn.Size = new System.Drawing.Size(118, 19);
            this.AllNominationsBtn.TabIndex = 46;
            this.AllNominationsBtn.Text = "Все номинации";
            this.AllNominationsBtn.UseVisualStyleBackColor = true;
            this.AllNominationsBtn.Click += new System.EventHandler(this.AllNominationsBtn_Click);
            // 
            // backMainForm
            // 
            this.backMainForm.Location = new System.Drawing.Point(212, 289);
            this.backMainForm.Margin = new System.Windows.Forms.Padding(2);
            this.backMainForm.Name = "backMainForm";
            this.backMainForm.Size = new System.Drawing.Size(67, 19);
            this.backMainForm.TabIndex = 45;
            this.backMainForm.Text = "Назад";
            this.backMainForm.UseVisualStyleBackColor = true;
            this.backMainForm.Click += new System.EventHandler(this.backMainForm_Click);
            // 
            // name_NominationTextBox
            // 
            this.name_NominationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nomination_OlimpiadsBindingSource, "Name_Nomination", true));
            this.name_NominationTextBox.Location = new System.Drawing.Point(339, 105);
            this.name_NominationTextBox.Name = "name_NominationTextBox";
            this.name_NominationTextBox.Size = new System.Drawing.Size(237, 20);
            this.name_NominationTextBox.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(336, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Данные номинаций";
            // 
            // NominationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(name_NominationLabel);
            this.Controls.Add(this.name_NominationTextBox);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.saveNominationBtn);
            this.Controls.Add(this.removeNominationBtn);
            this.Controls.Add(this.editNominationBtn);
            this.Controls.Add(this.addNominationBtn);
            this.Controls.Add(this.AllNominationsBtn);
            this.Controls.Add(this.backMainForm);
            this.Controls.Add(this.nomination_OlimpiadsBindingNavigator);
            this.Name = "NominationForm";
            this.Text = "NominationForm";
            this.Load += new System.EventHandler(this.NominationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lazutkinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomination_OlimpiadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomination_OlimpiadsBindingNavigator)).EndInit();
            this.nomination_OlimpiadsBindingNavigator.ResumeLayout(false);
            this.nomination_OlimpiadsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LazutkinDataSet lazutkinDataSet;
        private System.Windows.Forms.BindingSource nomination_OlimpiadsBindingSource;
        private LazutkinDataSetTableAdapters.Nomination_OlimpiadsTableAdapter nomination_OlimpiadsTableAdapter;
        private LazutkinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nomination_OlimpiadsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nomination_OlimpiadsBindingNavigatorSaveItem;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button saveNominationBtn;
        private System.Windows.Forms.Button removeNominationBtn;
        private System.Windows.Forms.Button editNominationBtn;
        private System.Windows.Forms.Button addNominationBtn;
        private System.Windows.Forms.Button AllNominationsBtn;
        private System.Windows.Forms.Button backMainForm;
        private System.Windows.Forms.TextBox name_NominationTextBox;
        private System.Windows.Forms.Label label1;
    }
}