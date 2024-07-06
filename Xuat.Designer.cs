using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace QLCP6_2.Module.BusinessObjects.QuanLyQuanCaPhe6
{

    public partial class Xuat : XPLiteObject
    {
        string fMaXuat;
        [Key]
        [Size(5)]
        public string MaXuat
        {
            get { return fMaXuat; }
            set { SetPropertyValue<string>(nameof(MaXuat), ref fMaXuat, value); }
        }
        NhanVien fMaNhanVien;
        [Size(5)]
        [Association(@"XuatReferencesNhanVien")]
        public NhanVien MaNhanVien
        {
            get { return fMaNhanVien; }
            set { SetPropertyValue<NhanVien>(nameof(MaNhanVien), ref fMaNhanVien, value); }
        }
        SanPham fMaSanPham;
        [Size(5)]
        [Association(@"XuatReferencesSanPham")]
        public SanPham MaSanPham
        {
            get { return fMaSanPham; }
            set { SetPropertyValue<SanPham>(nameof(MaSanPham), ref fMaSanPham, value); }
        }
        DateTime fNgayXuat;
        public DateTime NgayXuat
        {
            get { return fNgayXuat; }
            set { SetPropertyValue<DateTime>(nameof(NgayXuat), ref fNgayXuat, value); }
        }
        int fSoLuong;
        public int SoLuong
        {
            get { return fSoLuong; }
            set { SetPropertyValue<int>(nameof(SoLuong), ref fSoLuong, value); }
        }
        double fDonGia;
        public double DonGia
        {
            get { return fDonGia; }
            set { SetPropertyValue<double>(nameof(DonGia), ref fDonGia, value); }
        }
        double fTongTien;
        public double TongTien
        {
            get { return fTongTien; }
            set { SetPropertyValue<double>(nameof(TongTien), ref fTongTien, value); }
        }
    }

}
