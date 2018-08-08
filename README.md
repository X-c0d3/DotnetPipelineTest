Nginx

upstream coreapp {
    server localhost:5000;
    server localhost:5001;
    server localhost:5002;
}
server {
    listen 80;
 
        location / {
            proxy_pass http://coreapp;
        }
}

Jenkins Shell Commands

cd DotnetPipelineTest.Tests && dotnet test
cd ../DotnetPipelineTest.Web/
docker-compose down
docker build -t dotnetpipeline .
docker-compose up -d