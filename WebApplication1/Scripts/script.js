var images = document.querySelectorAll('.product-images img');
var currentIndex = 0;

// Afișează prima imagine la încărcarea paginii
images[currentIndex].style.display = 'block';

// Funcție pentru a schimba imaginea la fiecare 5 secunde
function changeImage() {
    images[currentIndex].style.display = 'none';
    currentIndex = (currentIndex + 1) % images.length;
    images[currentIndex].style.display = 'block';
}

// Setează intervalul pentru a schimba imaginea la fiecare 4 secunde
setInterval(changeImage, 4000);

document.addEventListener("DOMContentLoaded", function() {
    const sidebarToggle = document.querySelector('.sidebar-toggle');
    const sidebarClose = document.querySelector('.sidebar-close');
    const sidebar = document.querySelector('.sidebar');

    sidebarToggle.addEventListener('click', function() {
        sidebar.style.left = '0';
    });

    sidebarClose.addEventListener('click', function() {
        sidebar.style.left = '-300px';
    });
});

