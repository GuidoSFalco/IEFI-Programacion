using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        string nombResponsable;
        int adultos;
        int menores;
        int habitaciones;
        DateTime fechIng;
        DateTime fechFin;

        public string NombResponsable { get => nombResponsable; set => nombResponsable = value; }
        public int Adultos { get => adultos; set => adultos = value; }
        public int Menores { get => menores; set => menores = value; }
        public int Habitaciones { get => habitaciones; set => habitaciones = value; }
        public DateTime FechIng { get => fechIng; set => fechIng = value; }
        public DateTime FechFin { get => fechFin; set => fechFin = value; }
    }
}
