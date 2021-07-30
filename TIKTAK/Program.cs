using System;

namespace TIKTAK
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tablica = new string[3];
            string[] tablica1 = new string[3];
            string[] tablica2 = new string[3];

            for (int i = 0; i < 3; i++)
            {
                tablica[i] = "-";
                tablica1[i] = "-";
                tablica2[i] = "-";
            }
            Console.WriteLine("{0}", string.Join(" ", tablica));
            Console.WriteLine("{0}", string.Join(" ", tablica1));
            Console.WriteLine("{0}", string.Join(" ", tablica2));

            
            
            int ruch = 1;
           

            bool checkWinnerX()
            {
                // check rows
                if (tablica[0] == "X" && tablica[1] == "X" && tablica[2] == "X") { return true; }
                if (tablica1[0] == "X" && tablica1[1] == "X" && tablica1[2] == "X") { return true; }
                if (tablica2[0] == "X" && tablica2[1] == "X" && tablica2[2] == "X") { return true; }

               

                // check columns
                if (tablica[0] == "X" && tablica1[0] == "X" && tablica2[0] == "X") { return true; }
                if (tablica[1] == "X" && tablica1[1] == "X" && tablica2[1] == "X") { return true; }
                if (tablica[2] == "X" && tablica1[2] == "X" && tablica2[2] == "X") { return true; }

               

                // check diags
                if (tablica[0] == "X" && tablica1[1] == "X" && tablica2[2] == "X") { return true; }
                if (tablica[2] == "X" && tablica1[1] == "X" && tablica2[0] == "X") { return true; }

                

                return false;
            }

            bool checkWinnerO()
            {
                if (tablica[0] == "O" && tablica[1] == "O" && tablica[2] == "O") { return true; }
                if (tablica1[0] == "O" && tablica1[1] == "O" && tablica1[2] == "O") { return true; }
                if (tablica2[0] == "O" && tablica2[1] == "O" && tablica2[2] == "O") { return true; }
                if (tablica[0] == "O" && tablica1[0] == "O" && tablica2[0] == "O") { return true; }
                if (tablica[1] == "O" && tablica1[1] == "O" && tablica2[1] == "O") { return true; }
                if (tablica[2] == "O" && tablica1[2] == "O" && tablica2[2] == "O") { return true; }
                if (tablica[0] == "O" && tablica1[1] == "O" && tablica2[2] == "O") { return true; }
                if (tablica[2] == "O" && tablica1[1] == "O" && tablica2[0] == "O") { return true; }


                return false;
            }





            while (ruch < 10)

            {
                Console.WriteLine(" ");
                Console.WriteLine("Wybierz pierwsze pole od 1 do 9");
                string wybor = Console.ReadLine();
                int wybor2 = int.Parse(wybor);

                if (wybor2 == 1)
                {
                    if (tablica[0] == "-")
                    {
                        if (ruch % 2 != 0)
                        {
                            tablica[0] = "O";
                            ruch = ruch + 1;
                            Console.Clear();
                            Console.WriteLine("{0}", string.Join(" ", tablica));
                            Console.WriteLine("{0}", string.Join(" ", tablica1));
                            Console.WriteLine("{0}", string.Join(" ", tablica2));
                            Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                        }
                        else
                        {
                            tablica[0] = "X";
                            ruch = ruch + 1;
                            Console.Clear();
                            Console.WriteLine("{0}", string.Join(" ", tablica));
                            Console.WriteLine("{0}", string.Join(" ", tablica1));
                            Console.WriteLine("{0}", string.Join(" ", tablica2));
                            Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                        }

                    }
                    else { Console.WriteLine("Wybierz inne pole, te juz ktos zająl"); continue; }
                    



                }

                else if (wybor2 == 2)
                {

                    if (tablica[1] == "-")
                    {
                        if (ruch % 2 != 0)
                    {
                        tablica[1] = "O";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                    }else
                    {
                        tablica[1] = "X";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                    }
                    }
                    else { Console.WriteLine("Wybierz inne pole, te juz ktos zająl"); continue; }
                }
                else if (wybor2 == 3)
                {
                    if (tablica[2] == "-")
                    {
                        if (ruch % 2 != 0)
                    {
                        
                        
                            tablica[2] = "O";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                    }else
                    {
                        tablica[2] = "X";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                    }
                }
                else { Console.WriteLine("Wybierz inne pole, te juz ktos zająl"); continue; }
            }
                else if (wybor2 == 4)
                {
                    if (tablica1[0] == "-")
                    {
                        if (ruch % 2 != 0)
                    {
                        tablica1[0] = "O";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                    }
                    else
                    {
                        tablica1[0] = "X";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                        }
                    }
                    else { Console.WriteLine("Wybierz inne pole, te juz ktos zająl"); continue; }
                }
                else if (wybor2 == 5)
                {
                        if (tablica1[1] == "-")
                        {
                            if (ruch % 2 != 0)
                    {
                        tablica1[1] = "O";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                    }
                    else
                    {
                        tablica1[1] = "X";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                        }
                    }
                    else { Console.WriteLine("Wybierz inne pole, te juz ktos zająl"); continue; }
                }
                else if (wybor2 == 6)
                {
                            if (tablica1[2] == "-")
                            {
                                if (ruch % 2 != 0)
                    {
                        tablica1[2] = "O";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                    }
                    else
                    {
                        tablica1[2] = "X";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                       Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                        }
                    }
                    else { Console.WriteLine("Wybierz inne pole, te juz ktos zająl"); continue; }
                }
                else if (wybor2 == 7)
                {
                                if (tablica2[0] == "-")
                                {
                                    if (ruch % 2 != 0)
                    {
                        tablica2[0] = "O";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                    }
                    else
                    {
                        tablica2[0] = "X";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                        }
                    }
                    else { Console.WriteLine("Wybierz inne pole, te juz ktos zająl"); continue; }
                }
                else if (wybor2 == 8)
                {
                                    if (tablica2[1] == "-")
                                    {
                                        if (ruch % 2 != 0)
                    {
                        tablica2[1] = "O";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                    }
                    else
                    {
                        tablica2[1] = "X";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                        }
                    }
                    else { Console.WriteLine("Wybierz inne pole, te juz ktos zająl"); continue; }
                }
                else if (wybor2 == 9)
                {
                                        if (tablica2[2] == "-")
                                        {
                                            if (ruch % 2 != 0)
                    {
                        tablica2[2] = "O";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                    }
                    else
                    {
                        tablica2[2] = "X";
                        ruch = ruch + 1;
                        Console.Clear();
                        Console.WriteLine("{0}", string.Join(" ", tablica));
                        Console.WriteLine("{0}", string.Join(" ", tablica1));
                        Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                        }
                    }
                    else { Console.WriteLine("Wybierz inne pole, te juz ktos zająl"); continue; }
                }
                checkWinnerO();
                checkWinnerX();
                if (checkWinnerX())
                {
                   
                    Console.WriteLine("Wygranko Pana od X!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Koniec gry");
                    break;
                }
                else if (checkWinnerO())
                {
                    Console.WriteLine("Wygranko Pana od O!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Koniec gry");
                    break;
                }
                else
                {
                    Console.WriteLine("Gramy dalej!");
                }

            }


            
        }

  


    }
}
