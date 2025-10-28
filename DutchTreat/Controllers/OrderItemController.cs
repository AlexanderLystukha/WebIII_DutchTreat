using DutchTreat.Controllers.Base;
using DutchTreat.Data;
using DutchTreat.Data.Entities;
using DutchTreat.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class OrderItemController : BaseController<OrderItem>
    {
        private IUnitOfWork _unitOfWork;

        public OrderItemController(ILogger<OrderItemController> logger, IUnitOfWork unitOfWork) : base(logger, unitOfWork.GetRepository<IDutchRepository<OrderItem>>())
        {
            _unitOfWork = unitOfWork;
        }
    }
}
