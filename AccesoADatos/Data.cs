using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    public class Data
    {
        BaseDeDatos bd;
        public void Preparar(string pComando, CommandType pTipo)
        {
            bd = new BaseDeDatos();
            bd.Conectar();
            bd.CrearComando(pComando, pTipo);

        }

        public void AsignarParametro(string pNombre, OleDbType pTipo, object pValor)
        {
            bd.AsignarParametro(pNombre, pTipo, pValor);
        }

        public DataTable CargarDt()
        {
            var dt = bd.EjecutarConsulta();
            bd.Desconectar();
            return dt;

        }

        public DataTable CargarDt(string pComando, CommandType pTipo)
        {
            Preparar(pComando, pTipo);
            return CargarDt();
        }
    }
}
