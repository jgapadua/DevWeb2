using Agenciaturismo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; //para funcionar Datatable
using DAL; //inclui a classe banco de dados


namespace Agenciaturismo.Classes
{
    public class Igreja : PontosTuristicos

    {
        private string estilo;
 
        private DALMysql dao = new DALMysql();




        public string Estilo { get => estilo; set => estilo = value; }


        public int Cadastrar_igreja()
        {

            string sql = string.Format("insert into igreja values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}')",Descricao,Cep,Num,Complemento,Data.ToString("yyy/MM/dd"),estilo,Cidade.Id);
            return dao.ExecutarQuery(sql);
        }
        public void Remover_igreja()
        {
            //sql Delete
            dao.ExecutarQuery("delete from igreja where idIgreja = " + Id);
        }
        public DataTable Listar_igreja()
        {
            //sql select
            return dao.ExecutarConsulta("select * from igreja");
        }
        public void AlterarDadosIgreja()
        {
            try
            {
                string sql = string.Format($@"UPDATE igreja SET descricaoIgreja = '{Descricao}',
                                                                cepIgreja = '{Cep}',
                                                                numIgreja = '{Num}',
                                                                complementoIgreja = '{Complemento}',
                                                                dataIgreja = '{Data.ToString("yyyy/MM/dd")}',
                                                                estiloIgreja = '{estilo}',
                                                                Cidade_idCidade = '{Cidade.Id}'
                                                                where idIgreja = '{Id}'");
                dao.ExecutarQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}