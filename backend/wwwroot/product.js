const products = {
    hik1: {
        name: "HIKVISION HD Bullet 2.0MP AUDIO DS-2CE16D0T-ITPF",
        price: "₹1,413",
        desc: `
About this product:
• Model: DS-2CE16D0T-LPFS
• High-quality imaging with 2 MP (1920×1080)
• 2.8 mm / 3.6 mm fixed focal lens
• Up to 25 m IR night vision
• Water & dust resistant (IP67)`,
        img: "images/hik1.jpg"
    },

    hik2: {
        name: "HikVision DS-2CE5AC0T Dome Camera",
        price: "₹1,520",
        desc: `About this item
• Hikvision 720p 1 mp dome camera DS-2CE5ACOT-IRP eco 1 pc.
• 1.0 Megapixel high-performance CMOS
• Analog HD output, up to 720P resolution True Day/Night,DNR, Smart IR
• Up to 20m IR distance,3.6mm Lens Switchable TVI/AHD/CVI/CVBS`,
        img: "images/hik2.webp"
    },
    cp1: {
        name: "CP Plus EZ P21 Security Camera",
        price: "₹1,199",
        desc: "Two-way Audio • WiFi App",
        img: "images/cp1.webp"
    }
    // ➕ add remaining products
};

const params = new URLSearchParams(window.location.search);
const id = params.get("id");

if (products[id]) {
    document.getElementById("productName").innerText = products[id].name;
    document.getElementById("productPrice").innerText = products[id].price;
    document.getElementById("productDesc").innerText = products[id].desc;
    document.getElementById("productImage").src = products[id].img;
}

const buyButtons = document.querySelectorAll(".buy-btn");

buyButtons.forEach(btn => {
    btn.addEventListener("click", () => {
        if (!products[id]) {
            alert("Product not found");
            return;
        }

        const p = products[id];
        window.location.href =
            `./customer.html?name=${encodeURIComponent(p.name)}&price=${encodeURIComponent(p.price)}`;
    });
});


//document.addEventListener("DOMContentLoaded", () => {
//    const params = new URLSearchParams(window.location.search);
//    const id = params.get("id");

//    if (!id || !products[id]) {
//        alert("Product not found");
//        return;
//    }

//    const p = products[id];
//    document.getElementById("productName").innerText = p.name;
//    document.getElementById("productPrice").innerText = p.price;
//    document.getElementById("productDesc").innerText = p.desc;
//    document.getElementById("productImage").src = p.img;

//    const addToCartBtn = document.querySelector(".add-cart-btn");
//    const buyNowBtn = document.querySelector(".buy-now-btn");

//    addToCartBtn.addEventListener("click", () => {
//        window.location.href = "index.html"; // relative path
//    });

//    buyNowBtn.addEventListener("click", () => {
//        window.location.href =
//            `customer.html?name=${encodeURIComponent(p.name)}&price=${encodeURIComponent(p.price)}`;
//    });
//});



//document.addEventListener("DOMContentLoaded", () => {

//    // Get product id from URL
//    const params = new URLSearchParams(window.location.search);
//    const id = params.get("id");

//    if (!id || !products[id]) {
//        alert("Product not found!");
//        return;
//    }

//    const p = products[id];

//    // Fill product details
//    document.getElementById("productName").innerText = p.name;
//    document.getElementById("productPrice").innerText = p.price;
//    document.getElementById("productDesc").innerText = p.desc;
//    document.getElementById("productImage").src = p.img;

//    // Buttons
//    const addToCartBtn = document.querySelector(".add-cart-btn");
//    const buyNowBtn = document.querySelector(".buy-now-btn");

//    addToCartBtn.addEventListener("click", () => {
//        // Redirect to index.html (relative path)
//        window.location.href = "index.html";
//    });

//    buyNowBtn.addEventListener("click", () => {
//        // Redirect to customer page with product info
//        window.location.href =
//            `customer.html?name=${encodeURIComponent(p.name)}&price=${encodeURIComponent(p.price)}`;
//    });





