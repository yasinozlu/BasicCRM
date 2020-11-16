using BasicCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCRM.Entities.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
