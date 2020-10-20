using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Domain
{
    public class BaseEntity<TKey> where TKey : class
    {
        public TKey Key { get; set; }
    }
}
