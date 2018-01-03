/*********************************************************
 * FILE: GetCity.java                                    *
 * AUTHOR: Zhuocheng Shang                               *
 * DATE: 17/11/2017                                      *
 * PURPOSE: class for getting City list                  *
 *********************************************************/


import java.util.Scanner;
import java.sql.*;

public class GetCity {
	
	public static void Get_City(Scanner kbd, Statement stmt) throws SQLException 
	{
		  String myQuery;
		  ResultSet rs= null;
		  
		    //select all in the Cities table
		  myQuery = "select * from Cities";
		 
		  rs = stmt.executeQuery(myQuery);
		
		   boolean nextC = rs.next(); // boolean to check if the table is empty or not
		   
		   if(nextC == false) // check boolean
		   {
			   System.out.println("ERROD: your Cities table is empty.");
		   }
		
		   // go through each line(row) of the answer table
		  while(nextC)
		      {	     		   		   
			    // display requested attributes
			    System.out.printf("%-20s%-20s",rs.getString("cityCode"),rs.getString("cityName"));
				System.out.println();
				nextC = rs.next();
		       }
		
		  //clean up query results
		rs.close();
	} 
	

}
