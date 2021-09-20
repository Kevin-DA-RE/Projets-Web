
use greta;

--
-- Insertion Rôle
--

 INSERT INTO `role` (`id_role`, `nom_role`) VALUES
 (1, 'Administrateur'),
 (2, 'Professeur'),
 (3, 'Etudiant');

--
-- Insertion Promotion
--

INSERT INTO `promotion` (`id_promotion`, `nom_promotion`, `date_debut`, `date_fin`) VALUES
(1, 'CDA-1', '2020-09-07', '2021-04-21'),
(2, 'CDA-2', '2021-01-10', '2021-01-11'),
(4, 'IPM', '2021-01-11', '2021-01-18'),
(5, 'ipm', '2021-01-11', '2021-01-18'),
(6, 'TU', '2021-01-25', '2021-02-08');



-- Insertion Site Utilisateur
--


INSERT INTO `utilisateur` (`id_utilisateur`, `nom_utilisateur`, `prenom_utilisateur`, `num_rue_utilisateur`, `nom_rue_utilisateur`, `code_postal_utilisateur`, `ville_utilisateur`, `telephone_utilisateur`, `email_utilisateur`,  `password`, `id_promotion`, `id_role`) VALUES
(1, 'Druette', 'Sandie', 13, 'avenue', 21000, 'chenove', '0303030303', 'zvzeve@gmail.com', NULL, NULL, 1),
(2, 'Mallet', 'Fatima', 16, 'boulevard', 25000, 'juilly', '0606060606', 'eiovbnezpov@gmail.com', NULL, NULL, 1),
(3, 'Klistinec', 'Laurence', 14, 'test', 21000, 'dijon', '0202020202', 'test@gmail.com', NULL, NULL, 1),
(4, 'Van Assel', 'Laurent', 18, 'test', 21000, 'test', '0202020202', 'test@gmail.com', NULL, NULL, 2),
(5, 'Mehl', 'Guy', 30, 'test', 24410, 'test', '0505050505', 'test@gmail.com', NULL, NULL, 2),
(6, 'Saxe', 'Dominique', 18, 'test', 50000, 'test', '0404040404', 'test@gmail.com', NULL, NULL, 2),
(7, 'Thevenot', 'Delphine', 8, 'test', 30000, 'test@gmail.com', '0606060606', 'test@gmail.com', NULL, NULL, 2),
(8, 'Villerot', 'Michael', 20, 'test', 14000, 'test', '0404040404', 'test@gmail.com', NULL, NULL, 2),
(13, 'Arcidiaco', 'Axel', 1, 'test', 2100, 'test', '03030303', 'test@gmail.com', NULL, NULL, 3);


--
-- Insertion Formation`
--
INSERT INTO `formation` (`id_formation`, `intitule_formation`, `detail_formation`, `type_formation`, `categorie_formation`, `volume_horaire_centre`, `volume_horaire_stage`) VALUES
(1, 'Concepteur Développeur d\'Applications', 'Acquérir la maîtrise de la programmation d\'au moins deux langages objets (Java, C#, PHP, C++)\nSavoir concevoir et exploiterune base de données (ORacle, SQL Server, MySQL, PostGreSQL?)\nSavoir développer des composants d\'accès aux données\nAcquérir la maîtrise de toutes les composantes du développement d\'un site Web et d\'une application de A a A:\n- Ergonomie (UI,UX?), aspects client et intègre on (HTML5, CSS3, Javascript?), programmation coté serveur.\n- Acquérir la maîtrise de toutes les composantes du développement mobile: (IOS, Android) et multi-plateforme.\n- Savoir intégrer les bonnes pratiques et la méthodologie du développement securisé des applications.\n- Comprendre et connaître les bases de la gestion de projet Web et Mobile.\n- Acquérir une culture générale de l\'environnement Big Data: Hadoop, Map Reduce, base de données NOSQL et le langage de programmation.\nA l\'issue de ce parcours, les stagiaires sauront notamment:\n- Concevoir des applications objets, en utilisant le langage de modélisation Merise.\n- Développer des interfaces Web ou mobiles.\n- Développer des applications métiers en utilisant le langage Java et la plateforme d\'entreprise Java EE.\n- Travailler dans un environnement professionnel: utilisation d\'IDE, d\'outils de gestion de version d\'outils de build, d\'outils de tests.\n- Mettre en oeuvre le framework Spring\n', 'Titre Professionnel', 'Informatique', 707, 385);


-- Insertion Activite Type

INSERT INTO `activite_type` (`id_act_type`, `num_act_type`, `nom_act_type`, `id_formation`) VALUES
(1, 1, 'Concevoir et développer des composants d\'interface utilisateur en intégrant les recommandations de sécurité', 1),
(2, 2, 'Concevoir et développer la persistance des données en intégrant les recommandations de sécurité', 1),
(3, 3, 'Concevoir et développer une application multicouche répartie en intégrant les recommandations de sécurité', 1);


-- Insertion Competence

INSERT INTO `competence` (`id_competence`, `nom_competence`, `code_competence`, `id_act_type`) VALUES
(31, 'Maquetter une application', 'CP01', 1),
(32, 'Développer une interface utilisateur de type desktop', 'CP02', 1),
(33, 'Développer des composants d’accès aux données', 'CP03', 1),
(34, 'Développer la partie front-end d’une interface utilisateur web', 'CP04', 1),
(35, 'Développer la partie back-end d’une interface utilisateur web', 'CP05', 1),
(36, 'Concevoir une base de données', 'CP06', 2),
(37, 'Mettre en place une base de données', 'CP07', 2),
(38, 'Développer des composants dans le langage d’une base de données', 'CP08', 2),
(39, 'Collaborer à la gestion d’un projet informatique et à l’organisation de l’environnement de développement', 'CP09', 3),
(40, 'Concevoir une application', 'CP10', 3),
(41, 'Développer des composants métier', 'CP11', 3),
(42, 'Construire une application organisée en couches', 'CP12', 3),
(43, 'Développer une application mobile', 'CP13', 3),
(44, 'Préparer et exécuter les plans de tests d’une application', 'CP14', 3),
(45, 'Préparer et exécuter le déploiement d’une application', 'CP15', 3);








-- ---------------------------
-- Insertion Organisme Formation`
--

