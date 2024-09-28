
namespace BaseLibrary.Entities
{
    public class Employee : BaseEntity
    {
        public string? CivilID { get; set; }
        public string? FileNumber { get; set; }
        public string? FullName { get; set; }
        public string? JobName { get; set; }
        public string? Address { get; set; }
        public string? TelephoneNumber { get; set; }
        public string? Photo { get; set; }
        public string? Other { get; set; }


        public Branch? Branch { get; set; }
        public int BrachId { get; set; }

        //Many to one relationship with Town
        public Town? Town { get; set; }
        public int TownId { get; set; }

    }
}
