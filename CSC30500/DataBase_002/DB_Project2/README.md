---------------------------
|    Basic Information     |
---------------------------

Name: Zhuocheng Shang

Date: 17/11/2017

Platform: MacOS


----------------------------------------
|    Special Steps needed to complier   |
----------------------------------------

import into Eclipse and run program OR run with terminal.
 
*NOTICE* EACH INPUT DATA SHOULD BE ON ONE LINE *NOTICE*
1. connect to mysql database through type URL, user name , password
   (you may create a mysql database before run as application)

2. enter 'a' for add. 
   - if enter "a c stl Saint Louis", will store city code (stl) and city name (Saint Louis) into a file.
   - if enter "a t stl Cardinals", will store city code (stl) and team name (Cardinals) into a file.
   - if enter "a g Cubs 3 Cardinals 5" 
     will store both visit team (Cubs) and home team (Cardinals)'s name and score in a game.
     
3. enter 'l' for print
   - if enter "l c", will print out all city code and city name added.
   - if enter "l t", will print out all city name and team name added.
   - if enter " l g", will print out all games' information added.
   
4. enter 'r' for printing specific team's game data (record)
   - if enter "r Cubs", will print out team (Cubs) 's total number of wins, total number of 
     losses,total point scored, and total points scored against it.

5. enter 's' for listing all team's total number of wins, total number of 
     losses,total point scored, and total points scored against it.

6. enter 'q' to quit the program.




---------------
|    Bugs     |
---------------
1. Can not pop up alert message when try to Delete non-exist team.

2. Still will add Game to database if just one of two team in the Team table.
   For example, type input "a g Cubs 6 Blues 8" when "Blues" has not been added, but 
   still will add to Game table. 
3. For deleting team. If only want to delete one team, this system will delete both teams from database.



----------------------------------------
|    Brief Summary for my approaches   |
----------------------------------------
1. Set connection to MySQL database.
2. Get user input by using Scanner. 
3. Figure out condition.
4. Write SQL syntax as a string. 
5. Execute SQL syntax statement.
6. Pop up ERROR message if needed.

   
others:  (methods in my program)

1. int getDiff()  //return point differentials
2. void printTeam() // print game records   
      
      
