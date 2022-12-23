namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.SelectedOrderIDLabel = new System.Windows.Forms.Label();
            this.SelectedOrderCreatedLabel = new System.Windows.Forms.Label();
            this.SelectedOrderIDTextBox = new System.Windows.Forms.TextBox();
            this.SelectedOrderCreatedTextBox = new System.Windows.Forms.TextBox();
            this.SelectedOrderStatusLabel = new System.Windows.Forms.Label();
            this.SelectedOrderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AllAmountLabel = new System.Windows.Forms.Label();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersLabel
            // 
            this.OrdersLabel.AutoSize = true;
            this.OrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersLabel.Location = new System.Drawing.Point(3, 10);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Size = new System.Drawing.Size(48, 13);
            this.OrdersLabel.TabIndex = 0;
            this.OrdersLabel.Text = "Orders:";
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.CreatedColumn,
            this.OrderStatusColumn,
            this.CustomerFullNameColumn,
            this.DeliveryAddressColumn,
            this.AmountColumn});
            this.OrdersDataGridView.Enabled = false;
            this.OrdersDataGridView.Location = new System.Drawing.Point(6, 26);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.Size = new System.Drawing.Size(275, 492);
            this.OrdersDataGridView.TabIndex = 1;
            this.OrdersDataGridView.SelectionChanged += new System.EventHandler(this.OrdersDataGridView_SelectionChanged);
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.AutoSize = true;
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedOrderLabel.Location = new System.Drawing.Point(293, 11);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(92, 13);
            this.SelectedOrderLabel.TabIndex = 2;
            this.SelectedOrderLabel.Text = "Selected Order";
            // 
            // SelectedOrderIDLabel
            // 
            this.SelectedOrderIDLabel.AutoSize = true;
            this.SelectedOrderIDLabel.Location = new System.Drawing.Point(293, 43);
            this.SelectedOrderIDLabel.Name = "SelectedOrderIDLabel";
            this.SelectedOrderIDLabel.Size = new System.Drawing.Size(21, 13);
            this.SelectedOrderIDLabel.TabIndex = 3;
            this.SelectedOrderIDLabel.Text = "ID:";
            // 
            // SelectedOrderCreatedLabel
            // 
            this.SelectedOrderCreatedLabel.AutoSize = true;
            this.SelectedOrderCreatedLabel.Location = new System.Drawing.Point(293, 69);
            this.SelectedOrderCreatedLabel.Name = "SelectedOrderCreatedLabel";
            this.SelectedOrderCreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.SelectedOrderCreatedLabel.TabIndex = 4;
            this.SelectedOrderCreatedLabel.Text = "Created:";
            // 
            // SelectedOrderIDTextBox
            // 
            this.SelectedOrderIDTextBox.Location = new System.Drawing.Point(361, 40);
            this.SelectedOrderIDTextBox.Name = "SelectedOrderIDTextBox";
            this.SelectedOrderIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.SelectedOrderIDTextBox.TabIndex = 5;
            // 
            // SelectedOrderCreatedTextBox
            // 
            this.SelectedOrderCreatedTextBox.Location = new System.Drawing.Point(361, 66);
            this.SelectedOrderCreatedTextBox.Name = "SelectedOrderCreatedTextBox";
            this.SelectedOrderCreatedTextBox.Size = new System.Drawing.Size(121, 20);
            this.SelectedOrderCreatedTextBox.TabIndex = 6;
            // 
            // SelectedOrderStatusLabel
            // 
            this.SelectedOrderStatusLabel.AutoSize = true;
            this.SelectedOrderStatusLabel.Location = new System.Drawing.Point(293, 95);
            this.SelectedOrderStatusLabel.Name = "SelectedOrderStatusLabel";
            this.SelectedOrderStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.SelectedOrderStatusLabel.TabIndex = 7;
            this.SelectedOrderStatusLabel.Text = "Status:";
            // 
            // SelectedOrderStatusComboBox
            // 
            this.SelectedOrderStatusComboBox.FormattingEnabled = true;
            this.SelectedOrderStatusComboBox.Location = new System.Drawing.Point(361, 92);
            this.SelectedOrderStatusComboBox.Name = "SelectedOrderStatusComboBox";
            this.SelectedOrderStatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.SelectedOrderStatusComboBox.TabIndex = 8;
            this.SelectedOrderStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedOrderStatusComboBox_SelectedIndexChanged);
            // 
            // addressControl1
            // 
            address1.Apartment = " ";
            address1.Building = " ";
            address1.City = " ";
            address1.Country = " ";
            address1.Index = 100000;
            address1.Street = " ";
            this.addressControl1.Address = address1;
            this.addressControl1.Location = new System.Drawing.Point(287, 118);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(403, 172);
            this.addressControl1.TabIndex = 9;
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderItemsLabel.Location = new System.Drawing.Point(293, 266);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(72, 13);
            this.OrderItemsLabel.TabIndex = 10;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.Location = new System.Drawing.Point(296, 282);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(384, 147);
            this.OrderItemsListBox.TabIndex = 11;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(628, 431);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(53, 13);
            this.AmountLabel.TabIndex = 12;
            this.AmountLabel.Text = "Amount:";
            // 
            // AllAmountLabel
            // 
            this.AllAmountLabel.AutoSize = true;
            this.AllAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllAmountLabel.Location = new System.Drawing.Point(649, 444);
            this.AllAmountLabel.Name = "AllAmountLabel";
            this.AllAmountLabel.Size = new System.Drawing.Size(14, 13);
            this.AllAmountLabel.TabIndex = 13;
            this.AllAmountLabel.Text = "0";
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "IDColumn";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CreatedColumn
            // 
            this.CreatedColumn.HeaderText = "CreatedColumn";
            this.CreatedColumn.Name = "CreatedColumn";
            this.CreatedColumn.ReadOnly = true;
            this.CreatedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderStatusColumn
            // 
            this.OrderStatusColumn.HeaderText = "OrderStatusColumn";
            this.OrderStatusColumn.Name = "OrderStatusColumn";
            this.OrderStatusColumn.ReadOnly = true;
            this.OrderStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomerFullNameColumn
            // 
            this.CustomerFullNameColumn.HeaderText = "CustomerFullNameColumn";
            this.CustomerFullNameColumn.Name = "CustomerFullNameColumn";
            this.CustomerFullNameColumn.ReadOnly = true;
            this.CustomerFullNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DeliveryAddressColumn
            // 
            this.DeliveryAddressColumn.HeaderText = "DeliveryAddressColumn";
            this.DeliveryAddressColumn.Name = "DeliveryAddressColumn";
            this.DeliveryAddressColumn.ReadOnly = true;
            this.DeliveryAddressColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "AmountColumn";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            this.AmountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AllAmountLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.OrderItemsListBox);
            this.Controls.Add(this.OrderItemsLabel);
            this.Controls.Add(this.addressControl1);
            this.Controls.Add(this.SelectedOrderStatusComboBox);
            this.Controls.Add(this.SelectedOrderStatusLabel);
            this.Controls.Add(this.SelectedOrderCreatedTextBox);
            this.Controls.Add(this.SelectedOrderIDTextBox);
            this.Controls.Add(this.SelectedOrderCreatedLabel);
            this.Controls.Add(this.SelectedOrderIDLabel);
            this.Controls.Add(this.SelectedOrderLabel);
            this.Controls.Add(this.OrdersDataGridView);
            this.Controls.Add(this.OrdersLabel);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(693, 538);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Label SelectedOrderLabel;
        private System.Windows.Forms.Label SelectedOrderIDLabel;
        private System.Windows.Forms.Label SelectedOrderCreatedLabel;
        private System.Windows.Forms.TextBox SelectedOrderIDTextBox;
        private System.Windows.Forms.TextBox SelectedOrderCreatedTextBox;
        private System.Windows.Forms.Label SelectedOrderStatusLabel;
        private System.Windows.Forms.ComboBox SelectedOrderStatusComboBox;
        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label AllAmountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
    }
}
