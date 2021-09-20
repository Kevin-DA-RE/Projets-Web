<?php
session_start();
include("../BDD/bdd.php"); // Inclusion de la connexion à la base de données pour toutes les pages de l'application 
$dbh = connexion();
$session = $_SESSION['nom'];
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

    <div class="container-fluid header">
        <div class="page-header">
            <div class="headerItem"><img src="../img/logo-header.png" width="200"></div>
            <div class="headerTitle">
                <h2 class="text-dark">Planning</h2>
            </div>
            <div class="headerItem"><button type="button" class="btn"><a href="form_ajouter_role.php" class="textApps text-light"><img src="../img/maison.png" width="50"><br>Siege</a></button></div>
        </div>
        <?php
        switch ($sessionPass) {
            case 'admin':?>
                <button class="btn btn-danger"><a href="../view/accueilAdmin.php" class="text-light">Retour à l'accueil</a></button>
                <?php
                break;
            case 'form':?>
                <button class="btn btn-danger"><a href="../view/accueilForm.php" class="text-light">Retour à l'accueil</a></button>
                <?php
                break;
            case 'stag':?>  
                <button class="btn btn-danger"><a href="../view/accueilStag.php" class="text-light">Retour à l'accueil</a></button>
                <?php
                break;
            default:
                # code...
                
        }
        // if ($_SESSION['nom'] == 'admin' && $_SESSION['password'] == 'admin'){
        ?>
        
       
    </div>
    <div class="container-fluid">