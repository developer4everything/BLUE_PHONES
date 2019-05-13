# build environment
FROM node:9.6.1 as builder
RUN mkdir /usr/src/app
WORKDIR /usr/src/app
ENV PATH /usr/src/app/node_modules/.bin:$PATH
COPY /src/Web/webreact/package.json /usr/src/app/package.json
COPY /src/Web/webreact/tsconfig.json /usr/src/app/tsconfig.json
RUN npm install --silent
RUN npm install react-scripts@3.0.1 -g --silent
COPY /src/Web/webreact /usr/src/app
RUN npm run build

# production environment
FROM nginx:1.15.2-alpine
RUN rm -rf /etc/nginx/conf.d
COPY /src/Web/webreact/conf /etc/nginx
COPY --from=builder /usr/src/app/build /usr/share/nginx/html
EXPOSE 3000
CMD ["nginx", "-g", "daemon off;"]