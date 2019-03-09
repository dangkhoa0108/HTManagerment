using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HTManagerment.Data.BusinessLogic;
using HTManagerment.Data.Model;

namespace HTManagement.UI
{
    public partial class UnitUpdateForm : XtraForm
    {
        public int Id = 0;
        public UnitUpdateForm()
        {
            InitializeComponent();
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtUnit.EditValue != null)
            {
                var input = txtUnit.EditValue.ToString();
                bool update;
                if (Id == 0)
                {
                    update = UnitService.UpdateUnit(new UnitModel
                    {
                        Value = input,
                        DateCreated = DateTime.Now,
                        Version = 1
                    });
                }
                else
                {
                    update = UnitService.UpdateUnit(new UnitModel
                    {
                        UnitId = Id,
                        Value = input
                    });
                }
                if (update)
                {
                    XtraMessageBox.Show("Lưu thành công", "Thông tin", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Có lỗi xảy ra, không thể lưu", "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Không thể bỏ trống trường đơn vị", "Cảnh báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BindingData()
        {
            if (Id > 0)
            {
                var data = UnitService.GetById(Id);
                txtUnit.EditValue = data.Value;
            }
        }

        private void UnitUpdateForm_Load(object sender, EventArgs e)
        {
            BindingData();
        }
    }
}