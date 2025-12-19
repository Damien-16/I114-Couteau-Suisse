using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{

    static Dictionary<char, string> codeMorse = new Dictionary<char, string>()
   {
       {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."},
       {'E', "."}, {'F', "..-."}, {'G', "--."}, {'H', "...."},
       {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."},
       {'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."},
       {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
       {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"},
       {'Y', "-.--"}, {'Z', "--.."},
       {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"},
       {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."},
       {'9', "----."}, {'0', "-----"},{' ', "/"}
   };
    static void Main(string[] args)
    {
        bool continuer = true;
        do
        {
            Console.Clear();
            Console.WriteLine("\n\n=== Couteau Suisse – Utilitaires ===");
            Console.WriteLine("1. Convertir du texte en code Morse ");
            Console.WriteLine("2. Convertir des nombres entre différentes bases (Décimal <> Binaire <> Octal)");
            Console.WriteLine("3. César ");
            Console.WriteLine("4. Quitter\n\n");
            Console.Write("Veuillez entrer votre choix : ");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("=== Convertisseur de texte en code Morse ===");
                    string text = "";

                    do
                    {
                        Console.WriteLine("Entrez un mot ou une phrase (sans accents) :");
                        text = Console.ReadLine().ToUpper();
                    } while (string.IsNullOrWhiteSpace(text));

                    string morse = "";
                    foreach (char c in text)
                    {
                        if (codeMorse.ContainsKey(c))
                        {
                            morse += codeMorse[c] + " ";
                        }
                        else
                        {
                            morse += "?";
                        }
                    }
                    Console.WriteLine($"Résultat en Morse: \n{morse}");

                    Console.WriteLine("\n\nVoulez vous continuer le morse ? (o/n)");
                    string boucle = Console.ReadLine();


                    if (boucle == "o" | boucle == "O")
                    { }
                    else if (boucle == "n" | boucle == "N")
                    {
                        break;
                    }
                } while (true);
            }
            if (choix == "2")
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("=== Convertisseur de bases ===");
                    Console.WriteLine("1. Décimal > Binaire");
                    Console.WriteLine("2. Binaire > Décimal");
                    Console.WriteLine("3. Binaire > Octal");
                    Console.WriteLine("4. Octal > Binaire");
                    Console.WriteLine("5. Quitter");
                    Console.Write("Veuillez entrer votre choix :");
                    string choix2 = Console.ReadLine();


                    if (choix2 == "1")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Convertisseur Décimal -> Binaire");
                            Console.Write("Écris un chiffre décimal: ");
                            int dec;
                            int remainder;
                            string binary = "";

                            while (!int.TryParse(Console.ReadLine(), out dec))
                            {
                                Console.WriteLine("Erreur ! Veuillez entrer un nombre entier valide :");
                            }

                            if (dec == 0)
                            {
                                binary = "0";
                            }
                            while (dec > 0)
                            {
                                remainder = dec % 2;
                                dec /= 2;
                                binary = remainder.ToString() + binary;
                            }
                            Console.WriteLine($"Le nombre en binaire  = {binary} ");
                            Console.WriteLine("\n\nVoulez vous continuer ? (o/n)");
                            string boucle = Console.ReadLine();


                            if (boucle == "o" | boucle == "O")
                            { }
                            else if (boucle == "n" | boucle == "N")
                            {
                                break;
                            }

                        } while (true);
                    }
                    if (choix2 == "2")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Convertisseur Binaire -> Décimal");
                            Console.Write("Écris un nombre binaire :");
                            string nbBi = Console.ReadLine();
                            int decNum = 0;
                            int power = 1;
                            bool estValide = true;
                            foreach (char c in nbBi)//verif si = 1 ou 0 
                            {
                                if (c != '0' && c != '1')
                                {
                                    estValide = false;
                                }
                            }

                            if (!estValide)
                            {
                                Console.WriteLine("Erreur: Ce n'est pas un binaire valide.");
                            }
                            else
                            {
                                for (int i = nbBi.Length - 1; i >= 0; i--)
                                {
                                    int bit = nbBi[i];

                                    if (bit == '1')
                                    {
                                        decNum += power;
                                    }
                                    power *= 2;
                                }
                                Console.WriteLine($"Le nombre binaire {nbBi} est {decNum} en décimal");
                            }

                            Console.ReadLine();
                            if (estValide)
                            {
                                Console.WriteLine("\n\nVoulez vous continuer ? (o/n)");
                                string boucle = Console.ReadLine();


                                if (boucle == "o" | boucle == "O")
                                { }
                                else if (boucle == "n" | boucle == "N")
                                {
                                    break;
                                }
                            }
                        } while (true);

                    }
                    if (choix2 == "3")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Convertisseur Binaire -> Octal");
                            Console.WriteLine("Ecrivez votre chiffre en Binaire");
                            string nbBi = Console.ReadLine();
                            int decNum = 0;
                            int power = 1;
                            bool estValide = true;
                            foreach (char c in nbBi)//verif si = 1 ou 0 
                            {
                                if (c != '0' && c != '1')
                                {
                                    estValide = false;
                                }
                            }

                            if (!estValide)
                            {
                                Console.WriteLine("Erreur: Ce n'est pas un binaire valide.");
                            }
                            else
                            {
                                for (int i = nbBi.Length - 1; i >= 0; i--)
                                {
                                    char bit = nbBi[i];
                                    if (bit == '1')
                                    {
                                        decNum += power;
                                    }
                                    power *= 2;
                                }
                                string octalNum = "";
                                int tempDecNum = decNum;

                                while (tempDecNum > 0)
                                {
                                    int remainder = tempDecNum % 8;
                                    octalNum = remainder.ToString() + octalNum;
                                    tempDecNum /= 8;
                                }

                                Console.WriteLine($"Le nombre binaire {nbBi} est {octalNum} en octal");
                            }

                            Console.ReadLine();
                            if (estValide)
                            {
                                Console.WriteLine("\n\nVoulez vous continuer ? (o/n)");
                                string boucle = Console.ReadLine();


                                if (boucle == "o" | boucle == "O")
                                { }
                                else if (boucle == "n" | boucle == "N")
                                {
                                    break;
                                }
                            }
                        } while (true);
                    }
                    if (choix2 == "4")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Convertisseur Octal -> Binaire");
                            Console.WriteLine("Ecrivez votre chiffre en Binaire");
                            string numOct = Console.ReadLine();
                            string savOct = numOct;
                            int i = 0;
                            string binary = "";
                            while (i < numOct.Length)
                            {
                                int c = numOct[i];
                                switch (c)
                                {
                                    case '0':
                                        binary += "000";
                                        break;
                                    case '1':
                                        binary += "001";
                                        break;
                                    case '2':
                                        binary += "010";
                                        break;
                                    case '3':
                                        binary += "011";
                                        break;
                                    case '4':
                                        binary += "100";
                                        break;
                                    case '5':
                                        binary += "101";
                                        break;
                                    case '6':
                                        binary += "110";
                                        break;
                                    case '7':
                                        binary += "111";
                                        break;
                                    default:
                                        Console.WriteLine("\nCe caractère n'est pas en Octal " + numOct[i] + "\n");
                                        break;
                                }
                                i++;
                            }
                            Console.WriteLine($"Le nombre binaire {savOct} est {binary} en octal");
                            Console.ReadLine();

                            Console.WriteLine("\n\nVoulez vous continuer ? (o/n)");
                            string boucle = Console.ReadLine();


                            if (boucle == "o" | boucle == "O")
                            { }
                            else if (boucle == "n" | boucle == "N")
                            {
                                break;
                            }

                        } while (true);

                    }
                    if (choix2 == "5")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nOption invalide !");
                        Console.ReadKey();
                    }
                } while (true);
            }
            if (choix == "3")
            {
                Console.Clear();
                Console.WriteLine("\n--- Chiffrement de César ---");
                Console.Write("Entrez le message à chiffrer : ");
                string message = Console.ReadLine();
                Console.Write("Entrez le décalage (nombre entier) : ");

                int decalage;

                while (!int.TryParse(Console.ReadLine(), out decalage))
                {
                    Console.Write("Erreur. Veuillez entrer un nombre entier valide : ");
                }

                string messageChiffre = "";

                foreach (char c in message)
                {
                    if (char.IsLetter(c))
                    {
                        char offset = char.IsUpper(c) ? 'A' : 'a';

                        int lettreCalculee = (c - offset + decalage) % 26;

                        if (lettreCalculee < 0)
                        {
                            lettreCalculee += 26;
                        }
                        messageChiffre += (char)(lettreCalculee + offset);
                    }
                    else
                    {
                        messageChiffre += c;
                    }
                }

                Console.WriteLine($"\nRésultat : {messageChiffre}");
                Console.ReadKey();
            }
            if (choix == "4")
            {
                continuer = false;
                Console.WriteLine("\n\nAU revoir.\n\n\n");
            }
            else
            {
                Console.WriteLine("\n\nEntez un chiffre valide SVP!!");
                Console.ReadKey();
            }

        } while (continuer == true);

    }

}