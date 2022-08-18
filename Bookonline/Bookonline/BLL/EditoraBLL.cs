using Bookonline.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Bookonline.BLL
{
    public class EditoraBLL
    {
        private readonly DALProjeto dao;
        public EditoraBLL()
        {
            dao = new DALProjeto("localhost", "bd_Livraria", "root", "");
        }
        public DataTable ListarTodosEditoras()
        {
            try
            {
                return dao.SelectAll("TBL_Editora");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CadastrarDadosEditora(Editora editora)
        {
            try
            {
                dao.Insert("TBL_Editora", editora);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AlterarDadosEditora(Editora editora)
        {
            try
            {
                dao.Update("TBL_Editora", editora, 0);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void ExcluirEditora(Editora editora)
        {
            try
            {
                dao.Delete("TBL_Editora", editora, 0);
            }
            catch (Exception)
            {
                throw;
            }

        }



    }
}
    

 