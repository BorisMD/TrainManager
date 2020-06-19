using System.Collections.Generic;
using TrainManager.Models;

namespace TrainManager.Services
{
    public interface IUserService
    {
        int GetCount();

        List<User> GetAll(int page, int showByPage, string orderBy);

        bool Contains(string id);

        User GetById(string id);

        void Edit(UserServiceModel user);

        void Delete(string id);
    }
}
