using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.DTO
{
    public  class ValidationError
    {
        public string PropertyName { get; set; }
        public object PropertyValue { get; set; }
        public string ErrorMessage { get; set; }
    }
}
