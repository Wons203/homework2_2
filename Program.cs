namespace homework2_2
{

    class program
    {
        static void Main(string[] args)
        {
            bool b = true;


            while (b)
            {
                Console.WriteLine("Please input DNA :");
                string DNA = Console.ReadLine();


                if (IsValidSequence(DNA) == true)
                {
                    Console.WriteLine("Current half DNA sequence : {0}", DNA);
                    int check2 = 0;
                    while (b && check2 == 0)
                    {
                        Console.WriteLine("Do you want to replicate it ? (Y/N) : ");
                        string answer2 = Console.ReadLine();
                        if (answer2 == "Y" || answer2 == "N")
                        {
                            if (answer2 == "Y")
                            {
                                Console.WriteLine("Current half DNA sequence : {0}", ReplicateSeqeunce(DNA));
                                int check = 0;
                                while (check == 0 && b)
                                {
                                    Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                                    string answer = Console.ReadLine();
                                    if (answer == "N" || answer == "Y")
                                    {
                                        if (answer == "N")
                                        {
                                            b = false;
                                            break;


                                        }
                                        else
                                        {
                                            check2++;
                                            check++;
                                            continue;

                                        }



                                    }
                                    else
                                    {
                                        Console.WriteLine("Please input Y or N.");

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                                string answer = Console.ReadLine();
                                if (answer == "N" || answer == "Y")
                                {
                                    if (answer == "N")
                                    {
                                        b = false;
                                        break;
                                    }
                                    else
                                    {
                                        check2++;
                                        continue;
                                    }



                                }
                                else
                                {
                                    Console.WriteLine("Please input Y or N.");
                                    continue;
                                }
                            }

                        }
                        else
                        {

                            Console.WriteLine("Please input Y or N.");
                            continue;

                        }
                    }


                }
                else
                {

                    Console.WriteLine("That half DNA sequence is invalid.");
                    int a = 0;
                    while (a == 0 && b)
                    {
                        Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                        string answer = Console.ReadLine();
                        if (answer == "N" || answer == "Y")
                        {
                            if (answer == "N")
                            {
                                b = false;
                                break;
                            }
                            else
                            {
                                a++;

                            }



                        }
                        else
                        {
                            Console.WriteLine("Please input Y or N.");
                            continue;
                        }
                    }

                }



            }

        }




        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }

        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }


    }
}