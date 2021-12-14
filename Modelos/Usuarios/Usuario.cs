using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos.Usuarios
{
    public class Usuario
    {
        public int id { get; set; }
        public String usuario { get; set; }
        public String nombre { get; set; }
        public String apellidoMaterno { get; set; }
        public String apellidoPaterno { get; set; }
        public virtual Roles rol { get; set; }

        public String PasswordStored { get ; set; }

        [NotMapped]
        public string Password
        {
            get => StringUtils.DecodeString(PasswordStored);
            set => PasswordStored = StringUtils.EncryptString(value);
        }
    }
}