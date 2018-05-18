namespace FrundController.Views
{
    partial class FrundControllerView
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
            this.btnRunSolution = new System.Windows.Forms.Button();
            this.btnStopSolution = new System.Windows.Forms.Button();
            this.selectModelBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAngularVelocity = new System.Windows.Forms.Label();
            this.trackAngularVelocity = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVelocityY = new System.Windows.Forms.Label();
            this.lblVelocityX = new System.Windows.Forms.Label();
            this.trackVelocityY = new System.Windows.Forms.TrackBar();
            this.trackVelocityX = new System.Windows.Forms.TrackBar();
            this.velocityControlCanvas = new System.Windows.Forms.PictureBox();
            this.additionalParamsGrid = new ViewLibrary.DoubleBufferedDataGridView();
            this.ColumnParamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParamValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonZeroing = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackAngularVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVelocityY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVelocityX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityControlCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalParamsGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRunSolution
            // 
            this.btnRunSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunSolution.Location = new System.Drawing.Point(34, 37);
            this.btnRunSolution.Name = "btnRunSolution";
            this.btnRunSolution.Size = new System.Drawing.Size(154, 40);
            this.btnRunSolution.TabIndex = 0;
            this.btnRunSolution.Text = "Запустить решение";
            this.btnRunSolution.UseVisualStyleBackColor = true;
            // 
            // btnStopSolution
            // 
            this.btnStopSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopSolution.Location = new System.Drawing.Point(204, 37);
            this.btnStopSolution.Name = "btnStopSolution";
            this.btnStopSolution.Size = new System.Drawing.Size(154, 40);
            this.btnStopSolution.TabIndex = 1;
            this.btnStopSolution.Text = "Остановить решение";
            this.btnStopSolution.UseVisualStyleBackColor = true;
            // 
            // selectModelBox
            // 
            this.selectModelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectModelBox.FormattingEnabled = true;
            this.selectModelBox.Location = new System.Drawing.Point(195, 3);
            this.selectModelBox.Name = "selectModelBox";
            this.selectModelBox.Size = new System.Drawing.Size(247, 24);
            this.selectModelBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор модели движения";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonZeroing);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAngularVelocity);
            this.groupBox1.Controls.Add(this.trackAngularVelocity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblVelocityY);
            this.groupBox1.Controls.Add(this.lblVelocityX);
            this.groupBox1.Controls.Add(this.trackVelocityY);
            this.groupBox1.Controls.Add(this.trackVelocityX);
            this.groupBox1.Controls.Add(this.velocityControlCanvas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(436, 252);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основные параметры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Угловая скорость";
            // 
            // lblAngularVelocity
            // 
            this.lblAngularVelocity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAngularVelocity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAngularVelocity.Location = new System.Drawing.Point(318, 65);
            this.lblAngularVelocity.Name = "lblAngularVelocity";
            this.lblAngularVelocity.Size = new System.Drawing.Size(55, 22);
            this.lblAngularVelocity.TabIndex = 11;
            this.lblAngularVelocity.Text = "0";
            this.lblAngularVelocity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackAngularVelocity
            // 
            this.trackAngularVelocity.AutoSize = false;
            this.trackAngularVelocity.Location = new System.Drawing.Point(269, 35);
            this.trackAngularVelocity.Maximum = 100;
            this.trackAngularVelocity.Name = "trackAngularVelocity";
            this.trackAngularVelocity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackAngularVelocity.Size = new System.Drawing.Size(150, 27);
            this.trackAngularVelocity.TabIndex = 10;
            this.trackAngularVelocity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackAngularVelocity.Value = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Скорость";
            // 
            // lblVelocityY
            // 
            this.lblVelocityY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVelocityY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVelocityY.Location = new System.Drawing.Point(57, 221);
            this.lblVelocityY.Name = "lblVelocityY";
            this.lblVelocityY.Size = new System.Drawing.Size(55, 22);
            this.lblVelocityY.TabIndex = 8;
            this.lblVelocityY.Text = "0";
            this.lblVelocityY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVelocityX
            // 
            this.lblVelocityX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVelocityX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVelocityX.Location = new System.Drawing.Point(198, 101);
            this.lblVelocityX.Name = "lblVelocityX";
            this.lblVelocityX.Size = new System.Drawing.Size(55, 22);
            this.lblVelocityX.TabIndex = 7;
            this.lblVelocityX.Text = "0";
            this.lblVelocityX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackVelocityY
            // 
            this.trackVelocityY.AutoSize = false;
            this.trackVelocityY.Location = new System.Drawing.Point(9, 191);
            this.trackVelocityY.Maximum = 150;
            this.trackVelocityY.Name = "trackVelocityY";
            this.trackVelocityY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackVelocityY.Size = new System.Drawing.Size(150, 27);
            this.trackVelocityY.TabIndex = 6;
            this.trackVelocityY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackVelocityY.Value = 75;
            this.trackVelocityY.Scroll += new System.EventHandler(this.trackVelocityY_Scroll);
            // 
            // trackVelocityX
            // 
            this.trackVelocityX.AutoSize = false;
            this.trackVelocityX.Location = new System.Drawing.Point(165, 35);
            this.trackVelocityX.Maximum = 150;
            this.trackVelocityX.Name = "trackVelocityX";
            this.trackVelocityX.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackVelocityX.Size = new System.Drawing.Size(27, 150);
            this.trackVelocityX.TabIndex = 5;
            this.trackVelocityX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackVelocityX.Value = 75;
            this.trackVelocityX.Scroll += new System.EventHandler(this.trackVelocityX_Scroll);
            // 
            // velocityControlCanvas
            // 
            this.velocityControlCanvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.velocityControlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.velocityControlCanvas.Location = new System.Drawing.Point(9, 35);
            this.velocityControlCanvas.Name = "velocityControlCanvas";
            this.velocityControlCanvas.Size = new System.Drawing.Size(150, 150);
            this.velocityControlCanvas.TabIndex = 0;
            this.velocityControlCanvas.TabStop = false;
            this.velocityControlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.velocityControlCanvas_MouseDown);
            this.velocityControlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.velocityControlCanvas_MouseMove);
            this.velocityControlCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.velocityControlCanvas_MouseUp);
            // 
            // additionalParamsGrid
            // 
            this.additionalParamsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.additionalParamsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.additionalParamsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnParamName,
            this.ColumnParamValue});
            this.additionalParamsGrid.Location = new System.Drawing.Point(9, 19);
            this.additionalParamsGrid.Name = "additionalParamsGrid";
            this.additionalParamsGrid.RowHeadersVisible = false;
            this.additionalParamsGrid.Size = new System.Drawing.Size(273, 126);
            this.additionalParamsGrid.TabIndex = 5;
            // 
            // ColumnParamName
            // 
            this.ColumnParamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnParamName.HeaderText = "Параметр";
            this.ColumnParamName.Name = "ColumnParamName";
            this.ColumnParamName.ReadOnly = true;
            // 
            // ColumnParamValue
            // 
            this.ColumnParamValue.HeaderText = "Значение";
            this.ColumnParamValue.Name = "ColumnParamValue";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.additionalParamsGrid);
            this.groupBox2.Location = new System.Drawing.Point(6, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 155);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дополнительные параметры";
            // 
            // buttonZeroing
            // 
            this.buttonZeroing.Location = new System.Drawing.Point(308, 123);
            this.buttonZeroing.Name = "buttonZeroing";
            this.buttonZeroing.Size = new System.Drawing.Size(75, 23);
            this.buttonZeroing.TabIndex = 13;
            this.buttonZeroing.Text = "Сброс";
            this.buttonZeroing.UseVisualStyleBackColor = true;
            this.buttonZeroing.Click += new System.EventHandler(this.buttonZeroing_Click);
            // 
            // FrundControllerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectModelBox);
            this.Controls.Add(this.btnStopSolution);
            this.Controls.Add(this.btnRunSolution);
            this.Name = "FrundControllerView";
            this.Size = new System.Drawing.Size(455, 510);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackAngularVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVelocityY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVelocityX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityControlCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalParamsGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunSolution;
        private System.Windows.Forms.Button btnStopSolution;
        private System.Windows.Forms.ComboBox selectModelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVelocityY;
        private System.Windows.Forms.Label lblVelocityX;
        private System.Windows.Forms.TrackBar trackVelocityY;
        private System.Windows.Forms.TrackBar trackVelocityX;
        private System.Windows.Forms.PictureBox velocityControlCanvas;
        private System.Windows.Forms.Label lblAngularVelocity;
        private System.Windows.Forms.TrackBar trackAngularVelocity;
        private System.Windows.Forms.Label label3;
        private ViewLibrary.DoubleBufferedDataGridView additionalParamsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParamValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonZeroing;
    }
}
