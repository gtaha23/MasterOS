using System;
using System.Text;
using Sys = Cosmos.System;

namespace MamacOS
{
    public class Kernel : Sys.Kernel
    {
        Sys.FileSystem.CosmosVFS fs;
        string current_directory = "0:\\";
        protected override void BeforeRun()
        {
            fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);

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
                Console.WriteLine("Last stable version is -> v0.4.3 ");
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
                Console.WriteLine("-> waf");
                Console.WriteLine("-> raf");
                Console.WriteLine("-> cad");
                Console.WriteLine("-> dad");
                Console.WriteLine("-> logs");
                Console.WriteLine("-> FAQs");
                Console.WriteLine("=====Game Zone=====");
                Console.WriteLine("-> Lab0");
            }

            else if (input == "about")
            {
                Console.WriteLine("MasterOS is an TUI based small but stable Operating System.");
                Console.WriteLine("This OS is currently being developed by mOS, and the project is open source.");
                Console.WriteLine("Current version of it is v0.4.1  .");
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
                Console.WriteLine("The OS is built by COSMOS using C#,");
                Console.WriteLine("It is an FOSS project and can be edited by its users freely!");
                Console.WriteLine("The Dev team wants the satisfaction of the users, not money.");
                Console.WriteLine("And again we say, Thanks for choosing mOS !");
            }

            else if (input == "oldfetch")
            {
                Console.Clear();
                Console.WriteLine("                    ########  ########    OS Name: MasterOS");
                Console.WriteLine("######## #####    ###    ### ###    ##    Kernel Version: v0.23");
                Console.WriteLine(" ######### ####  ##      ### ######       Creator: MasterCode Studios");
                Console.WriteLine(" ###  ###  #### ###     ###    ######     Current Version: v0.4.3");
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
                Console.WriteLine(" 30 commands currently available");
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
                Console.WriteLine("Type exit to quit FAQs menu");
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

                else if(faq_input == "exit")
                {
                    Console.WriteLine("Exiting. . . ");
                }

                else
                {
                    Console.WriteLine("!! Invalid Command !!");
                }

            }


            else if(input == "sfs")
            {
                try
                {
                    string drive = @"0:\"; 
                    long availableSpace = Sys.FileSystem.VFS.VFSManager.GetAvailableFreeSpace(drive);
                    Console.WriteLine($"Available Free Space: {availableSpace / (1024 * 1024)} MB");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error retrieving available space: {ex.Message}");
                }
            }

            else if(input == "fst")
            {
                try
                {
                    var fileSystemType = Sys.FileSystem.VFS.VFSManager.GetFileSystemType(current_directory);
                    Console.WriteLine($"File System Type: {fileSystemType}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error retrieving file system type: {ex.Message}");
                }
            }

