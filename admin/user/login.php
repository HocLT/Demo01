<?php
/**
 * Created by PhpStorm.
 * User: Quang
 * Date: 1/10/2016
 * Time: 7:31 PM
 */

// khoi dong session
session_start();

// kiem tra neu da dang nhap thi quay ve trang chu quan tri
if (isset($_SESSION['user'])) {
    header('location: ../home/home.php');
}

// require cac fil can thiet
require '../../configs/config.php';
require '../../libraries/connect.php';
require '../../models/user.php';

// kiem tra du lieu POST len
if (isset($_POST['username']) && !empty($_POST['username']) && isset($_POST['password']) && !empty($_POST['password'])) {
    // luu du lieu nhan duoc vao 2 bien tuong ung
    $username = $_POST['username'];
    $password = $_POST['password'];

    // lay thong tin thanh vien tu db
    $user = get_user_by_username($username);

    // kiem tra su ton tai cua thanh vien va mat khau co trung khop
    if ($user && $user['password'] === md5($password)) {
        // tao session luu thong tin user dang nhap thanh cong
        $_SESSION['user'] = $user;

        // chuyen huong ve trang quan tri
        header('location:../home/home.php');
    } else {
        // bat co loi
        $error = true;
    }
}

// required file giao dien (view)
require '../../views/admin/user/login.tpl.php';