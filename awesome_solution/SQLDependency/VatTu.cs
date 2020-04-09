using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SQLDependency
{
    public partial class VatTu : Form
    {
        private BindingSource m_objBindingSrc;
        public VatTu(BindingSource x_bindingSource)
        {
            InitializeComponent();
            this.m_objBindingSrc = x_bindingSource;
            BindTextBoxWithDataGridView();
        }

        private void VatTu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = m_objBindingSrc;
        }

        private void bntGhi_Click(object sender, EventArgs e)
        {
            m_objBindingSrc.EndEdit();
            try
            {
                MessageBox.Show(string.Format("Đã lưu {0} thay đổi", DAL.ExecQueryNoneResult((DataTable)m_objBindingSrc.DataSource)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                m_objBindingSrc.DataSource = DAL.ExecQuery();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRowView dataRowView = (DataRowView)m_objBindingSrc.AddNew();
            //dataRowView.Row[1] = "VT1";
            m_objBindingSrc.MoveLast();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (m_objBindingSrc.Count > 0)
            {
                m_objBindingSrc.RemoveCurrent();
                m_objBindingSrc.MoveFirst();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BindTextBoxWithDataGridView()
        {
            txtMaVT.DataBindings.Add(new Binding("Text", m_objBindingSrc, "MaVT", false));
            txtTenVT.DataBindings.Add(new Binding("Text", m_objBindingSrc, "TenVT", false));
            txtSL.DataBindings.Add(new Binding("Text", m_objBindingSrc, "SoLuong", false));
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }
    }
}
