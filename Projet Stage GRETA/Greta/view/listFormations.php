<?php include("includes/debut_listing.inc.php") ?>

<!-- Contenu de la page de gestion des formations -->
<section>
    <div class="container-fluid">
        <br>
        <div class="row">
            <div class="col-10">
                <h2>Liste des formations</h2>
            </div>
            <div class="col-2">
                <button type="button" class="btn btn-success float-right" id="btn-ajouter" onclick="btnOnClick(this)"><i class="fas fa-plus"></i> Ajouter une formation</button>
            </div>
        </div>
        <table class='table table-bordered table-responsive'>
            <thead>
                <tr>
                    <th>Nom</th>
                    <th>Description</th>
                    <th>Type de formation</th>
                    <th>Catégorie de formation</th>
                    <th>Volume horaire en centre</th>
                    <th>Volume horaire en stage</th>
                    <th>Site de formation</th>
                    <th>Organisme de formation</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
                <?php
                $formations = select_formation($dbh);
                $formation = $formations->fetch();
                while ($formation) {
                    // Récupération des valeurs qui vont remplir une ligne du tableau des utilisateurs
                    $id = $formation["id_formation"];
                    $intitule = $formation["intitule_formation"];
                    $detail = $formation["detail_formation"];
                    $type = $formation["type_formation"];
                    $categorie = $formation["categorie_formation"];
                    $volume_horaire_centre = $formation["volume_horaire_centre"];
                    $volume_horaire_stage = $formation["volume_horaire_stage"];
                    $site = $formation["site"];
                    $organisme = $formation["organisme"];
                    // Remplisage d'une ligne du tableau des utilisateurs
                    echo ("<tr><td>$intitule</td><td>$detail</td><td>$type</td><td>$categorie</td><td>$volume_horaire_centre</td><td>$volume_horaire_stage</td><td>$site</td><td>$organisme</td><td>");
                    // Boutons d'actions
                    echo ("<a href=\"details_formation.php?id=$id&formation=$intitule\" class=\"btn btn-info\" id=\"btn-modifier\" role=\"button\">Détails<a>");
                    echo ("    ");
                    echo ("<a href=\"form_modifier_formation.php?id=$id\" class=\"btn btn-warning\" id=\"btn-modifier\" role=\"button\">Modifier<a>");
                    echo ("    ");
                    echo ("<a href=\"supprimer_formation.php?id=$id\" class=\"btn btn-danger\" id=\"btn-supprimer\" role=\"button\">Supprimer</a></td></tr>");
                    $formation = $formations->fetch();
                }
                ?>
            </tbody>
        </table>
        <script>
            function btnOnClick(btn, id) {
                if (document.getElementById("btn-ajouter") === btn) {
                    // console.log("Le bouton accueil fonctionne !"); //Pour le débug
                    //Changement de page
                    location.replace("form_ajouter_formation.php");
                }
            }
        </script>
</section>

<?php include("includes/footer.inc.php") ?>