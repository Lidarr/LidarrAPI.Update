FROM mysql/mysql-server

ENV MYSQL_ROOT_PASSWORD=${MYSQL_ROOT_PASSWORD}
ENV MYSQL_ALLOW_EMPTY_PASSWORD=true

COPY files/setup.sql /docker-entrypoint-initdb.d/setup.sql