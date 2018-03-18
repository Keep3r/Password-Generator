using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwordgenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Command Line script that generates a password.
            /*
             Types of password:
             -Random;
             -Random Phrase;
             -Phrase.
             */
            //Command: generate passwd #r/#rP/#p
            //Made by: X x/li3r.

            string passwd = "";//Is the string that'll hvve the password.
            string help = "Command Line script that generates a password.\n\nTypes of password:\n-Random;\n-Random Phrase;\n-Phrase.\n\nCommand: generate passwd #r/#rP/#p.\n\nMeaning:\n#r: random characters password;\n#rP: random phrase password;\n#p: non-random phrase password.\n\nParameters:\n-ws. It takes off the spaces.\nEx.: generate passwd #rP -ws\n\nMade by: X x/li3r.";


            while (true)
            {
                Console.Write("#> ");
                string command = Console.ReadLine();//Get the command.

                string[] commandParts = command.Trim().Split();//Divide it into parts without any spaces.

                //Check if the command is correct.
                if(commandParts[0] == "generate")
                {
                    if(commandParts[1] == "passwd")
                    {
                        //Generate a random password.
                        if(commandParts[2] == "#r")
                        {   
                                passwd = GenerateRandom();    
                        }
                        //Generate a random phrase as password.
                        else if(commandParts[2] == "#rP")
                        {
                            if (commandParts.Length < 4)
                            {
                                passwd = GenerateRandomPhrase();
                            }
                            else if (commandParts.Length == 4 && commandParts[3] == "-ws")
                            {
                                passwd = GenerateRandomPhrase(true);
                            }
                        }
                        //Generate a phrase as password.
                        else if(commandParts[2] == "#p")
                        {
                            if (commandParts.Length < 4)
                            {
                                passwd = GeneratePhrase();
                            }
                            else if (commandParts.Length == 4 && commandParts[3] == "-ws")
                            {
                                passwd = GeneratePhrase(true);
                            }
                        }
                        else
                        {
                            break;
                        }

                        Console.WriteLine($"Your password is \"{passwd}\"");
                    }
                    else
                    {
                        break;
                    }
                }
                //Show help.
                else if (commandParts[0] == "$help")
                {
                    Console.WriteLine(help);
                }
                else
                {
                    break;
                }
                Console.ReadLine();
            }
        }

        static string GenerateRandomPhrase(bool ws = false)//Generates a random phrase.
        {
            string[] nouns = 
            {
                //Nouns.
                " lonely",
                " deeply",
                " happiness",
                " sadness",
                " badness",
                " useless",
                " chillness",
                " faithly"
            };

            string[] adjectives = 
            {
                //Adjectives.
                " intelligent",
                " dumb",
                " small",
                " big",
                " thin",
                " round",
                " cool",
                " crazy",
            };

            string[] verbs =
            {
                //verbs
                " take",
                " put",
                " throw", 
                " get", 
                " run",
                " walk",
                " care",
                " poop"
            };

            string[] subjects =
            {
                //Subjects.
                "I",
                "He",
                "She",
                "It",
                "Him",
                "Her",
                "They",
                "We", 
            };

            string[] toBe =
            {
                //To be verbs.
                "'s",
                "'re",
                " ain't",
                " are",
                " is",
                " isn't",
                "'m",
            };

            string[] words =
            {
                //Words.
                " ball",
                " chair",
                " furniture",
                " beer",
                " wine",
                " toys",
                " pen",
                " house"
            };

            if (!ws)
            {
                //Make a non-sense phrase.
                return subjects[new Random().Next(subjects.Length)].TrimStart() + toBe[new Random().Next(toBe.Length)] + verbs[new Random().Next(verbs.Length)] + adjectives[new Random().Next(adjectives.Length)] + nouns[new Random().Next(nouns.Length)] + words[new Random().Next(words.Length)].TrimEnd();
            }
            else
            {
                return (subjects[new Random().Next(subjects.Length)] + toBe[new Random().Next(toBe.Length)] + verbs[new Random().Next(verbs.Length)] + adjectives[new Random().Next(adjectives.Length)] + nouns[new Random().Next(nouns.Length)] + words[new Random().Next(words.Length)]).Replace(" ", "");
            }
        }

        static string GeneratePhrase(bool ws = false)
        {
            string[] phrases =
            {
                //Phrases.
                "Do what you have to",
                "Fuck you",
                "Fuck people",
                "That is no security. Trust no one",
                "People are dirt, trust no one",
                "Trust no one",
                "Don't collect material things, collect moments",
                "Care about no one and no will care about you",
            };

            //Return a random phrase.
            if (!ws)
            {
                return phrases[new Random().Next(phrases.Length)];
            }
            else
            {
                return (phrases[new Random().Next(phrases.Length)]).Replace(" ", "");
            }
            
        }

        static string GenerateRandom()
        {
            string capsLockCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";//Characters on upper case.
            string normalCharacters = "abcdefghijklmnopqrstuvwxyz";//Characters on lower case.
            string numbers = "0123456789";//Numbers
            string specialCharacters = "''\"\"!@#$%¨&*()_+-=[]{}^~`´/?>.<,|°ºª§¬¢£";

            //Return a random thing.
            return (capsLockCharacters[new Random().Next(capsLockCharacters.Length)].ToString() + normalCharacters[new Random().Next(normalCharacters.Length)].ToString() + numbers[new Random().Next(numbers.Length)].ToString() + specialCharacters[new Random().Next(specialCharacters.Length)].ToString()).Replace(" ", "");
        }
    }
}
