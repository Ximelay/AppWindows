namespace AppWindows.Sql_queryForms
{
    partial class SortByOrganizations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortByOrganizations));
            this.lazutkinDataSet = new AppWindows.LazutkinDataSet();
            this.сортировкаПоОрганизациямBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сортировкаПоОрганизациямTableAdapter = new AppWindows.LazutkinDataSetTableAdapters.СортировкаПоОрганизациямTableAdapter();
            this.tableAdapterManager = new AppWindows.LazutkinDataSetTableAdapters.TableAdapterManager();
            this.сортировкаПоОрганизациямBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.сортировкаПоОрганизациямBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.сортировкаПоОрганизациямDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backMainForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lazutkinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортировкаПоОрганизациямBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортировкаПоОрганизациямBindingNavigator)).BeginInit();
            this.сортировкаПоОрганизациямBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сортировкаПоОрганизациямDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lazutkinDataSet
            // 
            this.lazutkinDataSet.DataSetName = "LazutkinDataSet";
            this.lazutkinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сортировкаПоОрганизациямBindingSource
            // 
            this.сортировкаПоОрганизациямBindingSource.DataMember = "СортировкаПоОрганизациям";
            this.сортировкаПоОрганизациямBindingSource.DataSource = this.lazutkinDataSet;
            // 
            // сортировкаПоОрганизациямTableAdapter
            // 
            this.сортировкаПоОрганизациямTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Educational_OrganisationsTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = null;
            this.tableAdapterManager.Nomination_OlimpiadsTableAdapter = null;
            this.tableAdapterManager.RykovoditelsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppWindows.LazutkinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // сортировкаПоОрганизациямBindingNavigator
            // 
            this.сортировкаПоОрганизациямBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.сортировкаПоОрганизациямBindingNavigator.BindingSource = this.сортировкаПоОрганизациямBindingSource;
            this.сортировкаПоОрганизациямBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.сортировкаПоОрганизациямBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.сортировкаПоОрганизациямBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.сортировкаПоОрганизациямBindingNavigatorSaveItem});
            this.сортировкаПоОрганизациямBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.сортировкаПоОрганизациямBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.сортировкаПоОрганизациямBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.сортировкаПоОрганизациямBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.сортировкаПоОрганизациямBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.сортировкаПоОрганизациямBindingNavigator.Name = "сортировкаПоОрганизациямBindingNavigator";
            this.сортировкаПоОрганизациямBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.сортировкаПоОрганизациямBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.сортировкаПоОрганизациямBindingNavigator.TabIndex = 0;
            this.сортировкаПоОрганизациямBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // сортировкаПоОрганизациямBindingNavigatorSaveItem
            // 
            this.сортировкаПоОрганизациямBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сортировкаПоОрганизациямBindingNavigatorSaveItem.Enabled = false;
            this.сортировкаПоОрганизациямBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("сортировкаПоОрганизациямBindingNavigatorSaveItem.Image")));
            this.сортировкаПоОрганизациямBindingNavigatorSaveItem.Name = "сортировкаПоОрганизациямBindingNavigatorSaveItem";
            this.сортировкаПоОрганизациямBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.сортировкаПоОрганизациямBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // сортировкаПоОрганизациямDataGridView
            // 
            this.сортировкаПоОрганизациямDataGridView.AutoGenerateColumns = false;
            this.сортировкаПоОрганизациямDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сортировкаПоОрганизациямDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.сортировкаПоОрганизациямDataGridView.DataSource = this.сортировкаПоОрганизациямBindingSource;
            this.сортировкаПоОрганизациямDataGridView.Location = new System.Drawing.Point(12, 28);
            this.сортировкаПоОрганизациямDataGridView.Name = "сортировкаПоОрганизациямDataGridView";
            this.сортировкаПоОрганизациямDataGridView.Size = new System.Drawing.Size(776, 365);
            this.сортировкаПоОрганизациямDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Название_Организации";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название_Организации";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Количество_участников";
            this.dataGridViewTextBoxColumn2.HeaderText = "Количество_участников";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // backMainForm
            // 
            this.backMainForm.Location = new System.Drawing.Point(30, 415);
            this.backMainForm.Name = "backMainForm";
            this.backMainForm.Size = new System.Drawing.Size(75, 23);
            this.backMainForm.TabIndex = 3;
            this.backMainForm.Text = "Назад";
            this.backMainForm.UseVisualStyleBackColor = true;
            this.backMainForm.Click += new System.EventHandler(this.backMainForm_Click);
            // 
            // SortByOrganizations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backMainForm);
            this.Controls.Add(this.сортировкаПоОрганизациямDataGridView);
            this.Controls.Add(this.сортировкаПоОрганизациямBindingNavigator);
            this.Name = "SortByOrganizations";
            this.Text = "SortByOrganizations";
            this.Load += new System.EventHandler(this.SortByOrganizations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lazutkinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортировкаПоОрганизациямBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортировкаПоОрганизациямBindingNavigator)).EndInit();
            this.сортировкаПоОрганизациямBindingNavigator.ResumeLayout(false);
            this.сортировкаПоОрганизациямBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сортировкаПоОрганизациямDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LazutkinDataSet lazutkinDataSet;
        private System.Windows.Forms.BindingSource сортировкаПоОрганизациямBindingSource;
        private LazutkinDataSetTableAdapters.СортировкаПоОрганизациямTableAdapter сортировкаПоОрганизациямTableAdapter;
        private LazutkinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator сортировкаПоОрганизациямBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton сортировкаПоОрганизациямBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView сортировкаПоОрганизациямDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button backMainForm;
    }
}