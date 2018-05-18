namespace AR600ROSControlGUI
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lableMasterLinkState = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.editMasterUri = new System.Windows.Forms.ToolStripTextBox();
            this.connectToMasterButton = new System.Windows.Forms.ToolStripButton();
            this.selectControllerLable = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectControllerBox = new System.Windows.Forms.ToolStripComboBox();
            this.selectControllerButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabJointsList = new System.Windows.Forms.TabPage();
            this.jointsListView = new AR600ROSControlGUI.Views.JointsListView();
            this.tabSensorsList = new System.Windows.Forms.TabPage();
            this.sensorsListView = new AR600ROSControlGUI.Views.SensorsListView();
            this.tabPlayFileControl = new System.Windows.Forms.TabPage();
            this.tabRealTimeControl = new System.Windows.Forms.TabPage();
            this.frundControllerView = new FrundController.Views.FrundControllerView();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.graphView = new AR600ROSControlGUI.Views.GraphView();
            this.initPosButton = new System.Windows.Forms.Button();
            this.selectedJointView = new AR600ROSControlGUI.Views.SelectedJointView();
            this.powerSourcesView = new AR600ROSControlGUI.Views.PowerSourcesView();
            this.stopTransitButton = new System.Windows.Forms.Button();
            this.transitionProgressBar = new System.Windows.Forms.ProgressBar();
            this.statusStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabJointsList.SuspendLayout();
            this.tabSensorsList.SuspendLayout();
            this.tabRealTimeControl.SuspendLayout();
            this.tabPageGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lableMasterLinkState});
            this.statusStrip.Location = new System.Drawing.Point(0, 579);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(840, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lableMasterLinkState
            // 
            this.lableMasterLinkState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableMasterLinkState.ForeColor = System.Drawing.Color.Brown;
            this.lableMasterLinkState.Name = "lableMasterLinkState";
            this.lableMasterLinkState.Size = new System.Drawing.Size(184, 17);
            this.lableMasterLinkState.Text = "Нет подключения к MasterNode";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.editMasterUri,
            this.connectToMasterButton,
            this.selectControllerLable,
            this.toolStripSeparator1,
            this.SelectControllerBox,
            this.selectControllerButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainToolStrip.Size = new System.Drawing.Size(840, 25);
            this.mainToolStrip.TabIndex = 5;
            this.mainToolStrip.Text = "toolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(75, 22);
            this.toolStripLabel1.Text = "MasterNode:";
            // 
            // editMasterUri
            // 
            this.editMasterUri.Name = "editMasterUri";
            this.editMasterUri.Size = new System.Drawing.Size(150, 25);
            this.editMasterUri.Text = "ws://192.168.0.100:9090";
            // 
            // connectToMasterButton
            // 
            this.connectToMasterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.connectToMasterButton.Image = ((System.Drawing.Image)(resources.GetObject("connectToMasterButton.Image")));
            this.connectToMasterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connectToMasterButton.Name = "connectToMasterButton";
            this.connectToMasterButton.Size = new System.Drawing.Size(89, 22);
            this.connectToMasterButton.Text = "Подключение";
            this.connectToMasterButton.Click += new System.EventHandler(this.connectToMasterButton_Click);
            // 
            // selectControllerLable
            // 
            this.selectControllerLable.Name = "selectControllerLable";
            this.selectControllerLable.Size = new System.Drawing.Size(119, 22);
            this.selectControllerLable.Text = "Выбор контроллера";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // SelectControllerBox
            // 
            this.SelectControllerBox.AutoSize = false;
            this.SelectControllerBox.Items.AddRange(new object[] {
            "Настройка, переход в позицию",
            "Управление из файла",
            "Управление из ФРУНД (Real Time)"});
            this.SelectControllerBox.Name = "SelectControllerBox";
            this.SelectControllerBox.Size = new System.Drawing.Size(250, 23);
            // 
            // selectControllerButton
            // 
            this.selectControllerButton.BackColor = System.Drawing.SystemColors.Control;
            this.selectControllerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.selectControllerButton.Image = ((System.Drawing.Image)(resources.GetObject("selectControllerButton.Image")));
            this.selectControllerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectControllerButton.Name = "selectControllerButton";
            this.selectControllerButton.Size = new System.Drawing.Size(48, 22);
            this.selectControllerButton.Text = "Выбор";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabJointsList);
            this.tabControl1.Controls.Add(this.tabSensorsList);
            this.tabControl1.Controls.Add(this.tabPlayFileControl);
            this.tabControl1.Controls.Add(this.tabRealTimeControl);
            this.tabControl1.Controls.Add(this.tabPageGraph);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 544);
            this.tabControl1.TabIndex = 9;
            // 
            // tabJointsList
            // 
            this.tabJointsList.Controls.Add(this.jointsListView);
            this.tabJointsList.Location = new System.Drawing.Point(4, 22);
            this.tabJointsList.Name = "tabJointsList";
            this.tabJointsList.Padding = new System.Windows.Forms.Padding(3);
            this.tabJointsList.Size = new System.Drawing.Size(556, 518);
            this.tabJointsList.TabIndex = 0;
            this.tabJointsList.Text = "Приводы";
            this.tabJointsList.UseVisualStyleBackColor = true;
            // 
            // jointsListView
            // 
            this.jointsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jointsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jointsListView.Location = new System.Drawing.Point(6, 6);
            this.jointsListView.Name = "jointsListView";
            this.jointsListView.Size = new System.Drawing.Size(544, 506);
            this.jointsListView.TabIndex = 0;
            // 
            // tabSensorsList
            // 
            this.tabSensorsList.Controls.Add(this.sensorsListView);
            this.tabSensorsList.Location = new System.Drawing.Point(4, 22);
            this.tabSensorsList.Name = "tabSensorsList";
            this.tabSensorsList.Padding = new System.Windows.Forms.Padding(3);
            this.tabSensorsList.Size = new System.Drawing.Size(556, 518);
            this.tabSensorsList.TabIndex = 1;
            this.tabSensorsList.Text = "Датчики";
            this.tabSensorsList.UseVisualStyleBackColor = true;
            // 
            // sensorsListView
            // 
            this.sensorsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sensorsListView.Location = new System.Drawing.Point(6, 6);
            this.sensorsListView.Name = "sensorsListView";
            this.sensorsListView.Size = new System.Drawing.Size(544, 506);
            this.sensorsListView.TabIndex = 0;
            // 
            // tabPlayFileControl
            // 
            this.tabPlayFileControl.Location = new System.Drawing.Point(4, 22);
            this.tabPlayFileControl.Name = "tabPlayFileControl";
            this.tabPlayFileControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayFileControl.Size = new System.Drawing.Size(556, 518);
            this.tabPlayFileControl.TabIndex = 3;
            this.tabPlayFileControl.Text = "Управление из файла";
            this.tabPlayFileControl.UseVisualStyleBackColor = true;
            // 
            // tabRealTimeControl
            // 
            this.tabRealTimeControl.Controls.Add(this.frundControllerView);
            this.tabRealTimeControl.Location = new System.Drawing.Point(4, 22);
            this.tabRealTimeControl.Name = "tabRealTimeControl";
            this.tabRealTimeControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabRealTimeControl.Size = new System.Drawing.Size(556, 518);
            this.tabRealTimeControl.TabIndex = 4;
            this.tabRealTimeControl.Text = "Управление RealTime";
            this.tabRealTimeControl.UseVisualStyleBackColor = true;
            // 
            // frundControllerView
            // 
            this.frundControllerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frundControllerView.Location = new System.Drawing.Point(6, 6);
            this.frundControllerView.Name = "frundControllerView";
            this.frundControllerView.Size = new System.Drawing.Size(544, 506);
            this.frundControllerView.TabIndex = 0;
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.Controls.Add(this.graphView);
            this.tabPageGraph.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraph.Size = new System.Drawing.Size(556, 518);
            this.tabPageGraph.TabIndex = 5;
            this.tabPageGraph.Text = "График";
            this.tabPageGraph.UseVisualStyleBackColor = true;
            // 
            // graphView
            // 
            this.graphView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphView.Location = new System.Drawing.Point(6, 6);
            this.graphView.Name = "graphView";
            this.graphView.Size = new System.Drawing.Size(544, 506);
            this.graphView.TabIndex = 0;
            // 
            // initPosButton
            // 
            this.initPosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.initPosButton.Location = new System.Drawing.Point(582, 219);
            this.initPosButton.Name = "initPosButton";
            this.initPosButton.Size = new System.Drawing.Size(153, 23);
            this.initPosButton.TabIndex = 12;
            this.initPosButton.Text = "Переход в стартовое";
            this.initPosButton.UseVisualStyleBackColor = true;
            this.initPosButton.Click += new System.EventHandler(this.initPosButton_Click);
            // 
            // selectedJointView
            // 
            this.selectedJointView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedJointView.Location = new System.Drawing.Point(582, 277);
            this.selectedJointView.Name = "selectedJointView";
            this.selectedJointView.Size = new System.Drawing.Size(246, 283);
            this.selectedJointView.TabIndex = 11;
            // 
            // powerSourcesView
            // 
            this.powerSourcesView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.powerSourcesView.Location = new System.Drawing.Point(582, 28);
            this.powerSourcesView.Name = "powerSourcesView";
            this.powerSourcesView.Size = new System.Drawing.Size(246, 185);
            this.powerSourcesView.TabIndex = 10;
            // 
            // stopTransitButton
            // 
            this.stopTransitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopTransitButton.Location = new System.Drawing.Point(741, 219);
            this.stopTransitButton.Name = "stopTransitButton";
            this.stopTransitButton.Size = new System.Drawing.Size(87, 23);
            this.stopTransitButton.TabIndex = 13;
            this.stopTransitButton.Text = "Остановка";
            this.stopTransitButton.UseVisualStyleBackColor = true;
            this.stopTransitButton.Click += new System.EventHandler(this.stopTransitButton_Click);
            // 
            // transitionProgressBar
            // 
            this.transitionProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transitionProgressBar.Location = new System.Drawing.Point(582, 248);
            this.transitionProgressBar.Name = "transitionProgressBar";
            this.transitionProgressBar.Size = new System.Drawing.Size(246, 23);
            this.transitionProgressBar.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 601);
            this.Controls.Add(this.transitionProgressBar);
            this.Controls.Add(this.stopTransitButton);
            this.Controls.Add(this.initPosButton);
            this.Controls.Add(this.selectedJointView);
            this.Controls.Add(this.powerSourcesView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.statusStrip);
            this.Name = "MainForm";
            this.Text = "ROSBRIDGE Client for AR600 robot control";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabJointsList.ResumeLayout(false);
            this.tabSensorsList.ResumeLayout(false);
            this.tabRealTimeControl.ResumeLayout(false);
            this.tabPageGraph.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripLabel selectControllerLable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox SelectControllerBox;
        private System.Windows.Forms.ToolStripButton selectControllerButton;
        private System.Windows.Forms.ToolStripStatusLabel lableMasterLinkState;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabJointsList;
        private Views.JointsListView jointsListView;
        private System.Windows.Forms.TabPage tabSensorsList;
        private Views.SensorsListView sensorsListView;
        private System.Windows.Forms.TabPage tabPlayFileControl;
        private System.Windows.Forms.TabPage tabRealTimeControl;
        private Views.PowerSourcesView powerSourcesView;
        private Views.SelectedJointView selectedJointView;
        private System.Windows.Forms.Button initPosButton;
        private System.Windows.Forms.TabPage tabPageGraph;
        private Views.GraphView graphView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox editMasterUri;
        private System.Windows.Forms.ToolStripButton connectToMasterButton;
        private FrundController.Views.FrundControllerView frundControllerView;
        private System.Windows.Forms.Button stopTransitButton;
        private System.Windows.Forms.ProgressBar transitionProgressBar;
    }
}

