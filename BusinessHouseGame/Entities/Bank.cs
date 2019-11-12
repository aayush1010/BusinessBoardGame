namespace BusinessHouseGame.Entities
{
    class Bank
    {
        private int amount;

        public Bank()
        {
            amount = Constants.Constants.BankInitialAmount;
        }

        public void AddBankBalance(int amount)
        {
            this.amount += amount;
        }

        public void DeductBankBalance(int amount)
        {
            this.amount -= amount;
        }

        public int GetBankBalance() 
        {
            return amount;
        }
    }
}
