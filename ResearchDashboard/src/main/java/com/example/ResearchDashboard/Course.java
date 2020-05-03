package com.example.ResearchDashboard;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class Course {
	
private String CourseCode;
private String CourseName;

	public Course () {
		
		  String sqlSelectAllPersons = "SELECT * FROM courses";
	      String connectionUrl = "jdbc:mysql://localhost:3306/SD?serverTimezone=UTC";
	       
	      try (Connection conn = DriverManager.getConnection(connectionUrl, "root", "mysqlpass"); 
	              PreparedStatement ps = conn.prepareStatement(sqlSelectAllPersons); 
	    		  ResultSet rs = ps.executeQuery()) {
	          
	          while (rs.next()) {
	             CourseCode = rs.getString("COURSE_CODE");
	             CourseName = rs.getString("COURSE_NAME");
	          }
	      }catch (SQLException e) {
	          // handle the exception
	          System.out.println(e);
		}
	}

	
	public void setCourseCode(String courseCode) {
		this.CourseCode = courseCode;
	}
	
	public String getCourseCode() {
		return CourseCode;
	}
	
	public void setCourseName(String courseName) {
		this.CourseName = courseName;
	}
	
	public String getCourseName() {
		return CourseName;
	}
}
	

