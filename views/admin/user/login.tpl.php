/**
 * Created by PhpStorm.
 * User: Quang
 * Date: 1/10/2016
 * Time: 7:46 PM
 */

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Quản trị - Đăng nhập</title>
</head>
<body>

<form name="login" method="POST" action="">
<?php if(isset($error) && $error == true): ?>
    <p style="color:red;">Sai Tài khoản hoặc Mật khẩu!</p>
<?php endif; ?>

<p>
    <label>Tài khoản:</label>
    <input type="text" name="username" value="" />
</p>
<p>
    <label>Mật khẩu:</label>
    <input type="password" name="password" value="" />
</p>
<p>
    <input type="submit" value="Đăng nhập" />
</p>
</form>

</body>
</html>