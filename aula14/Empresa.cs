namespace aula14
{
    public class Empresa : Administração
    {
        Dictionary<int, Funcionario> Registrados = new Dictionary<int, Funcionario>();
        public void Cadastrar(int id, Funcionario pessoa)
        {
            Registrados.Add(id, pessoa);
        }
        public override void Remover(int id)
        {
            id = Convert.ToInt32(Console.ReadLine());
            Registrados.Remove(id);
        }
        public override void Listar()
        {
            foreach (var item in Registrados)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Nome} {item.Value.Sobrenome}");
            }
        }
        public void MenuFuncionario()
        {
            var empresa = new Empresa();
            int id = 0;
            string escolha = "1";
            while (escolha == "1" || escolha == "2" || escolha == "3")
            {
                Console.WriteLine("Escolha uma operação: 1/Cadastrar  2/Remover  3/Listar");
                escolha = Console.ReadLine();
                if (escolha == "1")
                {
                    var func_user = new Funcionario();

                    Console.WriteLine("Digite o nome:");
                    func_user.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o Sobrenome:");
                    func_user.Sobrenome = Console.ReadLine();
                    Console.WriteLine("Digite o telefone:");
                    func_user.Telefone = Console.ReadLine();
                    Console.WriteLine("Digite o salário:");
                    func_user.Salario = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine(Environment.NewLine);

                    empresa.Cadastrar(id, func_user);

                    id++;
                }
                else if (escolha == "2")
                {
                    Console.WriteLine("Digite o seu Id:");
                    empresa.Remover(id);
                    Console.WriteLine("Removido com SUCESSO!");
                }
                else if (escolha == "3")
                {
                    empresa.Listar();
                    Console.WriteLine(Environment.NewLine);
                }

            }
        }
    }
}
