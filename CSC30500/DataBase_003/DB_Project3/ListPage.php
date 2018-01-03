<!--
Author: Zhuocheng Shang
Date: 06/12/2017
Purpose: list all ingredients of a recipe
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
	die("Could not connect:".mysqli_connect_error());
else
	echo " connected!<br>";
?>

<!-- Get user input part-->

<br>
<h2> List the recipe you want to know </h2><br>
<form action="ListPage.php" method="post">

  <fieldset style="width: 500px;"><br>
    <legend>List Info:</legend>

     <!-- get recipe name-->

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
    // get recipe name
    $recipe = $_POST["recipeName"];

    // select all recipes in the table
    $queryString = "select * from Recipes where RecipeName = \"$recipe\"";
    $status = mysqli_query($conn, $queryString);

    // if the recipe name entered exists
if(mysqli_num_rows($status) > 0)
{
      //table
      echo "$recipe<br>";
      echo "<table>";
      echo "<tr><th>Ingredient</th><th>Quantity</th></tr>";
       // output data of each row
      while($row = mysqli_fetch_assoc($status))
       {

				 echo "<tr>
						   <td>" . $row["Ingredient"] ."</td>
						   <td>" . $row["Quantity"] . "</td>
						   </tr>";
       }
       echo "</table>";
  // close the connection (to be safe)
    mysqli_close($conn);
  }
  else // if the recipe name entered not exists
  {
		 echo "0 results, no such a recipe.";
  }

}
 // click return button
else if(isset($_POST["back"]))
{
  header("Location: MainPage.html");
}
 ?>
