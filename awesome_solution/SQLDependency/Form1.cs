using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDependency
{
    public partial class Form1 : Form
    {
        public BindingSource m_objBindingSource;
        public Form1()
        {
            InitializeComponent();
            m_objBindingSource = new BindingSource();
            dataGridView1.DataSource = m_objBindingSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_objBindingSource.DataSource = DAL.ExecQuery();
            DAL.RefreshEvent += new RefreshHandler(RefreshCallback);
        }

        private void RefreshCallback(SqlNotificationEventArgs eventArgs)
        {
            dataGridView1.Invoke((MethodInvoker)(() =>
            {
                m_objBindingSource.DataSource = DAL.ExecQuery();
            }));

            listView1.Invoke((MethodInvoker)(() => {
                listView1.Items.Clear();
                listView1.Items.Add(string.Format("Info: {0}\n", eventArgs.Info.ToString()));
                listView1.Items.Add(string.Format("Source: {0}\n", eventArgs.Source.ToString()));
                listView1.Items.Add(string.Format("Type: {0}\n", eventArgs.Type.ToString()));
            }));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            VatTu frm = new VatTu(this.m_objBindingSource);
            frm.ShowDialog();
        }
    }
}
