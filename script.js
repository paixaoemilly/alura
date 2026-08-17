/* =================================
   FILMES
================================= */


const filmes = [

    {
        nome: "A Viagem de Chihiro",

        descricao:
            "Uma garota entra em um mundo mágico e precisa encontrar uma maneira de salvar seus pais.",

        imagem:
            "imagens/chihiro.jpg"
    },


    {
        nome: "Meu Vizinho Totoro",

        descricao:
            "Duas irmãs descobrem criaturas mágicas enquanto vivem no interior do Japão.",

        imagem:
            "imagens/totoro.jpg"
    },


    {
        nome: "O Castelo Animado",

        descricao:
            "Uma jovem encontra um misterioso castelo mágico e seu excêntrico dono.",

        imagem:
            "imagens/castelo-animado.jpg"
    },


    {
        nome: "Princesa Mononoke",

        descricao:
            "Uma história sobre a relação entre a humanidade, a natureza e os espíritos da floresta.",

        imagem:
            "imagens/princesa-mononoke.jpg"
    },


    {
        nome: "O Serviço de Entregas da Kiki",

        descricao:
            "Uma jovem bruxa parte para uma nova cidade para iniciar sua vida independente.",

        imagem:
            "imagens/kiki.jpg"
    }

];


let filmeAtual = 0;



/* =================================
   ELEMENTOS DO HTML
================================= */

const filmeAtualImagem =
    document.getElementById("filmeAtualImagem");


const filmeAtualNome =
    document.getElementById("filmeAtualNome");


const filmeAtualDescricao =
    document.getElementById("filmeAtualDescricao");


const filmeAnteriorImagem =
    document.getElementById("filmeAnteriorImagem");


const filmeAnteriorNome =
    document.getElementById("filmeAnteriorNome");


const proximoFilmeImagem =
    document.getElementById("proximoFilmeImagem");


const proximoFilmeNome =
    document.getElementById("proximoFilmeNome");



/* =================================
   ATUALIZAR CARROSSEL
================================= */

function atualizarCarrossel() {

    const atual =
        filmes[filmeAtual];


    const anteriorIndex =
        (filmeAtual - 1 + filmes.length)
        % filmes.length;


    const proximoIndex =
        (filmeAtual + 1)
        % filmes.length;


    const anterior =
        filmes[anteriorIndex];


    const proximo =
        filmes[proximoIndex];



    /* Filme principal */

    filmeAtualNome.textContent =
        atual.nome;


    filmeAtualDescricao.textContent =
        atual.descricao;


    filmeAtualImagem.src =
        atual.imagem;


    filmeAtualImagem.alt =
        atual.nome;



    /* Filme anterior */

    filmeAnteriorNome.textContent =
        anterior.nome;


    filmeAnteriorImagem.src =
        anterior.imagem;


    filmeAnteriorImagem.alt =
        anterior.nome;



    /* Próximo filme */

    proximoFilmeNome.textContent =
        proximo.nome;


    proximoFilmeImagem.src =
        proximo.imagem;


    proximoFilmeImagem.alt =
        proximo.nome;

}



/* =================================
   BOTÃO ANTERIOR
================================= */

document
    .getElementById("anteriorBtn")
    .addEventListener("click", function () {

        filmeAtual--;

        if (filmeAtual < 0) {

            filmeAtual =
                filmes.length - 1;
        }

        atualizarCarrossel();

    });



/* =================================
   BOTÃO PRÓXIMO
================================= */

document
    .getElementById("proximoBtn")
    .addEventListener("click", function () {

        filmeAtual++;

        if (filmeAtual >= filmes.length) {

            filmeAtual = 0;
        }

        atualizarCarrossel();

    });



/* =================================
   INICIAR CARROSSEL
================================= */

atualizarCarrossel();



/* =================================
   BOTÕES DE IDIOMA E INFORMAÇÃO
================================= */

document
    .getElementById("idiomaBtn")
    .addEventListener("click", function () {

        alert("A opção de idioma será adicionada em breve!");

    });



document
    .getElementById("informacaoBtn")
    .addEventListener("click", function () {

        alert(
            "Este site apresenta informações sobre filmes e trilhas sonoras do Studio Ghibli."
        );

    });



/* =================================
   TRILHA SONORA
================================= */


/*
    Por enquanto as músicas são apenas
    exemplos.

    Quando você tiver os arquivos de áudio,
    podemos colocar os caminhos aqui.
*/

const musicas = [

    {
        nome: "Música 01",

        filme: "A Viagem de Chihiro",

        arquivo: ""
    },


    {
        nome: "Música 02",

        filme: "Meu Vizinho Totoro",

        arquivo: ""
    },


    {
        nome: "Música 03",

        filme: "O Castelo Animado",

        arquivo: ""
    },


    {
        nome: "Música 04",

        filme: "Princesa Mononoke",

        arquivo: ""
    },


    {
        nome: "Música 05",

        filme: "O Serviço de Entregas da Kiki",

        arquivo: ""
    }

];


let musicaAtual = 0;


const nomeMusica =
    document.getElementById("nomeMusica");


const nomeFilmeMusica =
    document.getElementById("nomeFilmeMusica");


const playBtn =
    document.getElementById("playBtn");



/* =================================
   SELECIONAR MÚSICA
================================= */

function selecionarMusica(numero) {

    musicaAtual = numero;

    const musica =
        musicas[musicaAtual];


    nomeMusica.textContent =
        musica.nome;


    nomeFilmeMusica.textContent =
        musica.filme;

}



/* =================================
   CLIQUES NAS MÚSICAS
================================= */

const botoesMusica =
    document.querySelectorAll(".musica");


botoesMusica.forEach(function (botao) {

    botao.addEventListener("click", function () {

        const numero =
            Number(botao.dataset.musica);


        selecionarMusica(numero);

    });

});



/* =================================
   BOTÃO PLAY
================================= */

playBtn.addEventListener("click", function () {

    alert(
        "O player será conectado às músicas quando os arquivos de áudio forem adicionados."
    );

});