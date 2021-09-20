<?php include("includes/debut_listing.inc.php") ?>

<!-- Contenu de la page de gestion des sites de formation -->
<section>
    <div class="container-fluid">
        <br />
        <div class="row">
            <div class="col-9">
                <h2>Liste des sites de formation</h2>
            </div>
            <div class="col-3">
                <button type="button" class="btn btn-success float-right" id="btn-ajouter" onclick="btnOnClick(this)"><i class="fas fa-plus"></i> Ajouter un site de formation</button>
            </div>
        </div>
        <table class='table table-bordered table-responsive'>
            <thead>
                <tr>
                    <th>Nom</th>
                    <th>Adresse</th>
                    <th>Téléphone</th>
                    <th>Adresse Mail</th>
                    <th>Organisme de formation</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
                <?php
                $sites = select_site_formation($dbh);
                $site = $sites->fetch();
                while ($site) {
                    // Récupération des valeurs qui vont remplir une ligne du tableau des utilisateurs
                    $id = $site["id_site"];
                    $nom = $site["nom_site"];
                    $adresse = $site["adresse"];
                    $telephone = $site["telephone_site"];
                    $email = $site["email_site"];
                    $organisme = $site["organisme"];
                    // Remplisage d'une ligne du tableau des utilisateurs
                    echo ("<tr><td>$nom</td><td>$adresse</td><td>$telephone</td><td>$email</td><td>$organisme</td><td>");
                    // Boutons d'actions
                    echo ("<a href=\"salles.php?id=$id\" class=\"btn btn-info\" id=\"btn-modifier\" role=\"button\">Détails<a>");
                    echo ("    ");
                    echo ("<a href=\"form_modifier_site.php?id=$id\" class=\"btn btn-warning\" id=\"btn-modifier\" role=\"button\">Modifier<a>");
                    echo ("    ");
                    echo ("<a href=\"supprimer_site_formation.php?id=$id\" class=\"btn btn-danger\" id=\"btn-supprimer\" role=\"button\">Supprimer</a></td></tr>");
                    $site = $sites->fetch();
                }
                ?>
            </tbody>
        </table>
    </div>
    <script>
        function btnOnClick(btn, id) {
            if (document.getElementById("btn-retour") === btn) {
                location.replace("form_ajouter_site.php");
            }
        }
    </script>
</section>

<?php include("includes/footer.inc.php") ?>