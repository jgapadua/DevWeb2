using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class TagBLL
    {
        private readonly DALProjeto dao;
        public TagBLL()
        {
            dao = new DALProjeto("localhost", "stackoverflow", "root", "");
        }
        public DataTable ListarTodosTags()
        {
            try
            {
                return dao.SelectAll("tag");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CadastrarDadosTags(Tag tag)
        {
            try
            {
                dao.Insert("tag", tag);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AlterarDadosTags(Tag tag)
        {
            try
            {
                dao.Update("tag", tag, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ExcluirTags(Tag tag)
        {
            try
            {
                dao.Delete("tag", tag, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}