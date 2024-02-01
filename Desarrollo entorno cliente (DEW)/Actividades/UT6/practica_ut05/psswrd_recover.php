<?php

// RETURS THE PASSWORD STRING FOR AN ALREADY EXISTING USER

if (isset($_POST['email'])) $email = $_POST['email'];

$file_name = 'users_registry.txt';


fopen($file_name,'a+');


$users_data = explode(PHP_EOL,file_get_contents($file_name));


$psswrd = NULL;

if ($users_data != NULL) {

$psswrd = recover_psswrd($email,$users_data);

 }; 


echo $psswrd;


function recover_psswrd($email,$users_data) {

for ($i = 0; $i < count($users_data); $i++) {

if (json_decode($users_data[$i])->email == $email) $psswrd = json_decode($users_data[$i])->psswrd;

  }; 

return $psswrd;

  };



?> 


