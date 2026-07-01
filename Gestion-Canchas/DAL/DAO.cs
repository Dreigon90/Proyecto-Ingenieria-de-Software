using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BE;
using Services;

namespace DAL
{
    public class DAO
    {
        static SqlConnection mConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena"].ConnectionString); // Base "GestionCanchas"

        public DataSet EjecutarDataSet(string pCommandText, Dictionary<string, object> parametros = null)
        {
            try
            {
                using (SqlCommand mCom = new SqlCommand(pCommandText, mConexion))
                {
                    mCom.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                    {
                        foreach (var param in parametros)
                        {
                            mCom.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    using (SqlDataAdapter mDa = new SqlDataAdapter(mCom))
                    {
                        DataSet mDs = new DataSet();
                        mDa.Fill(mDs);
                        return mDs;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (mConexion.State != ConnectionState.Closed)
                    mConexion.Close();
            }

        }

        public int EjecutarNonQuery(string procedimiento, Dictionary<string, object> parametros = null)
        {
            try
            {
                SqlCommand comando = new SqlCommand(procedimiento, mConexion);

                comando.CommandType = CommandType.StoredProcedure;

                if (parametros != null)
                {
                    foreach (var param in parametros)
                    {
                        comando.Parameters.AddWithValue(
                            param.Key,
                            param.Value ?? DBNull.Value
                        );
                    }
                }

                mConexion.Open();

                return comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
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
