using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("myFittingExp-Prod-Experiences-M")]
    public class ConsumerExperienceTransfer :Entity
    {
      [Key]
      public string consumerEmail{get; set;}
      public string consumerFirstName{get; set;}
      public string consumerLastName{get; set;}
      public string locationName{get; set;}
      public string address1{get; set;}
      public string address2{get; set;}
      public string city{get; set;}
      public string state{get; set;}
      public string postalCode{get; set;}
      public DateTime experienceDate{get; set;}
      public override Guid? Id { get; set; }
    }
}
