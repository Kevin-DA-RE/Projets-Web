<?php
// On démarre la session
session_start();

// On détruit la session
session_destroy();

header('location: ../index.php');

?>