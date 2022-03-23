namespace smallCompany.Models
{
    public class Assignment
    {
        public int AssignmentID { get; set; }
        public int EmployeeID { get; set; }
        public int TaskID { get; set; }

        public Employee Employee { get; set; }
        public Task Task { get; set; }
    }
}
