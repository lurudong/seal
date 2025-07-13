# Seal

## .net core framework

![logo](images/logo_128x128_transparent.png)

Seal是一个用于处理结果和错误处理的.NET Core框架。它提供了一种简单而强大的方式来处理应用程序中的成功和失败结果。



## 功能

- 处理成功和失败结果
- 提供错误处理机制
- 简化代码编写

## 安装

使用NuGet包管理器安装Seal：

　　　

```NuGet
Install-Package Seal
```




## 使用方法

在项目中使用Seal非常简单。首先，你需要创建一个结果对象，然后根据结果的状态执行相应的操作。

```csharp
var result = Result<int>.Success(1);
if (result.IsSuccess)
{
    // 处理成功结果
}
else
{
    // 处理失败结果
}

```