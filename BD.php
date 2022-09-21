<?php
$dbhost="local host";
$dbUser="root";
$dbpass="";
$dbname="registrousuario";

$connect= mysqli_connect ($dbhost,$dbUser,$dbpass,$dbname);
if (!$connect)
{
	die("no hay conexion:".mysqli_connect_error());
}
$nombre=$_POST("Nombre Usuario");
$contraseña=$_POST("Contraseña");
$Gmail=$_POST("CorreoElectronico");

$query=mysqli_query($connect,"SELECT*FROM datos WHERE Usuario='".$nombre."'and password = '".$contraseña."'");
$nr= mysqli_num_rows($query);

if($nr==1)
{
	echo "Bienvenido:".$nombre;
}
else if($nr==0)
{
	echo "no ingreso correctamente sus datos";
}
?>