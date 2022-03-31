using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Customer
    {
        /// <summary>
        /// 每个顾客可能会有多个订单
        /// </summary>
        private List<Order> orderList = new List<Order>();
        public string name { get; set; }
        public int orderCount = 1;

        public Customer(string name)
        {
            this.name = name;
        }
    }
}
