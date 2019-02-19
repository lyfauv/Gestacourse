create database if not exists gestacourse character set utf8 collate utf8_unicode_ci;
use gestacourse;

grant all privileges on gestacourse.* to 'user'@'localhost' identified by 'secret';