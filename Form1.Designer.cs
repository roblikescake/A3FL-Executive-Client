namespace A3FL_Executive_Client
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.staticLabelPlayerName = new System.Windows.Forms.Label();
            this.inputSupportName = new System.Windows.Forms.TextBox();
            this.inputPlayerName = new System.Windows.Forms.TextBox();
            this.staticLabelSupportName = new System.Windows.Forms.Label();
            this.inputChooseResponse = new System.Windows.Forms.ComboBox();
            this.staticLabelResponse = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.staticLabelMsgPreview = new System.Windows.Forms.Label();
            this.labelMessagePreview = new System.Windows.Forms.Label();
            this.buttonBattlemetrics = new System.Windows.Forms.Button();
            this.buttonAdminPanel = new System.Windows.Forms.Button();
            this.buttonPunishmentSystem = new System.Windows.Forms.Button();
            this.buttonStaffRecords = new System.Windows.Forms.Button();
            this.buttonDisciplinaryTracker = new System.Windows.Forms.Button();
            this.buttonMainDrive = new System.Windows.Forms.Button();
            this.buttonOperationsManual = new System.Windows.Forms.Button();
            this.buttonActivityForm = new System.Windows.Forms.Button();
            this.buttonActivityStats = new System.Windows.Forms.Button();
            this.staticLabelCompItem = new System.Windows.Forms.Label();
            this.inputCompensationItem = new System.Windows.Forms.TextBox();
            this.buttonAddCompensationItem = new System.Windows.Forms.Button();
            this.buttonClearCompensationList = new System.Windows.Forms.Button();
            this.labelCompensationList = new System.Windows.Forms.Label();
            this.staticLabelCompList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // staticLabelPlayerName
            // 
            this.staticLabelPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.staticLabelPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.staticLabelPlayerName.ForeColor = System.Drawing.Color.White;
            this.staticLabelPlayerName.Location = new System.Drawing.Point(24, 48);
            this.staticLabelPlayerName.Name = "staticLabelPlayerName";
            this.staticLabelPlayerName.Size = new System.Drawing.Size(420, 35);
            this.staticLabelPlayerName.TabIndex = 5;
            this.staticLabelPlayerName.Text = "Player Name";
            this.staticLabelPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputSupportName
            // 
            this.inputSupportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.inputSupportName.Location = new System.Drawing.Point(24, 176);
            this.inputSupportName.Name = "inputSupportName";
            this.inputSupportName.Size = new System.Drawing.Size(420, 35);
            this.inputSupportName.TabIndex = 2;
            // 
            // inputPlayerName
            // 
            this.inputPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.inputPlayerName.Location = new System.Drawing.Point(24, 88);
            this.inputPlayerName.Name = "inputPlayerName";
            this.inputPlayerName.Size = new System.Drawing.Size(420, 35);
            this.inputPlayerName.TabIndex = 1;
            // 
            // staticLabelSupportName
            // 
            this.staticLabelSupportName.BackColor = System.Drawing.Color.Transparent;
            this.staticLabelSupportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.staticLabelSupportName.ForeColor = System.Drawing.Color.White;
            this.staticLabelSupportName.Location = new System.Drawing.Point(24, 136);
            this.staticLabelSupportName.Name = "staticLabelSupportName";
            this.staticLabelSupportName.Size = new System.Drawing.Size(420, 35);
            this.staticLabelSupportName.TabIndex = 6;
            this.staticLabelSupportName.Text = "Your Name";
            this.staticLabelSupportName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputChooseResponse
            // 
            this.inputChooseResponse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputChooseResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.inputChooseResponse.FormattingEnabled = true;
            this.inputChooseResponse.Items.AddRange(new object[] {
            "Support Ticket Completed",
            "Accepted Whitelist",
            "Player Report",
            "Accepted Comp Request - Items",
            "Accepted Comp Request - Vehicle",
            "Name Change Required"});
            this.inputChooseResponse.Location = new System.Drawing.Point(24, 272);
            this.inputChooseResponse.Name = "inputChooseResponse";
            this.inputChooseResponse.Size = new System.Drawing.Size(420, 33);
            this.inputChooseResponse.TabIndex = 3;
            this.inputChooseResponse.SelectedIndexChanged += new System.EventHandler(this.inputChooseResponse_SelectedIndexChanged);
            // 
            // staticLabelResponse
            // 
            this.staticLabelResponse.BackColor = System.Drawing.Color.Transparent;
            this.staticLabelResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.staticLabelResponse.ForeColor = System.Drawing.Color.White;
            this.staticLabelResponse.Location = new System.Drawing.Point(24, 232);
            this.staticLabelResponse.Name = "staticLabelResponse";
            this.staticLabelResponse.Size = new System.Drawing.Size(420, 35);
            this.staticLabelResponse.TabIndex = 8;
            this.staticLabelResponse.Text = "Response";
            this.staticLabelResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.Transparent;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonGenerate.Location = new System.Drawing.Point(24, 712);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(172, 75);
            this.buttonGenerate.TabIndex = 7;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.Transparent;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCopy.Location = new System.Drawing.Point(272, 712);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(172, 75);
            this.buttonCopy.TabIndex = 8;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.ForeColor = System.Drawing.Color.Red;
            this.buttonClear.Location = new System.Drawing.Point(24, 800);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(420, 75);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "CLEAR INPUT DATA";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // staticLabelMsgPreview
            // 
            this.staticLabelMsgPreview.BackColor = System.Drawing.Color.Transparent;
            this.staticLabelMsgPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staticLabelMsgPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.staticLabelMsgPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.staticLabelMsgPreview.Location = new System.Drawing.Point(1296, 16);
            this.staticLabelMsgPreview.Name = "staticLabelMsgPreview";
            this.staticLabelMsgPreview.Size = new System.Drawing.Size(600, 32);
            this.staticLabelMsgPreview.TabIndex = 13;
            this.staticLabelMsgPreview.Text = "Message Preview";
            this.staticLabelMsgPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMessagePreview
            // 
            this.labelMessagePreview.BackColor = System.Drawing.Color.Transparent;
            this.labelMessagePreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelMessagePreview.Location = new System.Drawing.Point(520, 16);
            this.labelMessagePreview.Name = "labelMessagePreview";
            this.labelMessagePreview.Size = new System.Drawing.Size(1376, 464);
            this.labelMessagePreview.TabIndex = 12;
            this.labelMessagePreview.Text = " ";
            // 
            // buttonBattlemetrics
            // 
            this.buttonBattlemetrics.BackColor = System.Drawing.Color.Transparent;
            this.buttonBattlemetrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBattlemetrics.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonBattlemetrics.Location = new System.Drawing.Point(656, 936);
            this.buttonBattlemetrics.Name = "buttonBattlemetrics";
            this.buttonBattlemetrics.Size = new System.Drawing.Size(175, 75);
            this.buttonBattlemetrics.TabIndex = 13;
            this.buttonBattlemetrics.Text = "Battlemetrics";
            this.buttonBattlemetrics.UseVisualStyleBackColor = false;
            this.buttonBattlemetrics.Click += new System.EventHandler(this.buttonBattlemetrics_Click);
            // 
            // buttonAdminPanel
            // 
            this.buttonAdminPanel.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminPanel.ForeColor = System.Drawing.Color.BlueViolet;
            this.buttonAdminPanel.Location = new System.Drawing.Point(864, 936);
            this.buttonAdminPanel.Name = "buttonAdminPanel";
            this.buttonAdminPanel.Size = new System.Drawing.Size(175, 75);
            this.buttonAdminPanel.TabIndex = 14;
            this.buttonAdminPanel.Text = "Exec Admin Panel";
            this.buttonAdminPanel.UseVisualStyleBackColor = false;
            this.buttonAdminPanel.Click += new System.EventHandler(this.buttonAdminPanel_Click);
            // 
            // buttonPunishmentSystem
            // 
            this.buttonPunishmentSystem.BackColor = System.Drawing.Color.Transparent;
            this.buttonPunishmentSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPunishmentSystem.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonPunishmentSystem.Location = new System.Drawing.Point(1488, 936);
            this.buttonPunishmentSystem.Name = "buttonPunishmentSystem";
            this.buttonPunishmentSystem.Size = new System.Drawing.Size(175, 75);
            this.buttonPunishmentSystem.TabIndex = 17;
            this.buttonPunishmentSystem.Text = "Punishment System";
            this.buttonPunishmentSystem.UseVisualStyleBackColor = false;
            this.buttonPunishmentSystem.Click += new System.EventHandler(this.buttonPunishmentSystem_Click);
            // 
            // buttonStaffRecords
            // 
            this.buttonStaffRecords.BackColor = System.Drawing.Color.Transparent;
            this.buttonStaffRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStaffRecords.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonStaffRecords.Location = new System.Drawing.Point(1072, 936);
            this.buttonStaffRecords.Name = "buttonStaffRecords";
            this.buttonStaffRecords.Size = new System.Drawing.Size(175, 75);
            this.buttonStaffRecords.TabIndex = 15;
            this.buttonStaffRecords.Text = "Staff Records";
            this.buttonStaffRecords.UseVisualStyleBackColor = false;
            this.buttonStaffRecords.Click += new System.EventHandler(this.buttonStaffRecords_Click);
            // 
            // buttonDisciplinaryTracker
            // 
            this.buttonDisciplinaryTracker.BackColor = System.Drawing.Color.Transparent;
            this.buttonDisciplinaryTracker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisciplinaryTracker.ForeColor = System.Drawing.Color.BlueViolet;
            this.buttonDisciplinaryTracker.Location = new System.Drawing.Point(1280, 936);
            this.buttonDisciplinaryTracker.Name = "buttonDisciplinaryTracker";
            this.buttonDisciplinaryTracker.Size = new System.Drawing.Size(175, 75);
            this.buttonDisciplinaryTracker.TabIndex = 16;
            this.buttonDisciplinaryTracker.Text = "Disciplinary Tracker";
            this.buttonDisciplinaryTracker.UseVisualStyleBackColor = false;
            this.buttonDisciplinaryTracker.Click += new System.EventHandler(this.buttonDisciplinaryTracker_Click);
            // 
            // buttonMainDrive
            // 
            this.buttonMainDrive.BackColor = System.Drawing.Color.Transparent;
            this.buttonMainDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainDrive.ForeColor = System.Drawing.Color.BlueViolet;
            this.buttonMainDrive.Location = new System.Drawing.Point(1696, 936);
            this.buttonMainDrive.Name = "buttonMainDrive";
            this.buttonMainDrive.Size = new System.Drawing.Size(175, 75);
            this.buttonMainDrive.TabIndex = 18;
            this.buttonMainDrive.Text = "Main Exec Drive";
            this.buttonMainDrive.UseVisualStyleBackColor = false;
            this.buttonMainDrive.Click += new System.EventHandler(this.buttonMainDrive_Click);
            // 
            // buttonOperationsManual
            // 
            this.buttonOperationsManual.BackColor = System.Drawing.Color.Transparent;
            this.buttonOperationsManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOperationsManual.ForeColor = System.Drawing.Color.BlueViolet;
            this.buttonOperationsManual.Location = new System.Drawing.Point(448, 936);
            this.buttonOperationsManual.Name = "buttonOperationsManual";
            this.buttonOperationsManual.Size = new System.Drawing.Size(175, 75);
            this.buttonOperationsManual.TabIndex = 12;
            this.buttonOperationsManual.Text = "Operations Manual";
            this.buttonOperationsManual.UseVisualStyleBackColor = false;
            this.buttonOperationsManual.Click += new System.EventHandler(this.buttonOperationsManual_Click);
            // 
            // buttonActivityForm
            // 
            this.buttonActivityForm.BackColor = System.Drawing.Color.Transparent;
            this.buttonActivityForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActivityForm.ForeColor = System.Drawing.Color.BlueViolet;
            this.buttonActivityForm.Location = new System.Drawing.Point(32, 936);
            this.buttonActivityForm.Name = "buttonActivityForm";
            this.buttonActivityForm.Size = new System.Drawing.Size(175, 75);
            this.buttonActivityForm.TabIndex = 10;
            this.buttonActivityForm.Text = "Exec Activity Form";
            this.buttonActivityForm.UseVisualStyleBackColor = false;
            this.buttonActivityForm.Click += new System.EventHandler(this.buttonActivityForm_Click);
            // 
            // buttonActivityStats
            // 
            this.buttonActivityStats.BackColor = System.Drawing.Color.Transparent;
            this.buttonActivityStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActivityStats.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonActivityStats.Location = new System.Drawing.Point(240, 936);
            this.buttonActivityStats.Name = "buttonActivityStats";
            this.buttonActivityStats.Size = new System.Drawing.Size(175, 75);
            this.buttonActivityStats.TabIndex = 11;
            this.buttonActivityStats.Text = "Exec Activity Stats";
            this.buttonActivityStats.UseVisualStyleBackColor = false;
            this.buttonActivityStats.Click += new System.EventHandler(this.buttonActivityStats_Click);
            // 
            // staticLabelCompItem
            // 
            this.staticLabelCompItem.BackColor = System.Drawing.Color.Transparent;
            this.staticLabelCompItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.staticLabelCompItem.ForeColor = System.Drawing.Color.White;
            this.staticLabelCompItem.Location = new System.Drawing.Point(24, 352);
            this.staticLabelCompItem.Name = "staticLabelCompItem";
            this.staticLabelCompItem.Size = new System.Drawing.Size(420, 35);
            this.staticLabelCompItem.TabIndex = 24;
            this.staticLabelCompItem.Text = "Item to Compensate";
            this.staticLabelCompItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputCompensationItem
            // 
            this.inputCompensationItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.inputCompensationItem.Location = new System.Drawing.Point(24, 392);
            this.inputCompensationItem.Name = "inputCompensationItem";
            this.inputCompensationItem.Size = new System.Drawing.Size(420, 35);
            this.inputCompensationItem.TabIndex = 4;
            // 
            // buttonAddCompensationItem
            // 
            this.buttonAddCompensationItem.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddCompensationItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCompensationItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.buttonAddCompensationItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAddCompensationItem.Location = new System.Drawing.Point(24, 440);
            this.buttonAddCompensationItem.Name = "buttonAddCompensationItem";
            this.buttonAddCompensationItem.Size = new System.Drawing.Size(420, 75);
            this.buttonAddCompensationItem.TabIndex = 5;
            this.buttonAddCompensationItem.Text = "Add Compensation item";
            this.buttonAddCompensationItem.UseVisualStyleBackColor = false;
            this.buttonAddCompensationItem.Click += new System.EventHandler(this.buttonAddCompensationItem_Click);
            // 
            // buttonClearCompensationList
            // 
            this.buttonClearCompensationList.BackColor = System.Drawing.Color.Transparent;
            this.buttonClearCompensationList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearCompensationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.buttonClearCompensationList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonClearCompensationList.Location = new System.Drawing.Point(24, 528);
            this.buttonClearCompensationList.Name = "buttonClearCompensationList";
            this.buttonClearCompensationList.Size = new System.Drawing.Size(420, 75);
            this.buttonClearCompensationList.TabIndex = 6;
            this.buttonClearCompensationList.Text = "Clear Compensation List";
            this.buttonClearCompensationList.UseVisualStyleBackColor = false;
            this.buttonClearCompensationList.Click += new System.EventHandler(this.buttonClearCompensationList_Click);
            // 
            // labelCompensationList
            // 
            this.labelCompensationList.BackColor = System.Drawing.Color.Transparent;
            this.labelCompensationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelCompensationList.ForeColor = System.Drawing.Color.White;
            this.labelCompensationList.Location = new System.Drawing.Point(1488, 480);
            this.labelCompensationList.Name = "labelCompensationList";
            this.labelCompensationList.Size = new System.Drawing.Size(404, 450);
            this.labelCompensationList.TabIndex = 27;
            this.labelCompensationList.Text = " ";
            // 
            // staticLabelCompList
            // 
            this.staticLabelCompList.BackColor = System.Drawing.Color.Transparent;
            this.staticLabelCompList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staticLabelCompList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.staticLabelCompList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.staticLabelCompList.Location = new System.Drawing.Point(1392, 448);
            this.staticLabelCompList.Name = "staticLabelCompList";
            this.staticLabelCompList.Size = new System.Drawing.Size(500, 32);
            this.staticLabelCompList.TabIndex = 28;
            this.staticLabelCompList.Text = "Compensation List";
            this.staticLabelCompList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A3FL_Executive_Client.Properties.Resources.Yt_Ban1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1038);
            this.Controls.Add(this.staticLabelCompList);
            this.Controls.Add(this.labelCompensationList);
            this.Controls.Add(this.buttonClearCompensationList);
            this.Controls.Add(this.buttonAddCompensationItem);
            this.Controls.Add(this.staticLabelCompItem);
            this.Controls.Add(this.inputCompensationItem);
            this.Controls.Add(this.buttonActivityForm);
            this.Controls.Add(this.buttonActivityStats);
            this.Controls.Add(this.buttonOperationsManual);
            this.Controls.Add(this.buttonMainDrive);
            this.Controls.Add(this.buttonDisciplinaryTracker);
            this.Controls.Add(this.buttonPunishmentSystem);
            this.Controls.Add(this.buttonStaffRecords);
            this.Controls.Add(this.buttonAdminPanel);
            this.Controls.Add(this.buttonBattlemetrics);
            this.Controls.Add(this.staticLabelMsgPreview);
            this.Controls.Add(this.labelMessagePreview);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.staticLabelResponse);
            this.Controls.Add(this.inputChooseResponse);
            this.Controls.Add(this.staticLabelSupportName);
            this.Controls.Add(this.staticLabelPlayerName);
            this.Controls.Add(this.inputSupportName);
            this.Controls.Add(this.inputPlayerName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Arna 3 Fishers Life Executive Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staticLabelPlayerName;
        private System.Windows.Forms.TextBox inputSupportName;
        private System.Windows.Forms.TextBox inputPlayerName;
        private System.Windows.Forms.Label staticLabelSupportName;
        private System.Windows.Forms.ComboBox inputChooseResponse;
        private System.Windows.Forms.Label staticLabelResponse;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label staticLabelMsgPreview;
        private System.Windows.Forms.Label labelMessagePreview;
        private System.Windows.Forms.Button buttonBattlemetrics;
        private System.Windows.Forms.Button buttonAdminPanel;
        private System.Windows.Forms.Button buttonPunishmentSystem;
        private System.Windows.Forms.Button buttonStaffRecords;
        private System.Windows.Forms.Button buttonDisciplinaryTracker;
        private System.Windows.Forms.Button buttonMainDrive;
        private System.Windows.Forms.Button buttonOperationsManual;
        private System.Windows.Forms.Button buttonActivityForm;
        private System.Windows.Forms.Button buttonActivityStats;
        private System.Windows.Forms.Label staticLabelCompItem;
        private System.Windows.Forms.TextBox inputCompensationItem;
        private System.Windows.Forms.Button buttonAddCompensationItem;
        private System.Windows.Forms.Button buttonClearCompensationList;
        private System.Windows.Forms.Label labelCompensationList;
        private System.Windows.Forms.Label staticLabelCompList;
    }
}

