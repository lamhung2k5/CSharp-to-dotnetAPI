public class Registration
{
    public Student Student { get; }
    public Course Course { get; }
    public DateTime RegisteredAt { get; }

    public Registration(Student student, Course course)
    {
        if(student == null)
        {
            throw new ArgumentNullException(nameof(student), "Student cannot be null.");
        }

        if(course == null)
        {
            throw new ArgumentNullException(nameof(course), "Course cannot be null.");
        }

        Student = student;
        Course = course;
        RegisteredAt = DateTime.Now;
    }
}