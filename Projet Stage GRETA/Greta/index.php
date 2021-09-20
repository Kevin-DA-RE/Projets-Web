<!DOCTYPE html>
<html lang="fr">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <!-- Feuille de style pour les icônes -->
    <link href="fontawesome/css/all.css" rel="stylesheet">
    <!-- Feuille de style bootstrap -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link rel="stylesheet" href="css/style.css">
    <title>Identification</title>
</head>

<body>
    <section class="groupConnexion">
        <div class="formIdent">
            <form action="./functions/ident.php" method="POST">
            <h1 class="text-secondary">Connexion</h1>
                <div class="identName">
                    <label for="name">Nom : </label><br>
                    <input type="text" name="name" placeholder="Votre Nom" id="name">
                </div><br>
                <div class="identPdt">
                    <label for="password">Password : </label><br>
                    <input type="password" name="password" placeholder="Votre mot de passe" id="password">
                </div><br>
                <button type="submit" class="btn btn-primary">Valider</button><br>
            </form><br>
            <a href="view/inscription.html.php" class="btn btn-info">Veuillez vous inscrire</a>
        </div>
    </section>
</body>

</html>