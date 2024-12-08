using OopClassPersonStudentAndTeacher;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person();
        person.Greet();

        Student student = new Student() { Age = 26 };
        student.Greet();
        student.ShowAge();

        Teacher teacher = new Teacher() { Age = 39};
        teacher.Greet();
        teacher.Explain();
    }
}