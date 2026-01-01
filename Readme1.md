# ASP.NET Core Web API - NuGet Packages Installation Guide

## 📦 Essential NuGet Packages for ASP.NET Core Web API

This guide covers all the essential NuGet packages you need for a production-ready ASP.NET Core Web API with Entity Framework Core, SQL Server, and Swagger.

---

## 🛠️ Installation Methods

### **Method 1: Using .NET CLI (Recommended)**

```bash
# Navigate to your project directory
cd YourProjectName

# Install packages using dotnet add package command
dotnet add package PackageName
```

### **Method 2: Using Visual Studio**

1. Right-click on project → **Manage NuGet Packages**
2. Search for package name
3. Click **Install**

### **Method 3: Using Package Manager Console (Visual Studio)**

```powershell
Install-Package PackageName
```

### **Method 4: Manually Edit .csproj File**

Add packages directly to your `.csproj` file:

```xml
<ItemGroup>
  <PackageReference Include="PackageName" Version="8.0.0" />
</ItemGroup>
```

Then run: `dotnet restore`

---

## 📋 Core Packages Installation

### **1. Entity Framework Core Packages**

#### **A. EF Core Base Package**

```bash
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0
```

**Purpose:** Core Entity Framework functionality

---

#### **B. EF Core SQL Server Provider**

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.0
```

**Purpose:** SQL Server database provider for EF Core

**Alternative Database Providers:**

```bash
# PostgreSQL
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 8.0.0

# MySQL
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 8.0.0

# SQLite (for development/testing)
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.0.0

# In-Memory Database (for testing)
dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 8.0.0
```

---

#### **C. EF Core Tools (For Migrations)**

```bash
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.0
```

**Purpose:** Enables migration commands like `Add-Migration`, `Update-Database`

**Also install the global tool:**

```bash
dotnet tool install --global dotnet-ef
```

**Verify installation:**

```bash
dotnet ef --version
```

---

#### **D. EF Core Design (Required for Migrations)**

```bash
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.0
```

**Purpose:** Design-time support for EF Core (required for migrations)

---

### **2. Swagger/OpenAPI Packages**

#### **A. Swashbuckle.AspNetCore (Complete Swagger Package)**

```bash
dotnet add package Swashbuckle.AspNetCore --version 6.5.0
```

**Purpose:** Complete package that includes:

- Swagger generator
- Swagger UI
- Swagger JSON endpoint

**This single package is usually enough!**

---

#### **B. Individual Swashbuckle Packages (Optional - if you need more control)**

```bash
# Swagger Generator
dotnet add package Swashbuckle.AspNetCore.SwaggerGen --version 6.5.0

# Swagger UI
dotnet add package Swashbuckle.AspNetCore.SwaggerUI --version 6.5.0

# Swagger Annotations (for better documentation)
dotnet add package Swashbuckle.AspNetCore.Annotations --version 6.5.0
```

---

### **3. Authentication & Security Packages**

#### **A. JWT Bearer Authentication**

```bash
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 8.0.0
```

**Purpose:** JWT token authentication

---

#### **B. ASP.NET Core Identity (User Management)**

```bash
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 8.0.0
```

**Purpose:** Built-in user management, authentication, and authorization

---

### **4. Additional Useful Packages**

#### **A. AutoMapper (Object-to-Object Mapping)**

```bash
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1
```

**Purpose:** Map between entities and DTOs automatically

---

#### **B. FluentValidation (Advanced Validation)**

```bash
dotnet add package FluentValidation.AspNetCore --version 11.3.0
```

**Purpose:** More powerful validation than Data Annotations

---

#### **C. Newtonsoft.Json (JSON Serialization)**

```bash
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 8.0.0
```

**Purpose:** Better JSON serialization options

---

#### **D. CORS (Cross-Origin Resource Sharing)**

**Already included in ASP.NET Core 8.0, but if needed:**

```bash
dotnet add package Microsoft.AspNetCore.Cors --version 2.2.0
```

---

#### **E. Serilog (Advanced Logging)**

```bash
dotnet add package Serilog.AspNetCore --version 8.0.0
dotnet add package Serilog.Sinks.Console --version 5.0.0
dotnet add package Serilog.Sinks.File --version 5.0.0
```

**Purpose:** Better logging than built-in ILogger

---

#### **F. BCrypt.Net (Password Hashing)**

```bash
dotnet add package BCrypt.Net-Next --version 4.0.3
```

**Purpose:** Secure password hashing (if not using Identity)

---

## 🚀 Complete Installation Script

### **For a Basic Web API with EF Core, SQL Server, and Swagger:**

```bash
# Create new Web API project
dotnet new webapi -n MyWebAPI
cd MyWebAPI

# Entity Framework Core packages
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.0

# Swagger
dotnet add package Swashbuckle.AspNetCore --version 6.5.0

# JWT Authentication
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 8.0.0

# Identity (if you need user management)
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 8.0.0

# AutoMapper
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1

# Install EF Core global tool
dotnet tool install --global dotnet-ef

# Restore packages
dotnet restore

# Build project
dotnet build
```

---

### **For a Production-Ready API:**

```bash
# All previous packages plus:

# Validation
dotnet add package FluentValidation.AspNetCore --version 11.3.0

# Better JSON
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 8.0.0

# Logging
dotnet add package Serilog.AspNetCore --version 8.0.0
dotnet add package Serilog.Sinks.Console --version 5.0.0
dotnet add package Serilog.Sinks.File --version 5.0.0

