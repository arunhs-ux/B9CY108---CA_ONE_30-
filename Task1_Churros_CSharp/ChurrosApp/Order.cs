
using System;

public class Order
{
    public int OrderNo { get; private set; }
    public string OrderDetails { get; private set; }
    public int Quantity { get; private set; }
    public double Bill { get; private set; }

    public Order(int orderNo, string details, int qty)
    {
        OrderNo = orderNo;
        OrderDetails = details;
        Quantity = qty;
    }

    public double PayBill(double price)
    {
        Bill = price * Quantity;
        return Bill;
    }

    public void Display()
    {
        Console.WriteLine($"[Order #{OrderNo}] {OrderDetails} x{Quantity} → €{Bill}");
    }
}
