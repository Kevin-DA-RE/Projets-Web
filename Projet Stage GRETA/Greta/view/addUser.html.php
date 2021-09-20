<?php include("../includes/debut_page_admin.inc.php");
 ?>

<!-- Formulaire d'ajout d'un utilisateur -->
<div class="container-fluid formSaisi">
<h2>Nouvel Utilisateur</h2>
    <br>
    <form action="../functions/newUser.php" method="POST" onsubmit="return valider_formulaire()">
        <div class="form-group">
            <label for="role-select">Rôle : </label><br>
            <select name="role-select" id="role-select" required>
                <?php
                $roles = select_role($dbh);
                while ($role = $roles->fetch()) { 
                    ?>
                        <option value=<?=$role['id_role']?>><?=$role['nom_role']?></option>
                    <?php
                }
                ?>
            </select>
        </div>
        <div class="form-group">
            <label for="txt-nom">Nom : </label><br>
            <input type="text" name="nom_utilisateur" id="txt-nom" required>
        </div>
        <div class="form-group">
            <label for="txt-prenom">Prénom : </label><br>
            <input type="text" name="prenom_utilisateur" id="txt-prenom" required>
        </div>
        <div class="form-group">
            <label for="num-rue">Numéro de rue : </label><br>
            <input type="number" name="num_rue_utilisateur" id="num-rue" required>
        </div>
        <div class="form-group">
            <label for="nom-rue">Rue : </label><br>
            <input type="text" name="nom_rue_utilisateur" id="nom-rue" required>
        </div>
        <div class="form-group">
            <label for="code-postal">Code postal : </label><br>
            <input type="number" name="code_postal_utilisateur" id="code-postal" required>
        </div>
        <div class="form-group">
            <label for="txt-ville">Ville : </label><br>
            <input type="text" name="ville_utilisateur" id="txt-ville" required>
        </div>
        <div class="form-group">
            <label for="txt-tel">Numéro de téléphone : </label><br>
            <input type="text" name="telephone_utilisateur" id="txt-tel" required>
        </div>
        <div class="form-group">
            <label for="txt-email">Adresse mail : </label><br>
            <input type="text" name="email_utilisateur" id="txt-email" required>
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
            // Le nom doit être renseigné
            alert("Nom obligatoire!")
            return false;
        } else if (document.getElementById("txt-prenom").value.trim().length == 0) {
            // Le prénom doit être renseigné
            alert("Prénom obligatoire!")
            return false;
        } else if (document.getElementById("num-rue").value.trim().length == 0) {
            // Le numéro de rue doit être renseigné
            alert("Numéro de rue obligatoire!")
            return false;
        } else if (document.getElementById("nom-rue").value.trim().length == 0) {
            // Le nom de rue doit être renseigné
            alert("Nom de rue obligatoire!")
            return false;
        } else if (document.getElementById("code-postal").value.trim().length == 0) {
            // Le nom de rue doit être renseigné
            alert("Code postal obligatoire!")
            return false;
        } else if (document.getElementById("txt-ville").value.trim().length == 0) {
            // Le nom de rue doit être renseigné
            alert("Ville obligatoire!")
            return false;
        } else if (document.getElementById("role-select").value == "") {
            // Le nom de rue doit être renseigné
            alert("Rôle obligatoire!")
            return false;
        }
        return true;
    }
</script>

<?php include("../includes/footer.inc.php") ?>