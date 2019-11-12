using static BusinessHouseGame.Constants.Enums;

namespace BusinessHouseGame.Helper
{
    static class HotelHelper
    {
        public static int AmountToUpdateHotel(this HotelType fromHotelType) 
        {
            if (fromHotelType == HotelType.Silver)
            {
                return Constants.Constants.GoldHotelValue - Constants.Constants.SilverHotelValue;
            }
            else if (fromHotelType == HotelType.Gold)
            {
                return Constants.Constants.PlatiniumHotelValue - Constants.Constants.GoldHotelValue;
            }
            else 
            {
                return default(int);
            }
        }

        public static int GetRentAmount(this HotelType hotelType) 
        {
            if (hotelType == HotelType.Silver)
            {
                return Constants.Constants.SilverHotelRent;
            }
            else if (hotelType == HotelType.Gold)
            {
                return Constants.Constants.GoldHotelRent;
            }
            else
            {
                return Constants.Constants.PlatiniumHotelRent;
            }
        }

        public static int GetHotelValue(this HotelType hotelType)
        {
            if (hotelType == HotelType.Silver)
            {
                return Constants.Constants.SilverHotelValue;
            }
            else if (hotelType == HotelType.Gold)
            {
                return Constants.Constants.GoldHotelValue;
            }
            else
            {
                return Constants.Constants.PlatiniumHotelValue;
            }
        }
    }
}
