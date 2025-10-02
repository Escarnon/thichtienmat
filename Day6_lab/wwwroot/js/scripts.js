/* ==========================
   File: scripts.js
   Mục đích: JS custom cho giao diện
   ========================== */

document.addEventListener("DOMContentLoaded", function () {
    console.log("✅ scripts.js đã được load thành công!");

    // Ví dụ: Toggle menu sidebar
    const sidebarToggle = document.getElementById("sidebarToggle");
    if (sidebarToggle) {
        sidebarToggle.addEventListener("click", function (e) {
            e.preventDefault();
            document.body.classList.toggle("sb-sidenav-toggled");
        });
    }
});
