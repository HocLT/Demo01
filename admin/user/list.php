<?php
/**
 * Created by PhpStorm.
 * User: Quang
 * Date: 1/10/2016
 * Time: 9:09 PM
 */

// khoi dong session
session_start();

// kiem tra neu chua dang nhap thi quay ve trang dang nhap
if (!isset($_SESSION['user'])) {
    header('location:login.php');
}

// require cac file can thiet
require '../../configs/config.php';
require '../../libiraries/connect.php';
require '../../models/user.php';

$user_list = get_user_list();

// require file giao dien
require '../../views/admin/user/list.tpl.php';
