using System;
using System.ComponentModel.DataAnnotations;

namespace TrainManager.BindingModels.Line
{
    public class Input
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string From { get; set; }

        [Required]
        [MaxLength(30)]
        public string To { get; set; }

        [Required]
        public string DepartureTime { get; set; }

        [Required]
        public string ArrivalTime { get; set; }

        [Required]
        public string Date { get; set; }
    }
}
