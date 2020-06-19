using System;
using System.Collections.Generic;
using System.Linq;
using TrainManager.Models;
using TrainManager.Data;

namespace TrainManager.Services
{
    public class LineService : ILineService
    {
        private readonly TrainManagerDBContext context;

        public LineService(TrainManagerDBContext context)
        {
            this.context = context;
        }

        public void Create(LineServiceModel input)
        {
            var line = new Line
            {
                From = input.From,
                To = input.To,
                ArrivalTime = input.ArrivalTime,
                DepartureTime = input.DepartureTime,
                Date = input.Date
            };

            context.Lines.Add(line);
            context.SaveChanges();
        }

        public int GetCount()
        {
            return context.Lines.Count();
        }

        public IEnumerable<Line> GetAll(int page)
        {
            return context.Lines
                .OrderByDescending(f => f.DepartureTime)
                .Take(page * GlobalConstants.LinesPerPage)
                .Skip((page - 1) * GlobalConstants.LinesPerPage)
                .ToList();
        }

        public bool HasWithId(string id)
        {
            return context.Lines.Any(f => f.Id == id);
        }

        public Line GetById(string id)
        {
            if (!HasWithId(id))
            {
                throw new ArgumentException("Invalid line id!");
            }

            var line = context.Lines.SingleOrDefault(f => f.Id == id);

            return line;
        }

        public void DeleteById(string id)
        {
            if (!HasWithId(id))
            {
                throw new ArgumentException("Invalid line id!");
            }

            var line = context.Lines.SingleOrDefault(f => f.Id == id);

            context.Lines.Remove(line);
            context.SaveChanges();
        }

        public void Edit(LineServiceModel line)
        {
            if (!HasWithId(line.Id))
            {
                throw new ArgumentException("Invalid line id!");
            }

            var lineFromDB = context.Lines.SingleOrDefault(f => f.Id == line.Id);

            lineFromDB.From = line.From;
            lineFromDB.To = line.To;
            lineFromDB.ArrivalTime = line.ArrivalTime;
            lineFromDB.DepartureTime = line.DepartureTime;
            lineFromDB.Date = line.Date;

            context.Lines.Update(lineFromDB);
            context.SaveChanges();
        }
    }
}
