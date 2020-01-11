namespace Fifth_HomeWork.Models
{
    public class SortViewModel
    {
        public SortState NameSort { get; private set; } 
        public SortState TicketsSort { get; private set; }  
        public SortState PriceSort { get; private set; } 

        public SortViewModel(SortState sortOrder)
        {
            NameSort = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            TicketsSort = sortOrder == SortState.TicketsAsc ? SortState.TicketsDesc : SortState.TicketsAsc;
            PriceSort = sortOrder == SortState.PriceAsc ? SortState.PriceDesc : SortState.PriceAsc;
        }
    }
}