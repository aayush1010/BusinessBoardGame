using BusinessHouseGame.Entities;
using System;

namespace BusinessHouseGame.Factory
{
    class CellFactory
    {
        public Cell CreateCell(char cellType) 
        {
            Cell cell;
            switch (cellType) 
            {
                case 'J':
                    cell = new JailCell();
                    break;
                case 'H':
                    cell = new HotelCell();
                    break;
                case 'L':
                    cell = new LotteryCell();
                    break;
                case 'E':
                    cell = new EmptyCell();
                    break;
                default:
                    throw new Exception("Invalid Cell Type In Cell List");
            }
            return cell;
        }
    }
}
