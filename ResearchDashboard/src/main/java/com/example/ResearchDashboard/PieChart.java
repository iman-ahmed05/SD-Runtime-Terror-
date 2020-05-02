package com.example.ResearchDashboard;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import com.github.appreciated.apexcharts.ApexCharts;
import com.github.appreciated.apexcharts.ApexChartsBuilder;
import com.github.appreciated.apexcharts.config.builder.ChartBuilder;
import com.github.appreciated.apexcharts.config.builder.LegendBuilder;
import com.github.appreciated.apexcharts.config.builder.ResponsiveBuilder;
import com.github.appreciated.apexcharts.config.chart.Type;
import com.github.appreciated.apexcharts.config.legend.Position;
import com.github.appreciated.apexcharts.config.locale.builder.OptionsBuilder;
import com.vaadin.flow.component.Component;
import com.vaadin.flow.component.html.Div;

public class PieChart extends Div {
	private Statement statement;
	String query;
	
	public void initialiseDB() {
		try{
			   Class.forName("com.mysql.jdbc.Driver");
			   //change the local host
			   Connection connection = DriverManager.getConnection("jdbc:mysql://localhost/mysql?useUnicode=yes&characterEncoding=UTF-8","root","");
			   statement=connection.createStatement();  
			 }
			 catch(Exception ex){
			  ex.printStackTrace();
			  }	
	}
	
	public String DB() {
		initialiseDB();
		String sql = "SELECT YOS3_OUT, COUNT(*) FROM MARKS GROUP BY YOS3_OUT;";
		try {
		ResultSet rset = statement.executeQuery(sql);
			while(rset.next()) {
				query = rset.getString("YOS3_OUT") + " " + rset.getString("COUNT");
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return sql;
	}
	public PieChart() {
		ApexCharts piechart = ApexChartsBuilder.get()
		.withChart(ChartBuilder.get().withType(Type.pie).build())
		.withLabels("Excluded","Not Categorised","Qualified","Proceed")
		.withLegend(LegendBuilder.get().withPosition(Position.right).build())
	    .withSeries(5939.0,1674.0,4465.0,2248.0)
	    .build();
	    add(piechart);
	    setWidth("100%");
		
	}

}
