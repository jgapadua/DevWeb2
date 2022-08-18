using Agenciaturismo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; //para funcionar Datatable
using DAL; //inclui a classe banco de dados


namespace Agenciaturismo.Classes
{
    public class CasaShow : PontosTuristicos

    {
        private int fechamento;

        private DALMysql dao = new DALMysql();




        public int Fechamento { get => fechamento; set => fechamento = value; }


        public int Cadastrar_casashow()
        {

            string sql = string.Format("insert into casashow values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Descricao, Cep, Num, Complemento, Data.ToString("yyy/MM/dd"), fechamento, Cidade.Id);
            return dao.ExecutarQuery(sql);
        }
        public void Remover_casashow()
        {
            //sql Delete
            dao.ExecutarQuery("delete from casashow where idShow = " + Id);
        }
        public DataTable Listar_casashow()
        {
            //sql select
            return dao.ExecutarConsulta("select * from casashow");
        }
        public void AlterarDadosCasaShow()
        {
            try
            {
                string sql = string.Format($@"UPDATE cidade SET descricaoShow = '{Descricao}',
                                                                cepShow = '{Cep}',
                                                                numShow = '{Num}',
                                                               complementoShow = '{Complemento}',
                                                              dataShow = '{Data.ToString("yyyy/MM/dd")}',
                                                             fechamentoShow = '{fechamento}',
                                                          Cidade_idCidade = '{Cidade.Id}'                                                            
                                                                where idCidade = '{Id}'");
                dao.ExecutarQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}