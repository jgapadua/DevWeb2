using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;


namespace OFICINA.BLL
{
    public class ModeloBLL
    {
        private readonly DALProjeto dao;
        public ModeloBLL()
        {
            dao = new DALProjeto("localhost", "oficina", "root", "");
        }
        public DataTable ListarTodosModelos()
        {
            try
            {
                return dao.SelectAll("modelo");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
