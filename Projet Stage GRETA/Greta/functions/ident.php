<?php

$bdd = new PDO('mysql:host=localhost;dbname=greta', 'root', 'mysql');
session_start();

/*if(isset($_POST['name']) && isset($_POST['password']) && !empty($_POST['name']) && !empty($_POST['password'])){
    
    $name = htmlspecialchars($_POST['name']);
    $password = htmlspecialchars($_POST['password']);

    $reqUser = $bdd->prepare('SELECT id_utilisateur, prenom_utilisateur, num_rue_utilisateur, nom_rue_utilisateur, code_postal_utilisateur, ville_utilisateur, telephone_utilisateur, email_utilisateur, id_promotion, id_role, password FROM utilisateur WHERE nom_utilisateur = :name');
    $reqUser->execute(['name'=>$name]);

    $userExist = $reqUser->rowCount();

    if ($userExist > 0){

        $user = $reqUser->fetch(); // On récupère la ligne de notre requête sous forme de tableau et on l'enregistre dans la variable user
        // var_dump($user['password']);  test pour vérifier que l'on récupère bien le password de l'utilisateur
        if (password_verify($password, $user['password'])){
            session_start();
            $_SESSION['name'] = $name;
            $_SESSION['id'] = $user['id_utilisateur'];
            $_SESSION['firstname'] = $user['prenom_utilisateur'];
            $_SESSION['streetNumber'] = $user['num_rue_utilisateur'];
            $_SESSION['street'] = $user['nom_rue_utilisateur'];
            $_SESSION['postal'] = $user['code_postal_utilisateur'];
            $_SESSION['town'] = $user['ville_utilisateur'];
            $_SESSION['phone'] = $user['telephone_utilisateur'];
            $_SESSION['email'] = $user['email_utilisateur'];
            $_SESSION['idPromo'] = $user['id_promotion'];
            $_SESSION['idRole'] = $user['id_role'];

            switch ( $_SESSION['idRole']) {
                case 1:
                    header('location: ../view/accueilAdmin.php');
                    break;
                case 2:
                    header('location: ../view/accueilForm.php');
                    break;
                case 3:
                    header('location: ../view/accueilStag.php');
                    break;
                
                default:
                   header('location: ../index.php');
                    break;
            }
        }else{
            header('location: ../index.php?error=name');
        }
    }

}*/

if (isset($_POST['name']) && isset($_POST['password'])) {

    if (!empty($_POST['name']) && !empty($_POST['password'])) {   

       if ($_POST['name'] == "admin" && $_POST['password'] == "admin") {

            $_SESSION['nom'] = htmlspecialchars($_POST['name']);  // htmlspecialchars => empecher l'injection de script en transformant la valeur de l'input en brut
            header('location: ../view/accueilAdmin.php');

        } else if ($_POST['name'] == "form" && $_POST['password'] == "form") {

            $_SESSION['nom'] = htmlspecialchars($_POST['name']);  // htmlspecialchars => empecher l'injection de script en transformant la valeur de l'input en brut
            header('location: ../view/accueilForm.php');
            
        } else if ($_POST['name'] == "stag" && $_POST['password'] == "stag") {

            $_SESSION['nom'] = htmlspecialchars($_POST['name']);  // htmlspecialchars => empecher l'injection de script en transformant la valeur de l'input en brut
            header('location: ../view/accueilStag.php');
        }
    }
    
}else{
    header('location: ../index.php');
}

