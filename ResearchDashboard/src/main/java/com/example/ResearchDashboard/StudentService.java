package com.example.ResearchDashboard;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class StudentService {
	Student student = new Student();
	
	public void Student() {
		 String sqlSelectAllPersons = "SELECT * FROM STUDENT";
	      String connectionUrl = "jdbc:mysql://localhost:3306/SD?serverTimezone=UTC";
	       
	      try (Connection conn = DriverManager.getConnection(connectionUrl, "root", "mysqlpass"); 
	              PreparedStatement ps = conn.prepareStatement(sqlSelectAllPersons); 
	    		  ResultSet rs = ps.executeQuery()) {
	          
	          while (rs.next()) {
	        	  student.setID(rs.getString("STUDENT_NUM"));
	        	  student.setRace(rs.getString("RACE"));
	        	  student.setGender(rs.getString("GENDER"));
	        	  student.setLanguage(rs.getString("LANGUAGE"));
	          }
	      }catch (SQLException e) {
	          // handle the exception
	          System.out.println(e);
		}
	}

}
