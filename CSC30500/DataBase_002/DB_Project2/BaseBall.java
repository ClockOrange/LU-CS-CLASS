/*********************************************************
 * FILE: BaseBall.java                                   *
 * AUTHOR: Zhuocheng Shang                               *
 * DATE: 17/11/2017                                      *
 * PURPOSE: main source file for CSC30500 Project #2     *
 *********************************************************/

import java.sql.*;
import java.util.Scanner;


public class BaseBall {
	 
	   // JDBC driver name and database URL
	 static final String JDBC_DRIVER = "com.mysql.jdbc.Driver";  
	 static final String DB_URL = "jdbc:mysql://lindenwoodcshome.ddns.net/shangz";

		   //  Database credentials
	 static final String USER = "username";
	 static final String PASS = "password";
	
	   public static void main(String[] args)  
	   {
           Scanner kbd = new Scanner(System.in);
		   
		   Connection conn; // the actual mysql server connection
		   Statement stmt;
		   //Connection conn = null;
		   //Statement stmt = null;
		   
	   		// strings for mysql hostname, userid, ...
			String db_host;
			String db_user;
			String db_password;
			String db_name;
		   
			// get user credentials and mysql server info
			System.out.print("Enter MySQL database hostname (or IP adress):");
			db_host = kbd.nextLine();

			System.out.print("Enter MySQL database username:");
			db_user = kbd.nextLine();

			System.out.print("Enter MySQL database password:");
			db_password=kbd.nextLine(); 

			// could also prompt for this, if desired
			db_name=db_user;
			
			db_host = "jdbc:mysql://" + db_host+ "/" + db_name;
			
		   // most mysql calls can cause exceptions,so we'll try to catch them. 
		   try
		   {
			   // set up the client (this machine) to use mysql
			   System.out.print("Initializing client DB subsystem ...");
			   Class.forName("com.mysql.jdbc.Driver");
			   System.out.println("Done.");
			   			   
			   // go out and connect to the mysql server
			   System.out.print("Connecting to remote DB ...");
			   conn = DriverManager.getConnection(db_host,db_user, db_password);
			   System.out.println("DB connection established.");
			   
			   // now, send mysql our query
			   stmt = conn.createStatement();
			   
			  /*****create cities table if not exist******/
	            String sql;
	            sql = "create table if not exists Cities " +
	                    "( cityCode VARCHAR(20) not NULL, " +
	                     " cityName VARCHAR(100) not NULL," +
	                     " PRIMARY KEY (cityCode) );"; 
	            stmt.executeUpdate(sql);
	            
	          /*****create teams table if not exist******/
	           
	            sql = "create table if not exists Teams " +
	                    "( cityCode VARCHAR(20) not NULL, " +
	                     " teamName VARCHAR(50) not NULL, " +
	                     " PRIMARY KEY (cityCode,teamName), FOREIGN KEY (cityCode) REFERENCES Cities(cityCode) );"; 
	            stmt.executeUpdate(sql);
	            
	            
	         /*****create  games table if not exist******/
	              
	            sql = "create table if not exists Games " +
	                    "( visitTeam VARCHAR(50) not NULL, " +
	            		     " visitScore INTEGER, " +
	                     " homeTeam VARCHAR(50) not NULL, " +
	            		     " homeScore INTEGER);"; 
	            stmt.executeUpdate(sql);
	            
	        /*****create  records table if not exist******/
	            
	            sql = "create table if not exists Records " +
	                    "( cityCode VARCHAR(20) not NULL, " + 
	                    "  teamName VARCHAR(50) not NULL," +
	            		     " win INTEGER, " +
	                     " lost INTEGER," +
	            		     " PF INTEGER,"+
	                     " PA INTEGER,"+ " PRIMARY KEY (cityCode,teamName), FOREIGN KEY (cityCode) REFERENCES Cities(cityCode) );"; 
	            stmt.executeUpdate(sql);
	        
	          
			   
	         /*****get user input and update tables******/
	            
	          char command;
	          char type;
	          
	            //run program until type 'q'
	          
	            do {
	            	
	                	System.out.print("enter data >> ");
	                	  //get first command
	             	command = kbd.next().charAt(0);
	             	
	             	  //figure out the condition
	             	switch(command)
	             	{	
	              	     /**************************case a***************************/
	              	  case 'a': //add
	            		        type = kbd.next().charAt(0); //get second command
	            		        
	            		           //figure out the condition
	            		        if(type == 'c') //add city
	            		        {
	            		          AddCity.Add_City(kbd,stmt);  //call Add_City method	
	            		         }
	            		        else if(type == 't')//add team
	            		          	{
	            		        	       AddTeam.Add_Team(kbd, stmt);  //call Add_Team method
	            		         	}
	            		        	else
	            		        		if(type == 'g')//add game
	            		        		{
	            		        			 AddGame.Add_Game(kbd, stmt); //call Add_Game method
	            		        		}
	            		         
	            		   break;
	            		   
	            		   /**************************case l***************************/
	             	  case 'l': //print put list
	             		  
	             		     //get second command
	            		     type = kbd.next().charAt(0);
	            		   
	            		        //figure out the condition
	            		     if(type == 'c') //print out city
	            		     {
	            		    	   GetCity.Get_City(kbd, stmt); //call Get_City method
	            		     }
	            		      else if(type == 't') //print out team
	            			      {
	            		    	        GetTeam.Get_Team(kbd, stmt); // call Get_Team method   
	            			      }
	            			       else if(type =='g') //print out game
	            				       {
	            				         GetGame.Get_Game(kbd, stmt); // call Get_Game method
	            				       }
	            		 
	            		break;
	            		
	            		/**************************case s***************************/
	             	case 'r': //get record
	             		
	            		GetOneRecord.Get_OneR(kbd,stmt); // call Get_OneR method
	            		
	            		break;
	            		
	            		
	            		/**************************case r***************************/
	             	case 's': // get standing
	             		
	            		GetRecord.Get_AllR(kbd,stmt); //call Get_AllR method
	               
	            		break;
	            		
	            		/**************************case d***************************/
	             	case 'd': //delete
	             		
	            		DeleteTeam.D_Team(kbd, stmt); //call D_Team method
	            		
	    		    		break;
	            		
	            		/**************************case m***************************/
	             	case 'm': //move      
	             		
	            		MoveTeam.M_Team(kbd, stmt); // call M_Team method
	            		
	            		break;
	            		
	            		/**************************case q***************************/
	            	    case 'q': //quit
	            		break;
	            		
	            		  // other than command characters, pop up ERROR message
	            	    default: System.out.println("ERROR: Invalid input."); 
	              	break;
	            	}	
	           	
	           }while(command != 'q'); //quit when type in 'q'
	            

	     	   System.out.print("Sending query ..."); 	     		
	     	   
	     	   System.out.println("Done");
	     	   
	     	   

	     	   // clean up query original query stmt
	     	   stmt.close();
	     	   
	     	   //close db connection
	     	   conn.close();
		   }
		   catch(SQLException se)
		   {
			   //Handle errors for JDBC
			   se.printStackTrace();
		   }
		   catch(Exception e)
		   {
			   // Handle any other exceptions
			   System.out.println("Exception"+e);
		   }
	   }
}
