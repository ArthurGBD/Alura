const botaMenu = document.querySelector('.cabecalho__menu');
const menu = document.querySelector('.menu-lateral');

botaMenu.addEventListener('click', () => {
    menu.classList.toggle('menu-lateral--ativo')
})

function esconderMenu() {
    if (menu.style.display == 'none') {
        menu.style.display = 'block';
    } else {
        menu.style.display = 'none';
    }
}