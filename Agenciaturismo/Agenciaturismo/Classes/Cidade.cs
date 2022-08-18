using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; //para funcionar Datatable
using DAL; //inclui a classe banco de dados

namespace Agenciaturismo.Classes
{
    public class Cidade
    {
        private int id;
        private string nome, uf;
        private int populacao;
        DALMysql dao = new DALMysql();

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Uf { get => uf; set => uf = value; }
        public int Populacao { get => populacao; set => populacao = value; }

        public int Cadastrar_cidade()
        {
            //sql insert
            //return dao.ExecutarQuery("insert into cidade values(null,'" + nome + "','" + uf + "','" + populacao + "')");
            string sql = string.Format("insert into cidade values(null,'{0}','{1}','{2}')", nome, uf, populacao);
            return dao.ExecutarQuery(sql);
        }
        public void Remover_cidade()
        {
            //sql Delete
            dao.ExecutarQuery("delete from cidade where idCidade = " + id);
        }
        public DataTable Listar_cidades()
        {
            //sql select
            return dao.ExecutarConsulta("Select * from cidade");
        }
        public DataTable ListarCidadesPorUF()
        {
            try
            {
                string sql = string.Format($@"SELECT * FROM cidade where ufCidade = '{uf}'");
                return dao.ExecutarConsulta(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable Visualizar_cidade(int id)
        {
            //sql select
            return dao.ExecutarConsulta("Select * from cidade where idCidade = " + id);
        }
        public DataTable Pesquisar_cidade(string nome,string uf)
        {
            if (nome != null && uf != null)
                return dao.ExecutarConsulta("Select * from cidade where nomeCidade =" + nome + "and ufCidade = " + uf);
            else if (nome != null)
                return dao.ExecutarConsulta("Select * from cidade where nomeCidade = " + nome);
            else
                return dao.ExecutarConsulta("Select * from cidade where ufCidade = " + uf);

        }
        public void AlterarDadosCidade()
        {
            try
            {
                string sql = string.Format($@"UPDATE cidade SET nomeCidade = '{nome}',
                                                                ufCidade = '{uf}',
                                                                populacaoCidade = '{populacao}'
                                                                where idCidade = '{id}'");
                dao.ExecutarQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}