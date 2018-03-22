using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Store_manage
{
    class DBProduct
    {
        SqlConnection con = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        public DataTable getAllCategory(ref string Error)
        {
            try
            {
                con.Open();
                SqlDataAdapter adpt = new SqlDataAdapter("select * from CategoryInfo", con);
                DataTable table = new DataTable();
                adpt.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable getAllStatus(ref string Error)
        {
            try
            {
                con.Open();
                SqlDataAdapter adpt = new SqlDataAdapter("select * from SolutionStatus", con);
                DataTable table = new DataTable();
                adpt.Fill(table);
                return table;

            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable getAllSellsData(ref string Error)
        {
            try
            {
                con.Open();
                SqlDataAdapter adpt = new SqlDataAdapter("select * from SalesInfo", con);
                DataTable table = new DataTable();
                adpt.Fill(table);
                return table;

            }
            catch (NullReferenceException ex)
            {
                Error = ex.Message;
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public double geProductQuantityCount(int ProductId, ref string Error)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select sum(PQuantity) from AllProduct where ProductId=" + ProductId, con);
                Object obj = cmd.ExecuteScalar();
                if (obj != null)
                {
                    return Int64.Parse(obj.ToString());
                }
                else
                {
                    return 0;
                }

            }
            catch (NullReferenceException ex)
            {
                Error = ex.Message;
                return 0;
            }
            finally
            {
                con.Close();
            }
        }



        //public void addProduct(string PN,double prc,double qunt,int CId ,ref string Error)
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        //    try
        //    {
        //        con.Open();
        //        string query = "INSERT INTO ProductInfo (PName,PPrice,PQuantity,CategoryId) VALUES ('" + PN + "','" + prc + "','" + qunt + "','" + CId + "')";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.ExecuteNonQuery();

        //    }
        //    catch (NullReferenceException ex)
        //    {
        //        Error = ex.Message;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}


        //public DataSet getAllProduct(ref string Error)
        //{
        //    try
        //    {
        //        con.Open();
        //        SqlDataAdapter adpt = new SqlDataAdapter("select ProductId,PName from AllProduct where CategoryId =@CategoryId", con);
        //        DataSet table = new DataSet();
        //        adpt.Fill(table);
        //        return table;

        //    }
        //    catch (Exception ex)
        //    {
        //        Error = ex.Message;
        //        return null;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
    }
}
  


