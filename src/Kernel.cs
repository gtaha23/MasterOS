using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using Sys = Cosmos.System;
Sys.FileSystem.CosmosVFS fs = new Cosmos.System.FileSystem.CosmosVFS();
Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);

namespace MamacOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("MasterOS Succesfully booted...");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("                     ########  ######## ");
            Console.WriteLine(" ######## #####    ###    ### ###    ## ");
            Console.WriteLine("  ######### ####  ##      ### ######    ");
            Console.WriteLine("  ###  ###  #### ###     ###    ######  ");
            Console.WriteLine(" ###  ###  #### ##     ### ##    ####   ");
            Console.WriteLine(" ################ ########  ########    ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Welcome to MasterOS!");
            Console.WriteLine("Write help to see the commands.");
            Console.WriteLine("");

        }

        protected override void Run()
        {
            Console.Write("#root@mOS>");
            var input = Console.ReadLine();
            if (input == "help")
            {
                Console.WriteLine("Last stable version is -> v0.3.9 Alpha ");
                Console.WriteLine("Commands: ");
                Console.WriteLine("-> help");
                Console.WriteLine("-> about");
                Console.WriteLine("-> info");
                Console.WriteLine("-> oldfetch");
                Console.WriteLine("-> reboot");
                Console.WriteLine("-> shutdown");
                Console.WriteLine("-> c-sharp");
                Console.WriteLine("-> vm");
                Console.WriteLine("-> command-counter");
                Console.WriteLine("-> clear");
                Console.WriteLine("-> bios ");
                Console.WriteLine("-> color");
                Console.WriteLine("-> color2");
                Console.WriteLine("-> otokarl");
                Console.WriteLine("-> sfs");
                Console.WriteLine("-> fst");
                Console.WriteLine("-> lof");
                Console.WriteLine("-> gdl");
                Console.WriteLine("-> FAQs");
                Console.WriteLine("=====Game Zone=====");
                Console.WriteLine("-> Lab0");
            }

            else if (input == "about")
            {
                Console.WriteLine("MasterOS is an TUI based small but stable Operating System.");
                Console.WriteLine("This OS is currently being developed by mOS, and the project is open source.");
                Console.WriteLine("Current version of it is v0.3.8  (Because due to migration to C#).");
                Console.WriteLine("To see more updates, stay tuned!");
            }

            else if (input == "reboot")
            {
                Console.WriteLine("O.S rebooting...");
                Cosmos.System.Power.Reboot();
            }

            else if (input == "shutdown")
            {
                Console.WriteLine("O.S Shutting down...");
                Cosmos.System.Power.Shutdown();
            }

            else if (input == "info")
            {
                Console.WriteLine("The OS is built by COSMOS using C#, although the developers doesn't know C#, they managed to write some commands!");
            }

            else if (input == "oldfetch")
            {
                Console.Clear();
                Console.WriteLine("                    ########  ########    OS Name: MasterOS");
                Console.WriteLine("######## #####    ###    ### ###    ##    Kernel Version: v0.13");
                Console.WriteLine(" ######### ####  ##      ### ######       Creator: MasterCode Studios");
                Console.WriteLine(" ###  ###  #### ###     ###    ######     Current Version: v0.3.9 Alpha ");
                Console.WriteLine("###  ###  #### ##     ### ##    ####      Current File: Kernel.cs");
                Console.WriteLine("################ ########  ########       Foundation: Master Operating Systems");
                Console.WriteLine("                                                                   ");
            }

            else if (input == "vm")
            {
                Console.WriteLine("VM is a short name for Virtual Machines,");
                Console.WriteLine("You can enable Virtualization in your BIOS.");
                Console.WriteLine("Once you done that you can download a Virtualization Software like VMware, VirtualBox,...");
                Console.WriteLine("This O.S is built with VMware and VS2022");
            }

            else if (input == "clear")
            {
                Console.Clear();
            }

            else if (input == "command-counter")
            {
                Console.WriteLine(" *----------------------------*");
                Console.WriteLine(" 25 commands currently available");
                Console.WriteLine(" *----------------------------*");
            }

            else if (input == "color")
            {
                Console.WriteLine("What colors do you want?(for text)");
                Console.WriteLine("- black");
                Console.WriteLine("- blue");
                Console.WriteLine("- cyan");
                Console.WriteLine("- darkBlue");
                Console.WriteLine("- darkCyan");
                Console.WriteLine("- darkGray");
                Console.WriteLine("- darkGreen");
                Console.WriteLine("- darkMagenta");
                Console.WriteLine("- darkRed");
                Console.WriteLine("- darkYellow");
                Console.WriteLine("- gray");
                Console.WriteLine("- green");
                Console.WriteLine("- red");
                Console.WriteLine("- magenta");
                Console.WriteLine("- yellow");
                Console.WriteLine("- white");
                Console.WriteLine("enter the color: ");
                Console.Write("--> ");
                var color_input = Console.ReadLine();

                if (color_input == "black")
                {
                    Console.ForegroundColor = ConsoleColor.Black;

                }
                else if (color_input == "blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (color_input == "cyan")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (color_input == "darkBlue")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (color_input == "darkCyan")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                else if (color_input == "darkGray")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else if (color_input == "darkGreen")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else if (color_input == "darkMagenta")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                else if (color_input == "darkRed")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else if (color_input == "darkYellow")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else if (color_input == "gray")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (color_input == "green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (color_input == "red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (color_input == "magenta")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (color_input == "yellow")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (color_input == "white")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {
                    Console.WriteLine("! Invalid Color Command !");
                }
            }

            else if (input == "color2")
            {
                Console.WriteLine("Welcome to Color 2.0!");
                Console.WriteLine("What colors do you want?(Put a t- at the beginning of the color for the text, put a b- for the background)");
                Console.WriteLine("- black");
                Console.WriteLine("- blue");
                Console.WriteLine("- cyan");
                Console.WriteLine("- darkBlue");
                Console.WriteLine("- darkCyan");
                Console.WriteLine("- darkGray");
                Console.WriteLine("- darkGreen");
                Console.WriteLine("- darkMagenta");
                Console.WriteLine("- darkRed");
                Console.WriteLine("- darkYellow");
                Console.WriteLine("- gray");
                Console.WriteLine("- green");
                Console.WriteLine("- red");
                Console.WriteLine("- magenta");
                Console.WriteLine("- yellow");
                Console.WriteLine("- white");
                Console.WriteLine("enter the color: ");
                Console.Write("--> ");
                var color_input = Console.ReadLine();

                if (color_input == "t-black")
                {
                    Console.ForegroundColor = ConsoleColor.Black;

                }
                else if (color_input == "t-blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (color_input == "t-cyan")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (color_input == "t-darkBlue")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (color_input == "t-darkCyan")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                else if (color_input == "t-darkGray")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else if (color_input == "t-darkGreen")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else if (color_input == "t-darkMagenta")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                else if (color_input == "t-darkRed")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else if (color_input == "t-darkYellow")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else if (color_input == "t-gray")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (color_input == "t-green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (color_input == "t-red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (color_input == "t-magenta")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (color_input == "t-yellow")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (color_input == "t-white")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (color_input == "b-black")
                {
                    Console.BackgroundColor = ConsoleColor.Black;

                }
                else if (color_input == "b-blue")
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else if (color_input == "b-cyan")
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else if (color_input == "b-darkBlue")
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                else if (color_input == "b-darkCyan")
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                }
                else if (color_input == "b-darkGray")
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                }
                else if (color_input == "b-darkGreen")
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else if (color_input == "b-darkMagenta")
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                }
                else if (color_input == "b-darkRed")
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                else if (color_input == "b-darkYellow")
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else if (color_input == "b-gray")
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                else if (color_input == "b-green")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else if (color_input == "b-red")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else if (color_input == "b-magenta")
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                }
                else if (color_input == "b-yellow")
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                else if (color_input == "b-white")
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
            }

            else if (input == "bios")
            {
                Console.Clear();
                Console.WriteLine("Welcome to MasterOS BIOS");
                Console.WriteLine("                                 ########  ########");
                Console.WriteLine("             ######## #####    ###    ### ###    ##");
                Console.WriteLine("              ######### ####  ##      ### ######   ");
                Console.WriteLine("              ###  ###  #### ###     ###    ###### ");
                Console.WriteLine("             ###  ###  #### ##     ### ##    ####  ");
                Console.WriteLine("             ################ ########  ########   ");
                Console.WriteLine("");
                Console.WriteLine("Type exit to return / help to see the commands");

                while (true)
                {
                    Console.Write("-=> ");
                    var bios_input = Console.ReadLine();

                    if (bios_input == "help")
                    {
                        Console.WriteLine("Commands: ");
                        Console.WriteLine("- ver-chk");
                        Console.WriteLine("- mos");
                        Console.WriteLine("- about_bios");
                        Console.WriteLine("- help");
                        Console.WriteLine("- exit");
                    }

                    else if (bios_input == "ver-chk")
                    {
                        Console.WriteLine("*===================*");
                        Console.WriteLine("Current BIOS version is v0.03");
                        Console.WriteLine("*===================*");
                    }

                    else if (bios_input == "mos")
                    {
                        Console.WriteLine("                     ########  ######## ");
                        Console.WriteLine(" ######## #####    ###    ### ###    ## ");
                        Console.WriteLine("  ######### ####  ##      ### ######    ");
                        Console.WriteLine("  ###  ###  #### ###     ###    ######  ");
                        Console.WriteLine(" ###  ###  #### ##     ### ##    ####   ");
                        Console.WriteLine(" ################ ########  ########    ");
                        Console.WriteLine("");
                    }

                    else if (bios_input == "about_bios")
                    {
                        Console.WriteLine("This BIOS is the additional part for MasterOS,");
                        Console.WriteLine("in further updates the BIOS will be the control panel for mOS.");
                        Console.WriteLine("You can edit your own MasterOS and share with us,");
                        Console.WriteLine("at gokhantahagpinar@gmail.com / akaytuna378@gmail.com");
                    }

                    else if (bios_input == "exit")
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("! Invalid BIOS command !");
                    }
                }
            }

            else if (input == "c-sharp")
            {
                Console.Clear();
                Console.WriteLine("C# is an Object Oriented programming language,");
                Console.WriteLine("It is a part of the C family and it can be used in many ways.");
                Console.WriteLine("In this project its used to create an OS via COSMOS");
                Console.WriteLine("Toolkit, You can create a OS too by downloading the peripherals.");
            }

            else if (input == "Lab0")
            {
                Console.WriteLine("---- Coming soon ----");
                Console.WriteLine(" _        _       __  ");
                Console.WriteLine("| | __ _ | |__   /  \\ ");
                Console.WriteLine("| |/ _` ||  _ \\ | () |");
                Console.WriteLine("|_|\\__/_||____/  \\__/ ");
                Console.WriteLine("");
            }

            else if (input == "otokarl")
            {
                Console.WriteLine("Otokarl is an Global Warming informator bot that helps people detect some situations like fires, factory wastes etc.");
                Console.WriteLine("If you want to get involved, you can contact gokhantahagpinar@gmail.com");
                Console.WriteLine("");
            }

            else if (input == "FAQs")
            {
                Console.WriteLine("Here are the FAQs (Frequently asked questions): ");
                Console.WriteLine("1- What is MasterOS");
                Console.WriteLine("2- How to create an OS");
                Console.WriteLine("3- What are these OSes");
                Console.Write("-=> ");
                var faq_input = Console.ReadLine();

                if (faq_input == "1")
                {
                    Console.WriteLine("MasterOS is an Operating System created by MasterCode Studios.");
                    Console.WriteLine("It is created with C# and established in 09.05.2023");
                    Console.WriteLine("You can contact the creators at gokhantahagpinar@gmail.com / akaytuna378@gmail.com");
                }

                else if (faq_input == "2")
                {
                    Console.WriteLine("You can create an O.S with languages like Assembly, C, C++");
                    Console.WriteLine("You might be thinking 'Then why does MasterOS used C# ?' because we want people to acces and modify it easily.");
                }

                else if (faq_input == "3")
                {
                    Console.WriteLine("The OSes are used to contact the hardware for using the software.");
                }

                else
                {
                    Console.WriteLine("!! Invalid Command !!");
                }

            }

            // WARNING THE COMMANDS BELOW IS STILL BEING TESTED, DO NOT INCLUDE TO YOUR VERSION !!

            else if(input == "sfs")
            {
                var available_space = fs.GetAvailableFreeSpace(@"0:\");
                Console.WriteLine("Available Free Space (Bytes): " + available_space);
            }

            else if(input == "fst")
            {
                var fs_type = fs.GetFileSystemType(@"0:\");
                Console.WriteLine("File System Type: " + fs_type);
            }

            else if(input == "lof")
            {
                var files_list = Directory.GetFiles(@"0:\");

                foreach (var file in files_list)
                {
                    Console.WriteLine(file);
                }

            }

            else if(input == "gdl")
            {
                var files_list = Directory.GetFiles(@"0:\");
                var directory_list = Directory.GetDirectories(@"0:\");

                foreach (var file in files_list)
                {
                    Console.WriteLine(file);
                }
                foreach (var directory in directory_list)
                {
                    Console.WriteLine(directory);
                }
            }

            else
            {
                Console.WriteLine("! Invalid Command !");
            }
        }
    }
}

