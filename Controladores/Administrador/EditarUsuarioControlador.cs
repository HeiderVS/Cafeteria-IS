using System.Linq;
using Microsoft.EntityFrameworkCore;
using Modelos;
using Modelos.Usuarios;
using EntityState = System.Data.Entity.EntityState;

namespace Controladores.Administrador
{
    public class EditarUsuarioControlador
    {
        public UsuarioInfoViewModel UsuarioInfoViewModel { get; }

        public EditarUsuarioControlador(UsuarioInfoViewModel usuarioInfoViewModel)
        {
            UsuarioInfoViewModel = usuarioInfoViewModel;
        }

        public UsuarioInfoViewModel AuthAdministrador(string pass)
        {
            if (pass == "") return null;

            using CafeteriaDBContext dbContext = new CafeteriaDBContext();
            return dbContext.Usuarios
                .Include(u => u.rol)
                .ToList()
                .Where(c => c.rolId == 0 && c.Password.Equals(pass))
                .Select(userSelect => new UsuarioInfoViewModel()
                {
                    id = userSelect.id,
                    maternal = userSelect.apellidoMaterno,
                    paternal = userSelect.apellidoPaterno,
                    name = userSelect.nombre,
                    username = userSelect.usuario,
                    rol = userSelect.rolId ?? -1
                })
                .SingleOrDefault();
        }

        public Usuario GetUsuarioById(UsuarioInfoViewModel usuarioViewModel)
        {
            using CafeteriaDBContext dbContext = new CafeteriaDBContext();
            return dbContext.Usuarios.Find(usuarioViewModel.id);
        }
        
        public string ReestablecerUsuario(UsuarioInfoViewModel dataBoundItem)
        {
            Usuario reestablecerUsuario = GetUsuarioById(dataBoundItem);
            reestablecerUsuario.Password = StringUtils.CreateRandom();
            using CafeteriaDBContext dbContext = new CafeteriaDBContext();
            dbContext.Entry(reestablecerUsuario).State = EntityState.Modified;
            dbContext.SaveChanges();
            return reestablecerUsuario.Password;
        }
    }
}