<?php 
include("../includes/debut_page_admin.inc.php");
?>

<!-- Formulaire d'ajout d'un utilisateur -->
<div class="container-fluid formSaisi">
    <br>
    <h2>Nouvelle Compétence</h2>
    <form action="../functions/newCmp.php" method="POST" onsubmit="return valider_formulaire()">
    <div class="form-group">
            <label for="act-select">Activité type :</label>
            <select name="act-select" id="act-select" required>
                <?php
                $activities = select_activite_type($dbh);
                while ($activity = $activities->fetch()) {
                    echo "<option value=$activity[id_act_type]>$activity[nom_act_type]</option>";
                }
                ?>
            </select>
        </div>
        <div class="form-group">
            <label for="nom-cp">Nom : </label>
            <input type="text" name="nom-cp" id="nom-cp" required>
        </div>
        <div class="form-group">
            <label for="code-cp">Code : </label>
            <input type="text" name="code-cp" id="code-cp" required>
        </div>
        
        <div class="form-example">
            <button type="submit" class="btn btn-success">Valider</button>
            <a class="btn btn-danger" id="btn-annuler" href="formations.php" role='button'>Annuler</a>
        </div>
    </form>
</div>

<!--<script>
    function valider_formulaire() {
        if (document.getElementById("num-cp").value.trim().length == 0) {
            // Le numéro de compétence doit être renseigné
            alert("Numéro de compétence obligatoire!")
            return false;
        } else if (document.getElementById("nom-cp").value.trim().length == 0) {
            // Le nom de compétence doit être renseigné
            alert("Nom de compétence obligatoire!")
            return false;
        } else if (document.getElementById("desc-cp").value.trim().length == 0) {
            // La description de compétence doit être renseigné
            alert("Description de compétence obligatoire!")
            return false;
        } else if (document.getElementById("code-cp").value.trim().length == 0) {
            // Le nom de rue doit être renseigné
            alert("Code de compétence obligatoire!")
            return false;
        }  else if (document.getElementById("act-select").value == "") {
            // Une activité type doit être renseigné
            alert("Activité type obligatoire!")
            return false;
        }
        return true;
    }
</script>-->

<?php include("includes/footer.inc.php") ?>