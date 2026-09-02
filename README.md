# Firefighter Station Management

Desktop application for running a fire station: personnel, vehicles, callouts
and a dashboard. Written in C# with Windows Forms, on .NET Framework 4.7.2,
with a local SQLite database.

> **Coursework.** Development project (SAE) of the BUT Informatique at IUT
> Robert Schuman, Strasbourg. Written in 2025 over about three months, as a
> team of three.

## How the repository is laid out

This is not one solution, and that is deliberate: the interface was split into
`UserControl`s, each developed in **its own Visual Studio solution**, then
assembled into the final application. Each of us could work on a module without
blocking the others.

| Folder | What it holds |
|---|---|
| `Caubert-Stroher-KlausnitzerSae24/` | The assembled application: login window, main window, data access |
| `UCLogin/` | The authentication control |
| `UC_Tableau_de_bord/`, `UCTDB/` | The dashboard, in two successive versions |
| `UCGestionPompier/` | Browsing personnel records |
| `UCmodifPompier/` | Editing a personnel record |
| `UCmobilisations/` | Callout tracking |
| `nouvelleMission/` | Entering a new intervention |
| `Engin/` | The vehicle fleet |
| `Statistiques/` | Station statistics |

## Building it

**Requirements:** Visual Studio with the .NET Desktop workload, on Windows. The
project targets .NET Framework 4.7.2.

The application references the modules by their compiled DLL, so the order
matters:

1. Open and build each of the module solutions above (`Engin/Engin.sln`,
   `Statistiques/Statistiques.sln`, and so on).
2. Open
   `Caubert-Stroher-KlausnitzerSae24/Caubert-Stroher-KlausnitzerSae24.sln`
   and run (F5). NuGet restores SQLite on first load.

`bin/`, `obj/` and `packages/` are not tracked: this procedure rebuilds them
entirely.

## What we took away from it

Splitting into independent modules did its job while three of us were working
at once. It has a cost we had not anticipated: linking modules by their
compiled DLL rather than by project reference forces a build order and makes
the build manual. With `ProjectReference` entries in a single solution, Visual
Studio would have worked that order out on its own.

`UC_Tableau_de_bord` and `UCTDB` are two successive states of the same screen.
Both are kept as they were handed in.

## License

MIT, see [LICENSE](LICENSE).
