using System;
using System.Collections.Generic;
using System.Data; //para funcionar o datatable
using MySql.Data.MySqlClient;

namespace DAL
{
    class DALProjeto : DALMysql
    {
        public DALProjeto(string servidor, string bancodedados, string usuario, string senha)
        {
            this.servidor = servidor ?? throw new ArgumentNullException(nameof(servidor));
            this.bancodedados = bancodedados ?? throw new ArgumentNullException(nameof(bancodedados));
            this.usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            this.senha = senha ?? throw new ArgumentNullException(nameof(senha));
        }

        public int Insert(string tabela, Object obj)
        {
            try
            {
                var propriedades = obj.GetType().GetProperties();
                string msg = $@"INSERT INTO {tabela} VALUES( ";
                foreach (var propriedade in propriedades)
                {
                    if (propriedade.GetType().Equals(typeof(DateTime)))
                        msg += $@"'{Convert.ToDateTime(propriedade.GetValue(obj)).ToString("yyyy/MM/dd")}',";
                    else if (Decimal.TryParse(propriedade.GetValue(obj).ToString(), out var x))
                        msg += $@"'{propriedade.GetValue(obj).ToString().Replace(',', '.')}',";
                    else
                        msg += $@"'{propriedade.GetValue(obj).ToString()}',";
                }
                msg = msg.Remove(msg.Length - 1);
                msg += ");";

                return ExecutarQuery(msg);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public int Delete(string tabela, Object obj, int indicePK)
        {
            try
            {
                var propriedades = obj.GetType().GetProperties();
                string msg = $@"DELETE FROM {tabela} 
                                   WHERE {propriedades[indicePK].Name} = {propriedades[indicePK].GetValue(obj).ToString()} ;";
                return ExecutarQuery(msg);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public int Update(string tabela, Object obj, int indicePK)
        {
            try
            {
                var propriedades = obj.GetType().GetProperties();

                string msg = $@"UPDATE {tabela} SET ";
                for (int i = 0; i < propriedades.Length; i++)
                {
                    if (i != indicePK)
                        if (propriedades[i].GetType().Equals(typeof(DateTime)))
                            msg += $@"{propriedades[i].Name} = '{Convert.ToDateTime(propriedades[i].GetValue(obj)).ToString("yyyy/MM/dd")}',";
                        else if (Decimal.TryParse(propriedades[i].GetValue(obj).ToString(), out var x))
                            msg += $@"{propriedades[i].Name} = '{propriedades[i].GetValue(obj).ToString().Replace(',', '.')}',";
                        else
                            msg += $@"{propriedades[i].Name} = '{propriedades[i].GetValue(obj).ToString()}',";
                }
                msg = msg.Remove(msg.Length - 1);
                msg += $@" where {propriedades[indicePK].Name} = {propriedades[indicePK].GetValue(obj).ToString()} ;";
                return ExecutarQuery(msg);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable SelectAll(string tabela)
        {
            try
            {
                string msg = $@"SELECT * FROM {tabela}";
                return ExecutarConsulta(msg);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable SelectWhere(string tabela, string condicao)
        {
            try
            {
                string msg = $@"SELECT * FROM {tabela} where {condicao}";
                return ExecutarConsulta(msg);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    abstract class DALMysql
    {

        protected string servidor, bancodedados, usuario, senha;

        MySqlConnection con;
        private void Conectar()
        {
            try
            {
                con = new MySqlConnection($@"server={servidor};uid={usuario};pwd={senha};database={bancodedados}");
                con.Open();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        protected int ExecutarQuery(string SQL) //insert, delete e update
        {
            try
            {
                Conectar();
                MySqlCommand cmd = new MySqlCommand(SQL, con);
                return cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }

        protected DataTable ExecutarConsulta(string SQL) //select
        {
            try
            {
                Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter(SQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}