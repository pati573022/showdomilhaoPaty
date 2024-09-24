


namespace showdomilhaoPaty;

public partial class MainPage : ContentPage
{
  Gerenciador gerenciador;
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
}