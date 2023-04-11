using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        // add owner id - it is the user's id from AsoNEtUser table in Identity DB
        public string? OwnerID { get; set; }

        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        public ContactStatus Status { get; set; }
    }
    
    // add Status Field to determine status of submitted users
    public enum ContactStatus
    {
        Submitted,
        Approved,
        Rejected
    }
}

// finally migrate into DB
