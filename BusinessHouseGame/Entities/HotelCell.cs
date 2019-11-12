using BusinessHouseGame.Helper;
using static BusinessHouseGame.Constants.Enums;

namespace BusinessHouseGame.Entities
{
    class HotelCell : Cell
    {
        private HotelType hotelType;
        private Player ownBy;

        public HotelCell()
        {
            hotelType = HotelType.Silver;
        }

        public HotelType GetHotelType() 
        {
            return hotelType;
        }

        private void UpdateHotelOwner(Player player) 
        {
            ownBy = player;
        }

        private void UpdateHotelType(HotelType hotelType)
        {
            this.hotelType = hotelType;
        }

        private bool CanUpdateHotelType(Player player, HotelType hotelType) 
        {
            return this.hotelType != HotelType.Platinium && player.GetPlayerBalance() > hotelType.AmountToUpdateHotel();
        }

        private void CheckAndUpdateHotelType(Player player, Bank bank) 
        {
            if (CanUpdateHotelType(player, hotelType)) 
            {
                var hotelDeltaValue = hotelType.AmountToUpdateHotel();
                player.DeductPlayerBalance(hotelDeltaValue);
                bank.AddBankBalance(hotelDeltaValue);
                UpdateHotelType(hotelType++);
            }
        }

        public override void ExecuteCellOperation(Player player, Bank bank)
        {
            if (ownBy == null)
            {
                UpdateHotelOwner(player);
                player.AddHotelOwned(this);
                player.DeductPlayerBalance(Constants.Constants.SilverHotelValue);
                bank.AddBankBalance(Constants.Constants.SilverHotelValue);
            }
            else 
            {
                var playerLanded = player.GetPlayerId();
                if (playerLanded == ownBy.GetPlayerId())
                {
                    CheckAndUpdateHotelType(player, bank);
                }
                else 
                {
                    var rentAmount = this.hotelType.GetRentAmount();
                    player.DeductPlayerBalance(rentAmount);
                    ownBy.AddPlayerBalance(rentAmount);
                }
            }
        }
    }
}
