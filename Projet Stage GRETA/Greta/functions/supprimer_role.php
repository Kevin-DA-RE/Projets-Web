<?php

include("../BDD/bdd.php");
$dbh = connexion();


if (isset($_GET["id"])) {
    $id_role = $_GET["id"];
    delete_role($dbh, $id_role);
    header('location: ../view/listRoles.php');
}