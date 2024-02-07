namespace marcatel_api.Models
{
    public class GetContactoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Alias { get; set; }
        public string Direccion { get; set; }
        public string NumMovil { get; set; }
        public string NumCasa { get; set; }
        public string Correo { get; set; }
        public string NumEmergencia { get; set; }
        public string Empresa { get; set; }
        public string Departamento { get; set; }
        public string Puesto { get; set; }
    }

    public class InsertContactoModel
    {
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Alias { get; set; }
        public string Direccion { get; set; }
        public string NumMovil { get; set; }
        public string NumCasa { get; set; }
        public string Correo { get; set; }
        public string NumEmergencia { get; set; }
        public string Empresa { get; set; }
        public string Departamento { get; set; }
        public string Puesto { get; set; }
    }

    public class UpdateContactoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Alias { get; set; }
        public string Direccion { get; set; }
        public string NumMovil { get; set; }
        public string NumCasa { get; set; }
        public string Correo { get; set; }
        public string NumEmergencia { get; set; }
        public string Empresa { get; set; }
        public string Departamento { get; set; }
        public string Puesto { get; set; }
    }

    public class DeleteContactoModel
    {
        public int Id { get; set; }
    }

}