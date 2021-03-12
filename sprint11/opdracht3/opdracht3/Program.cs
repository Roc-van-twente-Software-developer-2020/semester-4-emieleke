using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {

            int beginningPromptChoise = 0;

            string[] dateArray = {
                "1: Voeg wekker toe",
                "2: Verwijder wekker",
                "3: Pas wekker aan",
                "4: Zet wekker aan",
                "5: Zet wekker uit"
            };

            foreach (string strings in dateArray)
            {
                Console.WriteLine(strings);
            }

            Console.WriteLine();
            Console.Write("Maak een keuze: ");
            beginningPromptChoise = Convert.ToInt32(Console.ReadLine());

            switch (beginningPromptChoise)
            {
                case 1:
                    string alarmConfigString = ChoiseToText();
                    stringToTxtFile(alarmConfigString);
                    break;

                case 2:
                    Console.Write("t");
                    break;

                case 3:
                    Console.Write("r");
                    break;

                case 4:
                    Console.Write("e");
                    break;

                case 5:
                    Console.Write("w");
                    break;

                case 6:
                    Console.Write("q");
                    break;

            }

            Console.ReadLine();

        }


        public static string DatePrompt()
        {

            string[] dateArray = new string[3];
            string dateString = "";


            Console.Clear();

            Console.WriteLine("Selecteer welke dagen uw alarm wilt gebruiken.");
            Console.WriteLine("1: Specefieke datum");
            Console.WriteLine("2: Specefieke dag");
            Console.WriteLine("3: Alle werkdagen");
            Console.WriteLine("4: Alle weekend dagen");


            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:

                    Console.Write("Voer het jaar in: ");
                    dateArray[0] = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Voer de maand in: ");
                    dateArray[1] = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Voer de dag in: ");
                    dateArray[2] = Console.ReadLine();
                    Console.WriteLine();

                    dateString = dateArray[0] + "-" + dateArray[1] + "-" + dateArray[2];

                    break;

                case 2:

                    Console.WriteLine("1: Maandag");

                    Console.WriteLine("2: Dinsdag");

                    Console.WriteLine("3: Woensdag");

                    Console.WriteLine("4: Donderdag");

                    Console.WriteLine("5: Vrijdag");

                    Console.Write("Selecteer welke dag: ");

                    dateString = Console.ReadLine();

                    break;

                case 3:
                    dateString = "weekdays";
                    break;
                case 4:
                    dateString = "months";
                    break;
            }

            return dateString;

        }


        public static string TimePrompt()
        {

            Console.Clear();
            Console.Write("Typ het gewenste tijdstip in --:-- : ");
            string timeStamp = Console.ReadLine();

            return timeStamp;
        }



        public static string AudioPrompt()
        {
            Console.Clear();

            string audioName = "";

            Console.WriteLine("1: hugh_mungus.wav");
            Console.WriteLine("2: im_gay_idubzz.wav");
            Console.WriteLine("3: jeroen.wav");
            Console.WriteLine("4: niet_toeteren.wav");

            Console.Write("Selecteer welke audio bestand u wilt gebruiken: ");
            int audioChoise = Convert.ToInt32(Console.ReadLine());

            switch (audioChoise)
            {

                case 1:
                    audioName = "hugh_mungus.wav";
                    break;

                case 2:
                    audioName = "im_gay_idubzz.wav";
                    break;

                case 3:
                    audioName = "jeroen.wav";
                    break;

                case 4:
                    audioName = "niet_toeteren.wav";
                    break;

            }

            return audioName;

        }
        public static string DescriptionPrompt()
        {
            Console.Clear();
            Console.Write("Typ een gewenste beschrijving in: ");
            return Console.ReadLine();
        }

        public static string ChoiseToText()
        {
            // Sets config info into array
            string[] lines = new string[4];

            lines[0] = DatePrompt();
            lines[1] = TimePrompt();
            lines[2] = AudioPrompt();
            lines[3] = DescriptionPrompt();

            // Puts every array element into a single string with seperation.
            string alarmConfig = "";

            foreach (string line in lines)
            {

                alarmConfig += line + ";";

            }

            alarmConfig = alarmConfig.Remove(alarmConfig.Length - 1, 1);

            return alarmConfig;
        }

        static void stringToTxtFile(string alarmString)
        {
            string TextFileURL = Global.mediaDirectory + @"\media" + @"\wekkers.txt";

            // Try to create the directory.
            try
            {
                DirectoryInfo di = Directory.CreateDirectory(Global.mediaDirectory + @"\media");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }

            // Checks if File Exists
            if (!File.Exists(Global.mediaDirectory))
            {
                using StreamWriter file = File.CreateText(TextFileURL);
    
            }
            File.AppendAllText(TextFileURL, alarmString + Environment.NewLine + "\r\n");
        }
        void RemoveLinesFromText()
        {
            int counter = 0;
            string line;

            StreamReader file = new StreamReader(@"c:\test.txt");

            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
            }
            file.Close();
        }
    }
}
