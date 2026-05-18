# PRG282_Project - Student Management System

## 📋 Project Overview

PRG282_Project is a comprehensive **Student Management System** application developed in C# as part of the PRG282 course. This Windows Forms desktop application provides institutions with tools to manage student records, enrollment data, and generate reports efficiently.

### 🎯 Key Features

- **Student Records Management**: Create, read, update, and delete student information
- **Enrollment Tracking**: Monitor student enrollment status and academic progress
- **PDF Report Generation**: Generate professional PDF reports from student data
- **User-Friendly Interface**: Modern UI built with Guna UI2.WinForms framework
- **Data Management**: Efficient handling of student information using .NET Framework

## 🛠️ Technology Stack

- **Language**: C#
- **Framework**: .NET Framework 4.8
- **UI Framework**: Guna.UI2.WinForms
- **Report Generation**: HtmlRenderer & PdfSharp
- **Type**: Windows Forms Desktop Application

---

> [!TIP]
> ## Installation
> **1. Clone this Repository**
>   Clone this repository to your local machine:
> ```
> git clone https://github.com/aceoroal/PRG282_Project.git
> ```

## Running the Application
### 1. Install Required Packages
> [!NOTE]
> In Visual Studio, follow these steps to set up the necessary package:

> - Click on the **Project** tab at the top menu.

> - Select **Manage NuGet Packages...**

> - In the NuGet Package Manager, click on the **Browse** tab.

> - Search for `Guna.UI2.WinForms`. If `Guna.UI2.WinForms` is already installed, uninstall it and then install the latest version or version `2.0.4.6` to ensure compatibility.
> - Search for `HtmlRenderer`. If `HtmlRenderer` is already installed, uninstall it and then install it again, install version `1.5.0.5` to ensure compatibility.
> - Search for `HtmlRenderer.PdfSharp`. If `HtmlRenderer.PdfSharp` is already installed, uninstall it and then install it again, install version `1.5.0.6` to ensure compatibility.
> - Search for `PdfSharp`. If `PdfSharp` is already installed, uninstall it and then install it again, install version `1.32.3057.0` to ensure compatibility.

### 2. Run the Application
After installing the package, you can run the application by pressing **F5** or clicking **Start** in Visual Studio.
> [!IMPORTANT]
> **Dependencies**
>> - .NET Framework (4.8)
>> - Guna.UI2.WinForms (for UI components)
>> - HtmlRenderer.PdfSharp (This library provides the ability to generate PDF documents from HTML snippets using static rendering code.
For more info see HTML Renderer on CodePlex: [http://htmlrenderer.codeplex.com](http://htmlrenderer.codeplex.com))
