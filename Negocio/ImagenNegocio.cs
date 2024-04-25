﻿using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listar(int ID)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Imagen> lista = new List<Imagen>();

            try
            {
                datos.setearConsulta("select ID, ImagenUrl from IMAGENES where IdArticulo=@id");
                datos.setearParametro("@id", ID);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.ID = (int)datos.Lector["ID"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];      
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
