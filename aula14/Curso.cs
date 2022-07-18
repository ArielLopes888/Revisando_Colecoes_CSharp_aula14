using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula14
{
    public class Curso : Administração
    {

        Dictionary<int, Aluno> Matriculados = new Dictionary<int, Aluno>();
        public  void Cadastrar(int id, Aluno pessoa)
        {
            Matriculados.Add(id, pessoa);
        }
        public override void Remover(int id)
        {
            id = Convert.ToInt32(Console.ReadLine());
            Matriculados.Remove(id);
        }
        public override void Listar()
        {
            foreach (var item in Matriculados)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Nome} {item.Value.Sobrenome}");
            }
        }
        public void MenuAluno()
        {
            var curso = new Curso();
            int id = 0;
            string escolha = "1";
            while (escolha == "1" || escolha == "2" || escolha == "3")
            {
                Console.WriteLine("Escolha uma operação: 1/Cadastrar  2/Remover  3/Listar");
                escolha = Console.ReadLine();
                if (escolha == "1")
                {
                    var aluno_user = new Aluno();

                    Console.WriteLine("Digite seu nome:");
                    aluno_user.Nome = Console.ReadLine();
                    Console.WriteLine("Digite seu Sobrenome:");
                    aluno_user.Sobrenome = Console.ReadLine();
                    Console.WriteLine("Digite seu telefone:");
                    aluno_user.Telefone = Console.ReadLine();
                    Console.WriteLine(Environment.NewLine);

                    curso.Cadastrar(id, aluno_user);

                    id++;
                    Console.WriteLine("Deseja cadastrar notas? 1/Sim  2/Não");
                    Console.WriteLine(Environment.NewLine);
                    string opcao = Console.ReadLine();
                    if(opcao == "1")
                    {
                        aluno_user.RegistrarNota();
                        aluno_user.ApresentarNotas();
                        aluno_user.MediaDasNotas();
                        aluno_user.Estagio();
                    }

                }
                else if (escolha == "2")
                {
                    Console.WriteLine("Digite o seu Id:");
                    curso.Remover(id);
                    Console.WriteLine("Removido com SUCESSO!");
                }
                else if (escolha == "3")
                {
                    curso.Listar();
                    Console.WriteLine(Environment.NewLine);
                }

            }

        }
    }

}
