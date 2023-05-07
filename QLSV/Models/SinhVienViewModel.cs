using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QLSV.Models
{
    public class SinhVienViewModel
    {
        public SinhVienViewModel()
        {
        }

        [DisplayName("Mã số sinh viên")]
        public int MaSV { get; set; }

        [DisplayName("Họ và tên")]
        [MaxLength(50, ErrorMessage = "Họ và tên không quá 50 ký tự.")]
        public string HoTen { get; set; }

        [DisplayName("Lớp")]
        [MaxLength(20, ErrorMessage = "Lớp không quá 20 ký tự.")]
        public string Lop { get; set; }

        [DisplayName("Tuổi")]
        public int Tuoi { get; set; }

        [DisplayName("Địa chỉ")]
        [MaxLength(100, ErrorMessage = "Địa chỉ không quá 100 ký tự.")]
        public string DiaChi { get; set; }
    }
}
