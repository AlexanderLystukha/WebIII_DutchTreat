using DutchTreat.Data.Entities;
using DutchTreat.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace DutchTreat.Controllers.Base
{
    public class BaseController<T> : Controller where T : class
    {
        internal readonly ILogger<BaseController<T>> _logger;
        internal readonly IDutchRepository<T> _repository;

        public BaseController(ILogger<BaseController<T>> logger, IDutchRepository<T> repository)
        {
            _logger = logger;
            _repository = repository;
        }

        // GET: BaseController
        public ActionResult Index()
        {
            var results = _repository.GetAll();

            return View(results);            
        }

        // GET: BaseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BaseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BaseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BaseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BaseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BaseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BaseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
