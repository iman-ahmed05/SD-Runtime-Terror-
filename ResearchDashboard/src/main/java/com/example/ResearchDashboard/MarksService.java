package com.example.ResearchDashboard;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class MarksService {
	Marks mark = new Marks();

	public void Marks () {
		
		 String sqlSelectAllPersons = "SELECT * FROM MARKS";
	      String connectionUrl = "jdbc:mysql://localhost:3306/SD?serverTimezone=UTC";
	       
	      try (Connection conn = DriverManager.getConnection(connectionUrl, "root", "mysqlpass"); 
	              PreparedStatement ps = conn.prepareStatement(sqlSelectAllPersons); 
	    		  ResultSet rs = ps.executeQuery()) {
	          
	          while (rs.next()) {
	        	  mark.setStudent_Num(rs.getString("STUDENT_NUM"));
	        	  mark.setAgg_yos1(rs.getString("AGG_YOS1"));
	        	  mark.setAgg_yos2(rs.getString("AGG_YOS2"));
	        	  mark.setAgg_yos3(rs.getString("AGG_YOS3"));
	        	  mark.setProg_yos1(rs.getString("PROG_O_YOS1"));
	        	  mark.setProg_yos2(rs.getString("PROG_O_YOS2"));
	        	  mark.setProg_yos3(rs.getString("PROG_O_YOS3"));
	        	  mark.setFinal(rs.getString("YOS3_OUT"));
	        	  mark.setYos1(rs.getString("YOS1_OUT")); 
	        	  mark.setYos2(rs.getString("YOS2_OUT")); 
	        	  mark.setYos3(rs.getString("YOS3_OUT"));
	        	  
	        	  mark.setID(rs.getInt("AGG_ID")); 
	          }
	      }catch (SQLException e) {
	          // handle the exception
	          System.out.println(e);
		}
	}
}
