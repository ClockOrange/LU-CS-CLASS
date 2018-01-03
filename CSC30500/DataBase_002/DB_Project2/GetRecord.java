/*********************************************************
 * FILE: GetRecord.java                                  *
 * AUTHOR: Zhuocheng Shang                               *
 * DATE: 17/11/2017                                      *
 * PURPOSE: class for getting Record list                *
 *********************************************************/

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class GetRecord {
	public static void Get_AllR(Scanner kbd, Statement stmt) throws SQLException {
		
		ResultSet rs = null;
		String myQuery;
		      
		      //get  teamName, win , lost, PF, PA from Records table, and sort 
		myQuery = "SELECT teamName,win,lost,PF,PA,(win/lost) AS winPercent,(win+lost) AS total "+
		           "FROM Records "+
				   "ORDER BY winPercent DESC ,total DESC ,teamName ASC;"; //sort data 
		
		
		 rs = stmt.executeQuery(myQuery);
		 boolean hasNext = rs.next(); //set boolean to check if the Records table is empty or not
		 
		 if(hasNext == false) // if the table is empty
		 {
			 System.out.println("ERROR: your records table is empty");
		 }
		 else // if not empty 
		 {
			 System.out.println("====Team====================================W====L====PF====PA");
		 }
		 
		    // go through each line(row) of the answer table
		 while(hasNext)
     	   {	     		   
     		  
     		   // display requested attributes
			 System.out.printf("%-44s%1d    %1d   %3d   %3d",rs.getString("teamName"),
                      rs.getInt("win"),
                      rs.getInt("lost"),
                      rs.getInt("PF"),
                       rs.getInt("PA"));
             System.out.println();
             
             hasNext = rs.next(); // update result
     	   }    
		 
		//clean up query results
		 rs.close();
	}
}
