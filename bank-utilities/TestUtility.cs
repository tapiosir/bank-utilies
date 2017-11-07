using System;
using System.Text;

namespace  Ekoodi.Utilities.Test 
{
    public static class TestUtility
    {

        public static void Validator()
        {

            StringBuilder bban = new StringBuilder();
            Console.WriteLine("please enter an account number");
            string bbanInput = Console.ReadLine();
            string remove;
            string removeSpaces;
            remove = bbanInput.Replace("-", "");
            removeSpaces = remove.Replace(" ", "");
            bban.Append(removeSpaces);
            int decider = int.Parse(bban[0].ToString());
            int luhnCheckSum = 0;
          
            

            if (decider == 4)
            {
                while (bban.Length < 14)
                {
                    bban.Insert(7, "0");
                }
            }
            else if (decider == 5)
            {
                while (bban.Length < 14)
                {
                    bban.Insert(7, "0");
                }
            }
            else
            {
                while (bban.Length < 14)
                {
                    bban.Insert(6, "0");
                }
            }

            for (int i = 0; i <= 12; i++)
            {
                int asd = int.Parse(bban[i].ToString());

                if (i % 2 == 1)
                {
                        luhnCheckSum = luhnCheckSum + asd;
                }
                else
                {
                    luhnCheckSum = luhnCheckSum +(asd * 2);

                   if (asd * 2 >= 10)
                   {
                      luhnCheckSum = luhnCheckSum - 9;
                   }
                }
            }

            int lastNumber = int.Parse(bban[13].ToString());
            int test = (luhnCheckSum + lastNumber) % 10;
            if (test == 0)
            {
                Console.WriteLine("account number {0} is correct", bban);
            }
            else
            {
                Console.WriteLine("account number was incorrect");
            }
  
            Console.ReadKey();
        }

    }

}
