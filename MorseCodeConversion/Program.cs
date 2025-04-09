using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace MorseCodeConversion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Initialize the Morse code dictionary
            //String[] morseCodeDictionary = new String[36];
            //morseCodeDictionary = File.ReadAllText();
        }

        public static string CleanWhiteSpaces(string inputTxt) 
        {
            string outputTxt;

            // Remove all non-alphanumeric characters
            inputTxt
                = inputTxt
                    .Replace("\n", "");


            outputTxt = inputTxt;
            return outputTxt;
        }

        public static string CleanDiacritics(string inputTxt)
        {
            string outputTxt;
            // Remove all non-alphanumeric characters
            inputTxt
                = inputTxt
                    .ToLower()
                    .Replace("\r", "")
                    .Replace("\n", " ")
                    .Replace("á", "a")
                    .Replace("ä", "a")
                    .Replace("é", "e")
                    .Replace("í", "i")
                    .Replace("ó", "o")
                    .Replace("ô", "o")
                    .Replace("ú", "u")
                    .Replace("ñ", "n")
                    .Replace("ľ", "l")
                    .Replace("č", "c")
                    .Replace("š", "s")
                    .Replace("ž", "z")
                    .Replace("ť", "t")
                    .Replace("ý", "y")
                    .Replace("ď", "d")
                    .ToUpper();
            outputTxt = inputTxt;
            return outputTxt;
        }



        public static string Txt2Morse(string inStr)
        {
            //string[] MorsePairsTab = File.ReadAllLines("MorsePairs.txt");
 /*           string[] MorsePairsTab = { "A", "·− ", "B", "−··· ", "C", "−·−· ""D", "−·· ", "E", "· ", "F", "··−· " "G", "−−· ","H", "···· ","I", "·· ","J", "·−−− ","K", "−·− ","L", "·−·· ","M", "−− ","N", "−· ","O", "−−− ","P", "·−−· ","Q", "−−·− ","R", "·−· ","S", "··· ","T", "− ","U", "··− ","V", "···− ","W", "·−− ","X", "−··− ","Y", "−·−− ","Z", "−−·· ","", " / ","0", "−−−−− ","1", "·−−−− ","2", "··−−− ","3", "···−− ","4", "····− ","5", "····· ","6", "−···· ","7", "−−··· ","8", "−−−·· ","9", "−−−−· ",".", "·−·−·− ",",", "−−··−− ","?", "··−−·· ","!", "−·−·−− ","'", "·−−−−· ","\"", "·−··−· ","(", "−·−−· ",")", "−·−−·− ","/", "−··−· ",":", "−−−··· ",";", "−·−·−· ","=", "−···− ","+", "·−·−· ","-", "−····− ","@", "·−−·−· "};
            int lenght = MorsePairsTab.Length;
 
            string[,] strMorseCode = new string[lenght, 2];
 */
            string outStr = "";
/*
            int i = 0;
            foreach (var item in MorsePairsTab)
            {
                strMorseCode[i, 0] = item.Split('", "')[0];
                strMorseCode[i, 1] = item.Split('", "')[1];
            }
*/
  //          int indexOfChar;

                var morseCodeDict = new Dictionary<string, string>
                {
                    { "A", "·− " },
                    { "B", "−··· " },
                    { "C", "−·−· " },
                    { "D", "−·· " },
                    { "E", "· " },
                    { "F", "··−· " },
                    { "G", "−−· " },
                    { "H", "···· " },
                    { "I", "·· " },
                    { "J", "·−−− " },
                    { "K", "−·− " },
                    { "L", "·−·· " },
                    { "M", "−− " },
                    { "N", "−· " },
                    { "O", "−−− " },
                    { "P", "·−−· " },
                    { "Q", "−−·− " },
                    { "R", "·−· " },
                    { "S", "··· " },
                    { "T", "− " },
                    { "U", "··− " },
                    { "V", "···− " },
                    { "W", "·−− " },
                    { "X", "−··− " },
                    { "Y", "−·−− " },
                    { "Z", "−−·· " },
                    { " ", " / " },
                    { "0", "−−−−− " },
                    { "1", "·−−−− " },
                    { "2", "··−−− " },
                    { "3", "···−− " },
                    { "4", "····− " },
                    { "5", "····· " },
                    { "6", "−···· " },
                    { "7", "−−··· " },
                    { "8", "−−−·· " },
                    { "9", "−−−−· " },
                    { ".", "·−·−·− " },
                    { ",", "−−··−− " },
                    { "?", "··−−·· " },
                    { "!", "−·−·−− " },
                    { "'", "·−−−−· " },
                    { "\"", "·−··−· " },
                    { "(", "−·−−· " },
                    { ")", "−·−−·− " },
                    { "/", "−··−· " },
                    { ":", "−−−··· " },
                    { ";", "−·−·−· " },
                    { "=", "−···− " },
                    { "+", "·−·−· " },
                    { "-", "−····− " },
                    { "@", "·−−·−· " } 
                };
            

                var morseCodeDictReverse = new Dictionary<string, string>();
            foreach (var kvp in morseCodeDict)
            {
                morseCodeDictReverse[kvp.Value.Trim()] = kvp.Key;
            }

            foreach (char c in inStr)
                {
                    if (morseCodeDict.TryGetValue(c.ToString(), out var morse))
                        outStr += morse;
                }
                //indexOfChar = Array.IndexOf(strMorseCode, symbol.ToString());
                //outStr = outStr + strMorseCode[indexOfChar, 1];
            

            return outStr;
        }

    }
}
