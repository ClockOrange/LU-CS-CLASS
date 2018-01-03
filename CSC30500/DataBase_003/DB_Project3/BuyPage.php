<!--
Author: Zhuocheng Shang
Date: 06/12/2017
Purpose: buy all recipe ingredients from the store
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

<br>
<h2> Buy ingredients for a recipe you want </h2><br>
<form action="BuyPage.php" method="post">

  <fieldset style="width:500px;">
		<legend>Recipe Info:</legend>

		<!-- Get recipe name-->

		Recipe Name: <input type=text name="recipeName"></input> <br><br>

  </fieldset>

<br>
<input type=submit value="Submit" name = "done"></input>
<input type=submit value="Return" name = "back"></input>
</form>


<!-- send rquest to database-->

<?php

if (isset($_POST["done"]))
{
        //get recipe name
			 $recipe = $_POST["recipeName"];

			 //assume there are enpugh ingredient
			 $canBuy = true;

			 //start transaction
			  mysqli_autocommit($conn, FALSE);

				$queryString = "update Inventory, Recipes" .
					             " set Inventory.Quantity = Inventory.Quantity-Recipes.Quantity" .
											 " where Recipes.RecipeName = \"$recipe\" and".
											 " Recipes.Ingredient = Inventory.Ingredient";
				mysqli_query($conn, $queryString);

				$queryString = "select Inventory.Quantity from Inventory, Recipes where Recipes.RecipeName = \"$recipe\" and".
					               " Recipes.Ingredient = Inventory.Ingredient";
				$status = mysqli_query($conn, $queryString);

				// if the recipe exists
					if (mysqli_num_rows($status)>0)
				  {
              //go through each row
						while($row = mysqli_fetch_array($status))
			      {
							 // if the quantity of ingredient is less than 0
			        if ($row["Quantity"] < 0)
			        {
								 // cannot buy
									$canBuy = false;
							  	// out of loop
			            break;
			        }
			       }
				 }
				 else // the recipe not exist
				 {
					 //can not buy
					 $canBuy = false;
				 }

         // if there are enough ingredient
				 if ($canBuy)
				 {
						echo "Success!";

						//commit
						mysqli_commit($conn);
				 }
				 else // if there are not enough ingredient or recipe not exists
				 {
						 echo "Sorry, not enough ingredient OR we do not have such a recipe.";

						 //rollback
						 mysqli_rollback($conn);
				 }

// close the connection (to be safe)
 mysqli_close($conn);

}
else if(isset($_POST["back"]))
{
  header("Location: MainPage.html");
}
 ?>
