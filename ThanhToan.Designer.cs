using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace QLCP6_2.Module.BusinessObjects.QuanLyQuanCaPhe6
{

    public partial class ThanhToan : XPLiteObject
    {
        string fMaThanhToan;
        [Key]
        [Size(5)]
        public string MaThanhToan
        {
            get { return fMaThanhToan; }
            set { SetPropertyValue<string>(nameof(MaThanhToan), ref fMaThanhToan, value); }
        }
        HoaDon fMaHoaDon;
        [Size(5)]
        [Association(@"ThanhToanReferencesHoaDon")]
        public HoaDon MaHoaDon
        {
            get { return fMaHoaDon; }
            set { SetPropertyValue<HoaDon>(nameof(MaHoaDon), ref fMaHoaDon, value); }
        }
        DateTime fNgayThanhToan;
        public DateTime NgayThanhToan
        {
            get { return fNgayThanhToan; }
            set { SetPropertyValue<DateTime>(nameof(NgayThanhToan), ref fNgayThanhToan, value); }
        }
        double fSoTien;
        public double SoTien
        {
            get { return fSoTien; }
            set { SetPropertyValue<double>(nameof(SoTien), ref fSoTien, value); }
        }
        string fPhuongThucThanhToan;
        [Size(30)]
        public string PhuongThucThanhToan
        {
            get { return fPhuongThucThanhToan; }
            set { SetPropertyValue<string>(nameof(PhuongThucThanhToan), ref fPhuongThucThanhToan, value); }
        }
    }

}
