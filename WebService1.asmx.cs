using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using Oracle.DataAccess.Client;
using System.Data;
using Newtonsoft.Json;

namespace WebApplication4
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string getdropdown()
        {
            try
            {
                var connection = ConfigurationManager.ConnectionStrings["uatprovider"].ConnectionString;
                using (OracleConnection conn = new OracleConnection(connection))
                {
                    string command1 = "SP_GET_DEPARTMENTS";
                    OracleCommand cmd1 = new OracleCommand(command1, conn);

                    cmd1.Parameters.Add("iDEPT", OracleDbType.Varchar2, 10, DBNull.Value.ToString());
                    cmd1.Parameters.Add("iSPECIALITY", OracleDbType.Varchar2, 2, DBNull.Value.ToString());
                    cmd1.Parameters.Add("oDATA", OracleDbType.RefCursor, ParameterDirection.Output);
                    conn.Open();
                    DataSet da1 = new DataSet();
                    OracleDataAdapter oda1 = new OracleDataAdapter();
                    oda1.SelectCommand = cmd1;
                    oda1.SelectCommand.CommandType = CommandType.StoredProcedure;
                    oda1.Fill(da1);
                    string json = JsonConvert.SerializeObject(da1 , Formatting.Indented);
                    return json;
                }
            }
            catch (Exception ee)
            {
                return ee.Message;
                
            }
        }

        [WebMethod]
        public string getdata(string dept_code, string from_date, string to_date)
        {
            try
            {
                var connection = ConfigurationManager.ConnectionStrings["uatprovider"].ConnectionString;
                using (OracleConnection conn = new OracleConnection(connection))
                {
                    string command = "countpatients";
                    OracleCommand cmd = new OracleCommand(command, conn);
                    cmd.Parameters.Add("p_list", OracleDbType.RefCursor, ParameterDirection.Output);
                    
                    cmd.Parameters.Add("from_date",  from_date.ToString());
                    cmd.Parameters.Add("to_date" ,  to_date.ToString());
                    if (dept_code == "-1")
                    {
                        cmd.Parameters.Add("dept_code", OracleDbType.Varchar2, 10, DBNull.Value.ToString());
                    }
                    else
                    {
                        cmd.Parameters.Add("dept_code", dept_code);
                    }
                    conn.Open();
                    DataSet da = new DataSet();
                    OracleDataAdapter oda = new OracleDataAdapter();
                    oda.SelectCommand = cmd;
                    oda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    oda.Fill(da);

                    //foreach (DataRow row in command.Rows)
                    //{
                    //    lstSales.Add(row["DAILY_SALES"].ToString());
                    //}


                    //var DailySales = new
                    //{
                    //    SALESTODAY = lstSales
                    //};

                    string json = JsonConvert.SerializeObject(da, Formatting.Indented);
                    return json;
                }
            }
            catch (OracleException oe)
            {
                return oe.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
