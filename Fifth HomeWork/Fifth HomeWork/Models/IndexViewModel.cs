using System.Collections.Generic;
namespace Fifth_HomeWork.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Staging> Stagings { get; set; }
        public SortViewModel SortViewModel { get; set; }
    }
}