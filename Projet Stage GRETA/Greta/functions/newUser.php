<?php 
    include("../BDD/bdd.php");
    $dbh = connexion();

    // Vérification que les champs obligatoire sont renseigné
    if((isset($_POST["role-select"])) && (isset($_POST["nom_utilisateur"])) && (isset($_POST["prenom_utilisateur"])) && 
    (isset($_POST["num_rue_utilisateur"]))&& (isset($_POST["nom_rue_utilisateur"])) && (isset($_POST["code_postal_utilisateur"]))
     && (isset($_POST["ville_utilisateur"])) && (isset($_POST["telephone_utilisateur"])) && (isset($_POST["email_utilisateur"])))
     {
        $nom = $_POST["nom_utilisateur"];
        $prenom = $_POST["prenom_utilisateur"];
        $num_rue = $_POST["num_rue_utilisateur"];
        $nom_rue = $_POST["nom_rue_utilisateur"];
        $code_postal = $_POST["code_postal_utilisateur"];
        $ville = $_POST["ville_utilisateur"];
        $telephone = $_POST["telephone_utilisateur"];
        $email = $_POST["email_utilisateur"];
        $role = strval ($_POST["role-select"]);
        insert_user($dbh, $nom, $prenom, $num_rue, $nom_rue, $code_postal, $ville, $telephone, $email, $role);
        header("Location: ../view/message_user.php"); // Dans le cas où l'utilisateur est enregistré sans erreurs
    } else {
        // Si l'une des valeurs demandées est vide l'utilisateur est renvoyé sur le formulaire  
        echo 'Erreur lors de la saisie du nouvel utilisateur';
        header("Location: addUser.php");
        exit();
    }
?>