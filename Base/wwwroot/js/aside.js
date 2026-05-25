class MenuLateral extends HTMLElement {
    connectedCallback() {
        this.innerHTML = `
            <div class="sombra"></div>

            <aside class="menu_lateral">
                <div class="div_seta_ma" id="setaMenu">
                    <svg xmlns="http://www.w3.org/2000/svg"
                        viewBox="0 0 640 640"><!--! Font Awesome Pro 7.1.0 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license (Commercial License) Copyright 2025 Fonticons, Inc. -->
                        <path
                        d="M229.8 156.4C216.3 145 214.5 124.8 225.9 111.3C237.3 97.8 257.4 96 271 107.4C317.8 146.7 363.3 189.3 405.6 233.4C423.9 252.5 450.9 280.5 471.1 301.3C497.5 330.9 464.3 353.1 442.1 370.1C435.8 375.8 429.4 381.6 422.9 387.6C389.8 418.7 354.8 445 323.8 480C312.5 492.1 298.5 506.9 286.1 517.4C279.4 523.2 273.2 528.9 268.4 534.1C240 564.8 193.1 521.8 221.2 490.8C239.9 471.5 257.8 458 274.9 438.4C305.4 403.7 343.8 373.5 378.2 341.7C385.6 334.9 393.1 327.9 401 320.9C345.1 262.1 291.6 207.7 229.7 156.4L229.7 156.4z" />
                    </svg>                
                </div>

                <div class="container_lateral">
                    <a href="/home/index.html" class="logo_box">
                        <img src="/img/logoV.svg" alt="">
                        <span>bibliotec</span>
                    </a>

                    <nav class="nav_box">
                        <div>
                            <a class="menu_item" href="/perfil/index.html">
                                <img src="/img/icon-dino.png" alt="">
                                <span>perfil</span>
                            </a>
                            <a class="menu_item" href="#">
                                <svg xmlns="http://www.w3.org/2000/svg"
                                    viewBox="0 0 640 640"><!--!Font Awesome Free 7.1.0 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2026 Fonticons, Inc.-->
                                    <path
                                        d="M136 192C136 125.7 189.7 72 256 72C322.3 72 376 125.7 376 192C376 258.3 322.3 312 256 312C189.7 312 136 258.3 136 192zM48 546.3C48 447.8 127.8 368 226.3 368L285.7 368C384.2 368 464 447.8 464 546.3C464 562.7 450.7 576 434.3 576L77.7 576C61.3 576 48 562.7 48 546.3zM544 160C557.3 160 568 170.7 568 184L568 232L616 232C629.3 232 640 242.7 640 256C640 269.3 629.3 280 616 280L568 280L568 328C568 341.3 557.3 352 544 352C530.7 352 520 341.3 520 328L520 280L472 280C458.7 280 448 269.3 448 256C448 242.7 458.7 232 472 232L520 232L520 184C520 170.7 530.7 160 544 160z" />
                                </svg>
                                <span>cadastrar usuário</span>
                            </a>
                            <a class="menu_item" href="#">
                                <img src="../img/users-solid 1.svg" alt="">
                                <span>listar usuários</span>
                            </a>
                            <a class="menu_item" href="/cadastroLivro/index.html">
                                <img src="../img/book-plus.svg" alt="">
                                <span>cadastrar livro</span>
                            </a>
                            <a class="menu_item menu_item_ativo" href="/listaLivros/index.html">
                                <img src="../img/books.svg" alt="">
                                <span>listar livros</span>
                            </a>
                            <a class="menu_item" href="#">
                                <svg xmlns="http://www.w3.org/2000/svg"
                                    viewBox="0 0 576 512"><!--! Font Awesome Pro 7.1.0 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license (Commercial License) Copyright 2025 Fonticons, Inc. -->
                                    <path fill="currentColor"
                                        d="M359.2 17c-17.1 4.6-27.2 22.1-22.6 39.2l12.4 46.4 123.6-33.1-12.4-46.4C455.7 6 438.1-4.1 421 .4L359.2 17zm125.9 98.8l-123.6 33.1 66.3 247.3 123.6-33.1-66.3-247.3zM452.5 488.9c4.6 17.1 22.1 27.2 39.2 22.6L553.6 495c17.1-4.6 27.2-22.1 22.6-39.2l-12.4-46.4-123.6 33.1 12.4 46.4zM32.4 32l0 48 128 0 0-48c0-17.7-14.3-32-32-32l-64 0c-17.7 0-32 14.3-32 32zm0 96l0 256 128 0 0-256-128 0zm0 304l0 48c0 17.7 14.3 32 32 32l64 0c17.7 0 32-14.3 32-32l0-48-128 0zm176-304l0 352c0 17.7 14.3 32 32 32l48 0c17.7 0 32-14.3 32-32l0-352c0-17.7-14.3-32-32-32l-48 0c-17.7 0-32 14.3-32 32z" />
                                </svg>
                                <span>livros reservados</span>
                            </a>
                            <a class="menu_item" href="#">
                                <svg xmlns="http://www.w3.org/2000/svg"
                                    viewBox="0 0 448 512"><!--! Font Awesome Pro 7.1.0 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license (Commercial License) Copyright 2025 Fonticons, Inc. -->
                                    <path fill="currentColor"
                                        d="M96 512l320 0c17.7 0 32-14.3 32-32s-14.3-32-32-32l0-66.7c18.6-6.6 32-24.4 32-45.3l0-288c0-26.5-21.5-48-48-48L96 0C43 0 0 43 0 96L0 416c0 53 43 96 96 96zM64 416c0-17.7 14.3-32 32-32l256 0 0 64-256 0c-17.7 0-32-14.3-32-32zM217.6 119.5l6.4 8.5 6.4-8.5c11.1-14.8 28.5-23.5 46.9-23.5 32.4 0 58.7 26.3 58.7 58.7l0 5.3c0 49.1-65.8 98.1-96.5 118.3-9.5 6.2-21.5 6.2-30.9 0-30.7-20.2-96.5-69.3-96.5-118.3l0-5.3c0-32.4 26.3-58.7 58.7-58.7 18.5 0 35.9 8.7 46.9 23.5z" />
                                </svg>
                                <span>favoritos</span>
                            </a>
                        </div>

                        <a href="#" class="menu_item">
                            <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 640 640"><!--!Font Awesome Free 7.2.0 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2026 Fonticons, Inc.--><path d="M64 128L288 128L288 137.8C288 176.8 264.3 211.8 228.1 226.2C167.6 250.4 128 308.9 128 374.1L128 447.9L64 447.9L64 127.9zM352 128L576 128L576 448L508.3 448L504.6 443.5L429.4 353.3C420.3 342.4 406.8 336 392.5 336L321.4 336L280.4 272.9C280.1 272.4 279.8 271.9 279.4 271.5C324.1 242.5 351.9 192.5 351.9 137.9L351.9 128.1zM425 448L398.4 448L441.1 512L592 512C618.5 512 640 490.5 640 464L640 112C640 85.5 618.5 64 592 64L48 64C21.5 64 0 85.5 0 112L0 464C0 490.5 21.5 512 48 512L308.2 512L341.4 561.8C351.2 576.5 371.1 580.5 385.8 570.7C400.5 560.9 404.5 541 394.7 526.3L310.5 400.1L385.1 400.1L425.1 448.1zM265.5 448L192 448L192 374.2C192 364 193.6 354.1 196.7 344.7L265.5 448zM192 192C192 165.5 170.5 144 144 144C117.5 144 96 165.5 96 192C96 218.5 117.5 240 144 240C170.5 240 192 218.5 192 192z"/></svg>
                            <span>Sair</span>
                        </a>
                    </nav>
                </div>
            </aside>
        `;

        this.iniciar();
    }

    iniciar() {
        this.menu = this.querySelector('.menu_lateral');
        this.seta = this.querySelector('#setaMenu');
        this.sombra = this.querySelector('.sombra');

        this.seta.addEventListener('click', () => this.AbrirFecharMenu());

        this.ajustarMenuResponsivo();
        window.addEventListener('resize', () => this.ajustarMenuResponsivo());

        this.ativarItemAtual();
    }

    AbrirFecharMenu() {
        this.menu.classList.toggle('menu_lateral_fechado');
        this.seta.classList.toggle('div_seta_mf');
        this.sombra.classList.toggle('movimento_sombra');
    }

    ajustarMenuResponsivo() {
        if (window.innerWidth <= 1024) {
            this.menu.classList.add('menu_lateral_fechado');
            this.seta.classList.add('div_seta_mf');
            this.sombra.classList.add('movimento_sombra');
        } else {
            this.menu.classList.remove('menu_lateral_fechado');
            this.seta.classList.remove('div_seta_mf');
            this.sombra.classList.remove('movimento_sombra');
        }
    }

    ativarItemAtual() {
        const url = window.location.pathname;

        const itens = this.querySelectorAll('.menu_item');

        itens.forEach(item => {
            const link = item.getAttribute('href');

            if (url.includes(link)) {
                item.classList.add('menu_item_ativo');
            }else{
                item.classList.remove('menu_item_ativo');
                
            }
        });
    }
}

customElements.define('menu-lateral', MenuLateral);