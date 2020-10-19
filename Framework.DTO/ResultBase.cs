using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.DTO
{
    public abstract class ResultBase
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public List<ValidationError> ValidationErrors { get; set; }
    }
}
