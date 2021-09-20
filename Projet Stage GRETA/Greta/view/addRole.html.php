<?php include("../includes/debut_page_admin.inc.php") ?>

<!-- Formulaire d'ajout d'un utilisateur -->
<div class="container-fluid formSaisi"><br>
<h2>Nom rôle</h2>
    <form action="../functions/newRole.php" method="POST" onsubmit="return valider_formulaire()">
        <div class="form-group">
            <label for="txt-nom">Nom : </label><br>
            <input type="text" name="txt-nom" id="txt-nom" required>
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
            // Le nom de rôle doit être renseigné
            alert("Nom de rôle obligatoire!")
            return false;
        }
        return true;
    }
</script>

<?php include("../includes/footer.inc.php") ?>

