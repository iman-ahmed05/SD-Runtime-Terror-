package com.example.ResearchDashboard;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class HomeService {
	Home home = new Home();
	
	public void Home () {
		 String sqlSelectAllPersons = "SELECT * FROM HOME";
	      String connectionUrl = "jdbc:mysql://localhost:3306/SD?serverTimezone=UTC";
	       
	      try (Connection conn = DriverManager.getConnection(connectionUrl, "root", "mysqlpass"); 
	              PreparedStatement ps = conn.prepareStatement(sqlSelectAllPersons); 
	    		  ResultSet rs = ps.executeQuery()) {
	          
	          while (rs.next()) {
	             home.setProvince(rs.getString("HOME_PROVINCE"));
	             home.setCountry(rs.getString("HOME_COUNTRY"));
	          }
	      }catch (SQLException e) {
	          // handle the exception
	          System.out.println(e);
		}
	}
}
