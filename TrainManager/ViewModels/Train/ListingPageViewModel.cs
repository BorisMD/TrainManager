using System.Collections.Generic;

namespace TrainManager.ViewModels.Train
{
    public class ListingPageViewModel
    {
        public List<TrainViewModel> Trains { get; set; }

        public int TotalTrainsCount { get; set; }

        public int CurrentPage { get; set; }

        public int LastPage { get; set; }
    }
}
