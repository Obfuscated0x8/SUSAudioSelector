using SUSAudioSelector.Properties;
using System.Diagnostics;
using System.IO;

namespace SUSAudioSelector
{
    public partial class SUSAudioSelector : Form
    {
        FolderBrowserDialog browser = new FolderBrowserDialog();

        private int CurrentAudioFileIndex = 0;
        private int CurrentSongIndex = 0;
        private int CurrentSusFileIndex = 0;
        private int CurrentUgcFileIndex = 0;

        private List<Song> Songs = new List<Song>();
        private Song CurrentSong = new Song("");

        private string CurrentSusFilePath = "";
        private string CurrentUgcFilePath = "";

        public SUSAudioSelector()
        {
            InitializeComponent();
        }


        //////////////////////////////////////////
        /// Event Handlers
        //////////////////////////////////////////

        private void SUSAudioSelectorForm_Load(object sender, EventArgs e)
        {
            ClearSongMetadataFields();
            hideSongMetadataLabels();
        }

        // When Load Folder button is clicked from the menu strip
        // We want to load with the assumption that a single folder contains all relevant .sus files and either .wav, .mp3, .ogg, or .flac files
        // Note: I can maybe extend this later to support more audio formats but I don't have an exhaustive list top of head, so I'll just go with
        // what came to mind first.
        private void LoadSingleFolder_Click(object sender, EventArgs e)
        {
            // Load the dialog box result and parse the files in the selected folder
            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Because we are loading a single folder, we want to hide the multi-song controls
                hideMultiSongControls();

                // Calling a Single Folder Load ignores Songs, so we don't need to handle clearing it but we will anyway
                Songs.Clear();
                ClearSongMetadataFields();
                AddSong(browser.SelectedPath);
                LoadSong(CurrentSong);

            }
            ShowSongMetadataLabels();
        }

