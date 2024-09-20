using Microsoft.VisualBasic;

namespace showdomilhaoPaty;

public class Gerenciador
{
    List<Questao>Listaquestoes=new List<Questao>();
    List <int> listaQuestoesRespondidas= new List<int>();
    Questao QuestaoCorrente;
    public Gerenciador(Label labelPergunta, Button btResposta01,Button btResposta02,Button btResposta03,Button btResposta04,Button btResposta05)
    {
        CriaPerguntas (labelPergunta,btResposta01, btResposta02,btResposta03,btResposta04, btResposta05 ) ;

    }
    
    void CriaPerguntas (Label labelPergunta, Button btResposta01, Button btResposta02, Button btResposta03, Button btResposta04,Button btResposta05 ) 

    {
        var Questao01 = new Questao ();
        Questao01.ConfigurarEstruturaDesenho(labelPergunta, btResposta01,btResposta02,btResposta03,btResposta04, btResposta05 );
        Questao01.Pergunta = " quanto  é ?";
        Questao01.Resposta1 = "...";
        Questao01.Resposta2 = "...";
        Questao01.Resposta3 = "...";
        Questao01.Resposta4 = "...";
        Questao01.Resposta5 = "...";
        Questao01.respostacorreta = 3;
        Listaquestoes.Add (Questao01);
        ProximaQuestao();
   }
   public async void verificaCorreta (int RespostaRespondida)
   {
    if (QuestaoCorrente.VerificaResposta(RespostaRespondida))
    {
         await Task.Delay (1000);
    ProximaQuestao ();
    }
   
   }
   void ProximaQuestao()
   {
    var numAleat =Random.Shared.Next (0, Listaquestoes.Count);
    while (listaQuestoesRespondidas.Contains(numAleat))
    numAleat=Random.Shared.Next (0, Listaquestoes.Count);
    listaQuestoesRespondidas.Add(numAleat);
    QuestaoCorrente=Listaquestoes[numAleat];
    QuestaoCorrente.desenhar();
   
   }
  
}