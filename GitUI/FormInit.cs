﻿using System;
using System.IO;
using System.Windows.Forms;
using GitCommands;
using GitCommands.Repository;
using ResourceManager.Translation;

namespace GitUI
{
    public partial class FormInit : GitExtensionsForm
    {
        private readonly TranslationString _chooseDirectory =
            new TranslationString("Please choose a directory.");

        private readonly TranslationString _chooseDirectoryCaption =
            new TranslationString("Choose directory");

        private readonly TranslationString _chooseDirectoryNotFile =
            new TranslationString("Cannot initialize a new repository on a file.\nPlease choose a directory.");

        private readonly TranslationString _chooseDirectoryNotFileCaption =
            new TranslationString("Error");

        private readonly TranslationString _initMsgBoxCaption =
            new TranslationString("Initialize new repository");

        

        public FormInit(string dir)
        {
            InitializeComponent();
            Translate();
            Directory.Text = dir;
        }

        public FormInit()
        {
            InitializeComponent();
            Translate();

            if (!GitModule.Current.ValidWorkingDir())
                Directory.Text = GitModule.CurrentWorkingDir;
        }

        private void DirectoryDropDown(object sender, EventArgs e)
        {
            Directory.DataSource = Repositories.RepositoryHistory.Repositories;
            Directory.DisplayMember = "Path";
        }

        private void InitClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Directory.Text))
            {
                MessageBox.Show(this, _chooseDirectory.Text,_chooseDirectoryCaption.Text);
                return;
            }

            if (File.Exists(Directory.Text))
            {
                MessageBox.Show(this, _chooseDirectoryNotFile.Text,_chooseDirectoryNotFileCaption.Text);
                return;
            }

            GitModule.CurrentWorkingDir = Directory.Text;

            if (!System.IO.Directory.Exists(GitModule.CurrentWorkingDir))
                System.IO.Directory.CreateDirectory(GitModule.CurrentWorkingDir);

            MessageBox.Show(this, GitModule.Current.Init(Central.Checked, Central.Checked), _initMsgBoxCaption.Text);

            Repositories.AddMostRecentRepository(Directory.Text);

            Close();
        }

        private void BrowseClick(object sender, EventArgs e)
        {
            using (var browseDialog = new FolderBrowserDialog())
            {

                if (browseDialog.ShowDialog(this) == DialogResult.OK)
                    Directory.Text = browseDialog.SelectedPath;
            }
        }
    }
}