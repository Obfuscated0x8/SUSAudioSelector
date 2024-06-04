using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SUSAudioSelector
{

    // Keep track of information for a particular Song. The "Song" in this case is the DIRECTORY containing all relevant assets.
    internal class Song
    {
        public List<string> AudioFiles = new List<string>();
        public List<string> SusFiles = new List<string>();
        public List<string> UgcFiles = new List<string>();

        public string JacketFile = "";
        public string SongName = "";
        public string SongUri = "";

        public List<string> AudioFileExtensions = new List<string> { ".wav", ".mp3", ".ogg", ".flac" };
        public List<string> JacketFileExtensions = new List<string> { ".png", ".jpg", ".jpeg", ".gif" };


        public Song(string uri)
        {
            SongUri = uri;
            SongName = Path.GetFileName(uri);
            if (!string.IsNullOrEmpty(SongUri))
            {
                GetAudioFiles();
                GetSusFiles();
                GetUgcFiles();
                GetJacketFile();
            }
        }

        private void GetAudioFiles()
        {
            AudioFiles = Directory.GetFiles(SongUri).Where(file => AudioFileExtensions.Any(file.EndsWith)).ToList();
        }

        private void GetSusFiles()
        {
            // The .sus files are Sliding Universal Scores
            // SUS v2.7 spec: https://gist.github.com/waki285/dafa254a9de56ba43d177ae0913d4263
            SusFiles = Directory.GetFiles(SongUri).Where(file => file.EndsWith(".sus")).ToList();
        }

        private void GetUgcFiles()
        {
            // The .ugc files are UMIGURIs specific song format.
            UgcFiles = Directory.GetFiles(SongUri).Where(file => file.EndsWith(".ugc")).ToList();
        }

        private void GetJacketFile()
        {
            // The "Jacket" file is simply the "album art" of the song. This method will only look for the first instance.
            JacketFile = Directory.GetFiles(SongUri).Where(file => JacketFileExtensions.Any(file.EndsWith)).FirstOrDefault("");
        }
    }
}
