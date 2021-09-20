<?php

include("BDD/bdd.php");
$dbh = connexion();

if (isset($_GET["id"])) {
    $id = $_GET["id"];
    delete_activite_type($dbh, $id);
    header('Location:roles.php');
} else {
    header('Location:roles.php');
    exit();
}
