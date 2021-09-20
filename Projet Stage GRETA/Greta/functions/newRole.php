<?php

/*if (!empty($_POST["nom_role"]) == true)
{
    $nom_role = $_POST["nom_role"];

    echo " les données envoyé sont ". $nom_role ." !";

}*/


require_once("../BDD/bdd.php");

if (isset($_POST["txt-nom"]) && !empty($_POST["txt-nom"]))
{
    $nom_role = $_POST["txt-nom"];

    $dbh = connexion();
    newRole($dbh, $nom_role);
}

header("Location: ../view/message_role.php");


?>