<?php include("includes/debut_page.inc.php");
require_once('./BDD/bdd.php');
$dbh = connexion();
 ?>

<!-- Formulaire d'ajout d'un utilisateur -->
<div class="container-fluid formSaisi">
    <img src="./img/user.png" width="150">
    <br>
    <form action="newClassroom.php" method="POST" onsubmit="return valider_formulaire()">
        <div class="form-group">
            <label for="site">Site de Formation : </label><br>
            <select name="site" id="site" required>
                <?php
                $classrooms = select_site_formation($dbh);
                while ($classroom = $classrooms->fetch()) { 
                    ?>
                        <option value=<?=$classroom['id_site']?>><?=$classroom['nom_site']?></option>
                    <?php
                }
                ?>
            </select>
        </div>
        <div class="form-group">
            <label for="txt-nom">Nom de la salle : </label><br>
            <input type="text" name="nom_salle" id="txt-nom" required>
        </div><br>
        <div class="form-group">
            <label for="txt-nom">Numéro : </label><br>
            <input type="text" name="numero_salle" id="txt-num">
        </div><br>
        <div class="form-group">
            <label for="txt-nom">Bâtiment : </label><br>
            <input type="text" name="batiment_salle" id="txt-bat">
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
            alert("Nom de la salle obligatoire !")
            return false;
        } 
        return true;
    }
</script>

<?php include("includes/footer.inc.php") ?>