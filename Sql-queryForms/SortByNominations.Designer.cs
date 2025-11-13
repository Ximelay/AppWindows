namespace AppWindows.Sql_queryForms
{
    partial class SortByNominations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortByNominations));
            this.lazutkinDataSet = new AppWindows.LazutkinDataSet();
            this.сортировкаПоНоминациямBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сортировкаПоНоминациямTableAdapter = new AppWindows.LazutkinDataSetTableAdapters.СортировкаПоНоминациямTableAdapter();
            this.tableAdapterManager = new AppWindows.LazutkinDataSetTableAdapters.TableAdapterManager();
            this.сортировкаПоНоминациямBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.сортировкаПоНоминациямBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.сортировкаПоНоминациямDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backMainForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lazutkinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортировкаПоНоминациямBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортировкаПоНоминациямBindingNavigator)).BeginInit();
            this.сортировкаПоНоминациямBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сортировкаПоНоминациямDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lazutkinDataSet
            // 
            this.lazutkinDataSet.DataSetName = "LazutkinDataSet";
            this.lazutkinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сортировкаПоНоминациямBindingSource
            // 
            this.сортировкаПоНоминациямBindingSource.DataMember = "СортировкаПоНоминациям";
            this.сортировкаПоНоминациямBindingSource.DataSource = this.lazutkinDataSet;
            // 
            // сортировкаПоНоминациямTableAdapter
            // 
            this.сортировкаПоНоминациямTableAdapter.ClearBeforeFill = true;
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
            // сортировкаПоНоминациямBindingNavigator
            // 
            this.сортировкаПоНоминациямBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.сортировкаПоНоминациямBindingNavigator.BindingSource = this.сортировкаПоНоминациямBindingSource;
            this.сортировкаПоНоминациямBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.сортировкаПоНоминациямBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.сортировкаПоНоминациямBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.сортировкаПоНоминациямBindingNavigatorSaveItem});
            this.сортировкаПоНоминациямBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.сортировкаПоНоминациямBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.сортировкаПоНоминациямBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.сортировкаПоНоминациямBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.сортировкаПоНоминациямBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.сортировкаПоНоминациямBindingNavigator.Name = "сортировкаПоНоминациямBindingNavigator";
            this.сортировкаПоНоминациямBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.сортировкаПоНоминациямBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.сортировкаПоНоминациямBindingNavigator.TabIndex = 0;
            this.сортировкаПоНоминациямBindingNavigator.Text = "bindingNavigator1";
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
            // сортировкаПоНоминациямBindingNavigatorSaveItem
            // 
            this.сортировкаПоНоминациямBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сортировкаПоНоминациямBindingNavigatorSaveItem.Enabled = false;
            this.сортировкаПоНоминациямBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("сортировкаПоНоминациямBindingNavigatorSaveItem.Image")));
            this.сортировкаПоНоминациямBindingNavigatorSaveItem.Name = "сортировкаПоНоминациямBindingNavigatorSaveItem";
            this.сортировкаПоНоминациямBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.сортировкаПоНоминациямBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // сортировкаПоНоминациямDataGridView
            // 
            this.сортировкаПоНоминациямDataGridView.AutoGenerateColumns = false;
            this.сортировкаПоНоминациямDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сортировкаПоНоминациямDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.сортировкаПоНоминациямDataGridView.DataSource = this.сортировкаПоНоминациямBindingSource;
            this.сортировкаПоНоминациямDataGridView.Location = new System.Drawing.Point(12, 28);
            this.сортировкаПоНоминациямDataGridView.Name = "сортировкаПоНоминациямDataGridView";
            this.сортировкаПоНоминациямDataGridView.Size = new System.Drawing.Size(776, 371);
            this.сортировкаПоНоминациямDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номинация";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номинация";
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
            this.backMainForm.Location = new System.Drawing.Point(28, 415);
            this.backMainForm.Name = "backMainForm";
            this.backMainForm.Size = new System.Drawing.Size(75, 23);
            this.backMainForm.TabIndex = 3;
            this.backMainForm.Text = "Назад";
            this.backMainForm.UseVisualStyleBackColor = true;
            this.backMainForm.Click += new System.EventHandler(this.backMainForm_Click);
            // 
            // SortByNominations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backMainForm);
            this.Controls.Add(this.сортировкаПоНоминациямDataGridView);
            this.Controls.Add(this.сортировкаПоНоминациямBindingNavigator);
            this.Name = "SortByNominations";
            this.Text = "SortByNominations";
            this.Load += new System.EventHandler(this.SortByNominations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lazutkinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортировкаПоНоминациямBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортировкаПоНоминациямBindingNavigator)).EndInit();
            this.сортировкаПоНоминациямBindingNavigator.ResumeLayout(false);
            this.сортировкаПоНоминациямBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сортировкаПоНоминациямDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LazutkinDataSet lazutkinDataSet;
        private System.Windows.Forms.BindingSource сортировкаПоНоминациямBindingSource;
        private LazutkinDataSetTableAdapters.СортировкаПоНоминациямTableAdapter сортировкаПоНоминациямTableAdapter;
        private LazutkinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator сортировкаПоНоминациямBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton сортировкаПоНоминациямBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView сортировкаПоНоминациямDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button backMainForm;
    }
}