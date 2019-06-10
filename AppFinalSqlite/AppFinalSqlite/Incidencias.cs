using SQLite;
using System;
using System.Collections.Generic;
using System.Text;


namespace AppFinalSqlite
{
    public class Incidencias
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string responsable { get; set; }
        public string motivo { get; set; }
        public string tipoIncidencia { get; set; }
        public string fechaIncidencia { get; set; }
        public string estado { get; set; }
    }
}
