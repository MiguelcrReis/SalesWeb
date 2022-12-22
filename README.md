<h1 align="center"> Sales web system </h1>

<p align="center">
  <img src="https://user-images.githubusercontent.com/69518446/209129220-647a502e-5068-4e9f-bdd8-c47c4e286980.png"/>
</p>

<p align="center">
<img src="http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=GREEN&style=for-the-badge"/>
</p>

## Project description 

<p align="justify">
Web application project for a sales system in ASP.NET CORE (version 2.1.7) in the MVC pattern (Model-View-Controller)
with Entity Framework (version 2.1.1), using the Visual Studio 2019 IDE (version 16.11.22) connected to a MySQL database (version 8.0).
</p>

## Descrição do projeto 

<p align="justify">
Projeto de aplicação web de um sistema de vendas em ASP.NET CORE (versão 2.1.7) no padrão MVC (Model-View-Controller) 
com Entity Framework (versão 2.1.1), utilizando a IDE Visual Studio 2019 (versão 16.11.22) conectado a um banco de dados MySQL (versão 8.0).
</p>


## Functionalities

<p align="justify">

:heavy_check_mark: `Functionality 1:` CRUD Sellers;

:heavy_check_mark: `Functionality 2:` CRUD Departments;

:heavy_check_mark: `Functionality 3:` Sales view filtering by date and department.

</p>

![Example SalesWeb - Google Chrome 2022-12-22 10-27-44](https://user-images.githubusercontent.com/69518446/209144963-beb53b9d-164d-4c84-a24f-df8e51da1ad6.gif)

## 📁 Project access
[Source code](https://github.com/MiguelcrReis/SalesWeb)

[Download ZIP](https://github.com/MiguelcrReis/SalesWeb/archive/refs/heads/master.zip)


## 🛠️ Open and run the project

Must have installed [ .NET Core 2.1 SDK ](https://dotnet.microsoft.com/en-us/download/dotnet/2.1)

Must have installed [ Servidor MySQL 8.0 ](https://dev.mysql.com/downloads/windows/installer/8.0.html)

Configure connection string in project's appsettings.json, replacing the `username`, `password`, and `database` appropriately:

```cs
"ConnectionStrings": {
  "DefaultConnection":"server=localhost;userid=myusername;password=mypassword;database=mydatabase;"
},
```

Execute the installation and Execute the migration of the Mysql provider using either Visual Studio Package Manager Console (from menu: Tools -> NuGet Package Manager -> Package Manager Console):

```
Install-Package Pomelo.EntityFrameworkCore.MySql -Version 2.1.1
```
```
Update-Database
```

Run the solution.
