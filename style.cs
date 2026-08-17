/* =================================
   CONFIGURAÇÕES GERAIS
================================= */

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}


body {
    font-family: Arial, sans-serif;

    background-color: white;

    color: #222;

    min-height: 100vh;
}


/* =================================
   CABEÇALHO
================================= */

.cabecalho {

    min-height: 120px;

    display: flex;

    align-items: center;

    justify-content: space-between;

    padding: 25px 50px;

    border-bottom: 1px solid #222;
}


.logo {

    font-size: 42px;

    font-weight: normal;

    text-transform: uppercase;
}


.menu {

    display: flex;

    flex-direction: column;

    gap: 10px;
}


.menu button {

    background: transparent;

    border: none;

    font-size: 16px;

    cursor: pointer;

    text-transform: uppercase;
}


.menu button:hover {

    text-decoration: underline;
}



/* =================================
   FILMES
================================= */

.filmes {

    padding: 35px 40px 45px;

    border-bottom: 1px solid #222;
}


.filmes > h2 {

    text-align: center;

    font-size: 24px;

    margin-bottom: 35px;
}


.carrossel {

    display: flex;

    align-items: center;

    justify-content: center;

    gap: 30px;
}



/* =================================
   SETAS
================================= */

.seta {

    width: 55px;

    height: 55px;

    border-radius: 50%;

    border: 1px solid #222;

    background: white;

    font-size: 25px;

    cursor: pointer;

    flex-shrink: 0;
}


.seta:hover {

    background-color: #eee;
}



/* =================================
   FILMES
================================= */

.filme {

    text-align: center;
}


.filme-lateral {

    width: 180px;

    opacity: 0.75;
}


.filme-principal {

    width: 350px;
}


.capa {

    width: 100%;

    height: 240px;

    border: 1px solid #222;

    overflow: hidden;

    background-color: #f5f5f5;

    display: flex;

    align-items: center;

    justify-content: center;
}


.filme-principal .capa {

    height: 300px;
}


.capa img {

    width: 100%;

    height: 100%;

    object-fit: cover;

    display: block;
}


.filme h3 {

    margin-top: 12px;

    font-size: 18px;
}


.filme-principal p {

    margin-top: 10px;

    line-height: 1.5;

    font-size: 14px;
}



/* =================================
   PARTE INFERIOR
================================= */

.parte-inferior {

    display: grid;

    grid-template-columns: 1fr 1.5fr;

    min-height: 500px;
}



/* =================================
   TRILHA SONORA
================================= */

.trilha {

    padding: 35px;

    border-right: 1px solid #222;
}


.trilha h2 {

    margin-bottom: 25px;
}



/* =================================
   PLAYER
================================= */

.player {

    padding: 20px;

    border: 1px solid #222;

    border-radius: 20px;
}


.album {

    width: 100%;

    height: 170px;

    border: 1px solid #222;

    overflow: hidden;

    margin-bottom: 20px;

    background-color: #f5f5f5;
}


.album img {

    width: 100%;

    height: 100%;

    object-fit: cover;
}


.musica-info {

    margin-bottom: 20px;
}


.musica-info h3 {

    margin-bottom: 5px;
}


.musica-info p {

    font-size: 14px;
}



/* =================================
   CONTROLES DO PLAYER
================================= */

.controles {

    display: flex;

    align-items: center;

    gap: 12px;
}


.controles button {

    border: none;

    background: transparent;

    font-size: 22px;

    cursor: pointer;
}


.barra {

    flex: 1;

    height: 5px;

    background-color: #ddd;

    border-radius: 5px;

    overflow: hidden;
}


.progresso {

    width: 0%;

    height: 100%;

    background-color: #222;
}


#tempo {

    font-size: 12px;

    min-width: 35px;
}



/* =================================
   LISTA DE MÚSICAS
================================= */

.lista-musicas {

    margin-top: 20px;

    display: flex;

    flex-direction: column;

    gap: 4px;
}


.lista-musicas button {

    padding: 9px 10px;

    border: none;

    background: transparent;

    text-align: left;

    cursor: pointer;

    font-size: 14px;
}


.lista-musicas button:hover {

    background-color: #eee;
}



/* =================================
   SOBRE
================================= */

.sobre {

    padding: 35px;
}


.sobre h2 {

    margin-bottom: 25px;
}


.sobre p {

    max-width: 600px;

    line-height: 1.7;

    margin-bottom: 20px;
}



/* =================================
   RODAPÉ
================================= */

footer {

    padding: 25px;

    text-align: center;

    border-top: 1px solid #222;
}



/* =================================
   RESPONSIVIDADE
================================= */

@media (max-width: 900px) {

    .filme-lateral {

        display: none;
    }

}


@media (max-width: 700px) {

    .cabecalho {

        flex-direction: column;

        gap: 20px;

        text-align: center;
    }


    .logo {

        font-size: 32px;
    }


    .carrossel {

        gap: 10px;
    }


    .filme-principal {

        width: 70%;
    }


    .seta {

        width: 45px;

        height: 45px;
    }


    .parte-inferior {

        grid-template-columns: 1fr;
    }


    .trilha {

        border-right: none;

        border-bottom: 1px solid #222;
    }

}