# Testing (optional)
dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 8.0.0
dotnet add package xunit --version 2.6.0
dotnet add package Moq --version 4.20.0
```

---

## 📝 Your .csproj File Should Look Like This

```xml
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  <ItemGroup>
    <!-- Entity Framework Core -->
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="8.0.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.0">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="8.0.0">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>

    <!-- Swagger -->
    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.5.0" />

    <!-- Authentication -->
    <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="8.0.0" />
    <PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="8.0.0" />

    <!-- AutoMapper -->
    <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="12.0.1" />

    <!-- Validation -->
    <PackageReference Include="FluentValidation.AspNetCore" Version="11.3.0" />
  </ItemGroup>

</Project>
```

---

## ⚙️ Configuration After Installation

### **1. Configure Entity Framework Core**

**appsettings.json:**

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=MyDatabase;Trusted_Connection=True;TrustServerCertificate=True;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  }
}
```

**Program.cs:**

```csharp
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add controllers
builder.Services.AddControllers();

// Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
```

---

### **2. Create DbContext**

**Data/ApplicationDbContext.cs:**

```csharp
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure relationships here
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();
    }
}
```

---

### **3. Configure Swagger with JWT**

**Program.cs:**

```csharp
using Microsoft.OpenApi.Models;

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "My API",
        Version = "v1",
        Description = "ASP.NET Core Web API with JWT Authentication"
    });

    // Add JWT Authentication to Swagger
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Enter 'Bearer' [space] and then your token in the text input below.",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});
```

---

### **4. Configure JWT Authentication**

**appsettings.json:**

```json
{
  "Jwt": {
    "Key": "YourSuperSecretKeyThatIsAtLeast32CharactersLong!",
    "Issuer": "YourApp",
    "Audience": "YourAppUsers",
    "ExpireMinutes": 60
  }
}
```

**Program.cs:**

```csharp
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

// Add Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

// After var app = builder.Build();
app.UseAuthentication(); // Add this BEFORE UseAuthorization
app.UseAuthorization();
```

---

### **5. Configure AutoMapper**

**Mappings/MappingProfile.cs:**

```csharp
using AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<CreateUserDto, User>();
        CreateMap<Product, ProductDto>();
    }
}
```

**Program.cs:**

```csharp
// Add AutoMapper
builder.Services.AddAutoMapper(typeof(Program));
```

---

## 🔧 EF Core Migration Commands

After installing EF Core packages, use these commands:

```bash
# Create your first migration
dotnet ef migrations add InitialCreate

# Update database
dotnet ef database update

# Remove last migration (if not applied)
dotnet ef migrations remove

# List all migrations
dotnet ef migrations list

# Generate SQL script
dotnet ef migrations script

# Drop database
dotnet ef database drop
```

---

## 📊 Package Version Compatibility

| .NET Version | EF Core Version | Recommended Versions |
| ------------ | --------------- | -------------------- |
| .NET 8.0     | 8.0.x           | Use 8.0.0 or later   |
| .NET 7.0     | 7.0.x           | Use 7.0.0 or later   |
| .NET 6.0     | 6.0.x           | Use 6.0.0 or later   |

**Always use matching versions for:**

- All EF Core packages (SqlServer, Tools, Design)
- All ASP.NET Core packages

---

## ⚠️ Common Issues & Solutions

### **Issue 1: Migration commands not found**

```bash
# Solution: Install global tool
dotnet tool install --global dotnet-ef

# Update if already installed
dotnet tool update --global dotnet-ef
```

---

### **Issue 2: "Build failed" during migration**

```bash
# Solution: Build project first
dotnet build
dotnet ef migrations add InitialCreate
```

---

### **Issue 3: Connection string error**

**Ensure your connection string in appsettings.json is correct:**

```json
// For SQL Server with Windows Authentication
"Server=localhost;Database=MyDb;Trusted_Connection=True;TrustServerCertificate=True;"

// For SQL Server with SQL Authentication
"Server=localhost;Database=MyDb;User Id=sa;Password=YourPassword;TrustServerCertificate=True;"

// For LocalDB (development)
"Server=(localdb)\\mssqllocaldb;Database=MyDb;Trusted_Connection=True;"
```

---

### **Issue 4: Swagger not showing up**

**Make sure you have both these lines in Program.cs:**

```csharp
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
```

**Access Swagger at:** `https://localhost:5001/swagger`

---

## 🎯 Quick Start Complete Example

```bash
# 1. Create new project
dotnet new webapi -n MyAPI
cd MyAPI

# 2. Install all essential packages
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.0
dotnet add package Swashbuckle.AspNetCore --version 6.5.0
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 8.0.0
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1

# 3. Install EF Core global tool
dotnet tool install --global dotnet-ef

# 4. Restore and build
dotnet restore
dotnet build

# 5. Run the application
dotnet run

# 6. Access Swagger UI
# Open browser: https://localhost:5001/swagger
```

---

## 📚 Additional Resources

- [NuGet.org](https://www.nuget.org/) - Search for packages
- [Entity Framework Core Docs](https://docs.microsoft.com/en-us/ef/core/)
- [Swashbuckle GitHub](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
- [ASP.NET Core Authentication](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/)

---

## ✅ Verification Checklist

After installation, verify everything works:

- [ ] Project builds without errors: `dotnet build`
- [ ] All packages restored: `dotnet restore`
- [ ] EF Core tools installed: `dotnet ef --version`
- [ ] Swagger accessible: `https://localhost:5001/swagger`
- [ ] Database connection works
- [ ] Migrations run successfully
- [ ] JWT authentication configured
- [ ] AutoMapper profiles registered

---

**You're now ready to build a secure, production-ready ASP.NET Core Web API!** 🚀
