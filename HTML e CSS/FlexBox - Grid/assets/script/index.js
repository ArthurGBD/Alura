const botaMenu = document.querySelector('.cabecalho__menu');
const menu = document.querySelector('.menu-lateral');

botaMenu.addEventListener('click', () => {
    menu.classList.toggle('menu-lateral--ativo')
})
