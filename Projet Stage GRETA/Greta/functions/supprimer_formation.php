<?php

include("BDD/bdd.php");
$dbh = connexion();

if (isset($_GET["id"])) {
    $id = $_GET["id"];
    delete_formation($dbh, $id);
    header('Location:formations.php');
} else {
    header('Location:formations.php');
    exit();
}
