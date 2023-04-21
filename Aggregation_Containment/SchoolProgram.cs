namespace Aggregation_Containment
{
    internal class SchoolProgram
    {
        //Fields
        string _className;
        string _classNumber;
        string _roomNumber;
        Instructor _instructor;
        List<Student> _classRoster;

        //Constructor
        public SchoolProgram(string className, string classNumber, string roomNumber, Instructor instructor)
        {
            _className = className;
            _classNumber = classNumber;
            _roomNumber = roomNumber;
            _instructor = instructor;
            _classRoster = new List<Student>();
        }

        //Properties
        public string ClassName1 { get => _className; set => _className = value; }
        public string ClassNumber1 { get => _classNumber; set => _classNumber = value; }
        public string RoomNumber1 { get => _roomNumber; set => _roomNumber = value; }
        public Instructor Instructor1 { get => _instructor; set => _instructor = value; }
        public List<Student> ClassRoster1 { get => _classRoster; }


        //Methods
        public void AddStudent(Student student)
        {
            _classRoster.Add(student);
        }

        public void AddStudent(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            Student student = new Student(firstName, lastName, csiGrade, genEdGrade);
            _classRoster.Add(student);
        }

        public override string ToString()
        {
            return $"{_className} - {_classNumber} : {_roomNumber} - {_instructor.FirstName} {_instructor.LastName} - Number of Students: {_classRoster.Count}";
        }
    }
}