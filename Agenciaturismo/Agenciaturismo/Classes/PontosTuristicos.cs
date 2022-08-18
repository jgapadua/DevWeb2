using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; //para funcionar Datatable
using DAL; //inclui a classe banco de dados

namespace Agenciaturismo.Classes
{
    public abstract class PontosTuristicos
    {
        private int id;
        private int cep, num;
        private string descricao, complemento;
        private DateTime data;
        private Cidade cidade = new Cidade();
        private DALMysql dao = new DALMysql();


        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Cep { get => cep; set => cep = value; }
        public int Num { get => num; set => num = value; }
       public string Complemento { get => complemento; set => complemento = value; }
        public DateTime Data { get => data; set => data = value; }
        public Cidade Cidade { get => cidade; set => cidade = value; }



    }
}