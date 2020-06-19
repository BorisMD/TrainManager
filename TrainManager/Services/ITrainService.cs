using System.Collections.Generic;
using TrainManager.Models;

namespace TrainManager.Services
{
    public interface ITrainService
    {
        void Make(TrainServiceModel input);

        bool HasWithId(string id);

        Train GetById(string id);

        void Delete(string id);

        int GetCount();

        List<Train> GetAll(int page);
    }
}
