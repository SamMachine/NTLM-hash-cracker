using System;
using System.Diagnostics;
using System.Text;

namespace Brute_Force
{
    class Program
    {
        static void Main(string[] args)
        {
            string charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Console.WriteLine("Charset is " + charset.Length + " characters long");
            Console.Write("Please enter the NTLM hash you want to crack: ");
            hash crack = new hash(Console.ReadLine().ToUpper());
            Console.Write("Please enter the estimated length of your password: ");
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            String chk = "";
            int len = Convert.ToInt32(Console.ReadLine());
            if (crack.ntlmHash.Equals("31d6cfe0d16ae931b73c59d7e0c089c0", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine();
                Console.WriteLine("Password Found! Your password is empty");
                crack.password = "";
                System.IO.File.WriteAllText(@"X:\Files\Programming\C# Programs\Brute_Force\Brute_Force\resource\BruteForce.txt", crack.password);
                Console.WriteLine();
                Console.Write("Press any key to exit!");
                Console.ReadKey();
                System.Environment.Exit(1);
            }
            if (len <= 6)
            {
                for (int c = 0; c < charset.Length; c++)
                {
                    chk = charset[c].ToString();
                    crack.time = sw.Elapsed;
                    crack.isMatch(chk);
                }

                for (int q = 0; q < charset.Length; q++)
                {
                    for (int c = 0; c < charset.Length; c++)
                    {
                        chk = charset[q].ToString() + charset[c].ToString();
                        crack.time = sw.Elapsed;
                        crack.isMatch(chk);
                    }
                }


                for (int w = 0; w < charset.Length; w++)
                {
                    for (int q = 0; q < charset.Length; q++)
                    {
                        for (int c = 0; c < charset.Length; c++)
                        {

                            chk = charset[w].ToString() + charset[q].ToString() + charset[c].ToString();
                            crack.time = sw.Elapsed;
                            crack.isMatch(chk);
                        }
                    }
                }

                for (int e = 0; e < charset.Length; e++)
                {
                    for (int w = 0; w < charset.Length; w++)
                    {
                        for (int q = 0; q < charset.Length; q++)
                        {
                            for (int c = 0; c < charset.Length; c++)
                            {

                                chk = charset[e].ToString() + charset[w].ToString() + charset[q].ToString() + charset[c].ToString();
                                crack.time = sw.Elapsed;
                                crack.isMatch(chk);
                            }
                        }
                    }
                }

                for (int r = 0; r < charset.Length; r++)
                {
                    for (int e = 0; e < charset.Length; e++)
                    {
                        for (int w = 0; w < charset.Length; w++)
                        {
                            for (int q = 0; q < charset.Length; q++)
                            {
                                for (int c = 0; c < charset.Length; c++)
                                {

                                    chk = charset[r].ToString() + charset[e].ToString() + charset[w].ToString() + charset[q].ToString() + charset[c].ToString();
                                    crack.time = sw.Elapsed;
                                    crack.isMatch(chk);
                                }
                            }
                        }
                    }
                }

                for (int t = 0; t < charset.Length; t++)
                {
                    for (int r = 0; r < charset.Length; r++)
                    {
                        for (int e = 0; e < charset.Length; e++)
                        {
                            for (int w = 0; w < charset.Length; w++)
                            {
                                for (int q = 0; q < charset.Length; q++)
                                {
                                    for (int c = 0; c < charset.Length; c++)
                                    {

                                        chk = charset[t].ToString() + charset[r].ToString() + charset[e].ToString() + charset[w].ToString() + charset[q].ToString() + charset[c].ToString();
                                        crack.time = sw.Elapsed;
                                        crack.isMatch(chk);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (len >= 7 && len <= 10)
            {
                for (int y = 0; y < charset.Length; y++)
                {
                    for (int t = 0; t < charset.Length; t++)
                    {
                        for (int r = 0; r < charset.Length; r++)
                        {
                            for (int e = 0; e < charset.Length; e++)
                            {
                                for (int w = 0; w < charset.Length; w++)
                                {
                                    for (int q = 0; q < charset.Length; q++)
                                    {
                                        for (int c = 0; c < charset.Length; c++)
                                        {
                                            chk = charset[y].ToString() + charset[t].ToString() + charset[r].ToString() + charset[e].ToString() + charset[w].ToString() + charset[q].ToString() + charset[c].ToString();
                                            crack.time = sw.Elapsed;
                                            crack.isMatch(chk);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                for (int u = 0; u < charset.Length; u++)
                {
                    for (int y = 0; y < charset.Length; y++)
                    {
                        for (int t = 0; t < charset.Length; t++)
                        {
                            for (int r = 0; r < charset.Length; r++)
                            {
                                for (int e = 0; e < charset.Length; e++)
                                {
                                    for (int w = 0; w < charset.Length; w++)
                                    {
                                        for (int q = 0; q < charset.Length; q++)
                                        {
                                            for (int c = 0; c < charset.Length; c++)
                                            {
                                                chk = charset[u].ToString() + charset[y].ToString() + charset[t].ToString() + charset[r].ToString() + charset[e].ToString() + charset[w].ToString() + charset[q].ToString() + charset[c].ToString();
                                                crack.time = sw.Elapsed;
                                                crack.isMatch(chk);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                for (int o = 0; o < charset.Length; o++)
                {
                    for (int u = 0; u < charset.Length; u++)
                    {
                        for (int y = 0; y < charset.Length; y++)
                        {
                            for (int t = 0; t < charset.Length; t++)
                            {
                                for (int r = 0; r < charset.Length; r++)
                                {
                                    for (int e = 0; e < charset.Length; e++)
                                    {
                                        for (int w = 0; w < charset.Length; w++)
                                        {
                                            for (int q = 0; q < charset.Length; q++)
                                            {
                                                for (int c = 0; c < charset.Length; c++)
                                                {
                                                    chk = charset[o].ToString() + charset[u].ToString() + charset[y].ToString() + charset[t].ToString() + charset[r].ToString() + charset[e].ToString() + charset[w].ToString() + charset[q].ToString() + charset[c].ToString();
                                                    crack.time = sw.Elapsed;
                                                    crack.isMatch(chk);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                for (int p = 0; p < charset.Length; p++)
                {
                    for (int o = 0; o < charset.Length; o++)
                    {
                        for (int u = 0; u < charset.Length; u++)
                        {
                            for (int y = 0; y < charset.Length; y++)
                            {
                                for (int t = 0; t < charset.Length; t++)
                                {
                                    for (int r = 0; r < charset.Length; r++)
                                    {
                                        for (int e = 0; e < charset.Length; e++)
                                        {
                                            for (int w = 0; w < charset.Length; w++)
                                            {
                                                for (int q = 0; q < charset.Length; q++)
                                                {
                                                    for (int c = 0; c < charset.Length; c++)
                                                    {
                                                        chk = charset[p].ToString() + charset[o].ToString() + charset[u].ToString() + charset[y].ToString() + charset[t].ToString() + charset[r].ToString() + charset[e].ToString() + charset[w].ToString() + charset[q].ToString() + charset[c].ToString();
                                                        crack.time = sw.Elapsed;
                                                        crack.isMatch(chk);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if(len >= 11 && len <= 12)
            {
                for (int a = 0; a < charset.Length; a++)
                {
                    for (int p = 0; p < charset.Length; p++)
                    {
                        for (int o = 0; o < charset.Length; o++)
                        {
                            for (int u = 0; u < charset.Length; u++)
                            {
                                for (int y = 0; y < charset.Length; y++)
                                {
                                    for (int t = 0; t < charset.Length; t++)
                                    {
                                        for (int r = 0; r < charset.Length; r++)
                                        {
                                            for (int e = 0; e < charset.Length; e++)
                                            {
                                                for (int w = 0; w < charset.Length; w++)
                                                {
                                                    for (int q = 0; q < charset.Length; q++)
                                                    {
                                                        for (int c = 0; c < charset.Length; c++)
                                                        {
                                                            chk = charset[a].ToString() + charset[p].ToString() + charset[o].ToString() + charset[u].ToString() + charset[y].ToString() + charset[t].ToString() + charset[r].ToString() + charset[e].ToString() + charset[w].ToString() + charset[q].ToString() + charset[c].ToString();
                                                            crack.time = sw.Elapsed;
                                                            crack.isMatch(chk);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                for (int s = 0; s < charset.Length; s++)
                {
                    for (int a = 0; a < charset.Length; a++)
                    {
                        for (int p = 0; p < charset.Length; p++)
                        {
                            for (int o = 0; o < charset.Length; o++)
                            {
                                for (int u = 0; u < charset.Length; u++)
                                {
                                    for (int y = 0; y < charset.Length; y++)
                                    {
                                        for (int t = 0; t < charset.Length; t++)
                                        {
                                            for (int r = 0; r < charset.Length; r++)
                                            {
                                                for (int e = 0; e < charset.Length; e++)
                                                {
                                                    for (int w = 0; w < charset.Length; w++)
                                                    {
                                                        for (int q = 0; q < charset.Length; q++)
                                                        {
                                                            for (int c = 0; c < charset.Length; c++)
                                                            {
                                                                chk = charset[s].ToString() + charset[a].ToString() + charset[p].ToString() + charset[o].ToString() + charset[u].ToString() + charset[y].ToString() + charset[t].ToString() + charset[r].ToString() + charset[e].ToString() + charset[w].ToString() + charset[q].ToString() + charset[c].ToString();
                                                                crack.time = sw.Elapsed;
                                                                crack.isMatch(chk);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Password must be under 13 characters to crack!");
            }

            Console.WriteLine("Sorry, your password was not found!");
            Console.Write("Press any key to exit!");
            Console.ReadKey();
            System.Environment.Exit(1);
        }
    }
}
