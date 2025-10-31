using DutchTreat.Controllers.Base;
using DutchTreat.Data;
using DutchTreat.Data.Entities;
using DutchTreat.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    [Authorize()]
    public class ProductController : BaseController<Product>
    {       
        private IUnitOfWork _unitOfWork;
        public ProductController(ILogger<ProductController> logger, IUnitOfWork unitOfWork) : base(logger, unitOfWork.GetRepository<IDutchRepository<Product>>())
        {
            _unitOfWork = unitOfWork;
        }

        public override ActionResult Index()
        {
            var result = ((IDutchProductRepository)_unitOfWork.GetRepository<IDutchRepository<Product>>())
                                        .GetAll()
                                        .OrderBy(p=>p.Category)
                                        .ToList();
               
            return View(result);
        }
    }
}
