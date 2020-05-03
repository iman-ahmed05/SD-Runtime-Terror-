package com.example.ResearchDashboard;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class EnrollmentService {
	Enrollment enrol = new Enrollment();
	
	public void Enrollment() {
		  String sqlSelectAllPersons = "SELECT * FROM ENROLLMENT";
	      String connectionUrl = "jdbc:mysql://localhost:3306/SD?serverTimezone=UTC";
	       
	      try (Connection conn = DriverManager.getConnection(connectionUrl, "root", "mysqlpass"); 
	              PreparedStatement ps = conn.prepareStatement(sqlSelectAllPersons); 
	    		  ResultSet rs = ps.executeQuery()) {
	          
	          while (rs.next()) {
	             enrol.setCourseInfo(rs.getString("COURSE_CODE"));
	             enrol.setStudnetId(rs.getString("STUDENT_NUM"));
	          }
	      }catch (SQLException e) {
	          // handle the exception
	          System.out.println(e);
		}
	}

}
