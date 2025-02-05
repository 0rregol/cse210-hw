class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Dennis Thresh Fong on Computer Chronicles - Q3 and CS", "PhobosLaboratory", 311);
        Video video2 = new Video("The First Pro Gamer Ever - Dennis Thresh Fong that won a Ferrari in 1997", "QCP", 444);
        Video video3 = new Video("The History of Quake", "GameSpot", 745);

       
        video1.AddComment(new Comment("w04h", "After 24 years CS is still alive and well, insane"));
        video1.AddComment(new Comment("samfrankenstein", "He is the grandfather of all esports Players"));
        video1.AddComment(new Comment("kanivakil198", "Alright Dennis thanks a lot. It really sounded like he didn't have a clue or cared what was being said and was really glad to end the interview lol.."));

        video2.AddComment(new Comment("Proutt", "Absolute legend"));
        video2.AddComment(new Comment("gosterV3a", "dude didn't aged at all..."));
        video2.AddComment(new Comment("kuyavalcrist1736", "Bow down to the originator of WASD movement, Dennis Thresh Fong."));
        video2.AddComment(new Comment("oldnait", "Fight of makaveli immortal and thresh was amazing."));
        video2.AddComment(new Comment("swankieOW", "respect."));

        
        video3.AddComment(new Comment("andreiwayneandrewbrucewayn3421", "I have the entire Quake games series and I love em' all,especially the first Quake and Quake 2! Quake 3 Arena is special because it has all the characters from different timelines and worlds.Quake 4 continues the storyline from Quake 2 and it rocks."));
        video3.AddComment(new Comment("00Mindi00", "Correction guys: Half Life was NOT built on a modified Quake 2 engine, but a modified Quake 1 engine."));
        video3.AddComment(new Comment("drancov", "No wonder why the theme of Quake 1 never came back T_T I loved that style and Trent's soundtrack."));

        
        List<Video> videos = new List<Video> { video1, video2, video3 };

        
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
