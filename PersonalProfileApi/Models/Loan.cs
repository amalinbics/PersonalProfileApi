using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace PersonalProfileApi.Models
{
    public class Loan
    {
        public int Id { get; set; }

        [Required]
        public decimal AnnualIncome { get; set; }

        [Required]
        public int CibilScoreId { get; set; }

        public CibilScore CibilScore { get; set; }

        [Required]
        public decimal LoanAmount { get; set; }

        [Required]
        public byte TenureInMonths { get; set; }

        [Required]
        public double RateOfInterest { get; set; }

        [Required]
        public decimal EMI { get; set; }

        [Required]
        public int LenderId { get; set; }

        public Lender Lender { get; set; }


    }
}