<title>Ejercicio 3 PHP</title>
<h1>LLENE SUS DATOS</h1>
<form method="GET" action="http://localhost:51202/Default.aspx">
	Nombre(s): <input type="text" name="nombres"/><br/><br/>
	Apellido(s): <input type="text" name="apellidos"/><br/><br/>
	<input type="submit" name="Enviar"/>
	<br/> <br/> <br/>
	<input type="hidden" name="phptime">
	<?php 
		$conexion->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
		try{
			$consulta = "insert into registro (nombres,apellidos,fechaHora) values ('"nombres,apellidos,phptime"');" ;
		    $conexion->query($consulta);
		  } catch (Exception $e) {
		    die ("Se produjo un error");
		  }
	?>
</form>
<script type="text/javascript">
	var d = new Date().toLocaleDateString().concat(" ", new Date().getHours(), ":", new Date().getMinutes(), ":", new Date().getSeconds());
	document.write(d);
	document.forms[0].elements[3].value=d;
</script>
