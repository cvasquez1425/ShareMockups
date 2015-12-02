
namespace ShareMockups.DomainClasses
{
    public class Employee
    {
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name      { get; set; }
        public int DepartmentID { get; set; }

        private int _id;
    }
}
