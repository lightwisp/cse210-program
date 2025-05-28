using System.Reflection;
public class Coment()
{
    private string _name;
    private string _coment;
    
    static string oldFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    static string  filePath = oldFolderPath.Replace(@"\bin\Debug\net8.0", "");
    private string[] files = Directory.GetFiles(filePath, "*.csv");
    public int CountComments(string videoName)
    {
        int numberOfComents = 0;
        string trueName = filePath + @"\" + videoName + ".csv";
        foreach (string file in files)
        {
            if (trueName == file)
            {
                string csvFiles = trueName;
                foreach (string line in File.ReadLines(csvFiles).Skip(1))
                {
                    numberOfComents++;
                }
            }
            
        }
        return numberOfComents;
    }
    public void CreateCSVFile(string videoName)
    {
        string newFile = filePath + "/" + videoName + ".csv";

        using (StreamWriter writer = new StreamWriter(newFile))
        {
            writer.WriteLine("name,Comment");
        }
    }
    public void CreateComment(string videoName, string userName,string comment)
    {
        string existingFile = filePath + "/" + videoName + ".csv";
        using (StreamWriter writer = new StreamWriter(existingFile, append: true))
        {
            writer.WriteLine($"{userName},{comment}");
        }
    }
    public void DisplayVideoComments(string videoName)
    {
        string trueName = filePath + @"\" + videoName + ".csv";
        foreach (string file in files)
        {
            if (trueName == file)
            {
                string csvFiles = file;
                foreach (string line in File.ReadLines(csvFiles).Skip(1))
                {
                    string[] parts = line.Split(",");

                    _name = parts[0].Trim();
                    _coment = parts[1].Trim();
                    Console.WriteLine($"  {_name}:\n    ~{_coment}\n");
                }
            }
        }
    }
}