using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager
    {
 
        Gamer register = new Gamer();
        public void Add(List<Gamer> gamers)
        {
            Console.WriteLine("Please write your Turkey Republic Citizenship Number: ");
            Console.WriteLine("...");
            register.TcNO = Console.ReadLine();
            //  if (register.TcNO.Length =!11)
            //{

            //            }
            Console.WriteLine("Please write your Name: ");
            register.Name = Console.ReadLine();
            Console.WriteLine("Please write your LastName: ");
            register.LastName = Console.ReadLine();
            Console.WriteLine("Please write your Year of Birth:  ");
            string birthday = Console.ReadLine();
            register.Birthday = new DateTime(birthday);
            Console.WriteLine("Congrulations! " + register.Name + " succesfully registered!");
            gamers.Add(register);



        }

        public void LogIn(List<Gamer> gamers)
        {
            Console.WriteLine("Please write your name: ");
            string xi = Console.ReadLine();
            for (int i = 0; i < gamers.Count; i++)
            {
                if (xi == gamers[i].Name)
                {
                    Console.WriteLine("Please write your surname: ");
                    string yi = Console.ReadLine();
                    if (yi == gamers[i].LastName)
                    {
                        Console.WriteLine("Please write your Citizenship Number: ");
                        string zi = Console.ReadLine();
                        if (zi == gamers[i].TcNO)
                        {
                            Console.WriteLine("Please write your year of birth: ");
                            string ti = Console.ReadLine();
                            if (ti == gamers[i].Birthday.Year)
                            {
                                Console.WriteLine("Congrulations! You have succesfully loggined!");
                            }
                            else
                            {
                                throw new Exception("Not a valid value");
                            }
                        }
                        else
                        {
                            throw new Exception("Not a valid value");
                        }
                    }
                    else
                    {

                        throw new Exception("Not a valid value");
                    }
                }
                else
                {
                    throw new Exception("Not a valid value");
                }
               
            }
        }
        public void RemoveGamer(List<Gamer> gamers)
        {
            Console.WriteLine("Which user do you want to delete? Please write a valid person name: ");
            string ri1 = Console.ReadLine();

            for (int i = 0; i < gamers.Count; i++)
            {
                if (ri1 == gamers[i].Name)
                {
                    Console.WriteLine("Hello! " + gamers[i].Name + " " + "please write your surname: ");
                    var ri2 = Console.ReadLine();
                    if (ri2 == gamers[i].LastName)
                    {
                        Console.WriteLine("Dear, " + gamers[i].Name + " " + gamers[i].LastName + " We checking your personal informations. Your process is almost finish... ");
                        Console.WriteLine("Please write your personal citizenship number.");
                        string ri3 = Console.ReadLine();
                        if (ri3 == gamers[i].TcNO)
                        {
                            Console.WriteLine("We almost match your all informations and ready for delete");
                            Console.WriteLine("Please write your birthday for correction: DD/MM/YYYY");
                            string ri4 = Console.ReadLine();
                            if (ri4 == gamers[i].Birthday)
                            {
                                Console.WriteLine("Dear," + gamers[i].Name + " we are unhappy for leaving us. We want to see you in the future.");
                                gamers.Remove(gamers[i]);
                               


                            }
                            else
                            {
                                Console.WriteLine("Your informations don't much each other");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please write a valid surname that registered before and want to delete");
                    }
                }

                else
                {
                    Console.WriteLine("Please write a valid user person name that registered before");
                }
            }

        }
        public void ListG(List<Gamer> gamers)
        {
            foreach (var gamer in gamers)
            {
                Console.WriteLine("Name: "+ gamer.Name);
                Console.WriteLine("Surname: "+ gamer.LastName);
                Console.WriteLine("Birthday: " + gamer.Birthday);
                Console.WriteLine("Citizenship Number: " + gamer.TcNO);
            }
        }
    } 
}
