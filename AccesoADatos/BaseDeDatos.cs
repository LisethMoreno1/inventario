using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace AccesoADatos
{
    public class BaseDeDatos
    {
        string cadConex;
        OleDbConnection cn;
        OleDbCommand cmd;

        public string BdMsgError { get; set; }

        public int BdCodeError { get; set; }

        public BaseDeDatos()
        {
            BdCodeError = 0;
            BdMsgError = "";
            cadConex = ConfigurationManager.ConnectionStrings["cadConexAccess"].ConnectionString;
        }

        public void Conectar()
        {
            try
            {
                cn = new OleDbConnection(cadConex);
                cn.Open();
            }
            catch (OleDbException ex)
            {
                BdCodeError = ex.ErrorCode;
                BdMsgError = ex.Message;
                Desconectar();
            }
        }

        public void Desconectar()
        {
            if (cn != null)
            {
                cn.Close();
                cn.Dispose();
                cn = null;
            }
        }

        public void CrearComando(string pComando, CommandType pTipo)
        {
            cmd = new OleDbCommand(pComando, cn);
            cmd.CommandType = pTipo;
        }

        public void AsignarParametro(string pNombre, OleDbType pTipo, object pValor)
        {
            cmd.Parameters.Add(pNombre, pTipo).Value = pValor;
        }

        public int EjecutarComando()
        {
            int numReg = 0;
            try
            {
                numReg = cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                BdCodeError = ex.ErrorCode;
                BdMsgError = ex.Message;
                Desconectar();
            }
            return numReg;
        }

        public OleDbDataReader EjecutarConsultaReader() => cmd.ExecuteReader();

        public DataTable EjecutarConsulta()
        {
            var dt = new DataTable();
            var da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}
