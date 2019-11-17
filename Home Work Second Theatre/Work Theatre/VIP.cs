namespace Work_Theatre
{
    public class VIP
    {
        public string VipName;
        public int Purchases;
        public int Sale;

        public VIP(string name, int purchases)
        {
            VipName = name;
            Purchases = purchases;
            Sale = 5;
            if (purchases > 5)
            {
                Sale = 10;
            }
            if (purchases > 10)
            {
                Sale = 15;
            }
        }
    }
}