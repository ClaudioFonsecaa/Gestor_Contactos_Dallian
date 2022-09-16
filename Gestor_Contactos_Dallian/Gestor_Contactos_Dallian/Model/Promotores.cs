using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor_Contactos_Dallian.Model
{
    public class Promotores
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]

        public string Name { get; set; }

        public string Pais { get; set; }

        public string Morada { get; set; }
        public string Contacto { get; set; }

        public string Responsavel { get; set; }


    }
}
