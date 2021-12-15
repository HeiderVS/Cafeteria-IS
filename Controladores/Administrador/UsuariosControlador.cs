using System;
using System.Collections.Generic;
using System.Linq;
using Modelos;
using Modelos.Usuarios;

namespace Controladores.Administrador
{
    public class UsuariosControlador
    {
        public CredencialesViewModel RegistraUsuario(String name, String paternal, String maternal)
        {
            using CafeteriaDBContext cafeteriaDbContext = new CafeteriaDBContext();
            Usuario dbUser = cafeteriaDbContext.Usuarios.Add(new Usuario
            {
                nombre = name,
                apellidoPaterno = paternal,
                apellidoMaterno = maternal,
                Password = StringUtils.CreateRandom(),
                usuario = StringUtils.CreateUsername(name, paternal, maternal),
                rolId = (int) RolesEnum.Vendedor
            });
            cafeteriaDbContext.SaveChanges();
            return new CredencialesViewModel
            {
                generatedPassword = dbUser.Password,
                username = dbUser.usuario
            };
        }

        public List<UsuarioInfoViewModel> GetUsuarios()
        {
            using (CafeteriaDBContext dbContext = new CafeteriaDBContext())
            {
                return (from user in dbContext.Usuarios
                        select new UsuarioInfoViewModel
                        {
                            id = user.id,
                            name = user.nombre,
                            maternal = user.apellidoMaterno,
                            paternal = user.apellidoPaterno,
                            username = user.usuario
                        })
                    .ToList();
            }
        }
    }
}