using System;
using System.Collections.Generic;
using System.IO;

namespace LaboratorioTecFundamentales
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IList<Agenda> agenda = new List<Agenda>();
            Random rand = new Random();
            bool keep = true;
            int resAmount = 0;
            int option;
            int id = rand.Next(10, 99);
            File.AppendAllText("file.txt", Environment.NewLine);
            var lines = File.ReadAllLines("file.txt");
            while (keep)
            {
                Console.Clear();
                Console.WriteLine("1- Agregar registro\n" +
                                  "2- Listar registro\n" +
                                  "3- Modificar registro\n" +
                                  "4- Eliminar registro\n" +
                                  "5- Guardar y salir\n");
                Console.WriteLine(" ");
                Console.WriteLine("-Si cierra el programa sin guardar, los data no seran guardados en el archivo de texto");
                Console.WriteLine(@"-El archivo se llama 'file.txt', recomendable usar el buscador de archvios para encontrarlo");
                Console.WriteLine("Una vez guardados los registros, debera hacer modificaciones de forma manual");
                Console.WriteLine("Una vez guardados los registros, no podra listarlos en el programa");
                option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        agenda.Add(AgregarContacto(id, agenda));
                        resAmount++;
                        break;

                    case 2:
                        ListarRegistros(agenda);
                        Console.WriteLine("Presione Enter...");
                        Console.ReadLine();
                        break;

                    case 3:
                        ModificacionCampo(agenda);
                        break;
                    case 4:
                        BorrarRegistro(agenda);
                        break;
                    case 5:
                        foreach (Agenda k in agenda) {
                            File.AppendAllText("file.txt", "ID: " + k.id + Environment.NewLine);
                            File.AppendAllText("file.txt", "Nombre: " + k.nombres + Environment.NewLine);
                            File.AppendAllText("file.txt", "Apellido: " + k.apellidos + Environment.NewLine);
                            File.AppendAllText("file.txt", "Numero: " + k.numero + Environment.NewLine);
                            File.AppendAllText("file.txt", "Direccion: " + k.direccion + Environment.NewLine);
                            File.AppendAllText("file.txt", " " + Environment.NewLine);
                            File.AppendAllText("file.txt", " " + Environment.NewLine);
                            File.AppendAllText("file.txt", " " + Environment.NewLine);
                        }
                        Console.WriteLine(" ");
                        keep = false;
                        break;
                }

            }
        }

        static Agenda AgregarContacto(int id, IList<Agenda> ageda)
        {
            string nombres;
            string apellidos;
            string numero;
            string direccion;

            Random rand = new Random();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Introduzca los nombres: ");
            nombres = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Introduzca los apellidos: ");
            apellidos = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Introduzca el numero: ");
            numero = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Introduzca la direccion: ");
            direccion = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Registro agregado exitosamente");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Presione Enter...");
            Console.ReadLine();
            foreach (Agenda j in ageda)
            {
                if (id == j.id)
                {
                    id = rand.Next(10, 99);
                }
            }
            Agenda registro = new Agenda(nombres, apellidos, numero, direccion, id);
            return registro;
        }

        static void ListarRegistros(IList<Agenda> agenda)
        {
            Console.Clear();
            foreach (Agenda i in agenda)
            {
                Console.WriteLine("ID: " + i.id);
                Console.WriteLine("Nombres: " + i.nombres);
                Console.WriteLine("Apellidos: " + i.apellidos);
                Console.WriteLine("Direccion: " + i.direccion);
                Console.WriteLine("Numero: " + i.numero);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

        static void ModificacionCampo(IList<Agenda> agenda)
        {
            int modChange = 0;
            int mod;
            string modName;
            string modApellidos;
            string modNumero;
            string modDireccion;
            Console.Clear();
            ListarRegistros(agenda);
            Console.WriteLine(" ");
            Console.Write("Inserte el ID del registro que desea modificar: ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("0: Atras");
            mod = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < agenda.Count; i++)
            {
                if (mod == agenda[i].id)
                {
                    Console.Clear();
                    Console.WriteLine("Que desea modificar: ");
                    Console.WriteLine("1: Nombres: ");
                    Console.WriteLine("2: Apellidos: ");
                    Console.WriteLine("3: Numero: ");
                    Console.WriteLine("4: Direccion: ");
                    Console.WriteLine("5: Atras");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    string text = File.ReadAllText("file.txt");
                    modChange = Int32.Parse(Console.ReadLine());
                    switch (modChange)
                    {
                        case 1:


                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Ingrese el nuevo nombre: ");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("0: Cancelar modificacion");
                            modName = Console.ReadLine();
                            if (modName == "0") {
                                break;
                            }
                            agenda[i].nombres = modName;
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            break;
                        case 2:

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Ingrese el nuevo apellido: ");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("0: Cancelar modificacion");
                            modApellidos = Console.ReadLine();
                            if (modApellidos == "0")
                            {
                                break;
                            }
                            agenda[i].apellidos = modApellidos;
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            break;
                        case 3:

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Ingrese el nuevo numero: ");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("0: Cancelar modificacion");
                            modNumero = Console.ReadLine();
                            if (modNumero == "0")
                            {
                                break;
                            }
                            agenda[i].numero = modNumero;
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            break;
                        case 4:

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Ingrese la nueva direccion: ");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("0: Cancelar modificacion");
                            modDireccion = Console.ReadLine();
                            if (modDireccion == "0")
                            {
                                break;
                            }
                            agenda[i].direccion = modDireccion;
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            break;
                        case 5:
                            break;
                    }
                }
            }

        }

        static void BorrarRegistro(IList<Agenda> agenda)
        {
            bool resExist = true;
            Console.WriteLine("Inserte el ID del registro: ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            int del;
            Console.WriteLine("0: Atras");
            del = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < agenda.Count; i++)
            {
                if (del == 0)
                {
                    break;
                }
                else if (del == agenda[i].id)
                {

                    agenda.RemoveAt(i);
                    resExist = true;
                }
            }
            if (resExist)
            {
                Console.WriteLine("Registro eliminado exitosamente");
            }

        }
    }
}