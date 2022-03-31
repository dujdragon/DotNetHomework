using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework5
{
    class OrderService
    {
        private List<Order> orders = new List<Order>();
        public OrderService()
        {
        }
        public void addOrder(Order order)
        {
            if (order==null || !order.IsValid())
            {
                throw new ApplicationException("addOrder: can not add a invalid order");
            }
            if (orders.Contains(order))
            {
                throw new ApplicationException("addOrder: can not add a existed order");
            }
            orders.Add(order);
        }
        public void removeOrderById(int orderId)
        {
            orders.RemoveAll(o => o.orderIndex == orderId);
        }
        public void updateOrder(Order order)
        {
            if (order==null || !order.IsValid())
            {
                throw new ApplicationException("updateOrder: can not update a invalid order");
            }
            removeOrderById(order.orderIndex);
            addOrder(order);
        }

        public Order getOrderById(int orderId)
        { 
            return orders.Where(o => o.orderIndex == orderId).FirstOrDefault();
        }
        public List<Order> QueryAll()
        {
            return orders.OrderBy(o => o.totalPriceInOrder).ToList<Order>();
        }

        public List<Order> QueryByGoodsName(string productName)
        {
            var query = orders
              .Where(o => o.orderDetailGroup.Any(d => d.productName == productName))
              .OrderBy(o => o.totalPriceInOrder);
            return query.ToList();
        }

        public List<Order> QueryByTotalAmount(float totalAmount)
        {
            var query = orders
              .Where(o => o.totalPriceInOrder >= totalAmount)
              .OrderBy(o => o.totalPriceInOrder);
            return query.ToList();
        }

        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orders
                .Where(o => o.customerName == customerName)
                .OrderBy(o => o.totalPriceInOrder);
            return query.ToList();
        }
        public IEnumerable<Order> Query(Predicate<Order> condition)
        {
            return orders
              .Where(o => condition(o))
              .OrderBy(o => o.totalPriceInOrder);
        }
    }
}
