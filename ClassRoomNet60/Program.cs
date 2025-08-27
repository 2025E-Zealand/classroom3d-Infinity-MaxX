using ClassRoomNet60;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        List<Student> students = new List<Student>();
        students.Add(new Student("Katerina", 03, 17));
        students.Add(new Student("Kasper", 08, 20));
        students.Add(new Student("Johanne", 06, 23));
        students.Add(new Student("Viktor", 02, 02));
        students.Add(new Student("Natalie", 10, 10));

        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }

        ClassRoom classThirdQ = new ClassRoom("3Q", students, new DateTime(27 / 08 / 2025));
    }
}