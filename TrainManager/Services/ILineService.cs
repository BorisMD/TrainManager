using System.Collections.Generic;
using TrainManager.Models;

namespace TrainManager.Services
{
    public interface ILineService
    {
        void Create(LineServiceModel line);

        int GetCount();

        IEnumerable<Line> GetAll(int page);

        bool HasWithId(string id);

        Line GetById(string id);

        void DeleteById(string id);

        void Edit(LineServiceModel Line);
    }
}
