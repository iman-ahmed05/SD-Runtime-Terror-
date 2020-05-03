package com.example.ResearchDashboard;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class Enrollment {
	private String CourseInfo;
	
	private String StudentId;
	
	public Enrollment() {
		  String sqlSelectAllPersons = "SELECT * FROM ENROLLMENT";
	      String connectionUrl = "jdbc:mysql://localhost:3306/SD?serverTimezone=UTC";
	       
	      try (Connection conn = DriverManager.getConnection(connectionUrl, "root", "mysqlpass"); 
	              PreparedStatement ps = conn.prepareStatement(sqlSelectAllPersons); 
	    		  ResultSet rs = ps.executeQuery()) {
	          
	          while (rs.next()) {
	             CourseInfo = rs.getString("COURSE_CODE");
	             StudentId = rs.getString("STUDENT_NUM");
	          }
	      }catch (SQLException e) {
	          // handle the exception
	          System.out.println(e);
		}
	}
	
	public void setCourseInfo(String courseInfo) {
		this.CourseInfo = courseInfo;
	}
	
	public String getCourseInfo() {
		return CourseInfo;
	}
	
	public void setStudnetId(String studentId) {
		this.StudentId = studentId;
	}
	
	public String getStudentId() {
		return StudentId;
	}
}
