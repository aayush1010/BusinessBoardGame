using BusinessHouseGame.Helper;
using System.Collections.Generic;

namespace BusinessHouseGame.Entities
{
    class Player
    {
        private int amount;
        private int position;
        private readonly int id;
        private List<HotelCell> hotelOwns;

        public Player(int id)
        {
            this.id = id;
            this.amount = Constants.Constants.PlayerInitialAmount;
            position = 0;
            hotelOwns = new List<HotelCell>();
        }

        public int GetPlayerId()
        {
            return this.id;
        }

        public int GetPlayerBalance() 
        {
            return this.amount;
        }

        public void AddHotelOwned(HotelCell hotel)
        {
            this.hotelOwns.Add(hotel);
        }

        public int UpdatePlayerPosition(int diceNumber, int boardSize)
        {
            this.position = ((this.position + diceNumber) - 1) % boardSize;
            return this.position;
        }

        public void AddPlayerBalance(int amount)
        {
            this.amount += amount;
        }

        public void DeductPlayerBalance(int amount) 
        {
            this.amount -= amount;
        }

        public int GetAssetAmount() 
        {
            var assetAmount = 0;
            foreach (var hotel in hotelOwns) 
            {
                assetAmount += hotel.GetHotelType().GetHotelValue();
            }
            return assetAmount;
        }
    }
}
