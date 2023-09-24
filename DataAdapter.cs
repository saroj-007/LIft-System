using System.Data;
using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lift
{
    internal class DataAdapter
    {
        static string dc = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source = ElevatorDb.accdb";
        static OleDbConnection Connection = new OleDbConnection(dc);
        static string datacommand = "SELECT * FROM ElevatorTable;";
        static OleDbCommand command = new OleDbCommand(datacommand, Connection);

        public void Install(string data)
        {
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataSet ds = new DataSet();
                OleDbCommandBuilder ocb = new OleDbCommandBuilder(da);
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                DataRow dr = dt.NewRow();
                dr["DateAndTime"] = DateTime.Now.ToString();
                dr["Activity"] = data;
                dt.Rows.Add(dr);
                DataSet dsl = ds.GetChanges();
                da.Update(dsl);
                dt.AcceptChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public DataSet View()
        {
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}