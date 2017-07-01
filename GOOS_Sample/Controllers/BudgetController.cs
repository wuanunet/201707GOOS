﻿using System.Web.Mvc;
using GOOS_Sample.Models;
using GOOS_Sample.Models.ViewModels;

namespace GOOS_Sample.Controllers
{
    public class BudgetController : Controller
    {
        private IBudgetService budgetService;

        public BudgetController(IBudgetService budgetService)
        {
            this.budgetService = budgetService;
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(BudgetAddViewModel model)
        {
            this.budgetService.Created += (sender, e) => { ViewBag.Message = "added successfully"; };
            this.budgetService.Updated += (sender, e) => { ViewBag.Message = "updated successfully"; };

            this.budgetService.Create(model);
            //ViewBag.Message = "added successfully";

            return View(model);
        }
    }
}