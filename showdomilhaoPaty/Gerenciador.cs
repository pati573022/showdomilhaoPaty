using Microsoft.VisualBasic;

namespace showdomilhaoPaty;

public class Gerenciador
{
    List<Questao>Listaquestoes=new List<Questao>();
    List <int> listaQuestoesRespondidas= new List<int>();
    Questao QuestaoCorrente;
    public Gerenciador(Label labelPergunta, Button btResposta01,Button btResposta02,Button btResposta03,Button btResposta04,Button btResposta5)
    
    void CriaPerguntas (labelPergunta,btResposta01, btResposta02,btResposta03,btResposta04, btResposta05 ) 

    {
        var Questao01 = new Questao ();
        Questao01.ConfigurarEstruturaDesenho(labelPergunta, btResposta01,btResposta02,btResposta03,btResposta04, btResposta05 );
        Questao01.Pergunta = " quanto  é ?";
        Questao01.Resposta01 = "...";
        Questao01.Resposta02 = "...";
        Questao01.Resposta03 = "...";
        Questao01.Resposta04 = "...";
        Questao01.Resposta05 = "...";
        Questao01.respostacorreta = "3";
        listaQuestoesRespondidas.Add (Questao01);
   }
   public async void VerificaCorreta (RR)
   {
    await Task.Delay (1000);
    ProximaQuestao ();
   }
   void ProximaQuestao()
   {
    var numAleat =Random.S
   }
  
}