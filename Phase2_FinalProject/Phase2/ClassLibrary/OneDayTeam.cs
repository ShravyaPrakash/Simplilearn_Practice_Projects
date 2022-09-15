using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary;

public class OneDayTeam : Player, ITeam
{
    public static List<Player> oneDayTeam = new List<Player>();
    public OneDayTeam()
    {
        oneDayTeam.Capacity = 11;
    }
    public void Add(Player player)
    {
        oneDayTeam.Add(player);
    }
    public void Remove(int playerId)
    {
        Player p = null;

        foreach (var i in oneDayTeam)
        {
            if (i.PlayerId == playerId)
            {
                Console.WriteLine("Player{0} details is removed successfully", i.PlayerId);
                p = i;
            }
        }
        oneDayTeam.Remove(p);
    }
    public Player GetPlayerById(int playerId)
    {
        Player p = null;

        foreach (var i in oneDayTeam)
        {
            if (i.PlayerId == playerId)
            {
                p = i;
                break;
            }
            else
            {
                Console.WriteLine("Player ID not found.");
            }
        }
        return p;
    }
    public Player GetPlayerByName(string playerName)
    {
        Player p = null;

        foreach (var i in oneDayTeam)
        {
            if (i.PlayerName == playerName)
            {
                p = i;
                break;
            }
            else
            {
                Console.WriteLine("Player Name not found.");
            }
        }
        return p;
    }

    public List<Player> GetAllPlayers()
    {
        return oneDayTeam;
    }
}