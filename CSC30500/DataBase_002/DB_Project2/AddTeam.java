/*********************************************************
 * FILE: AddTeam.java                                    *
 * AUTHOR: Zhuocheng Shang                               *
 * DATE: 17/11/2017                                      *
 * PURPOSE: class for adding a Team                      *
 *********************************************************/

import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class AddTeam {

	public static void Add_Team(Scanner kbd, Statement stmt)
	{
		String code = kbd.next(); //get city code
	    String name = kbd.nextLine().trim(); // get team name
	    String myQuery;
	    myQuery = "INSERT INTO Teams "+ 
              "VALUES(\'"+code+"\',\'"+name+"\')";

	    try 
	      {
		    stmt.executeUpdate(myQuery); 	 // try to add to table
	       }
	       catch(SQLException e)  // print out error if the city code is wrong
	       {
		    System.out.println("ERROR: "+e);
	       }
	
	    myQuery = "INSERT INTO Records "+   // add new record for this new team
              "VALUES(\'"+code+"\',\'"+name+"\',"+0+","+0+","+0+","+0+")";
	
	      try 
	        {
		       stmt.executeUpdate(myQuery); 	
	         }
	         catch(SQLException e)
	         {
		        System.out.println("ERROR: "+e );
	         }
	}
}
