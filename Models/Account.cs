using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bank_Management_System.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AccountBalance { get; set; }
        public AccountType AccountType { get; set; } //this will be enum to show if the account to be created saving or cuurent
        public string AccountNumberGenerated { get; set; }

        public byte[] PinHash { get; set; }
        public byte[] PinSalt { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastUpdated { get; set; }

        Random rand = new Random();
        public Account()
        {
            AccountNumberGenerated = Convert.ToString((long)rand.NextDouble() * 9_000_000_000L + 1_000_000_000L);
                //9_000_000_000 so we could get a 10-digit random account number
            AccountName = $"{FirstName} {LastName}";
        }
    }

    public enum AccountType 
    {
    Saving,
    Current,
    Salary}
}
