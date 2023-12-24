<script>
    $(document).ready(function () {
        // Đảm bảo menu được ẩn ban đầu
        $(".submenu").hide();

    // Xử lý sự kiện hover
    $("#menuThanhToan").hover(
            function () {
        // Khi trỏ chuột vào
        $(".submenu").slideDown('fast');
    },
            function () {
        // Khi rời chuột đi
        $(".submenu").slideUp('fast');
    }
);
});
</script>