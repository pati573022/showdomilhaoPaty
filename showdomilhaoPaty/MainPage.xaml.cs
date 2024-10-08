


namespace showdomilhaoPaty;

public partial class MainPage : ContentPage
{
  Gerenciador gerenciador;
  int pula=0;
	public MainPage()
	{
		InitializeComponent();
    gerenciador = new Gerenciador(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05,labelPontuacao,labelNivel);

	}

  private void OnBtnResposta01Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreta(1);
  }

  private void OnBtnResposta02Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreta(2);
  }

  private void OnBtnResposta03Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreta(3);
  }

  private void OnBtnResposta04Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreta(4);
  }

  private void OnBtnResposta05Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreta(5);
  }
   void OnAjudaRetirarClicked(object s, EventArgs e)
   {
    var ajuda = new RetiraErradas();
    ajuda.ConfigurarEstruturaDesenho(btResposta01,btResposta02,btResposta03,btResposta04,btResposta05);
    ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
    (s as Button).IsVisible=false;
    
   }

   void OnAjudaPulaClicked(object s, EventArgs e)
   {
    gerenciador.ProximaQuestao();
    (s as Button).IsVisible=false;
   }
    
    void OnPulaClicked (object s, EventArgs a)
    {
      if (pula == 3)
      (s as Button).IsVisible=false;
      else
      {
      gerenciador.ProximaQuestao();
      pula++;
      }
    
    }
  

}
