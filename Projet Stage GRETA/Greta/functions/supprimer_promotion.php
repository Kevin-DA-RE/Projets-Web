<?php

include("BDD/bdd.php");
$dbh = connexion();

if (isset($_GET["id"])) {
    $id = $_GET["id"];
    delete_promotion($dbh, $id);
    header('Location:promotions.php');
} else {
    header('Location:promotions.php');
    exit();
}
