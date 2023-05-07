using Infrastructure.EF;
using Infrastructure.Entities;
using Infrastructure.Generic;

namespace Infrastructure.Repository
{
    public interface ISinhVienRepository : IRepository<SinhVien>
    {
    }

    public class SinhVienRepository : Repository<SinhVien>, ISinhVienRepository
    {
        public SinhVienRepository(EXDbContext context) : base(context)
        {
        }
    }
}
