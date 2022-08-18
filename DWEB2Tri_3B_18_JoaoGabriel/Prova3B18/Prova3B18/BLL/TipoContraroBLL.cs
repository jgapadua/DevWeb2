using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class TipoContratoBLL
    {
        private readonly DALProjeto dao;
        public TipoContratoBLL()
        {
            dao = new DALProjeto("localhost", "bd_estacionamento", "root", "");
        }
        public DataTable ListarTodosTipos()
        {
            try
            {
                return dao.SelectAll("TBL_TipoContrato");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CadastrarDadosTodosTipos(TipoContrato tipocontrato)
        {
            try
            {
                dao.Insert("TBL_TipoContrato", tipocontrato);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}