using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BE;
using Security;

namespace DAL
{
    public class DAO
    {
        static SqlConnection mConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena"].ConnectionString); // Base ""

        public static DataSet EjecutarDataSet(string pCommand)
        {
            try
            {
                SqlDataAdapter mDa = new SqlDataAdapter(pCommand, mConexion);
                DataSet mDs = new DataSet();
                mDa.Fill(mDs);
                return mDs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (mConexion.State != ConnectionState.Closed)
                {
                    mConexion.Close();
                }
            }
        }

        public static int EjecutarNonQuery(string pCommand)
        {
            try
            {
                SqlCommand mCom = new SqlCommand(pCommand, mConexion);
                mConexion.Open();
                return mCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (mConexion.State != ConnectionState.Closed)
                {
                    mConexion.Close();
                }
            }
        }
    }
}
