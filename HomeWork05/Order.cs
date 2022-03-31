using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework5
{
    class Order 
    {
        /// <summary>
        /// 数据列表
        /// </summary>        
        public List<OrderDetail> orderDetailGroup { get; } = new List<OrderDetail>();
        /// <summary>
        /// 定义所属的客户
        /// </summary>
        public String customerName;
            
        /// <summary>
        /// 订单编号
        /// </summary>
        public int orderIndex = 0;

        public int totalPriceInOrder
        {
            get => orderDetailGroup.Sum(od => od.totalPriceInDetail);
        }     
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="customer"> 所属客户</param>
        public Order(Customer customer)
        {
            this.customerName = customer.name;
        }
        public Order(Customer customer, int index)
        {
            this.customerName = customer.name;
            orderIndex = index;
        }

        public Order(Customer customer, int index, List<OrderDetail> detailsList)
        {
            this.customerName = customer.name;
            orderIndex = index;
            foreach(OrderDetail details in detailsList)
                orderDetailGroup.Add(details);
        }

        public void addOrderDetails(OrderDetail detail)
        {
            //if (this.orderDetailGroup.Contains(detail))
            //{
            //    throw new ApplicationException("addOrderDetails: add existed details");
            //}
            this.orderDetailGroup.Add(detail);
        }
        public override string ToString()
        {
            string orderStr = "";
            foreach (OrderDetail details in orderDetailGroup)
                orderStr += details.ToString();
            return orderStr;
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && order.orderIndex == this.orderIndex;
        }
        public override int GetHashCode()
        {
            return orderIndex.GetHashCode();
        }
        public bool IsValid()
        {
            return this.orderIndex != 0 && this.orderDetailGroup != null && this.orderDetailGroup.Count > 0;
        }

    }
}
