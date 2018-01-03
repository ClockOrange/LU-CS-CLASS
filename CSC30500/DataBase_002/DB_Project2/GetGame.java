/*********************************************************
 * FILE: GetGame.java                                    *
 * AUTHOR: Zhuocheng Shang                               *
 * DATE: 17/11/2017                                      *
 * PURPOSE: class for getting Game list                  *
 *********************************************************/

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class GetGame {
	public static void Get_Game(Scanner kbd, Statement stmt) throws SQLException
	{
		ResultSet rs = null;
		String myQuery;
		  
		  //select all from Games table
		 myQuery = "select * from Games";
		 
		 rs = stmt.executeQuery(myQuery);
   		 boolean nextG = rs.next(); // set boolean to check if the Games table is empty or not
   		 
   		 if(nextG == false)// if the table is empty
   		    {
   			    System.out.println("ERROR: your Games table is empty.");
   		    }
   		   
   		      // go through each line(row) of the answer table
   		    while(nextG)
   	          {	  
   		    	     // display requested attributes
   		          System.out.printf("%-20s%-10s%-10s%-10s",rs.getString("visitTeam"),
   		                      rs.getInt("visitScore"),
   				              rs.getString("homeTeam"),
   		                      rs.getInt("homeScore"));
   		          System.out.println();
   		          
   		          nextG = rs.next(); //update result 
   	          }
   		    
   		      //clean up query results
   		    rs.close();
	}

}
