using System;
using System.Collections.Generic;

namespace Work_Theatre
{
    public class VipWork
    {
        public static List<VIP> Guests= new List<VIP>();

        public static void AddGuest(string name, int purchases)
        {
           Guests.Add(new VIP(name, purchases)); 
          // Console.Write("Success!\r\n");
        }

        public static bool ThereIs(string name) // Наличие гостя в  VIP списке
        {
            int id = -1;
            id = Guests.FindIndex(Guests => Guests.VipName == name);
            if (id != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int FindId(string name)
        {
            return(Guests.FindIndex(Guests => Guests.VipName == name));
        }
        
        public static int SizeSale(string name)
        {
            if (ThereIs(name))
            {
                return Guests[FindId(name)].Sale;
            }
            else
            {
                return 0;
            }
        }

        public static void AddPurchases(string name, int purchases)
        {
            Guests[FindId(name)].Purchases += purchases;
            if (Guests[FindId(name)].Purchases > 5)
            {
                Guests[FindId(name)].Sale = 10;
            }
            if ( Guests[FindId(name)].Purchases > 10)
            {
                Guests[FindId(name)].Sale = 15;
            }
        }
    }
}