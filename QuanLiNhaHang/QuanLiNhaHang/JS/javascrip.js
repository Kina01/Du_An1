//Lay ra nut dang nhap
var btnLogin = document.getElementById('btnLogout');
var container_container_login = document.querySelector('.container_container_login');
var logonForm = document.querySelector('.logonForm');

btnLogin.addEventListener('click', function () {
    container_container_login.style.display = "flex";
    logonForm.style.animation = 'show_FormLogin ease 1s';
})
//bắt sự kiện click vào thẻ cha của form
container_container_login.addEventListener('click', function () {
    logonForm.style.animation = 'hide_FormLogin ease 1s';
    setTimeout(function () {
        container_container_login.style.display = 'none';
    }, 600);
})

//ngăn chặn sự kiện click của thẻ con bị đổ ra ngoài
logonForm.addEventListener('click', function (e) {
    e.stopPropagation();
})

document.getElementById('btnSubmitLogin').addEventListener('click', function (e) {
    e.preventDefault();
})

document.getElementById('btnLogin').addEventListener('click', function (e) {
    e.preventDefault();
})