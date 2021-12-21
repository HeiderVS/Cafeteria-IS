using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Modelos;
using Modelos.Usuarios;
using EntityState = System.Data.Entity.EntityState;

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
                rolId = (int) RolesEnum.Vendedor,
                activo = true
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
                        where user.activo == true && user.rolId == 1
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

        public void EliminarUsuario(UsuarioInfoViewModel usuarioInfoViewModel)
        {
            using CafeteriaDBContext dbContext = new CafeteriaDBContext();
            Usuario editUsuario = GetUsuarioById(usuarioInfoViewModel);
            editUsuario.activo = false;
            dbContext.Entry(editUsuario).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}