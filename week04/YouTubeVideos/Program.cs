using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video01 = new Video("Banjo_Wild", "Lets try and be a hero!", 124, 20, 42);
        video01.MakeComment("Jimmy", "Hey this is a good video");
        video01.MakeComment("Samuel", "first time commenting.");
        video01.MakeComment("Kilow", "I have alwasy wanted to be a hearo");
        video01.MakeComment("Julia_Miles", "Have you ever wondered what it is like to die");
        video01.MakeComment("Mark_Whezzer", "The best hero, is James bond");

        Video video02 = new Video("HelloKitty", "WHY DO I KEEP DYING!!", 525, 30, 22);
        video02.MakeComment("Bainless", "Maybeyou should just not die?");
        video02.MakeComment("Hisenburg", "How about we stop playing games");
        video02.MakeComment("Brandon", "THank you for the video!");
        video02.MakeComment("Bill_ny_the_science_guy", "I loved when you blew up into pices");

        Video video03 = new Video("RED_STONE_GUY", "How to make a 3x3 piston door", 1545, 35, 15);
        video03.MakeComment("redStoneLover", "This really helped me thank you!");
        video03.MakeComment("Scrach", "Why dose mine nott worrrrkkkk!!!");
        video03.MakeComment("U_U", "This is way harder than it looks.");

        
        video01.DisplayVideoComments();
        video02.DisplayVideoComments();
        video03.DisplayVideoComments();
        
        Console.WriteLine("End of program");
   
    }
}