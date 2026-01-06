using System;
class Order
{
    protected int orderId;
    protected DateTime orderDate;
    public Order(int orderId, DateTime orderDate)
    {
        this.orderId = orderId;
        this.orderDate = orderDate;
    }
    public virtual string GetOrderStatus()
    {
        return "Order created";
    }
}
class ShippedOrder : Order
{
    protected string trackingNumber;

    public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber) : base(orderId, orderDate)
    {
        this.trackingNumber = trackingNumber;
    }
    public override string GetOrderStatus()
    {
        return "Shipped";
    }

}
class DeliveredOrder : ShippedOrder
{
    protected DateTime deliveryDate;

    public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate) : base(orderId, orderDate, trackingNumber)
    {
        this.deliveryDate = deliveryDate;
    }
    public override string GetOrderStatus()
    {
        return "Delivered";
    }
    public void DisplayOrderDetails()
    {
        Console.WriteLine("Order ID: " + orderId);
        Console.WriteLine("Order Date: " + orderDate);
        Console.WriteLine("Tracking Number: " + trackingNumber);
        Console.WriteLine("Delivery Date: " + deliveryDate);
    }
}
class OnlineRetailOrderManagement
{
    static void Main(string[] args)
    {
        Order order = new Order(1, DateTime.Now);
        ShippedOrder shippedOrder = new ShippedOrder(2, DateTime.Now, "ABC123");
        DeliveredOrder deliveredOrder = new DeliveredOrder(3, DateTime.Now, "ABC456", DateTime.Now.AddDays(5));
        Console.WriteLine("Order Status: " + order.GetOrderStatus()); 
        Console.WriteLine("Shipped Order Status: " + shippedOrder.GetOrderStatus()); 
        Console.WriteLine("Delivered Order Status: " + deliveredOrder.GetOrderStatus()); 

        deliveredOrder.DisplayOrderDetails();
    }
}