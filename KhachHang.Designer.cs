﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace QLCP6_2.Module.BusinessObjects.QuanLyQuanCaPhe6
{

    public partial class KhachHang : XPLiteObject
    {
        string fMaKhachHang;
        [Key]
        [Size(5)]
        public string MaKhachHang
        {
            get { return fMaKhachHang; }
            set { SetPropertyValue<string>(nameof(MaKhachHang), ref fMaKhachHang, value); }
        }
        TaiKhoan fMaTaiKhoan;
        [Indexed(Name = @"UQ__KhachHan__AD7C6528B0D9CADA", Unique = true)]
        [Size(5)]
        [Association(@"KhachHangReferencesTaiKhoan")]
        public TaiKhoan MaTaiKhoan
        {
            get { return fMaTaiKhoan; }
            set { SetPropertyValue<TaiKhoan>(nameof(MaTaiKhoan), ref fMaTaiKhoan, value); }
        }
        string fGioiTinh;
        [Size(3)]
        public string GioiTinh
        {
            get { return fGioiTinh; }
            set { SetPropertyValue<string>(nameof(GioiTinh), ref fGioiTinh, value); }
        }
        string fHoTen;
        [Size(30)]
        public string HoTen
        {
            get { return fHoTen; }
            set { SetPropertyValue<string>(nameof(HoTen), ref fHoTen, value); }
        }
        string fEmail;
        [Size(30)]
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
        string fSoDienThoai;
        [Size(15)]
        public string SoDienThoai
        {
            get { return fSoDienThoai; }
            set { SetPropertyValue<string>(nameof(SoDienThoai), ref fSoDienThoai, value); }
        }
        string fDiaChi;
        [Size(30)]
        public string DiaChi
        {
            get { return fDiaChi; }
            set { SetPropertyValue<string>(nameof(DiaChi), ref fDiaChi, value); }
        }
        [Association(@"BanReferencesKhachHang")]
        public XPCollection<Ban> Bans { get { return GetCollection<Ban>(nameof(Bans)); } }
        [Association(@"DanhGiaReferencesKhachHang")]
        public XPCollection<DanhGia> DanhGias { get { return GetCollection<DanhGia>(nameof(DanhGias)); } }
        [Association(@"HoaDonReferencesKhachHang")]
        public XPCollection<HoaDon> HoaDons { get { return GetCollection<HoaDon>(nameof(HoaDons)); } }
    }

}