            else if(input == "lof")
            {
                try
                {
                    string directory = "0:\\";

                    if (!Sys.FileSystem.VFS.VFSManager.DirectoryExists(directory))
                    {
                        Console.WriteLine($"Directory '{directory}' not found.");
                        return;
                    }

                    var directoryEntries = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(directory);

                    bool filesFound = false;
                    foreach (var entry in directoryEntries)
                    {
                        if (entry.mSize > 0) 
                        {
                            Console.WriteLine($"File: {entry.mName}");
                            filesFound = true;
                        }
                    }

                    if (!filesFound)
                    {
                        Console.WriteLine("No files found in the directory.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error listing files: {ex.Message}");
                }

            }

            else if(input == "gdl")
            {
                try
                {
                    var directoryPath = @"0:\\"; 
                    var entries = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(directoryPath);

                    Console.WriteLine("Directory Listing:");
                    foreach (var entry in entries)
                    {
                        if (entry.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.File)
                        {
                            Console.WriteLine($"File: {entry.mName}");
                        }
                        else if (entry.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.Directory)
                        {
                            Console.WriteLine($"Directory: {entry.mName}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error retrieving directory listing: {ex.Message}");
                }
            }

            else if (input == "waf")
            {
                try
                {
                    Console.Write("Enter file path (e.g., 0:\\filename.txt): ");
                    string path = Console.ReadLine();

                    Console.Write("Enter content to write: ");
                    string content = Console.ReadLine();

                    var file = Sys.FileSystem.VFS.VFSManager.GetFile(path);
                    if (file == null)
                    {
                        Sys.FileSystem.VFS.VFSManager.CreateFile(path);
                        file = Sys.FileSystem.VFS.VFSManager.GetFile(path);
                    }

                    using (var stream = file.GetFileStream())
                    {
                        stream.Position = 0;

                        byte[] contentBytes = Encoding.ASCII.GetBytes(content);
                        stream.Write(contentBytes, 0, contentBytes.Length);

                        stream.SetLength(contentBytes.Length);
                    }

                    Console.WriteLine($"Successfully wrote to file: {path}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error writing to file: {ex.Message}");
                }
            }

            else if (input == "raf")
            {
                try
                {
                    Console.Write("Enter file path (e.g., 0:\\filename.txt): ");
                    string path = Console.ReadLine();

                    var file = Sys.FileSystem.VFS.VFSManager.GetFile(path);
                    if (file == null)
                    {
                        Console.WriteLine("File not found.");
                        return;
                    }

                    using (var stream = file.GetFileStream())
                    {
                        byte[] buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, (int)stream.Length);

                        string content = Encoding.ASCII.GetString(buffer);

                        Console.WriteLine($"Contents of {path}: ");
                        Console.WriteLine(content);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading from file: {ex.Message}");
                }
            }

            else if(input == "daf")
            {
                try
                {
                    Console.Write("Enter file path (e.g., 0:\\filename.txt): ");
                    string path = Console.ReadLine();

                    var file = Sys.FileSystem.VFS.VFSManager.GetFile(path);
                    if (file == null)
                    {
                        Console.WriteLine("File doesn't exist / empty");
                        return;
                    }

                    Sys.FileSystem.VFS.VFSManager.DeleteFile(path);
                    Console.WriteLine($"{path} succesfully deleted !");
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting the file! {ex.Message}");
                }
            }

            else if(input == "dad")
            {
                try
                {
                    bool choice = false;
                    Console.Write("Enter directory path (e.g., 0:\\directoryname): ");
                    string path = Console.ReadLine();
                    Console.Write("Are you sure? (y/n): ");
                    string x = Console.ReadLine().ToLower();
                    if (x == "y")
                    {
                        choice = true;
                    }
                    else
                    {
                        choice = false;
                    }

                    var dir = Sys.FileSystem.VFS.VFSManager.GetDirectory(path);
                    if (!Sys.FileSystem.VFS.VFSManager.DirectoryExists(path))
                    {
                        Console.WriteLine("Directory does not exists!! ");
                        return;
                    }

                    var files = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(path);
                    if (files.Count > 0)
                    {
                        Console.WriteLine($"Directory is not empty: {path}");
                        return;
                    }

                    Sys.FileSystem.VFS.VFSManager.DeleteDirectory(path, choice);
                    Console.WriteLine($"Successfully removed directory: {path}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error removing directory: {ex.Message}");
                }

            }

            else if(input == "cad")
            {
                try
                {
                    Console.Write("Enter the directory path to create (e.g., 0:\\newdirectory): ");
                    string path = Console.ReadLine();

                    if (Sys.FileSystem.VFS.VFSManager.DirectoryExists(path))
                    {
                        Console.WriteLine($"Directory already exists: {path}");
                        return;
                    }

                    Sys.FileSystem.VFS.VFSManager.CreateDirectory(path);
                    Console.WriteLine($"Successfully created directory: {path}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating directory: {ex.Message}");
                }
            }

            else if(input == "don pollo")
            {
                Console.Clear();
                Console.WriteLine("Lingangu lingangu lingan lingan guu,");
                Console.WriteLine("Lingan guli guli wacha lingan lingangu HEY !");
            }

            // Don't forget to add the new versions
            else if(input == "logs")
            {
                Console.WriteLine("------ Batchfile O.S ------");
                Console.WriteLine("First Creation / 19.04.2024 \\");
                Console.WriteLine("v0.0.1 / 21.04.2024 \\");
                Console.WriteLine("v0.0.2 / 26.05.2024 \\");
                Console.WriteLine("v0.0.3 / 12.06.2024 \\");
                Console.WriteLine("v0.0.4 - v0.0.6 / 13.06.2024 \\");
                Console.WriteLine("v0.0.7 - v0.0.8 / 14.06.2024 \\");
                Console.WriteLine("v0.0.9 / 15.06.2024 \\");
                Console.WriteLine("v0.1.0 / 17.06.2024 \\");
                Console.WriteLine("v0.1.1 - v0.1.2 / 22.06.2024 \\");
                Console.WriteLine("v0.1.3 - v0.1.4 / 23.06.2024 \\");
                Console.WriteLine("v0.1.5 / 24.06.2024 \\");
                Console.WriteLine("v0.1.6 / 26.06.2024 \\");
                Console.WriteLine("v0.1.7 / 28.06.2024 \\");
                Console.WriteLine("v0.1.8 / 30.06.2024 \\");
                Console.WriteLine("v0.1.9 / 01.07.2024 \\");
                Console.WriteLine("v0.2.0 / 02.07.2024 \\");
                Console.WriteLine("v0.2.1 / 03.07.2024 \\");
                Console.WriteLine("v0.2.2 - v0.2.4 / 04.07.2024 \\");
                Console.WriteLine("v0.2.5 - v0.2.7 / 05.07.2024 \\");
                Console.WriteLine("v0.2.8 / 06.07.2024 \\");
                Console.WriteLine("v0.2.9 / 09.07.2024 \\");
                Console.WriteLine("v0.3.0 - v0.3.1 / 28.07.2024 \\");
                Console.WriteLine("v0.3.2 - v0.3.4 / 29.07.2024 \\");
                Console.WriteLine("v0.3.5 - v0.3.7 / Migration to C# \\");
                Console.WriteLine("------ C-Sharp O.S ------");
                Console.WriteLine("v0.3.8 / 13.10.2024 \\");
                Console.WriteLine("v0.3.9 Alpha / 11.11.2024 \\");
                Console.WriteLine("v0.4.0 - v0.4.1 / 23.11.2024 \\");
                Console.WriteLine("v0.4.2 - v0.4.3 / 24.11.2024 \\");
                Console.WriteLine("Coming Soon...");
                Console.WriteLine("");
            }

            else
            {
                Console.WriteLine("! Invalid Command !");
            }
        }
    }
}

