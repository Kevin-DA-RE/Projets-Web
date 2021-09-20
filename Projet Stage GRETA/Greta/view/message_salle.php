<!doctype html>
<html lang="fr">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>GRETA - Gestion des plannings</title>
    <!-- Feuille de style pour les icônes -->
    <link href="fontawesome/css/all.css" rel="stylesheet">
    <!-- Feuille de style bootstrap -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <!-- Feuille de style de l'application -->
    <link rel="stylesheet" href="css/style.css">
</head>

<body id="body">
    <section class="messInterm">
        <article>
            <p>Félicitations, une nouvelle salle vient d’être ajoutée ! <br><br>
                Souhaitez-vous visionner la liste des lieux, revenir à l'atelier de création ou en créer un autre ?
            </p>
        </article>
            <nav class="btnMess">
                <button class="btn btn-info "><a href="classrooms.php" class="text-light"><h3>Liste Salles</h3></a></button> 
                <button class="btn btn-warning"><a href="atelierCreat.php" class="text-light"><h3>Atelier de création</h3></a></button> 
                <button class="btn btn-success"><a href="addClassroom.php" class="text-light"><h3>Créer Salle</h3></a></button> 
            </nav>
    </section>
</body>
<!-- Pied de page de l'application -->
<footer id="footer">
    <p class="text-center">
        Copyright <i class="fa fa-copyright" aria-hidden="true"></i> - Axel Arcidiaco & Kévin Da Re - 2020-<?php echo date("Y"); ?>
    </p>
</footer>

</html>