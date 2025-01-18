using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLySinhVien
{
    public partial class GiaoDien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            LichHoc LH = new LichHoc();
            LH.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            CaNhan CN = new CaNhan();
            CN.ShowDialog();
        }

        private void bbtKhoiPhuc_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbtThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            SinhVien SV = new SinhVien();
            SV.ShowDialog();
        }

        private void bbtGiaDinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GiaDinh GD = new GiaDinh();
            GD.ShowDialog();
        }

        private void bbtLienHe_ItemClick(object sender, ItemClickEventArgs e)
        {
            LienHe LH = new LienHe();
            LH.ShowDialog();
        }

        private void bbtDiemHocTap_ItemClick(object sender, ItemClickEventArgs e)
        {
            DiemHocTap DHT = new DiemHocTap();
            DHT.ShowDialog();
        }

        private void bbtDiemRenLuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            DiemRenLuyen DRL = new DiemRenLuyen();
            DRL.ShowDialog();
        }

        private void bbtKhenThuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            KhenThuong KT = new KhenThuong();
            KT.ShowDialog();
        }

        private void bbtCanhBao_ItemClick(object sender, ItemClickEventArgs e)
        {
            CanhCao CC= new CanhCao();
            CC.ShowDialog();
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            HocPhi HP = new HocPhi();
            HP.ShowDialog();
        }

        private void bbtMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            DangKyMonHoc DKMH = new DangKyMonHoc();
            DKMH.ShowDialog();
        }

        private void bbtHocLaiCaiThien_ItemClick(object sender, ItemClickEventArgs e)
        {
            HocLaiCaiThien HLCT = new HocLaiCaiThien();
            HLCT.ShowDialog();
        }

        private void bbtCaiThienDiemThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            CaiThienDiemThi CTDT = new CaiThienDiemThi();
            CTDT.ShowDialog();
        }
    }
}