﻿namespace GitUI.RepoHosting
{
    partial class ForkAndCloneForm
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
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.ColumnHeader columnHeader4;
            System.Windows.Forms.ColumnHeader columnHeader5;
            System.Windows.Forms.ColumnHeader columnHeader7;
            System.Windows.Forms.ColumnHeader columnHeader8;
            this._searchBtn = new System.Windows.Forms.Button();
            this._searchTB = new System.Windows.Forms.TextBox();
            this._forkBtn = new System.Windows.Forms.Button();
            this._myReposLV = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._searchResultsLV = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._cloneBtn = new System.Windows.Forms.Button();
            this._destinationTB = new System.Windows.Forms.TextBox();
            this._browseForCloneToDirbtn = new System.Windows.Forms.Button();
            this._createDirTB = new System.Windows.Forms.TextBox();
            this._createDirectoryLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._openGitupPageBtn = new System.Windows.Forms.Button();
            this._descriptionLbl = new System.Windows.Forms.Label();
            this._closeBtn = new System.Windows.Forms.Button();
            this._tabControl = new System.Windows.Forms.TabControl();
            this._myReposPage = new System.Windows.Forms.TabPage();
            this._helpTextLbl = new System.Windows.Forms.Label();
            this._searchReposPage = new System.Windows.Forms.TabPage();
            this._orLbl = new System.Windows.Forms.Label();
            this._getFromUserBtn = new System.Windows.Forms.Button();
            this._searchResultItemDescription = new System.Windows.Forms.TextBox();
            this._cloneSetupGB = new System.Windows.Forms.GroupBox();
            this._addRemoteAsTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._cloneInfoText = new System.Windows.Forms.Label();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._tabControl.SuspendLayout();
            this._myReposPage.SuspendLayout();
            this._searchReposPage.SuspendLayout();
            this._cloneSetupGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Is fork";
            columnHeader3.Width = 45;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "# Forks";
            columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Name";
            columnHeader5.Width = 180;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Forks";
            columnHeader7.Width = 40;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Owner";
            columnHeader8.Width = 110;
            // 
            // _searchBtn
            // 
            this._searchBtn.Location = new System.Drawing.Point(230, 9);
            this._searchBtn.Name = "_searchBtn";
            this._searchBtn.Size = new System.Drawing.Size(93, 23);
            this._searchBtn.TabIndex = 1;
            this._searchBtn.Text = "Search";
            this._searchBtn.UseVisualStyleBackColor = true;
            this._searchBtn.Click += new System.EventHandler(this._searchBtn_Click);
            // 
            // _searchTB
            // 
            this._searchTB.Location = new System.Drawing.Point(15, 11);
            this._searchTB.Name = "_searchTB";
            this._searchTB.Size = new System.Drawing.Size(198, 21);
            this._searchTB.TabIndex = 0;
            this._searchTB.Enter += new System.EventHandler(this._searchTB_Enter);
            this._searchTB.Leave += new System.EventHandler(this._searchTB_Leave);
            // 
            // _forkBtn
            // 
            this._forkBtn.Location = new System.Drawing.Point(15, 231);
            this._forkBtn.Name = "_forkBtn";
            this._forkBtn.Size = new System.Drawing.Size(150, 23);
            this._forkBtn.TabIndex = 4;
            this._forkBtn.Text = "Fork!";
            this._forkBtn.UseVisualStyleBackColor = true;
            this._forkBtn.Click += new System.EventHandler(this._forkBtn_Click);
            // 
            // _myReposLV
            // 
            this._myReposLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._myReposLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader3,
            columnHeader4,
            this.columnHeader2});
            this._myReposLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this._myReposLV.HideSelection = false;
            this._myReposLV.Location = new System.Drawing.Point(6, 6);
            this._myReposLV.MultiSelect = false;
            this._myReposLV.Name = "_myReposLV";
            this._myReposLV.ShowGroups = false;
            this._myReposLV.Size = new System.Drawing.Size(330, 252);
            this._myReposLV.TabIndex = 7;
            this._myReposLV.UseCompatibleStateImageBehavior = false;
            this._myReposLV.View = System.Windows.Forms.View.Details;
            this._myReposLV.SelectedIndexChanged += new System.EventHandler(this._myReposLV_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Private";
            this.columnHeader2.Width = 45;
            // 
            // _searchResultsLV
            // 
            this._searchResultsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader5,
            columnHeader8,
            columnHeader7,
            this.columnHeader6});
            this._searchResultsLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this._searchResultsLV.HideSelection = false;
            this._searchResultsLV.Location = new System.Drawing.Point(15, 38);
            this._searchResultsLV.MultiSelect = false;
            this._searchResultsLV.Name = "_searchResultsLV";
            this._searchResultsLV.ShowGroups = false;
            this._searchResultsLV.Size = new System.Drawing.Size(397, 187);
            this._searchResultsLV.TabIndex = 3;
            this._searchResultsLV.UseCompatibleStateImageBehavior = false;
            this._searchResultsLV.View = System.Windows.Forms.View.Details;
            this._searchResultsLV.SelectedIndexChanged += new System.EventHandler(this._searchResultsLV_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Is fork";
            this.columnHeader6.Width = 41;
            // 
            // _cloneBtn
            // 
            this._cloneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cloneBtn.Location = new System.Drawing.Point(7, 132);
            this._cloneBtn.Name = "_cloneBtn";
            this._cloneBtn.Size = new System.Drawing.Size(158, 30);
            this._cloneBtn.TabIndex = 4;
            this._cloneBtn.Text = "Clone";
            this._cloneBtn.UseVisualStyleBackColor = true;
            this._cloneBtn.Click += new System.EventHandler(this._cloneBtn_Click);
            // 
            // _destinationTB
            // 
            this._destinationTB.Location = new System.Drawing.Point(10, 32);
            this._destinationTB.Name = "_destinationTB";
            this._destinationTB.Size = new System.Drawing.Size(294, 21);
            this._destinationTB.TabIndex = 0;
            this._destinationTB.TextChanged += new System.EventHandler(this._destinationTB_TextChanged);
            this._destinationTB.Validating += new System.ComponentModel.CancelEventHandler(this._destinationTB_Validating);
            // 
            // _browseForCloneToDirbtn
            // 
            this._browseForCloneToDirbtn.Location = new System.Drawing.Point(310, 31);
            this._browseForCloneToDirbtn.Name = "_browseForCloneToDirbtn";
            this._browseForCloneToDirbtn.Size = new System.Drawing.Size(102, 23);
            this._browseForCloneToDirbtn.TabIndex = 1;
            this._browseForCloneToDirbtn.Text = "Browse...";
            this._browseForCloneToDirbtn.UseVisualStyleBackColor = true;
            this._browseForCloneToDirbtn.Click += new System.EventHandler(this._browseForCloneToDirbtn_Click);
            // 
            // _createDirTB
            // 
            this._createDirTB.Location = new System.Drawing.Point(11, 71);
            this._createDirTB.Name = "_createDirTB";
            this._createDirTB.Size = new System.Drawing.Size(183, 21);
            this._createDirTB.TabIndex = 2;
            this._createDirTB.TextChanged += new System.EventHandler(this._createDirTB_TextChanged);
            this._createDirTB.Validating += new System.ComponentModel.CancelEventHandler(this._createDirTB_Validating);
            // 
            // _createDirectoryLbl
            // 
            this._createDirectoryLbl.AutoSize = true;
            this._createDirectoryLbl.Location = new System.Drawing.Point(9, 55);
            this._createDirectoryLbl.Name = "_createDirectoryLbl";
            this._createDirectoryLbl.Size = new System.Drawing.Size(75, 12);
            this._createDirectoryLbl.TabIndex = 13;
            this._createDirectoryLbl.Text = "Create directory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Destination folder:";
            // 
            // _openGitupPageBtn
            // 
            this._openGitupPageBtn.Location = new System.Drawing.Point(418, 203);
            this._openGitupPageBtn.Name = "_openGitupPageBtn";
            this._openGitupPageBtn.Size = new System.Drawing.Size(116, 23);
            this._openGitupPageBtn.TabIndex = 5;
            this._openGitupPageBtn.Text = "Open github page";
            this._openGitupPageBtn.UseVisualStyleBackColor = true;
            this._openGitupPageBtn.Click += new System.EventHandler(this._openGitupPageBtn_Click);
            // 
            // _descriptionLbl
            // 
            this._descriptionLbl.AutoSize = true;
            this._descriptionLbl.Location = new System.Drawing.Point(418, 45);
            this._descriptionLbl.Name = "_descriptionLbl";
            this._descriptionLbl.Size = new System.Drawing.Size(56, 12);
            this._descriptionLbl.TabIndex = 17;
            this._descriptionLbl.Text = "Description:";
            // 
            // _closeBtn
            // 
            this._closeBtn.Location = new System.Drawing.Point(554, 133);
            this._closeBtn.Name = "_closeBtn";
            this._closeBtn.Size = new System.Drawing.Size(91, 30);
            this._closeBtn.TabIndex = 5;
            this._closeBtn.Text = "Close";
            this._closeBtn.UseVisualStyleBackColor = true;
            this._closeBtn.Click += new System.EventHandler(this._closeBtn_Click);
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._myReposPage);
            this._tabControl.Controls.Add(this._searchReposPage);
            this._tabControl.Location = new System.Drawing.Point(1, 2);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(656, 290);
            this._tabControl.TabIndex = 21;
            this._tabControl.SelectedIndexChanged += new System.EventHandler(this._tabControl_SelectedIndexChanged);
            // 
            // _myReposPage
            // 
            this._myReposPage.Controls.Add(this._helpTextLbl);
            this._myReposPage.Controls.Add(this._myReposLV);
            this._myReposPage.Location = new System.Drawing.Point(4, 21);
            this._myReposPage.Name = "_myReposPage";
            this._myReposPage.Padding = new System.Windows.Forms.Padding(3);
            this._myReposPage.Size = new System.Drawing.Size(648, 265);
            this._myReposPage.TabIndex = 0;
            this._myReposPage.Text = "My repositories";
            this._myReposPage.UseVisualStyleBackColor = true;
            // 
            // _helpTextLbl
            // 
            this._helpTextLbl.Location = new System.Drawing.Point(360, 50);
            this._helpTextLbl.Name = "_helpTextLbl";
            this._helpTextLbl.Size = new System.Drawing.Size(266, 140);
            this._helpTextLbl.TabIndex = 10;
            this._helpTextLbl.Text = "If you want to fork a repository owned by somebody else, go to the Search for rep" +
    "ositories tab.";
            // 
            // _searchReposPage
            // 
            this._searchReposPage.Controls.Add(this._orLbl);
            this._searchReposPage.Controls.Add(this._getFromUserBtn);
            this._searchReposPage.Controls.Add(this._searchTB);
            this._searchReposPage.Controls.Add(this._searchResultItemDescription);
            this._searchReposPage.Controls.Add(this._searchBtn);
            this._searchReposPage.Controls.Add(this._openGitupPageBtn);
            this._searchReposPage.Controls.Add(this._descriptionLbl);
            this._searchReposPage.Controls.Add(this._forkBtn);
            this._searchReposPage.Controls.Add(this._searchResultsLV);
            this._searchReposPage.Location = new System.Drawing.Point(4, 21);
            this._searchReposPage.Name = "_searchReposPage";
            this._searchReposPage.Padding = new System.Windows.Forms.Padding(3);
            this._searchReposPage.Size = new System.Drawing.Size(648, 265);
            this._searchReposPage.TabIndex = 1;
            this._searchReposPage.Text = "Search for repositories";
            this._searchReposPage.UseVisualStyleBackColor = true;
            // 
            // _orLbl
            // 
            this._orLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._orLbl.AutoSize = true;
            this._orLbl.Location = new System.Drawing.Point(329, 14);
            this._orLbl.Name = "_orLbl";
            this._orLbl.Size = new System.Drawing.Size(14, 12);
            this._orLbl.TabIndex = 22;
            this._orLbl.Text = "or";
            // 
            // _getFromUserBtn
            // 
            this._getFromUserBtn.Location = new System.Drawing.Point(364, 9);
            this._getFromUserBtn.Name = "_getFromUserBtn";
            this._getFromUserBtn.Size = new System.Drawing.Size(124, 23);
            this._getFromUserBtn.TabIndex = 2;
            this._getFromUserBtn.Text = "Get from user";
            this._getFromUserBtn.UseVisualStyleBackColor = true;
            this._getFromUserBtn.Click += new System.EventHandler(this._getFromUserBtn_Click);
            // 
            // _searchResultItemDescription
            // 
            this._searchResultItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._searchResultItemDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._searchResultItemDescription.Location = new System.Drawing.Point(418, 63);
            this._searchResultItemDescription.Multiline = true;
            this._searchResultItemDescription.Name = "_searchResultItemDescription";
            this._searchResultItemDescription.ReadOnly = true;
            this._searchResultItemDescription.Size = new System.Drawing.Size(224, 134);
            this._searchResultItemDescription.TabIndex = 18;
            // 
            // _cloneSetupGB
            // 
            this._cloneSetupGB.Controls.Add(this._addRemoteAsTB);
            this._cloneSetupGB.Controls.Add(this.label3);
            this._cloneSetupGB.Controls.Add(this._cloneInfoText);
            this._cloneSetupGB.Controls.Add(this._createDirTB);
            this._cloneSetupGB.Controls.Add(this._closeBtn);
            this._cloneSetupGB.Controls.Add(this._createDirectoryLbl);
            this._cloneSetupGB.Controls.Add(this._cloneBtn);
            this._cloneSetupGB.Controls.Add(this.label1);
            this._cloneSetupGB.Controls.Add(this._browseForCloneToDirbtn);
            this._cloneSetupGB.Controls.Add(this._destinationTB);
            this._cloneSetupGB.Location = new System.Drawing.Point(5, 298);
            this._cloneSetupGB.Name = "_cloneSetupGB";
            this._cloneSetupGB.Size = new System.Drawing.Size(652, 172);
            this._cloneSetupGB.TabIndex = 14;
            this._cloneSetupGB.TabStop = false;
            this._cloneSetupGB.Text = "Clone";
            // 
            // _addRemoteAsTB
            // 
            this._addRemoteAsTB.Location = new System.Drawing.Point(212, 71);
            this._addRemoteAsTB.Name = "_addRemoteAsTB";
            this._addRemoteAsTB.Size = new System.Drawing.Size(200, 21);
            this._addRemoteAsTB.TabIndex = 3;
            this._addRemoteAsTB.TextChanged += new System.EventHandler(this._addRemoteAsTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "Add remote as:";
            // 
            // _cloneInfoText
            // 
            this._cloneInfoText.Location = new System.Drawing.Point(10, 96);
            this._cloneInfoText.Name = "_cloneInfoText";
            this._cloneInfoText.Size = new System.Drawing.Size(632, 35);
            this._cloneInfoText.TabIndex = 21;
            // 
            // ForkAndCloneForm
            // 
            
            
            this.ClientSize = new System.Drawing.Size(663, 475);
            this.Controls.Add(this._tabControl);
            this.Controls.Add(this._cloneSetupGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ForkAndCloneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote repository fork and clone";
            this.Load += new System.EventHandler(this.ForkAndCloneForm_Load);
            this._tabControl.ResumeLayout(false);
            this._myReposPage.ResumeLayout(false);
            this._searchReposPage.ResumeLayout(false);
            this._searchReposPage.PerformLayout();
            this._cloneSetupGB.ResumeLayout(false);
            this._cloneSetupGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _searchBtn;
        private System.Windows.Forms.TextBox _searchTB;
        private System.Windows.Forms.Button _forkBtn;
        private System.Windows.Forms.ListView _myReposLV;
        private System.Windows.Forms.ListView _searchResultsLV;
        private System.Windows.Forms.Button _cloneBtn;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox _destinationTB;
        private System.Windows.Forms.Button _browseForCloneToDirbtn;
        private System.Windows.Forms.Label _descriptionLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _openGitupPageBtn;
        private System.Windows.Forms.Button _closeBtn;
        private System.Windows.Forms.TextBox _createDirTB;
        private System.Windows.Forms.Label _createDirectoryLbl;
        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _myReposPage;
        private System.Windows.Forms.TabPage _searchReposPage;
        private System.Windows.Forms.GroupBox _cloneSetupGB;
        private System.Windows.Forms.Label _helpTextLbl;
        private System.Windows.Forms.Label _cloneInfoText;
        private System.Windows.Forms.TextBox _searchResultItemDescription;
        private System.Windows.Forms.TextBox _addRemoteAsTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _getFromUserBtn;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label _orLbl;
    }
}