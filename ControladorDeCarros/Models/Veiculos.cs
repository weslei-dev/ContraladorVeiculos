using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WebMvcRazorCshap.Models
{
    public class Veiculo
    {
        private readonly static string _conn = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public short Ano { get; set; }
        public short Fabricacao { get; set; }
        public string Cor { get; set; }
        public byte Combustivel { get; set; }
        public bool Automatico { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }



        public Veiculo() { }


        public Veiculo(int id, string nome, string modelo, short ano, short fabricacao,
        string cor, byte combustivel, bool automatico, decimal valor, bool ativo)
        {
            Id = id;
            Nome = nome;
            Modelo = modelo;
            Ano = ano;
            Fabricacao = fabricacao;
            Cor = cor;
            Combustivel = combustivel;
            Automatico = automatico;
            Valor = valor;
            Ativo = ativo;
        }

        public static List<Veiculo> GetCarros()
        {

            {
                var listaCarros = new List<Veiculo>();
                var sql = "SELECT * FROM tb_Veiculos";

                try
                {


                    using (var cn = new SqlConnection(_conn))
                    {
                        cn.Open();
                        using (var cmd = new SqlCommand(sql, cn))
                        {
                            using (var dr = cmd.ExecuteReader())
                            {
                                if (dr.HasRows)
                                {
                                    while (dr.Read())
                                    {
                                        listaCarros.Add(new Veiculo(
                                            Convert.ToInt32(dr["Id"]),
                                            dr["Nome"].ToString(),
                                            dr["Modelo"].ToString(),
                                            Convert.ToInt16(dr["Ano"]),
                                            Convert.ToInt16(dr["Fabricacao"]),
                                            dr["Cor"].ToString(),
                                            Convert.ToByte(dr["Combustivel"]),
                                            Convert.ToBoolean(dr["Automatico"]),
                                            Convert.ToDecimal(dr["Valor"]),
                                            true
                                            ));
                                    }
                                }

                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Falha: " + ex.Message);
                }
                return listaCarros;
            }
        }

        //public void Salvar()
        //{
        //    var sql = "INSERT INTO tb_veiculos (nome, modelo, ano, fabricacao, cor, combustivel, automatico, valor, ativo)" +
        //        "VALUES (@nome, @modelo, @ano, @fabricacao, @cor, @combustivel, @automatico, @valor, @ativo)";

        //    try
        //    {
        //        using (var cn = new SqlConnection(_conn))
        //        {
        //            cn.Open();
        //            using (var cmd = new SqlCommand(sql, cn))
        //            {
        //                cmd.Parameters.AddWithValue("@nome", Nome);
        //                cmd.Parameters.AddWithValue("@modelo", Modelo);
        //                cmd.Parameters.AddWithValue("@ano", Fabricacao);
        //                cmd.Parameters.AddWithValue("@fabricacao", Fabricacao);
        //                cmd.Parameters.AddWithValue("@cor", Cor);
        //                cmd.Parameters.AddWithValue("@combustivel", Combustivel);
        //                cmd.Parameters.AddWithValue("@automatico", Automatico);
        //                cmd.Parameters.AddWithValue("@valor", Valor);
        //                cmd.Parameters.AddWithValue("@ativo", Ativo);

        //                cmd.ExecuteNonQuery();

        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Falha: " + ex.Message);
        //    }
        //    return ;

    }
}

