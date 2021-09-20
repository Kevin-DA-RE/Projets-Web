<?php include("../includes/debut_listing.inc.php") ?>

<div class="allFilter">
        <div class="filter">
            <label class="labelFiltre">Filtre</label>
        <?php
        $unRole = select_role($dbh);
        /*print_r($role);*/
        while ($role = $unRole->fetch()) {
            $id = $role["id_role"];
            $nomRole = $role["nom_role"];?>
            <div >
            <a href="filterRole.php?id=<?= $id?>#filtreRole" class="text-danger"><?=$nomRole?></a>
            </div>
        <?php }
        ?>
    </div> 