using BusinessHouseGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessHouseGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Player> players = new List<Player>();
                for (int playerId = 1; playerId <= Constants.Constants.PlayerCount; playerId++)
                {
                    players.Add(new Player(playerId));
                }

                Bank bank = new Bank();

                Board board = new Board(players, bank, Constants.Constants.BoardStructure);

                var diceOutputs = Constants.Constants.DiceOutputs.Split(',').Select(x => Convert.ToInt32(x)).ToList();
                board.PlayGame(diceOutputs);
                Console.ReadLine();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