INSERT INTO `organisme_formation` (`id_organisme`, `siret_organisme`, `nom_organisme`, `num_organisme`, `rue_organisme`, `code_postal_organisme`, `ville_organisme`, `telephone_organisme`, `email_organisme`) VALUES
(1, 211921001, 'Lycée Hippolyte Fontaine', 20, 'Boulevard Voltaire', 21000, 'Dijon', '0380383600', 'lycee.hippolyte@gmail.com');





-- Insertion Site Formation
--

INSERT INTO `site_formation` (`id_site`, `nom_site`, `num_site`, `rue_site`, `code_postal_site`, `ville_site`, `telephone_site`, `email_site`, `id_organisme`) VALUES
(1, 'Lycée Les Marcs d\'Or', 24, ' Chemin du Fort de la Motte Giron', 21000, 'Dijon', ' 03 80 54 38 43', 'agencecom.greta21@ac-dijon.fr', 1),
(2, 'Lycée E.J. Marey', 5, 'Rue du 5ème Chasseurs', 21200, 'Beaune', '03 80 24 83 24', 'agencecom.greta21@ac-dijon.fr', 1),
(3, 'Lycée Clos Maire', 4, 'Rue des Rôle', 21200, 'Beaune', '', '', 1),
(4, 'Pôle Régional des Industries Graphiques', 6, 'Av de Bensheim', 21200, 'Beaune', '', '', 1),
(5, 'Lycée Eugène Guillaume', 12, 'Avenue Maréchal de Lattre de Tassigny', 21500, 'Montbard', '03 80 89 90 30', 'agencecom.greta21@ac-dijon.fr', 1),
(6, 'GRETA 21', 9, 'Rue des Perdrix', 21140, 'Semur-en-Auxois', '03 80 92 41 21', 'agencecom.greta21@ac-dijon.fr', 1),
(7, 'Pôle d’Excellence Travaux Publics', 16, 'Rue du Creux Moroland', 21600, 'Fenay', '03 80 36 66 98', 'agencecom.greta21@ac-dijon.fr', 1),
(8, 'Lycée Antoine', 5, 'rue de Longvic', 21300, 'Chenôve', '03 80 54 39 00', 'agencecom.greta21@ac-dijon.fr', 1),
(9, 'Lycée des Marcs d’Or ', 24, 'Chemin du Fort de la Motte Giron', 21000, 'Dijon', '03 80 54 38 43', 'agencecom.greta21@ac-dijon.fr', 1),
(10, 'Lycée Eiffel', 15, 'Avenue Champollion', 21000, 'Dijon', '03 80 44 90 41', 'agencecom.greta21[a]ac-dijon.fr', 1),
(11, 'Lycée « Le Castel » ', 5, 'rue Daubenton', 21000, 'Dijon', 'Tel. 03 80 59 61 80', 'agencecom.greta21@ac-dijon.fr', 1);

--
-- Insertion Salle
--

INSERT INTO `salle` (`id_salle`, `nom_salle`, `numero_salle`, `batiment_salle`, `id_site`) VALUES
(1, 'Salle Napoleon', 212, '13', 1);

--

-- ------------------------------
-- Insertion Evenement
--

INSERT INTO `evenement` (`id_evenement`, `titre`, `type`, `date_debut`, `date_fin`, `heure_debut`, `heure_fin`, `visio`, `id_promotion`, `id_utilisateur`, `id_salle`, `id_competence`) VALUES
(1, 'Php', 'cours', '2020-12-23', '2020-12-23', '08:00:00', '12:00:00', 'N', 1, 6, 1, 40),
(3, 'php', '', '2020-12-24', '2020-12-24', '08:00:00', '12:00:00', '', 1, 1, 1, 39),
(4, 'html', '', '2020-12-24', '2020-12-24', '10:00:00', '12:00:00', '', 1, 1, 1, 39),
(5, 'php', '', '2020-12-24', '2020-12-24', '08:00:00', '12:00:00', '', 1, 1, 1, 39);
--------------------

