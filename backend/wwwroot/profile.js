function enableEdit(id) {
    const input = document.getElementById(id);
    input.disabled = false;
    input.focus();
}

/* Eye toggle */
function togglePassword() {
    const pwd = document.getElementById("password");
    const eye = document.getElementById("eyeIcon");

    if (pwd.type === "password") {
        pwd.type = "text";
        eye.classList.remove("fa-eye");
        eye.classList.add("fa-eye-slash");
    } else {
        pwd.type = "password";
        eye.classList.remove("fa-eye-slash");
        eye.classList.add("fa-eye");
    }
}

async function saveProfile() {
    const data = {
        username: document.getElementById("username").value,
        email: document.getElementById("email").value
    };

    const res = await fetch("http://localhost:5271/api/profile/update", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        credentials: "include",   // 🔥 REQUIRED
        body: JSON.stringify(data)
    });

    const msg = await res.text();

    if (!res.ok) {
        alert(msg || "Update failed");
        return;
    }

    alert(msg);
}



document.addEventListener("DOMContentLoaded", loadProfile);

//async function loadProfile() {
//    const res = await fetch('/api/profile/me');

//    if (!res.ok) {
//        alert("Session expired. Please login again.");
//        window.location.href = "index.html";
//        return;
//    }

//    const user = await res.json();

//    document.getElementById("username").value = user.username;
//    document.getElementById("email").value = user.email;
//}

//loadProfile();

async function loadProfile() {
    const res = await fetch('/api/profile/me', {
        credentials: 'include' // 🔥 REQUIRED
    });

    if (!res.ok) {
        alert("Session expired. Please login again.");
        window.location.href = "index.html";
        return;
    }

    const user = await res.json();
    document.getElementById("username").value = user.username;
    document.getElementById("email").value = user.email;


    function openCart() {
        window.location.href = "cart.html";
    }
}


