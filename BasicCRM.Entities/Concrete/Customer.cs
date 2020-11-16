using BasicCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace BasicCRM.Entities.Concrete
{
   public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerPhone { get; set; }
        public string  CustomerAddress { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
