using System;
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
    public partial class QuanLy
    {
        public QuanLy(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
