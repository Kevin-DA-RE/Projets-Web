<?php
require_once("./BDD/bdd.php");
$dbh = connexion();

if (isset($_POST["nom_utilisateur"])){

$id_users = $_POST["id_utilisateur"];
$nom = $_POST["nom_utilisateur"];
$prenom = $_POST["prenom_utilisateur"];
$numRue = $_POST["num_rue_utilisateur"];    
$nomRue = $_POST["nom_rue_utilisateur"];
$CP = $_POST["code_postal_utilisateur"];
$ville = $_POST["ville_utilisateur"];
$tel = $_POST["telephone_utilisateur"];
$email = $_POST["email_utilisateur"];
$idRole = $_POST["statut"];


update_user($dbh, $id_users, $nom, $prenom, $numRue, $nomRue, $CP, $ville, $tel, $email, $idRole);

header('location: listUser.php');

 } else{

     echo"Erreur lors de l'attribution des champs, revoir vos attributions des champs";
 }


?>
