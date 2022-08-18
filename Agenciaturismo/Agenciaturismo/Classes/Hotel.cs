using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; //para funcionar Datatable
using DAL; //inclui a classe banco de dados

namespace Agenciaturismo.Classes
{
    public class Hotel
    {
        private int id;
        private string nome, complemento;
        private int cep, num, categoria;
        private Cidade cidade = new Cidade();
        DALMysql dao = new DALMysql();


        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Cep { get => cep; set => cep = value; }
        public int Num { get => num; set => num = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public Cidade Cidade { get => cidade; set => cidade = value; }

        public int Cadastrar_hotel()
        {
            //sql insert
            //return dao.ExecutarQuery("insert into hotel values(null,'" + nome + "','" + endereco + "','" + categoria + "','" + tipos_quartos + "','" + numero_quartos + "','" + valor_diaria + "')");
            string sql = string.Format("insert into hotel values(null,'{0}','{1}','{2}','{3}','{4}','{5}')", nome, cep, num, complemento, categoria, cidade.Id);
            return dao.ExecutarQuery(sql);
        }
        public void Remover_hotel()
        {
            //sql Delete
            dao.ExecutarQuery("delete from hotel where idHotel = " + id);
        }
        public DataTable Listar_hoteis()
        {
            //sql select
            return dao.ExecutarConsulta("Select * from hotel");
        }
      
        
    }
}