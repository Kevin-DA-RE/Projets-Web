<?php

/* * ***************************************************************************
 * Regroupement de toutes les fonctions d'accès à la base de données
 * ************************************************************************** */

/**
 * Connexion persistante au serveur
 * @return \PDO Connexion
 */
function connexion()
{
    // Définition des variables de connexion
    $user = "root";
    $pass = "mysql";
    $dsn = 'mysql:host=mysql-planing-greta-stage-cda-kevin-da-re.alwaysdata.net;dbname=greta'; //Data Source Name
    // Connexion 
    try {
        $dbh = new PDO($dsn, $user, $pass, array(
            PDO::ATTR_PERSISTENT => true,
            PDO::MYSQL_ATTR_INIT_COMMAND => 'SET NAMES \'UTF8\''
        ));  // Connexion persistante
    } catch (PDOException $e) {
        die("Erreur : " . $e->getMessage());
    }
    return $dbh;
}

/** afficherErreurSQL : 
 *  Affichage de messages lors l'accès à la bdd avec une requête SQL
 *  @param $message	: message a afficher
 *  @param $req 	: requete executée
 *  @param $dbh     : connexion PDO
 */
function afficherErreurSQL($message, $req, $dbh)
{
    echo $message . "<br />";
    echo "Requete : " . $req . "<br />";
    print_r($dbh->errorInfo());
    die();
}

// ------------------------------------------------------------------
// Fonctions d'insertion dans la base de données
// ------------------------------------------------------------------

// Insertion d'un nouveau utilisateur
function insert_user($dbh, $nom, $prenom, $num_rue, $nom_rue, $code_postal, $ville, $telephone, $email, $role)
{
    $sql = "INSERT INTO utilisateur (`nom_utilisateur`, `prenom_utilisateur`, `num_rue_utilisateur`, `nom_rue_utilisateur`, `code_postal_utilisateur`, `ville_utilisateur`, `telephone_utilisateur`, `email_utilisateur`, `id_promotion`, `id_role`) VALUES ('$nom', '$prenom', $num_rue, '$nom_rue', '$code_postal', '$ville', '$telephone', '$email', NULL, '$role');";
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de l'ajout d'un utilisateur.", $sql, $dbh);
    }
}

// Insertion d'un nouveau rôle d'utilisateur
function newRole($dbh, $nom_role) {
    $sql = "INSERT INTO `role`(`nom_role`) VALUES ('$nom_role');";
    $result = $dbh->exec($sql);
    if ($result === false){
       afficherErreurSQL("Erreur lors de la requette ! ", $sql, $dbh);
    }
}


// Insertion d'une nouvelle promotion de stagiaires
function insert_promotion($dbh, $nom, $date_debut, $date_fin)
{
    $sql = "INSERT INTO  promotion (`nom_promotion`, `date_debut`, `date_fin`) VALUES ('$nom', $date_debut, $date_fin);";
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de l'ajout d'une promotion.", $sql, $dbh);
    }
}

// Insertion d'un nouveau organisme de formation
function insert_organisme($dbh, $siret, $nom, $num_rue, $nom_rue, $code_postal, $ville, $telephone, $email)
{
    $sql = "INSERT INTO organisme_formation (`siret_organisme`, `nom_organisme`, `num_organisme`, `rue_organisme`, `code_postal_organisme`, `ville_organisme`, `telephone_organisme`, `email_organisme`) VALUES ( '$siret', '$nom', '$num_rue', '$nom_rue', '$code_postal', '$ville', '$telephone', '$email');";
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de l'ajout d'un organisme de formation.", $sql, $dbh);
    }
}

// Insertion d'un nouveau site de formation
function insert_site($dbh, $nom, $num_rue, $nom_rue, $code_postal, $ville, $telephone, $email, $id_organisme)
{
    $sql = "INSERT INTO site_formation (`nom_site`, `num_site`, `rue_site`, `code_postal_site`, `ville_site`, `telephone_site`, `email_site`, `id_organisme`) VALUES ('$nom', '$num_rue', '$nom_rue', '$code_postal', '$ville', '$telephone', '$email', '$id_organisme');";
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de l'ajout d'un site de formation.", $sql, $dbh);
    }
}

// Insertion d'une nouvelle salle de cours
function insert_salle($dbh, $nom, $numero, $batiment, $id_site)
{
    $sql = "INSERT INTO salle (`nom_salle`, `numero_salle`, `batiment_salle`, `id_site`) VALUES ('$nom', '$numero', '$batiment', '$id_site');";
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de l'ajout d'une salle.", $sql, $dbh);
    }
}

// Insertion d'une nouvelle formation
function insert_formation($dbh, $nom, $details, $type, $categorie, $volume_horaire_centre, $volume_horaire_stage)
{
    $sql = "INSERT INTO formation (`intitule_formation`, `detail_formation`, `type_formation`, `categorie_formation`, `volume_horaire_centre`, `volume_horaire_stage`) VALUES ('$nom', '$details', '$type', '$categorie', '$volume_horaire_centre', '$volume_horaire_stage');";
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de l'ajout d'une formation.", $sql, $dbh);
    }
}

