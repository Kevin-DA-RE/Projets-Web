<?php
include("includes/header.inc.php");
$id_formation = $_GET["id"]; // Récupération de l'id de la formation sélectionné
$formation = $_GET["formation"]; // Récupération de intitulé de la formation sélectionné
?>

<!-- Contenu de la page de gestion des plannings -->
<br />
<section id="planning">
    <div class="container-fluid">
        <div class="row">
            <div class="col-2">
                <button type="button" class="btn btn-primary" id="btn-retour" onclick="btnOnClick(this)"><i class="fas fa-arrow-left"></i> Retour</button>
            </div>
            <div class="col-10">
                <h2><?php echo htmlspecialchars($formation); ?></h2>
            </div>
        </div>
        <button type="button" class="btn" id="btn-activites" onclick="btnOnClick(this)">Activités Type</button>
        <button type="button" class="btn" id="btn-competences" onclick="btnOnClick(this)">Compétences</button>
    </div>

    <!-- Zone d'affichage des activités type d'une formation -->
    <div class="container-fluid" id="activites">
        <div class="row">
            <div class="col-10">
                <h2>Liste des activités types</h2>
            </div>
            <div class="col-2">
                <a href="form_ajouter_activite.php?id=$id" class="btn btn-success float-right" id="btn-ajouter" role="button"><i class="fas fa-plus"></i> Ajouter une activité type</a>
            </div>
        </div>
        <section>
            <table class='table table-bordered table-responsive'>
                <thead>
                    <tr>
                        <th>Numéro</th>
                        <th>Nom</th>
                        <th>Description</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
                    <?php
                    $activites = select_activite_type_by_formation($dbh, $id_formation);
                    $activite = $activites->fetch();
                    while ($activite) {
                        // Récupération des valeurs qui vont remplir une ligne du tableau des utilisateurs
                        $id = $activite["id_promotion"];
                        $numero = $activite["num_act_type"];
                        $nom = $activite["nom_act_type"];
                        $description = $activite["description_act_type"];
                        // Remplisage d'une ligne du tableau des utilisateurs
                        echo ("<tr><td>$numero</td><td>$nom</td><td>$description</td><td>");
                        // Boutons d'actions
                        echo ("<a href=\"form_modifier_activite.php?id=$id&id_formation=$id_formation\" class=\"btn btn-warning\" id=\"btn-modifier\" role=\"button\">Modifier<a>");
                        echo ("    ");
                        echo ("<a href=\"supprimer_activite.php?id=$id\" class=\"btn btn-danger\" id=\"btn-supprimer\" role=\"button\">Supprimer</a></td></tr>");
                        $activite = $activites->fetch();
                    }
                    ?>
                </tbody>
            </table>
        </section>
    </div>

    <!-- Zone d'affichage des compétences d'une formation -->
    <div class="container-fluid" id="competences">
        <div class="row">
            <div class="col-9">
                <h2>Liste des compétences</h2>
            </div>
            <div class="col-3">
                <a href="form_ajouter_competence.php?id=$id" class="btn btn-success float-right" id="btn-ajouter" role="button"><i class="fas fa-plus"></i> Ajouter une compétence</a>
            </div>
        </div>
        <section>
            <table class='table table-bordered table-responsive'>
                <thead>
                    <tr>
                        <th>Numéro</th>
                        <th>Nom</th>
                        <th>Description</th>
                        <th>Code</th>
                        <th>Activité type</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
                    <?php
                    $competences = select_competence_by_formation($dbh, $id_formation);
                    $competence = $competences->fetch();
                    while ($competence) {
                        // Récupération des valeurs qui vont remplir une ligne du tableau des utilisateurs
                        $id = $competence["id_competence"];
                        $numero = $competence["num_competence"];
                        $nom = $competence["nom_competence"];
                        $description = $competence["desc_competence"];
                        $code = $competence["code_competence"];
                        $act_type = $competence["activite_type"];
                        // Remplisage d'une ligne du tableau des utilisateurs
                        echo ("<tr><td>$numero</td><td>$nom</td><td>$description</td><td>$code</td><td>$act_type</td><td>");
                        // Boutons d'actions
                        echo ("<a href=\"form_modifier_competence.php?id=$id&id_formation=$id_formation\" class=\"btn btn-warning\" id=\"btn-modifier\" role=\"button\">Modifier<a>");
                        echo ("    ");
                        echo ("<a href=\"supprimer_competence.php?id=$id\" class=\"btn btn-danger\" id=\"btn-supprimer\" role=\"button\">Supprimer</a></td></tr>");
                        $competence = $competences->fetch();
                    }
                    ?>
                </tbody>
            </table>
        </section>
    </div>

    <script>
        // Fonction gérant les boutons de l'entête de la page
        function btnOnClick(btn, id) {
            var comp = document.getElementById("competences");
            var act = document.getElementById("activites");
            if (document.getElementById("btn-activites") === btn) {
                act.style.display = "block";
                comp.style.display = "none";
            } else if (document.getElementById("btn-competences") === btn) {
                comp.style.display = "block";
                act.style.display = "none";
            } else if (document.getElementById("btn-retour") === btn) {
                location.replace("formations.php");
            }
        }

        window.onload = function() {
            // Récupération des éléments html <div> qui contiennent les tableaux des activités type et des compétences d'une formation 
            var comp = document.getElementById("competences");
            var act = document.getElementById("activites");
            // Définition du tableau qui est affiché et de celui qui est caché.
            act.style.display = "block"; // On affiche le tableau des activités type
            comp.style.display = "none"; // On cache le tableau des compétences
        };
    </script>
</section>

<?php include("includes/footer.inc.php") ?>