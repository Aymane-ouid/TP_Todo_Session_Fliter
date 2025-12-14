Objectifs du Projet

Appliquer les principes fondamentaux de ASP.NET Core MVC

Mettre en œuvre les principes SOLID, en particulier :

Single Responsibility Principle (SRP)

Dependency Inversion Principle (DIP)

Assurer une architecture claire et facilement maintenable

Prendre en compte la sécurité et l'expérience utilisateur

Fonctionnalités Clés

Authentification utilisateur via Sessions

Accès restreint aux pages protégées par un filtre d'authentification

Gestion des tâches Todo : création, affichage et gestion

Système de thème (Mode Clair / Sombre) géré via des cookies

Journalisation des actions utilisateur dans un fichier texte

Architecture et Filtres

L'application repose sur plusieurs filtres personnalisés pour optimiser son fonctionnement et sa sécurité :

AuthFilter : Vérifie si l’utilisateur est connecté avant d’accéder à des pages protégées.

ThemeFilter : Permet de récupérer le thème de l’utilisateur à partir des cookies et l'applique aux vues.

LogFilter : Enregistre chaque action de l’utilisateur, incluant :

Date et heure

Utilisateur connecté

Nom du contrôleur et de l’action

Tous ces logs sont stockés dans un fichier texte, offrant ainsi une trace claire des actions effectuées.

Application des Principes SOLID

SRP : Chaque composant (Contrôleur, Filtre, Service) a une responsabilité unique.

DIP : Les dépendances sont gérées via des interfaces (par exemple, ILogService), ce qui permet de découpler les composants et de faciliter l'évolution du projet.

Conclusion

Ce projet propose une application simple mais professionnelle, illustrant une maîtrise des concepts d'ASP.NET Core MVC, de l’utilisation des Sessions, des Filtres, ainsi que des bonnes pratiques de développement logiciel.
