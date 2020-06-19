using System;

namespace TrainManager.ViewModels.Line
{
    public class DetailsViewModel
    {
        public string Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public DateTime Date { get; set; }
    }
}
