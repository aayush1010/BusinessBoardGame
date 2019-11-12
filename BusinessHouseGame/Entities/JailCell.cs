namespace BusinessHouseGame.Entities
{
    class JailCell : Cell
    {
        public override void ExecuteCellOperation(Player player, Bank bank)
        {
            player.DeductPlayerBalance(Constants.Constants.JailAmountToBeDeducted);
            bank.AddBankBalance(Constants.Constants.JailAmountToBeDeducted);
        }
    }
}
