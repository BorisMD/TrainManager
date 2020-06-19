using System.Collections.Generic;
using TrainManager.Models;
using TrainManager.Services;
using TrainManager.BindingModels.Train;
using TrainManager.ViewModels.Train;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace TrainManager.Controllers
{
    public class TrainController : Controller
    {
        private ILineService lineService;
        private ITrainService trainService;


        public TrainController(ILineService lineService, ITrainService trainService)
        {
            this.lineService = lineService;
            this.trainService = trainService;
        }

        [HttpPost]
        public IActionResult Make(CreateBindingModel input)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/Line/Create");
            }

            var train = new TrainServiceModel
            {
                Id = input.Id,
                Name = input.Name,
                Capacity = input.Capacity,
                Fast = input.Fast
            };

            trainService.Make(train);

            return Redirect("/Home/Index");
        }

        public IActionResult Delete(string id)
        {
            if (!trainService.HasWithId(id))
            {
                return Redirect("/Home/Index");
            }

            trainService.Delete(id);

            return Redirect("/Home/Index");
        }

        [Authorize]
        public IActionResult All(int page)
        {
            if (page <= 0)
            {
                return Redirect("/Home/Index");
            }

            int reservationsCount = trainService.GetCount();

            var lastPage = reservationsCount / GlobalConstants.TrainsPerPage + 1;

            if (reservationsCount % GlobalConstants.TrainsPerPage == 0 && lastPage > 1)
            {
                lastPage--;
            }

            if (page > lastPage)
            {
                return Redirect("/Home/Index");
            }

            var trains = trainService.GetAll(page);

            var viewModel = new ListingPageViewModel
            {
                CurrentPage = page,
                TotalTrainsCount = trains.Count,
                LastPage = lastPage,
                Trains = new List<TrainViewModel>()
            };

            foreach (var train in trains)
            {
                viewModel.Trains.Add(new TrainViewModel()
                {
                    Id = train.Id,
                    Name = train.Name,
                    Capacity = train.Capacity,
                    Fast = train.Fast
                });
            }

            return View(viewModel);
        }
    }
}
