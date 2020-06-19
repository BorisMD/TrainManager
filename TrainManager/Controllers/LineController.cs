using System;
using System.Collections.Generic;
using TrainManager.Models;
using TrainManager.Services;
using TrainManager.BindingModels.Line;
using TrainManager.ViewModels.Line;
using TrainManager.ViewModels.Train;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TrainManager.Controllers
{
    public class LineController : Controller
    {
        private ILineService lineService;
        private ITrainService trainService;

        public LineController(ILineService lineService, ITrainService trainService)
        {
            this.lineService = lineService;
            this.trainService = trainService;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create(Input input)
        {
            return View(input);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(CreateBindingModel input)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/Line/Create");
            }

            var departureTime = new DateTime();

            if (!DateTime.TryParse(input.DepartureTime, out departureTime))
            {
                return Redirect("/Line/Create");
            }

            var arrivalTime = new DateTime();

            if (!DateTime.TryParse(input.ArrivalTime, out arrivalTime))
            {
                return Redirect("/Line/Create");
            }

            if (arrivalTime < departureTime)
            {
                return Redirect("/Line/Create");
            }

            var date = new DateTime();

            if (!DateTime.TryParse(input.Date, out date))
            {
                return Redirect("/Line/Create");
            }

            var line = new LineServiceModel
            {
                From = input.From,
                To = input.To,
                ArrivalTime = arrivalTime,
                DepartureTime = departureTime,
                Date = date
            };

            lineService.Create(line);

            return Redirect("/Home/Index");
        }

        public IActionResult GetAll(int page)
        {
            if (page <= 0)
            {
                return Redirect("/Home/Index");
            }

            int linesCount = lineService.GetCount();

            var lastPage = linesCount / GlobalConstants.LinesPerPage + 1;

            if (linesCount % GlobalConstants.LinesPerPage == 0 && lastPage > 1)
            {
                lastPage--;
            }

            if (page > lastPage)
            {
                return Redirect("/Home/Index");
            }

            var lines = lineService.GetAll(page);

            var viewModel = new TrainManager.ViewModels.Line.ListingPageViewModel
            {
                CurrentPage = page,
                TotalLinesCount = linesCount,
                LastPage = lastPage,
                Lines = new List<ListingViewModel>()
            };

            foreach (var line in lines)
            {
                viewModel.Lines.Add(new ListingViewModel()
                {
                    From = line.From,
                    DepartureTime = line.DepartureTime.ToString(GlobalConstants.DateTimeFormat),
                    To = line.To,
                    Id = line.Id,
                });
            }

            return View(viewModel);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(string id)
        {
            if (!lineService.HasWithId(id))
            {
                return Redirect("/Line/GetAll?page=1");
            }

            lineService.DeleteById(id);

            return Redirect("/Line/GetAll?page=1");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(string id)
        {
            if (!lineService.HasWithId(id))
            {
                return Redirect("/Line/GetAll?page=1");
            }

            var line = lineService.GetById(id);

            var viewModel = new DetailsViewModel()
            {
                Id = line.Id,
                ArrivalTime = line.ArrivalTime.ToString(GlobalConstants.DateTimeFormat),
                DepartureTime = line.DepartureTime.ToString(GlobalConstants.DateTimeFormat),
                From = line.From,
                To = line.To,
                Date = line.Date
            };

            return View(viewModel);
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Edit(Input input)
        {
            if (!ModelState.IsValid)
            {
                return Redirect($"/Line/Edit?id={input.Id}");
            }

            var departureTime = new DateTime();

            if (!DateTime.TryParse(input.DepartureTime, out departureTime))
            {
                return Redirect($"/Line/Edit?id={input.Id}");
            }

            var arrivalTime = new DateTime();

            if (!DateTime.TryParse(input.ArrivalTime, out arrivalTime))
            {
                return Redirect($"/Line/Edit?id={input.Id}");
            }

            var date = new DateTime();

            if (!DateTime.TryParse(input.Date, out date))
            {
                return Redirect($"/Line/Edit?id={input.Id}");
            }

            if (arrivalTime < departureTime)
            {
                return Redirect($"/Line/Edit?id={input.Id}");
            }

            var line = new LineServiceModel
            {
                Id = input.Id,
                From = input.From,
                To = input.To,
                ArrivalTime = arrivalTime,
                DepartureTime = departureTime,
                Date = date
            };

            lineService.Edit(line);

            return Redirect("/Line/GetAll?page=1");
        }
    }
}
