using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WebMvcRazorCshap.Models
{
    public class Remover : Veiculo
    {

        private readonly static string _conn = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public void Excluir()
        {
            var sql = "DELETE FROM tb_Veiculos WHERE id =" + Id;
            try
            {
                using (var cn = new SqlConnection(_conn))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha: " + ex.Message);
            }
        }
    }
}