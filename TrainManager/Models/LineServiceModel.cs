using System;

namespace TrainManager.Models
{
    public class LineServiceModel
    {
        public string Id { get; set; }
        public Train Train { get; set; }
        public string From { get; set; }

        public string To { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime Date { get; set; }
    }
}