// Insertion d'une nouvelle activité type lié à une formation

function insert_activite($dbh, $num_activite, $nom_activite, $id_formation)
{
    $sql = "INSERT INTO activite_type (`num_act_type`, `nom_act_type`, `id_formation`) VALUES ($num_activite, '$nom_activite', $id_formation);";
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de l'ajout d'une activité type à une formation.", $sql, $dbh);
    }
}

// Insertion d'une compétence professionnelle lié à une activité type
function insert_competence($dbh, $nom_competence, $code_competence, $id_activite)
{
    $sql = "INSERT INTO competence (`nom_competence`, `code_competence`, `id_act_type`) VALUES ('$nom_competence', '$code_competence', '$id_activite');";
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de l'ajout d'une compétence professionnelle à une activité type.", $sql, $dbh);
    }
}

// Insertion d'un nouvel évenement à l'emploi du temps
function insert_evenement($dbh, $titre, $type, $date_debut, $date_fin, $heure_debut, $heure_fin, $visio, $id_promotion, $id_utilisateur, $id_salle, $id_competence)
{
    $sql = "INSERT INTO evenement (`titre`, `type`, `date_debut`, `date_fin`, `heure_debut`, `heure_fin`, `visio`, `id_promotion`, `id_utilisateur`, `id_salle`, `id_competence`) VALUES ('$titre', '$type', '$date_debut', '$date_fin', '$heure_debut', '$heure_fin', '$visio', '$id_promotion', '$id_utilisateur', '$id_salle', '$id_competence');";
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de l'ajout d'un nouvel évenement à l'emploi du temps.", $sql, $dbh);
    }
}

// Liason d'une formation avec un site de formation qui l'accueil
function insert_accueillir($dbh, $id_formation, $id_site)
{
    $sql = "INSERT INTO accueillir (`id_formation`, `id_site`) VALUES ('$id_formation', '$id_site');";
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la liason entre une formation et un site de formation qui l'accueil.", $sql, $dbh);
    }
}

// Liason d'une formation avec un organisme de formation qui la propose
function insert_proposer($dbh, $id_organisme, $id_formation)
{
    $sql = "INSERT INTO proposer (`id_organisme`, `id_formation`) VALUES ('$id_organisme', '$id_formation');";
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la liason entre une formation et un organisme de formation qui la propose.", $sql, $dbh);
    }
}

// ------------------------------------------------------------------
// Fonctions de mise à jour des informations de la base de données
// ------------------------------------------------------------------

// Mise à jour d'un utilisateur
function update_user($dbh, $id_users, $nom, $prenom, $numRue, $nomRue, $CP, $ville, $tel, $email, $idRole){
    $sql ="UPDATE `utilisateur` SET `nom_utilisateur`= '$nom', `prenom_utilisateur`='$prenom', `num_rue_utilisateur`=$numRue, `nom_rue_utilisateur`='$nomRue', `code_postal_utilisateur`= $CP, `ville_utilisateur`='$ville',`telephone_utilisateur`= $tel, `email_utilisateur`= '$email', `id_role`= $idRole WHERE `id_utilisateur`= $id_users;";
    $result = $dbh -> exec($sql);
    if ($result == false) {
        afficherErreurSQL("Erreur lors de la requête", $sql, $dbh);
    }
}
// Mise à jour d'un rôle d'utilisateur
function update_role($dbh, $idRole, $role)
{
    // Requête de mise à jour d'un rôle d'utilisateur
    $sql = "UPDATE role SET nom_role = '$role' WHERE id_role = $idRole;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la mise à jour du rôle d'utilisateur.", $sql, $dbh);
    }
}

// Mise à jour d'une promotion
function update_promotion($dbh, $id_promotion, $nom, $date_debut, $date_fin)
{
    // Requête de mise à jour d'une promotion
    $sql = "UPDATE promotion SET
        nom_promotion = '$nom',
        date_debut = $date_debut,
        date_fin = $date_fin
    WHERE id_promotion = $id_promotion;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la mise à jour de la promotion.", $sql, $dbh);
    }
}

// Mise à jour d'un organisme de formation
function update_organisme($dbh, $id_organisme, $siret, $nom, $num_rue, $nom_rue, $code_postal, $ville, $telephone, $email)
{
    // Requête de mise à jour d'un organisme de formation
    $sql = "UPDATE organisme_formation SET
        siret_organisme = $siret,
        nom_organisme = '$nom',
        num_organisme = $num_rue,
        rue_organisme = '$nom_rue',
        code_postal_organisme = $code_postal,
        ville_organisme = '$ville',
        telephone_organisme = '$telephone',
        email_organisme = '$email'
    WHERE id_organisme = $id_organisme;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la mise à jour de l'organisme de formation.", $sql, $dbh);
    }
}

