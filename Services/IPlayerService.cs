using RugbyPlayerQuiz.Models;

namespace RugbyPlayerQuiz.Services;

public interface IPlayerService
{
    List<Player> GetPlayers();
    Player GetRandomPlayer();
    List<Player> GetRandomOptions(Player correctPlayer, int count);
    string GetPlayerStatus(int score);
}