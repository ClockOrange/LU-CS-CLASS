/*********************************************************
 * FILE: GetTeam.java                                    *
 * AUTHOR: Zhuocheng Shang                               *
 * DATE: 17/11/2017                                      *
 * PURPOSE: class for getting Team list                  *
 *********************************************************/

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class GetTeam {
	public static void Get_Team(Scanner kbd, Statement stmt) throws SQLException {
		
		String myQuery;
		ResultSet rs= null;
		    
		     // select cityName from City table and teamName from Team table
		myQuery = "select cityName,teamName " +
                "from Cities,Teams "+
		          "where Cities.cityCode = Teams.cityCode;";
		
      rs = stmt.executeQuery(myQuery);
      
      boolean nextT = rs.next(); // set boolean to check if the team is empty or not
      
      if(nextT == false) // if it is empty
      {
      	 System.out.println("ERROR: your Teams table is empty");
      }
         // go through each line(row) of the answer table
         while(nextT)
              {	 
	                    // display requested attributes
        	                // will print out city name with team name
             	 System.out.printf("%-20s%-20s",rs.getString("cityName"), rs.getString("teamName"));
        	         System.out.println();
        	         
	             nextT= rs.next(); //update result
               }
       //clean up query results
         rs.close();

	}

}
