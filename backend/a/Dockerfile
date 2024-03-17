FROM nginx:1.10.1-alpine

# WORKDIR /html

COPY html /usr/share/nginx/html

COPY nginx.conf /etc/nginx/nginx.conf

# expose by default
#  EXPOSE 8080
# call by default
# CMD ["nginx", "-g", "daemon off;"]