# .NET AWS Lambda Demo

This repository contains different samples of ways to deploy to AWS Lambda using .NET.

You can deploy/invoke these lambdas using [Amazon.Lambda.Tools](https://github.com/aws/aws-extensions-for-dotnet-cli).

To install Amazon.Lambda.Tools:
```
dotnet tool install -g Amazon.Lambda.Tools
```

## Deploying
If you are authenticated with the AWS CLI, then from a project directory run:
```
dotnet lambda deploy-function
```

## Invoking
```
dotnet lambda invoke-function -p "hello, world!"
```