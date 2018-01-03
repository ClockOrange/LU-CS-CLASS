/*********************************************************
 * FILE: AddGame.java                                    *
 * AUTHOR: Zhuocheng Shang                               *
 * DATE: 17/11/2017                                      *
 * PURPOSE: class for adding a Game                      *
 *********************************************************/

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class AddGame {
	public static void Add_Game(Scanner kbd, Statement stmt) throws SQLException {
		
		String myQuery;
		String teamA = kbd.next(); //get visit team name
		int scoreA = kbd.nextInt(); // get visit team score
		String teamB = kbd.next(); // get home team name
		int scoreB = kbd.nextInt(); // get home team score
		
		 // SQL syntax to check team exists or not
		
	    String myTestA = "select * from Teams where Teams.teamName = \'" + teamA +"\';"; //check team A
	    String myTestB = "select * from Teams where Teams.teamName = \'" + teamB +"\';"; // check team B
		ResultSet checkA =null;
		ResultSet checkB =null;
		checkA = stmt.executeQuery(myTestA); //get check team A result
		boolean checkTA = checkA.next();
		checkB = stmt.executeQuery(myTestB); //get check  team B result
		boolean checkTB = checkB.next();
		
		if(checkTA == false || checkTB == false) //if the team does not exist 
		{
			
			System.out.println("ERROR: one team or both teams has not been added.");
			
		}
		else {
			       //SQL syntax for inserting value into table
		        myQuery = "INSERT IGNORE INTO Games "+
		                  "VALUES( \'"+
				           teamA +
				          "\',"+scoreA +
				          ",\'"+teamB+
				          "\',"+ scoreB+
				          ");";

    		        stmt.executeUpdate(myQuery); 	
   
		 	/***** ********* Calculate win, lost, PF, PA **********  ******/ 
    		        
		    //visit team
		 
		     int vwin = 0; //visit team win points
	         int vlost = 0; // visit team lost points
	     
	         int PF = 0;
	         int PA = 0;
		
		   
	         ResultSet rst = null;
		     myQuery = "select * from Records where \'" + teamA +"\' = Records.teamName;";
		     rst = stmt.executeQuery(myQuery);
		     
		       //get current value for visit team
		     while(rst.next())
	     	   {	     		   
                  vwin = rst.getInt("win");
                  vlost = rst.getInt("lost");
                  PF = rst.getInt("PF");
                  PA = rst.getInt("PA");
 			     }
		     
		    if(scoreA < scoreB) // if visit team score < home team score, visit team lost the game
		      {
			      vlost++;
		      }else
			     if(scoreA >scoreB)
			       {
				      vwin++; // if visit team score < home team score, visit team win the game
			        }
		    int vPF= scoreA + PF; // get visit team PF
		    int vPA = scoreB + PA; // get visit team PA
		    
		       //update value in records table
			myQuery = "UPDATE Records "+
			          "SET win ="+vwin+" , lost ="+vlost+" , PF="+vPF +", PA = "+vPA +
			" WHERE Records.teamName = \'"+teamA +"\';";
			stmt.executeUpdate(myQuery); 
			
		   //home team
			
			  int hwin=0; //home team win points
		      int hlost=0; // home team lost points
		      
		      myQuery = "select * from Records where \'" + teamB +"\' = Records.teamName;";
			  rst = stmt.executeQuery(myQuery);
			  
			     //get current value for home team
			  while(rst.next())
   	     	       {	     		   
                       hwin = rst.getInt("win");
                       hlost = rst.getInt("lost");
                       PF = rst.getInt("PF");
                       PA = rst.getInt("PA");
     			    }
			  
			 if(scoreA < scoreB) // if visit team score < home team score, home team win the game
			 {
			
				 hwin++;

			 }else
				 if(scoreA >scoreB) // if visit team score > home team score, home team lost the game
				 {
					
					 hlost++;
				 }
		 
		   int hPF = scoreB + PF; // get home team PF
		   int hPA = scoreA +PA; // get home team PA
		   
		        //update value in records table
			myQuery = "UPDATE Records "+
			          "SET win ="+hwin+" , lost ="+hlost+" , PF="+hPF +", PA = "+hPA +
			" WHERE Records.teamName = \'"+teamB +"\';";
			stmt.executeUpdate(myQuery); 
			
			
			 //clean up query results
			rst.close();
			checkB.close();
			checkA.close();

		}     	      		
		
	}    	      		
		
}
		


