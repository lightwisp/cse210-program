using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTital = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 1999;
        job1._endYear = 2005;
       

        Job job2 = new Job();
        job2._jobTital = "Developer";
        job2._company = "Apple";
        job2._startYear = 2006;
        job2._endYear = 2015;
        
        
        Resume resume = new Resume();
        resume._name = "Dylan Sayer";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.ReturnResume();
    }

}