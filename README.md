# Gestion d'un centre de secours

Application de bureau pour la gestion d'un centre de sapeurs-pompiers :
personnels, engins, mobilisations et tableau de bord. Écrite en C# avec
Windows Forms, sur .NET Framework 4.7.2, avec une base SQLite locale.

Projet d'équipe réalisé en BUT Informatique (SAE), à trois.

## Comment le dépôt est organisé

Ce n'est pas une solution unique, et c'est volontaire : l'interface a été
découpée en `UserControl`, chacun développé dans **sa propre solution Visual
Studio**, puis assemblé dans l'application finale. Chaque membre de l'équipe
pouvait ainsi travailler sur son module sans bloquer les autres.

| Dossier | Ce qu'il contient |
|---|---|
| `Caubert-Stroher-KlausnitzerSae24/` | L'application assemblée : fenêtre de connexion, fenêtre principale, accès aux données |
| `UCLogin/` | Le contrôle d'authentification |
| `UC_Tableau_de_bord/`, `UCTDB/` | Le tableau de bord, en deux versions successives |
| `UCGestionPompier/` | La consultation des personnels |
| `UCmodifPompier/` | La modification d'une fiche de personnel |
| `UCmobilisations/` | Le suivi des mobilisations |
| `nouvelleMission/` | La saisie d'une nouvelle intervention |
| `Engin/` | Le parc de véhicules |
| `Statistiques/` | Les statistiques du centre |

## Le construire

**Prérequis :** Visual Studio avec la charge de travail .NET Desktop, sur
Windows. Le projet cible .NET Framework 4.7.2.

L'application référence les modules par leur DLL compilée. L'ordre compte donc :

1. Ouvrir et compiler chacune des solutions de module ci-dessus
   (`Engin/Engin.sln`, `Statistiques/Statistiques.sln`, etc.).
2. Ouvrir `Caubert-Stroher-KlausnitzerSae24/Caubert-Stroher-KlausnitzerSae24.sln`
   et lancer (F5). NuGet restaure SQLite au premier chargement.

Les dossiers `bin/`, `obj/` et `packages/` ne sont pas versionnés : ils sont
entièrement reconstruits par cette procédure.

## Ce qu'on en retient

Le découpage en modules indépendants a bien tenu son rôle pendant le
développement à trois. Il a un coût qu'on n'avait pas anticipé : lier les
modules par leur DLL compilée plutôt que par référence de projet oblige à
respecter un ordre de compilation, et rend la construction manuelle. Avec des
`ProjectReference` dans une solution unique, Visual Studio aurait déterminé cet
ordre tout seul.

`UC_Tableau_de_bord` et `UCTDB` sont deux états successifs du même écran. Les
deux sont conservés tels qu'ils ont été rendus.

## Licence

MIT, voir [LICENSE](LICENSE).
