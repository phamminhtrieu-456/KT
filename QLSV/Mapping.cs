using AutoMapper;
using Infrastructure.Entities;
using QLSV.Models;

namespace QLSV
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<SinhVien, SinhVienViewModel>();
            CreateMap<SinhVienViewModel, SinhVien>();
        }
    }
}
