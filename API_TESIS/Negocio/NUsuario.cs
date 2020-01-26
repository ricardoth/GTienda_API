using API_TESIS.Entidades;
using API_TESIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TESIS.Negocio
{
    public class NUsuario
    {
        bdEcommerceEntities _bdEcommerceEntities = new bdEcommerceEntities();

        //Post Usuario
        public Usuario PostUsuario(Usuario u)
        {
            try
            {
                int varQuery = _bdEcommerceEntities.pa_Insertar_Usuario(u.nom_usuario, u.pass, u.estado);
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede solicitar el recurso");
            }

            return u;
        }

        //Delete Usuario
        public int DeleteUsuario(int id)
        {
            try
            {
                int varQuery = _bdEcommerceEntities.pa_Eliminar_Usuario(id);
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede eliminar");
            }

            return id;
        }

        //get usuario
        public List<Usuario> GetListaUsuariosNoVigente()
        {
            List<Usuario> lstUsuario = new List<Usuario>();

            try
            {
                var varRespConsulta = _bdEcommerceEntities.pa_Listar_Usuario_NoVigente();
                foreach (var varUsu in varRespConsulta)
                {
                    Usuario u = new Usuario();
                    u.id_usuario = varUsu.id_usuario;
                    u.nom_usuario = varUsu.nom_usuario;
                    u.pass = varUsu.pass;
                    u.estado = varUsu.estado;

                    lstUsuario.Add(u);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }


            return lstUsuario;
        }

        //get usuario
        public List<Usuario> GetListaUsuarios()
        {
            List<Usuario> lstUsuario = new List<Usuario>();

            try
            {
                var varRespConsulta = _bdEcommerceEntities.pa_Listar_Usuario();
                foreach (var varUsu in varRespConsulta)
                {
                    Usuario u = new Usuario();
                    u.id_usuario = varUsu.id_usuario;
                    u.nom_usuario = varUsu.nom_usuario;
                    u.pass = varUsu.pass;
                    u.estado = varUsu.estado;

                    lstUsuario.Add(u);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }


            return lstUsuario;
        }

        public int ActivarUsuario(int id_usuario)
        {
            try
            {
                int varQuery = _bdEcommerceEntities.pa_Activar_Usuario(id_usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede Activar");
            }

            return id_usuario;
        }

        //Listar usuario por el id
        public List<Usuario> GetUsuarioID(int id_usuario)
        {
            //Usuario usu = new Usuario();
            List<Usuario> lstUsuario = new List<Usuario>();
            try
            {
                var varRespConsulta = _bdEcommerceEntities.pa_Listar_Usuario_ID(id_usuario);
                foreach (var varUsu in varRespConsulta)
                {
                    Usuario u = new Usuario();
                    u.id_usuario = varUsu.id_usuario;
                    u.nom_usuario = varUsu.nom_usuario;
                    u.pass = varUsu.pass;
                    u.estado = varUsu.estado;

                    lstUsuario.Add(u);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }

            return lstUsuario;
        }


        public int? Login(Usuario u)
        {
            //Usuario u = new Usuario();
            var resLogin = _bdEcommerceEntities.pa_Login(u.nom_usuario, u.pass);
            int? inicio = 0;
            foreach (var log in resLogin)
            {
                inicio = log;
            }

            return inicio;
        }
    }
}