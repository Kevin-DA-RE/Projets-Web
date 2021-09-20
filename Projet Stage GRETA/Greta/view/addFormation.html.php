<?php
include("../includes/debut_page_admin.inc.php");
?>

<!-- Formulaire d'ajout d'une nouveau formulaire -->
<div class="container-fluid formSaisi"><br>
    <h2>Nouvelle Formation</h2>
    <br>
    <form action="../functions/newFormation.php" method="POST" onsubmit="return valider_formulaire()">
        <div class="form-group">
            <label for="nom-act">Nom : </label><br>
            <input type="text" name="intule_formation" id="num-act" required>
        </div>
        <div class="form-group">
            <label for="details">Détails : </label><br>
            <textarea name="detail_formation" id="" cols="25" rows="10"></textarea>
        </div>
        <div class="form-group">
            <label for="type">Type : </label><br>
            <input type="text" name="type_formation" id="desc-act">
        </div>
        <div class="form-group">
            <label for="categorie">Catégorie </label><br>
            <input type="text" name="categorie_formation" id="categorie-formation" value="">
        </div>
        <div class="form-group">
            <label for="volumCentre">Volume horaire centre : </label><br>
            <input type="number" name="volume_horaire_centre" id="volHoraireCentre-formation" value="">
        </div>
        <div class="form-group">
            <label for="volumStage">Volume horaire stage : </label><br>
            <input type="number" name="volume_horaire_stage" id="voluHoraireStage-formation" value="">
        </div><br>
        <div class="form-example">
            <a class="btn btn-danger" id="btn-annuler" href="atelierCreat.php" role='button'>Annuler</a>
            <button type="submit" class="btn btn-success">Valider</button>
        </div><br><br><br>
    </form>
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