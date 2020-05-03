package com.example.ResearchDashboard;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class Age {
	private int AgeID, FirstYear, DropOutOrGrad, Years_In_Sys;
	private String StudentID;
	
	public Age() {
		
		  String sqlSelectAllPersons = "SELECT * FROM AGE";
	      String connectionUrl = "jdbc:mysql://localhost:3306/SD?serverTimezone=UTC";
	       
	      try (Connection conn = DriverManager.getConnection(connectionUrl, "root", "mysqlpass"); 
	              PreparedStatement ps = conn.prepareStatement(sqlSelectAllPersons); 
	    		  ResultSet rs = ps.executeQuery()) {
	          
	          while (rs.next()) {
	             AgeID = rs.getInt("AGE_ID");
	             FirstYear = rs.getInt("START_AGE");
	             DropOutOrGrad = rs.getInt("END_AGE");
	             StudentID = rs.getString("STUDENT_NUM");
	          }
	      }catch (SQLException e) {
	          // handle the exception
	          System.out.println(e);
		}
	}
	
	public int getId() {
		return AgeID;
	}
	
	public void setID(int id) {
		AgeID = id;
	}
	
	public int getFirstYear() {
		return FirstYear;
	}
	
	public void setFirstYear(int firstyear) {
		FirstYear = firstyear;
	}

	public int getDropOutGrad() {
		return DropOutOrGrad;
	}
	
	public void setDropOut(int dropoutgrad) {
		DropOutOrGrad = dropoutgrad;
	}
	
	public int getYearsInSys() {
		return Years_In_Sys;
	}
	
	public void setYearsInSys(int years) {
		Years_In_Sys = years;
	}
	
	public String getStudentId() {
		return StudentID;
	}
	
	public void setStudentId(String Studentid) {
		StudentID = Studentid;
	}

}
