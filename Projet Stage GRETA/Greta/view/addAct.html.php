<?php 
include("includes/header.inc.php");
$id_formation = $_GET["id"]; // Récupération de l'id de la formation sélectionné
?>

<!-- Formulaire d'ajout d'une nouvelle activité type -->
<div class="container-fluid"><br>
    <img src="./img/formation.png" width="150">
    <br>
    <form action="newAct.php" method="POST" onsubmit="return valider_formulaire()">
        <div class="form-group">
            <label for="num-act">Numéro : </label><br>
            <input type="number" name="num-act" id="num-act" required>
        </div>
        <div class="form-group">
            <label for="nom-act">Nom : </label><br>
            <input type="text" name="nom-act" id="nom-act" required>
        </div>
        <div class="form-group">
            <label for="desc-act">Description : </label><br>
            <input type="text" name="desc-act" id="desc-act">
        </div>
        <div class="form-group">
            <label for="num-formation">Formation :</label><br>
            <input type="number" name="num-formation" id="num-formation" value="<?php echo $id_formation ?>">
        </div>
        <div class="form-example">
            <a class="btn btn-danger" id="btn-annuler" href="formations.php" role='button'>Annuler</a>
            <button type="submit" class="btn btn-success">Valider</button>
        </div><br>
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

<?php include("includes/footer.inc.php") ?>