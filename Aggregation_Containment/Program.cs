namespace Aggregation_Containment;
class Program
{
    static void Main(string[] args)
    {
        Instructor will = new Instructor("Will", "Cram");
        SchoolProgram Program124 = new SchoolProgram("Programming", "124", "J102", will);
        Student student = new Student("Arshdeep", "Singh", 100, 100);
        Program124.AddStudent("Arshdeep", "Singh", 100, 100);
        Console.WriteLine(Program124);
        Console.WriteLine(will);
        Console.WriteLine(student);
    }
}

