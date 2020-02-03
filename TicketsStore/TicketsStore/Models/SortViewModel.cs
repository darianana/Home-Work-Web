﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketsStore.Models
{
    public class SortViewModel
    {
        public SortState NameSort { get; private set; } 
        public SortState PriceSort { get; private set; }    
        public SortState TheaterSort { get; private set; }  
        public SortState StartTimeSort { get; private set; }  
        public SortState Current { get; private set; }   

        public SortViewModel(SortState sortOrder)
        {
            NameSort = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            PriceSort = sortOrder == SortState.PriceAsc ? SortState.PriceDesc : SortState.PriceAsc;
            TheaterSort = sortOrder == SortState.TheaterAsc ? SortState.TheaterDesc : SortState.TheaterAsc;
            StartTimeSort = sortOrder == SortState.StartTimeAsc ? SortState.StartTimeDesc : SortState.StartTimeAsc;
            Current = sortOrder;
        }
    }
}