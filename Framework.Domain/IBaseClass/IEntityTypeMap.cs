using Microsoft.EntityFrameworkCore;

namespace Framework.IDomain
{
    public interface IEntityTypeMap
    {
        void Map(ModelBuilder builder);
    }
}
