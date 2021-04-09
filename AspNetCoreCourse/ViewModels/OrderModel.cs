using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCourse.ViewModels
{
    public class OrderModel
    {
        public OrderModel(int orderIndex, DateTime orderDate, string orderNumber,int itemsCount, double orderSum)
        {
            OrderIndex = orderIndex;
            OrderDate = orderDate;
            OrderNumber = orderNumber;
            ItemsCount = itemsCount;
            OrderSum = orderSum;
        }

        public int OrderIndex { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public int ItemsCount { get; set; }
        public double OrderSum { get; set; }
    }
}
