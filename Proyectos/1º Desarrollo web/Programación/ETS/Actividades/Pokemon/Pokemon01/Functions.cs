using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Functions
    {
        
        public static String strongestPokemon(string fichero, int generation)
        {
            string pokemonName = "";
            if (File.Exists(fichero))
            {
                List<string> dataFile = new List<string>();
                try
                {
                    //guardamos cada linea del fichero en una lista 
                    foreach (string line in File.ReadLines(fichero))
                    {
                        dataFile.Add(line);
                    }

                    int attack;
                    int maxAttack = 0;
                    int checkGeneration;
                    string textline;
                    string[] lineSplit = new string[0];
                    //ahora recorremos cada linea del fichero, buscamos la posición de la generación 
                    for (int i = 1; i < dataFile.Count; i++)
                    {
                        textline = dataFile[i];
                        lineSplit = textline.Split(',');
                        checkGeneration = Convert.ToInt32(lineSplit[lineSplit.Length-2]);
                        //cuando coincida la generacion con la dada por el usuario, sacamos el ataque de cada pokemon
                        if (checkGeneration == generation)
                        {
                            //comprobamos que no sea legendario
                            if (lineSplit[lineSplit.Length-1] == "False")
                            {
                                attack = Convert.ToInt32(lineSplit[6]);
                                //guardamos el nombre del pokemon con mayor ataque
                                if (attack > maxAttack)
                                {
                                    maxAttack = attack;
                                    pokemonName = lineSplit[1];
                                }
                            }
                        }
                    }
                    return pokemonName;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("El fichero no existe.");
            }
            return pokemonName;

        }

        public static string filterPokemon(string fichero)
        {
            string doubletypePokemon = "";
            if (File.Exists(fichero))
            {
                doubletypePokemon = "..\\..\\..\\DoubleTypePokemon.csv";
                StreamWriter writer = null;
                //leemos el contenido del archivo original
                try
                {
                    writer = File.CreateText(doubletypePokemon);
                    List<string> dataFile = new List<string>();
                    string textline;
                    string[] lineSplit = new string[0];
                    foreach (string line in File.ReadLines(fichero))
                    {
                        dataFile.Add(line);
                    }
                    writer.WriteLine(dataFile[0]);
                    for (int i = 1; i < dataFile.Count; i++)
                    {
                        textline = dataFile[i];
                        lineSplit = textline.Split(',');
                        if (lineSplit[3] != "")
                        {
                            writer.WriteLine(textline);
                        }
                    }
                    writer.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Se produjo una excepción al crear el archivo: " + ex.Message);
                }
            }
            else
                Console.WriteLine("El fichero no existe.");
            return doubletypePokemon;
        }

    }
}
