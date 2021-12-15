using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Modelos.Usuarios;

namespace Modelos.Inventario
{
    public class Categoria
    {
        private Categoria(CategoriaEnum @enum)
        {
            id = (int) @enum;
            categoria = @enum.ToString();
        }

        protected Categoria()
        {
        }


        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public String categoria { get; set; }

        public static implicit operator Categoria(CategoriaEnum @enum) => new Categoria(@enum);
        public static implicit operator CategoriaEnum(Categoria categoria) => (CategoriaEnum) categoria.id;
    }
}