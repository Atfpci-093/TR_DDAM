using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DemoPizza1.Registro
{
    public class TablaRegistro
    {

        [PrimaryKey, AutoIncrement]
        public int ID_Usurio { get; set; }
        [MaxLength(50)]

        public string T_Nombre { get; set; }
        [MaxLength(50)]
        public string T_Apellido { get; set; }
        [MaxLength(50)]
        public string T_Correo { get; set; }
        [MaxLength(100)]
        public string T_Contraseña { get; set; }
        [MaxLength(50)]
        public string T_NomUsuario{ get; set; }
    }
}
