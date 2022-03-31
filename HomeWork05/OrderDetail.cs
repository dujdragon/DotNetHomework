using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    // 商品购买类
    class OrderDetail
    {
        // 商品的属性
        public string  productName = "undefined";
        public int productNum = 0;
        public int totalPriceInDetail = 0;
        
        // 商品的单价, 应为私有属性, 有管理员设置
        private int unitPrice = 1;
        public OrderDetail(string name, int num)
        {
            productName = name;
            productNum = num;
            totalPriceInDetail = productNum * unitPrice;
        }

        public bool ChangeNum(int num)
        {
            if (num < 0)
            {
                throw new Exception("can not change to a negtive num");
            }
            productNum = num;
            totalPriceInDetail = productNum * unitPrice;
            return true;
        }

        public override string ToString()
        {
            return $"名称：{productName},个数：{productNum}，单价：{unitPrice}，总价：{totalPriceInDetail} \n";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetail;
            return detail != null & this.productName.Equals(this.productName);
        }
    }
}
