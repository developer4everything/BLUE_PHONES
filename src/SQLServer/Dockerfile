FROM mcr.microsoft.com/mssql/server:2017-latest-ubuntu

COPY ./src/SQLServer/create_database.sql .
COPY ./src/SQLServer/start.sh .
COPY ./src/SQLServer/entrypoint.sh .

ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=bL5ipH0n3sDb
ENV MSSQL_PID=Express

RUN chmod +x ./start.sh
CMD /bin/bash ./entrypoint.sh
