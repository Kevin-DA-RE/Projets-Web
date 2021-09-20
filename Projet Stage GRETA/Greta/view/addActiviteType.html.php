
<?php
include("../includes/debut_page_admin.inc.php");
?>

<!-- Formulaire d'ajout d'une nouveau formulaire -->
<div class="container-fluid formSaisi"><br>
<h2>Nouvelle Activité Type</h2>
    <br>
    <form action="../functions/newAct.php" method="POST" onsubmit="return valider_formulaire()">
        <select name="formation" id="formation">
            <?php
            $formations = selectFormation($dbh);
            while ($uneForm = $formations->fetch()) {
                echo "<option value=$uneForm[id_formation]>$uneForm[intitule_formation]</option>";
            }
            ?>
        </select><br><br>
        <div class="form-group">
            <label for="nom-act">Numéro : </label><br>
            <input type="number" name="num_act_type" id="num-act" required>
        </div>
        <div class="form-group">
            <label for="nom-act">Nom : </label><br>
            <input type="text" name="nom_act_type" id="num-act" required>
        </div>
        <div class="form-example">
            <button type="submit" class="btn btn-success">Ajouter Activité type</button>
        </div><br><br><br>
    </form>
</div>
<div>
    <button class="btn btn-danger"><a href="atelierCreta.php" class="textApps text-light">Annuler</a></button>
    <button class="btn btn-info"><a href="addCmp.html.php" class="textApps text-light">Suivant</a></button>
</div>

<script>
    function valider_formulaire() {
        if (document.getElementById("num-act").value.trim().length == 0) {
            // Le nom doit être renseigné
            alert("Numéro d'activité type obligatoire!")
            return false;
        } else if (document.getElementById("nom-act").value.trim().length == 0) {
            // Le prénom doit être renseigné
            alert("Nom d'activité type obligatoire!")
            return false;
        } else if (document.getElementById("desc-act").value.trim().length == 0) {
            // Le numéro de rue doit être renseigné
            alert("Description d'activité type obligatoire!")
            return false;
        } else if (document.getElementById("num-formation").value.trim().length == 0) {
            // Le nom de rue doit être renseigné
            alert("Numéro de formation obligatoire obligatoire!")
            return false;
        }
        return true;
    }
</script>

<?php include("../includes/footer.inc.php") ?>