using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace XOGame_Model
{
    public class Settings
    {
        public string Path = "d:/stats_default.txt";
        public int Size = 10;

        public void PathDefault()
        {
            Path = "d:/stats_default.txt";
        }
        public void SizeDefault()
        {
            Size = 10;
        }
        public void SetSize(int size)
        {
            Size = size;
        }
        public void SetPath(string path)
        {
            Path = path;
        }
        public string[] GetRecords()
        {
            string[] file = File.ReadAllLines(Path);
            return file;
        }

        public bool ValidateFile(string path)
        {
            if (!File.Exists(path)) return false;
            try
            {
                string[] file = File.ReadAllLines(path);
                foreach (string line in file)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length != 2 || string.IsNullOrWhiteSpace(parts[0]) || !int.TryParse(parts[1], out int score))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ValidateSize(string sizeString)
        {
            Match match = Regex.Match(sizeString, @"^(\d+)x\1$");
            if (!match.Success) return false;

            int size = int.Parse(match.Groups[1].Value);
            return size >= 10 && size <= 20;
        }
    }
}
