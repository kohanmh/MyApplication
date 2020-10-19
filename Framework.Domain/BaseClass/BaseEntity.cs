using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Domain
{
    public class BaseEntity<TKey>
    {
        public TKey Key { get; set; }
    }
}
