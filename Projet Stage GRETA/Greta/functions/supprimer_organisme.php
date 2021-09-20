<?php

include("BDD/bdd.php");
$dbh = connexion();

if (isset($_GET["id"])) {
    $id = $_GET["id"];
    delete_organisme($dbh, $id);
    header('Location:organismes_formation.php');
} else {
    header('Location:organismes_formation.php');
    exit();
}
