/*********************************************************
 * FILE: DeleteTeam.java                                 *
 * AUTHOR: Zhuocheng Shang                               *
 * DATE: 17/11/2017                                      *
 * PURPOSE: class for deleting a Team                    *
 *********************************************************/

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class DeleteTeam {
	public static void D_Team(Scanner kbd, Statement stmt) throws SQLException
	{
		 String myQuery;
		 String team = kbd.next(); // get team name needed to be deleted
		 
		 String myTest = "select * from Teams where Teams.teamName = \'" + team +"\';"; //check team for delete
		 ResultSet check =null;
		 check = stmt.executeQuery(myTest); // get check result
		 boolean checkD = check.next();
		 
		 if(checkD == false) // if not find the team
		 {
			 System.out.println("No such a team found."); 	  	
		 }
		 else
		 {
		           // delete team from Teams table
		         myQuery = "DELETE FROM "+ 
		                   "Teams "+
				           "WHERE Teams.teamName = \'"+team +"\';";	
		
		         stmt.executeUpdate(myQuery);
	 
		           // delete team from Games table
		         myQuery = "DELETE FROM "+ 
         	              "Games "+
				          "WHERE Games.visitTeam = \'"+
         	               team +
         	               "\' OR Games.homeTeam = \'" +team+"\';";
                 stmt.executeUpdate(myQuery); 
        
         
                  // delete team from Records table
                myQuery = "DELETE FROM "+ 
            		          "Records "+"WHERE Records.teamName = \'"+team +"\';";	
            		          stmt.executeUpdate(myQuery); 
            		
                System.out.print("Deleting team ..."); 	     		
      	     	   
      	       System.out.println("Done");
      	       
      	      check.close();
		 }
        
	}
}
