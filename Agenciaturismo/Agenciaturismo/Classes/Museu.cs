using Agenciaturismo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; //para funcionar Datatable
using DAL; //inclui a classe banco de dados


namespace Agenciaturismo.Classes
{
    public class Museu : PontosTuristicos

    {

        private int sala;
    
        private DALMysql dao = new DALMysql();



        public int Salas { get => sala; set => sala = value; }
        public int Cadastrar_museu()
        {

            string sql = string.Format("insert into museu values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Descricao, Cep, Num, Complemento, Data.ToString("yyy/MM/dd"), sala, Cidade.Id);
            return dao.ExecutarQuery(sql);
        }
        public void Remover_museu()
        {
            //sql Delete
            dao.ExecutarQuery("delete from museu where idMuseu = " + Id);
        }
        public DataTable Listar_museu()
        {
            //sql select
            return dao.ExecutarConsulta("select * from museu");
        }


    }
}