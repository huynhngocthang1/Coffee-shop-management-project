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
    public partial class SanPham
    {
        public SanPham(Session session) : base(session) { }
        public override void AfterConstruction() {
            if (Session.IsNewObject(this))
            {
                LastUpdated = DateTime.Now;
            }
         
            base.AfterConstruction(); }
         protected override void OnSaving()
    {
        base.OnSaving();
        Console.WriteLine("OnSaving event triggered");

            // Thực hiện hành động trước khi lưu đối tượng
            if (Session.IsNewObject(this))
        {
            // Đối tượng mới được tạo, thực hiện các thao tác cần thiết
            // Ví dụ: Kiểm tra tính duy nhất của mã sản phẩm
            SanPham existingProduct = Session.FindObject<SanPham>(CriteriaOperator.Parse("MaSanPham == ?", MaSanPham));
            if (existingProduct != null)
            {
                    throw new InvalidOperationException("Mã sản phẩm đã tồn tại. Vui lòng nhập mã khác.");
                }
        }
            

            // Thực hiện các thao tác khác nếu cần
        }
    }

}
