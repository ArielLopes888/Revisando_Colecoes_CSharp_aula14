namespace aula14
{
    public class Aluno
    {
        //public int Matricula;
        public string Nome;
        public string Sobrenome;
        public string Telefone;
        public double[]? Notas;
        public string[] Bimestres = { "1° bimestre", "2° bimestre", "3° bimestre", "4° bimestre" };
        public double media;


        public Aluno()
        {
            Notas = new double[4];
        }

        void Atualizar()
        {

        }

        public void RegistrarNota()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Digite a nota do {Bimestres[i]}:");
                Notas[i] = double.Parse(Console.ReadLine());
            }

        }

        public void ApresentarNotas()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"A nota do {Bimestres[i]} : {Notas[i]}.");
                Console.WriteLine(Environment.NewLine);
            }
        }

        public double MediaDasNotas()
        {
            double soma = 0;
            for (int j = 0; j < Notas.Length; j++)
            {
                soma += Notas[j];
            }

            media = (soma) / 4;
            Console.WriteLine($"A média das notas é {media}");
            Console.WriteLine(Environment.NewLine);
            return media;
            
        }

        public string Estagio()
        {
            string op;
            if (media >= 7)
            {
                op = "Aprovado";

            }
            else
            {
                op = "Reprovado";
            }
            Console.WriteLine($"O aluno está {op}!");
            Console.WriteLine(Environment.NewLine);
            return op;
        }
    }
}

