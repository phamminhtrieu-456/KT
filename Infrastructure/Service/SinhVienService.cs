﻿using Infrastructure.Entities;
using Infrastructure.Repository;
using System.Linq;

namespace Infrastructure.Service
{
    public interface ISinhVienService
    {
        IQueryable<SinhVien> GetSinhViens();
        SinhVien GetSinhVien(int id);
        void InsertSinhVien(SinhVien user);
        void UpdateSinhVien(SinhVien user);
        void DeleteSinhVien(SinhVien user);
    }

    public class SinhVienService : ISinhVienService
    {
        private ISinhVienRepository sinhvienRepository;

        public SinhVienService(ISinhVienRepository sinhvienRepository)
        {
            this.sinhvienRepository = sinhvienRepository;
        }

        public IQueryable<SinhVien> GetSinhViens()
        {
            return sinhvienRepository.GetAll();
        }

        public SinhVien GetSinhVien(int id)
        {
            return sinhvienRepository.GetById(id);
        }

        public void InsertSinhVien(SinhVien sinhvien)
        {
            sinhvienRepository.Insert(sinhvien);
        }

        public void UpdateSinhVien(SinhVien sinhvien)
        {
            sinhvienRepository.Update(sinhvien);
        }

        public void DeleteSinhVien(SinhVien sinhvien)
        {
            sinhvienRepository.Delete(sinhvien);
        }
    }
}
