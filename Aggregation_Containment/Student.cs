namespace Aggregation_Containment
{
    internal class Student
    {
        //Feilds
        string _firstName;
        string _lastName;
        int _csiGrade;
        int _genEdGrade;

        //Constructor
        public Student(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            FirstName1 = firstName;
            LastName1 = lastName;
            CsiGrade1 = csiGrade;
            GenEdGrade1 = genEdGrade;
        }

        //Properties
        public string FirstName1 { get => _firstName; set => _firstName = value; }
        public string LastName1 { get => _lastName; set => _lastName = value; }
        public int CsiGrade1 { get => _csiGrade; set => _csiGrade = value; }
        public int GenEdGrade1 { get => _genEdGrade; set => _genEdGrade = value; }

        //Override ToString Method
        public override string ToString()
        {
            return $"{FirstName1} {LastName1} - CSI Grade {CsiGrade1} - GenEd Grade {GenEdGrade1}";
        }
    }
}