// Mise à jour d'un site de formation
function update_site($dbh, $id_site, $nom, $num_rue, $nom_rue, $code_postal, $ville, $telephone, $email, $id_organisme)
{
    // Requête de mise à jour d'un site de formation
    $sql = "UPDATE site_formation SET
        nom_site = '$nom',
        num_site = $num_rue,
        rue_site = '$nom_rue',
        code_postal_site = $code_postal,
        ville_site = '$ville',
        telephone_site = '$telephone',
        email_site = '$email',
        id_organisme = $id_organisme
    WHERE id_site = $id_site;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la mise à jour du site de formation.", $sql, $dbh);
    }
}

// Mise à jour d'une salle de cours
function update_salle($dbh, $id_salle, $nom_salle, $numero_salle, $batiment, $id_site)
{
    // Requête de mise à jour d'une salle de cours
    $sql = "UPDATE salle SET
        nom_salle = '$nom_salle',
        numero_salle = $numero_salle,
        batiment = '$batiment',
        id_site = $id_site
    WHERE id_salle = $id_salle;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la mise à jour d'une salle de cours.", $sql, $dbh);
    }
}

// Mise à jour à d'une formation
function update_formation($dbh, $id_formation, $intitule_formation, $detail_formation, $type_formation, $categorie_formation, $volume_horaire_centre, $volume_horaire_stage)
{
    // Requête de mise jour d'une formation
    $sql = "UPDATE formation SET
        intitule_formation = '$intitule_formation',
        detail_formation = '$detail_formation',
        type_formation = '$type_formation',
        categorie_formation = '$categorie_formation',
        volume_horaire_centre = $volume_horaire_centre,
        volume_horaire_stage = $volume_horaire_stage
    WHERE id_formation = $id_formation;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la mise à jour d'une formation.", $sql, $dbh);
    }
}

// Mise à jour d'une activité type
function update_activite($dbh, $id_act_type, $num_act_type, $nom_act_type, $id_formation)
{
    // Requête de mise jour d'une activité type
    $sql = "UPDATE activite_type SET
        num_act_type = $num_act_type,
        nom_act_type = '$nom_act_type',
        id_formation = $id_formation
    WHERE id_act_type = $id_act_type;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la mise à jour d'une activité type.", $sql, $dbh);
    }
}

// Mise à jour d'une compétence professionnelle
function update_competence($dbh, $id_competence, $nom_competence, $code_competence, $id_act_type)
{
    // Requête de mise jour d'une compétence professionnelle
    $sql = "UPDATE activite_type SET
        nom_competence = '$nom_competence',
        code_competence = '$code_competence',
        id_act_type = $id_act_type
    WHERE id_competence = $id_competence;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la mise à jour d'une compétence professionnelle.", $sql, $dbh);
    }
}

// Modification d'une liason d'une formation avec un site de formation qui l'accueil
function update_accueillir($dbh, $id_formation, $id_site, $new_id_formation, $new_id_site)
{
    // Requête de mise à jour d'une liason d'une formation avec un site de formation qui l'accueil
    $sql = "UPDATE accueillir SET
        id_formation = $new_id_formation,
        id_site = $new_id_site
    WHERE id_formation = $id_formation AND id_site = $id_site;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la mise à jour d'une liason d'une formation avec un site de formation qui l'accueil.", $sql, $dbh);
    }
}

// Modification d'une liason d'une formation avec un organisme de formation qui la propose
function update_proposer($dbh, $id_formation, $id_organisme, $new_id_formation, $new_id_organisme)
{
    // Requête de mise à jour d'une liason d'une formation avec un organisme de formation qui la propose
    $sql = "UPDATE proposer SET
        id_formation = $new_id_formation,
        id_organisme = $new_id_organisme
    WHERE id_formation = $id_formation AND id_organisme = $id_organisme;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la mise à jour d'une liason d'une formation avec un organisme de formation qui la propose.", $sql, $dbh);
    }
}

// Modification d'un événement du calendrier
function update_evenement($dbh, $id_evenement, $titre, $type, $date_debut, $date_fin, $heure_debut, $heure_fin, $visio, $id_promotion, $id_utilisateur, $id_salle, $id_competence)
{
    // Requête de mise à jour d'un événement du calendrier
    $sql = "UPDATE evenement SET
        titre = '$titre',
        type = '$type',
        date_debut = $date_debut,
        date_fin = $date_fin,
        heure_debut = $heure_debut,
        heure_fin = $heure_fin,
        visio = '$visio',
        id_promotion = $id_promotion,
        id_utilisateur = $id_utilisateur,
        id_salle = $id_salle,
        id_competence = $id_competence
    WHERE id_evenement = $id_evenement;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la mise à jour d'un événement du calendrier.", $sql, $dbh);
    }
}

// ------------------------------------------------------------------
// Fonctions de sélection des informations de la base de données
// ------------------------------------------------------------------

// Requêtes de sélection sur la table utilisateur //

