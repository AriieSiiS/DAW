<?php

// RETURNS 1 IF USER EXISTS; 0 OTHERWISE

if (isset($_POST['userName'])) $userName = $_POST['userName'];
if (isset($_POST['psswrd'])) $psswrd = $_POST['psswrd'];

$file_name = 'users_registry.txt';

fopen($file_name,'a+');

$users_data = explode(PHP_EOL,file_get_contents($file_name));

$rslt = FALSE;

if ($users_data != NULL) {
    $rslt = check_user($userName,$psswrd,$users_data);
}; 

echo $rslt;

function check_user($userName, $psswrd, $users_data) {
  $rslt = FALSE;
  for ($i = 0; $i < count($users_data); $i++) {
      $userData = json_decode($users_data[$i]);
      if ($userData !== null && $userData->userName == $userName && $userData->psswrd == $psswrd) {
          $rslt = TRUE;
          break;
      }
  }
  return $rslt;
}
?>