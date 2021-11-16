
using RegistroVfinal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormRegistroVfinal
{

    public class BackFormulario
    {
        //array
        public Usuario[] Usuario { get; set; }
        public DataTable daTa { get; set; } = new DataTable();



        //constructor donde creo als columnas
        public BackFormulario()
        {
            daTa.TableName = "Registro";
            daTa.Columns.Add("Nombre");
            daTa.Columns.Add("Apellido");
            daTa.Columns.Add("Nacimiento");

            //llamo el metodo apra leer registro
            LeerRegistro();


        }

        public void LeerRegistro() //aca creamos el archivo xml y lo leemos
        {
            if (System.IO.File.Exists("Archivo.xml"))
            {
                daTa.Clear();
                daTa.ReadXml("Archivo.xml");

            }
        }

        public void CargarRegistro(Usuario usuario)
        {
            daTa.Rows.Add();//agrego las filas a la tabla
            int Contador = daTa.Rows.Count - 1; // contador de la posicion de cada carga
            daTa.Rows[Contador]["Nombre"] = usuario.Nombre;
            daTa.Rows[Contador]["Apellido"] = usuario.Apellido;
            daTa.Rows[Contador]["Nacimiento"] = usuario.Nacimiento;

            daTa.WriteXml("Archivo.xml");//vuelvo a llamar al xml


        }

    }


}