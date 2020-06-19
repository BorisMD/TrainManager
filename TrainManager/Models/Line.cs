using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrainManager.Models
{
    public class Line
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public Train Train { get; set; }

        [Required]
        [MaxLength(30)]
        public string From { get; set; }

        [Required]
        [MaxLength(30)]
        public string To { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
