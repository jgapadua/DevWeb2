using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;

namespace Municipios.BLL
{
    public class MunicipioBLL
    {
        private readonly DALProjeto dao;
        public MunicipioBLL()
        {
            dao = new DALProjeto("localhost", "bdcidades", "root", "");
        }
        public DataTable ListarTodosMunicipios()
        {
            try
            {
                return dao.SelectAll("Municipio");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable ConsultaMunicipio(string condicao)
        {
            try
            {
                return dao.ExecutarConsulta("SELECT Codigo as Codigo, Nome as Nome, Uf as UF FROM Municipio WHERE " + condicao);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}