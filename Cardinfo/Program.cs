namespace Cardinfo
{
    class DebitCard
    {
        public string CardNum { get; set; }
        public string Cardholder { get; set; }
        public string ExpDate { get; set; }
        public string CVV { get; set; }
        public string Company { get; set; }

        public decimal Balance { get; set; }

        public void CashIn(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Daxil edilen mebleg yalnısdır.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Daxil edilen mebleg {amount:C} teskil edir. Balans: {Balance:C}");

        }

        public void MakeWithdrawal(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Qeyd edilen mebleg yalnısdır.");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Hesabda kifayet qeder vesait yoxdur.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"Mexaric edilen mebleg {amount:C} teskil edir. Balans: {Balance:C}");

        }
        public override string ToString()
        {
            return $"Company: {this.Company}, " +
                $"Cardholder: {this.Cardholder}, ExpDate: {this.ExpDate}, " +
                $"CVV: {this.CVV}, CardNum: {this.CardNum}, " +
                $"Balance: {this.Balance}";
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
           DebitCard myDebitCard = new DebitCard();

            myDebitCard.Company = "Bank Respublika";
            myDebitCard.CardNum = "1234567891011213";
            myDebitCard.Cardholder = "Yaqubov Namiq";
            myDebitCard.ExpDate = "05/25";
            myDebitCard.CVV = "123";
            myDebitCard.Balance = 850.00m;

            
            decimal cashInAmount = 2000.00m;
            decimal WithdrawalAmount = 200.00m;

            myDebitCard.CashIn(cashInAmount);
            myDebitCard.MakeWithdrawal(WithdrawalAmount);

            
            Console.WriteLine(myDebitCard);

        }
    }
}