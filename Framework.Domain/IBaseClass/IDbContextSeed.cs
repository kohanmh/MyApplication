using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.IDomain
{
    public interface IDbContextSeed
    {
        void Seed(ModelBuilder modelBuilder);
    }
}
