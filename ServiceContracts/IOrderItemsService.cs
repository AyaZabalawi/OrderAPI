using Microsoft.Extensions.Logging;
using ServiceContracts.DTO;

namespace OrderAPI.Services
{
    public interface IOrderItemsService
    {
        Task<OrderItemResponse> AddOrderItem(OrderItemAddRequest orderItemRequest);
        Task<bool> DeleteOrderItemByOrderItemId(Guid orderItemId);
        Task<List<OrderItemResponse>> GetAllOrderItems();
        Task<List<OrderItemResponse>> GetOrderItemsByOrderId(Guid orderId);
        Task<OrderItemResponse?> GetOrderItemByOrderItemId(Guid orderItemId);
        Task<OrderItemResponse> UpdateOrderItem(OrderItemUpdateRequest orderItemRequest);
    }
}