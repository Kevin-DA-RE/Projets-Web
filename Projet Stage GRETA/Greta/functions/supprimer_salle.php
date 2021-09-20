<?php

include("BDD/bdd.php");
$dbh = connexion();

if (isset($_GET["id"])) {
    $id = $_GET["id"];
    delete_salle($dbh, $id);
    header('Location:salles.php');
} else {
    header('Location:salles.php');
    exit();
}
