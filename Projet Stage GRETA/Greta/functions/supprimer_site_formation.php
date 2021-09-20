<?php

include("BDD/bdd.php");
$dbh = connexion();

if (isset($_GET["id"])) {
    $id = $_GET["id"];
    delete_site($dbh, $id);
    header('Location:sites_formation.php');
} else {
    header('Location:sites_formation.php');
    exit();
}