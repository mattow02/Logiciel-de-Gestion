# Firefighter Management App

![C#](https://img.shields.io/badge/C%23-.NET-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-GUI-0078D6?style=for-the-badge&logo=windows&logoColor=white)

A desktop application for managing a firefighter station, personnel records, team assignments, interventions, and equipment tracking. Built with C# and Windows Forms.

---

## Features

- **Personnel management**, add, edit, delete firefighter profiles (name, rank, station, status).
- **Intervention tracking**, log missions with date, location, team, and outcome.
- **Team assignments**, assign firefighters to squads and track availability.
- **Equipment registry**, manage vehicles and gear linked to the station.
- **Data persistence**, save and load data between sessions.
- **Search and filter**, quickly find records across all modules.

---

## Running the project

**Requirements:** .NET SDK (or Visual Studio with C# workload)

### With Visual Studio
1. Open `UCLogin/UCLogin.sln` (or any `.sln` in the repo).
2. Build and run (F5).

### With .NET CLI
```bash
git clone https://github.com/mattow02/Logiciel-de-Gestion.git
cd Logiciel-de-Gestion/UCLogin
dotnet run
```

---

## Tech stack

- **Language:** C# (.NET Framework)
- **UI:** Windows Forms
- **Architecture:** modular with separate projects for login, dashboard, and CRUD modules
- **Data:** local file-based persistence
