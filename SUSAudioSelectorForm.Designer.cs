using System;


namespace SUSAudioSelector
{
    partial class SUSAudioSelector
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SUSAudioSelector));
            CurrentSongColumnLabel = new Label();
            CurrentSongLabel = new Label();
            SUSAudioSelectorMenuStrip = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            LoadSingleToolStripMenuItem = new ToolStripMenuItem();
            LoadBulkToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            HowToUseToolStripMenuItem = new ToolStripMenuItem();
            CurrentSongDirectoryColumnLabel = new Label();
            CurrentSongDirectoryLabel = new Label();
            NowPlayingColumnLabel = new Label();
            currentlyPlayingSongLabel = new Label();
            AvailableCoversLabel = new Label();
            CoverArtPictureBox = new PictureBox();
            SusFilesLabel = new Label();
            ApplyToSelectedSusFileButton = new Button();
            applyForAllSusFilesButton = new Button();
            AvailableCoversListBox = new ListBox();
            NextSongButton = new Button();
            CurrentSongMultiIndexCounterLabel = new Label();
            CurrentSongIdxLabel = new Label();
            idxDivisorLabel = new Label();
            TotalSongCountLabel = new Label();
            SusFileListBox = new ListBox();
            CoverCountLabel = new Label();
            SusFileCountLabel = new Label();
            PreviousSongButton = new Button();
            FileWriteStatusColumnLabel = new Label();
            FileWriteStatusLineLabel = new Label();
            UgcFileListBox = new ListBox();
            UgcFileCountLabel = new Label();
            UgcFilesLabel = new Label();
            ApplyToSelectedUgcFileButton = new Button();
            ApplyToAllUgcFilesButton = new Button();
            ApplyToAllChartsButton = new Button();
            mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            SUSAudioSelectorMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CoverArtPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).BeginInit();
            SuspendLayout();
            // 
            // CurrentSongColumnLabel
            // 
            CurrentSongColumnLabel.AutoSize = true;
            CurrentSongColumnLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CurrentSongColumnLabel.Location = new Point(12, 38);
            CurrentSongColumnLabel.Name = "CurrentSongColumnLabel";
            CurrentSongColumnLabel.Size = new Size(101, 19);
            CurrentSongColumnLabel.TabIndex = 0;
            CurrentSongColumnLabel.Text = "Current Song:";
            // 
            // CurrentSongLabel
            // 
            CurrentSongLabel.AutoSize = true;
            CurrentSongLabel.Font = new Font("Segoe UI", 10F);
            CurrentSongLabel.Location = new Point(119, 38);
            CurrentSongLabel.Name = "CurrentSongLabel";
            CurrentSongLabel.Size = new Size(119, 19);
            CurrentSongLabel.TabIndex = 1;
            CurrentSongLabel.Text = "CurrentSongLabel";
            CurrentSongLabel.Visible = false;
            // 
            // SUSAudioSelectorMenuStrip
            // 
            SUSAudioSelectorMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, AboutToolStripMenuItem });
            SUSAudioSelectorMenuStrip.Location = new Point(0, 0);
            SUSAudioSelectorMenuStrip.Name = "SUSAudioSelectorMenuStrip";
            SUSAudioSelectorMenuStrip.Size = new Size(551, 24);
            SUSAudioSelectorMenuStrip.TabIndex = 2;
            SUSAudioSelectorMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LoadSingleToolStripMenuItem, LoadBulkToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(37, 20);
            FileToolStripMenuItem.Text = "File";
            // 
            // LoadSingleToolStripMenuItem
            // 
            LoadSingleToolStripMenuItem.Name = "LoadSingleToolStripMenuItem";
            LoadSingleToolStripMenuItem.Size = new Size(135, 22);
            LoadSingleToolStripMenuItem.Text = "Load Single";
            LoadSingleToolStripMenuItem.Click += LoadSingleFolder_Click;
            // 
            // LoadBulkToolStripMenuItem
            // 
            LoadBulkToolStripMenuItem.Name = "LoadBulkToolStripMenuItem";
            LoadBulkToolStripMenuItem.Size = new Size(135, 22);
            LoadBulkToolStripMenuItem.Text = "Load Bulk";
            LoadBulkToolStripMenuItem.Click += LoadBulkFolders_Click;
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { HowToUseToolStripMenuItem });
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(52, 20);
            AboutToolStripMenuItem.Text = "About";
            // 
            // HowToUseToolStripMenuItem
            // 
            HowToUseToolStripMenuItem.Name = "HowToUseToolStripMenuItem";
            HowToUseToolStripMenuItem.Size = new Size(135, 22);
            HowToUseToolStripMenuItem.Text = "How to Use";
            HowToUseToolStripMenuItem.Click += ShowHowToUse_Click;
            // 
            // CurrentSongDirectoryColumnLabel
            // 
            CurrentSongDirectoryColumnLabel.AutoSize = true;
            CurrentSongDirectoryColumnLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CurrentSongDirectoryColumnLabel.Location = new Point(12, 57);
            CurrentSongDirectoryColumnLabel.Name = "CurrentSongDirectoryColumnLabel";
            CurrentSongDirectoryColumnLabel.Size = new Size(77, 19);
            CurrentSongDirectoryColumnLabel.TabIndex = 3;
            CurrentSongDirectoryColumnLabel.Text = "Directory:";
            // 
            // CurrentSongDirectoryLabel
            // 
            CurrentSongDirectoryLabel.AutoSize = true;
            CurrentSongDirectoryLabel.Font = new Font("Segoe UI", 10F);
            CurrentSongDirectoryLabel.Location = new Point(119, 57);
            CurrentSongDirectoryLabel.Name = "CurrentSongDirectoryLabel";
            CurrentSongDirectoryLabel.Size = new Size(175, 19);
            CurrentSongDirectoryLabel.TabIndex = 4;
            CurrentSongDirectoryLabel.Text = "CurrentSongDirectoryLabel";
            CurrentSongDirectoryLabel.Visible = false;
            // 
            // NowPlayingColumnLabel
            // 
            NowPlayingColumnLabel.AutoSize = true;
            NowPlayingColumnLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NowPlayingColumnLabel.Location = new Point(12, 286);
            NowPlayingColumnLabel.Name = "NowPlayingColumnLabel";
            NowPlayingColumnLabel.Size = new Size(90, 17);
            NowPlayingColumnLabel.TabIndex = 8;
            NowPlayingColumnLabel.Text = "Now Playing:";
            // 
            // currentlyPlayingSongLabel
            // 
            currentlyPlayingSongLabel.AutoSize = true;
            currentlyPlayingSongLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentlyPlayingSongLabel.Location = new Point(130, 138);
            currentlyPlayingSongLabel.Name = "currentlyPlayingSongLabel";
            currentlyPlayingSongLabel.Size = new Size(0, 17);
            currentlyPlayingSongLabel.TabIndex = 9;
            // 
            // AvailableCoversLabel
            // 
            AvailableCoversLabel.AutoSize = true;
            AvailableCoversLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AvailableCoversLabel.Location = new Point(282, 286);
            AvailableCoversLabel.Name = "AvailableCoversLabel";
            AvailableCoversLabel.Size = new Size(114, 17);
            AvailableCoversLabel.TabIndex = 12;
            AvailableCoversLabel.Text = "Available Covers:";
            // 
            // CoverArtPictureBox
            // 
            CoverArtPictureBox.Image = (Image)resources.GetObject("CoverArtPictureBox.Image");
            CoverArtPictureBox.Location = new Point(12, 306);
            CoverArtPictureBox.Name = "CoverArtPictureBox";
            CoverArtPictureBox.Size = new Size(250, 244);
            CoverArtPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            CoverArtPictureBox.TabIndex = 13;
            CoverArtPictureBox.TabStop = false;
            // 
            // SusFilesLabel
            // 
            SusFilesLabel.AutoSize = true;
            SusFilesLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SusFilesLabel.Location = new Point(12, 118);
            SusFilesLabel.Name = "SusFilesLabel";
            SusFilesLabel.Size = new Size(67, 17);
            SusFilesLabel.TabIndex = 15;
            SusFilesLabel.Text = "SUS Files:";
            // 
            // ApplyToSelectedSusFileButton
            // 
            ApplyToSelectedSusFileButton.Location = new Point(12, 609);
            ApplyToSelectedSusFileButton.Name = "ApplyToSelectedSusFileButton";
            ApplyToSelectedSusFileButton.Size = new Size(162, 23);
            ApplyToSelectedSusFileButton.TabIndex = 17;
            ApplyToSelectedSusFileButton.Text = "Apply to Selected SUS File";
            ApplyToSelectedSusFileButton.UseVisualStyleBackColor = true;
            ApplyToSelectedSusFileButton.Click += ApplyToSelectedSUSFileButton_Click;
            // 
            // applyForAllSusFilesButton
            // 
            applyForAllSusFilesButton.Location = new Point(403, 609);
            applyForAllSusFilesButton.Name = "applyForAllSusFilesButton";
            applyForAllSusFilesButton.Size = new Size(134, 23);
            applyForAllSusFilesButton.TabIndex = 18;
            applyForAllSusFilesButton.Text = "Apply to All SUS Files";
            applyForAllSusFilesButton.UseVisualStyleBackColor = true;
            applyForAllSusFilesButton.Click += ApplyForAllSUSFilesButton_Click;
            // 
            // AvailableCoversListBox
            // 
            AvailableCoversListBox.FormattingEnabled = true;
            AvailableCoversListBox.ItemHeight = 15;
            AvailableCoversListBox.Location = new Point(282, 306);
            AvailableCoversListBox.Name = "AvailableCoversListBox";
            AvailableCoversListBox.Size = new Size(255, 244);
            AvailableCoversListBox.TabIndex = 19;
            AvailableCoversListBox.SelectedIndexChanged += coverListIdxChanged;
            // 
            // NextSongButton
            // 
            NextSongButton.Location = new Point(403, 765);
            NextSongButton.Name = "NextSongButton";
            NextSongButton.Size = new Size(134, 23);
            NextSongButton.TabIndex = 21;
            NextSongButton.Text = "Next Song";
            NextSongButton.UseVisualStyleBackColor = true;
            NextSongButton.Visible = false;
            NextSongButton.Click += NextSongButtonClick;
            // 
            // CurrentSongMultiIndexCounterLabel
            // 
            CurrentSongMultiIndexCounterLabel.AutoSize = true;
            CurrentSongMultiIndexCounterLabel.Location = new Point(228, 754);
            CurrentSongMultiIndexCounterLabel.Name = "CurrentSongMultiIndexCounterLabel";
            CurrentSongMultiIndexCounterLabel.Size = new Size(80, 15);
            CurrentSongMultiIndexCounterLabel.TabIndex = 22;
            CurrentSongMultiIndexCounterLabel.Text = "Current Song:";
            CurrentSongMultiIndexCounterLabel.Visible = false;
            // 
            // CurrentSongIdxLabel
            // 
            CurrentSongIdxLabel.AutoSize = true;
            CurrentSongIdxLabel.Location = new Point(228, 769);
            CurrentSongIdxLabel.Name = "CurrentSongIdxLabel";
            CurrentSongIdxLabel.Size = new Size(23, 15);
            CurrentSongIdxLabel.TabIndex = 23;
            CurrentSongIdxLabel.Text = "idx";
            CurrentSongIdxLabel.Visible = false;
            // 
            // idxDivisorLabel
            // 
            idxDivisorLabel.AutoSize = true;
            idxDivisorLabel.Location = new Point(257, 769);
            idxDivisorLabel.Name = "idxDivisorLabel";
            idxDivisorLabel.Size = new Size(12, 15);
            idxDivisorLabel.TabIndex = 24;
            idxDivisorLabel.Text = "/";
            idxDivisorLabel.Visible = false;
            // 
            // TotalSongCountLabel
            // 
            TotalSongCountLabel.AutoSize = true;
            TotalSongCountLabel.Enabled = false;
            TotalSongCountLabel.Location = new Point(275, 769);
            TotalSongCountLabel.Name = "TotalSongCountLabel";
            TotalSongCountLabel.Size = new Size(31, 15);
            TotalSongCountLabel.TabIndex = 25;
            TotalSongCountLabel.Text = "total";
            TotalSongCountLabel.TextAlign = ContentAlignment.MiddleRight;
            TotalSongCountLabel.Visible = false;
            // 
            // SusFileListBox
            // 
            SusFileListBox.FormattingEnabled = true;
            SusFileListBox.ItemHeight = 15;
            SusFileListBox.Location = new Point(12, 138);
            SusFileListBox.Name = "SusFileListBox";
            SusFileListBox.Size = new Size(250, 139);
            SusFileListBox.TabIndex = 26;
            SusFileListBox.SelectedIndexChanged += susFileListIdxChanged;
            // 
            // CoverCountLabel
            // 
            CoverCountLabel.AutoSize = true;
            CoverCountLabel.Location = new Point(470, 288);
            CoverCountLabel.Name = "CoverCountLabel";
            CoverCountLabel.Size = new Size(71, 15);
            CoverCountLabel.TabIndex = 27;
            CoverCountLabel.Text = "CoverCount";
            CoverCountLabel.Visible = false;
            // 
            // SusFileCountLabel
            // 
            SusFileCountLabel.AutoSize = true;
            SusFileCountLabel.Location = new Point(187, 120);
            SusFileCountLabel.Name = "SusFileCountLabel";
            SusFileCountLabel.Size = new Size(76, 15);
            SusFileCountLabel.TabIndex = 28;
            SusFileCountLabel.Text = "SusFileCount";
            SusFileCountLabel.Visible = false;
            // 
            // PreviousSongButton
            // 
            PreviousSongButton.Location = new Point(12, 765);
            PreviousSongButton.Name = "PreviousSongButton";
            PreviousSongButton.Size = new Size(162, 23);
            PreviousSongButton.TabIndex = 29;
            PreviousSongButton.Text = "Previous Song";
            PreviousSongButton.UseVisualStyleBackColor = true;
            PreviousSongButton.Visible = false;
            PreviousSongButton.Click += PreviousSongButtonClick;
            // 
            // FileWriteStatusColumnLabel
            // 
            FileWriteStatusColumnLabel.AutoSize = true;
            FileWriteStatusColumnLabel.Location = new Point(12, 707);
            FileWriteStatusColumnLabel.Name = "FileWriteStatusColumnLabel";
            FileWriteStatusColumnLabel.Size = new Size(42, 15);
            FileWriteStatusColumnLabel.TabIndex = 30;
            FileWriteStatusColumnLabel.Text = "Status:";
            // 
            // FileWriteStatusLineLabel
            // 
            FileWriteStatusLineLabel.AutoSize = true;
            FileWriteStatusLineLabel.Location = new Point(12, 725);
            FileWriteStatusLineLabel.Name = "FileWriteStatusLineLabel";
            FileWriteStatusLineLabel.Size = new Size(70, 15);
            FileWriteStatusLineLabel.TabIndex = 31;
            FileWriteStatusLineLabel.Text = "No changes";
            FileWriteStatusLineLabel.Visible = false;
            // 
            // UgcFileListBox
            // 
            UgcFileListBox.FormattingEnabled = true;
            UgcFileListBox.ItemHeight = 15;
            UgcFileListBox.Location = new Point(282, 138);
            UgcFileListBox.Name = "UgcFileListBox";
            UgcFileListBox.Size = new Size(255, 139);
            UgcFileListBox.TabIndex = 32;
            // 
            // UgcFileCountLabel
            // 
            UgcFileCountLabel.AutoSize = true;
            UgcFileCountLabel.Location = new Point(458, 120);
            UgcFileCountLabel.Name = "UgcFileCountLabel";
            UgcFileCountLabel.Size = new Size(79, 15);
            UgcFileCountLabel.TabIndex = 33;
            UgcFileCountLabel.Text = "UgcFileCount";
            // 
            // UgcFilesLabel
            // 
            UgcFilesLabel.AutoSize = true;
            UgcFilesLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            UgcFilesLabel.Location = new Point(282, 118);
            UgcFilesLabel.Name = "UgcFilesLabel";
            UgcFilesLabel.Size = new Size(66, 17);
            UgcFilesLabel.TabIndex = 34;
            UgcFilesLabel.Text = "UGC Files";
            // 
            // ApplyToSelectedUgcFileButton
            // 
            ApplyToSelectedUgcFileButton.Location = new Point(12, 638);
            ApplyToSelectedUgcFileButton.Name = "ApplyToSelectedUgcFileButton";
            ApplyToSelectedUgcFileButton.Size = new Size(162, 23);
            ApplyToSelectedUgcFileButton.TabIndex = 35;
            ApplyToSelectedUgcFileButton.Text = "Apply to Selected UGC File";
            ApplyToSelectedUgcFileButton.UseVisualStyleBackColor = true;
            ApplyToSelectedUgcFileButton.Click += ApplyToSelectedUgcFileButton_Click;
            // 
            // ApplyToAllUgcFilesButton
            // 
            ApplyToAllUgcFilesButton.Location = new Point(403, 638);
            ApplyToAllUgcFilesButton.Name = "ApplyToAllUgcFilesButton";
            ApplyToAllUgcFilesButton.Size = new Size(134, 23);
            ApplyToAllUgcFilesButton.TabIndex = 36;
            ApplyToAllUgcFilesButton.Text = "Apply To All UGC Files";
            ApplyToAllUgcFilesButton.UseVisualStyleBackColor = true;
            ApplyToAllUgcFilesButton.Click += ApplyToAllUgcFilesButton_Click;
            // 
            // ApplyToAllChartsButton
            // 
            ApplyToAllChartsButton.BackColor = Color.LightGreen;
            ApplyToAllChartsButton.Location = new Point(208, 609);
            ApplyToAllChartsButton.Name = "ApplyToAllChartsButton";
            ApplyToAllChartsButton.Size = new Size(140, 52);
            ApplyToAllChartsButton.TabIndex = 37;
            ApplyToAllChartsButton.Text = "Apply To All Charts";
            ApplyToAllChartsButton.UseVisualStyleBackColor = false;
            ApplyToAllChartsButton.Click += ApplyToAllCharts_Click;
            // 
            // mediaPlayer
            // 
            mediaPlayer.Enabled = true;
            mediaPlayer.Location = new Point(12, 556);
            mediaPlayer.Name = "mediaPlayer";
            mediaPlayer.OcxState = (AxHost.State)resources.GetObject("mediaPlayer.OcxState");
            mediaPlayer.Size = new Size(525, 47);
            mediaPlayer.TabIndex = 38;
            // 
            // SUSAudioSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 800);
            Controls.Add(mediaPlayer);
            Controls.Add(ApplyToAllChartsButton);
            Controls.Add(ApplyToAllUgcFilesButton);
            Controls.Add(ApplyToSelectedUgcFileButton);
            Controls.Add(UgcFilesLabel);
            Controls.Add(UgcFileCountLabel);
            Controls.Add(UgcFileListBox);
            Controls.Add(FileWriteStatusLineLabel);
            Controls.Add(FileWriteStatusColumnLabel);
            Controls.Add(PreviousSongButton);
            Controls.Add(SusFileCountLabel);
            Controls.Add(CoverCountLabel);
            Controls.Add(SusFileListBox);
            Controls.Add(TotalSongCountLabel);
            Controls.Add(idxDivisorLabel);
            Controls.Add(CurrentSongIdxLabel);
            Controls.Add(CurrentSongMultiIndexCounterLabel);
            Controls.Add(NextSongButton);
            Controls.Add(AvailableCoversListBox);
            Controls.Add(applyForAllSusFilesButton);
            Controls.Add(ApplyToSelectedSusFileButton);
            Controls.Add(SusFilesLabel);
            Controls.Add(CoverArtPictureBox);
            Controls.Add(AvailableCoversLabel);
            Controls.Add(currentlyPlayingSongLabel);
            Controls.Add(NowPlayingColumnLabel);
            Controls.Add(CurrentSongDirectoryLabel);
            Controls.Add(CurrentSongDirectoryColumnLabel);
            Controls.Add(CurrentSongLabel);
            Controls.Add(CurrentSongColumnLabel);
            Controls.Add(SUSAudioSelectorMenuStrip);
            MainMenuStrip = SUSAudioSelectorMenuStrip;
            Name = "SUSAudioSelector";
            Text = "SUSAudioSelector";
            Load += SUSAudioSelectorForm_Load;
            SUSAudioSelectorMenuStrip.ResumeLayout(false);
            SUSAudioSelectorMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CoverArtPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CurrentSongColumnLabel;
        private Label CurrentSongLabel;
        private MenuStrip SUSAudioSelectorMenuStrip;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem LoadSingleToolStripMenuItem;
        private ToolStripMenuItem LoadBulkToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ToolStripMenuItem HowToUseToolStripMenuItem;
        private Label CurrentSongDirectoryColumnLabel;
        private Label CurrentSongDirectoryLabel;
        
        private Label NowPlayingColumnLabel;
        private Label currentlyPlayingSongLabel;
        private Label AvailableCoversLabel;
        private PictureBox CoverArtPictureBox;
        private Label SusFilesLabel;

        private Button ApplyToSelectedSusFileButton;
        private Button applyForAllSusFilesButton;
        private ListBox AvailableCoversListBox;
        private Button NextSongButton;
        private Label CurrentSongMultiIndexCounterLabel;
        private Label CurrentSongIdxLabel;
        private Label idxDivisorLabel;
        private Label TotalSongCountLabel;
        private ListBox SusFileListBox;
        private Label CoverCountLabel;
        private Label SusFileCountLabel;
        private Button PreviousSongButton;
        private Label FileWriteStatusColumnLabel;
        private Label FileWriteStatusLineLabel;
        private ListBox UgcFileListBox;
        private Label UgcFileCountLabel;
        private Label UgcFilesLabel;
        private Button ApplyToSelectedUgcFileButton;
        private Button ApplyToAllUgcFilesButton;
        private Button ApplyToAllChartsButton;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
    }
}
