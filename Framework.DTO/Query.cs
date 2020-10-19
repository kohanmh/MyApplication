using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Framework.DTO
{
    public class Query<TResult> : Queue where TResult : QueryResult
    {
        public Query() { }
    }
}
