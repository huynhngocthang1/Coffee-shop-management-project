using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace QLCP6_2.Module.BusinessObjects.QuanLyQuanCaPhe6
{

    public partial class TaiKhoan : XPLiteObject
    {
        string fMaTaiKhoan;
        [Key]
        [Size(5)]
        public string MaTaiKhoan
        {
            get { return fMaTaiKhoan; }
            set { SetPropertyValue<string>(nameof(MaTaiKhoan), ref fMaTaiKhoan, value); }
        }
        string fTenTaiKhoan;
        [Size(30)]
        public string TenTaiKhoan
        {
            get { return fTenTaiKhoan; }
            set { SetPropertyValue<string>(nameof(TenTaiKhoan), ref fTenTaiKhoan, value); }
        }
        string fMatKhau;
        [Size(255)]
        public string MatKhau
        {
            get { return fMatKhau; }
            set { SetPropertyValue<string>(nameof(MatKhau), ref fMatKhau, value); }
        }
        string fVaiTro;
        [Size(30)]
        public string VaiTro
        {
            get { return fVaiTro; }
            set { SetPropertyValue<string>(nameof(VaiTro), ref fVaiTro, value); }
        }
        [Association(@"KhachHangReferencesTaiKhoan")]
        public XPCollection<KhachHang> KhachHangs { get { return GetCollection<KhachHang>(nameof(KhachHangs)); } }
        [Association(@"NhanVienReferencesTaiKhoan")]
        public XPCollection<NhanVien> NhanViens { get { return GetCollection<NhanVien>(nameof(NhanViens)); } }
        [Association(@"QuanLyReferencesTaiKhoan")]
        public XPCollection<QuanLy> QuanLies { get { return GetCollection<QuanLy>(nameof(QuanLies)); } }
    }

}
