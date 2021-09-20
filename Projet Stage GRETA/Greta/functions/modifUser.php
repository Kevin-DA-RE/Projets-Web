<?php 
    include("includes/debut_page.inc.php");
    require_once("./BDD/bdd.php");
    $dbh = connexion();

    $id = $_GET["id"];
    $utilisateurs = select_User($dbh, $id);
    $utilisateur = $utilisateurs->fetch();
    $nom = $utilisateur["nom_utilisateur"];
    $prenom= $utilisateur["prenom_utilisateur"];
    $num_rue = $utilisateur["num_rue_utilisateur"];
    $nom_rue = $utilisateur["nom_rue_utilisateur"];
    $code_postal = $utilisateur["code_postal_utilisateur"];
    $ville = $utilisateur["ville_utilisateur"];
    $telephone = $utilisateur["telephone_utilisateur"];
    $email = $utilisateur["email_utilisateur"];
    $promo = $utilisateur["id_promotion"];
    $role = $utilisateur["id_role"];
?>

<!-- Formulaire d'ajout d'un utilisateur -->
<div class="container-fluid">
    <br>
    <h2>Modifier un utilisateur</h2>
    <form action="updateUser.php" method="POST" onsubmit="return valider_formulaire()">
    <legend>Utilisateur</legend>
                <input type="text" name="id_utilisateur" value="<?php echo $id; ?>" hidden><br><br>

    <div class="form-group">
            <label for="statut">Rôle :</label>
            <select name="statut" id="role-select" required>
                <?php
                $Statuts = select_role($dbh);
                while ($statut = $Statuts->fetch()) { 
                        echo "<option value=$statut[id_role]>$statut[nom_role]</option>";
                    }?>
                
            </select>
        </div>
        
        <div class="form-group">
            <label for="txt-nom">Nom : </label>
            <input type="text" name="nom_utilisateur" id="txt-nom" value="<?php echo $nom?>" required>
        </div>
        <div class="form-group">
            <label for="txt-prenom">Prénom : </label>
            <input type="text" name="prenom_utilisateur" id="txt-prenom" value="<?php echo $prenom?>" required>
        </div>
        <div class="form-group">
            <label for="num-rue">Numéro de rue : </label>
            <input type="number" name="num_rue_utilisateur" id="num-rue" value="<?php echo $num_rue?>" required>
        </div>
        <div class="form-group">
            <label for="nom-rue">Rue : </label>
            <input type="text" name="nom_rue_utilisateur" id="nom-rue" value="<?php echo $nom_rue?>" required>
        </div>
        <div class="form-group">
            <label for="code-postal">Code postal : </label>
            <input type="number" name="code_postal_utilisateur" id="code-postal" value="<?php echo $code_postal?>" required>
        </div>
        <div class="form-group">
            <label for="txt-ville">Ville :</label>
            <input type="text" name="ville_utilisateur" id="txt-ville" value="<?php echo $ville?>" required>
        </div>
        <div class="form-group">
            <label for="txt-tel">Numéro de téléphone : </label>
            <input type="text" name="telephone_utilisateur" id="txt-tel" value="<?php echo $telephone?>" required>
        </div>
        <div class="form-group">
            <label for="txt-email">Adresse mail : </label>
            <input type="text" name="email_utilisateur" id="txt-email" value="<?php echo $email?>" required>
        </div>
        
        <div class="form">
            <button type="submit" class="btn btn-success">Valider</button>
            <a class="btn btn-danger" id="btn-annuler" href="utilisateurs.php" role="button">Annuler</a>
        </div>
    </form>
</div>

<!--<script>
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
            alert("Ville obligatoire!")
            return false;
        }
        return true;
    }
</script>-->

<?php include("includes/footer.inc.php") ?>