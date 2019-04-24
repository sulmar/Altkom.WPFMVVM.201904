namespace Altkom.ABC.Models
{
    public class Customer : Base
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public decimal Salary { get; set; }

        public bool IsDeleted { get; set; }

        public string Description { get; set; }
    }
}
