

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
        Questao01.nivelpergunta = 1;
        Questao01.ConfigurarEstruturaDesenho(labelPergunta, btResposta01,btResposta02,btResposta03,btResposta04, btResposta05 );
        Questao01.Pergunta = " qual país tem o maior numero de habitantes no mundo ?";
        Questao01.Resposta1 = "India";
        Questao01.Resposta2 = "Russia";
        Questao01.Resposta3 = "Estados Unidos";
        Questao01.Resposta4 = "China";
        Questao01.Resposta5 = "Brasil";
        Questao01.respostacorreta = 1;
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

   public int Pontuacao {get;private set;}

   int NivelAtual= 0;
   void Inicializar()
   {
    Pontuacao =0;
    NivelAtual = 1;
    ProximaQuestao();
   }

   public async void VerificaCorreta(int RespostaRespondida)
   {
    if (QuestaoCorrente.VerificaResposta(RespostaRespondida))
    {
        await Task.Delay (1000);
        AdicionaPontuacao(NivelAtual);
        NivelAtual++;
        ProximaQuestao();
    }
    else 
    {
        await App.Current.MainPage.DisplayAlert("Fim","Voce Errou","Ok");
        Inicializar();
    }
       }
       void AdicionaPontuacao(int n)
       {
        if (n==1)
        Pontuacao=1000;
        else if (n==2)
        Pontuacao = 2000;
        else if (n==3)
        Pontuacao = 5000;
        else if (n==4)
        Pontuacao= 10000;
        else if(n==5)
        Pontuacao = 20000;
        else if (n==6)
        Pontuacao= 50000;
        else if (n==7)
        Pontuacao=100000;
        else if (n==8)
        Pontuacao=200000;
        else if (n==9)
        Pontuacao=500000;
        else
        Pontuacao=1000000;
       }


}
   
