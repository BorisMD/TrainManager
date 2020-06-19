using System;
using System.Collections.Generic;
using System.Linq;
using TrainManager.Data;
using TrainManager.Models;

namespace TrainManager.Services
{
    public class TrainService : ITrainService
    {
        private TrainManagerDBContext context;

        public TrainService(TrainManagerDBContext context)
        {
            this.context = context;
        }

        public void Make(TrainServiceModel input)
        {
            if (input.Capacity == 100)
            {
                return;
            }

            var train = new Train()
            {
                Name = input.Name,
                Capacity = input.Capacity,
                Fast = input.Fast
            };

            context.Trains.Add(train);
            context.SaveChanges();
        }

        public bool HasWithId(string id)
        {
            return context.Trains.Any(r => r.Id == id);
        }

        public Train GetById(string id)
        {
            if (!HasWithId(id))
            {
                throw new ArgumentException("Invalid train id");
            }

            return context.Trains.SingleOrDefault(r => r.Id == id);
        }

        public void Delete(string id)
        {
            if (!HasWithId(id))
            {
                throw new ArgumentException("Invalid train id");
            }

            var train = GetById(id);

            context.Trains.Remove(train);
            context.SaveChanges();
        }

        public int GetCount()
        {
            return context.Trains.Count();
        }

        public List<Train> GetAll(int page)
        {
            return context.Trains
                .OrderBy(r => r.Capacity)
                .Take(page * GlobalConstants.TrainsPerPage)
                .Skip((page - 1) * GlobalConstants.TrainsPerPage)
                .ToList();
        }
    }
}
