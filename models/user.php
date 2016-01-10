<?php
/**
 * Created by PhpStorm.
 * User: Quang
 * Date: 1/10/2016
 * Time: 7:42 PM
 */
function get_user_by_username($username) {
    // SQL
    $sql = "SELECT * FROM tbl_user WHERE username = '$username' AND status = 1";

    // query
    $query = mysql_query($sql);

    // fetch va return
    return mysql_fetch_assoc($query);
}

function get_user_list() {
    // SQL
    $sql = "SELECT * FROM tbl_user ORDER BY user_id DESC";

    // Query and return
    return mysql_query($sql);
}