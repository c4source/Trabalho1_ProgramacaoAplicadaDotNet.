using Questao2Reflection.Attributes;
using Questao2Reflection.Models;
using System.Reflection;

namespace Questao2Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipamento equipamento1 = new Equipamento()
            {
                Id = 1,
                Nome = "Teclado Alloy origins",
                Fabricante = "Hyperx",
                NumeroSerie = "222-1212-2212",
                Valor= 600,
                Localizacao = "São Paulo, Paraíso."


            };


            ExibirDadosAbertos(equipamento1); //Abeerta
            Console.WriteLine("");
            ExirDadosControlado(equipamento1); //Controlada

        }



        public static void ExibirDadosAbertos(object obj) 
        {
            Type tipo = obj.GetType();

            foreach (PropertyInfo p in tipo.GetProperties())
            {
                var valor = p.GetValue(obj);
                Console.WriteLine($"{p.Name}: {valor}");

            }

                
        }



        public static void ExirDadosControlado(object obj) 
        {
            Type tipo = obj.GetType();

            foreach (PropertyInfo p in tipo.GetProperties()) 
            {
               

                ExibirAttribute? atributo = p.GetCustomAttribute<ExibirAttribute>();

                if (atributo != null) 
                {

                    var valor = p.GetValue(obj);
                    Console.WriteLine($"{p.Name}: {valor}");

                }

            
            
            }
        
        
        
        }

    }
}