package com.example.ResearchDashboard;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class CourseService {
	
	Course course = new Course();
	public void Course () {
		
		  String sqlSelectAllPersons = "SELECT * FROM courses";
	      String connectionUrl = "jdbc:mysql://localhost:3306/SD?serverTimezone=UTC";
	       
	      try (Connection conn = DriverManager.getConnection(connectionUrl, "root", "mysqlpass"); 
	              PreparedStatement ps = conn.prepareStatement(sqlSelectAllPersons); 
	    		  ResultSet rs = ps.executeQuery()) {
	          
	          while (rs.next()) {
	             course.setCourseCode(rs.getString("COURSE_CODE"));
	             course.setCourseName(rs.getString("COURSE_NAME"));
	          }
	      }catch (SQLException e) {
	          // handle the exception
	          System.out.println(e);
		}
	}

}
