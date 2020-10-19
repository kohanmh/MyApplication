using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Domain.IFactory
{
    public interface IApplicationDbContextFactory
    {
        DataBaseContext Create();
    }
}
