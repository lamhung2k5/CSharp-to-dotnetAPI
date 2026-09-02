public class SupportRequestManager
{
    private readonly EntityRepository<SupportRequest> _repository; //luu toan bo yeu cau, tim nahnh theo id, khong chp phep trung id
    private readonly Queue<SupportRequest> _pendingQueue; //luu cac yeu cau dang can ho xu ly
    private readonly Stack<SupportRequest> _processedHistory; //luu lich su cac yeu cau vua xu ly
    private readonly HashSet<string> _queuedRequestIds; //luu cac id dang nam trong queue     

    public SupportRequestManager()
    {
        _repository = new EntityRepository<SupportRequest>();
        _pendingQueue = new Queue<SupportRequest>();
        _processedHistory = new Stack<SupportRequest>();
        _queuedRequestIds = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
    }

    public void AddRequest(SupportRequest request)
    {
        if(request == null)
        {
            throw new ArgumentNullException(nameof(request), "Request cannot be null.");
        }

        _repository.Add(request);
    }

    public void EnqueueRequest(string id)
    {
        // 1. Validation id
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Id cannot be null or whitespace.", nameof(id));
        }

        // 2. Trim
        string normalizedId = id.Trim();

        // 3. Tìm request trong repository
        SupportRequest? request = _repository.FindById(normalizedId);


        // 4. Nếu không tìm thấy
        if (request == null)
        {
            throw new InvalidOperationException($"Id with value {normalizedId} is not exist.");
        }

        // 5. Nếu Id đã có trong HashSet
        if (_queuedRequestIds.Contains(normalizedId))
        {
            throw new InvalidOperationException($"Id with value {normalizedId} is already exists.");
        }

        // 6. Nếu status == Completed
        if (request.Status == RequestStatus.Completed)
        {
            throw new InvalidOperationException($"This request is completed.");
        }

        // 7. Thêm object vào Queue
        _pendingQueue.Enqueue(request);

        // 8. Thêm Id vào HashSet
        _queuedRequestIds.Add(normalizedId);
    }

    public SupportRequest ProcessNextRequest()
    {
        //kiem tra queue
        if(_pendingQueue.Count == 0)
        {
            throw new InvalidOperationException("This pending queue is empty.");
        }

        //lay yeu cau dau tien
        SupportRequest? firstRequest = _pendingQueue.Dequeue();

        //xoa id ra khoi HashSet
        _queuedRequestIds.Remove(firstRequest.Id);

        //doi trang thai thanh Completed
        firstRequest.MarkAsCompleted();

        //dua yeu cau vao stack lich su
        _processedHistory.Push(firstRequest);

        return firstRequest;
    }

    public SupportRequest UndoLastProcessedRequest()
    {
        //kiem tra stack rong
        if(_processedHistory.Count == 0)
        {
            throw new InvalidOperationException("This processed history stack is empty.");
        }

        //lay request gan nhat bang pop
        SupportRequest currentReuqest = _processedHistory.Pop();

        //goi MarkAsPending 
        currentReuqest.MarkAsPending();

        //dua request tro lai queue
        _pendingQueue.Enqueue(currentReuqest);

        //them lai id vao hash set
        _queuedRequestIds.Add(currentReuqest.Id);

        return currentReuqest;
    }

    public SupportRequest? FindRequestById(string id)
    {
        return _repository.FindById(id);
    }

    public bool ContainsRequest(string id)
    {
        return _repository.ContainsId(id);
    }

    public int GetTotalRequestCount()
    {
        return _repository.GetCount();
    }

    public int GetPendingRequestCount()
    {
        return _pendingQueue.Count;
    }

    public int GetProcessedHistoryCount()
    {
        return _processedHistory.Count;
    }

    public void DisplayAllRequests()
    {
        
        _repository.DisplayAll();
    }

    public void DisplayPendingQueue()
    {
        if(_pendingQueue.Count == 0)
        {
            Console.WriteLine("This pending queue is empty.");
            return;
        }

        foreach(SupportRequest request in _pendingQueue)
        {
            request.DisplayInfo();
        }
    }

    public void DisplayProcessedHistory()
    {
        if (_processedHistory.Count == 0)
        {
            Console.WriteLine("This processed history is empty.");
            return;
        }

        foreach (SupportRequest request in _processedHistory)
        {
            request.DisplayInfo();
        }
    }
}