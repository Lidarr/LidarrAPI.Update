CREATE DATABASE lidarrapi;

CREATE USER 'root'@'lidarrupdate' IDENTIFIED BY '${MYSQL_ROOT_PASSWORD}';
GRANT ALL PRIVILEGES ON lidarrapi.* to 'root'@'lidarrupdate';
