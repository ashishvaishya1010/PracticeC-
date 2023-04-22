using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Ashish
{
    public class MySuperBank
    {
        public string Number {get;}
        public string Owner{get;set;}
        public decimal  Balance{ 
            get
            {
                decimal balance=0;
                foreach(var item in allTransaction)
                {
                    balance +=item.Amount;
                }
                return balance;
}
}

        private static int accountNumberSeed = 1234567890;

        private List<Transaction>allTransaction= new List<Transaction>();
         
        public MySuperBank(string name ,decimal intialBalance){
            this.Owner=name;
           MakeDiposit(intialBalance,DateTime.Now,"Initial  Balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDiposit(decimal amount,DateTime date ,string note)
        {
            if(amount<=0){
                throw new ArgumentOutOfRangeException(nameof(amount),"Amount of withdrawal must be positive ");
                }
            if (Balance-amount<0)
            {
                throw new IndexOutOfRangeException("NO sufficient funds for this withdrawal");
            }
            var withdrawal=new Transaction(-amount,date ,note);
            allTransaction.Add(withdrawal);
        }
        public void MakeWithdrawal(decimal amount ,DateTime date ,string note ){
            Console.WriteLine("Withdraw");
        }


        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date\t\tAmount\tNote");
            foreach(var item in allTransaction){

                report.AppendLine($"{item.Date}\t{item.Amount}\t{item.Notes}");
            }
            return report.ToString();

    }
}}