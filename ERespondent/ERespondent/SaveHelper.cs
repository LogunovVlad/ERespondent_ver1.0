using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ERespondent
{
    class SaveHelper
    {
        private MainForm _formMain;
        private ReportPanel _formReportPanel;

        private SqlConnection _conn = new SqlConnection();
        private SqlDataAdapter _da;
        private DataSet _dsReports=new DataSet();

        private SqlCommand _daUpdateCmnd;

        public SaveHelper(string year, string kodOkpo)
        {
            _conn.ConnectionString = ConfigurationManager.ConnectionStrings["ERConn"].ConnectionString;
            _conn.Open();

            CreateNewTemp();
        }

        public void CreateNewTemp()
        {
            try
            {
                _da = new SqlDataAdapter();

                //SelectCommand
                SqlCommand cmndSelect = new SqlCommand("SELECT * FROM Reports", _conn);
                _da.SelectCommand = cmndSelect;

                //InsertCommand
                SqlCommand cmndInsert =
                    new SqlCommand("INSERT INTO Reports (KodOrganization, NameOrganization, Year, Edit)"+
                "VALUES (@KodOrganization, @NameOrganization, @Year, @Edit)",_conn);
                cmndInsert.Parameters.Add(new SqlParameter("@KodOrganization", SqlDbType.BigInt));
                cmndInsert.Parameters["@KodOrganization"].SourceVersion = DataRowVersion.Current;
                cmndInsert.Parameters["@KodOrganization"].SourceColumn = "KodOrganization";

                cmndInsert.Parameters.Add(new SqlParameter("@NameOrganization", SqlDbType.Text));
                cmndInsert.Parameters["@NameOrganization"].SourceVersion = DataRowVersion.Current;
                cmndInsert.Parameters["@NameOrganization"].SourceColumn = "NameOrganization";

                cmndInsert.Parameters.Add(new SqlParameter("@Year", SqlDbType.Text));
                cmndInsert.Parameters["@Year"].SourceVersion = DataRowVersion.Current;
                cmndInsert.Parameters["@Year"].SourceColumn = "Year";

                cmndInsert.Parameters.Add(new SqlParameter("@Edit", SqlDbType.DateTime));
                cmndInsert.Parameters["@Edit"].SourceVersion = DataRowVersion.Current;
                cmndInsert.Parameters["@Edit"].SourceColumn = "Edit";
                _da.InsertCommand = cmndInsert;

                //UpdateCommand
                SqlCommand cmndUpdate = new SqlCommand("UPDATE Reports set KodOrganization=@KodOrganization, " +
                                                       "NameOrganization=@NameOrganization, Year=@Year, Edit=@Edit "+
                                                       "where ReportId=@ReportId",_conn);
                cmndUpdate.Parameters.Add(new SqlParameter("@KodOrganization", SqlDbType.BigInt));
                cmndUpdate.Parameters["@KodOrganization"].SourceVersion = DataRowVersion.Current;
                cmndUpdate.Parameters["@KodOrganization"].SourceColumn = "KodOrganization";

                cmndUpdate.Parameters.Add(new SqlParameter("@NameOrganization", SqlDbType.Text));
                cmndUpdate.Parameters["@NameOrganization"].SourceVersion = DataRowVersion.Current;
                cmndUpdate.Parameters["@NameOrganization"].SourceColumn = "NameOrganization";

                cmndUpdate.Parameters.Add(new SqlParameter("@Year", SqlDbType.Text));
                cmndUpdate.Parameters["@Year"].SourceVersion = DataRowVersion.Current;
                cmndUpdate.Parameters["@Year"].SourceColumn = "Year";

                cmndUpdate.Parameters.Add(new SqlParameter("@Edit", SqlDbType.DateTime));
                cmndUpdate.Parameters["@Edit"].SourceVersion = DataRowVersion.Current;
                cmndUpdate.Parameters["@Edit"].SourceColumn = "Edit";

                cmndUpdate.Parameters.Add(new SqlParameter("@ReportId", SqlDbType.Int));
                cmndUpdate.Parameters["@ReportId"].SourceVersion = DataRowVersion.Original;
                cmndUpdate.Parameters["@ReportId"].SourceColumn = "ReportId";
                _da.UpdateCommand = cmndUpdate;

                //Deletecomand
                SqlCommand cmndDelete = new SqlCommand("DELETE FROM Reports where ReportId=@ReportId",_conn);
                cmndDelete.Parameters.Add(new SqlParameter("@ReportId", SqlDbType.Int));
                cmndDelete.Parameters["@ReportId"].SourceVersion = DataRowVersion.Original;
                cmndDelete.Parameters["@ReportId"].SourceColumn = "ReportId";
                _da.DeleteCommand = cmndDelete;                
            }
            catch (Exception ex)
            {
                string t=ex.Message;
            }
            _da.Fill(_dsReports, "Reports");

            DataTable table = new DataTable();
            table = _dsReports.Tables["Reports"];
            DataRow newRow = table.NewRow();
            newRow["KodOrganization"] = 123123;
            newRow["NameOrganization"] = "sdfsdf";
            newRow["Year"] = "1990";
            newRow["Edit"] = "2010-01-02";

            table.Rows.Add(newRow);

            
            _da.Update(_dsReports,"Reports");
        }
    }
}
