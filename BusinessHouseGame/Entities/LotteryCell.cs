namespace BusinessHouseGame.Entities
{
    class LotteryCell : Cell
    {
        public override void ExecuteCellOperation(Player player, Bank bank)
        {
            player.AddPlayerBalance(Constants.Constants.LotteryAmountToBeAdded);
            bank.DeductBankBalance(Constants.Constants.LotteryAmountToBeAdded);
        }
    }
}
