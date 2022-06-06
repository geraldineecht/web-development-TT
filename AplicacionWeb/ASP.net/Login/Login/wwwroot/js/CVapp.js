const menu = document.querySelector('#mobile-menu');
const menuLinks = document.querySelector('.nav-menu');
const navBar = document.querySelector('.nav-container');
const navButton = document.querySelector('.nav-button');

const navBackground = document.querySelector('.header-container');


const mobileMenu = () => {
    menu.classList.toggle('is-active');
    menuLinks.classList.toggle('active');
    navBar.classList.toggle('active');
    navButton.classList.toggle('active');

    navBackground.classList.toggle('active');
}

menu.addEventListener('click', mobileMenu);



/* ---------- CLOSE MOBILE MENU ---------- */
const hideMobileMenu = () => {
    const menuBars = document.querySelector('.is-active');
    if (window.innerWidth <= 768 && menuBars) {
        menu.classList.toggle('is-active');
        menuLinks.classList.remove('active');
    }
};

menuLinks.addEventListener('click', hideMobileMenu);