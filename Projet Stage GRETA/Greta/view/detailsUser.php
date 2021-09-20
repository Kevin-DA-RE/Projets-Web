<?php include("../includes/debut_listing.inc.php");

$id = $_GET["id"];

$utilisateurs = select_User($dbh, $id);
$utilisateur = $utilisateurs->fetch();
$nom = $utilisateur["nom_utilisateur"];
$prenom = $utilisateur["prenom_utilisateur"];
$coordonnes = $utilisateur["coordonnees"];
$cp = $utilisateur["code_postal_utilisateur"];
$ville = $utilisateur["ville_utilisateur"];
$telephone = $utilisateur["telephone_utilisateur"];
$email = $utilisateur["email_utilisateur"];
$role = $utilisateur["role"];

?>
<div class="dtUser">
    <div class="userCard">
        <div class="imgUser"><i class="far fa-user-circle fa-5x"></i></div>
        <div class="userDes">
            <div class="userPHP text-success"><?= $role ?></div>
            
            <div class="userInfo">Nom : </div><div class="userPHP"><?= $nom ?></div>
            
            <div class="userInfo">Prenom : </div><div class="userPHP"><?= $prenom ?></div>
            
        </div><br>
    </div>
    <div class="userAdr">
        <div class="userInfo">N : </div><div class="userPHP"><?= $coordonnes ?></div>
        <br>
        <div class="userInfo">Code Postal : </div><div class="userPHP"><?= $cp ?></div>
        
        <div class="userInfo">Ville : </div><div class="userPHP"><?= $ville ?></div>
        
    </div>

</div>