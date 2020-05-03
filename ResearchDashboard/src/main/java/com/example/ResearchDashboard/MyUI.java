package com.example.myapplication;

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
import com.vaadin.ui.Button;
import com.vaadin.ui.Component;
import com.vaadin.ui.CssLayout;
import com.vaadin.ui.CustomLayout;
import com.vaadin.ui.GridLayout;
import com.vaadin.ui.HorizontalLayout;
import com.vaadin.ui.Label;
import com.vaadin.ui.UI;
import com.vaadin.ui.VerticalLayout;


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

    @Override
    protected void init(VaadinRequest vaadinRequest) {
        final VerticalLayout layout = new VerticalLayout();
        layout.addComponent(getTestAndDemos());

        setContent(layout);
    }
    
    
    public static Component getTestAndDemos() {
    	VerticalLayout vl = new VerticalLayout();
		vl.setSpacing(true);

		//vl.addComponent(createBasicDemo());
		vl.addComponent(PieChart());
		
		vl.addComponent(BarChart());
		return vl;
    }
    
    
   private static Component PieChart() {
	   DefaultPieDataset dataset = new DefaultPieDataset();
	   dataset.setValue("Apache", 52);
       dataset.setValue("Nginx", 31);
       dataset.setValue("IIS", 12);
       dataset.setValue("LiteSpeed", 2);
       dataset.setValue("Google server", 1);
       dataset.setValue("Others", 2);
       
       JFreeChart pieChart = ChartFactory.createPieChart(
               "Web servers market share",
               dataset,
               false, true, false);
       
       PiePlot p = (PiePlot) pieChart.getPlot();
       
       
       
       JFreeChart c = new JFreeChart(p);

		return new JFreeChartWrapper(c);

   }
    
    private static Component BarChart() {

    	DefaultCategoryDataset dataset = new DefaultCategoryDataset();
        dataset.setValue(46, "Gold medals", "USA");
        dataset.setValue(38, "Gold medals", "China");
        dataset.setValue(29, "Gold medals", "UK");
        dataset.setValue(22, "Gold medals", "Russia");
        dataset.setValue(13, "Gold medals", "South Korea");
        dataset.setValue(11, "Gold medals", "Germany");
        
        JFreeChart barChart = ChartFactory.createBarChart(
                "Olympic gold medals in London",
                "Country",
                "Gold medals",
                dataset,
                PlotOrientation.VERTICAL,
                false, true, false);

		

		CategoryPlot plot = (CategoryPlot) barChart.getPlot();

		//plot.setRangeGridlinePaint((Paint) Color.BLACK);

		// regression line points

		

		JFreeChart c = new JFreeChart(plot);

		return new JFreeChartWrapper(c);
	}

    @WebServlet(urlPatterns = "/*", name = "MyUIServlet", asyncSupported = true)
    @VaadinServletConfiguration(ui = MyUI.class, productionMode = false)
    public static class MyUIServlet extends VaadinServlet {
    }
}
