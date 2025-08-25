# 👥 Employee Management System

A modern, secure employee management web application built with ASP.NET Core 2.2, featuring user authentication, role-based authorization, and comprehensive employee data management.

[![.NET Core](https://img.shields.io/badge/.NET%20Core-2.2-blue.svg)](https://dotnet.microsoft.com/download/dotnet/2.2)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-2.2-green.svg)](https://docs.microsoft.com/en-us/aspnet/core/)
[![Entity Framework](https://img.shields.io/badge/Entity%20Framework-2.2.4-orange.svg)](https://docs.microsoft.com/en-us/ef/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-LocalDB-lightgrey.svg)](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## ✨ Features

### 🔐 Authentication & Authorization
- **User Registration & Login**: Secure user account management with ASP.NET Core Identity
- **Role-Based Access Control**: Create and manage user roles for different access levels
- **Email Validation**: Custom email domain validation with regex patterns
- **Session Management**: Persistent login sessions with remember me functionality

### 👤 Employee Management
- **CRUD Operations**: Complete Create, Read, Update, Delete functionality for employees
- **Department Management**: Organize employees by departments (HR, Payroll, IT)
- **Photo Upload**: Profile picture management with file upload capabilities
- **Data Validation**: Comprehensive input validation with custom attributes

### 🎨 User Interface
- **Responsive Design**: Bootstrap-based responsive web interface
- **Modern UI**: Clean, professional design with intuitive navigation
- **Photo Display**: Employee profile pictures with fallback to default images
- **Form Validation**: Client-side and server-side validation with user-friendly error messages

### 🛠 Technical Features
- **Repository Pattern**: Clean separation of concerns with repository abstraction
- **Dependency Injection**: IoC container for loose coupling
- **Database Migrations**: Entity Framework migrations for database schema management
- **Logging**: NLog integration for comprehensive application logging
- **Error Handling**: Custom error pages and exception handling

## 🚀 Quick Start

### Prerequisites
- [.NET Core 2.2 SDK](https://dotnet.microsoft.com/download/dotnet/2.2)
- [SQL Server LocalDB](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (included with Visual Studio)
- [Visual Studio 2019](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/EmployeeManagement.git
   cd EmployeeManagement
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Update database connection string**
   ```json
   // appsettings.json
   {
     "ConnectionStrings": {
       "EmployeeDBConnection": "server=(localdb)\\MSSQLLocalDB;database=EmployeeDB;Trusted_Connection=True"
     }
   }
   ```

4. **Run database migrations**
   ```bash
   dotnet ef database update
   ```

5. **Launch the application**
   ```bash
   dotnet run
   ```

6. **Access the application**
   - Navigate to `https://localhost:5001` or `http://localhost:5000`
   - Register a new user account
   - Start managing employees!

## 📁 Project Structure

```
EmployeeManagement/
├── Controllers/           # MVC Controllers
│   ├── AccountController.cs      # User authentication
│   ├── AdministrationController.cs # Role management
│   ├── EmployeeController.cs     # Employee operations
│   ├── HomeController.cs         # Main application logic
│   └── ErrorController.cs        # Error handling
├── Models/               # Data models and DbContext
│   ├── Employee.cs              # Employee entity
│   ├── ApplicationUser.cs       # Extended Identity user
│   ├── Dept.cs                  # Department enumeration
│   ├── AppDbContext.cs          # Entity Framework context
│   └── Repositories/            # Data access layer
├── ViewModels/           # View models for data binding
├── Views/               # Razor views
│   ├── Account/         # Authentication views
│   ├── Administration/  # Role management views
│   ├── Employees/       # Employee management views
│   └── Shared/          # Layout and common views
├── Migrations/          # Entity Framework migrations
├── wwwroot/            # Static files (CSS, JS, images)
└── Utilities/          # Custom utilities and attributes
```

## 🔧 Configuration

### Database Configuration
The application uses SQL Server LocalDB by default. You can modify the connection string in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "EmployeeDBConnection": "server=(localdb)\\MSSQLLocalDB;database=EmployeeDB;Trusted_Connection=True"
  }
}
```

### Logging Configuration
NLog is configured in `nlog.config` for comprehensive application logging.

### Email Domain Validation
Custom email domain validation is implemented in `ValidEmailDomainAttribute.cs`.

## 🛡 Security Features

- **ASP.NET Core Identity**: Secure user authentication and authorization
- **Password Hashing**: Secure password storage with ASP.NET Core Identity
- **CSRF Protection**: Built-in Cross-Site Request Forgery protection
- **Input Validation**: Comprehensive server-side and client-side validation
- **Role-Based Authorization**: Fine-grained access control

## 📊 Database Schema

### Employees Table
- `Id` (Primary Key)
- `Name` (Required)
- `Email` (Required, Validated)
- `Department` (HR, Payroll, IT, None)
- `PhotoPath` (Profile picture path)

### Users Table (ASP.NET Core Identity)
- Extended `ApplicationUser` with additional `City` field
- Standard Identity fields (Email, PasswordHash, etc.)

### Roles Table
- Role-based authorization support
- Custom role creation and management

## 🎯 Usage Examples

### Creating a New Employee
1. Navigate to the employee creation page
2. Fill in employee details (Name, Email, Department)
3. Upload a profile picture (optional)
4. Submit the form

### Managing User Roles
1. Access the Administration section
2. Create new roles as needed
3. Assign roles to users for access control

### Viewing Employee Details
1. Browse the employee list
2. Click on any employee to view detailed information
3. Edit or delete employee records as needed

## 🤝 Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

### Development Guidelines
- Follow C# coding conventions
- Add appropriate unit tests for new features
- Update documentation for any API changes
- Ensure all tests pass before submitting PR

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/) - Web framework
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/) - ORM framework
- [Bootstrap](https://getbootstrap.com/) - CSS framework
- [NLog](https://nlog-project.org/) - Logging framework

## 📞 Support

If you encounter any issues or have questions:

- Create an [Issue](https://github.com/yourusername/EmployeeManagement/issues)
- Check the [Documentation](https://github.com/yourusername/EmployeeManagement/wiki)
- Contact the maintainers

---

**Made with ❤️ using ASP.NET Core**
