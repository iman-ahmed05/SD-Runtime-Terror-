package com.example.ResearchDashboard;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class AgeService {
	Age age = new Age();
	
	public void Age() {
		
		  String sqlSelectAllPersons = "SELECT * FROM AGE";
	      String connectionUrl = "jdbc:mysql://localhost:3306/SD?serverTimezone=UTC";
	       
	      try (Connection conn = DriverManager.getConnection(connectionUrl, "root", "mysqlpass"); 
	              PreparedStatement ps = conn.prepareStatement(sqlSelectAllPersons); 
	    		  ResultSet rs = ps.executeQuery()) {
	          
	          while (rs.next()) {
	             age.setID(rs.getInt("AGE_ID")); 
	             age.setFirstYear(rs.getInt("START_AGE"));
	             age.setDropOut(rs.getInt("END_AGE"));
	             age.setStudentId(rs.getString("STUDENT_NUM"));
	             age.setYearsInSys(rs.getInt("YEARS_IN_SYSTEM"));
	          }
	      }catch (SQLException e) {
	          // handle the exception
	          System.out.println(e);
		}
	}
}
