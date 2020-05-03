package com.example.ResearchDashboard;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class Student {
	private String StudentID;
	
	private String Race, Gender, Language; 
	
	public Student() {
		 String sqlSelectAllPersons = "SELECT * FROM STUDENT";
	      String connectionUrl = "jdbc:mysql://localhost:3306/SD?serverTimezone=UTC";
	       
	      try (Connection conn = DriverManager.getConnection(connectionUrl, "root", "mysqlpass"); 
	              PreparedStatement ps = conn.prepareStatement(sqlSelectAllPersons); 
	    		  ResultSet rs = ps.executeQuery()) {
	          
	          while (rs.next()) {
	        	  StudentID= rs.getString("STUDENT_NUM");
	        	  Race = rs.getString("RACE");
	        	  Gender = rs.getString("GENDER");
	        	  Language = rs.getString("LANGUAGE");
	          }
	      }catch (SQLException e) {
	          // handle the exception
	          System.out.println(e);
		}
	}
	
	public String getId() {
		return StudentID;
	}
	
	public void setID(String id) {
		StudentID = id;
	}
	
	public String getRace() {
		return Race;
	}
	
	public void setRace(String race) {
		Race = race;
	}
	
	public String getGender() {
		return Gender;
	}
	
	public void setGender(String gen) {
		Gender = gen;
	}
	
	public String getLanguage() {
		return Language;
	}
	
	public void setLanguage(String lang) {
		Language = lang;
	}
	
	
	
	

}
