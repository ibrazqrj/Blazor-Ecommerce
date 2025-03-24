# 🛒 Blazor Ecommerce

A **modern eCommerce platform** built using **Blazor WebAssembly**. This project allows users to browse products, add items to the cart, and complete purchases. The frontend is developed using **Blazor WebAssembly**, while the backend is powered by **.NET Core API** with **Entity Framework** for data management.

---

## 🚀 Current Status

- **Blazor WebAssembly (WASM) Frontend** with dynamic UI components.
- **RESTful API Backend** built with **.NET Core**.
- **Entity Framework Core** used for database interaction.
- **Authentication with Azure AD (MSAL)**.
- **Shopping cart functionality** with session management.
- **Product catalog with filtering and sorting options**.
- **Secure checkout process** with payment integration planned.
- **Multi-language support** with localization.

---

## ✅ Features

- **🛍️ Browse Products** (retrieved from the API)
- **➕ Add Products to Cart**
- **🛒 View and Update Cart**
- **🔍 Search & Filter Products**
- **📊 Sort Products by Price, Name, and Category**
- **🔑 Authentication with Microsoft Login (MSAL)**
- **🌍 Multi-language support** (Localization using .resx files)
- **📦 Order Management** (Planned for future updates)
- **💳 Payment Integration** (Planned for future updates)

---

## 🔧 Tech Stack

### 🌍 Frontend
- **Blazor WebAssembly (.NET 9)**
- **MudBlazor** (UI components)
- **Syncfusion Blazor** (Advanced UI components)
- **Microsoft Authentication Library (MSAL)** for OAuth 2.0 login
- **HttpClient** for API communication
- **Bootstrap & CSS for styling**

### 🖥️ Backend
- **.NET Core Web API (C#)**
- **Entity Framework Core** for database interactions
- **Microsoft SQL Server**
- **Azure Active Directory (AD) for authentication**

### 🔗 Networking & Tools
- **Swagger** for API documentation
- **Azure Portal & Azure DevOps** for deployment
- **Postman** for API testing

---

## 🌐 API Endpoints

| Method | Endpoint               | Description                    |
|--------|------------------------|--------------------------------|
| GET    | `/api/products`        | Retrieve all products         |
| GET    | `/api/products/{id}`   | Retrieve a specific product   |
| POST   | `/api/cart`            | Add a product to the cart     |
| GET    | `/api/cart`            | Retrieve current cart items   |
| DELETE | `/api/cart/{id}`       | Remove a product from the cart |
| POST   | `/api/order`           | Place an order                |

---

## 📌 Installation & Usage

### 🚀 Requirements
- **.NET 7 SDK** installed ([Download here](https://dotnet.microsoft.com/en-us/download/dotnet/7.0))
- **Visual Studio 2022** or another .NET-supported IDE
- **A registered Azure AD account** for MSAL login
- **Microsoft SQL Server** for database management

### 📥 **Clone & Start the Project**
```sh
# Clone the repository
git clone https://github.com/ibrazqrj/Blazor-Ecommerce.git
cd Blazor-Ecommerce
```

### 🖥️ **Start the Backend**
```sh
cd BlazorEcommerce.API
# Start the API
dotnet run
```
➡ **API running at:** `http://localhost:5000`

### 🌍 **Start the Frontend**
```sh
cd BlazorEcommerce.Client
# Install dependencies
npm install
# Start Blazor
dotnet run
```
➡ **Web app running at:** `https://localhost:7000`

---

## 👥 Contributors

- **Ibrahim Zeqiraj** - Development  
[GitHub](https://github.com/ibrazqrj)

---

