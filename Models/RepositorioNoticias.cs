using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;
        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null)
                    CriarNoticias();
                return noticias;
            }
        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();
            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Novas medidas para tornar PIX mais seguro entram em vigor em 16 de novembro, anuncia BC",
                Autor = "João Carlos",
                Data = DateTime.Today,
                Conteudo = "O Banco Central (BC) anunciou nesta terça-feira (28) que novas medidas para tornar o PIX mais seguro entrarão em vigor no dia 16 de novembro. O PIX é um mecanismo de transferência de recursos que opera em tempo real, 24 horas por dia. Recentemente, a tecnologia passou a ser utilizada por criminosos para a prática de fraudes e, por isso, o Banco Central anunciou no fim de agosto que lançaria um conjunto de medidas para reduzir a vulnerabilidade dos sistemas às ações de criminosos."
            });
            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "ANS autua Prevent Senior após denúncia de falta de informações para pacientes com Covid-19",
                Autor = "Carlos",
                Data = DateTime.Today.AddDays(-2),
                Conteudo = "A Agência Nacional de Saúde Suplementar (ANS) informou nesta terça-feira (28) que autuou a Prevent Senior após constatar 'indícios de infração' por 'deixar de comunicar aos beneficiários as informações estabelecidas em lei'. A empresa tem 10 dias para se manifestar sobre o assunto. Segundo o órgão regulador, após apuração de denúncias contra a Prevent Senior, 'foram verificados elementos que contradizem a versão inicial apresentada'. A ANS informa, ainda, que 'segue com as análises de documentos(...) a respeito das denúncias sobre cerceamento ao exercício da atividade médica'."
            });
            noticias.Add(new Noticia
            {
                Id = 3,
                Titulo = "Lava do vulcão Cumbre Vieja toca o mar nas Canárias; veja VÍDEO",
                Autor = "Marcos",
                Data = DateTime.Today.AddDays(-5),
                Conteudo = "A lava do vulcão Cumbre Vieja tocou nesta terça-feira (28) o mar do Atlântico, informou o Instituto Vulcanológico das Canárias (Involcan) em um comunicado. O vulcão entrou em erupção no domingo (19) e desde então deixou um rastro de destruição no arquipélago espanhol. Especialistas alertam que o rápido resfriamento da lava ao entrar em contato com a água do oceano é preocupante, porque pode liberar gases tóxicos, carregados de ácido clorídrico. Não há, até o momento, o registro de mortos ou feridos por decorrência da atividade vulcânica na ilha."
            });
            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "Em busca do tri! Palmeiras empata com Atlético-MG e vai à final da Libertadores",
                Autor = "Eustacio",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "Em busca do tri! O Palmeiras vai à final da Copa Libertadores pelo segundo ano consecutivo.O empate por 1 a 1 com o Atlético - MG, nesta terça - feira, num Mineirão com barulhenta torcida do Galo, não foi fácil, mas serviu para manter vivo o sonho do tricampeonato continental – após as conquistas de 1999 e 2020, esta última vencendo o Santos, em janeiro passado.O Atlético, jogando em casa e com apoio, abriu o placar com Vargas, já no segundo tempo, mas fica pelo caminho mesmo invicto – uma eliminação dolorida, sem uma derrota sequer na campanha. Isso porque um iluminado Gabriel Veron entrou e, em sua primeira jogada, deu o gol de empate de presente para Dudu, decisivo, levar o Verdão à decisão pelo critério do gol fora de casa(o jogo de ida terminou 0 a 0, em São Paulo).Agora é esperar Flamengo ou Barcelona - EQU na decisão de 27 de novembro, em Montevidéu."
            });
            noticias.Add(new Noticia
            {
                Id = 5,
                Titulo = "Botijão de gás já consome 10% do salário mínimo em 16 estados",
                Autor = "Cleiton",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "Um item essencial para milhões de famílias, o botijão de gás de cozinha já custa o equivalente a 10% do salário mínimo em 16 estados. Dona Ana Maria cuida sozinha dos três netos.A filha dela, mãe das crianças, morreu em 2020. Sem trabalho nem aposentadoria, a única renda da casa vem de um programa social do governo do Distrito Federal: R$ 250 por mês. Na cidade dela, um botijão custa R$ 90."
            });
        }
    }
}