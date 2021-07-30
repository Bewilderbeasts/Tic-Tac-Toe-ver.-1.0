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
           

            bool checkWinner()
            {
                // check rows
                if (tablica[0] == "X" && tablica[1] == "X" && tablica[2] == "X") { return true; }
                if (tablica1[0] == "X" && tablica1[1] == "X" && tablica1[2] == "X") { return true; }
                if (tablica2[0] == "X" && tablica2[1] == "X" && tablica2[2] == "X") { return true; }

                if (tablica[0] == "O" && tablica[1] == "O" && tablica[2] == "O") { return true; }
                if (tablica1[0] == "O" && tablica1[1] == "O" && tablica1[2] == "O") { return true; }
                if (tablica2[0] == "O" && tablica2[1] == "O" && tablica2[2] == "O") { return true; }

                // check columns
                if (tablica[0] == "X" && tablica1[0] == "X" && tablica2[0] == "X") { return true; }
                if (tablica[1] == "X" && tablica1[1] == "X" && tablica2[1] == "X") { return true; }
                if (tablica[2] == "X" && tablica1[2] == "X" && tablica2[2] == "X") { return true; }

                if (tablica[0] == "O" && tablica1[0] == "O" && tablica2[0] == "O") { return true; }
                if (tablica[1] == "O" && tablica1[1] == "O" && tablica2[1] == "O") { return true; }
                if (tablica[2] == "O" && tablica1[2] == "O" && tablica2[2] == "O") { return true; }

                // check diags
                if (tablica[0] == "X" && tablica1[1] == "X" && tablica2[2] == "X") { return true; }
                if (tablica[2] == "X" && tablica1[1] == "X" && tablica2[0] == "X") { return true; }

                if (tablica[0] == "O" && tablica1[1] == "O" && tablica2[2] == "O") { return true; }
                if (tablica[2] == "O" && tablica1[1] == "O" && tablica2[0] == "O") { return true; }

                return false;
            }

            if (checkWinner())
            {
                Console.WriteLine("Wygranko!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gramy dalej!");
            }


            while (ruch < 10)

            {
                Console.WriteLine(" ");
                Console.WriteLine("Wybierz pierwsze pole od 1 do 9");
                string wybor = Console.ReadLine();
                int wybor2 = int.Parse(wybor);

                if (wybor2 == 1)
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
                    }else { 
                    tablica[0] = "X";
                    ruch = ruch+1;
                    Console.Clear();
                    Console.WriteLine("{0}", string.Join(" ", tablica));
                    Console.WriteLine("{0}", string.Join(" ", tablica1));
                    Console.WriteLine("{0}", string.Join(" ", tablica2));
                        Console.WriteLine("Obecna kolejka to numer: {0} ", ruch);
                    }

                }

                else if (wybor2 == 2)
                {
                    if(ruch % 2 != 0)
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
                else if (wybor2 == 3)
                {
                    if(ruch % 2 != 0)
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
                else if (wybor2 == 4)
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
                else if (wybor2 == 5)
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
                else if (wybor2 == 6)
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
                else if (wybor2 == 7)
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
                else if (wybor2 == 8)
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
                else if (wybor2 == 9)
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
                checkWinner();
                //Checks();

            }


            
        }

        private static void Checks (string[] tablica, string[] tablica1, string[] tablica2)
        {
            if (tablica[0] == "X" && tablica[1] == "X" && tablica[2] == "X")
            {
                Console.WriteLine("Wygranko gracza od Xa");
                return;
             
            }
            else
            { };
        }


    }
}
