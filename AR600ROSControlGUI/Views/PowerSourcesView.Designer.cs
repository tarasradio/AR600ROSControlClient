namespace AR600ROSControlGUI.Views
{
    partial class PowerSourcesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerSourcesView));
            this.powerStateGrid = new System.Windows.Forms.DataGridView();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoltageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPowerReboot = new System.Windows.Forms.Button();
            this.onOffButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.powerStateGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // powerStateGrid
            // 
            this.powerStateGrid.AllowUserToAddRows = false;
            this.powerStateGrid.AllowUserToDeleteRows = false;
            this.powerStateGrid.AllowUserToResizeColumns = false;
            this.powerStateGrid.AllowUserToResizeRows = false;
            this.powerStateGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.powerStateGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.powerStateGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.powerStateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.powerStateGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn,
            this.VoltageColumn,
            this.CurrentColumn});
            this.powerStateGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.powerStateGrid.Location = new System.Drawing.Point(3, 3);
            this.powerStateGrid.MultiSelect = false;
            this.powerStateGrid.Name = "powerStateGrid";
            this.powerStateGrid.ReadOnly = true;
            this.powerStateGrid.RowHeadersVisible = false;
            this.powerStateGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.powerStateGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.powerStateGrid.Size = new System.Drawing.Size(275, 152);
            this.powerStateGrid.TabIndex = 0;
            // 
            // TitleColumn
            // 
            this.TitleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TitleColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.TitleColumn.HeaderText = "Источники";
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            // 
            // VoltageColumn
            // 
            this.VoltageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VoltageColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.VoltageColumn.HeaderText = "Напряжение";
            this.VoltageColumn.Name = "VoltageColumn";
            this.VoltageColumn.ReadOnly = true;
            this.VoltageColumn.Width = 80;
            // 
            // CurrentColumn
            // 
            this.CurrentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CurrentColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.CurrentColumn.HeaderText = "Потребление";
            this.CurrentColumn.Name = "CurrentColumn";
            this.CurrentColumn.ReadOnly = true;
            this.CurrentColumn.Width = 80;
            // 
            // buttonPowerReboot
            // 
            this.buttonPowerReboot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPowerReboot.Location = new System.Drawing.Point(3, 159);
            this.buttonPowerReboot.Name = "buttonPowerReboot";
            this.buttonPowerReboot.Size = new System.Drawing.Size(219, 23);
            this.buttonPowerReboot.TabIndex = 2;
            this.buttonPowerReboot.Text = "Перезагрузка питания";
            this.buttonPowerReboot.UseVisualStyleBackColor = true;
            // 
            // onOffButton
            // 
            this.onOffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.onOffButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("onOffButton.BackgroundImage")));
            this.onOffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.onOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.onOffButton.Location = new System.Drawing.Point(228, 161);
            this.onOffButton.Name = "onOffButton";
            this.onOffButton.Size = new System.Drawing.Size(50, 18);
            this.onOffButton.TabIndex = 3;
            this.onOffButton.UseVisualStyleBackColor = true;
            this.onOffButton.Click += new System.EventHandler(this.onOffButton_Click);
            // 
            // PowerSourcesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.onOffButton);
            this.Controls.Add(this.buttonPowerReboot);
            this.Controls.Add(this.powerStateGrid);
            this.Name = "PowerSourcesView";
            this.Size = new System.Drawing.Size(281, 185);
            ((System.ComponentModel.ISupportInitialize)(this.powerStateGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView powerStateGrid;
        private System.Windows.Forms.Button buttonPowerReboot;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoltageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentColumn;
        private System.Windows.Forms.Button onOffButton;
    }
}
