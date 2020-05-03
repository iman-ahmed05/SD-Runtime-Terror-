package com.example.ResearchDashboard;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class RegistrationService {
	Registration reg = new Registration();
	
	public void Registration () {
		 String sqlSelectAllPersons = "SELECT * FROM REGISTRATION";
	      String connectionUrl = "jdbc:mysql://localhost:3306/SD?serverTimezone=UTC";
	       
	      try (Connection conn = DriverManager.getConnection(connectionUrl, "root", "mysqlpass"); 
	              PreparedStatement ps = conn.prepareStatement(sqlSelectAllPersons); 
	    		  ResultSet rs = ps.executeQuery()) {
	          
	          while (rs.next()) {
	        	  reg.setStart_Year(rs.getInt("START_YEAR"));
	        	  reg.setReg_Start(rs.getInt("REG_START"));
	        	  reg.setReg_End(rs.getInt("REG_END"));
	        	  reg.setID(rs.getInt("REGISTRATION_ID"));
	        	  reg.setStudent_Num(rs.getString("STUDENT_NUM"));
	          }
	      }catch (SQLException e) {
	          // handle the exception
	          System.out.println(e);
		}
	}

}
