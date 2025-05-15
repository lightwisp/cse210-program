using System.Reflection;

public class Menu
{
    static string oldFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    static string folderPath = oldFolderPath.Replace(@"\bin\Debug\net8.0", "");
    public int mainMenu()
    {
        int[] allowed = {1,2,3,4,5,6};
        int answer;
        Console.WriteLine("1: Write\n2: Display\n3: Clear Loaded Text\n4: Load\n5: Save\n6: Quit");
        try{
            answer = int.Parse(Console.ReadLine());
            if (allowed.Contains(answer))
            {
                Console.Clear();
                Console.WriteLine("Loading...");
            }
            else
            {   
                Console.Clear();
                Console.WriteLine("Chose an apropriat option. 1,2,3,4,5,6");
            }
        }
        catch{
            Console.Clear();
            Console.WriteLine("Press an aviable action. 1,2,3,4,5,6");
            answer = 0;
        }
        return answer;
    }
    public int saveMenu()
    {
        int[] allowed = {1,2};
        int answer;
        Console.WriteLine("1: Save to an existing file\n2: Create a new file");
        try{
            answer = int.Parse(Console.ReadLine());
            if (allowed.Contains(answer))
            {
                Console.Clear();
            }
            else
            {   
                Console.Clear();
                Console.WriteLine("Chose an apropriat option. 1,2");
            }   
        }
        catch{
            Console.Clear();
            Console.WriteLine("Press an aviable action. 1,2");
            answer = 0;
        }
        return answer;
    }
    public string GetFileName()
    {
        string fileName;

        Console.WriteLine("What is the name of you file? Example: Text.txt");
        fileName = Console.ReadLine();

        return fileName;
    }
    public string FindFolder()
    {
        return folderPath;
    }
    public string FindFiles()
    {  
        string[] textFiles = Directory.GetFiles(folderPath, "*.txt");
        List<string> existingFiles = new List<string>();
        int loop = 0;
        foreach (string file in textFiles)
        {
            loop += 1;
            string fileName = file.Replace(folderPath+@"\", "");
            existingFiles.Add(fileName);
            Console.WriteLine($"{loop}: " + fileName);
        }
        Console.WriteLine("What file do you want?");
        int index = existingFiles.Count();
        int answer = int.Parse(Console.ReadLine()) - 1;
        
        string chosenFile = existingFiles[answer];
            
       
        return chosenFile;
    }
    
}