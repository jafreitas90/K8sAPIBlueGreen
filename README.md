# Blue-Green Deployments in Kubernetes Using Minikube

Create and test a simple Blue-Green Deployment C# API to a local Kubernetes cluster using Minikube.

## Prerequisites

Minikube installed and running
Docker installed
Kubectl installed
.NET SDK installed

### Project Structure

```c#
LocalCSharpK8sAPI/                    # Root directory of the project
├── IaC/                              # Infrastructure as Code (IaC)
│   ├── blue-deployment.yaml          # Blue Deployment manifest
│   ├── green-deployment.yaml          # Green Deployment manifest
│   ├── service.yaml                  # Service to expose the app
├── src/                              # Source code folder
│   ├── K8sTimeService.sln            # C# Solution
|   ├── K8sTimeService.API
│   │   ├── Dockerfile                # Dockerfile to containerize the C# v1 App
|   ├── K8sTimeService.v2.API
│   │   ├── Dockerfile                # Dockerfile to containerize the C# v2 App API
│   │   ├── ...                       # Other necessary files for the C# project (e.g., Startup.cs, Properties, etc.)
└── README.md                         # Documentation

```

More details <a href="https://readme.com/" target="_blank">here</a>
