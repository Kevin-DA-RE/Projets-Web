<?php
include('listFilter.php');
$id_role = $_GET['id'];
?>

<table id="filtreRole">
    <thead>
        <tr>
            <th>Civilité</th>
            <th>Nom</th>
            <th>Prenom</th>
        </tr>
    </thead>
    <tbody>
        <?php
        $triRole = select_utilisateur_by_role($dbh, $id_role);

        while ($triRoles = $triRole->fetch()) {
            $nom = $triRoles["nom_utilisateur"];
            $prenom = $triRoles["prenom_utilisateur"];
        ?>
            <tr>
                <td>M/Mme</td>
                <td><?= $nom ?></td>
                <td><?= $prenom ?></td>
            </tr>
        <?php } ?>
    </tbody>
</table>