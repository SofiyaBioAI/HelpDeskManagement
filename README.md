<div align="center">

# 🎫 HelpDesk Management System

### A Full-Stack HelpDesk Ticket Management System built with ASP.NET Core MVC, ASP.NET Core Web API, SQL Server & Entity Framework Core.

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-.NET-purple?style=for-the-badge)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-red?style=for-the-badge)
![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework-Core-success?style=for-the-badge)

</div>

---

# 📖 About the Project

The **HelpDesk Management System** is a full-stack web application developed using **ASP.NET Core MVC**, **ASP.NET Core Web API**, **SQL Server**, and **Entity Framework Core**.

The application enables users to create, manage, update, and monitor support tickets efficiently through an intuitive user interface. The project follows a layered architecture by separating the presentation layer (MVC), business logic (API), and testing module, ensuring scalability and maintainability.

---

# ✨ Features

- 🎫 Raise New Support Tickets
- 📋 View All Tickets
- 🔍 View Ticket Details
- ✏️ Edit Existing Tickets
- 🗑 Delete Tickets
- 📊 Dashboard with Ticket Statistics
  - Total Tickets
  - Open Tickets
  - Closed Tickets
- 🔎 Filter Tickets by Status
- 🌐 RESTful Web API
- 💾 SQL Server Database Integration
- ✅ Unit Testing

---

# 🛠️ Tech Stack

| Category | Technologies |
|-----------|--------------|
| Frontend | ASP.NET Core MVC, Bootstrap 5 |
| Backend | ASP.NET Core Web API |
| Language | C# |
| Database | SQL Server |
| ORM | Entity Framework Core |
| Testing | xUnit |
| Version Control | Git & GitHub |

---

# 📂 Project Structure

```text
HelpDeskManagement
│
├── HelpDesk.Api
│   ├── Controllers
│   ├── Models
│   ├── Repositories
│   ├── Data
│   └── Program.cs
│
├── HelpDesk.Mvc
│   ├── Controllers
│   ├── Models
│   ├── Services
│   ├── ViewModels
│   ├── Views
│   └── wwwroot
│
├── HelpDesk.Tests
│
└── HelpDeskManagement.slnx
```

---

# 📸 Application Screenshots

## 🏠 Dashboard


<p align="center">
<img width="1919" height="967" alt="Dashboard" src="https://github.com/user-attachments/assets/65288a0d-5bf6-4f90-9aad-d89ba8f1060b" />
</p>

---

## 📋 All Tickets


<p align="center">
<img width="1919" height="965" alt="AllTickets" src="https://github.com/user-attachments/assets/dda00719-9cec-4d38-b1db-0dcceb2831c2" />
</p>

---

## ➕ Raise New Ticket


<p align="center">
<img width="1918" height="968" alt="CreateTicket" src="https://github.com/user-attachments/assets/1bedb6d8-11b6-45af-b0d0-6d8cf8581e25" />
</p>

---

## 🔍 Ticket Details


<p align="center">
<img width="1919" height="966" alt="TicketDetails" src="https://github.com/user-attachments/assets/412bc02d-0a75-4896-ae7f-b1781971507d" />
</p>

---

## ✏️ Edit Ticket


<p align="center">
<img width="1919" height="967" alt="EditTicket" src="https://github.com/user-attachments/assets/82c951a9-4cbb-43a6-8531-201e9b6f5009" />
</p>

---

## 🗑 Delete Ticket


<p align="center">
<img width="1919" height="916" alt="DeleteTicket" src="https://github.com/user-attachments/assets/c247f118-50ed-4f53-b67c-e295427c1e47" />
</p>
---

# 📊 Dashboard Overview

The dashboard provides a quick summary of the helpdesk system by displaying:

- 📌 Total Tickets
- 🟢 Open Tickets
- 🔴 Closed Tickets

This allows users to monitor the overall status of support requests at a glance.

---

# 🌐 REST API Endpoints

| Method | Endpoint | Description |
|---------|----------|-------------|
| GET | `/api/Ticket` | Get all tickets |
| GET | `/api/Ticket/{id}` | Get ticket by ID |
| POST | `/api/Ticket` | Create a new ticket |
| PUT | `/api/Ticket/{id}` | Update an existing ticket |
| DELETE | `/api/Ticket/{id}` | Delete a ticket |
| GET | `/api/Ticket/Status/{status}` | Filter tickets by status |

---

# ⚙️ Getting Started

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/SofiyaBioAI/HelpDeskManagement.git
```

### 2️⃣ Open the Solution

Open the project in **Visual Studio**.

### 3️⃣ Restore NuGet Packages

Restore all required packages.

### 4️⃣ Configure Database

Update the SQL Server connection string in:

```text
appsettings.json
```

### 5️⃣ Run the Projects

- Start **HelpDesk.Api**
- Start **HelpDesk.Mvc**

The MVC application communicates with the Web API to perform all ticket operations.

---

# 🧪 Testing

The project includes unit tests to validate the application's functionality.

Run the tests using:

```bash
dotnet test
```

✔ All implemented test cases pass successfully.

---

# 🚀 Future Enhancements

- 🔐 User Authentication & Authorization
- 📧 Email Notifications
- 👨‍💼 Admin Dashboard
- 📎 File Attachments
- 🔍 Search & Sorting
- 📄 Pagination
- 📈 Reports & Analytics
- 📱 Enhanced Responsive UI

---

# 👩‍💻 Developer

### **Sofiya Chavarekar**

**B.Tech Bioengineering (Bioinformatics)**  
**VIT Bhopal University**

📧 **Email:** sofiyachavarekar@gmail.com

🔗 **GitHub:** https://github.com/SofiyaBioAI

---

## 📄 License

This project was developed for educational and academic purposes.
