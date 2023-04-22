using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashish
{
    public class BankAcount
    {
        public static void Main(string[] args)
        {
            // MySuperBank ashishAccount = new MySuperBank("Ashish",10000000);
            // ashishAccount.MakeDiposit(100.00,"12/12/2012" ,"add");
            var acount =new MySuperBank("Ashish",10000000);
            // var acount2 =new MySuperBank("Ashu",20000000);
            // Console.WriteLine($"My number : {acount.Number}, balance : {acount.Balance}, Owner : {acount.Owner}");
            // Console.WriteLine($"My number : {acount2.Number}, balance : {acount2.Balance}, Owner : {acount2.Owner}");
          // acount.MakeDiposit(10000,DateTime.Now,"Ashish");        
            //Console.WriteLine(acount.Balance);
            // Console.WriteLine(acount.Balance+ acount.Owner);
            //acount.MakeDiposit(100.00,"12/12/2012" ,"add");
             acount.MakeWithdrawal(200000,DateTime.Now,"Ashish");        
            Console.WriteLine(acount.Balance);


            Console.WriteLine(acount.GetAccountHistory());
              
              try
              { 
                var invalidAcount = new MySuperBank("invalid",-55);
              }
               catch(ArgumentOutOfRangeException e)
               {
                 Console.WriteLine("Exception caught creating account with negative balence");
                 Console.WriteLine(e.ToString());
               }
                acount.MakeWithdrawal(50,DateTime.Now,"Abc");        
            Console.WriteLine(acount.Balance);
              



               
               
                }
    }
}