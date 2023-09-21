namespace Sesi.model
{
    //Declarando a classe Aluno
    public class Aluno
    {
        //Declarando os atributos (propriedades) da class aluno
        public string nome { get; set; }
        public int idade { get; set; }

        public string turma { get; set; }
     
     private int nrFaltas { get; set; }
   public int ResumoFalta { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Olá,meu nome é {nome}, eu tenho {idade} anos e estudo na turma {turma} e tenho {nrfaltas} faltas");

      {
      public void AdicionarFaltas(int nr) faltas");
  nrfaltas = nrFaltas + nr;
  }
  public void ResumoFalta()
  {
    Console.WriteLine("$O aluno {nome} faltou ontem e somou {nr} nrFaltas")
  nrFaltas = nrFaltas + nr;
  }
        public void ResumoFalta()
        {
            Console.WriteLine("$O aluno {nome} têm {nrFaltas}");
        }
        }
    }
}