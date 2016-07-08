using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Colegio_Jean.Models
{
    public class PersonalModel : TemplateModel
    {
        public String usuario { get; set;}
        public String clave { get; set; }
        public String dni { get; set; }
        public String nombre { get; set; }
        public String apePaterno { get; set; }
        public String apeMaterno { get; set; }
        public DateTime fechaCreacion { get; set; }
        public String estado { get; set; }

        public Boolean autenticar() {
            String query = "SELECT * FROM personal WHERE usuario = @usuario AND clave = @clave";
            SqlConnection conexion = this.cn;
            SqlCommand cmd = new SqlCommand(query,conexion);
            cmd.Parameters.AddWithValue("@usuario", this.usuario);
            cmd.Parameters.AddWithValue("@clave", this.clave);
            SqlDataReader resultado= cmd.ExecuteReader();
            
            return resultado.Read();
        }


    }
}