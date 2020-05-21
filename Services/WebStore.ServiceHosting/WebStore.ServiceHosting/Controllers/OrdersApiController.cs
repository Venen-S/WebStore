using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain;
using WebStore.Domain.DTO.Orders;
using WebStore.Interfaces.Services;

namespace WebStore.ServiceHosting.Controllers
{
    [Route(WebAPI.Orders)]
    [ApiController]
    public class OrdersApiController : ControllerBase,IOrderService
    {
        private readonly IOrderService _OrderService;

        public OrdersApiController(IOrderService OrderService)
        {
            _OrderService = OrderService;
        }
        [HttpPost("{UserName}")]
        public Task<OrderDTO> CreateOrderAsync(string UserName, [FromBody]CreateOrderModel OrderModel) => 
            _OrderService.CreateOrderAsync(UserName, OrderModel);

        [HttpGet("{id}")]
        public OrderDTO GetOrderById(int id) => 
            _OrderService.GetOrderById(id);

        [HttpGet("user/{UserName}")]
        public IEnumerable<OrderDTO> GetUserOrders(string UserName) => 
            _OrderService.GetUserOrders(UserName);
    }
}