        // Load All Subfolders of a master folder as if they're individual songs
        private void LoadBulkFolders_Click(object sender, EventArgs e)
        {

            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Only enable the labels if the user has selected a folder with valid subfolders
                showMultiSongControls();

                // clear the old file metadata fields and update the list of subfolders
                ClearSongMetadataFields();
                Songs.Clear();

                foreach (string FilePath in Directory.GetDirectories(browser.SelectedPath).ToList())
                {
                    AddSong(FilePath);
                }

                CurrentSongIdxLabel.Text = CurrentSongIndex.ToString();
                TotalSongCountLabel.Text = Songs.Count.ToString();

                // Set the Current Song to the first song added to maintain order and load it
                CurrentSong = Songs[0];
                LoadSong(CurrentSong);

                // Show multi-song controls
                showMultiSongControls();
            }

        }

        // Responsible for ensuring all of the CurrentSong's data is loaded and ready to go
        // in a multi-song directory. TODO: Should I just take an index?
        private void LoadSong(Song song)
        {
            ClearSongMetadataFields();
            CurrentSong = song;
            SetSongMetadataFields();
        }

        private void AddSong(string Uri)
        {
            CurrentSong = new Song(Uri);
            Songs.Add(CurrentSong);
        }

        private void susFileListIdxChanged(object sender, EventArgs e)
        {
            // FIXME Figure out the indexes and prevent possible NRE
            CurrentSusFileIndex = SusFileListBox.SelectedIndex;
            string SusFileAtSelectedIndex = SusFileListBox.SelectedItem.ToString() ?? "";
            CurrentSusFilePath = GetSelectedSusFile(SusFileListBox.SelectedItem.ToString());
        }

        // Automatically load and play a cover when selected from the Covers list box.
        private void coverListIdxChanged(object sender, EventArgs e)
        {
            CurrentAudioFileIndex = AvailableCoversListBox.SelectedIndex;
            if (CurrentAudioFileIndex != -1)
            {
                if (AvailableCoversListBox.SelectedItem != null)
                {
                    playAudioFile(GetSelectedAudioFile(AvailableCoversListBox.SelectedItem.ToString()));
                }
            }

        }

        private void PreviousSongButtonClick(object sender, EventArgs e)
        {
            // To prevent weird crashes we clear the metadata fields before loading the next song
            ClearSongMetadataFields();

            if (CurrentSongIndex > 0)
            {
                CurrentSongIndex--;
                CurrentSong = Songs[CurrentSongIndex];
                LoadSong(CurrentSong);
                CurrentSongIdxLabel.Text = CurrentSongIndex.ToString();
            }
            else
            {
                // If we are at the first song, we should loop to the back of the song list
                CurrentSongIndex = Songs.Count - 1;
                CurrentSong = Songs[CurrentSongIndex];
                LoadSong(CurrentSong);
                CurrentSongIdxLabel.Text = CurrentSongIndex.ToString();
            }
        }

        private void NextSongButtonClick(object sender, EventArgs e)
        {
            // To prevent weird crashes we clear the metadata fields before loading the next song
            ClearSongMetadataFields();

            if (CurrentSongIndex < Songs.Count - 1)
            {
                CurrentSongIndex++;
                CurrentSong = Songs[CurrentSongIndex];
                LoadSong(CurrentSong);
                CurrentSongIdxLabel.Text = CurrentSongIndex.ToString();
            }
            else
            {
                // If we are at the last song, we should loop back to the first song
                CurrentSongIndex = 0;
                CurrentSong = Songs[CurrentSongIndex];
                LoadSong(CurrentSong);
                CurrentSongIdxLabel.Text = CurrentSongIndex.ToString();
            }
        }

        private void ApplyToAllUgcFilesButton_Click(object sender, EventArgs e)
        {
            foreach (string UgcFile in CurrentSong.UgcFiles)
            {
                try
                {
                    SetFileDebugWriteStatus(UgcFile);
                    ChartUtils.WriteAudioToSus(UgcFile, CurrentSong.SongName);
                }
                catch (Exception ex)
                {
                    SetFileWriteErrorStatus(UgcFile, ex);
                }
                SetFileWriteStatus(UgcFile);
            }
        }

        private void ApplyForAllSUSFilesButton_Click(object sender, EventArgs e)
        {
            foreach (string SusFile in CurrentSong.SusFiles)
            {
                try
                {
                    SetFileDebugWriteStatus(SusFile);
                    ChartUtils.WriteAudioToSus(SusFile, CurrentSong.SongName);
                }
                catch (Exception ex)
                {
                    SetFileWriteErrorStatus(SusFile, ex);
                }
                SetFileWriteStatus(SusFile);
            }
        }

        private void ApplyToSelectedUgcFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetFileDebugWriteStatus(CurrentUgcFilePath);
                ChartUtils.WriteAudioToSus(CurrentUgcFilePath, CurrentSong.SongName);
            }
            catch (Exception ex)
            {
                SetFileWriteErrorStatus(CurrentSusFilePath, ex);
            }
            SetFileWriteStatus(CurrentSusFilePath);
        }

        private void ApplyToSelectedSUSFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetFileDebugWriteStatus(CurrentSusFilePath);
                ChartUtils.WriteAudioToSus(CurrentSusFilePath, CurrentSong.SongName);
            }
            catch (Exception ex)
            {
                SetFileWriteErrorStatus(CurrentSusFilePath, ex);
            }
            SetFileWriteStatus(CurrentSusFilePath);
        }

        private void ApplyToAllCharts_Click(object sender, EventArgs e)
        {
            // First the .sus files.
            foreach (string SusFile in CurrentSong.SusFiles)
            {
                try
                {
                    SetFileDebugWriteStatus(SusFile);
                    ChartUtils.WriteAudioToSus(SusFile, CurrentSong.SongName);
                }
                catch (Exception ex)
                {
                    SetFileWriteErrorStatus(SusFile, ex);
                }
                SetFileWriteStatus(SusFile);
            }

            // Then the .ugc files.
            foreach (string UgcFile in CurrentSong.UgcFiles)
            {
                try
                {
                    SetFileDebugWriteStatus(UgcFile);
                    ChartUtils.WriteAudioToSus(UgcFile, CurrentSong.SongName);
                }
                catch (Exception ex)
                {
                    SetFileWriteErrorStatus(UgcFile, ex);
                }
                SetFileWriteStatus(UgcFile);
            }
        }

        private void ShowHowToUse_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This program is designed to help you map audio files to .sus files for use in games that support it (such as UMIGURI)." + Environment.NewLine +
                Environment.NewLine +
                "To use this program, you must first load a folder that contains the .sus files and the audio files you wish to map to." + Environment.NewLine +
                "You can accomplish this by clicking 'File' -> 'Load Folder' and selecting the folder that contains the .sus files and audio files." + Environment.NewLine +
                "Once you have loaded the folder, you can select the .sus file you wish to map to by clicking on the .sus file in the list." + Environment.NewLine +
                "You can then click on a cover in 'Available Covers' in order to select it and then play it with the media player." + Environment.NewLine +
                "Once you have selected the audio file you wish to map to, you can click 'Apply to Selected SUS File' or 'Apply to All SUS Files' to map the audio file to the .sus file(s)." + Environment.NewLine +
                Environment.NewLine +
                "You can also click 'File' -> 'Load Bulk Folders' to load multiple folders at once." + Environment.NewLine +
                "This will cause new buttons to appear that will allow you to cycle through the songs." + Environment.NewLine
            );
        }



        //////////////////////////////////////////
        /// Helper Functions
        //////////////////////////////////////////

        // Sets all of the related fields for a given song
        private void SetSongMetadataFields()
        {
            // Stop any playing audio
            mediaPlayer.Ctlcontrols.stop();

            // Set the internal metadata
            CoverCountLabel.Text = CurrentSong.AudioFiles.Count.ToString();
            SusFileCountLabel.Text = CurrentSong.SusFiles.Count.ToString();
            UgcFileCountLabel.Text = CurrentSong.UgcFiles.Count.ToString();

            //  Set the relevant labels and tables
            CurrentSongLabel.Text = CurrentSong.SongName;
            CurrentSongDirectoryLabel.Text = CurrentSong.SongUri;

            // Load Assets for the current song
            LoadJacket();
            LoadAudioFileList();
            LoadSusFileList();
            LoadUgcFileList();
            SetLoadStatus(CurrentSong.SongUri);

            // Finally, show these file metadata fields
            ShowSongMetadataLabels();
        }

        // Get full path of the selected .sus file
        private string GetSelectedSusFile(string susFileName)
        {
            return CurrentSong.SusFiles.Single(filename => Path.GetFileName(filename) == susFileName);
        }

        private string GetSelectedUgcFile(string ugcFileName)
        {
            return CurrentSong.UgcFiles.Single(filename => Path.GetFileName(filename) == ugcFileName);
        }

        private string GetSelectedAudioFile(string audioFileName)
        {
            return CurrentSong.AudioFiles.Single(filename => Path.GetFileName(filename) == audioFileName);
        }

        private void LoadAudioFileList()
        {
            string AudioFileName = "";
            mediaPlayer.currentPlaylist = mediaPlayer.newPlaylist("AudioPlaylist", "");

            foreach (string AudioFile in CurrentSong.AudioFiles)
            {
                mediaPlayer.currentPlaylist.appendItem(mediaPlayer.newMedia(AudioFile));
                AudioFileName = Path.GetFileName(AudioFile);
                AvailableCoversListBox.Items.Add(AudioFileName);
            }

            CoverCountLabel.Text = CurrentSong.AudioFiles.Count.ToString();
            if (CurrentSong.AudioFiles.Count > 0)
            {
                AvailableCoversListBox.SelectedIndex = CurrentAudioFileIndex;
            }
            else
            {
                MessageBox.Show(
                    "No audio files found in the selected folder." + Environment.NewLine +
                    "Valid File Extensions: " + CurrentSong.AudioFileExtensions.ToString() + "."
                );
            }
        }
        private void LoadUgcFileList()
        {
            string UgcFileName = "";

            foreach (string UgcFile in CurrentSong.UgcFiles)
            {
                UgcFileName = Path.GetFileName(UgcFile);
                UgcFileListBox.Items.Add(UgcFileName);
            }
        }

        private void LoadSusFileList()
        {
            string susFileName = "";

            // Add each sus file to the list view
            foreach (string susFile in CurrentSong.SusFiles)
            {
                susFileName = Path.GetFileName(susFile);
                SusFileListBox.Items.Add(susFileName);
            }

            SusFileCountLabel.Text = CurrentSong.SusFiles.Count.ToString();
            if (CurrentSong.SusFiles.Count > 0)
            {
                SusFileListBox.SelectedIndex = CurrentSusFileIndex;
            }
            else
            {
                MessageBox.Show("No .sus files found in the selected folder.");
            }
        }

        private void LoadJacket()
        {
            // Load the current jacket image for the selected song
            if (CurrentSong.JacketFile != "" && File.Exists(CurrentSong.JacketFile))
            {
                CoverArtPictureBox.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(CurrentSong.JacketFile)));
            }
            else
            {
                CoverArtPictureBox.Image = Properties.Resources.ShittyNoAudioSelected;
            }
        }

        private void playAudioFile(string url)
        {
            mediaPlayer.URL = url;
            mediaPlayer.Ctlcontrols.play();
        }

        private void ClearSongMetadataFields()
        {
            // Stop any playing audio
            mediaPlayer.Ctlcontrols.stop();

            // Clear the list of audio files and sus files
            AvailableCoversListBox.Items.Clear();
            SusFileListBox.Items.Clear();
            UgcFileListBox.Items.Clear();

            CurrentAudioFileIndex = 0;
            CurrentSusFileIndex = 0;

            // Reset label colors
            FileWriteStatusLineLabel.ForeColor = Color.Black;
        }

        // Show the song metadata labels when a song is loaded
        private void ShowSongMetadataLabels()
        {
            List<Label> labels = new List<Label> {
                CoverCountLabel,
                CurrentSongDirectoryLabel,
                CurrentSongLabel,
                FileWriteStatusLineLabel,
                SusFileCountLabel,
                UgcFileCountLabel,
                
            };

            foreach (Label label in labels)
            {
                label.Visible = true;
            }
        }

        // Hide the song metadata labels when no song is loaded
        private void hideSongMetadataLabels()
        {
            List<Label> labels = new List<Label> {
                CoverCountLabel,
                CurrentSongDirectoryLabel,
                CurrentSongLabel,
                FileWriteStatusLineLabel,
                SusFileCountLabel,
                UgcFileCountLabel
                
            };

            foreach (Label label in labels)
            {
                label.Text = "";
                label.Visible = false;
            }
        }

        // Show the multi-song controls when the bulk folder load is used
        private void showMultiSongControls()
        {
            NextSongButton.Visible = true;
            PreviousSongButton.Visible = true;
            CurrentSongIdxLabel.Visible = true;
            CurrentSongMultiIndexCounterLabel.Visible = true;
            TotalSongCountLabel.Visible = true;
            idxDivisorLabel.Visible = true;
        }

        // Hide the multi-song controls when the bulk folder load is not used
        private void hideMultiSongControls()
        {
            NextSongButton.Visible = false;
            PreviousSongButton.Visible = false;
            CurrentSongIdxLabel.Visible = false;
            CurrentSongMultiIndexCounterLabel.Visible = false;
            TotalSongCountLabel.Visible = false;
            idxDivisorLabel.Visible = false;
        }

        private void SetLoadStatus(string uri)
        {
            FileWriteStatusLineLabel.ForeColor = Color.Green;
            FileWriteStatusLineLabel.Text = "Loaded: " + uri;
        }

        private void SetFileDebugWriteStatus(string uri)
        {
            FileWriteStatusLineLabel.ForeColor = Color.Blue;
            FileWriteStatusLineLabel.Text = "Attempting to write to: " + uri;
        }

        private void SetFileWriteStatus(string uri)
        {
            FileWriteStatusLineLabel.ForeColor = Color.Green;
            FileWriteStatusLineLabel.Text = "Wrote to: " + uri;
        }

        private void SetFileWriteErrorStatus(string uri, Exception ex)
        {
            FileWriteStatusLineLabel.ForeColor = Color.Red;
            FileWriteStatusLineLabel.Text = "Error writing to: " + uri + Environment.NewLine +
                                            "Exception: " + ex;
        }
    }  
}
