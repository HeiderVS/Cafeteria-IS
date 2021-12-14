using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos.Usuarios
{
    public class Roles
    {
        private Roles(RolesEnum @enum)
        {
            id = (int) @enum;
            rol = @enum.ToString();
        }
        
        protected Roles(){}
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public String rol { get; set; }

        public static implicit operator Roles(RolesEnum @enum) => new Roles(@enum);
        public static implicit operator RolesEnum(Roles roles) => (RolesEnum)roles.id;
        
    }
}