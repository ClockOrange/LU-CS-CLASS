/*********************************************************
 * FILE: AddCity.java                                    *
 * AUTHOR: Zhuocheng Shang                               *
 * DATE: 17/11/2017                                      *
 * PURPOSE: class for adding a City                      *
 *********************************************************/

import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class AddCity {
	
  public static void Add_City(Scanner kbd, Statement stmt) {
	    
     	  String code = kbd.next(); //get city code
     	  String name = kbd.nextLine().trim(); // get city name and reducing white spaces
     	  
     	     //create SQL syntax
     	  String myQuery = "INSERT INTO Cities "+
                   "VALUES(\'"+code+"\',\'"+name+"\')";
     	  
     	  try 
     	  {
     		stmt.executeUpdate(myQuery); 	
     	  }
     	   catch(SQLException e) //Handle errors for JDBC
		   {
			  System.out.println("ERROR: "+e); 
		   }
       	   		 
 }
  
}
