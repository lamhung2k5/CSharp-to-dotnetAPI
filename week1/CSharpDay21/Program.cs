public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            /*
                // 1. Tạo Queue xử lý đơn hàng
                OrderProcessingQueue queue =
                    new OrderProcessingQueue(
                        "Main Order Processing Queue");

                // 2. Tạo các đơn hàng
                Order order1 =
                    new Order(
                        "DH01",
                        "Hung",
                        1_000_000m);

                Order order2 =
                    new Order(
                        "DH02",
                        "Lam",
                        3_000_000m);

                Order order3 =
                    new Order(
                        "DH03",
                        "Tri",
                        4_000_000m);

                // 3. Thêm các đơn hàng
                queue.AddOrder(order1);
                queue.AddOrder(order2);
                queue.AddOrder(order3);

                // 4. Hiển thị đơn hàng đang chờ
                Console.WriteLine(
                    "=== WAITING ORDERS ===");

                queue.DisplayWaitingOrders();

                // 5. Kiểm tra TryPeek không làm giảm Count
                Console.WriteLine(
                    "\n=== VIEW NEXT ORDER ===");

                int countBefore =
                    queue.GetWaitingOrderCount();

                Order? nextOrder =
                    queue.ViewNextOrder();

                if (nextOrder == null)
                {
                    Console.WriteLine(
                        "There is no next order.");
                }
                else
                {
                    Console.WriteLine("Next order:");
                    nextOrder.DisplayInfo();
                }

                int countAfter =
                    queue.GetWaitingOrderCount();

                Console.WriteLine(
                    $"Count before TryPeek: {countBefore}");

                Console.WriteLine(
                    $"Count after TryPeek: {countAfter}");

                Console.WriteLine(
                    countBefore == countAfter
                        ? "TryPeek did not change the queue."
                        : "The queue was changed.");

                // 6. Xử lý một đơn hàng
                Console.WriteLine(
                    "\n=== PROCESS ONE ORDER ===");

                Order? processedOrder =
                    queue.ProcessNextOrder();

                if (processedOrder == null)
                {
                    Console.WriteLine(
                        "There are no orders to process.");
                }
                else
                {
                    Console.WriteLine(
                        "Processed order:");

                    processedOrder.DisplayInfo();
                }

                // 7. Kiểm tra số lượng còn lại
                Console.WriteLine(
                    $"Waiting orders: " +
                    $"{queue.GetWaitingOrderCount()}");

                // 8. Hiển thị Queue sau khi xử lý một đơn
                Console.WriteLine(
                    "\n=== REMAINING ORDERS ===");

                queue.DisplayWaitingOrders();

                // 9. Xử lý cho đến khi Queue rỗng
                Console.WriteLine(
                    "\n=== PROCESS ALL REMAINING ORDERS ===");

                while (true)
                {
                    Order? order =
                        queue.ProcessNextOrder();

                    if (order == null)
                    {
                        break;
                    }

                    Console.WriteLine(
                        "Processed order:");

                    order.DisplayInfo();
                }

                Console.WriteLine(
                    $"Waiting orders: " +
                    $"{queue.GetWaitingOrderCount()}");

                // 10. Thử xử lý khi Queue đã rỗng
                Console.WriteLine(
                    "\n=== PROCESS EMPTY QUEUE ===");

                Order? orderAfterEmpty =
                    queue.ProcessNextOrder();

                if (orderAfterEmpty == null)
                {
                    Console.WriteLine(
                        "The queue is empty. " +
                        "No order can be processed.");
                }
                else
                {
                    orderAfterEmpty.DisplayInfo();
                }

                // 11. Hiển thị Queue rỗng
                queue.DisplayWaitingOrders();
            }
            */
            CustomerQueue queue =
                new CustomerQueue();

            // 1. Thêm ba khách hàng
            queue.AddCustomer("Binh");
            queue.AddCustomer("Khanh");
            queue.AddCustomer("Chi");

            Console.WriteLine(
                "=== WAITING CUSTOMERS ===");

            queue.DisplayCustomers();

            // 2. Kiểm tra TryPeek không xóa
            Console.WriteLine(
                "\n=== VIEW NEXT CUSTOMER ===");

            int countBeforePeek =
                queue.GetWaitingCount();

            string? nextCustomer =
                queue.ViewNextCustomer();

            if (nextCustomer == null)
            {
                Console.WriteLine(
                    "There is no next customer.");
            }
            else
            {
                Console.WriteLine(
                    $"Next customer: {nextCustomer}");
            }

            int countAfterPeek =
                queue.GetWaitingCount();

            Console.WriteLine(
                $"Count before TryPeek: {countBeforePeek}");

            Console.WriteLine(
                $"Count after TryPeek: {countAfterPeek}");

            Console.WriteLine(
                countBeforePeek == countAfterPeek
                    ? "TryPeek did not remove the customer."
                    : "The queue was unexpectedly changed.");

            // 3. Phục vụ một khách hàng
            Console.WriteLine(
                "\n=== SERVE ONE CUSTOMER ===");

            int countBeforeServe =
                queue.GetWaitingCount();

            string? servedCustomer =
                queue.ServeNextCustomer();

            if (servedCustomer == null)
            {
                Console.WriteLine(
                    "There is no customer to serve.");
            }
            else
            {
                Console.WriteLine(
                    $"Served customer: {servedCustomer}");
            }

            int countAfterServe =
                queue.GetWaitingCount();

            Console.WriteLine(
                $"Count before TryDequeue: {countBeforeServe}");

            Console.WriteLine(
                $"Count after TryDequeue: {countAfterServe}");

            Console.WriteLine(
                countAfterServe == countBeforeServe - 1
                    ? "TryDequeue removed exactly one customer."
                    : "The waiting count is incorrect.");

            // 4. Xử lý cho đến khi Queue rỗng
            Console.WriteLine(
                "\n=== SERVE REMAINING CUSTOMERS ===");

            while (true)
            {
                string? customer =
                    queue.ServeNextCustomer();

                if (customer == null)
                {
                    break;
                }

                Console.WriteLine(
                    $"Served customer: {customer}");
            }

            // 5. Thử xử lý khi Queue rỗng
            Console.WriteLine(
                "\n=== SERVE EMPTY QUEUE ===");

            string? customerAfterEmpty =
                queue.ServeNextCustomer();

            if (customerAfterEmpty == null)
            {
                Console.WriteLine(
                    "The queue is empty. " +
                    "No customer can be served.");
            }
            else
            {
                Console.WriteLine(
                    $"Served customer: {customerAfterEmpty}");
            }

            queue.DisplayCustomers();
        }
        

        catch (ArgumentException ex)
        {
            Console.WriteLine(
                $"Invalid argument: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                $"Unexpected error: {ex.Message}");
        }
    }
}
