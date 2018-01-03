<!--
Author: Zhuocheng Shang
Date: 06/12/2017
Purpose: connect to database and create Recipes table and Inventory table
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

<!-- User input part-->
<br>
<h2> Create / Add ingredient to a recipe </h2><br>
<form action="CreatePage.php" method="post">

    <fieldset style="width:500px;">
      <legend> Recipe Info:</legend>

      <!-- get recipe name, ingredients, quantity-->
      Recipe Name: <input type=text name="recipeName"></input> <br><br>
      Ingredients: <input type=text name="ingredient"></input> <br><br>
      Quantity: <input type=text name="quantity"></input> <br><br>
  </fieldset>

<br>
<input type=submit value="Submit" name = "done"></input>
<input type=submit value="Return" name = "back"></input>
</form>


<!-- Send user input to database-->

<?php

if (isset($_POST["done"]))
{

  //quantity cannot less than 0
  $checkQ = $_POST["quantity"];

  if($checkQ <0)
  {
   echo " Wrong quantity, quantity should lager than 0 <br>";
  }
  else
    {
      $recipe = $_POST["recipeName"];
      $ingredient = $_POST["ingredient"];
      $quantity = $_POST["quantity"];

      // try and insert request
      $queryString = "insert into Recipes".
                     " values (\"$recipe\", \"$ingredient\", $quantity)";
      $status = mysqli_query($conn, $queryString);

      if (!$status)
      {
       die("Error performing insertion: " . mysqli_error($conn));
      }
        else
        {
          echo "New record created / add successfully";
        }

    }

  // close the connection (to be safe)
    mysqli_close($conn);

}
  // click return button
else if(isset($_POST["back"]))
{
   //redirect to main menu
  header("Location: MainPage.html");
}

 ?>
