<?php
include("../BDD/bdd.php");
$dbh = connexion();

// Vérification que les champs obligatoire sont renseigné
if ((isset($_POST["num_act_type"])) && (isset($_POST["nom_act_type"])) && (isset($_POST["formation"]))) {

    $num_activite= $_POST["num_act_type"];
    $nom_activite = $_POST["nom_act_type"];
    $id_formation = $_POST["formation"];
    
    insert_activite($dbh, $num_activite, $nom_activite, $id_formation);
    header("Location: ../view/addActiviteType.html.php"); // Dans le cas où l'utilisateur est enregistré sans erreurs
} else {
    // Si l'une des valeurs demandées est vide l'utilisateur est renvoyé sur le formulaire  
    header("Location: ../view/message_Erreur_activite.php");
    exit();
}
