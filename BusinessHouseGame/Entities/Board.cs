using BusinessHouseGame.Factory;
using System;
using System.Collections.Generic;

namespace BusinessHouseGame.Entities
{
    class Board
    {
        private readonly List<Cell> board;
        private readonly List<Player> players;
        private readonly Bank bank;
        private readonly int boardSize;
        private readonly CellFactory cellFactory;

        public Board(List<Player> players, Bank bank, string cellTypes)
        {
            this.players = players;
            this.bank = bank;
            cellFactory = new CellFactory();
            board = CreateBoard(cellTypes);
            boardSize = board.Count;
        }

        private List<Cell> CreateBoard(string cellTypes)
        {
            List<Cell> boardCell = new List<Cell>();
            int position = 1;
            try
            {
                var boardStructure = cellTypes.Split(Constants.Constants.Splitter);
                foreach (var cell in boardStructure)
                {
                    boardCell.Add(cellFactory.CreateCell(Convert.ToChar(cell)));
                    position++;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return boardCell;
        }

        private void PrintResult()
        {
            foreach (var player in players)
            {
                Console.WriteLine("Player " + player.GetPlayerId() + "has total money" + player.GetPlayerBalance() + "and asset amount : " + player.GetAssetAmount());
            }
            Console.WriteLine("Balance at bank : " +  bank.GetBankBalance());
        }

        public void PlayGame(List<int> diceOutputs)
        {
            for (int diceOutputIndex = 0; diceOutputIndex < diceOutputs.Count;)
            {
                foreach (var player in players)
                {
                    var udpatedPosition = player.UpdatePlayerPosition(diceOutputs[diceOutputIndex], boardSize);
                    var cell = board[udpatedPosition];
                    cell.ExecuteCellOperation(player, bank);
                    diceOutputIndex++;
                }
            }

            PrintResult();
        }
    }
}
