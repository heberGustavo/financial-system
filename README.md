<h1 align="center">
   Financial System ⚖️
</h1>

</br>
  
<p align="center">
  <a href="#globe_with_meridians-Technologies-and-Concepts-Implemented">Technology</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
   <a href="#gear-Architecture">Architecture</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
   <a href="#round_pushpin-endpoints">Endpoints</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#wrench-How-to-use">How to use</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#memo-Licence">Licence</a>
</p>

## :globe_with_meridians: Technologies and Concepts Implemented

This project was developed using:

- .NET 8
- Entity Framework Core
- Identity - Control users
- JWT - Users Authentication
- Swagger

Concepts/Techniques used in:
- Clean Architecture
- DDD principles
- Data Transfer Object [DTO]
- Repository Pattern
- Dependency Injection

## :gear: Architecture

```🌐
src
├── 📂 1- UI
|   ├── 📂 Controllers
|   ├── 📂 Models
|   ├── 📂 Token
├── 📂 2- Domain
|   ├── 📂 Interfaces
|       ├── 📂 Generics
|       ├── 📂 IServices
|   ├── 📂 Services
├── 📂 3- Infra
|   ├── 📂 Configuration
|   ├── 📂 Migration
|   ├── 📂 Repository
|       ├── 📂 Generics
├── 📂 4- Entities
|   ├── 📂 Entities
|       ├── 📂 Base
|   ├── 📂 Enum
|   ├── 📂 Notifications
├── 📂 5- Helpers
|   ├── 📂 DependencyGroups

```

## :round_pushpin: Endpoints
![screenshot-localhost_7028-2024 07 10-10_54_16](https://github.com/heberGustavo/financial-system/assets/44476616/9921e4ae-edd6-42c5-b7d9-06ad510b4d86)



## :wrench: How to use

Clone that application using [Git](https://git-scm.com) and follow the next steps:

```bash
# 1. Clone this repository
$ git clone https://github.com/heberGustavo/financial-system.git

# 2. Open the project in Visual Studio

# 3. Execute the build

# 4. Change the Connection String. To modify follow this path:
  4.1 - UI > WebApi > appsettings.json
  4.2 - Modify the value to "DefaultConnection"

# 5. Execute Migration
  5.1 - Open the "Package Manager Console"
  5.2 - Select the project "Infra" in "Default project"
  5.3 - Execute this command: Update-Database

# 6. Run the application

```


## :memo: Licence 
This project is under the MIT license. See the [LICENSE](https://github.com/heberGustavo/api-DDD-net8/blob/main/LICENSE) for more information.


## Autor

| [<img src="https://avatars.githubusercontent.com/u/44476616?v=4" style="max-width: 100%;width: 90px;"><br><sub>Heber Gustavo</sub>](https://github.com/heberGustavo) |
| :---: |
|[Linkedin](https://www.linkedin.com/in/heber-gustavo/)|
