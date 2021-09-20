<?php

include("BDD/bdd.php");
$dbh = connexion();

if (isset($_GET["id"])) {
    $id = $_GET["id"];
    delete_evenement_by_id($dbh, $id);
    header('Location:planning.php');
} else {
    header('Location:planning.php');
    exit();
}