package com.example.ResearchDashboard;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class Home {
	
	private String Province;
	
	private String Country;
	
	public Home () {
		 String sqlSelectAllPersons = "SELECT * FROM HOME";
	      String connectionUrl = "jdbc:mysql://localhost:3306/SD?serverTimezone=UTC";
	       
	      try (Connection conn = DriverManager.getConnection(connectionUrl, "root", "mysqlpass"); 
	              PreparedStatement ps = conn.prepareStatement(sqlSelectAllPersons); 
	    		  ResultSet rs = ps.executeQuery()) {
	          
	          while (rs.next()) {
	             Province = rs.getString("HOME_PROVINCE");
	             Country = rs.getString("HOME_COUNTRY");
	          }
	      }catch (SQLException e) {
	          // handle the exception
	          System.out.println(e);
		}
	}
	
	public void setProvince(String province) {
		this.Province = province;
	}
	
	public String getProvince() {
		return Province;
	}
	
	public void setCountry(String country) {
		this.Country = country;
	}
	
	public String getCountry() {
		return Country;
	}
}
