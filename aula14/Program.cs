namespace aula14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escolha = "";
            Console.WriteLine("Qual o sitema deseja acessar? 1/Curso  2/Empresa");
            escolha = Console.ReadLine();
            while (escolha == "1" || escolha == "2")
            {
                if (escolha == "1")
                {
                    var menu = new Curso();
                    menu.MenuAluno();
                }
                else if(escolha == "2")
                {
                    var menu = new Empresa();
                    menu.MenuFuncionario();
                }
            }
            
            
        }
    }
}