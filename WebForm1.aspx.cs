using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
using System.Configuration;
using System.Data;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //calender1.Visible = false;
                //calendar2.Visible = false;
                ////////////////

                //try
                //{
                //    var connection = ConfigurationManager.ConnectionStrings["uatprovider"].ConnectionString;
                //    using (OracleConnection conn = new OracleConnection(connection))
                //    {
                //        string command1 = "SP_GET_DEPARTMENTS";
                //        OracleCommand cmd1 = new OracleCommand(command1, conn);

                //        cmd1.Parameters.Add("iDEPT", OracleDbType.Varchar2, 10, DBNull.Value.ToString());
                //        cmd1.Parameters.Add("iSPECIALITY", OracleDbType.Varchar2, 2, DBNull.Value.ToString());
                //        cmd1.Parameters.Add("oDATA", OracleDbType.RefCursor, ParameterDirection.Output);
                //        conn.Open();

                //        DataSet da1 = new DataSet();
                //        OracleDataAdapter oda1 = new OracleDataAdapter();
                //        oda1.SelectCommand = cmd1;
                //        oda1.SelectCommand.CommandType = CommandType.StoredProcedure;
                //        oda1.Fill(da1);
                //        deptdropdown.DataSource = da1;
                //        deptdropdown.DataBind();
                //        deptdropdown.Items.Insert(0, new ListItem("ALL"));
                //    }
                //}
                //catch (Exception ee)
                //{
                //    Response.Write(ee.Message);
                //}

               
          }
        //protected void submitbutton_Click(object sender, EventArgs e)
        //{
        //    //var connection = ("Data Source =uat ; User ID = WHISPROD ; Password = test ;");
        //    try
        //    {
        //        var connection = ConfigurationManager.ConnectionStrings["uatprovider"].ConnectionString;
        //        using (OracleConnection conn = new OracleConnection(connection))
        //        {
        //            string command = "countpatients";
        //            OracleCommand cmd = new OracleCommand(command , conn);
        //            cmd.Parameters.Add("p_list", OracleDbType.RefCursor, ParameterDirection.Output);
        //            cmd.Parameters.Add("from_date", textbox1.Text);
        //            cmd.Parameters.Add("to_date", textbox2.Text);
        //            if(deptdropdown.SelectedValue == ("ALL"))
        //            {
        //                cmd.Parameters.Add("dept_code" , OracleDbType.Varchar2 , 10 , " ");
        //            }
        //            else
        //            {
        //                cmd.Parameters.Add("dept_code", deptdropdown.SelectedValue);
        //            }
        //            DataSet da = new DataSet();
        //            OracleDataAdapter oda = new OracleDataAdapter();
        //            oda.SelectCommand = cmd;
        //            oda.SelectCommand.CommandType = CommandType.StoredProcedure;
        //            oda.Fill(da);
        //            GridView1.DataSource = da;
        //            GridView1.DataBind();
        //        }
        //    }
        //    catch (OracleException oe)
        //    {
        //        Response.Write(oe.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message);
        //    }
        //    finally
        //    {

        //    }
        }
    }
}