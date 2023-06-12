using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Database
{
    public class Base : IBase
    {
        private string connectionString = ConfigurationManager.AppSettings["DataSource"];
        public List<T> Buscar<T>(int id)
        {
            var lista = new List<T>();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string sql;

                sql = "select * from " + this.GetType().Name + " where Id=" + id;


                MySqlCommand mySql = new MySqlCommand(sql, con);
                mySql.Connection.Open();
                MySqlDataReader myDataReader = mySql.ExecuteReader();

                // como eu me sinto neste exato momento https://www.youtube.com/watch?v=CZu9nSlj6i8
                // tin ta ra tin tin tin ton ta ta tara teun tin tin tin tin ton *barulhos de beatbox*

                while (myDataReader.Read())
                {
                    var obj = (IBase)Activator.CreateInstance(this.GetType());
                    foreach (PropertyInfo info in obj.GetType().GetProperties(
                        BindingFlags.Public | BindingFlags.Instance))
                    {
                        OpcoesBase opcoes = (OpcoesBase)info.GetCustomAttribute
                            (typeof(OpcoesBase));
                        if (opcoes != null)
                        {
                            info.SetValue(obj, myDataReader[info.Name]);
                        }
                    }
                    lista.Add((T)obj);
                }
                return lista;

            }
        }

        private string tipoPropriedade(PropertyInfo pi)
        {
            switch(pi.PropertyType.Name)
            {
                case "Int32":
                    return "int";
                case "int64":
                    return "bigint";
                case "double":
                    return "decimal(9, 2)";
                case "DateTime":
                    return "datetime";
                default:
                    return "varchar(255)";
            }
        }

        public void CriarTabela()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                List<string> campos = new List<string>();
                string chavePrimaria = "";
                foreach(PropertyInfo pi in this.GetType().GetProperties
                    (BindingFlags.Public | BindingFlags.Instance))
                {
                    OpcoesBase opcoesBase = (OpcoesBase)pi.GetCustomAttribute(
                        typeof(OpcoesBase));

                    // Caso a propriedade que esta sendo lida no momento nao tenha opcoes base valida sendo null
                    // Vamos continuar o laco ate que ele finalize.
                    // Ou seja se propriedade nao possui annotation UsaDB, ela nao vai fazer parte da tabela (reflection).
                    if (opcoesBase == null) continue;
                    
                    if (opcoesBase.ChavePrimaria)
                    {
                        chavePrimaria = pi.Name + " int auto_increment primary key";
                    }
                    else
                    {
                        campos.Add(pi.Name + " " + tipoPropriedade(pi) + " ");
                    }
                }
                string sql = "create table if not exists " + this.GetType().Name + " (";
                sql += chavePrimaria + ", ";
                sql += string.Join(", ", campos.ToArray())+");";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
        }

        public void Excluir(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = "delete from " + this.GetType().Name + " where id=" + id; // eu quando
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        public int Key
        {
            get
            {
                foreach (PropertyInfo pi in this.GetType().GetProperties(
                    BindingFlags.Public | BindingFlags.Instance))
                {
                    OpcoesBase opcoes = (OpcoesBase)pi.GetCustomAttribute(typeof(OpcoesBase));
                    if (opcoes != null && opcoes.ChavePrimaria)
                    {
                        return Convert.ToInt32(pi.GetValue(this));
                    }
                }
                return 0;
            }
        }

        public void Salvar()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                List<string> campos = new List<string>();
                List<string> valores = new List<string>();
                foreach(PropertyInfo pi in this.GetType().GetProperties
                    ( BindingFlags.Public | BindingFlags.Instance)) { 
                    OpcoesBase opcoes = (OpcoesBase)pi.GetCustomAttribute
                        (typeof(OpcoesBase));

                    if (opcoes == null) continue; 

                    if(this.Key == 0)
                    {
                        campos.Add(pi.Name);
                        valores.Add("'" + pi.GetValue(this) + "'"); 
                    }
                    else
                    {
                        if(!opcoes.ChavePrimaria)
                        {
                            valores.Add(pi.Name + "='" + pi.GetValue(this) + "'");
                        }
                    }
                }
                string sql = "";
                if (this.Key == 0)
                {
                    // Arrancando os campo de id porque auto increment no MySql nao precisa passar id na query
                    campos.RemoveAt(0); // 0 = campo do Id "INSERT INTO (Id <- esse aqui, Nome) VALUES (Id, Nome)"
                    valores.RemoveAt(0); // 0 = valor do Id "INSERT INTO (Id, Nome) VALUES (Id <- esse aqui, Nome)"
                    // Apos eu escrever essas duas linhas eu comecei a questionar a minha vida

                    sql = "insert into " + this.GetType().Name + "(";
                    sql += string.Join(", ", campos.ToArray());
                    sql += ") values (" + string.Join(", ", valores.ToArray()) + ")";
                }
                else
                {
                    sql = "update " + this.GetType().Name + " set ";
                    sql += string.Join(", ", valores.ToArray()) + " where Id=" + this.Key;
                }
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        public List<IBase> Todos()
        {
            var lista = new List<IBase>();
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                List<string> where = new List<string>();
                string chavePrimaria = string.Empty;

                string sql;
                if (Key == 0)
                {
                    sql = "select * from " + this.GetType().Name;
                    if (where.Count > 0)
                    {
                        sql += " where " + string.Join("or ", where.ToArray());
                    }
                }
                else
                {
                    sql = "select * from " + this.GetType().Name + " where "
                        + chavePrimaria;
                }

                MySqlCommand mySql = new MySqlCommand(sql, con);
                mySql.Connection.Open();
                MySqlDataReader myDataReader = mySql.ExecuteReader();
                while (myDataReader.Read())
                {
                    var obj = (IBase)Activator.CreateInstance(this.GetType());
                    foreach (PropertyInfo info in obj.GetType().GetProperties(
                        BindingFlags.Public | BindingFlags.Instance))
                    {
                        OpcoesBase opcoes = (OpcoesBase)info.GetCustomAttribute
                            (typeof(OpcoesBase));
                        if (opcoes != null)
                        {
                            info.SetValue(obj, myDataReader[info.Name]);
                        }    
                    }
                    lista.Add(obj);
                }
                return lista;
            }
        }
    
        // Sim, vamos implementar essa interface aqui
        // mesmo que nao esteja sendo usada, o motivo eh porque 
        // temos que respeitar o contrato entre a interface a classe.
        int IBase.Key()
        {
            throw new NotImplementedException();
        }
  
    }
}
