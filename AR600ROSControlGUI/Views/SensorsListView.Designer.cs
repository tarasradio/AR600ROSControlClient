namespace AR600ROSControlGUI.Views
{
    partial class SensorsListView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sensorsGrid = new ViewLibrary.DoubleBufferedDataGridView();
            this.sensorsGraph = new AR600ROSControlGUI.Views.GraphView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sensorsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sensorsGrid
            // 
            this.sensorsGrid.AllowUserToAddRows = false;
            this.sensorsGrid.AllowUserToDeleteRows = false;
            this.sensorsGrid.AllowUserToResizeColumns = false;
            this.sensorsGrid.AllowUserToResizeRows = false;
            this.sensorsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sensorsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sensorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sensorsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnGroup,
            this.ColumnName,
            this.ColumnValue,
            this.ColumnSelect});
            this.sensorsGrid.Location = new System.Drawing.Point(3, 3);
            this.sensorsGrid.MultiSelect = false;
            this.sensorsGrid.Name = "sensorsGrid";
            this.sensorsGrid.RowHeadersVisible = false;
            this.sensorsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sensorsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sensorsGrid.Size = new System.Drawing.Size(618, 111);
            this.sensorsGrid.TabIndex = 2;
            // 
            // graphView1
            // 
            this.sensorsGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sensorsGraph.Location = new System.Drawing.Point(3, 120);
            this.sensorsGraph.Name = "graphView1";
            this.sensorsGraph.Size = new System.Drawing.Size(618, 356);
            this.sensorsGraph.TabIndex = 3;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnNumber.HeaderText = "#";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Width = 39;
            // 
            // ColumnGroup
            // 
            this.ColumnGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnGroup.HeaderText = "Группа";
            this.ColumnGroup.Name = "ColumnGroup";
            this.ColumnGroup.ReadOnly = true;
            this.ColumnGroup.Width = 67;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnValue
            // 
            this.ColumnValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnValue.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnValue.HeaderText = "Значение";
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.ReadOnly = true;
            this.ColumnValue.Width = 80;
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.HeaderText = "На графике";
            this.ColumnSelect.Name = "ColumnSelect";
            // 
            // SensorsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sensorsGraph);
            this.Controls.Add(this.sensorsGrid);
            this.Name = "SensorsListView";
            this.Size = new System.Drawing.Size(624, 479);
            ((System.ComponentModel.ISupportInitialize)(this.sensorsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ViewLibrary.DoubleBufferedDataGridView sensorsGrid;
        private GraphView sensorsGraph;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelect;
    }
}
