using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MyVidly.Models
{
    public class Min18YearsIfMember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer =(Customer) validationContext.ObjectInstance;
            if (customer.MembershipTypeId==Customer.Unknown||customer.MembershipTypeId == Customer.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
            if (customer.DoB == null)
            {
                return new ValidationResult("Birthdate is required");
            }
            var age = DateTime.Today.Year - customer.DoB.Value.Year;
            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Customer need to be 18 years old");
        }
    }
}