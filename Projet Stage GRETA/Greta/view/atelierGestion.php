<?php
include("./includes/debut_page.inc.php");
?>
<section>
    <div class="imgCreat">
        <img src="./img/ampoule.png" width="80"><br>
        <h3>Gestion</h3>
    </div>
    <nav class="atelCreat">
        <button type="button" class="btn"><a href="form_ajouter_role.php" class="textApps text-light"><img src="./img/role.png" width="100"><br>Affectation <br> Prof/Comptétence</a></button>
        <button type="button" class="btn"><a href="form_ajouter_utilisateur.php" class="textApps text-light"><img src="./img/user.png" width="100"><br>Affectation <br> Promotion/Elèves </a></button>
    </nav>
</section>
<?php
include("./includes/footer.inc.php");
?>