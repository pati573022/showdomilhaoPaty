

namespace showdomilhaoPaty;

public class Gerenciador
{
    List<Questao>Listaquestoes=new List<Questao>();
    List <int> listaQuestoesRespondidas= new List<int>();
    Label labelPontuacao;
    Label labelNivel;
    Questao QuestaoCorrente;
    public Gerenciador(Label labelPergunta, Button btResposta01,Button btResposta02,Button btResposta03,Button btResposta04,Button btResposta05, Label labelPontuacao, Label labelNivel)
    {
        CriaPerguntas (labelPergunta,btResposta01, btResposta02,btResposta03,btResposta04, btResposta05 ) ;
        this.labelPontuacao =labelPontuacao;
        this.labelNivel =labelNivel;

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
        Questao01.respostacorreta = 2;
        Listaquestoes.Add (Questao01);
       
         var Questao02 = new Questao ();
        Questao02.nivelpergunta = 1;
        Questao02.ConfigurarEstruturaDesenho(labelPergunta, btResposta01,btResposta02,btResposta03,btResposta04, btResposta05 );
        Questao02.Pergunta = "Qual é o elemento químico mais abundante no universo?";
        Questao02.Resposta1 = "Oxigenio";
        Questao02.Resposta2 = "Hélio";
        Questao02.Resposta3 = "Hidrogênio";
        Questao02.Resposta4 = "Carbono";
        Questao02.Resposta5 = "Nitrogênio";
        Questao02.respostacorreta = 3;
        Listaquestoes.Add (Questao02);
        var Questao03 = new Questao();
        Questao03.nivelpergunta = 1;
        Questao03.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao03.Pergunta = "Qual é a capital da França?";
        Questao03.Resposta1 = "Paris";
        Questao03.Resposta2 = "Londres";
        Questao03.Resposta3 = "Roma";
        Questao03.Resposta4 = "Berlim";
        Questao03.Resposta5 = "Madrid";
        Questao03.respostacorreta = 1;
        Listaquestoes.Add(Questao03);

        var Questao04 = new Questao();
        Questao04.nivelpergunta = 1;
        Questao04.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao04.Pergunta = "Qual é o maior continente do mundo?";
        Questao04.Resposta1 = "África";
        Questao04.Resposta2 = "América";
        Questao04.Resposta3 = "Ásia";
        Questao04.Resposta4 = "Europa";
        Questao04.Resposta5 = "Oceania";
        Questao04.respostacorreta = 3;
        Listaquestoes.Add(Questao04);

        var Questao05 = new Questao();
        Questao05.nivelpergunta = 1;
        Questao05.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao05.Pergunta = "Quem escreveu 'Dom Casmurro'?";
        Questao05.Resposta1 = "Machado de Assis";
        Questao05.Resposta2 = "Jorge Amado";
        Questao05.Resposta3 = "Clarice Lispector";
        Questao05.Resposta4 = "José de Alencar";
        Questao05.Resposta5 = "Érico Veríssimo";
        Questao05.respostacorreta = 1;
        Listaquestoes.Add(Questao05);

        var Questao06 = new Questao();
        Questao06.nivelpergunta = 1;
        Questao06.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao06.Pergunta = "Qual é o animal mais rápido do mundo?";
        Questao06.Resposta1 = "Gato";
        Questao06.Resposta2 = "Cavalo";
        Questao06.Resposta3 = "Chita";
        Questao06.Resposta4 = "Leão";
        Questao06.Resposta5 = "Águia";
        Questao06.respostacorreta = 3;
        Listaquestoes.Add(Questao06);

        var Questao07 = new Questao();
        Questao07.nivelpergunta = 1;
        Questao07.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao07.Pergunta = "Qual é a fórmula química da água?";
        Questao07.Resposta1 = "H2O";
        Questao07.Resposta2 = "CO2";
        Questao07.Resposta3 = "O2";
        Questao07.Resposta4 = "H2SO4";
        Questao07.Resposta5 = "NaCl";
        Questao07.respostacorreta = 1;
        Listaquestoes.Add(Questao07);

        var Questao08 = new Questao();
        Questao08.nivelpergunta = 1;
        Questao08.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao08.Pergunta = "Qual é a moeda do Japão?";
        Questao08.Resposta1 = "Dólar";
        Questao08.Resposta2 = "Iene";
        Questao08.Resposta3 = "Euro";
        Questao08.Resposta4 = "Libra";
        Questao08.Resposta5 = "Franco";
        Questao08.respostacorreta = 2;
        Listaquestoes.Add(Questao08);

        var Questao09 = new Questao();
        Questao09.nivelpergunta = 1;
        Questao09.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao09.Pergunta = "Quem pintou a Mona Lisa?";
        Questao09.Resposta1 = "Vincent Van Gogh";
        Questao09.Resposta2 = "Pablo Picasso";
        Questao09.Resposta3 = "Leonardo da Vinci";
        Questao09.Resposta4 = "Claude Monet";
        Questao09.Resposta5 = "Michelangelo";
        Questao09.respostacorreta = 3;
        Listaquestoes.Add(Questao09);

        var Questao10 = new Questao();
        Questao10.nivelpergunta = 1;
        Questao10.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao10.Pergunta = "Qual é a capital do Brasil?";
        Questao10.Resposta1 = "Rio de Janeiro";
        Questao10.Resposta2 = "São Paulo";
        Questao10.Resposta3 = "Brasília";
        Questao10.Resposta4 = "Salvador";
        Questao10.Resposta5 = "Fortaleza";
        Questao10.respostacorreta = 3;
        Listaquestoes.Add(Questao10);


  var Questao11 = new Questao();
Questao11.nivelpergunta = 2;
Questao11.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao11.Pergunta = "Qual é a capital da Austrália?";
Questao11.Resposta1 = "Sydney";
Questao11.Resposta2 = "Canberra";
Questao11.Resposta3 = "Melbourne";
Questao11.Resposta4 = "Brisbane";
Questao11.Resposta5 = "Perth";
Questao11.respostacorreta = 2;
Listaquestoes.Add(Questao11);

var Questao12 = new Questao();
Questao12.nivelpergunta = 2;
Questao12.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao12.Pergunta = "Qual é a fórmula da glicose?";
Questao12.Resposta1 = "C6H12O6";
Questao12.Resposta2 = "C12H22O11";
Questao12.Resposta3 = "C6H10O5";
Questao12.Resposta4 = "C3H6O3";
Questao12.Resposta5 = "C2H5OH";
Questao12.respostacorreta = 1;
Listaquestoes.Add(Questao12);

var Questao13 = new Questao();
Questao13.nivelpergunta = 2;
Questao13.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao13.Pergunta = "Quem descobriu a gravidade?";
Questao13.Resposta1 = "Isaac Newton";
Questao13.Resposta2 = "Albert Einstein";
Questao13.Resposta3 = "Galileu Galilei";
Questao13.Resposta4 = "Nikola Tesla";
Questao13.Resposta5 = "Stephen Hawking";
Questao13.respostacorreta = 1;
Listaquestoes.Add(Questao13);

var Questao14 = new Questao();
Questao14.nivelpergunta = 2;
Questao14.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao14.Pergunta = "Qual é o planeta mais próximo do sol?";
Questao14.Resposta1 = "Mercúrio";
Questao14.Resposta2 = "Vênus";
Questao14.Resposta3 = "Terra";
Questao14.Resposta4 = "Marte";
Questao14.Resposta5 = "Júpiter";
Questao14.respostacorreta = 1;
Listaquestoes.Add(Questao14);

var Questao15 = new Questao();
Questao15.nivelpergunta = 2;
Questao15.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao15.Pergunta = "Qual é o maior oceano do mundo?";
Questao15.Resposta1 = "Atlântico";
Questao15.Resposta2 = "Índico";
Questao15.Resposta3 = "Ártico";
Questao15.Resposta4 = "Pacífico";
Questao15.Resposta5 = "Antártico";
Questao15.respostacorreta = 4;
Listaquestoes.Add(Questao15);

var Questao16 = new Questao();
Questao16.nivelpergunta = 2;
Questao16.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao16.Pergunta = "Qual é o símbolo químico do ouro?";
Questao16.Resposta1 = "Au";
Questao16.Resposta2 = "Ag";
Questao16.Resposta3 = "Fe";
Questao16.Resposta4 = "Hg";
Questao16.Resposta5 = "Pb";
Questao16.respostacorreta = 1;
Listaquestoes.Add(Questao16);

var Questao17 = new Questao();
Questao17.nivelpergunta = 2;
Questao17.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao17.Pergunta = "Quem foi o primeiro homem a pisar na Lua?";
Questao17.Resposta1 = "Buzz Aldrin";
Questao17.Resposta2 = "Neil Armstrong";
Questao17.Resposta3 = "Yuri Gagarin";
Questao17.Resposta4 = "Michael Collins";
Questao17.Resposta5 = "John Glenn";
Questao17.respostacorreta = 2;
Listaquestoes.Add(Questao17);

var Questao18 = new Questao();
Questao18.nivelpergunta = 2;
Questao18.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao18.Pergunta = "Qual é a língua mais falada do mundo?";
Questao18.Resposta1 = "Inglês";
Questao18.Resposta2 = "Mandarim";
Questao18.Resposta3 = "Espanhol";
Questao18.Resposta4 = "Árabe";
Questao18.Resposta5 = "Hindi";
Questao18.respostacorreta = 2;
Listaquestoes.Add(Questao18);

var Questao19 = new Questao();
Questao19.nivelpergunta = 2;
Questao19.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao19.Pergunta = "Qual é o continente mais populoso?";
Questao19.Resposta1 = "África";
Questao19.Resposta2 = "América";
Questao19.Resposta3 = "Ásia";
Questao19.Resposta4 = "Europa";
Questao19.Resposta5 = "Oceania";
Questao19.respostacorreta = 3;
Listaquestoes.Add(Questao19);

var Questao20 = new Questao();
Questao20.nivelpergunta = 2;
Questao20.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao20.Pergunta = "Qual é a moeda da União Europeia?";
Questao20.Resposta1 = "Dólar";
Questao20.Resposta2 = "Iene";
Questao20.Resposta3 = "Euro";
Questao20.Resposta4 = "Franco";
Questao20.Resposta5 = "Libra";
Questao20.respostacorreta = 3;
Listaquestoes.Add(Questao20);

var Questao21 = new Questao();
Questao21.nivelpergunta = 3;
Questao21.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao21.Pergunta = "Qual é o menor país do mundo?";
Questao21.Resposta1 = "Mônaco";
Questao21.Resposta2 = "Vaticano";
Questao21.Resposta3 = "San Marino";
Questao21.Resposta4 = "Malta";
Questao21.Resposta5 = "Liechtenstein";
Questao21.respostacorreta = 2;
Listaquestoes.Add(Questao21);

var Questao22 = new Questao();
Questao22.nivelpergunta = 3;
Questao22.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao22.Pergunta = "Qual é o elemento mais abundante no corpo humano?";
Questao22.Resposta1 = "Carbono";
Questao22.Resposta2 = "Oxigênio";
Questao22.Resposta3 = "Hidrogênio";
Questao22.Resposta4 = "Nitrogênio";
Questao22.Resposta5 = "Cálcio";
Questao22.respostacorreta = 2;
Listaquestoes.Add(Questao22);

var Questao23 = new Questao();
Questao23.nivelpergunta = 3;
Questao23.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao23.Pergunta = "Quem foi o autor da Teoria da Relatividade?";
Questao23.Resposta1 = "Isaac Newton";
Questao23.Resposta2 = "Albert Einstein";
Questao23.Resposta3 = "Niels Bohr";
Questao23.Resposta4 = "Galileu Galilei";
Questao23.Resposta5 = "Richard Feynman";
Questao23.respostacorreta = 2;
Listaquestoes.Add(Questao23);

var Questao24 = new Questao();
Questao24.nivelpergunta = 3;
Questao24.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao24.Pergunta = "Qual é a obra mais famosa de William Shakespeare?";
Questao24.Resposta1 = "Hamlet";
Questao24.Resposta2 = "Macbeth";
Questao24.Resposta3 = "Romeu e Julieta";
Questao24.Resposta4 = "Otelo";
Questao24.Resposta5 = "Sonetos";
Questao24.respostacorreta = 3;
Listaquestoes.Add(Questao24);

var Questao25 = new Questao();
Questao25.nivelpergunta = 3;
Questao25.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao25.Pergunta = "Qual é a capital da Islândia?";
Questao25.Resposta1 = "Reykjavik";
Questao25.Resposta2 = "Oslo";
Questao25.Resposta3 = "Copenhague";
Questao25.Resposta4 = "Helsinque";
Questao25.Resposta5 = "Estocolmo";
Questao25.respostacorreta = 1;
Listaquestoes.Add(Questao25);

var Questao26 = new Questao();
Questao26.nivelpergunta = 3;
Questao26.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao26.Pergunta = "Qual é a montanha mais alta do mundo?";
Questao26.Resposta1 = "K2";
Questao26.Resposta2 = "Kangchenjunga";
Questao26.Resposta3 = "Everest";
Questao26.Resposta4 = "Lhotse";
Questao26.Resposta5 = "Makalu";
Questao26.respostacorreta = 3;
Listaquestoes.Add(Questao26);

var Questao27 = new Questao();
Questao27.nivelpergunta = 3;
Questao27.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao27.Pergunta = "Qual é o principal gás do efeito estufa?";
Questao27.Resposta1 = "Oxigênio";
Questao27.Resposta2 = "Dióxido de carbono";
Questao27.Resposta3 = "Metano";
Questao27.Resposta4 = "Nitrogênio";
Questao27.Resposta5 = "Hélio";
Questao27.respostacorreta = 2;
Listaquestoes.Add(Questao27);

var Questao28 = new Questao();
Questao28.nivelpergunta = 3;
Questao28.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao28.Pergunta = "Qual é o maior mamífero do mundo?";
Questao28.Resposta1 = "Elefante";
Questao28.Resposta2 = "Girafa";
Questao28.Resposta3 = "Baleia azul";
Questao28.Resposta4 = "Orca";
Questao28.Resposta5 = "Rinoceronte";
Questao28.respostacorreta = 3;
Listaquestoes.Add(Questao28);

var Questao29 = new Questao();
Questao29.nivelpergunta = 3;
Questao29.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao29.Pergunta = "Qual é a primeira letra do alfabeto grego?";
Questao29.Resposta1 = "Alpha";
Questao29.Resposta2 = "Beta";
Questao29.Resposta3 = "Gamma";
Questao29.Resposta4 = "Delta";
Questao29.Resposta5 = "Epsilon";
Questao29.respostacorreta = 1;
Listaquestoes.Add(Questao29);

var Questao30 = new Questao();
Questao30.nivelpergunta = 3;
Questao30.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao30.Pergunta = "Quem pintou a 'Última Ceia'?";
Questao30.Resposta1 = "Vincent Van Gogh";
Questao30.Resposta2 = "Pablo Picasso";
Questao30.Resposta3 = "Leonardo da Vinci";
Questao30.Resposta4 = "Michelangelo";
Questao30.Resposta5 = "Raphael";
Questao30.respostacorreta = 3;
Listaquestoes.Add(Questao30);

var Questao31 = new Questao();
Questao31.nivelpergunta = 4;
Questao31.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao31.Pergunta = "Qual é a teoria que descreve a origem do universo?";
Questao31.Resposta1 = "Teoria do Big Bang";
Questao31.Resposta2 = "Teoria da Relatividade";
Questao31.Resposta3 = "Teoria das Cordas";
Questao31.Resposta4 = "Teoria do Caos";
Questao31.Resposta5 = "Teoria da Evolução";
Questao31.respostacorreta = 1;
Listaquestoes.Add(Questao31);

var Questao32 = new Questao();
Questao32.nivelpergunta = 4;
Questao32.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao32.Pergunta = "Qual elemento químico tem o número atômico 1?";
Questao32.Resposta1 = "Hélio";
Questao32.Resposta2 = "Oxigênio";
Questao32.Resposta3 = "Hidrogênio";
Questao32.Resposta4 = "Carbono";
Questao32.Resposta4 = "Nítrogênio";
Questao32.respostacorreta = 3;
Listaquestoes.Add(Questao32);

var Questao33 = new Questao();
Questao33.nivelpergunta = 4;
Questao33.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao33.Pergunta = "Qual é a capital da Armênia?";
Questao33.Resposta1 = "Tbilisi";
Questao33.Resposta2 = "Yerevan";
Questao33.Resposta3 = "Baku";
Questao33.Resposta4 = "Ankara";
Questao33.Resposta5 = "Teerã";
Questao33.respostacorreta = 2;
Listaquestoes.Add(Questao33);

var Questao34 = new Questao();
Questao34.nivelpergunta = 4;
Questao34.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao34.Pergunta = "Quem escreveu '1984'?";
Questao34.Resposta1 = "Aldous Huxley";
Questao34.Resposta2 = "Ray Bradbury";
Questao34.Resposta3 = "George Orwell";
Questao34.Resposta4 = "H.G. Wells";
Questao34.Resposta5 = "Fahrenheit 451";
Questao34.respostacorreta = 3;
Listaquestoes.Add(Questao34);

var Questao35 = new Questao();
Questao35.nivelpergunta = 4;
Questao35.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao35.Pergunta = "Qual é a função do fígado no corpo humano?";
Questao35.Resposta1 = "Produzir insulina";
Questao35.Resposta2 = "Filtrar sangue";
Questao35.Resposta3 = "Respiração";
Questao35.Resposta4 = "Digestão";
Questao35.Resposta5 = "Produção de hormônios";
Questao35.respostacorreta = 2;
Listaquestoes.Add(Questao35);

var Questao36 = new Questao();
Questao36.nivelpergunta = 4;
Questao36.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao36.Pergunta = "Quem é conhecido como o 'pai da psicanálise'?";
Questao36.Resposta1 = "Carl Jung";
Questao36.Resposta2 = "Sigmund Freud";
Questao36.Resposta3 = "Alfred Adler";
Questao36.Resposta4 = "Erik Erikson";
Questao36.Resposta5 = "Wilfred Bion";
Questao36.respostacorreta = 2;
Listaquestoes.Add(Questao36);

var Questao37 = new Questao();
Questao37.nivelpergunta = 4;
Questao37.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao37.Pergunta = "Qual é a fórmula química do ácido sulfúrico?";
Questao37.Resposta1 = "H2SO4";
Questao37.Resposta2 = "HCl";
Questao37.Resposta3 = "HNO3";
Questao37.Resposta4 = "CH3COOH";
Questao37.Resposta5 = "NaOH";
Questao37.respostacorreta = 1;
Listaquestoes.Add(Questao37);

var Questao38 = new Questao();
Questao38.nivelpergunta = 4;
Questao38.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao38.Pergunta = "Qual é a capital do Egito?";
Questao38.Resposta1 = "Cairo";
Questao38.Resposta2 = "Alexandria";
Questao38.Resposta3 = "Lúxor";
Questao38.Resposta4 = "Aswan";
Questao38.Resposta5 = "Giza";
Questao38.respostacorreta = 1;
Listaquestoes.Add(Questao38);

var Questao39 = new Questao();
Questao39.nivelpergunta = 4;
Questao39.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao39.Pergunta = "Qual foi o primeiro estado a abolir a escravidão?";
Questao39.Resposta1 = "Brasil";
Questao39.Resposta2 = "Reino Unido";
Questao39.Resposta3 = "Espanha";
Questao39.Resposta4 = "Estados Unidos";
Questao39.Resposta5 = "França";
Questao39.respostacorreta = 2;
Listaquestoes.Add(Questao39);

var Questao40 = new Questao();
Questao40.nivelpergunta = 4;
Questao40.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao40.Pergunta = "Qual é a maior estrutura viva do planeta?";
Questao40.Resposta1 = "Baobá";
Questao40.Resposta2 = "Sequoia";
Questao40.Resposta3 = "Coral Great Barrier";
Questao40.Resposta4 = "Cenoura";
Questao40.Resposta5 = "Redwood";
Questao40.respostacorreta = 3;
Listaquestoes.Add(Questao40);


var Questao41 = new Questao();
Questao41.nivelpergunta = 5;
Questao41.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao41.Pergunta = "Qual é a teoria que unifica a mecânica quântica e a relatividade geral?";
Questao41.Resposta1 = "Teoria das Cordas";
Questao41.Resposta2 = "Teoria do Caos";
Questao41.Resposta3 = "Teoria do Big Bang";
Questao41.Resposta4 = "Teoria da Relatividade";
Questao41.Resposta5 = "Teoria do Multiverso";
Questao41.respostacorreta = 1;
Listaquestoes.Add(Questao41);

var Questao42 = new Questao();
Questao42.nivelpergunta = 5;
Questao42.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao42.Pergunta = "Qual é a partícula subatômica que carrega carga negativa?";
Questao42.Resposta1 = "Próton";
Questao42.Resposta2 = "Nêutron";
Questao42.Resposta3 = "Elétron";
Questao42.Resposta4 = "Positron";
Questao42.Resposta5 = "Quark";
Questao42.respostacorreta = 3;
Listaquestoes.Add(Questao42);

var Questao43 = new Questao();
Questao43.nivelpergunta = 5;
Questao43.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao43.Pergunta = "Quem desenvolveu a teoria da evolução das espécies?";
Questao43.Resposta1 = "Charles Darwin";
Questao43.Resposta2 = "Gregor Mendel";
Questao43.Resposta3 = "Louis Pasteur";
Questao43.Resposta4 = "Richard Dawkins";
Questao43.Resposta5 = "Jean-Baptiste Lamarck";
Questao43.respostacorreta = 1;
Listaquestoes.Add(Questao43);

var Questao44 = new Questao();
Questao44.nivelpergunta = 5;
Questao44.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao44.Pergunta = "Qual é a capital do Quirguistão?";
Questao44.Resposta1 = "Bishkek";
Questao44.Resposta2 = "Almaty";
Questao44.Resposta3 = "Tashkent";
Questao44.Resposta4 = "Dushanbe";
Questao44.Resposta5 = "Astana";
Questao44.respostacorreta = 1;
Listaquestoes.Add(Questao44);

var Questao45 = new Questao();
Questao45.nivelpergunta = 5;
Questao45.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao45.Pergunta = "Qual é a maior espécie de tubarão do mundo?";
Questao45.Resposta1 = "Tubarão-branco";
Questao45.Resposta2 = "Tubarão-martelo";
Questao45.Resposta3 = "Tubarão-baleia";
Questao45.Resposta4 = "Tubarão-tigre";
Questao45.Resposta5 = "Tubarão-de-pontas-negras";
Questao45.respostacorreta = 3;
Listaquestoes.Add(Questao45);

var Questao46 = new Questao();
Questao46.nivelpergunta = 5;
Questao46.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao46.Pergunta = "Qual é a maior galáxia do Grupo Local?";
Questao46.Resposta1 = "Via Láctea";
Questao46.Resposta2 = "Andrômeda";
Questao46.Resposta3 = "Triângulo";
Questao46.Resposta4 = "Sombrero";
Questao46.Resposta5 = "Galáxia do Fuso";
Questao46.respostacorreta = 2;
Listaquestoes.Add(Questao46);

var Questao47 = new Questao();
Questao47.nivelpergunta = 5;
Questao47.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao47.Pergunta = "Qual é a fórmula da água?";
Questao47.Resposta1 = "H2O";
Questao47.Resposta2 = "CO2";
Questao47.Resposta3 = "O2";
Questao47.Resposta4 = "NaCl";
Questao47.Resposta5 = "C6H12O6";
Questao47.respostacorreta = 1;
Listaquestoes.Add(Questao47);

var Questao48 = new Questao();
Questao48.nivelpergunta = 5;
Questao48.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao48.Pergunta = "Qual é o princípio que afirma que a energia não pode ser criada nem destruída?";
Questao48.Resposta1 = "Princípio da Incerteza";
Questao48.Resposta2 = "Lei da Conservação da Energia";
Questao48.Resposta3 = "Teorema de Pitágoras";
Questao48.Resposta4 = "Teoria da Relatividade";
Questao48.Resposta5 = "Princípio da Superposição";
Questao48.respostacorreta = 2;
Listaquestoes.Add(Questao48);

var Questao49 = new Questao();
Questao49.nivelpergunta = 5;
Questao49.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao49.Pergunta = "Quem foi o primeiro homem a pisar na Lua?";
Questao49.Resposta1 = "Yuri Gagarin";
Questao49.Resposta2 = "Neil Armstrong";
Questao49.Resposta3 = "Buzz Aldrin";
Questao49.Resposta4 = "Michael Collins";
Questao49.Resposta5 = "John Glenn";
Questao49.respostacorreta = 2;
Listaquestoes.Add(Questao49);

var Questao50 = new Questao();
Questao50.nivelpergunta = 5;
Questao50.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao50.Pergunta = "Qual é o elemento químico que é um gás nobre e possui símbolo He?";
Questao50.Resposta1 = "Hélio";
Questao50.Resposta2 = "Neônio";
Questao50.Resposta3 = "Argônio";
Questao50.Resposta4 = "Kriptônio";
Questao50.Resposta5 = "Xenônio";
Questao50.respostacorreta = 1;
Listaquestoes.Add(Questao50);


var Questao51 = new Questao();
Questao51.nivelpergunta = 6;
Questao51.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao51.Pergunta = "Qual é a fórmula da relatividade de Einstein?";
Questao51.Resposta1 = "E=mc^2";
Questao51.Resposta2 = "F=ma";
Questao51.Resposta3 = "PV=nRT";
Questao51.Resposta4 = "a^2 + b^2 = c^2";
Questao51.Resposta5 = "E=hf";
Questao51.respostacorreta = 1;
Listaquestoes.Add(Questao51);

var Questao52 = new Questao();
Questao52.nivelpergunta = 6;
Questao52.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao52.Pergunta = "Qual a velocidade da luz no vácuo?";
Questao52.Resposta1 = "300.000 km/s";
Questao52.Resposta2 = "150.000 km/s";
Questao52.Resposta3 = "1.000 km/s";
Questao52.Resposta4 = "299.792 km/s";
Questao52.Resposta5 = "3.600 km/s";
Questao52.respostacorreta = 4;
Listaquestoes.Add(Questao52);

var Questao53 = new Questao();
Questao53.nivelpergunta = 6;
Questao53.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao53.Pergunta = "Qual é o princípio que estabelece que não se pode saber simultaneamente a posição e a velocidade de uma partícula?";
Questao53.Resposta1 = "Princípio da Incerteza";
Questao53.Resposta2 = "Princípio da Relatividade";
Questao53.Resposta3 = "Teorema de Pitágoras";
Questao53.Resposta4 = "Princípio de Bernoulli";
Questao53.Resposta5 = "Lei de Coulomb";
Questao53.respostacorreta = 1;
Listaquestoes.Add(Questao53);

var Questao54 = new Questao();
Questao54.nivelpergunta = 6;
Questao54.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao54.Pergunta = "Quem formulou as leis do movimento?";
Questao54.Resposta1 = "Isaac Newton";
Questao54.Resposta2 = "Galileu Galilei";
Questao54.Resposta3 = "Albert Einstein";
Questao54.Resposta4 = "Niels Bohr";
Questao54.Resposta5 = "Max Planck";
Questao54.respostacorreta = 1;
Listaquestoes.Add(Questao54);

var Questao55 = new Questao();
Questao55.nivelpergunta = 6;
Questao55.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao55.Pergunta = "Qual é o principal gás responsável pelo efeito estufa?";
Questao55.Resposta1 = "Dióxido de carbono (CO2)";
Questao55.Resposta2 = "Metano (CH4)";
Questao55.Resposta3 = "Óxido nitroso (N2O)";
Questao55.Resposta4 = "Vapor d'água";
Questao55.Resposta5 = "Ozone (O3)";
Questao55.respostacorreta = 1;
Listaquestoes.Add(Questao55);

var Questao56 = new Questao();
Questao56.nivelpergunta = 6;
Questao56.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao56.Pergunta = "Qual é a unidade de medida da força no Sistema Internacional?";
Questao56.Resposta1 = "Joule";
Questao56.Resposta2 = "Newton";
Questao56.Resposta3 = "Pascal";
Questao56.Resposta4 = "Watt";
Questao56.Resposta5 = "Coulomb";
Questao56.respostacorreta = 2;
Listaquestoes.Add(Questao56);

var Questao57 = new Questao();
Questao57.nivelpergunta = 6;
Questao57.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao57.Pergunta = "Quem é conhecido como o 'pai da química moderna'?";
Questao57.Resposta1 = "Robert Boyle";
Questao57.Resposta2 = "Antoine Lavoisier";
Questao57.Resposta3 = "John Dalton";
Questao57.Resposta4 = "Dmitri Mendeleev";
Questao57.Resposta5 = "Marie Curie";
Questao57.respostacorreta = 2;
Listaquestoes.Add(Questao57);

var Questao58 = new Questao();
Questao58.nivelpergunta = 6;
Questao58.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao58.Pergunta = "Qual é o maior órgão do corpo humano?";
Questao58.Resposta1 = "Coração";
Questao58.Resposta2 = "Fígado";
Questao58.Resposta3 = "Pele";
Questao58.Resposta4 = "Pulmão";
Questao58.Resposta5 = "Rim";
Questao58.respostacorreta = 3;
Listaquestoes.Add(Questao58);

var Questao59 = new Questao();
Questao59.nivelpergunta = 6;
Questao59.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao59.Pergunta = "Qual é a distância média da Terra ao Sol?";
Questao59.Resposta1 = "150 milhões de km";
Questao59.Resposta2 = "93 milhões de milhas";
Questao59.Resposta3 = "1 unidade astronômica";
Questao59.Resposta4 = "500 milhões de km";
Questao59.Resposta5 = "10 milhões de km";
Questao59.respostacorreta = 1;
Listaquestoes.Add(Questao59);

var Questao60 = new Questao();
Questao60.nivelpergunta = 6;
Questao60.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao60.Pergunta = "Qual é a primeira lei da termodinâmica?";
Questao60.Resposta1 = "A energia não pode ser criada nem destruída";
Questao60.Resposta2 = "A entropia de um sistema isolado aumenta";
Questao60.Resposta3 = "A energia é sempre conservada";
Questao60.Resposta4 = "A temperatura é uma medida de energia";
Questao60.Resposta5 = "Os sistemas tendem ao equilíbrio";
Questao60.respostacorreta = 1;
Listaquestoes.Add(Questao60);

var Questao61 = new Questao();
Questao61.nivelpergunta = 7;
Questao61.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao61.Pergunta = "Qual é a constante de Planck?";
Questao61.Resposta1 = "6.626 x 10^-34 J·s";
Questao61.Resposta2 = "3.14159";
Questao61.Resposta3 = "9.81 m/s²";
Questao61.Resposta4 = "8.314 J/(mol·K)";
Questao61.Resposta5 = "1.602 x 10^-19 C";
Questao61.respostacorreta = 1;
Listaquestoes.Add(Questao61);

var Questao62 = new Questao();
Questao62.nivelpergunta = 7;
Questao62.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao62.Pergunta = "Qual é o princípio que estabelece que a energia total de um sistema isolado permanece constante?";
Questao62.Resposta1 = "Lei da Conservação da Energia";
Questao62.Resposta2 = "Princípio da Incerteza";
Questao62.Resposta3 = "Teoria do Caos";
Questao62.Resposta4 = "Princípio da Superposição";
Questao62.Resposta5 = "Teoria da Relatividade";
Questao62.respostacorreta = 1;
Listaquestoes.Add(Questao62);

var Questao63 = new Questao();
Questao63.nivelpergunta = 7;
Questao63.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao63.Pergunta = "Quem foi o físico que desenvolveu a teoria da relatividade geral?";
Questao63.Resposta1 = "Isaac Newton";
Questao63.Resposta2 = "Albert Einstein";
Questao63.Resposta3 = "Niels Bohr";
Questao63.Resposta4 = "Max Planck";
Questao63.Resposta5 = "Richard Feynman";
Questao63.respostacorreta = 2;
Listaquestoes.Add(Questao63);

var Questao64 = new Questao();
Questao64.nivelpergunta = 7;
Questao64.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao64.Pergunta = "Qual é a principal função da mitocôndria na célula?";
Questao64.Resposta1 = "Produzir energia";
Questao64.Resposta2 = "Armazenar DNA";
Questao64.Resposta3 = "Sintetizar proteínas";
Questao64.Resposta4 = "Realizar fotossíntese";
Questao64.Resposta5 = "Regulamentar o ciclo celular";
Questao64.respostacorreta = 1;
Listaquestoes.Add(Questao64);

var Questao65 = new Questao();
Questao65.nivelpergunta = 7;
Questao65.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao65.Pergunta = "Qual é a força responsável pela atração gravitacional entre dois corpos?";
Questao65.Resposta1 = "Força eletromagnética";
Questao65.Resposta2 = "Força nuclear forte";
Questao65.Resposta3 = "Força gravitacional";
Questao65.Resposta4 = "Força de atrito";
Questao65.Resposta5 = "Força nuclear fraca";
Questao65.respostacorreta = 3;
Listaquestoes.Add(Questao65);

var Questao66 = new Questao();
Questao66.nivelpergunta = 7;
Questao66.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao66.Pergunta = "Qual é o estado físico em que as partículas estão mais próximas umas das outras?";
Questao66.Resposta1 = "Sólido";
Questao66.Resposta2 = "Líquido";
Questao66.Resposta3 = "Gasoso";
Questao66.Resposta4 = "Plasma";
Questao66.Resposta5 = "Bose-Einstein condensado";
Questao66.respostacorreta = 1;
Listaquestoes.Add(Questao66);

var Questao67 = new Questao();
Questao67.nivelpergunta = 7;
Questao67.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao67.Pergunta = "Quem é considerado o pai da genética moderna?";
Questao67.Resposta1 = "Charles Darwin";
Questao67.Resposta2 = "Gregor Mendel";
Questao67.Resposta3 = "James Watson";
Questao67.Resposta4 = "Francis Crick";
Questao67.Resposta5 = "Barbara McClintock";
Questao67.respostacorreta = 2;
Listaquestoes.Add(Questao67);

var Questao68 = new Questao();
Questao68.nivelpergunta = 7;
Questao68.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao68.Pergunta = "Qual é a propriedade que permite a água se mover contra a gravidade em plantas?";
Questao68.Resposta1 = "Capilaridade";
Questao68.Resposta2 = "Tensão superficial";
Questao68.Resposta3 = "Difusão";
Questao68.Resposta4 = "Osmose";
Questao68.Resposta5 = "Evaporação";
Questao68.respostacorreta = 1;
Listaquestoes.Add(Questao68);

var Questao69 = new Questao();
Questao69.nivelpergunta = 7;
Questao69.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao69.Pergunta = "Qual é o método utilizado para determinar a idade de fósseis?";
Questao69.Resposta1 = "Datação por carbono-14";
Questao69.Resposta2 = "Datação por potássio-argônio";
Questao69.Resposta3 = "Datação termoluminescente";
Questao69.Resposta4 = "Estratigrafia";
Questao69.Resposta5 = "Análise de isótopos";
Questao69.respostacorreta = 1;
Listaquestoes.Add(Questao69);

var Questao70 = new Questao();
Questao70.nivelpergunta = 7;
Questao70.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao70.Pergunta = "Qual é a lei que descreve a relação entre a pressão e o volume de um gás?";
Questao70.Resposta1 = "Lei de Boyle";
Questao70.Resposta2 = "Lei de Charles";
Questao70.Resposta3 = "Lei de Avogadro";
Questao70.Resposta4 = "Lei de Dalton";
Questao70.Resposta5 = "Lei dos gases ideais";
Questao70.respostacorreta = 1;
Listaquestoes.Add(Questao70);


var Questao71 = new Questao();
Questao71.nivelpergunta = 8;
Questao71.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao71.Pergunta = "Qual é a teoria que descreve a origem do universo?";
Questao71.Resposta1 = "Teoria do Big Bang";
Questao71.Resposta2 = "Teoria do Estado Estacionário";
Questao71.Resposta3 = "Teoria da Relatividade Geral";
Questao71.Resposta4 = "Teoria da Evolução";
Questao71.Resposta5 = "Teoria da Gravidade Quântica";
Questao71.respostacorreta = 1;
Listaquestoes.Add(Questao71);

var Questao72 = new Questao();
Questao72.nivelpergunta = 8;
Questao72.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao72.Pergunta = "Qual partícula subatômica é responsável pela carga negativa?";
Questao72.Resposta1 = "Próton";
Questao72.Resposta2 = "Nêutron";
Questao72.Resposta3 = "Elétron";
Questao72.Resposta4 = "Positron";
Questao72.Resposta5 = "Fóton";
Questao72.respostacorreta = 3;
Listaquestoes.Add(Questao72);

var Questao73 = new Questao();
Questao73.nivelpergunta = 8;
Questao73.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao73.Pergunta = "Qual é a função dos ribossomos na célula?";
Questao73.Resposta1 = "Produzir energia";
Questao73.Resposta2 = "Síntese de proteínas";
Questao73.Resposta3 = "Armazenar informações genéticas";
Questao73.Resposta4 = "Transportar substâncias";
Questao73.Resposta5 = "Realizar fotossíntese";
Questao73.respostacorreta = 2;
Listaquestoes.Add(Questao73);

var Questao74 = new Questao();
Questao74.nivelpergunta = 8;
Questao74.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao74.Pergunta = "Qual é o processo pelo qual as plantas convertem luz solar em energia?";
Questao74.Resposta1 = "Respiração celular";
Questao74.Resposta2 = "Fotossíntese";
Questao74.Resposta3 = "Quimiossíntese";
Questao74.Resposta4 = "Fermentação";
Questao74.Resposta5 = "Condensação";
Questao74.respostacorreta = 2;
Listaquestoes.Add(Questao74);

var Questao75 = new Questao();
Questao75.nivelpergunta = 8;
Questao75.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao75.Pergunta = "Qual é o elemento mais abundante no universo?";
Questao75.Resposta1 = "Oxigênio";
Questao75.Resposta2 = "Hidrogênio";
Questao75.Resposta3 = "Carbono";
Questao75.Resposta4 = "Nitrogênio";
Questao75.Resposta5 = "Helio";
Questao75.respostacorreta = 2;
Listaquestoes.Add(Questao75);

var Questao76 = new Questao();
Questao76.nivelpergunta = 8;
Questao76.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao76.Pergunta = "Qual é a unidade de medida da pressão no Sistema Internacional?";
Questao76.Resposta1 = "Pascal";
Questao76.Resposta2 = "Joule";
Questao76.Resposta3 = "Newton";
Questao76.Resposta4 = "Watt";
Questao76.Resposta5 = "Bar";
Questao76.respostacorreta = 1;
Listaquestoes.Add(Questao76);

var Questao77 = new Questao();
Questao77.nivelpergunta = 8;
Questao77.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao77.Pergunta = "Qual é a teoria que explica a formação das espécies ao longo do tempo?";
Questao77.Resposta1 = "Teoria da Seleção Natural";
Questao77.Resposta2 = "Teoria da Evolução";
Questao77.Resposta3 = "Teoria do Catastrofismo";
Questao77.Resposta4 = "Teoria da Evolução Direcionada";
Questao77.Resposta5 = "Teoria da Hereditariedade";
Questao77.respostacorreta = 1;
Listaquestoes.Add(Questao77);

var Questao78 = new Questao();
Questao78.nivelpergunta = 8;
Questao78.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao78.Pergunta = "Qual é a partícula responsável pela força eletromagnética?";
Questao78.Resposta1 = "Fóton";
Questao78.Resposta2 = "Gluon";
Questao78.Resposta3 = "W e Z";
Questao78.Resposta4 = "Gravão";
Questao78.Resposta5 = "Elétron";
Questao78.respostacorreta = 1;
Listaquestoes.Add(Questao78);

var Questao79 = new Questao();
Questao79.nivelpergunta = 8;
Questao79.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao79.Pergunta = "Qual é a base da teoria atômica moderna?";
Questao79.Resposta1 = "Os átomos são indivisíveis";
Questao79.Resposta2 = "Os átomos podem ser divididos em partículas subatômicas";
Questao79.Resposta3 = "Os átomos são todos iguais";
Questao79.Resposta4 = "Os átomos não reagem quimicamente";
Questao79.Resposta5 = "Os átomos são maciços e inertes";
Questao79.respostacorreta = 2;
Listaquestoes.Add(Questao79);

var Questao80 = new Questao();
Questao80.nivelpergunta = 8;
Questao80.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao80.Pergunta = "Qual é a força que mantém os elétrons em órbita ao redor do núcleo atômico?";
Questao80.Resposta1 = "Força eletromagnética";
Questao80.Resposta2 = "Força gravitacional";
Questao80.Resposta3 = "Força nuclear forte";
Questao80.Resposta4 = "Força nuclear fraca";
Questao80.Resposta5 = "Força de atrito";
Questao80.respostacorreta = 1;
Listaquestoes.Add(Questao80);


var Questao81 = new Questao();
Questao81.nivelpergunta = 9;
Questao81.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao81.Pergunta = "Qual é a equação que relaciona massa e energia na teoria da relatividade?";
Questao81.Resposta1 = "E = mc²";
Questao81.Resposta2 = "F = ma";
Questao81.Resposta3 = "PV = nRT";
Questao81.Resposta4 = "a² + b² = c²";
Questao81.Resposta5 = "V = IR";
Questao81.respostacorreta = 1;
Listaquestoes.Add(Questao81);

var Questao82 = new Questao();
Questao82.nivelpergunta = 9;
Questao82.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao82.Pergunta = "Qual é a função do ácido ribonucleico (RNA) na célula?";
Questao82.Resposta1 = "Armazenar informações genéticas";
Questao82.Resposta2 = "Síntese de proteínas";
Questao82.Resposta3 = "Replicação do DNA";
Questao82.Resposta4 = "Transportar oxigênio";
Questao82.Resposta5 = "Produzir ATP";
Questao82.respostacorreta = 2;
Listaquestoes.Add(Questao82);

var Questao83 = new Questao();
Questao83.nivelpergunta = 9;
Questao83.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao83.Pergunta = "Qual é o princípio da física que estabelece que a pressão de um gás é inversamente proporcional ao seu volume?";
Questao83.Resposta1 = "Lei de Boyle";
Questao83.Resposta2 = "Lei de Charles";
Questao83.Resposta3 = "Lei de Avogadro";
Questao83.Resposta4 = "Lei de Dalton";
Questao83.Resposta5 = "Lei dos Gases Ideais";
Questao83.respostacorreta = 1;
Listaquestoes.Add(Questao83);

var Questao84 = new Questao();
Questao84.nivelpergunta = 9;
Questao84.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao84.Pergunta = "Qual é a técnica utilizada para separar misturas de substâncias com base em suas massas e tamanhos?";
Questao84.Resposta1 = "Cromatografia";
Questao84.Resposta2 = "Centífuga";
Questao84.Resposta3 = "Filtração";
Questao84.Resposta4 = "Destilação";
Questao84.Resposta5 = "Eletroforese";
Questao84.respostacorreta = 5;
Listaquestoes.Add(Questao84);

var Questao85 = new Questao();
Questao85.nivelpergunta = 9;
Questao85.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao85.Pergunta = "Qual é o conceito que descreve a capacidade de um organismo de se adaptar ao seu ambiente ao longo do tempo?";
Questao85.Resposta1 = "Mutação";
Questao85.Resposta2 = "Seleção Natural";
Questao85.Resposta3 = "Evolução";
Questao85.Resposta4 = "Especiação";
Questao85.Resposta5 = "Transgênico";
Questao85.respostacorreta = 3;
Listaquestoes.Add(Questao85);

var Questao86 = new Questao();
Questao86.nivelpergunta = 9;
Questao86.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao86.Pergunta = "Qual é a unidade de medida da constante gravitacional?";
Questao86.Resposta1 = "m³/(kg·s²)";
Questao86.Resposta2 = "N·m²/kg²";
Questao86.Resposta3 = "J/kg";
Questao86.Resposta4 = "Pa·s";
Questao86.Resposta5 = "kg·m/s²";
Questao86.respostacorreta = 2;
Listaquestoes.Add(Questao86);

var Questao87 = new Questao();
Questao87.nivelpergunta = 9;
Questao87.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao87.Pergunta = "Qual é a principal causa do efeito estufa?";
Questao87.Resposta1 = "Desmatamento";
Questao87.Resposta2 = "Emissão de gases poluentes";
Questao87.Resposta3 = "Uso de combustíveis fósseis";
Questao87.Resposta4 = "Aumento da população";
Questao87.Resposta5 = "Atividades industriais";
Questao87.respostacorreta = 3;
Listaquestoes.Add(Questao87);

var Questao88 = new Questao();
Questao88.nivelpergunta = 9;
Questao88.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao88.Pergunta = "Qual fenômeno é causado pela interação de cargas elétricas opostas?";
Questao88.Resposta1 = "Magnetismo";
Questao88.Resposta2 = "Força Gravitacional";
Questao88.Resposta3 = "Eletricidade estática";
Questao88.Resposta4 = "Eletromagnetismo";
Questao88.Resposta5 = "Resistência elétrica";
Questao88.respostacorreta = 3;
Listaquestoes.Add(Questao88);

var Questao89 = new Questao();
Questao89.nivelpergunta = 9;
Questao89.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao89.Pergunta = "Qual é a abordagem científica que estuda a relação entre organismos e seu ambiente?";
Questao89.Resposta1 = "Biogeografia";
Questao89.Resposta2 = "Ecologia";
Questao89.Resposta3 = "Taxonomia";
Questao89.Resposta4 = "Fisiologia";
Questao89.Resposta5 = "Genética";
Questao89.respostacorreta = 2;
Listaquestoes.Add(Questao89);

var Questao90 = new Questao();
Questao90.nivelpergunta = 9;
Questao90.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao90.Pergunta = "Qual é a lei que relaciona a corrente, tensão e resistência em um circuito elétrico?";
Questao90.Resposta1 = "Lei de Ohm";
Questao90.Resposta2 = "Lei de Kirchhoff";
Questao90.Resposta3 = "Lei de Faraday";
Questao90.Resposta4 = "Lei de Coulomb";
Questao90.Resposta5 = "Lei da Conservação de Energia";
Questao90.respostacorreta = 1;
Listaquestoes.Add(Questao90);


var Questao91 = new Questao();
Questao91.nivelpergunta = 10;
Questao91.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao91.Pergunta = "Qual é o princípio que afirma que a energia total em um sistema isolado permanece constante?";
Questao91.Resposta1 = "Princípio da Conservação de Energia";
Questao91.Resposta2 = "Princípio da Incerteza";
Questao91.Resposta3 = "Princípio da Termodinâmica";
Questao91.Resposta4 = "Princípio de Pascal";
Questao91.Resposta5 = "Princípio de Arquimedes";
Questao91.respostacorreta = 1;
Listaquestoes.Add(Questao91);

var Questao92 = new Questao();
Questao92.nivelpergunta = 10;
Questao92.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao92.Pergunta = "Qual teoria científica explica a origem das espécies pela seleção natural?";
Questao92.Resposta1 = "Teoria da Evolução";
Questao92.Resposta2 = "Teoria da Relatividade";
Questao92.Resposta3 = "Teoria da Gravitação Universal";
Questao92.Resposta4 = "Teoria do Big Bang";
Questao92.Resposta5 = "Teoria da Quântica";
Questao92.respostacorreta = 1;
Listaquestoes.Add(Questao92);

var Questao93 = new Questao();
Questao93.nivelpergunta = 10;
Questao93.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao93.Pergunta = "Qual é a técnica utilizada para determinar a idade de fósseis através da decomposição radioativa?";
Questao93.Resposta1 = "Datação por Carbono-14";
Questao93.Resposta2 = "Datação Relativa";
Questao93.Resposta3 = "Datação Estratigráfica";
Questao93.Resposta4 = "Datação Isotópica";
Questao93.Resposta5 = "Datação Química";
Questao93.respostacorreta = 1;
Listaquestoes.Add(Questao93);

var Questao94 = new Questao();
Questao94.nivelpergunta = 10;
Questao94.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao94.Pergunta = "Qual é a unidade de medida da radioatividade no Sistema Internacional?";
Questao94.Resposta1 = "Sievert";
Questao94.Resposta2 = "Becquerel";
Questao94.Resposta3 = "Gray";
Questao94.Resposta4 = "Curie";
Questao94.Resposta5 = "Rem";
Questao94.respostacorreta = 2;
Listaquestoes.Add(Questao94);

var Questao95 = new Questao();
Questao95.nivelpergunta = 10;
Questao95.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao95.Pergunta = "Qual é a lei que estabelece que a corrente em um circuito é diretamente proporcional à tensão e inversamente proporcional à resistência?";
Questao95.Resposta1 = "Lei de Faraday";
Questao95.Resposta2 = "Lei de Ohm";
Questao95.Resposta3 = "Lei de Kirchhoff";
Questao95.Resposta4 = "Lei de Coulomb";
Questao95.Resposta5 = "Lei de Lenz";
Questao95.respostacorreta = 2;
Listaquestoes.Add(Questao95);

var Questao96 = new Questao();
Questao96.nivelpergunta = 10;
Questao96.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao96.Pergunta = "Qual é a descoberta que estabeleceu a estrutura do DNA como uma dupla hélice?";
Questao96.Resposta1 = "James Watson e Francis Crick";
Questao96.Resposta2 = "Rosalind Franklin";
Questao96.Resposta3 = "Gregor Mendel";
Questao96.Resposta4 = "Charles Darwin";
Questao96.Resposta5 = "Louis Pasteur";
Questao96.respostacorreta = 1;
Listaquestoes.Add(Questao96);

var Questao97 = new Questao();
Questao97.nivelpergunta = 10;
Questao97.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao97.Pergunta = "Qual é o conceito que descreve a variação de espécies em resposta a mudanças ambientais?";
Questao97.Resposta1 = "Adaptação";
Questao97.Resposta2 = "Mutação";
Questao97.Resposta3 = "Especiação";
Questao97.Resposta4 = "Extinção";
Questao97.Resposta5 = "Diversificação";
Questao97.respostacorreta = 1;
Listaquestoes.Add(Questao97);

var Questao98 = new Questao();
Questao98.nivelpergunta = 10;
Questao98.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao98.Pergunta = "Qual é a base molecular das características hereditárias?";
Questao98.Resposta1 = "Proteínas";
Questao98.Resposta2 = "Ácidos nucleicos";
Questao98.Resposta3 = "Carboidratos";
Questao98.Resposta4 = "Lipídios";
Questao98.Resposta5 = "Vitaminas";
Questao98.respostacorreta = 2;
Listaquestoes.Add(Questao98);

var Questao99 = new Questao();
Questao99.nivelpergunta = 10;
Questao99.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao99.Pergunta = "Qual fenômeno físico é responsável pela formação de arco-íris?";
Questao99.Resposta1 = "Refração";
Questao99.Resposta2 = "Reflexão";
Questao99.Resposta3 = "Difração";
Questao99.Resposta4 = "Dispersão";
Questao99.Resposta5 = "Transmissão";
Questao99.respostacorreta = 4;
Listaquestoes.Add(Questao99);

var Questao100 = new Questao();
Questao100.nivelpergunta = 10;
Questao100.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
Questao100.Pergunta = "Qual é o tipo de ligação química formada pelo compartilhamento de elétrons entre átomos?";
Questao100.Resposta1 = "Ligação iônica";
Questao100.Resposta2 = "Ligação covalente";
Questao100.Resposta3 = "Ligação metálica";
Questao100.Resposta4 = "Ligação de hidrogênio";
Questao100.Resposta5 = "Ligação dipolo-dipolo";
Questao100.respostacorreta = 2;
Listaquestoes.Add(Questao100);
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
    labelPontuacao.Text = "Pontuaçao:R$" +Pontuacao.ToString();
    labelNivel.Text = "Nivel:" + NivelAtual.ToString();
    
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
   
