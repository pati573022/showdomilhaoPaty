

using System.Reflection.Emit;

public class Questao
{
    public Questao()
    {

    }
    public string pergunta {get; set;}
    public string resposta1 {get; set;}
    public string resposta2 {get; set;}
    public string resposta3 {get; set;}
    public string resposta4 {get;set;}
    public string resposta5 {get; set;}
    public int nivelpergunta {get; set;}
    public int respostacorreta {get; set;}
    private Label labelPergunta;
    private Button btResposta01;
    private Button btResposta02;
    private Button btResposta03;
    private Button btResposta04;
    private Button btResposta05;
    public void desenhar()
    {
        labelPergunta.Text=pergunta;
        btResposta01.Text=resposta1;
        btResposta02.Text=resposta2;
        btResposta03.Text=resposta3;
        btResposta04.Text=resposta4;
        btResposta05.Text=resposta5;
    }
    public Questao(Label lp, Button bt01,Button bt02, Button bt03, Button bt04, Button bt05)
    {
        labelPergunta = lp;
        btResposta01 = bt01;
        btResposta02 = bt02;
        btResposta03 = bt03;
        btResposta04 = bt04;
        btResposta05 = bt05;
    }
     public void ConfigurarEstruturaDesenho(Label lp, Button bt01,Button bt02, Button bt03, Button bt04, Button bt05)
    {
        labelPergunta = lp;
        btResposta01 = bt01;
        btResposta02 = bt02;
        btResposta03 = bt03;
        btResposta04 = bt04;
        btResposta05 = bt05;
    }
   public bool VerificaResposta (int RR)
   {
      if (RespostaRespondida == respostacorreta)
        {
      var botao= QualBotao (RR);
      botao.BackgroundColor = Colors.Green;
      return true;

        }
        else
        {
            return false;
}

}
 private Button QualBotao (int RR)
 {
    if (RR == 1)
    return btResposta01;
    else if (RR == 2)
    return btResposta02;
 }
 
}