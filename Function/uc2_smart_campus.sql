-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost:3306
-- Généré le : lun. 12 avr. 2021 à 21:08
-- Version du serveur :  5.7.24
-- Version de PHP : 7.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `uc2_smart_campus`
--

-- --------------------------------------------------------

--
-- Structure de la table `labs`
--

CREATE TABLE `labs` (
  `id` int(10) UNSIGNED NOT NULL,
  `code` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `labs`
--

INSERT INTO `labs` (`id`, `code`) VALUES
(1, 'Labo 1'),
(2, 'Labo 2'),
(3, 'Labo 3'),
(4, 'Labo 4'),
(5, 'Labo 5');

-- --------------------------------------------------------

--
-- Structure de la table `prod_sci`
--

CREATE TABLE `prod_sci` (
  `id` int(10) UNSIGNED NOT NULL,
  `title` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `description` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `reference` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `type` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `created_at` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'CURRENT_TIMESTAMP',
  `created_by` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `prod_sci`
--

INSERT INTO `prod_sci` (`id`, `title`, `description`, `reference`, `type`, `created_at`, `created_by`) VALUES
(1, 'Titre 1', 'Description 1', 'Reference 1', 'Revue', '2021-03-19 08:45:42', 4),
(2, 'Titre 2', 'Description 2', 'Reference 2', 'Livre', '2021-04-10 02:12:21', 4),
(3, 'Titre 3', 'Description 3', 'Reference 3', 'Lien', '2021-04-11 10:05:58', 6),
(4, 'Titre 4', 'Description 4', 'Reference 4', 'Note', '2021-04-11 04:43:03', 4);

-- --------------------------------------------------------

--
-- Structure de la table `profils`
--

CREATE TABLE `profils` (
  `id` int(10) UNSIGNED NOT NULL,
  `fname` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `lname` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `role_id` int(10) UNSIGNED DEFAULT '1',
  `lab_id` int(10) UNSIGNED DEFAULT '1',
  `team_id` int(10) UNSIGNED DEFAULT '1',
  `email` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `profils`
--

INSERT INTO `profils` (`id`, `fname`, `lname`, `role_id`, `lab_id`, `team_id`, `email`, `password`) VALUES
(1, 'Chercheur 1', 'Chercheur 1', 1, 1, 1, 'Chercheur1@gmail.com', 'Chercheur1'),
(2, 'Chercheur 2', 'Chercheur 2', 2, 2, 2, 'Chercheur2@gmail.com', 'Chercheur2'),
(3, 'Chercheur 3', 'Chercheur 3', 3, 2, 2, 'Chercheur3@gmail.com', 'Chercheur3'),
(4, 'Chercheur 4', 'Chercheur 4', 2, 2, 2, 'Chercheur4@gmail.com', 'Chercheur4'),
(5, 'Chercheur 5', 'Chercheur 5', 2, 2, 2, 'Chercheur5@gmail.com', 'Chercheur5'),
(6, 'Chercheur 6', 'Chercheur 6', 3, 1, 1, 'Chercheur6@gmail.com', 'Chercheur6'),
(7, 'Chercheur 7', 'Chercheur 7', 2, 1, 1, 'chercheur7@gmail.com', 'chercheur7'),
(8, 'Chercheur 8', 'Chercheur 5', 2, 1, 1, 'Chercheur8@gmail.com', 'Chercheur8'),
(9, 'Chercheur 9', 'Chercheur 9', 2, 1, 1, 'Chercheur9@gmail.com', 'Chercheur9'),
(10, 'Chercheur 10', 'Chercheur 10', 2, 1, 1, 'Chercheur10@gmail.com', 'Chercheur10'),
(11, 'Chercheur 11', 'Chercheur 11', 3, 1, 2, 'Chercheur11@gmail.com', 'Chercheur11'),
(12, 'Chercheur 12', 'Chercheur 12', 2, 1, 2, 'Chercheur12@gmail.com', 'Chercheur12'),
(13, 'Chercheur 13', 'Chercheur 13', 2, 1, 2, 'Chercheur13@gmail.com', 'Chercheur13'),
(14, 'Chercheur 14', 'Chercheur 14', 2, 1, 2, 'Chercheur14@gmail.com', 'Chercheur14'),
(15, 'Chercheur 15', 'Chercheur 15', 4, 1, 1, 'Chercheur15@gmail.com', 'Chercheur15'),
(16, 'Chercheur 16', 'Chercheur 16', 4, 2, 1, 'Chercheur16@gmail.com', 'Chercheur16'),
(17, 'Chercheur 17', 'Chercheur 17', 4, 3, 1, 'chercheur17@gmail.com', 'Chercheur17');

-- --------------------------------------------------------

--
-- Structure de la table `roles`
--

CREATE TABLE `roles` (
  `id` int(10) UNSIGNED NOT NULL,
  `role` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `roles`
--

INSERT INTO `roles` (`id`, `role`) VALUES
(1, 'Admin'),
(2, 'Chercheur'),
(3, 'Chef d\'équipe'),
(4, 'Directeur');

-- --------------------------------------------------------

--
-- Structure de la table `teams`
--

CREATE TABLE `teams` (
  `id` int(10) UNSIGNED NOT NULL,
  `name` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `lab_id` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `teams`
--

INSERT INTO `teams` (`id`, `name`, `lab_id`) VALUES
(1, 'Team 1', 1),
(2, 'Team 2', 2),
(3, 'Team 3', 3),
(4, 'Team 4', 4),
(5, 'Team 5', 5);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `labs`
--
ALTER TABLE `labs`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `prod_sci`
--
ALTER TABLE `prod_sci`
  ADD PRIMARY KEY (`id`),
  ADD KEY `created_by` (`created_by`);

--
-- Index pour la table `profils`
--
ALTER TABLE `profils`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `Index 5` (`email`),
  ADD KEY `Index 4` (`team_id`),
  ADD KEY `profils_ibfk_1` (`role_id`),
  ADD KEY `profils_ibfk_2` (`lab_id`);

--
-- Index pour la table `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `teams`
--
ALTER TABLE `teams`
  ADD PRIMARY KEY (`id`),
  ADD KEY `teams_ibfk_1` (`lab_id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `labs`
--
ALTER TABLE `labs`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `prod_sci`
--
ALTER TABLE `prod_sci`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `profils`
--
ALTER TABLE `profils`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT pour la table `roles`
--
ALTER TABLE `roles`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `teams`
--
ALTER TABLE `teams`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `prod_sci`
--
ALTER TABLE `prod_sci`
  ADD CONSTRAINT `prod_sci_ibfk_1` FOREIGN KEY (`created_by`) REFERENCES `profils` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Contraintes pour la table `profils`
--
ALTER TABLE `profils`
  ADD CONSTRAINT `FK_profils_teams` FOREIGN KEY (`team_id`) REFERENCES `teams` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `profils_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `roles` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `profils_ibfk_2` FOREIGN KEY (`lab_id`) REFERENCES `labs` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Contraintes pour la table `teams`
--
ALTER TABLE `teams`
  ADD CONSTRAINT `teams_ibfk_1` FOREIGN KEY (`lab_id`) REFERENCES `labs` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
