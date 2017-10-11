using System;
using System.Text;

namespace  Ekoodi.Utilities.Test 
{
    public static class TestUtility
    {

      public static void Validator()
      {

            StringBuilder bban = new StringBuilder();

            string bbanInput = "159030 - 776";
            string remove;
            string removeSpaces;
            remove = bbanInput.Replace("-", "");
            removeSpaces = remove.Replace(" ", "");
            bban.Append(removeSpaces);
            int decider =int.Parse(bban[0].ToString());

            
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



            Console.WriteLine(bban);
            Console.WriteLine(bban.Length);
            Console.ReadKey();
        }


    }

}
