using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Fifth_HomeWork.Models
{
    public class FilterViewModel
    {
        public FilterViewModel(List<St_type> stTypes, int? st_type, string name)
        {
            // устанавливаем начальный элемент, который позволит выбрать всех
            stTypes.Insert(0, new St_type { Type = "All", Id = 0 });
            Types = new SelectList(stTypes, "Id", "Type", st_type);
            SelectedType = st_type;
            SelectedName = name;
        }
        public SelectList Types { get; private set; } 
        public int? SelectedType { get; private set; }
        public string SelectedName { get; private set; } 
         }
}