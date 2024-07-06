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

    public partial class DanhGia : XPLiteObject
    {
        string fMaDanhGia;
        [Key]
        [Size(5)]
        public string MaDanhGia
        {
            get { return fMaDanhGia; }
            set { SetPropertyValue<string>(nameof(MaDanhGia), ref fMaDanhGia, value); }
        }
        KhachHang fMaKhachHang;
        [Size(5)]
        [Association(@"DanhGiaReferencesKhachHang")]
        public KhachHang MaKhachHang
        {
            get { return fMaKhachHang; }
            set { SetPropertyValue<KhachHang>(nameof(MaKhachHang), ref fMaKhachHang, value); }
        }
        string fNoiDung;
        [Size(SizeAttribute.Unlimited)]
        public string NoiDung
        {
            get { return fNoiDung; }
            set { SetPropertyValue<string>(nameof(NoiDung), ref fNoiDung, value); }
        }
        int fDiemDanhGia;
        public int DiemDanhGia
        {
            get { return fDiemDanhGia; }
            set { SetPropertyValue<int>(nameof(DiemDanhGia), ref fDiemDanhGia, value); }
        }
        DateTime fNgayDanhGia;
        public DateTime NgayDanhGia
        {
            get { return fNgayDanhGia; }
            set { SetPropertyValue<DateTime>(nameof(NgayDanhGia), ref fNgayDanhGia, value); }
        }
    }

}