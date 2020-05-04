package com.example.ResearchDashboard;

import java.awt.GradientPaint;
import java.awt.Paint;

import javax.servlet.annotation.WebServlet;

import org.jfree.chart.ChartFactory;
import org.jfree.chart.ChartFrame;
import org.jfree.chart.JFreeChart;
import org.jfree.chart.axis.CategoryAxis;
import org.jfree.chart.axis.CategoryLabelPositions;
import org.jfree.chart.axis.NumberAxis;
import org.jfree.chart.plot.CategoryPlot;
import org.jfree.chart.plot.PiePlot;
import org.jfree.chart.plot.PlotOrientation;
import org.jfree.chart.plot.XYPlot;
import org.jfree.chart.renderer.category.BarRenderer;
import org.jfree.chart.renderer.xy.XYLineAndShapeRenderer;
import org.jfree.data.category.CategoryDataset;
import org.jfree.data.category.DefaultCategoryDataset;
import org.jfree.data.general.DefaultPieDataset;
import org.jfree.data.general.PieDataset;
import org.jfree.data.statistics.DefaultBoxAndWhiskerCategoryDataset;
import org.jfree.data.statistics.Regression;
import org.jfree.data.xy.DefaultTableXYDataset;
import org.jfree.data.xy.DefaultXYDataset;
import org.jfree.data.xy.XYSeries;
import org.vaadin.addon.JFreeChartWrapper;

import com.vaadin.annotations.Theme;
import com.vaadin.annotations.VaadinServletConfiguration;
import com.vaadin.server.VaadinRequest;
import com.vaadin.server.VaadinServlet;
import com.vaadin.shared.ui.colorpicker.Color;
import com.vaadin.ui.AbsoluteLayout;
import com.vaadin.ui.Alignment;
import com.vaadin.ui.Button;
import com.vaadin.ui.Component;
import com.vaadin.ui.CssLayout;
import com.vaadin.ui.CustomLayout;
import com.vaadin.ui.GridLayout;
import com.vaadin.ui.HorizontalLayout;
import com.vaadin.ui.Label;
import com.vaadin.ui.Table.Align;
import com.vaadin.ui.UI;
import com.vaadin.ui.VerticalLayout;
import com.vaadin.ui.Window;
import com.vaadin.ui.themes.ValoTheme;
import com.vaadin.annotations.Theme;
import com.vaadin.annotations.VaadinServletConfiguration;
import com.vaadin.server.VaadinRequest;
import com.vaadin.server.VaadinServlet;
import com.vaadin.ui.Button;
import com.vaadin.ui.Label;
import com.vaadin.ui.TextField;
import com.vaadin.ui.UI;
import com.vaadin.ui.VerticalLayout;

/**
 * This UI is the application entry point. A UI may either represent a browser window 
 * (or tab) or some part of a html page where a Vaadin application is embedded.
 * <p>
 * The UI is initialized using {@link #init(VaadinRequest)}. This method is intended to be 
 * overridden to add component to the user interface and initialize non-component functionality.
 */
@Theme("mytheme")
public class MyUI extends UI {
		private VerticalLayout main = new VerticalLayout();
    @Override
    protected void init(VaadinRequest vaadinRequest) {
    	Label heading = new Label("Select Your Query to Filter");
    	HorizontalLayout title = new HorizontalLayout();
    	title.addComponent(heading);
    	HorizontalLayout filter = new HorizontalLayout();
    	heading.setStyleName(ValoTheme.LABEL_H1);
    	Button pie = new Button("Student Status");
        Button bar = new Button("Enrollment Growth");
        filter.addComponents(pie, bar);
        filter.setSpacing(true);
        
        main.addComponents(title, filter);
        main.setComponentAlignment(title, Alignment.MIDDLE_CENTER);
        main.setComponentAlignment(filter, Alignment.MIDDLE_CENTER);
        
        pie.addClickListener(click -> {
        	addWindow(pieFilter());	
        });
        
        bar.addClickListener(click -> {
    		addWindow(barFilter());
        });

        main.setSpacing(true);
        setContent(main);
    }
    
   private static Component PieChart() {
	   DefaultPieDataset dataset = new DefaultPieDataset();
	   dataset.setValue("Excluded", 41.5);
       dataset.setValue("Not Categorised", 11.7);
       dataset.setValue("Proceed", 15.7);
       dataset.setValue("Qualify", 31.1);
       
       JFreeChart pieChart = ChartFactory.createPieChart(
               "Student Outcome Status",
               dataset,
               false, true, false);
       
       PiePlot p = (PiePlot) pieChart.getPlot();
       JFreeChart c = new JFreeChart(p);
	return new JFreeChartWrapper(c);

   }
    
    private static Component BarGraph() {
    	
    	DefaultCategoryDataset dataset = new DefaultCategoryDataset();
        dataset.setValue(1953, "Students Enrolled", "2008");
        dataset.setValue(1044, "Students Enrolled", "2009");
        dataset.setValue(1089, "Students Enrolled", "2010");
        dataset.setValue(1112, "Students Enrolled", "2011");
        dataset.setValue(1067, "Students Enrolled", "2012");
        dataset.setValue(1193, "Students Enrolled", "2013");
        dataset.setValue(1152, "Students Enrolled", "2014");
        dataset.setValue(1307, "Students Enrolled", "2015");
        dataset.setValue(1480, "Students Enrolled", "2016");
        dataset.setValue(1388, "Students Enrolled", "2017");
        dataset.setValue(1541, "Students Enrolled", "2018");
        
        JFreeChart barChart = ChartFactory.createBarChart(
                "Student Enrollemnt by Year",
                "Year",
                "Number Of stduents",
                dataset,
                PlotOrientation.VERTICAL,
                false, true, false);

		CategoryPlot plot = (CategoryPlot) barChart.getPlot();
		JFreeChart c = new JFreeChart(plot);
		return new JFreeChartWrapper(c);
	}
    
    public Window pieFilter() {
    	Window pie = new Window("Student Outcome Status");
    	VerticalLayout enrolment = new VerticalLayout();
    	pie.setContent(enrolment);
    	enrolment.addComponent(PieChart());
    	pie.center();
    	enrolment.setDefaultComponentAlignment(Alignment.MIDDLE_CENTER);
    	return pie;
    }
    
    public Window barFilter() {
    	Window bar = new Window("Student Enrollment Growth Per Year");
    	VerticalLayout studentstatus = new VerticalLayout();
    	bar.setContent(studentstatus);
    	studentstatus.addComponent(BarGraph());
    	bar.center();
    	studentstatus.setDefaultComponentAlignment(Alignment.MIDDLE_CENTER);
    	return bar;
    }

    @WebServlet(urlPatterns = "/*", name = "MyUIServlet", asyncSupported = true)
    @VaadinServletConfiguration(ui = MyUI.class, productionMode = false)
    public static class MyUIServlet extends VaadinServlet {
    }
}
