<?php
    include("includes/header.inc.php");
    $id = $_GET["id"];

    $promotions = select_promotion_by_id($dbh, $id);
    $promotion = $promotions->fetch();
    $nom_promo = $promotion["nom_promotion"];
?>

<!-- Contenu de la page de gestion des formateurs -->
<section>
    <div class="container-fluid">
        <br>
        <div class="row">
            <div class="col-2">
                <button type="button" class="btn btn-primary" id="btn-retour" onclick="btnOnClick(this)"><i class="fas fa-arrow-left"></i> Retour</button>
            </div>
            <div class="col-10">
                <h2>Liste des stagiaires de la promotion <?php echo ($promotion["nom_promotion"]); ?></h2>
            </div>
        </div>
        <table class='table table-bordered table-responsive'>
            <thead>
                <tr>
                    <th>Nom</th>
                    <th>Prénom</th>
                    <th>Adresse</th>
                    <th>Numéro de téléphone</th>
                    <th>Adresse Mail</th>
                </tr>
            </thead>
            <tbody>
                <?php
                $utilisateurs = select_utilisateur_by_promotion($dbh, $id);
                $utilisateur = $utilisateurs->fetch();
                while ($utilisateur) {
                    // Récupération des valeurs qui vont remplir une ligne du tableau des utilisateurs
                    $id = $utilisateur["id_utilisateur"];
                    $nom = $utilisateur["nom_utilisateur"];
                    $prenom = $utilisateur["prenom_utilisateur"];
                    $adresse = $utilisateur["adresse"];
                    $telephone = $utilisateur["telephone_utilisateur"];
                    $email = $utilisateur["email_utilisateur"];
                    // Remplisage d'une ligne du tableau des utilisateurs
                    echo ("<tr><td>$nom</td><td>$prenom</td><td>$adresse</td><td>$telephone</td><td>$email</td>");
                    $utilisateur = $utilisateurs->fetch();
                }
                ?>
            </tbody>
        </table>
    </div>
    <script>
        function btnOnClick(btn, id) {
            if (document.getElementById("btn-retour") === btn) {
                // console.log("Le bouton accueil fonctionne !"); //Pour le débug
                //Changement de page
                location.replace("promotions.php");
            }
        }
    </script>
</section>

<?php include("includes/footer.inc.php") ?>