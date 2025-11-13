namespace AppWindows
{
    partial class AllEducationOrganizations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllEducationOrganizations));
            this.lazutkinDataSet = new AppWindows.LazutkinDataSet();
            this.educational_OrganisationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educational_OrganisationsTableAdapter = new AppWindows.LazutkinDataSetTableAdapters.Educational_OrganisationsTableAdapter();
            this.tableAdapterManager = new AppWindows.LazutkinDataSetTableAdapters.TableAdapterManager();
            this.educational_OrganisationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.educational_OrganisationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.educational_OrganisationsDataGridView = new System.Windows.Forms.DataGridView();
            this.backEducOrgForm = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lazutkinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educational_OrganisationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educational_OrganisationsBindingNavigator)).BeginInit();
            this.educational_OrganisationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.educational_OrganisationsDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.educational_OrganisationsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.educational_OrganisationsBindingNavigator.TabIndex = 0;
            this.educational_OrganisationsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // educational_OrganisationsBindingNavigatorSaveItem
            // 
            this.educational_OrganisationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.educational_OrganisationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("educational_OrganisationsBindingNavigatorSaveItem.Image")));
            this.educational_OrganisationsBindingNavigatorSaveItem.Name = "educational_OrganisationsBindingNavigatorSaveItem";
            this.educational_OrganisationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.educational_OrganisationsBindingNavigatorSaveItem.Text = "Save Data";
            this.educational_OrganisationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.educational_OrganisationsBindingNavigatorSaveItem_Click);
            // 
            // educational_OrganisationsDataGridView
            // 
            this.educational_OrganisationsDataGridView.AutoGenerateColumns = false;
            this.educational_OrganisationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.educational_OrganisationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.educational_OrganisationsDataGridView.DataSource = this.educational_OrganisationsBindingSource;
            this.educational_OrganisationsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.educational_OrganisationsDataGridView.Name = "educational_OrganisationsDataGridView";
            this.educational_OrganisationsDataGridView.Size = new System.Drawing.Size(788, 370);
            this.educational_OrganisationsDataGridView.TabIndex = 1;
            // 
            // backEducOrgForm
            // 
            this.backEducOrgForm.Location = new System.Drawing.Point(31, 404);
            this.backEducOrgForm.Name = "backEducOrgForm";
            this.backEducOrgForm.Size = new System.Drawing.Size(75, 23);
            this.backEducOrgForm.TabIndex = 2;
            this.backEducOrgForm.Text = "Назад";
            this.backEducOrgForm.UseVisualStyleBackColor = true;
            this.backEducOrgForm.Click += new System.EventHandler(this.backEducOrgForm_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_Organisation";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name_Organisation";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email_Organisation";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email_Organisation";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Director_FIO_Organization";
            this.dataGridViewTextBoxColumn4.HeaderText = "Director_FIO_Organization";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Number_Phone_Organization";
            this.dataGridViewTextBoxColumn5.HeaderText = "Number_Phone_Organization";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // AllEducationOrganizations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backEducOrgForm);
            this.Controls.Add(this.educational_OrganisationsDataGridView);
            this.Controls.Add(this.educational_OrganisationsBindingNavigator);
            this.Name = "AllEducationOrganizations";
            this.Text = "AllEducationOrganizations";
            this.Load += new System.EventHandler(this.AllEducationOrganizations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lazutkinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educational_OrganisationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educational_OrganisationsBindingNavigator)).EndInit();
            this.educational_OrganisationsBindingNavigator.ResumeLayout(false);
            this.educational_OrganisationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.educational_OrganisationsDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView educational_OrganisationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button backEducOrgForm;
    }
}