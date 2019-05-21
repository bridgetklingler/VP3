﻿using System;

namespace Virtual_Pets_Amok
{
    class Program
    {
        static void Main(string[] args)
        {
            bool toPlay = true;
            Menu menu = new Menu();
            Console.WriteLine("Welcome to VP3, type \"start\" to begin.\nType \"quit\" at any time to exit.");
            string playResponse = Console.ReadLine().ToLower();

            if (playResponse.Equals("quit"))
            {
                toPlay = false;
            }

            while (toPlay)
            {
                Console.WriteLine("\nLet's Play!");

                Menu startMenu = new Menu();
                int menuResponse = menu.MainMenu();
                Pet firstPet = new Pet("", "");
                
                if (menuResponse == 1)
                 {
                    Console.WriteLine("Please choose which pet you would like to add to your shelter: Goldfish, Moose, Ferret, or Penguin");
                    string petSpecies = Console.ReadLine();
                    Console.WriteLine("Please give a name to your " + petSpecies);
                    string petName = Console.ReadLine();
                    firstPet = new Pet(petName, petSpecies);
                 }

                if (menuResponse == 2)
                {

                }

                if (menuResponse == 7)
                {
                    return;
                }


                Console.WriteLine("Type \"MyPet\" in order to view the status of your pet");
                string infoResponse = Console.ReadLine().ToLower();
                {
                    if (infoResponse.Equals("mypet"))
                    {
                        Console.WriteLine("Your " + firstPet.Species + " is named " + firstPet.Name);
                        firstPet.GetInfo();
                        Console.ReadLine();
                    }

                }
                
                Console.WriteLine("Type \"PetHealth\" in order to view the status of your pet");
                string statusResponse = Console.ReadLine().ToLower();
                {
                    if (statusResponse.Equals("pethealth"))
                    {
                       
                        Console.WriteLine("Your pet's hunger is " + firstPet.Hunger);

                        Console.ReadLine();
                    }

                }


            }
        }
    }
}
            


        
    

