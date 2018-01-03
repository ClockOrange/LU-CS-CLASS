/*********************************************************
 * FILE: MoveTeam.java                                   *
 * AUTHOR: Zhuocheng Shang                               *
 * DATE: 17/11/2017                                      *
 * PURPOSE: class for moving a Team                      *
 *********************************************************/

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class MoveTeam {
	public static void M_Team(Scanner kbd, Statement stmt) throws SQLException
	{
		String myQuery;
		String tname = kbd.next();
		String city = kbd.nextLine().trim();//get new city code 
		
		String testTeam;
		String testCity;
		testTeam = "select * from Teams where Teams.teamName = \'" + tname +"\';"; //check team 
		testCity = "select * from Cities where Cities.cityCode = \'" + city +"\';"; //check city
		
		ResultSet checkT =null;
		ResultSet checkC =null;
		checkT = stmt.executeQuery(testTeam); //get check team result
		boolean checkTeam = checkT.next();
		checkC = stmt.executeQuery(testCity); //get check city result
		boolean checkCity = checkC.next();
		
		if(checkTeam == false || checkCity == false) //if the team does not exist 
		{
			
			System.out.println("ERROR: no such a team / city found, can not be moved.");
			
		}
	    else // if value needed updated
	    {
	    	  
	      	// update team name 's city code in Team table
			myQuery = "UPDATE Teams  SET cityCode = \'" + 
			          city + "\' WHERE teamName = \'" +tname+"\';";
			stmt.executeUpdate(myQuery); 
			
	    	      // update Records table
		    myQuery = "UPDATE Records  SET cityCode = \'" + 
		          city + "\' WHERE teamName = \'" +tname+"\';";
		    stmt.executeUpdate(myQuery); 
		
		    System.out.print("Moving team ..."); 	     		
	     	   
	         System.out.println("Done");
	     
	         checkT.close();//clean up query results
		     checkC.close();
	     
	     	   
	    }
	}
}
