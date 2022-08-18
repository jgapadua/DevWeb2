using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class ClienteBLL
    {
        private readonly DALProjeto dao;
        public ClienteBLL()
        {
            dao = new DALProjeto("localhost", "bd_estacionamento", "root", "");
        }
        public DataTable ListarTodosClientes()
        {
            try
            {
                return dao.SelectAll("TBL_Cliente");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CadastrarDadosCliente(Cliente cliente)
        {
            try
            {
                dao.Insert("TBL_Cliente", cliente);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
     
    }
}