using Bookonline.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Bookonline.BLL
{
    public class AutorBLL
    {
        private readonly DALProjeto dao;
        public AutorBLL()
        {
            dao = new DALProjeto("localhost", "bd_Livraria", "root", "");
        }
        public DataTable ListarTodosAutores()
        {
            try
            {
                return dao.SelectAll("TBL_Autor");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CadastrarDadosAutor(Autor autor)
        {
            try
            {
                dao.Insert("TBL_Autor", autor);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AlterarDadosAutor(Autor autor)
        {
            try
            {
                dao.Update("TBL_Autor", autor, 0);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void ExcluirAutor(Autor autor)
        {
            try
            {
                dao.Delete("TBL_Autor", autor, 0);
            }
            catch (Exception)
            {
                throw;
            }

        }
       


    }
}
    
