<?php

include("BDD/bdd.php");
$dbh = connexion();

if (isset($_GET["id"])) {
    $id = $_GET["id"];
    delete_competence($dbh, $id);
    header('Location:formations.php');
} else {
    header('Location:formations.php');
    exit();
}