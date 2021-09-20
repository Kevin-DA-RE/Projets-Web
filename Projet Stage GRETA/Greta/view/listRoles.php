<?php include("../includes/debut_listing.inc.php") ?>

<!-- Contenu de la page de gestion des rôles qui peuvent être attibué à une personne -->

<section class="contTable">
    <table class="table table-bordered table-responsive">
        <h2>Liste des rôles</h2>
        <thead class="thead">
            <tr>
                <th>Nom</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody  class="tbody">
            <?php
            $roles = select_role($dbh);
            while ($role = $roles->fetch()) {
                // Récupération des valeurs qui vont remplir une ligne du tableau des utilisateurs
                $id = $role["id_role"];
                $nom= $role["nom_role"];?>
                <!-- Remplisage d'une ligne du tableau des utilisateurs-->
                <tr><td><?=$nom?></td><td><a href="../functions/supprimer_role.php?id=<?=$id?>" class="btn btn-danger" id="btn-supprimer" role="button">Supprimer</a></td></tr>
                <?
            }
            ?>
        </tbody>
    </table>
</section>
<?php include("../includes/footer.inc.php")?>