<?php
include("../BDD/bdd.php"); // Inclusion de la connexion à la base de données pour toutes les pages de l'application 
$dbh = connexion();
session_start();
$name = $_SESSION['nom'];
?>
<!doctype html>
<html lang="fr">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>GRETA - Gestion des plannings</title>
    <!-- Feuille de style pour les icônes -->
    <link href="../fontawesome/css/all.css" rel="stylesheet">
    <!-- Feuille de style bootstrap -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <!-- Feuille de style de l'application -->
    <link rel="stylesheet" href="../css/style.css">
</head>

<body>

    <div class="textAccueil">
        <a href="accueilAdmin.php" role='button' class=" text-light">Accueil</a>
        <a href="../functions/deconnection.php" class="text-light">Deconnection</a>
    </div>

    <div class="container-fluid header">
    <div class="page-header text-warning">
            <h2>Bonjour <?php echo $name; ?> !</h2>
        </div>
        <h2 class="text-dark">GRETA 21<br>Planning de gestion de formations</h2>

        <button type="button" class="btn"><a href="../view/planning.php" class="textApps text-light">Planning</a></button>
        <nav class="navbar navbar-expand-sm bg-success justify-content-center">
            <ul class="navbar-nav">
                <li class="nav-item"><button type="button" class="btn btn-success"><a href="../view/pageMaintenanceForm.php" role='button' class="textNav text-light">Planning de cours</a></button></li>
                <li class="nav-item"><button type="button" class="btn btn-success"><a href="../view/pageMaintenanceForm.php" role='button' class="textNav text-light">Drive</a></button></li>
                <li class="nav-item"><button type="button" class="btn btn-success"><a href="../view/pageMaintenanceForm.php" role='button' class="textNav text-light">Visio</a></button></li>
            </ul>
        </nav>
    </div>
    <div class="container-fluid">