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
        }
    }
}