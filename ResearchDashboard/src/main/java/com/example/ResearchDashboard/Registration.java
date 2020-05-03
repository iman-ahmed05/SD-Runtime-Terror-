package com.example.ResearchDashboard;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class Registration {
	private int Start_Year, Reg_Start, Reg_End, Registration_ID;
	private String Student_Num;
	
	public Registration () {
		 String sqlSelectAllPersons = "SELECT * FROM REGISTRATION";
	      String connectionUrl = "jdbc:mysql://localhost:3306/SD?serverTimezone=UTC";
	       
	      try (Connection conn = DriverManager.getConnection(connectionUrl, "root", "mysqlpass"); 
	              PreparedStatement ps = conn.prepareStatement(sqlSelectAllPersons); 
	    		  ResultSet rs = ps.executeQuery()) {
	          
	          while (rs.next()) {
	        	  Start_Year = rs.getInt("START_YEAR");
	        	  Reg_Start = rs.getInt("REG_START");
	        	  Reg_End = rs.getInt("REG_END");
	        	  Registration_ID = rs.getInt("END_AGE");
	        	  Student_Num = rs.getString("REGISTRATION_ID");
	          }
	      }catch (SQLException e) {
	          // handle the exception
	          System.out.println(e);
		}
	}
	
	public void setStart_Year(int start) {
		this.Start_Year = start;
	}
	
	public int getStart_Year() {
		return Start_Year;
	}
	
	public void setReg_Start(int start) {
		this.Reg_Start = start;
	}
	
	public int getReg_Start() {
		return Reg_Start ;
	}
	
	public void setReg_End(int end) {
		this.Reg_End = end;
	}
	
	public int getReg_End() {
		return Reg_End ;
	}
	
	public void setID(int id) {
		this.Registration_ID = id;
	}
	
	public int getID() {
		return Registration_ID ;
	}
	
	public void setStudent_Num(String num) {
		this.Student_Num = num;
	}
	
	public String getStudent_Num() {
		return Student_Num;
	}

}
