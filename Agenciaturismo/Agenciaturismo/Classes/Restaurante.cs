using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; //para funcionar Datatable
using DAL; //inclui a classe banco de dados

namespace Agenciaturismo.Classes
{
    public class Restaurante
    {
        private int id;
        private string nome, complemento;
        private int cep, num, categoria;
        private Cidade cidade = new Cidade();
        private Hotel hotel = new Hotel();
        DALMysql dao = new DALMysql();


        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Cep { get => cep; set => cep = value; }
        public int Num { get => num; set => num = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public  Cidade Cidade { get => cidade; set => cidade = value; }
        public Hotel Hotel { get => hotel; set => hotel = value; }



        public int Cadastrar_restaurante()
        {
            //sql insert
            //return dao.ExecutarQuery("insert into restaurante values(null,'" + nome + "','" + endereco + "','" + categoria + "','" + cidade + "','" + hotel +"','")");
            string sql = string.Format("insert into restaurante values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}')", nome, cep, num, complemento, categoria, cidade.Id, hotel.Id);
            return dao.ExecutarQuery(sql);
        }
        public void Remover_restaurante()
        {
            //sql Delete
            dao.ExecutarQuery("delete from restaurante where idRestaurante = " + id);
        }
        public DataTable Listar_restaurantes()
        {
            //sql select
            return dao.ExecutarConsulta("Select * from restaurante");
        }


    }
}