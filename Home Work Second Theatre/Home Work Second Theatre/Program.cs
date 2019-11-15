using System;
using Work_Theatre;

namespace Home_Work_Second_Theatre
{
    class Program
    {
        static void Main(string[] args)
        {
            StangingWork.AddConcert("Gore ot uma", "Griboedov", "staging");
            StangingWork.SortType("staging");
            TicketWork.AddTicets("Gore ot uma", "big scene", "2019.12.12 18:30", 750);
            TicketWork.ShowAll();
        }
    }
}