function select_Users($dbh) {
    $sql = "SELECT `id_utilisateur`, `nom_utilisateur`,`prenom_utilisateur`, CONCAT(`num_rue_utilisateur`,' ',`nom_rue_utilisateur`,' ',`code_postal_utilisateur`,' ',`ville_utilisateur`) AS adresse, role.nom_role AS statut FROM utilisateur INNER JOIN role ON utilisateur.id_role=role.id_role";
    $result = $dbh -> query($sql);
    if ($result == false) {
        afficherErreurSQL("Erreur lors de la requête", $sql, $dbh);
    }
    return $result;
}

// Fonction permettant de récupérer la liste des utilisateur
function select_User($dbh, $id) {
    $sql = "SELECT `id_utilisateur`, `nom_utilisateur`, `prenom_utilisateur`,CONCAT(`num_rue_utilisateur`,' ', `nom_rue_utilisateur`) AS coordonnees,`code_postal_utilisateur`, `ville_utilisateur`, `telephone_utilisateur`, `email_utilisateur`, role.nom_role AS role FROM `utilisateur` INNER JOIN role ON utilisateur.id_role=role.id_role WHERE `id_utilisateur`= $id";
    $result = $dbh -> query($sql);
    if ($result == false) {
        afficherErreurSQL("Erreur lors de la requête", $sql, $dbh);
    }
    return $result;
}


// Fonction permettant de récupérer les utilisateurs possédant un rôle donné
function select_utilisateur_by_role($dbh, $id_role)
{
    // Requête de séléction des utilisateurs en fonction de leur rôle
    $sql = "SELECT * FROM `utilisateur` WHERE `id_role` = $id_role ORDER BY `nom_utilisateur`, `prenom_utilisateur`;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des utilisateurs en fonction de leur rôle.", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer la liste des utilisateur selon le format nom, prénom, adresse, téléphone, email, rôle(nom), & promotion(nom)
function select_utilisateur_role_promotion($dbh)

{
    // Requête formatée de séléction des utilisateurs
    $sql = "SELECT `id_utilisateur`,`nom_utilisateur`, `prenom_utilisateur`, 
            CONCAT(`num_rue_utilisateur`, ' ', `nom_rue_utilisateur`, ', ', `code_postal_utilisateur`, ' ', `ville_utilisateur`) 
            AS adresse, `telephone_utilisateur`, `email_utilisateur`, promotion.nom_promotion AS promotion, role.nom_role AS role 
            FROM `utilisateur` LEFT JOIN promotion ON utilisateur.id_promotion=promotion.id_promotion 
            LEFT JOIN role ON utilisateur.id_role=role.id_role 
            ORDER BY utilisateur.id_utilisateur;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des utilisateurs.", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer la liste des stagiaires d'une promotion
function select_utilisateur_by_promotion($dbh, $id_promotion)
{
    // Requête permettant de récupérer la liste des stagiaires d'une promotion
    $sql = "SELECT `id_utilisateur`,`nom_utilisateur`, `prenom_utilisateur`, 
    CONCAT(`num_rue_utilisateur`, ' ', `nom_rue_utilisateur`, ', ', `code_postal_utilisateur`, ' ', `ville_utilisateur`) 
    AS adresse, `telephone_utilisateur`, `email_utilisateur` FROM utilisateur WHERE `id_promotion` = $id_promotion;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des utilisateurs.", $sql, $dbh);
    }
    return $resultat;
}


// Requêtes sur la table role //
// Fonction permettant de récupérer la liste des rôles d'utilisateur
function select_role($dbh)
{
    // Requête de sélection de tous les rôles
    $sql = "SELECT * FROM role;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des rôles.", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer un rôle d'utilisateur précis
function select_role_by_nom($dbh, $nom_role)
{
    // Requête de sélection d'un rôle
    $sql = "SELECT * FROM role WHERE nom_role = $nom_role;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des rôles.", $sql, $dbh);
    }
    return $resultat;
}

// Requêtes sur la table promotion //
// Fonction permettant de récupérer la liste des promotions
function select_promotion($dbh)
{
    // Requête de sélection de toutes les promotions
    $sql = "SELECT * FROM promotion;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des promotions.", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer une promotion par son id
function select_promotion_by_id($dbh, $id)
{
    // Requête de sélection de toutes les promotions
    $sql = "SELECT * FROM promotion WHERE `id_promotion` = $id;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des promotions.", $sql, $dbh);
    }
    return $resultat;
}


// Requêtes de sélection sur la table organisme_formation //
// Fonction permettant de récupérer la liste des organismes de formation
function select_organisme($dbh)
{
    // Requête de sélection des organismes de formation
    $sql = "SELECT `id_organisme`, `siret_organisme`, `nom_organisme`, CONCAT(`num_organisme`, ' ',`rue_organisme`, ', ', `code_postal_organisme`, ' ', `ville_organisme`) AS adresse, `telephone_organisme`, `email_organisme` FROM organisme_formation ORDER BY nom_organisme;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des organismes de formation.", $sql, $dbh);
    }
    return $resultat;
}


