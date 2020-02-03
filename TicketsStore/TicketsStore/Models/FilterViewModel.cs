using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TicketsStore.Models
{
    public class FilterViewModel
    {
        public FilterViewModel(List<Theater> theaters, int? theater, string name)
        {
            theaters.Insert(0, new Theater { Name = "Все", Id = 0 });
            Theaters = new SelectList(theaters, "Id", "Name", theater);
            SelectedTheater = theater;
            SelectedName = name;
        }
        public  SelectList Theaters { get; private set; } // список компаний
        public int? SelectedTheater { get; private set; }   // выбранная компания
        public string SelectedName { get; private set; }    // введенное имя
    }
}