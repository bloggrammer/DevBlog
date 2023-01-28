FROM nginx:alpine-slim

ARG HTML_FOLDER
ARG NGINX_CONFIG

COPY ${HTML_FOLDER} /usr/share/nginx/html
COPY ${NGINX_CONFIG} /etc/nginx/nginx.conf

# EXPOSE 80
# CMD ["nginx", "-g", "daemon off;"]