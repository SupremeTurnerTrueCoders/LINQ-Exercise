//using LINQExercise2;




List<string> videoGames = new List<string>(){"Call Of Duty","NBA 2K", "NFL Madden", "UFC"};

 var OrderedGames = videoGames.OrderBy(name => name.Length);

foreach (var game in OrderedGames)
{
    Console.WriteLine(game);
}