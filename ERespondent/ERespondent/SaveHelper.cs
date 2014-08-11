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
        private DataSet _ds;
        
        public SaveHelper(string year, string kodOkpo)
        {
            _conn.ConnectionString = ConfigurationManager.ConnectionStrings["ERConn"].ConnectionString;
            _conn.Open();
            _da =
                new SqlDataAdapter("SELECT  dbo.Reports.*, dbo.Section1_TER.*, dbo.Section2_MVT.*, " + 
                    "[Section3_Plan].* FROM         dbo.Reports INNER JOIN dbo.Section1_TER ON" + 
                    " dbo.Reports.Kod = dbo.Section1_TER.Kod INNER JOIN dbo.Section2_MVT ON"+
                    " dbo.Reports.Kod = dbo.Section2_MVT.Kod INNER JOIN dbo.[Section3_Plan] ON"+
                    " dbo.Reports.Kod = dbo.[Section3_Plan].Kod", _conn);
            
            _ds = new DataSet();
            _da.Fill(_ds, "Reports");

        }
    }
}
