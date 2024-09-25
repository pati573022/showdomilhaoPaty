namespace showdomilhaoPaty;

public class Questao
{
    public Questao()
    {

    }
    public string Pergunta {get; set;}
    public string Resposta1 {get; set;}
    public string Resposta2 {get; set;}
    public string Resposta3 {get; set;}
    public string Resposta4 {get;set;}
    public string Resposta5 {get; set;}
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
        labelPergunta.Text=Pergunta;
        btResposta01.Text=Resposta1;
        btResposta02.Text=Resposta2;
        btResposta03.Text=Resposta3;
        btResposta04.Text=Resposta4;
        btResposta05.Text=Resposta5;

    this.btResposta01!.BackgroundColor = Color.FromArgb("#D29D00");
    this.btResposta01!.TextColor       = Colors.White;
    this.btResposta02!.BackgroundColor = Color.FromArgb ("#D29D00");
    this.btResposta02!.TextColor       = Colors.White;
    this.btResposta03!.BackgroundColor = Color.FromArgb("#D29D00");
    this.btResposta03!.TextColor       = Colors.White;
    this.btResposta04!.BackgroundColor = Color.FromArgb("#D29D00");
    this.btResposta04!.TextColor       = Colors.White;
    this.btResposta05!.BackgroundColor = Color.FromArgb("#D29D00");
    this.btResposta05!.TextColor       = Colors.White;
    
        

     
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
   public bool VerificaResposta (int RespostaRespondida)
   {
      if (respostacorreta == RespostaRespondida)
        {
      var botao= QualBotao (RespostaRespondida);
      botao.BackgroundColor = Colors.Green;
      return true;

        }
        else
        {
            var ButtonCorreto= QualBotao (respostacorreta);
            var ButtonIncorreto= QualBotao (RespostaRespondida);
            ButtonCorreto.BackgroundColor = Colors.Yellow;
            ButtonIncorreto.BackgroundColor = Colors.Red;
            return false;
}

}
 private Button QualBotao (int RR)
 {
    if (RR == 1)
    return btResposta01;
    else if (RR == 2)
    return btResposta02;
    else if (RR == 3)
    return btResposta03;
    else if (RR == 4)
    return btResposta04;
    else if (RR == 5)
    return btResposta05;
     else
     return null;
 }
 
}