using System;
namespace LaboratorioTecFundamentales
{
    public class Agenda
    {
        public string nombres;
        public string apellidos;
        public string numero;
        public string direccion;
        public int id;

        public Agenda(string a, string b, string c, string d, int e)
        {
            nombres = a;
            apellidos = b;
            numero = c;
            direccion = d;
            id = e;
        }
    }
}