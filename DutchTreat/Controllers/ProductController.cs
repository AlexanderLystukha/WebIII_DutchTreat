using DutchTreat.Controllers.Base;
using DutchTreat.Data;
using DutchTreat.Data.Entities;
using DutchTreat.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class ProductController : BaseController<Product>
    {       
        private IUnitOfWork _unitOfWork;
        public ProductController(ILogger<ProductController> logger, IUnitOfWork unitOfWork) : base(logger, unitOfWork.ProductRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
