/*********************************************************
 * FILE: GetOneRecord.java                               *
 * AUTHOR: Zhuocheng Shang                               *
 * DATE: 17/11/2017                                      *
 * PURPOSE: class for getting specific one Record        *
 *********************************************************/


import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class GetOneRecord {
	public static void Get_OneR(Scanner kbd, Statement stmt) throws SQLException {
		ResultSet rs = null;
		String myQuery;
		
		String name = kbd.next(); // get team name 
		   
		   // select team record
		myQuery = "SELECT * "+
		           "FROM Records "+
				   "WHERE teamName = \'" +name+"\';";
		
		 rs = stmt.executeQuery(myQuery);
		 boolean nextR = rs.next(); // set up boolean to check if the team exists or not
		 
		 if(nextR == false) // if the team does not exist
		  {
			 System.out.println("ERROR: no such record found.");
		  }
		     // go through each line(row) of the answer table
		   while(nextR)
		 
	     	   {	   
			      System.out.println("====Team====================================W====L====PF====PA");
	     		   // display requested attributes
	     		   System.out.printf("%-44s%1d    %1d   %3d   %3d",rs.getString("teamName"),
	     		                      rs.getInt("win"),
	     		                      rs.getInt("lost"),
	     		                      rs.getInt("PF"),
	     		                       rs.getInt("PA"));
	     		  System.out.println();
	     		  
	     		 nextR = rs.next(); 	  //update result 
	     	   }
		 
		//clean up query results
		rs.close();
	}

}
