<?php
include("../includes/debut_page_planning.inc.php");
include("../src/dates/Mois.php");
?>

<!-- Contenu de la page de gestion des plannings -->
<br />
<section id="planning">
    <div class="container-fluid">
        <button type="button" class="btn btn-primary" id="btn-calendrier" onclick="btnOnClick(this)">Calendrier</button>
        <button type="button" class="btn btn-warning" id="btn-liste" onclick="btnOnClick(this)">Liste</button>
    </div>

    <div class="container-fluid" id="calendrier">
        <div class="row">
            <div class="col-10">
                <?php
                $mois = new Mois($_GET["mois"], $_GET["annee"]);
                if ($mois == 2) {
                    $start = $mois->getStartingDay()->modify("monday");
                } else {
                    $start = $mois->getStartingDay()->modify("last monday");
                }
                ?>
                <h2><?php echo $mois->toString() ?></h2>
            </div>
            <div class="col-2">
                <a href="planning.php?mois=<?= $mois->nextMonth()->mois; ?>&annee=<?= $mois->nextMonth()->annee; ?>" class="btn btn-info float-right" id="btn-suivant"><i class="fas fa-greater-than"></i></a>
                <a href="planning.php?mois=<?= $mois->previousMonth()->mois ?>&annee=<?= $mois->previousMonth()->annee; ?>" class="btn btn-info float-right" id="btn-precedent" onclick=""><i class="fas fa-less-than"></i></a>
            </div>
        </div>
        <table class="calendar__table calendar__table--<?= $mois->getWeeks() ?>weeks">
            <?php for ($i = 0; $i < $mois->getWeeks(); $i++) { ?>
                <tr>
                    <?php foreach ($mois->jours as $k => $jour) { 
                        $date =(clone $start)->modify("+" . ($k + $i * 7) . "days");
                        ?>
                        <td class="<?= $mois->withinMonth($date) ? '' : 'calendar__othermonth' ?>">
                            <?php if ($i === 0) : ?>
                                <div class="calendar__weekday"><?= $jour; ?></div>
                            <?php endif; ?>
                            <div class="calendar__day"><?= $date->format('d');  ?></div>
                        </td>
                    <?php } ?>
                </tr>
            <?php } ?>
        </table>
    </div>

    <div class="container-fluid" id="liste">
        <div class="row">
            <div class="col-10">
                <h2>Liste des événements</h2>
            </div>
            <div class="col-2">
                <a href="form_ajouter_evenement.php" class="btn btn-success float-right" id="btn-ajouter" role="button"><i class="fas fa-plus"></i> Ajouter un evénement</a>
            </div>
        </div>
        <section>
            <table class='table table-bordered table-responsive'>
                <thead>
                    <tr>
                        <th>Titre</th>
                        <th>Type</th>
                        <th>Date(s)</th>
                        <th>Heure de début</th>
                        <th>Heure de fin</th>
                        <th>Visio</th>
                        <th>Promotion</th>
                        <th>Intervenant(s)</th>
                        <th>Salle</th>
                        <th>Compétence</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
                    <?php
                    $evenements = select_evenement($dbh);
                    $evenement = $evenements->fetch();
                    while ($evenement) {
                        // Récupération des valeurs qui vont remplir une ligne du tableau des évenements
                        $id = $evenement["id_evenement"];
                        $titre = $evenement["titre"];
                        $type = $evenement["type"];
                        $dates = $evenement["dates"];
                        $heure_debut = $evenement["heure_debut"];
                        $heure_fin = $evenement["heure_fin"];
                        $visio = $evenement["visio"];
                        $promotion = $evenement["promotion"];
                        $intervenant = $evenement["intervenant"];
                        $salle = $evenement["salle"];
                        $competence = $evenement["competence"];
                        // Remplisage d'une ligne du tableau des utilisateurs
                        echo ("<tr><td>$titre</td><td>$type</td><td>$dates</td><td>$heure_debut</td><td>$heure_fin</td><td>$visio</td><td>$promotion</td><td>$intervenant</td><td>$salle</td><td>$competence</td><td>");
                        // Boutons d'actions
                        echo ("<a href=\"form_modifier_evenement.php?id=$id\" class=\"btn btn-warning\" id=\"btn-modifier\" role=\"button\">Modifier<a>");
                        echo ("    ");
                        echo ("<a href=\"supprimer_evenement.php?id=$id\" class=\"btn btn-danger\" id=\"btn-supprimer\" role=\"button\">Supprimer</a></td></tr>");
                        $evenement = $evenements->fetch();
                    }
                    ?>
                </tbody>
            </table>
        </section>
    </div>

    <script>
        // Fonction gérant les boutons de l'entête de la page
        function btnOnClick(btn, id) {
            var liste = document.getElementById("liste");
            var calendrier = document.getElementById("calendrier");
            if (document.getElementById("btn-liste") === btn) {
                liste.style.display = "block";
                calendrier.style.display = "none";
            } else if (document.getElementById("btn-calendrier") === btn) {
                calendrier.style.display = "block";
                liste.style.display = "none";
            }
        }

        window.onload = function() {
            // Récupération des éléments html <div> qui contiennent les tableaux des activités type et des compétences d'une formation 
            var liste = document.getElementById("liste");
            var calendrier = document.getElementById("calendrier");
            // Définition de ce qui est affiché et de ce qui est caché.
            calendrier.style.display = "block";
            liste.style.display = "none";
        };
    </script>
</section>

<?php include("../includes/footer.inc.php") ?>