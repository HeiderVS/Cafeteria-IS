using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Controladores.Administrador;
using Modelos;
using Modelos.Usuarios;

namespace Controladores
{
    public class LoginControlador
    {
        public UsuarioInfoViewModel GetLogin(String user, String pass)
        {
            using (CafeteriaDBContext dbContext = new CafeteriaDBContext())
            {
                /*Roles userRol = dbContext.Usuarios
                    .Include(u => u.rol)
                    .ToList()
                    .Where(c => c.usuario.Equals(user) && c.Password.Equals(pass))
                    .Select(userSelect => userSelect.rol)
                    .SingleOrDefault();

                if (userRol == null)
                    return -1;
                return userRol.id;*/
                
                return dbContext.Usuarios
                    .Include(u => u.rol)
                    .ToList()
                    .Where(c => c.usuario.Equals(user) && c.Password.Equals(pass))
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
        }
    }
}