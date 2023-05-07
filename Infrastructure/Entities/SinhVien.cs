using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        public int MaSV { get; set; }
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public int Tuoi { get; set; }
        public string DiaChi { get; set; }
    }
}