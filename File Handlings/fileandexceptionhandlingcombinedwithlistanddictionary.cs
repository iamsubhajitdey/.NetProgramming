// File and Exception Handling combined with List and Dictionary.
// Carry out the following operations:
// 1. Two files Players.txt and JerseyDetails.txt will be provided.
// • Players: list of player names selected in final squad.
// • JerseyDetails: list of (player name, jersey number) details.
// 2. Read all contents of Players.txt into a List named Players and throw exception for any numeric data.
// 3. Read all contents of JerseyDetails.txt into a Dictionary called JerseyDetails and make sure that any exception in data formatting errors in the file is caught in your code.
// 4. Create a new Dictionary called FinalSquad and this should only contain those players that have matching names in Players and JerseyDetails.
// 5. Output the contents of FinalSquad to a new file called FinalSquad.txt in the same format as JerseyDetails.txt. This output should be sorted by value of jersey number.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace fileshandling
{
    public class Program
    {
        public List<String> Players;
        public Dictionary<String, int> JerseyDetails;

        public void GetPlayersDetails(String playername)
        {
            foreach (char c in playername)
            {
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                {
                    throw new InvalidOperationException("Input data of player name is invalid.");
                }
            }

            Players.Add(playername);
        }

        public void GetJerseyDetails(String playername, int jerseynumber)
        {
            try
            {
                foreach (char c in playername)
                {
                    if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                    {
                        throw new InvalidOperationException("Input data of player name is invalid.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An Exception has occurred : {0}", e.Message);
                return;
            }

            JerseyDetails.Add(playername, jerseynumber);

        }

        public static void Main(string[] args)

        {
            String path1 = @"Players.txt";
            String path2 = @"JerseyDetails.txt";

            String[] lines1;
            String[] lines2;

            lines1 = File.ReadAllLines(path1);
            lines2 = File.ReadAllLines(path2);

            Program p = new Program();

            /*Read all contents of Players.txt into a List named Players and throw exception for any numeric data.*/

            p.Players = new List<String>();

            for (int i = 0; i < lines1.Length; i++)
            {
                p.GetPlayersDetails(lines1[i]);
            }

            /* Read all contents of JerseyDetails.txt into a Dictionary called JerseyDetails and make 
               sure that any exception in data formatting errors in the file is caught in your code.*/

            p.JerseyDetails = new Dictionary<string, int>();

            for (int k = 0; k < lines2.Length; k++)
            {
                try
                {
                    String[] spearator = { "," };
                    String[] jerseydetailsList = lines2[k].Split(",");

                    string playername = jerseydetailsList[0];
                    int jerseynumber = Convert.ToInt32(jerseydetailsList[1]);
                    p.GetJerseyDetails(playername, jerseynumber);

                }
                catch (Exception e)
                {
                    Console.WriteLine("An Exception has occurred : {0}", e.Message);
                }

            }

            /* Create a new Dictionary called FinalSquad and this should only contain 
               those players that have matching names in Players and JerseyDetails.*/

            Dictionary<string, int> FinalSquad = new Dictionary<string, int>();

            foreach (var player in p.JerseyDetails)
            {
                string key = player.Key;
                int value = player.Value;

                if (p.Players.Contains(key))
                {
                    FinalSquad.Add(key, value);
                }

            }

            /* Output the contents of FinalSquad to a new file called FinalSquad.txt in the same 
               format as JerseyDetails.txt. This output should be sorted by value of jersey number.*/

            String FileName = @"FinalSquad.txt";
            {
                using(StreamWriter filestr = new StreamWriter(FileName))
                {
                    foreach (KeyValuePair<string, int> item in FinalSquad.OrderBy(i => i.Value))
                    {
                        filestr.WriteLine(item.Key + "," + item.Value);
                    }
                }
            }
        }
    }
}