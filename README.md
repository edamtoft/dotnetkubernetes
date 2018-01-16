# ASP.NET Core on Kubernetes Sample App

This is a minimal "hello world" app for demonstrating deployment of a containerized .NET core app.

To run the deployed version of the app via docker, run

```
docker run -p "8080:80" edamtoft/dockersample:latest
```

or to build from source

```
docker build -t sampleapp .
```

To deploy via kubernetes:
```
kubectl create -f deployment.yml
kubectl create -f service.yml
```