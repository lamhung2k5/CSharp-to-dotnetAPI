public class Program
{
    public static void Main(string[] args)
    {
        //khoi tao SupportRequestManager
        SupportRequestManager manager = new SupportRequestManager();

        //tao 4 yeu cau
        SupportRequest request1 = new SupportRequest("YC01", "Hung", "Cannot log in", SupportCategory.Account);
        SupportRequest request2 = new SupportRequest("YC02", "Lan", "Tuition information", SupportCategory.Tuition);
        SupportRequest request3 = new SupportRequest("YC03", "An", "Course registration Error", SupportCategory.Academic);
        SupportRequest request4 = new SupportRequest("YC04", "Duy", "Website loading error", SupportCategory.Technology);


        manager.AddRequest(request1);
        manager.AddRequest(request2);
        manager.AddRequest(request3);
        manager.AddRequest(request4);

        //hien thi toan bo
        Console.WriteLine("================================All Support Requests================================");
        manager.DisplayAllRequests();

        //tim kiem ma yc02 (ma that la YC02)
        Console.WriteLine("\n==============================Find Request by Id: YC02==============================");
        SupportRequest? foundRequest = manager.FindRequestById("YC02");
        if (foundRequest != null)
        {
            Console.WriteLine("Request found:");
            foundRequest.DisplayInfo();
        }
        else
        {
            Console.WriteLine("Request not found.");
        }

        //dua YC01, YC02, YC03 vao queue, sau đó DisplayPendingQueue va dam bao hient hi theo dung thu tu
        Console.WriteLine("\n==============================Find Request by Id: YC02==============================");
        manager.EnqueueRequest("YC01");
        manager.EnqueueRequest("YC02");
        manager.EnqueueRequest("YC03");
        manager.DisplayPendingQueue();

        //Xu ly yeu cau 
        Console.WriteLine("\n==============================Process Next Request==============================");
        manager.ProcessNextRequest();
        manager.ProcessNextRequest();

        //hien thi lai lich su
        Console.WriteLine("\n==============================Process Next Request==============================");
        manager.DisplayProcessedHistory();

        //hoan tac
        Console.WriteLine("\n==============================Undo Last Processed Request==============================");
        manager.UndoLastProcessedRequest();
        manager.DisplayProcessedHistory();

        //hien thi so luong
        Console.WriteLine("\n==============================Quantity==============================");
        GenericHelper.DisplayValue("Total Requests", manager.GetTotalRequestCount());
        GenericHelper.DisplayValue("Pending Requests", manager.GetPendingRequestCount());
        GenericHelper.DisplayValue("Processed Requests", manager.GetProcessedHistoryCount());


        //Testing
        //tao request co id rong

        try
        {
            SupportRequest invalidRequest = new SupportRequest("", "Test", "Invalid request", SupportCategory.Account);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Id Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }

        //Them request co id trung
        try
        {
            SupportRequest ExistsIdRequest = new SupportRequest("yc01", "Test", "Invalid request", SupportCategory.Account);
            manager.AddRequest(ExistsIdRequest);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Duplicate Id Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }

        //dua cung request vao queue 2 lan
        try
        {
            manager.EnqueueRequest("YC02");
            manager.EnqueueRequest("yc02");

        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Enqueue Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }

        //Enqueue request khong ton tai
        try
        {
            manager.EnqueueRequest("YC99");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Enqueue Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }

        //process khi queue rong
        SupportRequestManager emptyManager = new SupportRequestManager();
        try
        {
            emptyManager.ProcessNextRequest();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Process Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }

        //undo khi stack rong
        try
        {
            emptyManager.UndoLastProcessedRequest();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Undo Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}