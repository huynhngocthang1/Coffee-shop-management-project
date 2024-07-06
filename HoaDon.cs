﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
namespace QLCP6_2.Module.BusinessObjects.QuanLyQuanCaPhe6
{
    [DefaultClassOptions]
    public partial class HoaDon
    {
        public HoaDon(Session session) : base(session) { }
        public override void AfterConstruction() {
            if (Session.IsNewObject(this))
            {
                NgayDatHang = DateTime.Now;
            }
            base.AfterConstruction(); }
    }

}
