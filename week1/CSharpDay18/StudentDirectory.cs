public class StudentDirectory
{
	public string Name { get; }
	private readonly Dictionary<string, Student> _students;

	public StudentDirectory(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentException("name can not be null or white space", nameof(name));
		}
		Name = name.Trim();

		_students = new Dictionary<string, Student>();
	}

	//Them mot hoc sinh vao dictionary

	/* my idea
	public void AddStudent(Student student)
	{
		if (student == null)
		{
			throw new ArgumentNullException(nameof(student), "student can not be null");
		}

		if (_students.ContainsKey(student.Id))
		{
			throw new ArgumentException($"student with id {student.Id} is existing", nameof(student.Id));
		}

		_students.Add(student.Id, student);
    }
	*/

	public void AddStudent(Student student)
	{
		if (student == null)
		{
			throw new ArgumentNullException(nameof(student),"Student cannot be null.");
		}

		if (_students.ContainsKey(student.Id))
		{
			throw new InvalidOperationException($"Student with Id {student.Id} already exists.");
		}

		_students.Add(student.Id, student);
	}

	//tim mot hoc sinh
	/* my idea
	public Student? FindStudentById(string id)
	{
		if (string.IsNullOrWhiteSpace(id))
		{
			throw new ArgumentException("id can not be null", nameof(id));
		}

		if (_students.TryGetValue(id, out Student? student)) 
		{
			return student;
		}
		else
		{
			return null;
		}
	}
	*/

	public Student? FindStudentById(string id)
	{
		if (string.IsNullOrWhiteSpace(id))
		{
			throw new ArgumentException("Id cannot be null or whitespace.",nameof(id));
		}

		//bien trung gian cho id
		string normalizedId = id.Trim();

		if (_students.TryGetValue(normalizedId,out Student? student))
		{
			return student;
		}

		return null;
	}

	//xoa mot hoc sinh trong dictionary

	/*my idea
	public bool RemoveStudentById(string id)
	{
		if (string.IsNullOrWhiteSpace(id))
		{
			throw new ArgumentException("id can not be null", nameof(id));
		}

		Student removedStudent = _students[id];

		Console.WriteLine("student is removed: ");
		removedStudent.DisplayInfo();

		return _students.Remove(removedStudent.Id);
	}
	*/

	public bool RemoveStudentById(string id)
	{
		if (string.IsNullOrWhiteSpace(id))
		{
			throw new ArgumentException("Id cannot be null or whitespace.",nameof(id));
		}

		string normalizedId = id.Trim();

		if (!_students.TryGetValue(normalizedId,out Student? student))
		{
			return false;
		}

		Console.WriteLine("Student to be removed:");
		student.DisplayInfo();

		return _students.Remove(normalizedId);
	}

	public void DisplayStudents()
	{
		if (_students.Count == 0)
		{
			Console.WriteLine("Student is not element");
			return;
		}

		foreach (KeyValuePair<string, Student> item in _students)
		{
			Console.WriteLine($"Dictionary key: {item.Key}");
			item.Value.DisplayInfo();
		}
	}
}