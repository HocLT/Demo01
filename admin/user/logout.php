<?php
/**
 * Created by PhpStorm.
 * User: Quang
 * Date: 1/10/2016
 * Time: 7:46 PM
 */
// khoi dong session
session_start();

// huy toan bo session
session_destroy();

// quay ve trang dang nhap
header('location:login.php');