<?php
/**
 * Created by PhpStorm.
 * User: Quang
 * Date: 1/10/2016
 * Time: 7:16 PM
 */
// ket noi
$connect = mysql_pconnect(DB_SERVER, DB_USERNAME, DB_PASSWORD) or die('Not Connected Database');
$db = mysql_select_db(DB_DATABASE, $connect) or die('Not Selected DB!');

// y/c luu tru theo utf-8
mysql_query('SET NAMES UTF8', $connect);