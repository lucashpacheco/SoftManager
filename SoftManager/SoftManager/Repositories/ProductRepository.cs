using SoftManager.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace SoftManager.Repositories
{
    public static class ProductRepository
    {
        private static readonly string _connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static List<Register> GetAllRegisters()
        {
            var query = "SELECT * FROM list_users";
            using (var conn = new SqlConnection(_connString))
            {
                var registers = conn.Query<Register>(query).ToList();

                return registers;
            }
        }

        public static List<DadosCliente> GetRegisterById(int codigo)
        {
            List<DadosCliente> produto = new List<DadosCliente>();

            using (var conn = new SqlConnection(_connString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())

                {
                    StringBuilder sql = new StringBuilder();

                    sql.Append("SELECT * FROM estoque WHERE codigo=");
                    sql.Append(codigo);

                    cmd.Connection = conn;
                    cmd.CommandText = sql.ToString();
                    

                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        DadosCliente cliente = new DadosCliente();

                        cliente.qtd = Convert.ToInt32(sqlDataReader["qtd"]);

                        cliente.valorsaida = float.Parse(sqlDataReader["valorsaida"].ToString());

                        cliente.desconto = float.Parse(sqlDataReader["desconto"].ToString());

                        produto.Add(cliente);
                      
                    }      

                }

                return produto;
            }
        }

        public static int InsertRegister(Register register)
        {
            var query = "INSERT INTO list_users(Nome,Apelido,Login,Senha,Obs) VALUES(@Nome,@Apelido,@Login,@Senha,@Obs)";

            using (var conn = new SqlConnection(_connString))
            {
                return conn.Execute(query, register);
            }
        }

        public static int UpdateRegister(Register register)
        {
            var query = "UPDATE list_users SET Nome=@Nome, Apelido=@Apelido, Login=@Login, Senha=@Senha, Obs=@Obs WHERE Id=@Id";

            using (var conn = new SqlConnection(_connString))
            {
                return conn.Execute(query, register);
            }
        }

        public static int DeleteRegister(int? id)
        {
            var query = "DELETE list_users WHERE Id=@id";

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand(query, conn))
            {
                return conn.Execute(query, new { id = id });
            }
        }
    }
}
