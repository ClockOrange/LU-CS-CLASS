---------------------------
|    Basic Information     |
---------------------------

Name: Zhuocheng Shang

Date: 06/12/2017

Platform: MacOS


----------------------------------------
|    Special Steps needed to complier   |
----------------------------------------

* set up apache & PHP & mySql for MacOS *
* or use linux - Fedora *


1. Open " logIn.html  " to connect to mysql database through entering host, user name , password
   (you may create a mysql database which has the same name with username at first)

2. " login_handler.php"
    try to connect to mySql and try to create Recipes table and Inventory table

3. " MainPage.php "
   click link and switch to certain response page

4. " CreatePage.php "
    create a recipe or add ingredient to a recipe by entering
    recipe name, Inventory, quantity

5. " ListPage.php "
    list a recipe's ingredients after entering recipe name

6. " BuyPage.php "
    buy all recipe ingredients from the store by entering recipe name

7. " AddPage.php "
    add ingredient to store by entering inventory name and quantity



---------------
|    Bugs     |
---------------
1. may need to check transaction


----------------------------------------
|    Brief Summary for my approaches   |
----------------------------------------
1. create log in page to start a php session
2. connect to database on each page
3. write SQL syntax to create / insert / update / select tables based on condition
4. Execute SQL syntax statement.
6. set transaction in BuyPage.php
7. Give user feedback information


Source:
php & mysqli W3schools
