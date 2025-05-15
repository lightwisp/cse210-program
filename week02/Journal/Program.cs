using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Reflection;


// the extra stuff i added was a clear jornalchas incase you want to save to multiple files but not the same text entries.
// i also added a dynamic .txt file surch function that grabs the curent running programs file location
// trims it to be the journal folder and serches for .txt files and displays them in the menu so you
// dont have to type them in and remember them every time you want to add an entry to an existing file.

class Program
{   
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        Menu menu = new Menu();
        string fileName;
        string folderPath;
        bool on = true;
        // looping untill user quits
        while (on)
        {
           Entry entry = new Entry(); 
           int answer = menu.mainMenu();
           switch(answer)
           {    
                //Writing to Jornal
                case 1:
                    entry._curentDate = entry.SetDate();
                    entry._prompt = prompt.GetPrompt();
                    entry._passage = Console.ReadLine();
                    journal._entries.Add(entry);
                    break;
                // Display what has been writen and Loaded
                case 2:
                    try{
                        journal.DisplayEntrys();
                    }
                    catch{
                        Console.WriteLine("No Text to Display...");
                    }
                    break;
                // Clear jornal list
                case 3:

                    Console.WriteLine("Erasing your Jornel Entries Cash...\n");
                    journal.ClearCash();
                    break;
                // Load Files
                case 4:
                    string chosenFile = menu.FindFiles();
                    folderPath = menu.FindFolder();
                    fileName = $@"{folderPath}\{chosenFile}";
                    string[] lines = System.IO.File.ReadAllLines(fileName);
                    
                    foreach (string line in lines)
                    {
                        Entry loadedEntry = new Entry();
                        string[] parts = line.Split("-");
                        loadedEntry._curentDate = parts[0];
                        loadedEntry._prompt = parts[1];
                        loadedEntry._passage = parts[2];
                        journal._entries.Add(loadedEntry);
                    }     
                    break;
                // save files
                case 5:
                    answer = menu.saveMenu();
                    // save to existing file
                    if (answer == 1)
                    {
                        fileName = menu.FindFiles(); 
                        folderPath = menu.FindFolder();
                        string trueFilePath = folderPath + @"\" + fileName;
                        Console.WriteLine($"Saving file too: {Path.GetFullPath(trueFilePath)}");
                        using (StreamWriter writer = new StreamWriter(trueFilePath, append: true))
                        {
                            foreach (Entry passage in journal._entries)
                            {
                                writer.WriteLine($"{passage._curentDate}-{passage._prompt}-{passage._passage}");
                            }
                        }
                    }
                    // creat new file
                    if (answer == 2)
                    {
                        fileName = menu.GetFileName();
                        folderPath = menu.FindFolder();
                        string trueFilePath = folderPath + @"\" + fileName;
                        Console.WriteLine($"Saving file too: {Path.GetFullPath(trueFilePath)}");
                        using (StreamWriter writer = new StreamWriter(trueFilePath))
                        {
                            foreach (Entry passage in journal._entries)
                            {
                                writer.WriteLine($"{entry._curentDate}-{entry._prompt}-{entry._passage}");
                            }
                        }
                    }  
                    break;
                // Quit Program
                case 6:
                    Console.WriteLine("Good Bye");
                    Environment.Exit(0);
                    break;
           }

        }
        
        
        
  
    }
}