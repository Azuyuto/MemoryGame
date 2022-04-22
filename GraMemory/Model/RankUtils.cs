using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GraMemory.Model
{
    public static class RankUtils
    {
        private readonly static string RankFile = @"rankList.csv";

        public static void AddNewEntry(Rank rank)
        {
            if (!File.Exists(RankFile))
            {
                using (var reader = File.CreateText(RankFile))
                {
                }
            }
            string csvRow = string.Format("{0};{1};{2}", rank.UserName, rank.Score, rank.TimeInSeconds);
            File.AppendAllLines(RankFile, new List<string> { csvRow });
        }

        public static List<Rank> GetRanks()
        {
            var list = new List<Rank>();
            if (File.Exists(RankFile))
            {
                using (var reader = new StreamReader(RankFile))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');
                        list.Add(new Rank()
                        {
                            UserName = values[0],
                            Score = int.Parse(values[1]),
                            TimeInSeconds = int.Parse(values[2])
                        });
                    }
                }
            }
            return list;
        }
    }
}
