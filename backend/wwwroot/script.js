// ===============================
// PROFILE DROPDOWN MENU
// ===============================

//function toggleProfileMenu() {
//    const menu = document.getElementById("profileMenu");
//    menu.style.display = menu.style.display === "flex" ? "none" : "flex";
//}

//// Close menu when clicking outside
//document.addEventListener("click", function (e) {
//    const container = document.querySelector(".profile-container");
//    if (!container.contains(e.target)) {
//        document.getElementById("profileMenu").style.display = "none";
//    }
//});

//function logoutUser() {
//    alert("Logged out!");
//    window.location.href = "login.html";
//}

// ===== SEARCH =====
const searchIcon = document.getElementById('search-icon');
const searchBar = document.getElementById('search-bar');

if (searchIcon && searchBar) {
    searchIcon.addEventListener('click', () => {
        searchBar.classList.toggle('active');
        searchBar.focus();
    });
}

// ===== GALLERY (HOME ONLY) =====
const gallery = document.getElementById('image-gallery');
const imgs = document.querySelectorAll('.gallery-img');

if (gallery && imgs.length) {
    gallery.addEventListener('mousemove', (e) => {
        const rect = gallery.getBoundingClientRect();
        const x = e.clientX - rect.left;
        const index = Math.floor((x / gallery.offsetWidth) * imgs.length);
        imgs.forEach((img, i) => img.classList.toggle('active', i === index));
    });

    gallery.addEventListener('mouseleave', () => {
        imgs.forEach((img, i) => img.classList.toggle('active', i === 0));
    });
}

// ===== CATEGORY HIGHLIGHT =====
document.querySelectorAll('.category-card').forEach(card => {
    card.addEventListener('click', () => {
        document.querySelectorAll('.category-card')
            .forEach(c => c.classList.remove('active'));
        card.classList.add('active');
    });
});


//userid prom login of winforms//

const params = new URLSearchParams(window.location.search);
const userId = params.get("userId");

//if (!userId) {
//    alert("Please login again");
//}

//fetch(`/api/profile/${userId}`)
//    .then(res => res.json())
//    .then(data => {
//        document.getElementById("username").value = data.username;
//        document.getElementById("email").value = data.email;
//    });

fetch('/api/profile/me')
    .then(res => {
        if (!res.ok) {
            window.location.href = "/login";
            return;
        }
        return res.json();
    })
    .then(data => {
        document.getElementById("username").value = data.username;
        document.getElementById("email").value = data.email;
    });



async function checkLogin() {
    const res = await fetch('/api/auth/me');
    const userId = await res.json();

    if (userId) {
        document.getElementById("welcome").innerText = "Welcome!";
        document.getElementById("profileMenu").style.display = "block";
    } else {
        document.getElementById("profileMenu").style.display = "none";
    }
}

checkLogin();

//profile dropdown//
const profileBtn = document.getElementById('profile-btn');
const profileDropdown = document.getElementById('profile-dropdown');

if (profileBtn && profileDropdown) {
    profileBtn.addEventListener('click', (e) => {
        e.stopPropagation();
        profileDropdown.classList.toggle('active');
    });

    document.addEventListener('click', (e) => {
        if (!e.target.closest('.profile-wrapper')) {
            profileDropdown.classList.remove('active');
        }
    });


   
}


// ===== CART BADGE UPDATE (GLOBAL) =====

async function updateCartBadge() {
    try {
        const res = await fetch("/api/cart/mycart", {
            credentials: "include"
        });

        if (!res.ok) return;

        const data = await res.json();

        let totalQty = 0;

        data.forEach(item => {
            totalQty += item.quantity;
        });

        const badge = document.getElementById("cart-count");

        if (badge) {
            badge.innerText = totalQty;
            badge.style.display = totalQty > 0 ? "flex" : "none";
        }

    } catch (err) {
        console.error("Cart badge error", err);
    }
}

// Run on every page load
document.addEventListener("DOMContentLoaded", () => {
    updateCartBadge();
});

// open cart page
function openCart() {
    window.location.href = "cart.html";
}

