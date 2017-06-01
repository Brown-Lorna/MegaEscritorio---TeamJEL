using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace L3MegaEscritorio
{
        // CONTROLLER
        class DeskQuote
        {
            public static void WriteQuote(int width, int depth, int numOfDrawers, DesktopMaterial material, int rushOrderDays, int deskPriceQuote)
            {
                string path;
                path =
                @"~\L3MegaEscritorio\Resources\deskquotes.txt";

                try
                {
                    StreamReader reader = new StreamReader(path);
                    List<string> fileStrings = new List<string>();

                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();
                        fileStrings.Add(line);
                    }
                    reader.Close();

                    string writeWidth = System.Convert.ToString(width);
                    string writeDepth = System.Convert.ToString(depth);
                    string writeNumOfDrawers = System.Convert.ToString(numOfDrawers);
                    string writeRushOrderDays = System.Convert.ToString(rushOrderDays);
                    string writeDeskPriceQuote = System.Convert.ToString(deskPriceQuote);

                    DateTime now = DateTime.Now;

                    string writeQuoteDate = now.ToString("d MMM yyyy");
                    string quoteLine = material + "," + writeWidth + "," + writeDepth + "," + writeNumOfDrawers + "," + writeRushOrderDays + "," + writeDeskPriceQuote + "," + writeQuoteDate;

                    fileStrings.Add(quoteLine);

                    StreamWriter writer;
                    writer = new StreamWriter(path);

                    foreach (string line in fileStrings)
                    {
                        writer.WriteLine(line);
                    }
                    writer.Close();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            public static int MakeQuote(int x, int y, int z, int i, int j)
            {
                int quote = 0;

                try
                {
                    quote = x + y + z + i + j;
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return quote;
            }

            public static string BuildQuoteSheet()
            {
                string text = "";

                try
                {
                    string path;
                    path = @"~\L3MegaEscritorio\Resources\deskquotes.txt";

                    StreamReader reader = new StreamReader(path);

                    ArrayList quoteList = new ArrayList();

                    int i = -1;
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();
                        i++;
                        quoteList.Add(line);
                    }
                    reader.Close();

                    text = "Num\tMaterial\tWidth\tDepth\tDrawers\tOrder\tQuote\tDate" + Environment.NewLine;
                    int pcounter = 0;
                    foreach (string row in quoteList)
                    {
                        string[] results = row.Split(',');
                        string pcounterString;
                        string paramString = "";

                        pcounterString = pcounter.ToString() + ":\t";

                        foreach (string param in results)
                        {
                            paramString += param + "\t";
                        }

                        text += pcounterString + paramString + Environment.NewLine;
                        pcounter++;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return text;
            }

            public static string SearchQuoteSheet(string materialName)
            {
                string text = "";

                try
                {
                    string path;
                    path = @"~\L3MegaEscritorio\Resources\deskquotes.txt";

                    StreamReader reader = new StreamReader(path);

                    ArrayList quoteList = new ArrayList();

                    int i = -1;

                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();
                        i++;

                        if (line.StartsWith(materialName))
                        {
                            quoteList.Add(line);
                        }
                    }
                    reader.Close();


                    text = "Material\tWidth\tDepth\tDrawers\tOrder\tQuote\tDate" + Environment.NewLine;
                    int pcounter = 0;
                    foreach (string row in quoteList)
                    {
                        string[] results = row.Split(',');
                        string paramString = "";
                        foreach (string param in results)
                        {
                            paramString += param + "\t";
                        }

                        text += paramString + Environment.NewLine;
                        pcounter++;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return text;
            }

            public static void DeleteQuote(int quoteNumber)
            {
                string path;
                path = @"~\L3MegaEscritorio\Resources\deskquotes.txt";

                try
                {
                    StreamReader reader = new StreamReader(path);

                    ArrayList quoteList = new ArrayList();

                    int i = -1;
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();
                        i++;

                        if (i != quoteNumber)
                        {
                            quoteList.Add(line);
                        }
                    }
                    reader.Close();

                    StreamWriter writer = new StreamWriter(path);

                    foreach (string row in quoteList)
                    {
                        writer.WriteLine(row);
                    }
                    writer.Close();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            public static int CountQuotes()
            {
                int i = 0;

                try
                {
                    string path;
                    path = @"~\L3MegaEscritorio\Resources\deskquotes.txt";

                    StreamReader reader = new StreamReader(path);

                    i = -1;

                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();
                        i++;
                    }
                    reader.Close();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return i;
            }
        }
}

