FROM node:11.6.0-alpine AS builder
COPY . ./reminiscence-app
WORKDIR /reminiscence-app
RUN npm i
RUN $(npm bin)/ng build --prod

FROM nginx:1.15.8-alpine
COPY --from=builder /reminiscence-app/dist/reminiscence-app/ /usr/share/nginx/html