using System;
using SimpleOWINCrudService.Contracts.Interfaces;

namespace SimpleOWINCrudService.Contracts.Models
{
    public class Customer : IIdentifiable, IAuditable
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TelephoneNo { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
