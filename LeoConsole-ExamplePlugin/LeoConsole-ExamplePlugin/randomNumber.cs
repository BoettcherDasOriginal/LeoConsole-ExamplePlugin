using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin
{
    public class ConsoleData : IData
    {
        public static User _User;
        public User User { get { return _User; } set { _User = value; } }
        public static string _SavePath;
        public string SavePath { get { return _SavePath; } set { _SavePath = value; } }
        public static string _DownloadPath;
        public string DownloadPath { get { return _DownloadPath; } set { _DownloadPath = value; } }
        public static string _Version;
        public string Version { get { return _Version; } set { _Version = value; } }
    }

    public class randomNumber : ICommand
    {
        Random rand = new Random();

        public string Name { get { return "randomNumber"; } }
        public string Description { get { return "generiert einen zuffälligen Code"; } }
        public Action CommandFunktion { get { return () => Command(); } }
        private string[] _InputProperties;
        public string[] InputProperties { get { return _InputProperties; } set { _InputProperties = value; } }
        public void Command()
        {
            try
            {
                string mitText = InputProperties[1];
                int length = Convert.ToInt32(InputProperties[2]);

                int Buchstabe;
                int textOrNumber;

                if (_InputProperties != null)
                {
                    Console.WriteLine("Neuer Code: ");

                    for (int i = 0; i < length; i++)
                    {
                        if (mitText == "true")
                        {
                            textOrNumber = rand.Next(0, 12);

                            if (textOrNumber >= 10)
                            {
                                Buchstabe = rand.Next(1, 26);

                                switch (Buchstabe)
                                {
                                    case 1:
                                        Console.Write("A");
                                        break;

                                    case 2:
                                        Console.Write("B");
                                        break;

                                    case 3:
                                        Console.Write("C");
                                        break;

                                    case 4:
                                        Console.Write("D");
                                        break;

                                    case 5:
                                        Console.Write("E");
                                        break;

                                    case 6:
                                        Console.Write("F");
                                        break;

                                    case 7:
                                        Console.Write("G");
                                        break;

                                    case 8:
                                        Console.Write("H");
                                        break;

                                    case 9:
                                        Console.Write("I");
                                        break;

                                    case 10:
                                        Console.Write("J");
                                        break;

                                    case 11:
                                        Console.Write("K");
                                        break;

                                    case 12:
                                        Console.Write("L");
                                        break;

                                    case 13:
                                        Console.Write("M");
                                        break;

                                    case 14:
                                        Console.Write("N");
                                        break;

                                    case 15:
                                        Console.Write("O");
                                        break;

                                    case 16:
                                        Console.Write("P");
                                        break;

                                    case 17:
                                        Console.Write("Q");
                                        break;

                                    case 18:
                                        Console.Write("R");
                                        break;

                                    case 19:
                                        Console.Write("S");
                                        break;

                                    case 20:
                                        Console.Write("T");
                                        break;

                                    case 21:
                                        Console.Write("U");
                                        break;

                                    case 22:
                                        Console.Write("V");
                                        break;

                                    case 23:
                                        Console.Write("W");
                                        break;

                                    case 24:
                                        Console.Write("X");
                                        break;

                                    case 25:
                                        Console.Write("Y");
                                        break;

                                    case 26:
                                        Console.Write("Z");
                                        break;
                                }
                            }
                            else if (textOrNumber <= 9)
                            {
                                Console.Write(rand.Next(0, 9).ToString());
                            }
                        }
                        else
                        {
                            Console.Write(rand.Next(0, 9).ToString());
                        }
                    }

                    Console.WriteLine("");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message + "\n");
            }
        }
    }
}
