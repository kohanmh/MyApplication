using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Domain
{
    public class CustomerEntity : BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
    }
}
