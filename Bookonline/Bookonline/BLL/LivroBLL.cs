using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;
using Bookonline.DTO;

namespace Bookonline.BLL
{
    public class LivroBLL
    {
        private readonly DALProjeto dao;
        public LivroBLL()
        {
            dao = new DALProjeto("localhost", "bd_Livraria", "root", "");
        }
        public DataTable ListarTodosLivros()
        {
            try
            {
                return dao.SelectAll("TBL_Livro");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CadastrarDadosLivro(Livro livro)
        {
            try
            {
                dao.Insert("TBL_Livro", livro);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AlterarDadosLivro(Livro livro)
        {
            try
            {
                dao.Update("TBL_Livro", livro, 0);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void ExcluirLivro(Livro livro)
        {
            try
            {
                dao.Delete("TBL_Livro", livro, 0);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public DataTable ConsultaLivro(string condicao)
        {
            try
            {
               return dao.ExecutarConsulta("SELECT titulo as Título, numPaginas as Número de Páginas, valor as Valor " + "nome as Autor"+ "nome as Editora FROM TBL_Livro inner JOIN TBL_Autor on idAutor = idAutor inner JOIN TBL_Editora on idEditora = idEditora WHERE" + condicao);
            }
            catch (Exception)
            {
                throw;
            }
        }

        SELECT column1, column2, ...
FROM table_name
WHERE condition;

    }
}