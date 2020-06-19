using System;
using System.ComponentModel.DataAnnotations;
using TrainManager.Models;

namespace TrainManager.BindingModels.Train
{
    public class CreateBindingModel
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [Range(0, 100)]
        public int Capacity { get; set; }

        [Required]
        public string Fast { get; set; }
    }
}
