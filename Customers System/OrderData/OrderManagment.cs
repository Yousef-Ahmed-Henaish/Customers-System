using System;
using System.Collections.Generic;
using System.Text;

namespace Customers_System.OrderData;

public class OrderManagment
{
    public const int MaxOrders = 100;
    public static List<Order> Orders = new List<Order>();




    /*
            if (OrderIsFound(order.ID))
                throw new Exception("Not Avaliable. Order Not Found");
            else if (order.IsPaid == false)
                throw new Exception("Not Avaliable. Order Not Paid");
    */


    Order CreateOrder(Customer customer, List<Line> lines)
    {
        Order order = new Order(customer, false,lines);
        Orders.Add(order);
        return order;
    }


    public static decimal CalculateOrderTotal(Order order) 
    {
        decimal Total = 0;
            
        foreach (Line line in order.Lines)
        {
            Total += line.Total;
        }

        if (order.Customer.IsVip)
            return Total * 0.9m;
        else
            return Total;
    }








    void AddLineToOrder(Order order, Product product, int quantity) 
    {
        order.Lines.Add( new Line(product, quantity) );
    }
   
    void MarkOrderPaid(Order order) 
    {
        order.IsPaid = true;
    }

    void PrintOrder(Order order)
    {
        Console.WriteLine($"===== Order {order.ID} =====");

        Console.WriteLine($"Date: {order.OrderDate}");
        Console.WriteLine($"Customer: {order.Customer}");
        Console.WriteLine($"Paid: {order.IsPaid}");
        Console.WriteLine("Lines");
        foreach (Line line in order.Lines)
        {
            int i = 0; i++;
            Console.WriteLine($"Line {i + 1}: {line.Product}, {line.Quantity}, @{line.Product.Price} = {line.Quantity * line.Product.Price}");
        }
        Console.WriteLine($"Total: {CalculateOrderTotal(order)}");
    }

    Boolean OrderIsFound(Order order)
    {
        foreach (Order Order in Orders)
            if (Order.ID == order.ID)
                return true;

        return false;
    }

    int FindOrderIndexById(int id)
    {
        foreach (Order Order in Orders)
            if (id == Order.ID)
                return Orders.IndexOf(Order);

        return -1;
    }


}
