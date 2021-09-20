<?php include("includes/header.inc.php") ?>

<!-- Contenu de la page de gestion des organismes de formation -->
<section>
    <br />
    <div class="row">
        <div class="col-9">
            <h2>Liste des organismes de formation</h2>
        </div>
        <div class="col-3">
            <button type="button" class="btn btn-success float-right" id="btn-ajouter" onclick="btnOnClick(this)"><i class="fas fa-plus"></i> Ajouter un organisme de formation</button>
        </div>
    </div>
    <table class='table table-bordered table-responsive'>
        <thead>
            <tr>
                <th>SIRET</th>
                <th>Nom</th>
                <th>Adresse</th>
                <th>Téléphone</th>
                <th>Adresse Mail</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
            <?php
            $organismes = select_organisme($dbh);
            $organisme = $organismes->fetch();
            while ($organisme) {
                // Récupération des valeurs qui vont remplir une ligne du tableau des utilisateurs
                $id = $organisme["id_organisme"];
                $siret = $organisme["siret_organisme"];
                $nom = $organisme["nom_organisme"];
                $adresse = $organisme["adresse"];
                $telephone = $organisme["telephone_organisme"];
                $email = $organisme["email_organisme"];
                // Remplisage d'une ligne du tableau des utilisateurs
                echo ("<tr><td>$siret</td><td>$nom</td><td>$adresse</td><td>$telephone</td><td>$email</td><td>");
                // Boutons d'actions
                echo ("<a href=\"form_modifier_organisme.php?id=$id\" class=\"btn btn-warning\" id=\"btn-modifier\" role=\"button\">Modifier<a>");
                echo ("    ");
                echo ("<a href=\"supprimer_organisme.php?id=$id\" class=\"btn btn-danger\" id=\"btn-supprimer\" role=\"button\">Supprimer</a></td></tr>");
                $organisme = $organismes->fetch();
            }
            ?>
        </tbody>
    </table>
    <script>
        function btnOnClick(btn, id) {
            if (document.getElementById("btn-retour") === btn) {
                location.replace("form_ajouter_organisme.php");
            }
        }
    </script>
</section>

<?php include("includes/footer.inc.php") ?>