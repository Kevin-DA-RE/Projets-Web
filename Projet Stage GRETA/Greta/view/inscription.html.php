<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form action="../functions/inscription.php" method="POST">
        <div>
            <label for="">Nom</label>
            <input type="text" name="name">
        </div>
        <div>
            <label for="">Prénom</label>
            <input type="text" name="firstname">
        </div>
        <div>
            <label for="">email</label>
            <input type="email" name="email">
        </div>
        <div>
            <label for="">Confirmer E-mail</label>
            <input type="email" name="emailConfirm">
        </div>
        <div>
            <label for="">Téléphone</label>
            <input type="tel" name="phone">
        </div>
        <div>
            <label for="">Mot de Passe</label>
            <input type="password" name="password">
        </div>
        <div>
            <label for="">Confirmer Mot de Passe</label>
            <input type="password" name="passwordConfirm">
        </div>
        <div>
            <label for="">N°</label>
            <input type="number" name="numberStreet">
        </div>
        <div>
            <label for="">Nom rue</label>
            <input type="text" name="nameStreet">
        </div>
        <div>
            <label for="">Code Postal</label>
            <input type="number" name="postal">
        </div>
        <div>
            <label for="">Ville</label>
            <input type="text" name="city">
        </div>
        <div>
            <label for="">Promotion</label>
            <select name="promotion" id="">
                <option value="1"> CDA-1</option>
                <option value="2"> CDA-2</option>
                <option value="4"> IPM</option>
            </select>
        </div>
        <div>
            <label for="">Role</label>
            <select name="role" id="">
                <option value="1"> Administrateur</option>
                <option value="2"> Professeur</option>
                <option value="3"> Etudiant</option>
            </select>
        </div>
        <button type="submit">Valider</button>
        
    </form>

</body>

</html>