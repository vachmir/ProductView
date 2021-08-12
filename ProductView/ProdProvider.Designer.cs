
namespace ProductView
{
    partial class ProdProvider
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
            System.Windows.Forms.Label providerNameLabel;
            System.Windows.Forms.Label serialNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdProvider));
            this.warehouseDataSet2 = new ProductView.WarehouseDataSet2();
            this.prodProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodProviderTableAdapter = new ProductView.WarehouseDataSet2TableAdapters.ProdProviderTableAdapter();
            this.tableAdapterManager = new ProductView.WarehouseDataSet2TableAdapters.TableAdapterManager();
            this.prodProviderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.prodProviderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.providerNameTextBox = new System.Windows.Forms.TextBox();
            this.serialNumberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            providerNameLabel = new System.Windows.Forms.Label();
            serialNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodProviderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodProviderBindingNavigator)).BeginInit();
            this.prodProviderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // providerNameLabel
            // 
            providerNameLabel.AutoSize = true;
            providerNameLabel.Location = new System.Drawing.Point(77, 139);
            providerNameLabel.Name = "providerNameLabel";
            providerNameLabel.Size = new System.Drawing.Size(80, 13);
            providerNameLabel.TabIndex = 3;
            providerNameLabel.Text = "Provider Name:";
            // 
            // serialNumberLabel
            // 
            serialNumberLabel.AutoSize = true;
            serialNumberLabel.Location = new System.Drawing.Point(77, 165);
            serialNumberLabel.Name = "serialNumberLabel";
            serialNumberLabel.Size = new System.Drawing.Size(76, 13);
            serialNumberLabel.TabIndex = 5;
            serialNumberLabel.Text = "Serial Number:";
            // 
            // warehouseDataSet2
            // 
            this.warehouseDataSet2.DataSetName = "WarehouseDataSet2";
            this.warehouseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodProviderBindingSource
            // 
            this.prodProviderBindingSource.DataMember = "ProdProvider";
            this.prodProviderBindingSource.DataSource = this.warehouseDataSet2;
            // 
            // prodProviderTableAdapter
            // 
            this.prodProviderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProdProviderTableAdapter = this.prodProviderTableAdapter;
            this.tableAdapterManager.ProductObtainTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProductView.WarehouseDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // prodProviderBindingNavigator
            // 
            this.prodProviderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prodProviderBindingNavigator.BindingSource = this.prodProviderBindingSource;
            this.prodProviderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prodProviderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prodProviderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prodProviderBindingNavigatorSaveItem});
            this.prodProviderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prodProviderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prodProviderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prodProviderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prodProviderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prodProviderBindingNavigator.Name = "prodProviderBindingNavigator";
            this.prodProviderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prodProviderBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.prodProviderBindingNavigator.TabIndex = 0;
            this.prodProviderBindingNavigator.Text = "bindingNavigator1";
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
            // prodProviderBindingNavigatorSaveItem
            // 
            this.prodProviderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prodProviderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prodProviderBindingNavigatorSaveItem.Image")));
            this.prodProviderBindingNavigatorSaveItem.Name = "prodProviderBindingNavigatorSaveItem";
            this.prodProviderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.prodProviderBindingNavigatorSaveItem.Text = "Save Data";
            this.prodProviderBindingNavigatorSaveItem.Click += new System.EventHandler(this.prodProviderBindingNavigatorSaveItem_Click_3);
            // 
            // providerNameTextBox
            // 
            this.providerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodProviderBindingSource, "ProviderName", true));
            this.providerNameTextBox.Location = new System.Drawing.Point(163, 136);
            this.providerNameTextBox.Name = "providerNameTextBox";
            this.providerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.providerNameTextBox.TabIndex = 4;
            this.providerNameTextBox.TextChanged += new System.EventHandler(this.providerNameTextBox_TextChanged_1);
            // 
            // serialNumberTextBox
            // 
            this.serialNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodProviderBindingSource, "SerialNumber", true));
            this.serialNumberTextBox.Location = new System.Drawing.Point(163, 162);
            this.serialNumberTextBox.Name = "serialNumberTextBox";
            this.serialNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.serialNumberTextBox.TabIndex = 6;
            this.serialNumberTextBox.TextChanged += new System.EventHandler(this.serialNumberTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 299);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(382, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "See Table";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProdProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(providerNameLabel);
            this.Controls.Add(this.providerNameTextBox);
            this.Controls.Add(serialNumberLabel);
            this.Controls.Add(this.serialNumberTextBox);
            this.Controls.Add(this.prodProviderBindingNavigator);
            this.Name = "ProdProvider";
            this.Text = "Product Provider";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodProviderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodProviderBindingNavigator)).EndInit();
            this.prodProviderBindingNavigator.ResumeLayout(false);
            this.prodProviderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WarehouseDataSet2 warehouseDataSet2;
        private System.Windows.Forms.BindingSource prodProviderBindingSource;
        private WarehouseDataSet2TableAdapters.ProdProviderTableAdapter prodProviderTableAdapter;
        private WarehouseDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prodProviderBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prodProviderBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox providerNameTextBox;
        private System.Windows.Forms.TextBox serialNumberTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
    }
}

