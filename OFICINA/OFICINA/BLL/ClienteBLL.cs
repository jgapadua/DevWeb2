using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;
using OFICINA.DTO;

namespace OFICINA.BLL
{
    public class ClienteBLL
    {
        private readonly DALProjeto dao;
        public ClienteBLL()
        {
            dao = new DALProjeto("localhost", "oficina", "root", "");
        }
        public DataTable ListarTodosClientes()
        {
            try
            {
                return dao.SelectAll("cliente");
            }
            catch (Exception)
            {
                throw;
            }
        }
      
     
        public void CadastrarCliente(Cliente cliente)
        {
            try
            {
                dao.Insert("cliente", cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AlterarDadosCliente(Cliente cliente)
        {
            try
            {
                dao.Update("cliente", cliente, 0);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void ExcluirCliente(Cliente cliente)
        {
            try
            {
                dao.Delete("cliente", cliente, 0);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}