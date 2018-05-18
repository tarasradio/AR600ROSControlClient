namespace AR600ROSControlGUI.Views
{
    partial class JointsListView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.jointsGrid = new ViewLibrary.DoubleBufferedDataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLowerLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUpperLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jointsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // jointsGrid
            // 
            this.jointsGrid.AllowUserToAddRows = false;
            this.jointsGrid.AllowUserToDeleteRows = false;
            this.jointsGrid.AllowUserToOrderColumns = true;
            this.jointsGrid.AllowUserToResizeColumns = false;
            this.jointsGrid.AllowUserToResizeRows = false;
            this.jointsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jointsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jointsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.jointsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnName,
            this.ColumnPosition,
            this.ColumnState,
            this.ColumnLowerLimit,
            this.ColumnUpperLimit,
            this.ColumnSelect});
            this.jointsGrid.Location = new System.Drawing.Point(3, 3);
            this.jointsGrid.Name = "jointsGrid";
            this.jointsGrid.RowHeadersVisible = false;
            this.jointsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jointsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jointsGrid.Size = new System.Drawing.Size(687, 398);
            this.jointsGrid.TabIndex = 2;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnNumber.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnNumber.HeaderText = "№";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Width = 43;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnPosition
            // 
            this.ColumnPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnPosition.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnPosition.HeaderText = "Позиция";
            this.ColumnPosition.Name = "ColumnPosition";
            this.ColumnPosition.ReadOnly = true;
            this.ColumnPosition.Width = 76;
            // 
            // ColumnState
            // 
            this.ColumnState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnState.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnState.HeaderText = "Статус";
            this.ColumnState.Name = "ColumnState";
            this.ColumnState.ReadOnly = true;
            this.ColumnState.Width = 66;
            // 
            // ColumnLowerLimit
            // 
            this.ColumnLowerLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnLowerLimit.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnLowerLimit.HeaderText = "MIN";
            this.ColumnLowerLimit.Name = "ColumnLowerLimit";
            this.ColumnLowerLimit.ReadOnly = true;
            this.ColumnLowerLimit.Width = 52;
            // 
            // ColumnUpperLimit
            // 
            this.ColumnUpperLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnUpperLimit.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnUpperLimit.HeaderText = "MAX";
            this.ColumnUpperLimit.Name = "ColumnUpperLimit";
            this.ColumnUpperLimit.ReadOnly = true;
            this.ColumnUpperLimit.Width = 55;
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSelect.HeaderText = "На графике";
            this.ColumnSelect.Name = "ColumnSelect";
            this.ColumnSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnSelect.Width = 92;
            // 
            // JointsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jointsGrid);
            this.Name = "JointsListView";
            this.Size = new System.Drawing.Size(693, 404);
            ((System.ComponentModel.ISupportInitialize)(this.jointsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ViewLibrary.DoubleBufferedDataGridView jointsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLowerLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUpperLimit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelect;
    }
}
