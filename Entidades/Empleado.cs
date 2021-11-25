using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        string nombre;
        string apellido;
        int dni;
        int caract;
        int telefono;
        string direccion;
        string genero;
        string area;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Caract { get => caract; set => caract = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Area { get => area; set => area = value; }
    }
}
