<html>
    <head>
        <meta http-equiv="CONTENT-TYPE" content="text/html; charset=utf-8"/>
        <title>Quan tri - Thanh vien - Danh sach</title>
    </head>

    <body>
        <table width="100%" cellpadding="10">
            <tr>
                <th>ID</th>
                <th>Tài khoản</th>
                <th>Họ tên</th>
                <th>Trạng thái</th>
                <th>Ngày tạo</th>
                <th>Ngày chỉnh sửa</th>
                <th>Tác vụ</th>
            </tr>
            <?php while ($user = mysql_fetch_assoc($user_list)): ?>
            <tr>
                <td><?php echo $user['user_id']; ?></td>
                <td><a href="<?php echo SITE_URL .'admin/user/edit.php?user_id='.$user['user_id']; ?>"><?php echo $user['username']; ?></a></td>
                <td><?php echo ($user['status'] == 1) ? 'Kích hoạt' : 'Không kích hoạt'; ?></td>
                <td><?php echo date('d-m-Y H:i:s', $user['created']); ?></td>
                <td><?php echo date('d-m-Y H:i:s', $user['modified']); ?></td>
                <td><a href="<?php echo SITE_URL.'admin/user/delete.php?user_id='.$user['user_id']; ?>">Xóa</a></td>
            </tr>
            <?php endwhile; ?>
        </table>
    </body>
</html>