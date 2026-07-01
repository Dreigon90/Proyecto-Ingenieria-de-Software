using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AuditoriaDAL
    {
        DAO dao = new DAO();
        public void InsertarAuditoria(UsuarioMemento memento)
        {
            try
            {
                string commandText = "Auditoria_Insertar";
                var parametros = new Dictionary<string, object>
                {
                    {"@UsuarioId", memento.UsuarioId},
                    {"@EmailAnterior", memento.EmailAnterior},
                    {"@EmailActual", memento.EmailActual},
                    {"@Fecha", memento.Fecha},
                    {"@ModificadoPor", memento.ModificadoPor},
                    {"@Accion", memento.Accion}
                };

                dao.EjecutarNonQuery(commandText, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<UsuarioMemento> ObtenerAuditoria(int usuarioId)
        {
            try
            {
                string commandText = "Auditoria_ObtenerHistorial";
                var parametros = new Dictionary<string, object>
                {
                    {"@UsuarioId", usuarioId}
                };

                DataSet ds = dao.EjecutarDataSet(commandText, parametros);
                var lista = new List<UsuarioMemento>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    lista.Add(Mapear(row));
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UsuarioMemento ObtenerAuditoriaPorId(int idAuditoria)
        {
            try
            {
                string commandText = "Auditoria_ObtenerPorId";
                var parametros = new Dictionary<string, object>
                {
                    {"@IdAuditoria", idAuditoria}
                };

                DataSet ds = dao.EjecutarDataSet(commandText, parametros);
                if (ds.Tables[0].Rows.Count > 0)
                    return Mapear(ds.Tables[0].Rows[0]);

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private UsuarioMemento Mapear(DataRow row)
        {
            return new UsuarioMemento
            {
                IdAuditoria = Convert.ToInt32(row["IdAuditoria"]),
                UsuarioId = Convert.ToInt32(row["UsuarioId"]),
                EmailAnterior = row["EmailAnterior"].ToString(),
                EmailActual = row["EmailActual"].ToString(),
                Fecha = Convert.ToDateTime(row["Fecha"]),
                ModificadoPor = row["ModificadoPor"].ToString(),
                Accion = row["Accion"].ToString()
            };
        }


    }
}
