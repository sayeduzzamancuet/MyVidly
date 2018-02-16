using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyVidly.Models;
using System.ComponentModel.DataAnnotations;
namespace MyVidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        public DateTime? DoB { get; set; }
    }
}