// Requêtes de sélection sur la table site_formation //
// Fonction permettant de récupérer la liste des sites de formation
function select_site_formation($dbh)
{
    // Requête de sélection des sites de formation
    $sql = "SELECT *  FROM site_formation;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des site de formation", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer la liste des sites de formation
function select_site_formation_by_id($dbh, $id)
{
    // Requête de sélection des sites de formation
    $sql = "SELECT * FROM site_formation WHERE `id_site` = $id;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des site de formation", $sql, $dbh);
    }
    return $resultat;
}


// Requêtes de sélection sur la table salle //
// Fonction permettant d'obtenir la liste des salles enregistrées dans la base de données
function select_salle($dbh)
{
    // Requête de sélection de toutes les salles
    $sql = "SELECT * FROM salle;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des salles", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer les salles d'un site de formation
function select_site_salles_by_nom($dbh, $nom_site)
{
    // Requête de sélection des salles d'un site site de formation
    $sql = "SELECT * FROM salle INNER JOIN site_formation ON salle.id_site = site_formation.id_site WHERE nom_site = $nom_site;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des salles d'un site de formation.", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer les salles d'un bâtiment d'un site de formation
function select_salle_by_batiment($dbh, $batiment, $nom_site)
{
    // Requête de sélection des salles d'un bâtiment d'un site site de formation
    $sql = "SELECT * FROM salle INNER JOIN site_formation ON salle.id_site = site_formation.id_site WHERE nom_site = $nom_site AND salle.batiment_salle = $batiment;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des salles du bâtiment $batiment.", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer les salles d'un bâtiment d'un site de formation
function select_salle_by_id_site($dbh, $id_site)
{
    // Requête de sélection des salles d'un bâtiment d'un site site de formation
    $sql = "SELECT `id_salle`, `nom_salle`, `numero_salle`, `batiment_salle`, `id_site` FROM `salle` WHERE `id_site` = $id_site;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des salles du site de formation.", $sql, $dbh);
    }
    return $resultat;
}

// Requete selectionnant toutes les formations
function selectFormation($dbh){
    // Requete affichant toutes les formations disponibles
    $sql = "SELECT * FROM formation;";
    $resultat = $dbh->query($sql);
    //Execution de la requete
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des formations.", $sql, $dbh);
    }
    return $resultat;

}
// Requête de sélection sur la table formation //
// Fonction permettant de récupérer la liste des formations
function select_formation_by_site_formation($dbh)
{
    // Requête de sélection des formations avec le nom des organismes qui les proposent et les sites qui les accueillent
    $sql = "SELECT formation.id_formation, `intitule_formation`, `detail_formation`, `type_formation`, `categorie_formation`, 
            `volume_horaire_centre`, `volume_horaire_stage`, site_formation.nom_site AS site, 
            organisme_formation.nom_organisme AS organisme FROM `formation` 
            LEFT JOIN accueillir ON formation.id_formation = accueillir.id_formation
            LEFT JOIN site_formation ON accueillir.id_site = site_formation.id_site
            LEFT JOIN proposer ON formation.id_formation = proposer.id_formation
            LEFT JOIN organisme_formation ON proposer.id_organisme = organisme_formation.id_organisme
            ORDER BY `intitule_formation`;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des formations.", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer la liste des formations à un organisme de formation
function select_formation_order_by_organisme($dbh, $nom_organisme)
{
    // Requête de sélection des formations en fonction d'un organisme de formation donné
    $sql = "SELECT id_formation, intitule_formation, detail_formation, type_formation, categorie_formation, 
            volume_horaire_centre, volume_horaire_stage, organisme_formation.nom_organisme, site_formation.nom_site 
            FROM formation INNER JOIN proposer ON formation.id_formation = proposer.id_formation
            INNER JOIN organisme_formation ON proposer.id_organisme = organisme_formation.id_organisme
            INNER JOIN centre_formation ON organisme_formation.id_organisme = site_formation.id_organisme
            WHERE organisme_formation.nom_organisme = $nom_organisme ORDER BY intitule_formation;";
    // Execution de la requête
    $resultat = $dbh->query($dbh);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des formations.", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer la liste des formations lié à un site de formation
function select_formation_by_site($dbh, $nom_site)
{
    // Requête de sélection des formations en fonction d'un site de formation donné
    $sql = "SELECT id_formation, intitule_formation, detail_formation, type_formation, categorie_formation, 
            volume_horaire_centre, volume_horaire_stage, organisme_formation.nom_organisme, site_formation.nom_site 
            FROM formation INNER JOIN proposer ON formation.id_formation = proposer.id_formation
            INNER JOIN organisme_formation ON proposer.id_organisme = organisme_formation.id_organisme
            INNER JOIN centre_formation ON organisme_formation.id_organisme = site_formation.id_organisme
            WHERE site_formation.nom_site = $nom_site ORDER BY intitule_formation;";
    // Execution de la requête
    $resultat = $dbh->query($dbh);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des formations.", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer la liste des formations en fonction d'un nom de formation donné
function select_formation_by_id($dbh, $id_formation)
{
    // Requête de sélection des formations en fonction d'un nom de formation donné
    $sql = "SELECT `id_formation`, `intitule_formation`, `detail_formation`, `type_formation`, `categorie_formation`, `volume_horaire_centre`, `volume_horaire_stage` FROM formation WHERE `id_formation` = $id_formation;";
    // Execution de la requête
    $resultat = $dbh->query($dbh);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des formations.", $sql, $dbh);
    }
    return $resultat;
}


// Requête sur la table activite_type
// Fonction permettant de récupérer la liste des activités type
function select_activite_type($dbh)
{
    // Requête de sélection des activités type
    $sql = "SELECT * FROM activite_type;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat) {
        afficherErreurSQL("Pb lors de la recherche des activités type", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer la liste des activités type d'une formation
function select_activite_type_by_formation($dbh, $id_formation)
{
    // Requête de sélection des activités type d'une formation
    $sql = "SELECT * FROM activite_type INNER JOIN formation ON activite_type.id_formation = formation.id_formation 
            WHERE formation.id_formation = $id_formation;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des activités type d'une formation", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer la ou les activités type selon un nom donné
function select_activite_type_by_nom($dbh, $nom_act_type)
{
    // Requête de sélection des activités type
    $sql = "SELECT formation.intitule_formation, num_act_type, nom_act_type FROM activite_type 
            WHERE nom_act_type = $nom_act_type ORDER BY nom_act_type;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des activités type selon un nom donné", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer la liste des activités type d'une formation
function select_activite_type_by_formation_nom($dbh, $intitule_formation, $nom_act_type)
{
    // Requête de sélection des activités type d'une formation
    $sql = "SELECT formation.intitule_formation, num_act_type, nom_act_type FROM activite_type 
            INNER JOIN formation ON activite_type.id_formation = formation.id_formation 
            WHERE formation.intitule_formation = $intitule_formation AND nom_act_type = $nom_act_type;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des activités type selon une formation et un nom d'activité type donné", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer la ou les activités type selon un numéro donné
function select_activite_type_by_num($dbh, $num_act_type)
{
    // Requête de sélection des activités type
    $sql = "SELECT formation.intitule_formation, num_act_type, nom_act_type FROM activite_type 
            WHERE num_act_type = $num_act_type ORDER BY nom_act_type;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des activités type selon un nom donné", $sql, $dbh);
    }
    return $resultat;
}

// Fonction permettant de récupérer la liste des activités type d'une formation selon un numéro donné
function select_activite_type_by_formation_num($dbh, $intitule_formation, $num_act_type)
{
    // Requête de sélection des activités type d'une formation
    $sql = "SELECT formation.intitule_formation, num_act_type, nom_act_type FROM activite_type 
            INNER JOIN formation ON activite_type.id_formation = formation.id_formation 
            WHERE formation.intitule_formation = $intitule_formation AND num_act_type = $num_act_type;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des activités type selon une formation et un nom d'activité type donné", $sql, $dbh);
    }
    return $resultat;
}


// Requêtes sur la table competence //
// Fonction permettant de récupérer la liste des compétences d'une formation
function select_competence_by_formation($dbh, $id_formation)
{
    // Requête de sélection des compétences
    $sql = "SELECT `id_competence`, `num_competence`, `nom_competence`, `code_competence`, `desc_competence`, activite_type.nom_act_type AS activite_type FROM `competence` 
            INNER JOIN activite_type ON competence.id_act_type = activite_type.id_act_type
            INNER JOIN formation ON activite_type.id_formation = formation.id_formation 
            WHERE formation.id_formation = $id_formation;";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des compétences.", $sql, $dbh);
    }
    return $resultat;
}

// 
function select_competence_by_activite($dbh, $id_act_type) {
    // Requête de sélection des compétences
    $sql = "SELECT `id_competence`, `num_competence`, `nom_competence`, `code_competence`, `desc_competence`, `id_act_type` 
            FROM `competence` WHERE `id_act_type` = $id_act_type";
    // Execution de la requête
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des compétences.", $sql, $dbh);
    }
    return $resultat;
}


// Requêtes sur la table evenement //
// Fonction permettant de récupérer la liste des événements du calendrier
function select_evenement($dbh)
{
    // Requêtes de sélection des événements
    $sql = "SELECT `id_evenement`, `titre`, `type`, CONCAT(evenement.date_debut, ' - ', evenement.date_fin) AS dates, 
            `heure_debut`, `heure_fin`, `visio`, promotion.nom_promotion AS promotion, 
            CONCAT( utilisateur.nom_utilisateur, ' ', utilisateur.prenom_utilisateur ) AS intervenant,
            CONCAT( salle.nom_salle, ' - Salle ', salle.numero_salle ) AS salle, 
            CONCAT( competence.code_competence, ' - ', competence.nom_competence ) AS competence FROM `evenement` 
            INNER JOIN promotion ON evenement.id_promotion = promotion.id_promotion 
            INNER JOIN utilisateur ON evenement.id_utilisateur = utilisateur.id_utilisateur 
            INNER JOIN salle ON evenement.id_salle = salle.id_salle 
            INNER JOIN competence ON evenement.id_competence = competence.id_competence;";
    // Execution de la requête SQL
    $resultat = $dbh->query($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la recherche des événements du calendrier.", $sql, $dbh);
    }
    return $resultat;
}

// ------------------------------------------------------------------
// Fonctions de suppression des informations de la base de données
// ------------------------------------------------------------------

// Fonction permettant de supprimer un utilisateur
function delete_utilisateur($dbh, $id_utilisateur)
{
    // Requête de suppression d'un utilisateur
    $sql = "DELETE FROM utilisateur WHERE id_utilisateur = $id_utilisateur;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression d'un utilisateur.", $sql, $dbh);
    }
}

