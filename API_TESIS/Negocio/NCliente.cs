using API_TESIS.Entidades;
using API_TESIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TESIS.Negocio
{
    public class NCliente
    {
        bdEcommerceEntities _bdEcommerceEntities = new bdEcommerceEntities();

        public int ActivarCliente(int id_cliente)
        {
            try
            {
                int varQuery = _bdEcommerceEntities.pa_Activar_Cliente(id_cliente);
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede Activar");
            }

            return id_cliente;
        }

        //get cliente
        public List<Cliente> GetListaClientesNoVigente()
        {
            List<Cliente> lstCliente = new List<Cliente>();

            try
            {
                var varRespConsulta = _bdEcommerceEntities.pa_Listar_Cliente_NoVigente();
                foreach (var varCli in varRespConsulta)
                {
                    Cliente c = new Cliente();
                    c.id_cliente = varCli.id_cliente;
                    c.nombre = varCli.nombre;
                    c.apellido = varCli.apellido;
                    c.rut = varCli.rut;
                    c.direccion = varCli.direccion;
                    c.fono = varCli.fono;
                    c.estado = varCli.estado;

                    lstCliente.Add(c);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }

            return lstCliente;
        }

        public int DeleteCliente(int id_cliente)
        {
            try
            {
                int varQuery = _bdEcommerceEntities.pa_Eliminar_Cliente(id_cliente);
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede eliminar");
            }

            return id_cliente;
        }

        //Listar Cliente por id
        public List<Cliente> GetClienteID(int id_cliente)
        {
            List<Cliente> lstCliente = new List<Cliente>();
            try
            {
                var respId = _bdEcommerceEntities.pa_Listar_Cliente_ID(id_cliente);
                foreach (var cli in respId)
                {
                    Cliente c = new Cliente();
                    c.id_cliente = cli.id_cliente;
                    c.nombre = cli.nombre;
                    c.apellido = cli.apellido;
                    c.rut = cli.rut;
                    c.direccion = cli.direccion;
                    c.fono = cli.fono;
                    c.estado = cli.estado;

                    lstCliente.Add(c);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede solicitar el recurso");
            }
            return lstCliente;
        }

        //get cliente
        public List<Cliente> GetListaClientes()
        {
            List<Cliente> lstCliente = new List<Cliente>();

            try
            {
                var varRespConsulta = _bdEcommerceEntities.pa_Listar_Cliente();
                foreach (var varCli in varRespConsulta)
                {
                    Cliente c = new Cliente();
                    c.id_cliente = varCli.id_cliente;
                    c.nombre = varCli.nombre;
                    c.apellido = varCli.apellido;
                    c.rut = varCli.rut;
                    c.direccion = varCli.direccion;
                    c.fono = varCli.fono;
                    c.estado = varCli.estado;

                    lstCliente.Add(c);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }

            return lstCliente;
        }

        public List<Cliente> GetNombreClientes()
        {
            List<Cliente> lstCliente = new List<Cliente>();

            try
            {
                var varRespConsulta = _bdEcommerceEntities.pa_Listar_Cliente();
                foreach (var varCli in varRespConsulta)
                {
                    Cliente c = new Cliente();
                    c.id_cliente = varCli.id_cliente;
                    c.nombre = varCli.nombre;

                    lstCliente.Add(c);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede solicitar el recurso");
            }

            return lstCliente;
        }

        //Post Cliente
        public Cliente PostCliente(Cliente c)
        {
            try
            {
                int varQuery = _bdEcommerceEntities.pa_Insertar_Cliente(c.nombre, c.apellido, c.rut, c.direccion, c.fono, c.estado);
            }
            catch (Exception ex)
            {

                Console.WriteLine("No se puede solicitar el recurso");
            }

            return c;
        }
    }
}