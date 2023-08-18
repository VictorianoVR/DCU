namespace ProyectoDCU.Models
{
    public class Usuario
    {
        [ColumnSqlAttribute("Id")]
        public int Id { get; set; }
        [ColumnSqlAttribute("Nombre")]
        public string Nombre { get; set; }
        [ColumnSqlAttribute("Correo")]
        public string Correo { get; set; }
        [ColumnSqlAttribute("Telefono")]
        public string Celular { get; set; }

    }
    public class ColumnSqlAttribute : Attribute
    {
        public string NameColumn { get; set; }

        public ColumnSqlAttribute(string nameColumn)
        {
            NameColumn = nameColumn;
        }
    }
}
