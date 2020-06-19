using System.Collections.Generic;

namespace TrainManager.ViewModels.Line
{
    public class ListingPageViewModel
    {
        public List<ListingViewModel> Lines { get; set; }

        public int TotalLinesCount { get; set; }

        public int CurrentPage { get; set; }

        public int LastPage { get; set; }
    }
}
