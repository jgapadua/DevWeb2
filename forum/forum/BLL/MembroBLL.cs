using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class MembroBLL
    {
        private readonly DALProjeto dao; 
    public MembroBLL()
        {
            dao = new DALProjeto("localhost", "stackoverflow", "root", "");
        }
        public DataTable ListarTodosMembros()
        {
            try
            {
                return dao.SelectAll("membro");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CadastrarDadosMembros(Membro membro)
        {
            try
            {
                dao.Insert("membro", membro);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AlterarDadosMembro(Membro membro)
        {
            try
            {
                dao.Update("membro", membro, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ExcluirMembro(Membro membro)
        {
            try
            {
                dao.Delete("membro", membro, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Membro AutenticarMembro(Membro membro)
        {
            try
            {
                DataTable dt = dao.SelectWhere("membro", $"emailMembro = '{membro.EmailMembro}'and senhaMmebro='{membro.SenhaMembro}'");
                if (dt.Rows.Count == 1)
                {
                    membro.IdMembro = Convert.ToInt32(dt.Rows[0][0]);
                    membro.NomeMembro = dt.Rows[0][1].ToString();
                    membro.NickMembro = dt.Rows[0][2].ToString();
                    membro.EmailMembro = dt.Rows[0][3].ToString();
                    membro.EmailMembro = dt.Rows[0][3].ToString();
                    return membro;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}