public class RegistrationService
{
    private readonly List<Student> students;
    private readonly List<Course> courses;
    private readonly List<Registration> registrations;

    //event
    public event Action<Registration>? CourseRegistered;

    public RegistrationService()
    {
        students = new List<Student>();
        courses = new List<Course>();
        registrations = new List<Registration>();
    } 

    public void AddStudent(Student student)
    {
        //kiem tra student
        if(student == null)
        {
            throw new ArgumentNullException(nameof(student), "Student cannot be null.");
        }

        //kiem tra id trung
        if(students.Exists(foundStudent => foundStudent.Id == student.Id))
        {
            throw new InvalidOperationException($"Student with id {student.Id} already exists.");
        }

        students.Add(student);
    }

    public void AddCourse(Course course)
    {
        if (course == null)
        {
            throw new ArgumentNullException(nameof(course), "Course cannot be null");
        }

        if (courses.Exists(foundCourse => foundCourse.Id == course.Id))
        {
            throw new InvalidOperationException($"Course with id {course.Id} already exists.");
        }

        courses.Add(course);
    }

    public void RegisterCourse(string studentId, string courseId)
    {
        //validation studentId
        if (string.IsNullOrWhiteSpace(studentId))
        {
            throw new ArgumentException("Student Id cannot be null or whitespace", nameof(studentId));
        }

        //validation courseID
        if (string.IsNullOrWhiteSpace(courseId))
        {
            throw new ArgumentException("Course Id cannot be null or whitespace", nameof(courseId));
        }

        //normalizedId cho student va course
        string normalizedStudentId = studentId.Trim();
        string normalizedCourseId = courseId.Trim();

        /*
        //studentId va courseId phai co mat trong he thong
        if (!students.Exists(student => student.Id == normalizedStudentId) || !courses.Exists(course => course.Id == normalizedCourseId))
        {
            throw new InvalidOperationException($"Student with id {normalizedStudentId} does not exist in this student List.");
        }

        if (!courses.Exists(course => course.Id == normalizedCourseId))
        {
            throw new InvalidOperationException($"Student with id {normalizedCourseId} does not exist in this student List.");
        }
        */

        //tao object student va course theo id moi phan
        Predicate<Student> foundStudentPredicate = student => student.Id == normalizedStudentId;

        Student? studentRegistered = students.Find(foundStudentPredicate);
        Course? courseRegistered = courses.Find(course => course.Id == normalizedCourseId);

        //kiem tra null cho studentRegistered và courseRegistered
        if(studentRegistered == null)
        {
            throw new InvalidOperationException("Student cannot be null");
        }

        if(courseRegistered == null)
        {
            throw new InvalidOperationException("Course cannot ne null.");
        }

         //kiem tra registration (studentId và courseId) da co trong registrations chua
        if(registrations.Exists(registration => registration.Student.Id == normalizedStudentId && registration.Course.Id == normalizedCourseId))
        {
            throw new InvalidOperationException("This registration already exists.");
        }

        //neu tat ca hop le thi thong bao
        Registration registration = new Registration(studentRegistered, courseRegistered);

        registrations.Add(registration);

        CourseRegistered?.Invoke(registration);
    }
}