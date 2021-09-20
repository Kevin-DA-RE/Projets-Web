<?php

include("../BDD/bdd.php");
$dbh = connexion();

if(isset($_GET["id"])) {
    $id = $_GET["id"];
    delete_utilisateur($dbh, $id);
    header('location: ../view/listUser.php');
} else {
    header('Location:utilisateurs.php');
    exit();
}