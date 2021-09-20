<?php 
    include("BDD/bdd.php");
    $dbh = connexion();

    // Vérification que les champs obligatoire sont renseigné
    if((isset($_POST["site"])) && (isset($_POST["nom_salle"])) && (isset($_POST["numero_salle"])) && (isset($_POST["batiment_salle"])))
     {
        $nom = $_POST["nom_salle"];
        $numero = $_POST["numero_salle"];
        $batiment = $_POST["batiment_salle"];
        $id_site = $_POST["site"];

        insert_salle($dbh, $nom, $numero, $batiment, $id_site);
        header("Location:message_salle.php"); // Dans le cas où l'utilisateur est enregistré sans erreurs
    } else {
        // Si l'une des valeurs demandées est vide l'utilisateur est renvoyé sur le formulaire  
        echo 'Erreur lors de la saisie du nouvel utilisateur';
        header("Location:form_ajouter_utilisateur.php");
        exit();
    }
?>