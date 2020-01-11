<?php
$file = "./users.txt";
$fh = fopen($file,'r+');
$infouser = htmlspecialchars($_GET["user"]);
$infopass = htmlspecialchars($_GET["pass"]);
$infoHDI  = htmlspecialchars($_GET["hdi"]);
$users = '';
$libera = false;
while(!feof($fh)) {

    $user = explode(',',fgets($fh));

    $username = trim($user[0]);
    $password = trim($user[1]);
    $data     = trim($user[2]);
    $HDI      = trim($user[3]);
    $status   = trim($user[4]);
    if (!empty($username) AND !empty($password)) {
        if ($username == $infouser AND $password == $infopass    ) {
           
           if (empty($data) AND empty($HDI) AND empty($status)){
            $libera = true;
            $data   = date('d-m-Y');
            $data   = date('d-m-Y', strtotime("+1 month", strtotime($data))); 
            $HDI    = $infoHDI;
            $status = "OK";
            $data_inicial =  date('Y-m-d');
            $data_final = $data;
            $time_inicial = strtotime($data_inicial);
            $time_final = strtotime($data_final);
            $diferenca = $time_final - $time_inicial; 
            $dias = (int)floor( $diferenca / (60 * 60 * 24)); 
            echo $status . "|" . $HDI . "|" . $dias; 
           }else{
            $libera = true;
            $data_inicial =  date('Y-m-d');
            $data_final = $data;
            $time_inicial = strtotime($data_inicial);
            $time_final = strtotime($data_final);
            $diferenca = $time_final - $time_inicial; 
            $dias = (int)floor( $diferenca / (60 * 60 * 24)); 
            if ($dias < 0) {
              //Acabou
              $status = "Acabou";
              echo $status . "|" . $HDI . "|" . $dias;     
            }else{
            echo $status . "|" . $HDI . "|" . $dias;   
             
            }
            
        }
        }

        $users .= $username . ',' . $password .','. $data . ',' . $HDI . ',' . $status ;
        $users .= "\r\n";
     }
}

file_put_contents($file, $users);

fclose($fh); 

if ( $libera == false ){
echo "Nao Cadastrado";

}
?>