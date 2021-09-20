<?php include("../includes/debut_listing.inc.php") ?>

<!-- Contenu de la page de gestion de misting -->
<a href="listFilter.php" class="btn btn-warning">Trier par filtre</a>

<section class="contTable">
<table class='table table-bordered table-responsive'>
        <h2>Liste des utilisateurs</h2>
            <thead>
                <tr><th>Role</th>
                    <th>Civilité</th>
                    <th>Nom</th>
                    <th>Prénom</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
                <?php
                $users = select_utilisateur_role_promotion($dbh);
                while ($user = $users->fetch()) {
                    // Récupération des valeurs qui vont remplir une ligne du tableau des utilisateurs
                    $id = $user["id_utilisateur"];
                    $nom = $user["nom_utilisateur"];
                    $prenom = $user["prenom_utilisateur"];
                    $role = $user["role"];
                    ?>
                    <!--Remplisage d'une ligne du tableau des utilisateurs-->
                    <tr><td>M/Mme</td><td><?= $role?></td><td><?=$nom?></td><td><?=$prenom?></td><td><a href="detailsUser.php?id=<?=$id?> " class="btn btn-secondary">Détails</a>
                    <a href="modifUser.php?id=<?=$id?>" class="btn btn-warning" id="btn-modifier" role="button">Modifier</a>
                    <a href="../functions/supprimer_utilisateur.php?id=<?=$id?>" class="btn btn-danger" id="btn-supprimer" role="button">Supprimer</a></td></tr>
                 <?   
                }
                ?>
            </tbody>
</table>


</section>
</div>

<?php include("../includes/footer.inc.php"); ?>