
<!--<h1>Page en maintenance, pour retourner à l'écran d'accueil veuillez cliquez <a href="../view/accueil.php">ici</a></h1>
<?php
include("BDD/bdd.php");
$dbh = connexion();

// Vérification que les champs obligatoire sont renseigné
if ((isset($_POST["intule_formation"])) && (isset($_POST["detail_formation"])) && (isset($_POST["type_formation"]))
    && (isset($_POST["categorie_formation"]))&& (isset($_POST["volume_horaire_centre"])) && (isset($_POST["volume_horaire_stage"]))) {

    $nom = $_POST["intule_formation"];
    $details = $_POST["detail_formation"];
    $type = $_POST["type_formation"];
    $categorie = $_POST["categorie_formation"];
    $volume_horaire_centre = $_POST["volume_horaire_centre"];
    $volume_horaire_stage = $_POST["volume_horaire_stage"];

    insert_formation($dbh, $nom, $details, $type, $categorie, $volume_horaire_centre, $volume_horaire_stage);
    header("Location:atelierCreat.php"); // Dans le cas où l'utilisateur est enregistré sans erreurs
} else {
    // Si l'une des valeurs demandées est vide l'utilisateur est renvoyé sur le formulaire  
    header("Location:form_ajouter_utilisateur.php");
    exit();
}
