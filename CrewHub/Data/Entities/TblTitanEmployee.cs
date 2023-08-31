namespace CrewHub.Data.Entities
{
    public class TblTitanEmployee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string EmpRefCode { get; set; }
        public string ReportsTo { get; set; }
    }
}
