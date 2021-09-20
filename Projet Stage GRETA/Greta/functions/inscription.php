<?php
$bdd = new PDO('mysql:host=localhost;dbname=greta', 'root', 'root');

if(isset($_POST['name']) && isset($_POST['firstname']) && isset($_POST['email']) && isset($_POST['emailConfirm']) && isset($_POST['password']) && isset($_POST['passwordConfirm']) && isset($_POST['numberStreet']) && isset($_POST['nameStreet']) && isset($_POST['postal']) && isset($_POST['city']) && isset($_POST['promotion']) && isset($_POST['role']) && isset($_POST['phone'])) {
    if(!empty($_POST['name']) && !empty($_POST['firstname']) && !empty($_POST['email']) && !empty($_POST['emailConfirm']) && !empty($_POST['password']) && !empty($_POST['passwordConfirm']) && !empty($_POST['numberStreet']) && !empty($_POST['nameStreet']) && !empty($_POST['postal']) && !empty($_POST['city']) && !empty($_POST['promotion']) && !empty($_POST['role']) && !empty($_POST['phone'])) {
        $name = htmlspecialchars($_POST['name']);
        $firstname = htmlspecialchars($_POST['firstname']);
        $email = htmlspecialchars($_POST['email']);
        $emailConfirm = htmlspecialchars($_POST['emailConfirm']);
        $password = htmlspecialchars($_POST['password']);
        $passwordConfirm = htmlspecialchars($_POST['passwordConfirm']);
        $numberStreet = htmlspecialchars($_POST['numberStreet']);
        $nameStreet = htmlspecialchars($_POST['nameStreet']);
        $postal = htmlspecialchars($_POST['postal']);
        $city = htmlspecialchars($_POST['city']);
        $promotion = htmlspecialchars($_POST['promotion']);
        $role = htmlspecialchars($_POST['role']);
        $phone = htmlspecialchars($_POST['phone']);

        if($email === $emailConfirm && filter_var($email, FILTER_VALIDATE_EMAIL)) {
            $reqEmail = $bdd->prepare('SELECT id_utilisateur FROM utilisateur WHERE email_utilisateur = :email');
            $reqEmail->execute(['email' => $email]);

            if($reqEmail->rowCount() === 0) {
                if($password === $passwordConfirm && strlen($password) >= 6) {
                    $passwordHash = password_hash($password, PASSWORD_DEFAULT);
                    $insertUser = $bdd->prepare('INSERT INTO utilisateur (nom_utilisateur, prenom_utilisateur, num_rue_utilisateur, nom_rue_utilisateur, code_postal_utilisateur, ville_utilisateur, telephone_utilisateur, email_utilisateur, password, id_promotion, id_role) VALUES (?,?,?,?,?,?,?,?,?,?,?)');
                    $insertUser->execute(array(
                        $name,
                        $firstname,
                        $numberStreet,
                        $nameStreet,
                        $postal,
                        $city,
                        $phone,
                        $email,
                        $passwordHash,
                        $promotion,
                        $role
                    ));
                    header('location: ../index.php');
                }
            }
        }
    }else{
        echo "Pas ok !";
    }
}