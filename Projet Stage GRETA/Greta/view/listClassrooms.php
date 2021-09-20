<?php
    include("includes/debut_listing.inc.php");
    $id = $_GET["id"];
    $sites = select_site_formation_by_id($dbh, $id);
    $site = $sites->fetch();
    $salles = select_salle_by_id_site($dbh, $id);
?>

<!-- Contenu de la page de gestion des salles composant un site de formation -->
<section>
    <div class="container-fluid">
        <br>
        <div class="row">
            <div class="col-2">
                <button type="button" class="btn btn-primary float-right" id="btn-retour" onclick="btnOnClick(this)"><i class="fas fa-arrow-left"></i> Retour</button>
            </div>
            <div class="col-8">
                <h2>Liste des salles du site de formation <?php echo ($site["nom_site"]); ?></h2>
            </div>
            <div class="col-2">
                <button type="button" class="btn btn-success" id="btn-ajouter" onclick="btnOnClick(this)"><i class="fas fa-plus"></i> Ajouter un utilisateur</button>
            </div>
        </div>
        <table class='table table-bordered table-responsive'>
            <thead>
                <tr>
                    <th>Numéro</th>
                    <th>Nom</th>
                    <th>Bâtiment</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
                <?php
                    $salle = $salles->fetch();
                    while ($salle) {
                        // Récupération des valeurs qui vont remplir une ligne du tableau des utilisateurs
                        $num_salle = $salle["numero_salle"];
                        $nom_salle = $salle["nom_salle"];
                        $batiment = $salle["batiment_salle"];
                        // Remplisage d'une ligne du tableau des utilisateurs
                        echo ("<tr><td>$num_salle</td><td>$nom_salle</td><td>$batiment</td><td>");
                        // Boutons d'actions
                        echo ("<a href=\"form_modifier_salle.php?id=$id\" class=\"btn btn-warning\" id=\"btn-modifier\" role=\"button\">Modifier<a>");
                        // echo ("    ");
                        echo ("<a href=\"supprimer_salle.php?id=$id\" class=\"btn btn-danger\" id=\"btn-supprimer\" role=\"button\">Supprimer</a></td></tr>");
                        $salle = $salles->fetch();
                    }
                ?>
            </tbody>
        </table>
    </div>
    <script>
        function btnOnClick(btn, id) {
            if (document.getElementById("btn-retour") === btn) {
                location.replace("sites_formation.php");
            } else if (document.getElementById("btn-ajouter") === btn) {
                location.replace("form_ajouter_salle.php");
            }
        }
    </script>
</section>

<?php include("includes/footer.inc.php") ?>