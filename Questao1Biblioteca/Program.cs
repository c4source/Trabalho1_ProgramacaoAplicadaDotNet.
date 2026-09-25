using Questao1Biblioteca.Models;

namespace Questao1Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Visitante v1 = new Visitante
            {
                QuantidadeEmprestimosAtivos = 2

            };

            Aluno al1 = new Aluno
            {
                QuantidadeEmprestimosAtivos = 4

            };


            Professor p1 = new Professor
            {

                QuantidadeEmprestimosAtivos = 3

            };

            //Verificar o null
            Console.WriteLine(VerificarEmprestimo(null));

            //Verificando Aluno
            Console.WriteLine(VerificarEmprestimo(al1));

            //Verificando Professor
            Console.WriteLine(VerificarEmprestimo(p1));

            //Verificando Visitante 
            Console.WriteLine(VerificarEmprestimo(v1));

            //Testa o default
            Console.WriteLine(VerificarEmprestimo("Qualquer Coisa"));
        }

        public static string VerificarEmprestimo(object obj) 
        {

            return obj switch
            {

                null => "Usuário inválido",

                Aluno {QuantidadeEmprestimosAtivos: < 3 }
                => "Emprestimo autorizado", 

                Aluno {QuantidadeEmprestimosAtivos: >= 3 }
                => "Limites de emprestimos atingidop para aluno",

                Professor {QuantidadeEmprestimosAtivos: < 5 }
                => "Emprestimo autorizado para o professor", 

                Professor {QuantidadeEmprestimosAtivos: >= 5 }
                => "Limites de emprestimos atingido pelo professorr", 

                Visitante 
                => "Visitantes não podem realizar empréstimos", 

                _ => "Usuario não classificado"
            };
            
        
        
        }

    }
}
