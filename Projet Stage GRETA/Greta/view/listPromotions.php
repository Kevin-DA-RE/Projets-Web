<?php include("includes/debut_listing.inc.php") ?>

<!-- Contenu de la page de gestion des formations -->
<section>
    <div class="container-fluid">
        <br />
        <div class="row">
            <div class="col-10">
                <h2>Liste des promotions</h2>
            </div>
            <div class="col-2">
                <button type="button" class="btn btn-success float-right" id="btn-ajouter" onclick="btnOnClick(this)"><i class="fas fa-plus"></i> Ajouter une promotion</button>
            </div>
        </div>
        <table class='table table-bordered table-responsive'>
            <thead>
                <tr>
                    <th>Nom</th>
                    <th>Date de début</th>
                    <th>Date de fin</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
                <?php
                $promotions = select_promotion($dbh);
                $promotion = $promotions->fetch();
                while ($promotion) {
                    // Récupération des valeurs qui vont remplir une ligne du tableau des utilisateurs
                    $id_promotion = $promotion["id_promotion"];
                    $nom_promotion = $promotion["nom_promotion"];
                    $date_debut = $promotion["date_debut"];
                    $date_fin = $promotion["date_fin"];
                    // Remplisage d'une ligne du tableau des utilisateurs
                    echo ("<tr><td>$nom_promotion</td><td>$date_debut</td><td>$date_fin</td><td>");
                    // Boutons d'actions
                    echo ("<a href=\"details_promotion.php?id=$id_promotion\" class=\"btn btn-info\" id=\"btn-modifier\" role=\"button\">Détails<a>");
                    echo ("    ");
                    echo ("<a href=\"form_modifier_promotion.php?id=$id_promotion\" class=\"btn btn-warning\" id=\"btn-modifier\" role=\"button\">Modifier<a>");
                    echo ("    ");
                    echo ("<a href=\"supprimer_promotion.php?id=$id_promotion\" class=\"btn btn-danger\" id=\"btn-supprimer\" role=\"button\">Supprimer</a></td></tr>");
                    $promotion = $promotions->fetch();
                }
                ?>
            </tbody>
        </table>
    </div>
    <script>
        function btnOnClick(btn, id) {
            if (document.getElementById("btn-retour") === btn) {
                location.replace("form_ajouter_promotion.php");
            }
        }
    </script>
</section>

<?php include("includes/footer.inc.php") ?>