// Fonction permettant de supprimer un rôle
function delete_role($dbh, $id_role)
{
    // Requête de suppression d'un utilisateur
    $sql = "DELETE FROM role WHERE id_role = $id_role;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression d'un rôle.", $sql, $dbh);
    }
}

// Fonction permettant de vider une promotion de ses stagiaires
function empty_promotion($dbh, $id_promotion)
{
    // Requête de vidage de la promotion
    $sql = "UPDATE utilisateur SET id_promotion = NULL WHERE id_promotion = $id_promotion;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors du vidage de la promotion de ses stagiaires.", $sql, $dbh);
    }
}

// Fonction permettant de supprimer une promotion de la base de données
function delete_promotion($dbh, $id_promotion)
{
    // Appel de la fonction permettant de retirer tous les stagiaires d'une promotion
    empty_promotion($dbh, $id_promotion);
    // Requête de suppression d'un promotion
    $sql = "DELETE FROM promotion WHERE id_promotion = $id_promotion;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression d'une promotion.", $sql, $dbh);
    }
}

// Fonction permettant de supprimer une compétence donné
function delete_competence($dbh, $id_competence)
{
    // Requête de suppresion de la compétence donné
    $sql = "DELETE FROM competence WHERE id_competence = $id_competence;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression d'une competence.", $sql, $dbh);
    }
}

