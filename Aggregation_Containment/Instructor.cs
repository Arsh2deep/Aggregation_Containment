namespace Aggregation_Containment
{
    internal class Instructor
    {
        //Feilds
        string _firstName;
        string _lastName;

        //Constructor
        public Instructor(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        //Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        //Tostring method
        public override string ToString()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}