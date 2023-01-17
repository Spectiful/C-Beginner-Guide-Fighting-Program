using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting_Game_Beginner_Guide
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeatcode = true;
            while (repeatcode)
            {
                Console.WriteLine("\nWelcome to the Fighting Game Beginner Guide");
                Console.WriteLine("Are you new to fighting games? \n1. Yes \n2. No \n");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("\nWhat fighting game would you like to learn?");

                    Console.WriteLine("1. Tekken 7 \n2. Street Fighter 5 \n3. Guilty Gear Strive \n4. Killer Instinct \n5. Dragon Ball FighterZ \n6. Skullgirls \n");

                    int game = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nWhen it comes to picking a character, you can use any character that you like. \nbut it's also recommended to use a beginner character to learn how the game works. \n");

                    switch (game)
                    {
                        case 1:
                            Console.WriteLine("Tekken 7 is 3d fighting game that focus on movement. \nUnfortunately, Tekken 7 doesn't have a tutorial on how the game works or teaches the basics, " +
                                "\nbut select one of the options for general tips \n");
                            Console.WriteLine("\n1.Movement \n2.Picking a Character \n3. Combos \n");
                            int gamechoice = Convert.ToInt32(Console.ReadLine());
                            if (gamechoice == 1)
                            {
                                Console.WriteLine("\nWhen it comes to movement in Tekken 7, it's best to learn backdashing and forward dashing to start off. \nOnce you feel more comfortable with the movement, " +
                                    "you can give learning the Korean Back Dash (KBD) by doing tap back twice, then holding down back, then tap back once on the controller.");
                            }
                            if (gamechoice == 2)
                            {
                                Console.WriteLine("\nWhen it comes to picking a character in Tekken 7, \nyou can pick any character that you find interesting or like how they look \n" +
                                    "\nSome characters may be harder than other characters, \nbut starting off by practicing some moves with the character and going through the movelist.\n"
                                     );
                            }
                            if (gamechoice == 3)
                            {
                                Console.WriteLine("\nLearning combos in tekken 7 can be a bit challenging but when starting with combos, \nit's best start to small bnb (bread & butter) combos line 2-5 hits and slowly experiment.");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Street Fighter 5 is 2.5D fighting game that focus on ground based gameplay and movement. \nSFV also has a tutorial mode on how the game works but not with fighting game basics. \n");
                            Console.WriteLine("What character would you like to learn? \n1. Ryu \n2. Ken \n3. Guile");
                            int sfcharacter = Convert.ToInt32(Console.ReadLine());
                            if (sfcharacter == 1)
                            {
                                Console.WriteLine("Ryu is well rounded character that can help you learn the fundamentals of how the game works.");
                            }
                            if (sfcharacter == 2)
                            {
                                Console.WriteLine("Ken is similiar to Ryu with some tools being different but is also well rounded.");
                            }
                            if (sfcharacter == 3)
                            {
                                Console.WriteLine("Guile is a defensive character with just two special moves but are charge motions \nwhere you hold a button for a 1-2 seconds and pressing a attack button.");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Guilty Gear Strive is a 2.5D anime style fighting game that focus on combos and movement. \nGuilty Gear Strive has a really detailed tutorial that not shows how the game works, " +
                                "\nbut how fighting work in general. \n");
                            Console.WriteLine("What character would you like to learn \n1. Sol \n2. Ky \n3. Ramlethal \n4. May \n5. Giovanna \n");
                            int ggcharacter = Convert.ToInt32(Console.ReadLine());
                            if (ggcharacter == 1)
                            {
                                Console.WriteLine("\nSol is a rushdown character that has easy to perform combos and to learn");
                            }
                            if (ggcharacter == 2)
                            {
                                Console.WriteLine("\nKy is a all around character that has a little bit of every tool that can help a beginner learn the game");
                            }
                            if (ggcharacter == 3)
                            {
                                Console.WriteLine("\nRamlethal is zoner based character that focuses on distance and screen control.");
                            }
                            if (ggcharacter == 4)
                            {
                                Console.WriteLine("\nMay is a charge motion all around character that has tools to help with getting closer to opponents along with \nmoves that are not complex to perform.");
                            }
                            if (ggcharacter == 5)
                            {
                                Console.WriteLine("\nGiovanna is a rushdown character that has short but damaging combos that are easy for beginners to learn.");
                            }
                            break;

                        case 4:
                            /*
                             * Beginner Characters: Jago, Sabrewulf, Riptor, Rash, Tusk
                             */
                            Console.WriteLine("Killer Instinct is a free to play 2.5D fighting game that is on XBOX One \nKiller Instinct has a really detailed tutorial that goes over the basics of fighting games along with the mechanics of the game.");
                            Console.WriteLine("What character would you like to learn \n1. Jago \n2. Sabrewulf \n3. Riptor \n4. Thunder");
                            int kicharacter = Convert.ToInt32(Console.ReadLine());
                            if (kicharacter == 1)
                            {
                                Console.WriteLine("Jago is the well rounded character that has every tool for beginners to learn how the game works.");
                            }
                            if (kicharacter == 2)
                            {
                                Console.Write("Sabrewulf is a rushdown character who's gameplan is to apply pressure when playing the character.");
                            }
                            if (kicharacter == 3)
                            {
                                Console.WriteLine("Riptor is a rushdown character who has some stance modes along with some charge moves but has a straight forward gameplan.");
                            }
                            if (kicharacter == 4)
                            {
                                Console.WriteLine("Thunder is a grappler character that has a straight forward rushdown and high damaging combos and grabs.");
                            }
                            break;

                        case 5:
                            /* General tips for dbfz
                               Character Tier list for easy to use and hard to use
                               FighterZ Dojo
                               Picking your characters for your team
                               Team Order: Point, Mid, Anchor
                            */
                            Console.WriteLine("Dragonball FighterZ is a 3v3 anime fighting game where you have to beat every character on the opponents team. \nDragonball FighterZ has a beginner friendly tutorial and easy to learn playstyle.");
                            Console.WriteLine("Choose which general tips you would like to know about Dragonball FighterZ: \n1. FighterZ Dojo \n2. Picking a character for your team \n3. Team order \n4. Assist \n");
                            int dbfzguide = Convert.ToInt32(Console.ReadLine());
                            if (dbfzguide == 1)
                            {
                                Console.WriteLine("\nFighterZ Dojo is the tutorial for Dragonball FighterZ. \nIt walks you through how the game mechanics works and how the game plays as well.");
                            }
                            if (dbfzguide == 2)
                            {
                                Console.WriteLine("\nFor picking a character in dbfz, you have to pick 3 characters to have a team in dbfz. Although you can pick any character to pick on your team, here are 3 list of characters from easy to learn to some that would need some extra practice:");
                                /*
                                  Not too sure for difficulty: Hit, Cell, Trunks
                                */

                                /*
                                  Easy to learn: Bardock, DBS Broly, Cooler, SSB Gogeta, Teen Gohan, Goku Black, SSB Goku, SSJ Goku, Janemba, Jiren, Kefla Tien, SSJ Vegeta, Yamcha
                                */
                                Console.WriteLine("\nEasy to learn: \nBardock \nDBS Broly \nCooler \nSSB Gogeta \nTeen Gohan \nGoku Black \nSSB Goku \nSSJ Goku \nJanemba \nJiren \nKefla \nTien \nSSJ Vegeta \nYamcha ");

                                /*
                                  Easy to learn but need some practice: SSB Vegeta, Nappa, Krillin, Andriod 17, Andriod 18, Andriod 16, Andriod 21, Kid Buu, Base Goku, Baby Vegeta, Frieza, Ginyu, Ultimate Gohan, Gotenks, Base Vegeta, GT Goku
                                */
                                Console.WriteLine("\nEasy to learn but needs some practice: \nSSB Vegeta \nNappa \nKrillin \nAndriod 17 \nAndriod 18 " +
                                                  "\nAndriod 16 \nAndriod 21 \nKid Buu \nBase Goku \nBaby Vegeta \nFrieza \nGinyu \nUltimate Gohan \nGotenks \nBase Vegeta, \nGT Goku");

                                /*
                                  Hard to learn need to practice: Zamasu, Videl, Piccolo, Master Roshi, Beerus, Majin Buu 
                                */
                                Console.WriteLine("\nHard to play needs to practice: \nZamasu \nVidel \nPiccolo \nMaster Roshi \nBeerus \nMajin Buu");
                            }
                            if (dbfzguide == 3)
                            {
                                Console.WriteLine("\nSince Dragonball Fighterz is a 3v3 team fighting game, you would have to pick the order of which characters in your team is place. You can place characters in any position, \n" +
                                    "but the order will always be the following: Point, Mid, Anchor.");
                                Console.WriteLine("\nPoint is the first character in your team that would build meter for the mid and anchor characters. " +
                                    "\n Point character doesn't need a lot of meter to do combos and can do fine without having it.");
                                Console.WriteLine("\nMiddle is the second character in your team and is flexible with not needing meter to play but can use a little of it as well." +
                                    "\n Much like the point character, the mid character gives the anchor character more meter to work with when or if they are to be played.");
                                Console.WriteLine("\nAnchor is the last character in your team that is the strongest and can peform the most damage in the team.");
                            }
                            if (dbfzguide == 4)
                            {
                                Console.WriteLine("\nAssists in Dragonball FighterZ are mechanics used to either continue combos or pressure the opponents. " +
                                    "\n Dragonball FighterZ has three types of assist: Assist A, Assist B, & Assist C. Although assist a and b would vary for every character, assist c is a move where it would tracking the opponent for combo potential.");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            break;

                        case 6:
                            /*
                            Skullgirls easy characters to use: Fillia, Valentine, Parasoul, Fortune, Peacock, Big Band, Annie
                            Skullgirls needs some practice to use: Cerebella, Eliza, Beowulf, Fukua, Umbrella
                            Skullgirls hardest to use: Fortune (headless), Double, Painwheel, Robo-Fortune, Squigly, Parasoul
                            */
                            Console.WriteLine("\nSkullgirls is a indie team fighting game where you can choose to have the following ways of playing: \n 1v1, 1v2, 1v3, 2v2, and 3v3.");
                            Console.WriteLine("\nSkullgirls is a easy to learn and play indie team fighting game where the tutorial is in depth from learning the basic of fighting, how the mechanics of skullgirls work, and other technique that are explored in fighting games.");
                            Console.WriteLine("Choose which general tips you would like to know about Dragonball FighterZ: \n1.Tutorial \n2.Picking a character for your team \n3.Team order \n4.Assist \n");
                            int skullgirls = Convert.ToInt32(Console.ReadLine());
                            if (skullgirls == 1)
                            {
                                Console.WriteLine("Skullgirls tutorial will help the player understand how skullgirls mechanics are along with how the basics of fighting  works in general from movement to blocking certain attacks and fighting game terms.");
                            }
                            if (skullgirls == 2)
                            {
                                Console.WriteLine("Normally in a team game, you would have to pick three characters to have a team. \nBut for skullgirls, you have the option to choose either 3 characters, 2 characters, or even one character to play.");
                                Console.WriteLine("\nThe only difference with skullgirls, is that depending how many characters you choose for your team, the health would vary. Having one character in your team would have the most health while having 2 characters or 3 characters would have less health.");
                                Console.WriteLine("\nNumber of characters in a team would be a factor on when playing against other players. For example if player 1 has one character in their team but player 2 has 3 characters, \nplayer one team would have more health than player two. But if both players has the same amount of characters, then both teams would have the same amount of health.");
                            }
                            if (skullgirls == 3)
                            {
                                Console.WriteLine("\nAlthough Skullgirls has the option to choose how many characters are on a team, you would have to pick the order of which characters in your team is place u. You can place characters in any position, \n" +
                                    "but the order will always be the following: Point, Mid, Anchor.");
                                Console.WriteLine("\nPoint is the first character in your team that would build meter for the mid and anchor characters. " +
                                    "\n Point character doesn't need a lot of meter to do combos and can do fine without having it.");
                                Console.WriteLine("\nMiddle is the second character in your team and is flexible with not needing meter to play but can use a little of it as well." +
                                    "\n Much like the point character, the mid character gives the anchor character more meter to work with when or if they are to be played.");
                                Console.WriteLine("\nAnchor is the last character in your team that is the strongest and can peform the most damage in the team.");
                            }
                            if (skullgirls == 4)
                            {
                                Console.WriteLine("In some 3v3 fighting games, you would choose a team and for each character, each character needs an assist. \nAlthough there are preset assists in Skullgirls," +
                                    "Skullgirls also allows you to input your own assist based of the character's movelist. \nChoosing between the preset or customizable assist would vary on the player and be helpful towards how they play" +
                                    "skullgirls.");
                            }
                            break;
                    }
                }

                else if (choice == 2)
                {
                    Console.WriteLine("Sorry this guide is for beginners only...");
                }

                Console.WriteLine("\nTry Again? (Y for yes/N for no) \n");
                string pick = Console.ReadLine();

                if (pick == "N" || pick == "n")
                {
                    repeatcode = false;
                }

                if (pick == "Y" || pick == "y")
                {
                    repeatcode = true;
                }
          
            }
        }
    }
}


/*
 * Random ideas that may be added later:
 * Contoller type to use
 */