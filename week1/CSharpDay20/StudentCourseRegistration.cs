public class StudentCourseRegistration
{
	public string StudentId { get; }
	private readonly HashSet<string> _courseCodes;

	public StudentCourseRegistration(string studentId)
	{
		if(string.IsNullOrWhiteSpace(studentId))
		{
			throw new ArgumentException("Id cannot be null or whitespace.",nameof(studentId));
		}

		StudentId = studentId.Trim();

		//khoi tao hashset khong phan biet hoa thuong
		_courseCodes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
	}

	public bool RegisterCourse(string courseCode)
	{
		if(string.IsNullOrWhiteSpace(courseCode))
		{
			throw new ArgumentException("Course code cannot be null or whitespace", nameof(courseCode));
		}

		string normalizedCourseCode = courseCode.Trim();

		return _courseCodes.Add(normalizedCourseCode);
	}

	public bool IsCourseRegistered(string courseCode)
	{
        if (string.IsNullOrWhiteSpace(courseCode))
        {
            throw new ArgumentException("Course code cannot be null or whitespace", nameof(courseCode));
        }

		string normalizedCourseCode = courseCode.Trim();


		return _courseCodes.Contains(normalizedCourseCode);
    }

	public bool UnregisterCourse(string courseCode)
	{
        if (string.IsNullOrWhiteSpace(courseCode))
        {
            throw new ArgumentException("Course code cannot be null or whitespace", nameof(courseCode));
        }

        string normalizedCourseCode = courseCode.Trim();

		return _courseCodes.Remove(normalizedCourseCode);
    }

    public void DisplayRegisteredCourses()
    {
        Console.WriteLine(
            $"Registered courses of student {StudentId}:");

        if (_courseCodes.Count == 0)
        {
            Console.WriteLine("No registered courses.");
            return;
        }

        foreach (string courseCode in _courseCodes)
        {
            Console.WriteLine($"- {courseCode}");
        }
    }
}