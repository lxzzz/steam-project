using System;
using System.Windows.Forms;
//C#编写代码,应用程序中访问数据库，需要在程序开始处引入下面2条相应的命名空间
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace ssj
{
    /// <summary>
    ///  Class1 的摘要说明
    /// </summary>
    public class DBOperation
    {
        public DBOperation()
        {
            //
            //  TODO: 在此处添加构造函数逻辑
            //
        }
        static public string getConnectString()
        {
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\db.mdb";
        }


        static public OleDbDataAdapter getAdapter(string cmdText)
        {


            OleDbCommand cm = new OleDbCommand(cmdText);

            cm.Connection = new OleDbConnection(getConnectString());


            OleDbDataAdapter da = new OleDbDataAdapter(cm);
            return da;
        }






        static public void DataGridBind(DataGrid dgObj, string strSQL)
        {

            OleDbConnection cn = new OleDbConnection();
            OleDbCommand cm = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();
            string sql = "select MATERIAL from material ";
            cm.CommandText = sql;
            OleDbDataReader reader = cm.ExecuteReader();
           // reader.

            DataTable td = new DataTable();
            try
            {
                cn.Open();
                da.Fill(td);
                cn.Close();
                if (td.Rows.Count > 0)
                {
                    dgObj.DataSource = td.DefaultView;
                    dgObj.CaptionText = "共有" + td.Rows.Count.ToString().Trim() + "条记录";
                }
                else
                {
                    dgObj.DataSource = null;
                    dgObj.CaptionText = "共有0条记录";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }
        //    static public System.Data.DataTable  getDataTable( string strSQL)
        //    {
        //        SqlConnection cn=new SqlConnection(getConnection());
        //        SqlDataAdapter da=new SqlDataAdapter(strSQL,cn);
        //        DataTable td=new DataTable();
        //        try
        //        {
        //            cn.Open();
        //            da.Fill(td);
        //            cn.Close();
        //            return td;
        //        }
        //        catch(SqlException ex)
        //        {
        //            MessageBox.Show(ex.ToString());
        //            return null;
        //        }
        //        finally
        //        {
        //            if(cn.State==ConnectionState.Open)
        //                cn.Close();				
        //        }
        //    }
        //    static public void  executeSQL( string strSQL)
        //    {
        //        SqlConnection cn=new SqlConnection(connect());
        //        SqlCommand  cm=new SqlCommand(strSQL,cn);
        //        try
        //        {
        //            cn.Open();
        //            cm.ExecuteNonQuery();
        //            cn.Close();
        //        }
        //        catch(SqlException ex)
        //        {
        //            MessageBox.Show(ex.ToString());
        //        }
        //        finally
        //        {
        //            if(cn.State==ConnectionState.Open)
        //                cn.Close();				
        //        }
        //    }

        //static public void TreeViewBind(TreeView TV, string strSQL,int iValueField,int iTextField )
        //{
        //    SqlConnection cn = new SqlConnection(connect());
        //    SqlDataAdapter adapter= new SqlDataAdapter();
        //    SqlCommand cm= new SqlCommand(strSQL,cn);
        //    DataTable dt = new DataTable();
        //    adapter.SelectCommand = cm;
        //    try
        //    {
        //        cn.Open();
        //        adapter.Fill(dt);
        //        cn.Close();
        //        TV.SelectedNode.Nodes.Clear();
        //        for(int i = 0;i<dt.Rows.Count;i++)
        //        {
        //            TreeNode nn=new TreeNode();
        //            nn.Text=dt.Rows[i].ItemArray[iTextField].ToString().Trim();
        //            nn.Tag=dt.Rows[i].ItemArray[iValueField].ToString().Trim();
        //            TV.SelectedNode.Nodes.Add(nn);
        //        }
        //        TV.SelectedNode.Expand();
        //     }
        //    catch( Exception ex )
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        dt = null;
        //        cm = null;
        //        adapter = null;
        //        cn = null;
        //    }
        //}
        //    static public void ComboBind(ComboBox comObj,string strSQL,string strTextFieldName,string strValueFieldName)
        //    {
        //        SqlConnection cn=new SqlConnection(connect());
        //        SqlDataAdapter da=new SqlDataAdapter(strSQL,cn);
        //        DataTable td=new DataTable();
        //        try
        //        {
        //            cn.Open();
        //            da.Fill(td);
        //            cn.Close();
        //            if(td.Rows.Count >0)
        //            {
        //                comObj.DataSource=td.DefaultView;
        //                comObj.DisplayMember=strTextFieldName;
        //                comObj.ValueMember=strValueFieldName;
        //            }
        //            else
        //            {
        //                comObj.DataSource =null;
        //                comObj.Items.Clear();
        //            }

        //        }
        //        catch(SqlException ex)
        //        {
        //            MessageBox.Show(ex.ToString());
        //        }
        //        finally
        //        {
        //            if(cn.State==ConnectionState.Open)
        //                cn.Close();
        //        }
        //    }
        //}
    }
}