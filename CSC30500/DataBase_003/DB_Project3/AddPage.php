<!--
Author: Zhuocheng Shang
Date: 06/12/2017
Purpose: add ingrdient to the store
-->

<!-- Connect to database-->

<?php

// to get data stored in a session, you must let the browser know to start a session
session_start();

// build the connection ...
echo "Attempting to connect to DB server: $host ...";
$conn = mysqli_connect($_SESSION["host"], $_SESSION["user"], $_SESSION["passw"], $_SESSION["user"]);

if (!$conn)
	// die is a php function that terminates execution.
	//   the . means string concatenation in php.
	die("Could not connect:".mysqli_connect_error());
else
	echo " connected!<br>";
?>

<!-- Get user input part-->

<h2> Add Ingredients to store </h2>
<br>
<form action="AddPage.php" method="post">

  <fieldset style="width:500px;">
    <legend>Ingredients Info:</legend>

     <!-- Get ingredients and quantity-->

     Ingredients: <input type=text name="ingredient"></input> <br><br>
     Quantity: <input type=text name="quantity"></input> <br><br>
  </fieldset>

<br>
<input type=submit value="Submit" name = "done"></input>
<input type=submit value="Return" name = "back"></input>
</form>

<!-- send rquest to database-->

<?php
if (isset($_POST["done"]))
{
  // get ingrdient
  $ingredient = $_POST["ingredient"];
  //get quantity
  $quantity = $_POST["quantity"];

  //quantity cannot less than 0
  $checkQ = $quantity;

    if($checkQ <0)
    {
     echo " Wrong quantity, quantity should lager than 0 <br>";
    }
    else{

          // try insert into table
          $queryString = "insert into Inventory values (\"$ingredient\", $quantity) ";
          $status = mysqli_query($conn, $queryString);

          // if the ingredient already exists, update the quantity
         if (!$status)
            {
              $queryString = "update Inventory set Quantity = Quantity + $quantity where Ingredient = \"$ingredient\"";
              mysqli_query($conn, $queryString);
            }
         }

  // close the connection (to be safe)
    mysqli_close($conn);

}
else if(isset($_POST["back"]))
{
  header("Location: MainPage.html");
}
 ?>
