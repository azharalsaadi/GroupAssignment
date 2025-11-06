using Salalah_Sports_League.Models_D;

namespace Salalah_Sports_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Team team1 = new Team("Salalah Eagles", "Coach Hamza");
            Team team2 = new Team("Dhofar Lions", "Coach Azhar");

            team1.AddPlayer(new Player("yasmen", 20, "Forward"));
            team1.AddPlayer(new Player("Noor", 22, "Midfielder"));

            team2.AddPlayer(new Player("Sultan", 29, "Forward"));
            team2.AddPlayer(new Player("Elaf", 90, "Defender"));

            
            League league = new League("Salalah Annual Football League");
            league.AddTeam(team1);
            league.AddTeam(team2);

            
            Match match1 = new Match(team1, team2, 2, 1);
            Match match2 = new Match(team1, team2, 0, 0);

            league.AddMatch(match1);
            league.AddMatch(match2);

            
            Console.WriteLine("Match Results:");
            match1.PrintResult();
            match2.PrintResult();

          
            Console.WriteLine("\nLeague Standings:");
            league.ShowStandings();
        }
    }
}
