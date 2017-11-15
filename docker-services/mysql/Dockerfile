FROM mysql/mysql-server

ENV MYSQL_ROOT_PASSWORD=root
ENV MYSQL_ALLOW_EMPTY_PASSWORD=true
ENV DATABASE=lidarrupdate

COPY files/setup.sql /docker-entrypoint-initdb.d/setup.sql

## Replace placeholders with ENV vars
RUN sed -i 's/${DATABASE}/'${DATABASE}'/' /docker-entrypoint-initdb.d/setup.sql
RUN sed -i 's/${MYSQL_ROOT_PASSWORD}/'${MYSQL_ROOT_PASSWORD}'/' /docker-entrypoint-initdb.d/setup.sql