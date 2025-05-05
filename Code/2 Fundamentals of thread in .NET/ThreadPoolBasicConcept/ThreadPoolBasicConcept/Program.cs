namespace ThreadPoolBasicConcept
{
    internal class Program
    {
        public static void Main()
        {
            PlaceOrder(new Order() { Description = "Lego blocks", Name = "Lego", Price = 100 });
        }
        public static void PlaceOrder(Order order)
        {
            // Step 1: Process the order (synchronously)
            SaveOrderToDatabase(order);

            // Step 2: Offload email sending to ThreadPool
            ThreadPool.QueueUserWorkItem(state =>
            {
                SendEmailConfirmation((Order)state);
            }, order);

            // Return immediately to the user
            Console.WriteLine("Order placed! Email will be sent shortly.");
        }

        private static void SendEmailConfirmation(Order order)
        {
            // Simulate email sending
            Console.WriteLine($"Sending email to {order.CustomerEmail}...");
            Thread.Sleep(2000); // Simulate delay
            Console.WriteLine("Email sent!");
        }
        private static void SaveOrderToDatabase(Order order)
        {
            //Save to DB
        }

        public class Order
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public string CustomerEmail { get; set; }
        }
    }
}
