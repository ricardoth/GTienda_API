using API_TESIS.Entidades;
using API_TESIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TESIS.Negocio
{
    public class NCategoria
    {
        bdEcommerceEntities _bdEcommerceEntities = new bdEcommerceEntities();

        public int ActivarCategoria(int id_categoria)
        {
            try
            {
                int varQuery = _bdEcommerceEntities.pa_Activar_Categoria(id_categoria);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede Activar");
            }

            return id_categoria;
        }

        //Post Categoria
        public Categoria PostCategoria(Categoria c)
        {
            try
            {
                int varQuery = _bdEcommerceEntities.pa_Insertar_Categoria(c.nom_categoria, c.estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }

            return c;
        }

        //Delete Categoria
        public int DeleteCategoria(int id_categoria)
        {
            try
            {
                int varQuery = _bdEcommerceEntities.pa_Eliminar_Categoria(id_categoria);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede eliminar");
            }

            return id_categoria;
        }


        //get categoria
        public List<Categoria> GetListaCategoriaNoVigente()
        {
            List<Categoria> lstCategoria = new List<Categoria>();
            try
            {
                var varRespConsulta = _bdEcommerceEntities.pa_Listar_Categoria_NoVigente();
                foreach (var varCat in varRespConsulta)
                {
                    Categoria _Categoria = new Categoria();
                    _Categoria.id_categoria = varCat.id_categoria;
                    _Categoria.nom_categoria = varCat.nom_categoria;
                    _Categoria.estado = varCat.estado;

                    lstCategoria.Add(_Categoria);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede solicitar el recurso");
            }


            return lstCategoria;
        }

        //get categoria
        public List<Categoria> GetListaCategoria()
        {
            List<Categoria> lstCategoria = new List<Categoria>();
            try
            {
                var varRespConsulta = _bdEcommerceEntities.pa_Listar_Categoria();
                foreach (var varCat in varRespConsulta)
                {
                    Categoria _Categoria = new Categoria();
                    _Categoria.id_categoria = varCat.id_categoria;
                    _Categoria.nom_categoria = varCat.nom_categoria;
                    _Categoria.estado = varCat.estado;

                    lstCategoria.Add(_Categoria);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede solicitar el recurso");
            }


            return lstCategoria;
        }

       


        //Listar categoria por id
        public List<Categoria> GetCategoriaID(int id_categoria)
        {
            List<Categoria> lstCategoria = new List<Categoria>();
            try
            {
                var respId = _bdEcommerceEntities.pa_Listar_Categoria_ID(id_categoria);
                foreach (var cat in respId)
                {
                    Categoria c = new Categoria();
                    c.id_categoria = cat.id_categoria;
                    c.nom_categoria = cat.nom_categoria;
                    c.estado = cat.estado;

                    lstCategoria.Add(c);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("No se puede solicitar el recurso");

            }
            return lstCategoria;
        }


       
    }
}