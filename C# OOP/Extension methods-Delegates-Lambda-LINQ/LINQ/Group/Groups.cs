namespace LINQ.Group
{
    public class Groups
    {
        public Groups(int groupNum, string department)
        {
            this.GroupNumber = groupNum;
            this.DepartmentName = department;
        }

        public int GroupNumber { get; set; }

        public string DepartmentName { get; set; }
    }
}
