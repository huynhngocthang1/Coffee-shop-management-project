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

    public partial class ChiTietHoaDon : XPLiteObject
    {
        string fMaChiTietHoaDon;
        [Key]
        [Size(5)]
        public string MaChiTietHoaDon
        {
            get { return fMaChiTietHoaDon; }
            set { SetPropertyValue<string>(nameof(MaChiTietHoaDon), ref fMaChiTietHoaDon, value); }
        }
        HoaDon fMaHoaDon;
        [Size(5)]
        [Association(@"ChiTietHoaDonReferencesHoaDon")]
        public HoaDon MaHoaDon
        {
            get { return fMaHoaDon; }
            set { SetPropertyValue<HoaDon>(nameof(MaHoaDon), ref fMaHoaDon, value); }
        }
        SanPham fMaSanPham;
        [Size(5)]
        [Association(@"ChiTietHoaDonReferencesSanPham")]
        public SanPham MaSanPham
        {
            get { return fMaSanPham; }
            set { if (SetPropertyValue<SanPham>(nameof(MaSanPham), ref fMaSanPham, value)
                    && value != null && !IsLoading)
                    DonGia = value.Gia;
                    }
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
        public double ThanhTien
        {
            get
            {
                return SoLuong * DonGia;
            }
        }
    }

}
