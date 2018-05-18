namespace AR600ROSControlGUI.Views
{
    partial class SelectedJointView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBrake = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonRelax = new System.Windows.Forms.Button();
            this.checkCalibration = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lowerLimitLable = new System.Windows.Forms.TextBox();
            this.upperLimitLable = new System.Windows.Forms.TextBox();
            this.currentPositionLable = new System.Windows.Forms.TextBox();
            this.editPosition = new System.Windows.Forms.TrackBar();
            this.checkPositionTracking = new System.Windows.Forms.CheckBox();
            this.jointParamsGrid = new System.Windows.Forms.DataGridView();
            this.ColumnParamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editJointParamsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointParamsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrake
            // 
            this.buttonBrake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBrake.Location = new System.Drawing.Point(3, 119);
            this.buttonBrake.Name = "buttonBrake";
            this.buttonBrake.Size = new System.Drawing.Size(75, 23);
            this.buttonBrake.TabIndex = 0;
            this.buttonBrake.Text = "BRAKE";
            this.buttonBrake.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonStop.Location = new System.Drawing.Point(84, 119);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(78, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonRelax
            // 
            this.buttonRelax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRelax.Location = new System.Drawing.Point(168, 119);
            this.buttonRelax.Name = "buttonRelax";
            this.buttonRelax.Size = new System.Drawing.Size(75, 23);
            this.buttonRelax.TabIndex = 2;
            this.buttonRelax.Text = "RELAX";
            this.buttonRelax.UseVisualStyleBackColor = true;
            // 
            // checkCalibration
            // 
            this.checkCalibration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkCalibration.AutoSize = true;
            this.checkCalibration.Location = new System.Drawing.Point(3, 152);
            this.checkCalibration.Name = "checkCalibration";
            this.checkCalibration.Size = new System.Drawing.Size(87, 17);
            this.checkCalibration.TabIndex = 4;
            this.checkCalibration.Text = "Калибровка";
            this.checkCalibration.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(96, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сохранить как ноль";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lowerLimitLable
            // 
            this.lowerLimitLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lowerLimitLable.Location = new System.Drawing.Point(3, 177);
            this.lowerLimitLable.Name = "lowerLimitLable";
            this.lowerLimitLable.Size = new System.Drawing.Size(75, 20);
            this.lowerLimitLable.TabIndex = 6;
            this.lowerLimitLable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // upperLimitLable
            // 
            this.upperLimitLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upperLimitLable.Location = new System.Drawing.Point(168, 177);
            this.upperLimitLable.Name = "upperLimitLable";
            this.upperLimitLable.Size = new System.Drawing.Size(75, 20);
            this.upperLimitLable.TabIndex = 7;
            this.upperLimitLable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentPositionLable
            // 
            this.currentPositionLable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.currentPositionLable.Location = new System.Drawing.Point(84, 177);
            this.currentPositionLable.Name = "currentPositionLable";
            this.currentPositionLable.Size = new System.Drawing.Size(78, 20);
            this.currentPositionLable.TabIndex = 8;
            this.currentPositionLable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editPosition
            // 
            this.editPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editPosition.AutoSize = false;
            this.editPosition.Location = new System.Drawing.Point(3, 203);
            this.editPosition.Name = "editPosition";
            this.editPosition.Size = new System.Drawing.Size(240, 24);
            this.editPosition.TabIndex = 9;
            this.editPosition.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // checkPositionTracking
            // 
            this.checkPositionTracking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkPositionTracking.AutoSize = true;
            this.checkPositionTracking.Location = new System.Drawing.Point(3, 233);
            this.checkPositionTracking.Name = "checkPositionTracking";
            this.checkPositionTracking.Size = new System.Drawing.Size(123, 17);
            this.checkPositionTracking.TabIndex = 10;
            this.checkPositionTracking.Text = "Ручное управление";
            this.checkPositionTracking.UseVisualStyleBackColor = true;
            // 
            // jointParamsGrid
            // 
            this.jointParamsGrid.AllowUserToAddRows = false;
            this.jointParamsGrid.AllowUserToDeleteRows = false;
            this.jointParamsGrid.AllowUserToResizeColumns = false;
            this.jointParamsGrid.AllowUserToResizeRows = false;
            this.jointParamsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jointParamsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jointParamsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jointParamsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnParamName,
            this.ColumnValue});
            this.jointParamsGrid.Location = new System.Drawing.Point(3, 3);
            this.jointParamsGrid.Name = "jointParamsGrid";
            this.jointParamsGrid.RowHeadersVisible = false;
            this.jointParamsGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jointParamsGrid.Size = new System.Drawing.Size(240, 110);
            this.jointParamsGrid.TabIndex = 11;
            // 
            // ColumnParamName
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnParamName.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnParamName.HeaderText = "Параметр";
            this.ColumnParamName.Name = "ColumnParamName";
            this.ColumnParamName.ReadOnly = true;
            // 
            // ColumnValue
            // 
            this.ColumnValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnValue.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnValue.HeaderText = "Значение";
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.ReadOnly = true;
            // 
            // editJointParamsButton
            // 
            this.editJointParamsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editJointParamsButton.Location = new System.Drawing.Point(3, 256);
            this.editJointParamsButton.Name = "editJointParamsButton";
            this.editJointParamsButton.Size = new System.Drawing.Size(240, 23);
            this.editJointParamsButton.TabIndex = 12;
            this.editJointParamsButton.Text = "Настройка параметров";
            this.editJointParamsButton.UseVisualStyleBackColor = true;
            // 
            // SelectedJointView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editJointParamsButton);
            this.Controls.Add(this.jointParamsGrid);
            this.Controls.Add(this.checkPositionTracking);
            this.Controls.Add(this.editPosition);
            this.Controls.Add(this.currentPositionLable);
            this.Controls.Add(this.upperLimitLable);
            this.Controls.Add(this.lowerLimitLable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkCalibration);
            this.Controls.Add(this.buttonRelax);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonBrake);
            this.Name = "SelectedJointView";
            this.Size = new System.Drawing.Size(246, 282);
            ((System.ComponentModel.ISupportInitialize)(this.editPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointParamsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrake;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRelax;
        private System.Windows.Forms.CheckBox checkCalibration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lowerLimitLable;
        private System.Windows.Forms.TextBox upperLimitLable;
        private System.Windows.Forms.TextBox currentPositionLable;
        private System.Windows.Forms.TrackBar editPosition;
        private System.Windows.Forms.CheckBox checkPositionTracking;
        private System.Windows.Forms.DataGridView jointParamsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.Button editJointParamsButton;
    }
}