// Fonction permettant de supprimer la compétence donné
function delete_activite_type($dbh, $id_act_type)
{
    // Fonction permettant de supprimer les compétences lié à l'activité type donné
    delete_competence_by_activite($dbh, $id_act_type);
    // Requête de suppresion de l'activité type donné
    $sql = "DELETE FROM activite_type WHERE id_act_type = $id_act_type;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression d'une competence.", $sql, $dbh);
    }
}

// Fonction permettant de supprimer un formation de la base de données
function delete_formation($dbh, $id_formation)
{
    // Appel des fonctions permettant de supprimer les liens entre les table formation, accueillir, site_formation, proposer, et organisme_formation
    delete_accueillir($dbh, $id_formation, null);
    delete_proposer($dbh, $id_formation, null);
    delete_activite_type_by_formation($dbh, $id_formation);
    // Requête de suppression d'une formation
    $sql = "DELETE FROM formation WHERE id_formation = $id_formation;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression d'une formation.", $sql, $dbh);
    }
}

// 
function delete_activite_type_by_formation($dbh, $id_formation)
{
    // 
    $activites = select_activite_type_by_formation($dbh, $id_formation);
    $activite = $activites->fetch();
    while ($activite) {
        delete_competence_by_activite($dbh, $activite["id_act_type"]);
        $activite = $activites->fetch();
    }
    // Requête de suppression des activités type lié à la formation donné
    $sql = "DELETE FROM `activite_type` WHERE `id_formation` = $id_formation;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression des activités type.", $sql, $dbh);
    }
}

// Fonction permetant de supprimer les compétences liées à une activité type
function delete_competence_by_activite($dbh, $id_act_type)
{
    // Suppression des evénements liées aux compétences de l'activité type
    $comps = select_competence_by_activite($dbh, $id_act_type);
    $comp = $comps->fetch();
    while ($comp) {
        delete_evenement($dbh, null, null, null, $comp["id_act_type"]);
        $comp = $comps->fetch();
    }
    // Requête de suppression des compétences liées à l'activité donnée
    $sql = "DELETE FROM `competence` WHERE `id_act_type` = $id_act_type)";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression des compétences.", $sql, $dbh);
    }
}

// Fonction permettant de supprimer les liaisons entre :
//     - Une formation et le ou les sites de formation qui l'accueil
//     - Un site de formation et les formation qui l'accueil
function delete_accueillir($dbh, $id_formation, $id_site)
{
    $sql = "";
    // Requête de suppression de ligne(s) de la table accueillir
    if ($id_formation == null) {
        $sql = "DELETE FROM accueillir WHERE id_site = $id_site;";
    } else if ($id_site == null) {
        $sql = "DELETE FROM accueillir WHERE id_formation = $id_formation;";
    }
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression des liaisons entre une formation et le ou les sites de formation qui l'accueil ou un site de formation et les formation qui l'accueil.", $sql, $dbh);
    }
}

