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
import org.jfree.chart.plot.PlotOrientation;
import org.jfree.chart.plot.XYPlot;
import org.jfree.chart.renderer.category.BarRenderer;
import org.jfree.chart.renderer.xy.XYLineAndShapeRenderer;
import org.jfree.data.category.CategoryDataset;
import org.jfree.data.category.DefaultCategoryDataset;
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
    
    public static JFreeChartWrapper createBasicDemo() {
    	JFreeChart createchart = createchart(createDataset());
    	return new JFreeChartWrapper(createchart(null));
    }
    
    private static CategoryDataset createDataset() {
    	// row keys...
    			String series1 = "First";
    			String series2 = "Second";
    			String series3 = "Third";

    			// column keys...
    			String category1 = "Category 1";
    			String category2 = "Category 2";
    			String category3 = "Category 3";
    			String category4 = "Category 4";
    			String category5 = "Category 5";

    			// create the dataset...
    			DefaultCategoryDataset dataset = new DefaultCategoryDataset();

    			dataset.addValue(1.0, series1, category1);
    			dataset.addValue(4.0, series1, category2);
    			dataset.addValue(3.0, series1, category3);
    			dataset.addValue(5.0, series1, category4);
    			dataset.addValue(5.0, series1, category5);

    			dataset.addValue(5.0, series2, category1);
    			dataset.addValue(7.0, series2, category2);
    			dataset.addValue(6.0, series2, category3);
    			dataset.addValue(8.0, series2, category4);
    			dataset.addValue(4.0, series2, category5);

    			dataset.addValue(4.0, series3, category1);
    			dataset.addValue(3.0, series3, category2);
    			dataset.addValue(2.0, series3, category3);
    			dataset.addValue(3.0, series3, category4);
    			dataset.addValue(6.0, series3, category5);

    			return dataset;
    	
    }
    
    private static JFreeChart createchart(CategoryDataset dataset) {
    	JFreeChart chart = ChartFactory.createBarChart("Bar Chart Demo 1", // chart
				// title
				"Category", // domain axis label
				"Value", // range axis label
				dataset, // data
				PlotOrientation.VERTICAL, // orientation
				true, // include legend
				true, // tooltips?
				false // URLs?
				);
    	
    	chart.setBackgroundPaint((Paint) Color.WHITE);
    	CategoryPlot plot = (CategoryPlot) chart.getPlot();
		plot.setBackgroundPaint((Paint) Color.YELLOW);
		plot.setDomainGridlinePaint((Paint) Color.WHITE);
		plot.setDomainGridlinesVisible(true);
		plot.setRangeGridlinePaint((Paint) Color.WHITE);
		final NumberAxis rangeAxis = (NumberAxis) plot.getRangeAxis();
		rangeAxis.setStandardTickUnits(NumberAxis.createIntegerTickUnits());
		/*BarRenderer renderer = (BarRenderer) plot.getRenderer();
		GradientPaint gp0 = new GradientPaint(0.0f, 0.0f,new Color.blue, 0.0f,
				0.0f, new Color(0, 0, 64));
		GradientPaint gp1 = new GradientPaint(0.0f, 0.0f, Color.green, 0.0f,
				0.0f, new Color(0, 64, 0));
		GradientPaint gp2 = new GradientPaint(0.0f, 0.0f, Color.red, 0.0f,
				0.0f, new Color(64, 0, 0));
		renderer.setSeriesPaint(0, gp0);
		renderer.setSeriesPaint(1, gp1);
		renderer.setSeriesPaint(2, gp2);
		*/

		CategoryAxis domainAxis = plot.getDomainAxis();
		domainAxis.setCategoryLabelPositions(CategoryLabelPositions
				.createUpRotationLabelPositions(Math.PI / 6.0));
		// OPTIONAL CUSTOMISATION COMPLETED.

		return chart;
    }
    
    public static Component getTestAndDemos() {
    	VerticalLayout vl = new VerticalLayout();
		//vl.setSpacing(true);

		//vl.addComponent(createBasicDemo());
		
		vl.addComponent(regressionChart());
		
		return vl;
    }
    
    private static Component regressionChart() {

		DefaultTableXYDataset ds = new DefaultTableXYDataset();

		XYSeries series;

		series = new XYSeries("BAR", false, false);
		series.add(1, 1);
		series.add(2, 4);
		series.add(3, 6);
		series.add(4, 9);
		series.add(5, 9);
		series.add(6, 11);
		ds.addSeries(series);

		JFreeChart scatterPlot = ChartFactory.createScatterPlot("Regression",
				"X", "Y", ds, PlotOrientation.HORIZONTAL, true, false, false);

		XYPlot plot = (XYPlot) scatterPlot.getPlot();

		double[] regression = Regression.getOLSRegression(ds, 0);

		// regression line points

		double v1 = regression[0] + regression[1] * 1;
		double v2 = regression[0] + regression[1] * 6;

		DefaultXYDataset ds2 = new DefaultXYDataset();
		ds2.addSeries("regline", new double[][] { new double[] { 1, 6 },
				new double[] { v1, v2 } });
		plot.setDataset(1, ds2);
		plot.setRenderer(1, new XYLineAndShapeRenderer(true, false));

		JFreeChart c = new JFreeChart(plot);

		return new JFreeChartWrapper(c);
	}

    @WebServlet(urlPatterns = "/*", name = "MyUIServlet", asyncSupported = true)
    @VaadinServletConfiguration(ui = MyUI.class, productionMode = false)
    public static class MyUIServlet extends VaadinServlet {
    }
}
