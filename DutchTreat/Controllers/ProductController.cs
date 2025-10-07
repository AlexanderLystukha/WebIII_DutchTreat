using DutchTreat.Controllers.Base;
using DutchTreat.Data.Entities;
using DutchTreat.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class ProductController : BaseController<Product>
    {
        public ProductController(ILogger<HomeController> logger, IDutchRepository<Product> repository) : base(logger, repository)
        {
        }
    }
}
