using SharedServices.Data;

namespace CrewHub.Data.Entities
{
    public class TblTitanEmployee : EntityBase<string>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string EmpRefCode { get; set; }
        public string ReportsTo { get; set; }
    }
}
