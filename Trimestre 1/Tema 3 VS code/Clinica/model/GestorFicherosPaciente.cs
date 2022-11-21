using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace model
{
    public class GestorFicherosPaciente
    {
        public Boolean GuardarPaciente(Paciente paciente)
        {
            try {
                StreamWriter sw = new StreamWriter("..\\..\\..\\model\\Resources\\pacientes.txt", true);
                sw.WriteLine(paciente.ToString());
                sw.Close();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
            return true;
        }

        public Paciente findByDni(String dni)
        {
            Paciente paciente = new Paciente();
            string lineas = Properties.Resources.pacientes;
            string[] lineasarray = lineas.Split( Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var linea in lineasarray)
            {
                string[] lineaarray = linea.Split(':');
                foreach (var stringencontrado in lineaarray)
                {
                    if(stringencontrado == dni)
                    {
                        paciente = new Paciente(lineaarray[0], lineaarray[1], lineaarray[2], int.Parse(lineaarray[3]), lineaarray[4], (lineaarray[5]), int.Parse(lineaarray[6]));
                        return paciente;
                    }
                }
            }
            paciente = null;
            return paciente;
        }

        public Paciente findByNhc(int nhc)
        {
            Paciente paciente = new Paciente();
            string lineas = Properties.Resources.pacientes;
            string[] lineasarray = lineas.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var linea in lineasarray)
            {
                string[] lineaarray = linea.Split(':');
                foreach (var stringencontrado in lineaarray)
                {
                    if (stringencontrado == nhc.ToString())
                    {
                        paciente = new Paciente(lineaarray[0], lineaarray[1], lineaarray[2], int.Parse(lineaarray[3]), lineaarray[4], lineaarray[5], int.Parse(lineaarray[6]));
                        return paciente;
                    }
                }
            }
            paciente = null;
            return paciente;
        }

        public Boolean DeletePacienteByDni(string dni)
        {
            string linea = null;
            try
            {
                StreamWriter sw = new StreamWriter("..\\..\\..\\model\\Resources\\pacientes.txt");
                StreamReader sr = new StreamReader("..\\..\\..\\model\\Resources\\pacientes.txt");
                while((linea = sr.ReadLine()) != null)
                {
                    string[] lineaarray = linea.Split(':');
                    for (int i = 0; i < lineaarray.Length; i++)
                    {
                        if (lineaarray[i] == dni)
                            continue;
                        sw.WriteLine(linea);
                    }
                }
                sw.Close();
                sr.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public Boolean DeletePacienteByNhc(int nhc)
        {
            string linea = null;
            string nuevotexto = null;
            try
            {
                    using (StreamReader sr = new StreamReader("..\\..\\..\\model\\Resources\\pacientes.txt"))
                    {
                        while ((linea = sr.ReadLine()) != null)
                        {
                            string[] lineaarray = linea.Split(':');
                            for (int i = 0; i < lineaarray.Length; i++)
                            {
                            if (lineaarray[i] == nhc.ToString())
                                linea = "";
                            else if (i == 6)
                            {
                                nuevotexto += linea + "\n";
                            }
                            }
                        }
                    }
                    using(StreamWriter sw = new StreamWriter("..\\..\\..\\model\\Resources\\pacientes.txt")) 
                    { 
                        sw.WriteLine(nuevotexto);
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public List<Paciente> findAll()
        {
            List<Paciente> pacientes = new List<Paciente>();
            string lineas = Properties.Resources.pacientes;
            string[] lineasarray = lineas.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var linea in lineasarray)
            {
                string[] lineaarray = linea.Split(':');
                pacientes.Add(new Paciente(lineaarray[0], lineaarray[1], lineaarray[2], int.Parse(lineaarray[3]), lineaarray[4], lineaarray[5], int.Parse(lineaarray[6])));
            }
            return pacientes;

        }

        public Boolean verificarDni(string dni)
        {
            string dninumeros = Regex.Match(dni, @"\d+").Value;
            if (dni.Length != 9)
                return false;
            else
                return CalcularLetraDNI(int.Parse(dninumeros)) == dni[8];
        }
        private int CalcularLetraDNI(int dni)
        {
            char[] letras = "TRWAGMYFPDXBNJZSQVHLCKE".ToCharArray();
            return letras[dni % 23];
        }
    }
}
