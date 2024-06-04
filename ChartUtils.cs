using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUSAudioSelector
{
    // This function is used to open a given sus file path and parse the lines into a list of strings
    public static class ChartUtils
    {
        public static void OpenFile(string path, out List<string> lines)
        {
            lines = new List<string>();
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(path))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        // Check File for an already set WAVE file
        public static bool FileHasWaveSet(string SusFilePath)
        {
            List<string> lines;
            OpenFile(SusFilePath, out lines);
            foreach (string line in lines)
            {
                if (line == "#WAVE \"\"")
                {
                    // Line contains the default empty WAVE file path
                    return false;
                }
            }
            // Line does not contain the default empty WAVE file path
            // This means _something_ is set
            return true;
        }

        // This function is used to edit the line containing "WAVE" in the given sus file to contain the new audio file path
        public static void WriteAudioToSus(string SusFilePath, string NewAudioFilename)
        {
            List<string> Lines;
            OpenFile(SusFilePath, out Lines);
            foreach (var Line in Lines.Select((Text,Index) => (Text, Index)))
            {
                if (Line.Text.StartsWith("#WAVE"))
                {
                    Lines[Line.Index] = "#WAVE " + "\"" + NewAudioFilename + "\"";
                    break;
                }
            }
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(SusFilePath))
                {
                    foreach (string line in Lines)
                    {
                        file.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be written:");
                Console.WriteLine(e.Message);
            }
        }

        public static void WriteAudioToUgc(string UgcFilePath, string NewAudioFilename)
        {
            List<string> Lines;
            OpenFile(UgcFilePath, out Lines);
            foreach (var Line in Lines.Select((Text, Index) => (Index, Text )))
            {
                // We need the @BGM line to `@BGM <music_file>`
                // @BGMPRV denotes the menu preview of the files used, so thats not the line we want.
                if (Line.Text.StartsWith("@BGM") && !Line.Text.Contains("BGMPRV"))
                {
                    Lines[Line.Index] = "@BGM\t" + NewAudioFilename;
                    break;
                }
            }
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(UgcFilePath))
                {
                    foreach (string Line in Lines)
                    {
                        file.WriteLine(Line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be written:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
