using Ticket_Richard.Models;

namespace Ticket_Richard.Data
{
    public class OrdersCollection
    {
        private readonly IEnumerable<OrderViewModel> orders = new List<OrderViewModel>
        {
            new OrderViewModel { OrderID = 1, Freight = 1, OrderDate = new DateTime(2016, 9, 15), ShipCity = "Berlin", ShipName = "FraightCo" },
            new OrderViewModel { OrderID = 2, Freight = 1, OrderDate = new DateTime(2016, 9, 15), ShipCity = "London", ShipName = "FraightCo" },
            new OrderViewModel { OrderID = 3, Freight = 1, OrderDate = new DateTime(2016, 9, 15), ShipCity = "Amsterdam", ShipName = "TransitCo" },
            new OrderViewModel { OrderID = 4, Freight = 1, OrderDate = new DateTime(2016, 9, 15), ShipCity = "Berlin", ShipName = "FraightCo" },
            new OrderViewModel { OrderID = 5, Freight = 1, OrderDate = new DateTime(2016, 9, 15), ShipCity = "Berlin", ShipName = "TransitCo" },
            new OrderViewModel { OrderID = 6, Freight = 1, OrderDate = new DateTime(2016, 9, 15), ShipCity = "Amsterdam", ShipName = "TransitCo" },
            new OrderViewModel { OrderID = 7, Freight = 1, OrderDate = new DateTime(2016, 9, 15), ShipCity = "Amsterdam", ShipName = "FraightCo" },
            new OrderViewModel { OrderID = 8, Freight = 1, OrderDate = new DateTime(2016, 9, 15), ShipCity = "London", ShipName = "TransitCo" },
            new OrderViewModel { OrderID = 9, Freight = 12, OrderDate = new DateTime(2016, 9, 15), ShipCity = "Berlin", ShipName = "FraightCo" },
            new OrderViewModel { OrderID = 10, Freight = 12, OrderDate = new DateTime(2016, 9, 15), ShipCity = "London", ShipName = "TransitCo" },
            new OrderViewModel { OrderID = 11, Freight = 12, OrderDate = new DateTime(2016, 9, 15), ShipCity = "Amsterdam", ShipName = "FraightCo" },
            new OrderViewModel { OrderID = 12, Freight = 12, OrderDate = new DateTime(2016, 9, 15), ShipCity = "Amsterdam", ShipName = "TransitCo" },
            new OrderViewModel { OrderID = 13, Freight = 12, OrderDate = new DateTime(2016, 9, 15), ShipCity = "Berlin", ShipName = "TransitCo" },
            new OrderViewModel { OrderID = 14, Freight = 12, OrderDate = new DateTime(2016, 9, 15), ShipCity = "Amsterdam", ShipName = "TransitCo" },
            new OrderViewModel { OrderID = 15, Freight = 12, OrderDate = new DateTime(2016, 9, 15), ShipCity = "London", ShipName = "FraightCo" },
            new OrderViewModel { OrderID = 16, Freight = 12, OrderDate = new DateTime(2016, 9, 15), ShipCity = "Berlin", ShipName = "TransitCo" },
        };

        public IEnumerable<OrderViewModel> Get_OrdersSet()
        {
            return orders;
        }
    }
}
