DROP DATABASE IF EXISTS greta;
CREATE DATABASE greta;
USE greta;
-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost
-- Généré le :  mar. 30 mars 2021 à 16:58
-- Version du serveur :  8.0.18
-- Version de PHP :  7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `greta`
--

-- --------------------------------------------------------

--
-- Structure de la table `accueillir`
--

CREATE TABLE `accueillir` (
  `id_formation` int(11) NOT NULL,
  `id_site` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `activite_type`
--

CREATE TABLE `activite_type` (
  `id_act_type` int(11) NOT NULL,
  `num_act_type` int(11) NOT NULL,
  `nom_act_type` text COLLATE utf8mb4_general_ci NOT NULL,
  `id_formation` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Table des activités types d''une formation';

-- --------------------------------------------------------

--
-- Structure de la table `competence`
--

CREATE TABLE `competence` (
  `id_competence` int(11) NOT NULL,
  `nom_competence` text COLLATE utf8mb4_general_ci NOT NULL,
  `code_competence` varchar(5) COLLATE utf8mb4_general_ci NOT NULL,
  `id_act_type` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Table des compétences';

-- --------------------------------------------------------

--
-- Structure de la table `evenement`
--

CREATE TABLE `evenement` (
  `id_evenement` int(11) NOT NULL,
  `titre` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `type` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `date_debut` date NOT NULL,
  `date_fin` date NOT NULL,
  `heure_debut` time NOT NULL,
  `heure_fin` time NOT NULL,
  `visio` char(1) COLLATE utf8mb4_general_ci NOT NULL,
  `id_promotion` int(11) NOT NULL,
  `id_utilisateur` int(11) DEFAULT NULL,
  `id_salle` int(11) DEFAULT NULL,
  `id_competence` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Table des évenements affichés dans l''emploi du temps (cours, réunion, etc...)';

-- --------------------------------------------------------

--
-- Structure de la table `formation`
--

CREATE TABLE `formation` (
  `id_formation` int(11) NOT NULL,
  `intitule_formation` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `detail_formation` longtext COLLATE utf8mb4_general_ci COMMENT 'informations complémentaire sur la formation : coût, prerequis, objectifs, etc...',
  `type_formation` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `categorie_formation` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `volume_horaire_centre` int(11) NOT NULL,
  `volume_horaire_stage` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Table des formations';

-- --------------------------------------------------------

--
-- Structure de la table `organisme_formation`
--

CREATE TABLE `organisme_formation` (
  `id_organisme` int(11) NOT NULL,
  `siret_organisme` int(11) NOT NULL,
  `nom_organisme` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `num_organisme` int(11) NOT NULL,
  `rue_organisme` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `code_postal_organisme` int(11) NOT NULL,
  `ville_organisme` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `telephone_organisme` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `email_organisme` varchar(50) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Table des organismes de formation';

-- --------------------------------------------------------

--
-- Structure de la table `promotion`
--

CREATE TABLE `promotion` (
  `id_promotion` int(11) NOT NULL,
  `nom_promotion` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `date_debut` date NOT NULL,
  `date_fin` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Table des promotions/classes';

-- --------------------------------------------------------

--
-- Structure de la table `proposer`
--

CREATE TABLE `proposer` (
  `id_organisme` int(11) NOT NULL,
  `id_formation` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `role`
--

CREATE TABLE `role` (
  `id_role` int(11) NOT NULL,
  `nom_role` varchar(50) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Table des statuts des utilisateurs';

-- --------------------------------------------------------

--
-- Structure de la table `salle`
--

CREATE TABLE `salle` (
  `id_salle` int(11) NOT NULL,
  `nom_salle` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `numero_salle` int(11) DEFAULT NULL,
  `batiment_salle` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `id_site` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Table des salles de cours';

-- --------------------------------------------------------

--
-- Structure de la table `site_formation`
--

CREATE TABLE `site_formation` (
  `id_site` int(11) NOT NULL,
  `nom_site` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `num_site` int(11) NOT NULL,
  `rue_site` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `code_postal_site` int(11) NOT NULL,
  `ville_site` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `telephone_site` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `email_site` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `id_organisme` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Table des sites de formations';

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `id_utilisateur` int(11) NOT NULL,
  `nom_utilisateur` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `prenom_utilisateur` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `num_rue_utilisateur` int(11) NOT NULL,
  `nom_rue_utilisateur` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `code_postal_utilisateur` int(11) NOT NULL,
  `ville_utilisateur` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `telephone_utilisateur` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `email_utilisateur` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `password` text NULL,
  `id_promotion` int(11) DEFAULT NULL,
  `id_role` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Table des utilisateurs';

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `accueillir`
--
ALTER TABLE `accueillir`
  ADD PRIMARY KEY (`id_formation`,`id_site`),
  ADD KEY `accueillir_site_formation0_FK` (`id_site`);

--
-- Index pour la table `activite_type`
--
ALTER TABLE `activite_type`
  ADD PRIMARY KEY (`id_act_type`),
  ADD KEY `activite_type_formation_FK` (`id_formation`);

--
-- Index pour la table `competence`
--
ALTER TABLE `competence`
  ADD PRIMARY KEY (`id_competence`),
  ADD KEY `competence_activite_type_FK` (`id_act_type`);

--
-- Index pour la table `evenement`
--
ALTER TABLE `evenement`
  ADD PRIMARY KEY (`id_evenement`),
  ADD KEY `evenement_promotion_FK` (`id_promotion`),
  ADD KEY `evenement_utilisateur0_FK` (`id_utilisateur`),
  ADD KEY `evenement_salle1_FK` (`id_salle`),
  ADD KEY `evenement_competence2_FK` (`id_competence`);

--
-- Index pour la table `formation`
--
ALTER TABLE `formation`
  ADD PRIMARY KEY (`id_formation`);

--
-- Index pour la table `organisme_formation`
--
ALTER TABLE `organisme_formation`
  ADD PRIMARY KEY (`id_organisme`);

--
-- Index pour la table `promotion`
--
ALTER TABLE `promotion`
  ADD PRIMARY KEY (`id_promotion`);

--
-- Index pour la table `proposer`
--
ALTER TABLE `proposer`
  ADD PRIMARY KEY (`id_organisme`,`id_formation`),
  ADD KEY `proposer_formation0_FK` (`id_formation`);

--
-- Index pour la table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`id_role`);

--
-- Index pour la table `salle`
--
ALTER TABLE `salle`
  ADD PRIMARY KEY (`id_salle`),
  ADD KEY `salle_site_formation_FK` (`id_site`);

--
-- Index pour la table `site_formation`
--
ALTER TABLE `site_formation`
  ADD PRIMARY KEY (`id_site`),
  ADD KEY `site_formation_organisme_formation_FK` (`id_organisme`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`id_utilisateur`),
  ADD KEY `utilisateur_promotion_FK` (`id_promotion`),
  ADD KEY `utilisateur_role0_FK` (`id_role`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `activite_type`
--
ALTER TABLE `activite_type`
  MODIFY `id_act_type` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `competence`
--
ALTER TABLE `competence`
  MODIFY `id_competence` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `evenement`
--
ALTER TABLE `evenement`
  MODIFY `id_evenement` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `formation`
--
ALTER TABLE `formation`
  MODIFY `id_formation` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `organisme_formation`
--
ALTER TABLE `organisme_formation`
  MODIFY `id_organisme` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `promotion`
--
ALTER TABLE `promotion`
  MODIFY `id_promotion` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `role`
--
ALTER TABLE `role`
  MODIFY `id_role` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `salle`
--
ALTER TABLE `salle`
  MODIFY `id_salle` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `site_formation`
--
ALTER TABLE `site_formation`
  MODIFY `id_site` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  MODIFY `id_utilisateur` int(11) NOT NULL AUTO_INCREMENT;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `accueillir`
--
ALTER TABLE `accueillir`
  ADD CONSTRAINT `accueillir_formation_FK` FOREIGN KEY (`id_formation`) REFERENCES `formation` (`id_formation`),
  ADD CONSTRAINT `accueillir_site_formation0_FK` FOREIGN KEY (`id_site`) REFERENCES `site_formation` (`id_site`);

--
-- Contraintes pour la table `activite_type`
--
ALTER TABLE `activite_type`
  ADD CONSTRAINT `activite_type_formation_FK` FOREIGN KEY (`id_formation`) REFERENCES `formation` (`id_formation`);

--
-- Contraintes pour la table `competence`
--
ALTER TABLE `competence`
  ADD CONSTRAINT `competence_activite_type_FK` FOREIGN KEY (`id_act_type`) REFERENCES `activite_type` (`id_act_type`);

--
-- Contraintes pour la table `evenement`
--
ALTER TABLE `evenement`
  ADD CONSTRAINT `evenement_competence2_FK` FOREIGN KEY (`id_competence`) REFERENCES `competence` (`id_competence`),
  ADD CONSTRAINT `evenement_promotion_FK` FOREIGN KEY (`id_promotion`) REFERENCES `promotion` (`id_promotion`),
  ADD CONSTRAINT `evenement_salle1_FK` FOREIGN KEY (`id_salle`) REFERENCES `salle` (`id_salle`),
  ADD CONSTRAINT `evenement_utilisateur0_FK` FOREIGN KEY (`id_utilisateur`) REFERENCES `utilisateur` (`id_utilisateur`);

--
-- Contraintes pour la table `proposer`
--
ALTER TABLE `proposer`
  ADD CONSTRAINT `proposer_formation0_FK` FOREIGN KEY (`id_formation`) REFERENCES `formation` (`id_formation`),
  ADD CONSTRAINT `proposer_organisme_formation_FK` FOREIGN KEY (`id_organisme`) REFERENCES `organisme_formation` (`id_organisme`);

--
-- Contraintes pour la table `salle`
--
ALTER TABLE `salle`
  ADD CONSTRAINT `salle_site_formation_FK` FOREIGN KEY (`id_site`) REFERENCES `site_formation` (`id_site`);

--
-- Contraintes pour la table `site_formation`
--
ALTER TABLE `site_formation`
  ADD CONSTRAINT `site_formation_organisme_formation_FK` FOREIGN KEY (`id_organisme`) REFERENCES `organisme_formation` (`id_organisme`);

--
-- Contraintes pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD CONSTRAINT `utilisateur_promotion_FK` FOREIGN KEY (`id_promotion`) REFERENCES `promotion` (`id_promotion`),
  ADD CONSTRAINT `utilisateur_role0_FK` FOREIGN KEY (`id_role`) REFERENCES `role` (`id_role`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
