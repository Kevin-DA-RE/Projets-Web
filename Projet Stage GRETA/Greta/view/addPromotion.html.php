<?php include("includes/debut_page.inc.php") ?>

<!-- Formulaire d'ajout d'un utilisateur -->
<div class="container-fluid formSaisi"><br>
    <img src="./img/promotion.png" width="150">
    <br>
    <form action="creer_nouveau_role.php" method="POST" onsubmit="return valider_formulaire()">
        <div class="form-group">
            <label for="txt-nom">Nom promotion : </label><br>
            <input type="text" name="txt-nom" id="txt-nom" required>
        </div>
        <div class="form-group">
            <label for="date-debut">Date de début : </label><br>
            <input type="date" name="date-debut" id="date-debut" required>
        </div>
        <div class="form-group">
            <label for="date-fin">Date de fin : </label><br>
            <input type="date" name="date-fin" id="date-fin" required>
        </div><br>
        <div class="form-example">
            <a class="btn btn-danger" id="btn-annuler" href="atelierCreat.php" role='button'>Annuler</a>
            <button type="submit" class="btn btn-success">Valider</button>
        </div><br><br><br>
    </form>
</div>

<script>
    function valider_formulaire() {
        if (document.getElementById("txt-nom").value.trim().length == 0) {
            // Le nom de promotion doit être renseigné
            alert("Nom de promotion obligatoire!");
            return false;
        } else if (document.getElementById("date-debut").value.trim().length == 0) {
            // La date de début doit être renseigné
            alert("Date de début obligatoire");
            return false;
        } else if (document.getElementById("date-fin").value.trim().length == 0) {
            // La date de fin doit être renseigné
            alert("Date de fin obligatoire");
            return false;
        }
        return true;
    }
</script>

<?php include("includes/footer.inc.php") ?>