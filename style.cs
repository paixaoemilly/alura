
:root {
  --blue-green: #82b5b6;
  --green: #83bd45;
  --white: #ffffff;
  --black: #000000;
}

* {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

html {
  scroll-behavior: smooth;
}

body {
  background: var(--green);
  color: var(--white);
  font-family: "Libre Baskerville", Georgia, serif;
}

/* =========================
   CABEÇALHO
========================= */

.hero {
  height: 178px;
  min-height: 150px;
  background-image:
    linear-gradient(rgba(0, 0, 0, 0.03), rgba(0, 0, 0, 0.03)),
    url("imagens/fundo.jpg");
  background-size: cover;
  background-position: center 43%;
  border-bottom: 3px solid var(--white);
  display: flex;
  align-items: center;
  justify-content: center;
  text-align: center;
}

.hero-overlay {
  width: 100%;
  padding-top: 5px;
}

.japanese-title {
  font-family: "Libre Baskerville", serif;
  font-size: clamp(20px, 2.2vw, 38px);
  letter-spacing: 5px;
  margin-bottom: -5px;
}

.hero h1 {
  font-family: "DM Serif Display", Georgia, serif;
  font-size: clamp(46px, 5.3vw, 86px);
  font-weight: 400;
  letter-spacing: 2px;
  line-height: 1;
}

/* =========================
   FILMES
========================= */

.films-section {
  height: 288px;
  background: var(--blue-green);
  border-bottom: 3px solid var(--white);
  padding: 25px 20px 30px;
}

h2 {
  font-family: "DM Serif Display", Georgia, serif;
  font-size: clamp(34px, 3vw, 50px);
  font-weight: 400;
}

.films-section h2 {
  text-align: center;
  margin-bottom: 27px;
}

.films-carousel {
  width: 100%;
  display: flex;
  align-items: center;
  gap: 20px;
}

.films-window {
  flex: 1;
  overflow: hidden;
}

.films-track {
  display: flex;
  gap: 28px;
  transition: transform 0.45s ease;
}

.film-card {
  flex: 0 0 calc((100% - 112px) / 5);
  height: 147px;
  overflow: hidden;
}

.film-card img {
  width: 100%;
  height: 100%;
  display: block;
  object-fit: cover;
  transition: transform 0.25s ease;
}

.film-card:hover img {
  transform: scale(1.035);
}

.carousel-btn {
  flex: 0 0 42px;
  width: 42px;
  height: 42px;
  border: 0;
  border-radius: 50%;
  background: var(--white);
  color: var(--blue-green);
  font-size: 30px;
  font-family: Arial, sans-serif;
  font-weight: bold;
  cursor: pointer;
  line-height: 42px;
  transition: transform 0.2s ease;
}

.carousel-btn:hover {
  transform: scale(1.08);
}

/* =========================
   PARTE INFERIOR
========================= */

.bottom-section {
  min-height: 410px;
  display: grid;
  grid-template-columns: 48% 52%;
}

.music-section {
  min-height: 410px;
  border-right: 3px solid var(--white);
  display: grid;
  grid-template-columns: 43% 57%;
  padding: 15px 25px 25px 30px;
}

.music-list h2 {
  margin-bottom: 35px;
}

.music-item,
.more-music {
  display: block;
  color: var(--white);
  font: inherit;
  font-family: "DM Serif Display", Georgia, serif;
  font-size: clamp(25px, 2vw, 34px);
  line-height: 1.35;
}

.music-item {
  background: transparent;
  border: 0;
  cursor: pointer;
  text-align: left;
  margin-bottom: 2px;
}

.music-item:hover,
.music-item.active {
  text-decoration: underline;
}

.more-music {
  margin-top: 3px;
  margin-left: 48px;
}

.player {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: flex-start;
  padding: 0 10px;
}

.album-art {
  width: min(340px, 95%);
  aspect-ratio: 1 / 0.8;
  margin-top: 0;
  overflow: hidden;
}

.album-art img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}

.song-name {
  font-family: "DM Serif Display", Georgia, serif;
  font-size: clamp(24px, 2vw, 32px);
  margin: 7px 0 8px;
}

.progress-area {
  width: min(310px, 90%);
}

#progress {
  width: 100%;
  height: 5px;
  accent-color: var(--black);
  cursor: pointer;
}

.player-controls {
  display: flex;
  align-items: center;
  justify-content: center;
  gap: clamp(15px, 2vw, 28px);
  margin-top: 12px;
}

.control {
  border: 0;
  background: transparent;
  color: var(--black);
  cursor: pointer;
  font-family: Arial, sans-serif;
  font-size: 35px;
  line-height: 1;
}

.control.small {
  font-size: 31px;
}

.control.play {
  width: 70px;
  height: 70px;
  border: 3px solid var(--black);
  border-radius: 50%;
  font-size: 32px;
  display: flex;
  align-items: center;
  justify-content: center;
}

.control:hover {
  transform: scale(1.08);
}

/* =========================
   SOBRE
========================= */

.about-section {
  padding: 15px 40px 30px;
  text-align: center;
}

.about-section h2 {
  text-align: left;
  margin-bottom: 25px;
}

.about-section p {
  max-width: 810px;
  margin: 0 auto;
  font-size: clamp(17px, 1.35vw, 23px);
  line-height: 1.55;
  font-weight: 700;
}

/* =========================
   RESPONSIVO
========================= */

@media (max-width: 1050px) {
  .film-card {
    flex-basis: calc((100% - 56px) / 3);
  }

  .films-section {
    height: auto;
    padding-bottom: 35px;
  }

  .bottom-section {
    grid-template-columns: 1fr;
  }

  .music-section {
    border-right: 0;
    border-bottom: 3px solid var(--white);
  }

  .about-section {
    padding-bottom: 45px;
  }
}

@media (max-width: 700px) {
  .hero {
    height: 150px;
  }

  .japanese-title {
    font-size: 17px;
  }

  .hero h1 {
    font-size: 39px;
  }

  .films-section {
    padding-left: 12px;
    padding-right: 12px;
  }

  .films-carousel {
    gap: 8px;
  }

  .films-track {
    gap: 12px;
  }

  .film-card {
    flex-basis: 100%;
    height: 175px;
  }

  .carousel-btn {
    flex-basis: 36px;
    width: 36px;
    height: 36px;
    font-size: 25px;
    line-height: 36px;
  }

  .music-section {
    grid-template-columns: 1fr;
    gap: 30px;
    padding: 20px;
  }

  .music-list {
    text-align: center;
  }

  .music-list h2 {
    text-align: left;
  }

  .music-item {
    margin: 0 auto;
    text-align: center;
  }

  .more-music {
    margin: 5px auto;
  }

  .about-section {
    padding: 20px;
  }

  .about-section h2 {
    text-align: center;
  }

  .about-section p {
    font-size: 16px;
    line-height: 1.65;
  }
}
