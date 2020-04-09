using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDependency
{
    public delegate void RefreshHandler(SqlNotificationEventArgs eventArgs);
    class DAL
    {
        public static event RefreshHandler RefreshEvent;

        private const string CONNECTION_STRING = @"Data Source =.\; Initial Catalog = SQLDependency; Integrated Security = True";
        private static SqlConnection m_objConn;

        private static void ConnectDB()
        {
            if (m_objConn != null)
            {
                if (m_objConn.State == ConnectionState.Open)
                {
                    return;
                }
            }

            m_objConn = new SqlConnection(CONNECTION_STRING);
            try
            {
                m_objConn.Open();
                SqlDependency.Start(CONNECTION_STRING);
            }
            catch (Exception)
            {

            }
        }

        public static DataTable ExecQuery()
        {
            DataTable dt = new DataTable();
            ConnectDB();
            SqlCommand objCmd = new SqlCommand("SELECT MaVT, TenVT, SoLuong FROM dbo.VatTu", m_objConn);
            SqlDependency sqlDependency = new SqlDependency(objCmd);
            sqlDependency.OnChange += SqlDependency_OnChange;
            SqlDataAdapter objDap = new SqlDataAdapter(objCmd);
            objDap.Fill(dt);
            return dt;
        }

        public static int ExecQueryNoneResult(DataTable dt)
        {
            ConnectDB();
            SqlCommand objCmd = new SqlCommand("SELECT MaVT, TenVT, SoLuong FROM dbo.VatTu", m_objConn);
            SqlDataAdapter objDap = new SqlDataAdapter(objCmd);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(objDap);
            try
            {
                return objDap.Update(dt);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static void SqlDependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            RefreshEvent(e);
        }
    }
}
