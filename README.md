# Deploying a Local C# API to Kubernetes with Minikube and Docker

Deploy a simple C# API to a local Kubernetes cluster using Minikube.

This repository contains a basic example of deploy our own ASP.NET Core API with a locally built Docker image, without uploading it to a container registry.

## Prerequisites

Minikube installed and running
Docker installed
Kubectl installed
.NET SDK installed

### Project Structure

```c#
LocalCSharpK8sAPI/                    # Root directory of the project
├── IaC/                              # Infrastructure as Code (IaC) folder
│   ├── deployment.yaml               # Deployment manifest
│   ├── service.yaml                  # Service to expose the app
├── src/                              # Source code folder
│   ├── K8sTimeService.sln            # C# Solution
|   ├── K8sTimeService.API
│   │   ├── Dockerfile                # Dockerfile to containerize the C# API
│   │   ├── K8sTimeService.csproj     # Project file for the C# API
│   │   ├── ...                       # Other necessary files for the C# project (e.g., Startup.cs, Properties, etc.)
└── README.md                         # Documentation

```

More details <a href="https://readme.com/" target="_blank">here</a>
