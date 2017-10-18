using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class UsuarioDAO
    {
        public Usuario login(string username, string password)
        {
            try
            {
                using (var context = new AgenciaModeloEntities())
                {
                    Usuario us = new Usuario();
                    us = context.Usuario.First(x => x.userName.Equals(username) && x.password.Equals(password));
                    return us;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
