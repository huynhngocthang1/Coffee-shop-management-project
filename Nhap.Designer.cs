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

    public partial class Nhap : XPLiteObject
    {
        string fMaNhap;
        [Key]
        [Size(5)]
        public string MaNhap
        {
            get { return fMaNhap; }
            set { SetPropertyValue<string>(nameof(MaNhap), ref fMaNhap, value); }
        }
        NhanVien fMaNhanVien;
        [Size(5)]
        [Association(@"NhapReferencesNhanVien")]
        public NhanVien MaNhanVien
        {
            get { return fMaNhanVien; }
            set { SetPropertyValue<NhanVien>(nameof(MaNhanVien), ref fMaNhanVien, value); }
        }
        SanPham fMaSanPham;
        [Size(5)]
        [Association(@"NhapReferencesSanPham")]
        public SanPham MaSanPham
        {
            get { return fMaSanPham; }
            set { SetPropertyValue<SanPham>(nameof(MaSanPham), ref fMaSanPham, value); }
        }
        DateTime fNgayNhap;
        public DateTime NgayNhap
        {
            get { return fNgayNhap; }
            set { SetPropertyValue<DateTime>(nameof(NgayNhap), ref fNgayNhap, value); }
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