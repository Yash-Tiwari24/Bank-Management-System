using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bank_Management_System.Models
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string TransactionUniqueReference { get; set; }
        public decimal TransactionAmount { get; set; }
        public TranStatus TransactionStatus { get; set; }//this is the enum
        public bool IsSuccessful => TransactionStatus.Equals(TranStatus.Success); //depends on the value of transactin status
        public string TransactionSourceAccount { get; set; }
        public string TransactionDestinationAccount { get; set; }
        public string TransactionParticulars { get; set; }
        public TranType TransactionType { get; set; } //this is the another enum
        public DateTime TransactionDate { get; set; }

    }
    public enum TranStatus
    {
        Failed,
        Success,
        Error
    }
    public enum TranType
    {
        Deposit,
        Withdraw,
        Transfer
    }
}
