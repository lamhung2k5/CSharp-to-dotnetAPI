public class Department
{
	public List<Teacher> Teachers { get; private set; }

	public Department(List<Teacher> teachers)
	{
		Teachers = teachers;
	}

	public void AddTeacher(Teacher teacher)
	{
		if (teacher == null)
		{
			throw new ArgumentNullException(nameof(teacher), "Teacher cannot be null.");
		}
		Teachers.Add(teacher);
	}

	public void DisplayTeachers()
	{
		foreach (var teacher in Teachers)
		{
			teacher.DisplayInfo();
		}
	}
}