// Fonction permettant de supprimer les liaisons entre :
//     - Une formation et le ou les organismes de formation qui la propose
//     - Un organisme de formation et les formation qu'il propose
function delete_proposer($dbh, $id_formation, $id_organisme)
{
    $sql = "";
    // Requête de suppression de ligne(s) de la table proposer
    if ($id_formation == null) {
        $sql = "DELETE FROM proposer WHERE id_organisme = $id_organisme;";
    } else if ($id_organisme == null) {
        $sql = "DELETE FROM proposer WHERE id_formation = $id_formation;";
    }
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression des liaisons entre une formation et le ou les organismes de formation qui la propose ou un organisme de formation et les formation qu'il propose.", $sql, $dbh);
    }
}

// Fonction permettant de supprimer un organisme de formation
function delete_organisme($dbh, $id_organisme)
{
    // Appel des fonction permettant de supprimer les liens entre organisme_formation, site_formation, proposer, et formation
    delete_proposer($dbh, null, $id_organisme);
    delete_site_by_organisme($dbh, $id_organisme);
    // Requête de suppression 
    $sql = "DELETE FROM organisme_formation WHERE id_organisme = $id_organisme;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression d'un organisme de formation.", $sql, $dbh);
    }
}

// Fonction qui permet de supprimer de la base de données les sites de formation
// qui dans la base de données ont pour clé étrangère la valeur de la variable $id_organisme
function delete_site_by_organisme($dbh, $id_organisme)
{
    // Suppression des liens entre les tables site_formation, accueillir, et formation pour tous les sites de formation
    // qui dans la base de données ont pour clé étrangère la valeur de la variable $id_organisme
    $les_sites = select_site_formation($dbh);
    $un_site = $les_sites->fetch();
    while ($un_site) {
        delete_salle_by_site($dbh, $un_site["id_site"]);
        delete_accueillir($dbh, $un_site["id_site"], null);
        $un_site = $les_sites->fetch();
    }
    // Requête de suppression de la base de données des sites de formation gérer par l'organisme de formation donné
    $sql = "DELETE FROM site_formation WHERE id_organisme = $id_organisme;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression des sites de formation.", $sql, $dbh);
    }
}

// Fonction permettant de supprimer un site de formation donné
function delete_site($dbh, $id_site)
{
    // Suppression des salles lié au site de formation qui va être supprimer
    delete_salle_by_site($dbh, $id_site);
    delete_accueillir($dbh, $id_site, null);
    // Requête de suppression de la base de données du site de formation
    $sql = "DELETE FROM `site_formation` WHERE `id_site` = $id_site;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression du sites de formation.", $sql, $dbh);
    }
}

// Fonction permettant de supprimer les salles lié à un site de formation donné
function delete_salle_by_site($dbh, $id_site)
{
    // Suppression des évenements lié aux salles du site
    $les_salles = select_salle_by_id_site($dbh, $id_site);
    $une_salle = $les_salles->fetch();
    while ($une_salle) {
        delete_evenement($dbh, null, null, $une_salle["id_salle"], null);
        $une_salle = $les_salles->fetch();
    }
    // Requête de suppression des salles
    $sql = "DELETE FROM `salle` WHERE `id_site` = $id_site;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression des salles du site de formation .", $sql, $dbh);
    }
}

// 
function delete_salle($dbh, $id_salle)
{
    // Suppression des évenements lié a là salle
    delete_evenement($dbh, null, null, $id_salle, null);
    // Requête de suppression de la salle donné
    $sql = "DELETE FROM `salle` WHERE `id_salle` = $id_salle;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression des salles du site de formation .", $sql, $dbh);
    }
}

// Fonction permettant de supprimer un évenement donné
function delete_evenement_by_id($dbh, $id_evenement)
{
    // Requête permettant de supprimer un évenement donné
    $sql = "DELETE FROM evenement WHERE id_evenement = $id_evenement;";
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression d'un évenement'.", $sql, $dbh);
    }
}

// Fonction permettant de supprimer un évenement en fonction d'un id_utilisateur, ou d'un id_promotion, 
function delete_evenement($dbh, $id_utilisateur, $id_promotion, $id_salle, $id_competence)
{
    // Vérification des valeurs des variables $id_utilisateur, $id_promotion, $id_salle, $id_competence & rédaction de la requête
    if ($id_promotion == null && $id_salle == null && $id_competence == null) {
        $sql = "DELETE FROM evenement WHERE id_utilisateur = $id_utilisateur;";
    } else if ($id_utilisateur == null && $id_salle == null && $id_competence == null) {
        $sql = "DELETE FROM evenement WHERE id_promotion = $id_promotion;";
    } else if ($id_utilisateur == null && $id_promotion == null && $id_competence == null) {
        $sql = "DELETE FROM evenement WHERE id_salle = $id_salle;";
    } else if ($id_utilisateur == null && $id_promotion == null && $id_salle == null) {
        $sql = "DELETE FROM evenement WHERE id_competence = $id_competence;";
    } else {
        $sql = "";
    }
    // Execution de la requête
    $resultat = $dbh->exec($sql);
    if ($resultat === false) {
        afficherErreurSQL("Pb lors de la suppression d'un évenement'.", $sql, $dbh);
    }
}
