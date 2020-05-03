package com.example.ResearchDashboard.Testing;

import static org.junit.Assert.*;

import org.junit.Test;

import com.example.ResearchDashboard.Marks;

public class TestMarks {
	
	Marks test = new Marks();

	@Test
	public void testStuNum() {	
		test.setStudent_Num("q");
		String result = test.getStudent_Num();
		assertEquals("q",result);	
	}
	
	@Test
	public void testAGG_yos1() {	
		test.setAgg_yos1("w");
		String result = test.getAGG_yos1();
		assertEquals("w",result);	
	}
	@Test
	public void testAGG_yos2() {	
		test.setAgg_yos2("e");
		String result = test.getAGG_yos2();
		assertEquals("e",result);	
	}
	@Test
	public void testAGG_yos3() {	
		test.setAgg_yos3("r");
		String result = test.getAGG_yos3();
		assertEquals("r",result);	
	}
	@Test
	public void testProg_yos1() {		
		test.setProg_yos1("t");
		String result = test.getProg_yos1();
		assertEquals("t",result);	
	}
	@Test
	public void testProg_yos2() {	
		test.setProg_yos2("y");
		String result = test.getProg_yos2();
		assertEquals("y",result);	
	}
	@Test
	public void testProg_yos3() {	
		test.setProg_yos3("u");
		String result = test.getProg_yos3();
		assertEquals("u",result);	
	}
	@Test
	public void testFinal() {	
		test.setFinal("i");
		String result = test.getFinal();
		assertEquals("i",result);	
	}
	@Test
	public void testgetId() {	
		test.setID(6);
		int result = test.getId();
		assertEquals(6,result);	
	}
	@Test
	public void testYos1(){		
		test.setYos1("a");
		String result = test.getYos1();
		assertEquals("a",result);	
	}
	@Test
	public void testYos2() {	
		test.setYos2("s");
		String result = test.getYos2();
		assertEquals("s",result);	
	}
	@Test
	public void testYos3() {	
		test.setYos3("d");
		String result = test.getYos3();
		assertEquals("d",result);	
	}
	
	@Test
	public void testSetStuNum() {	
		test.setStudent_Num("h");
		String result = test.getStudent_Num();
		assertEquals("h",result);	
	}
	
	@Test
	public void testSetAGG_yos1() {	
		test.setAgg_yos1("k");
		String result = test.getAGG_yos1();
		assertEquals("k",result);	
	}
	@Test
	public void testSetAGG_yos2() {	
		test.setAgg_yos2("j");
		String result = test.getAGG_yos2();
		assertEquals("j",result);	
	}
	@Test
	public void testSetAGG_yos3() {
		test.setAgg_yos3("g");
		String result = test.getAGG_yos3();
		assertEquals("g",result);	
	}
	@Test
	public void testSetProg_yos1() {	
		test.setProg_yos1("d");
		String result = test.getProg_yos1();
		assertEquals("d",result);	
	}
	@Test
	public void testSetProg_yos2() {	
		test.setProg_yos2("v");
		String result = test.getProg_yos2();
		assertEquals("v",result);	
	}
	@Test
	public void testSetProg_yos3() {	
		test.setProg_yos3("z");
		String result = test.getProg_yos3();
		assertEquals("z",result);	
	}
	@Test
	public void testSetFinal() {	
		test.setFinal("l");
		String result = test.getFinal();
		assertEquals("l",result);	
	}
	@Test
	public void testSetId() {	
		test.setID(9);
		int result = test.getId();
		assertEquals(9,result);	
	}
	@Test
	public void testSetYos1(){		
		test.setYos1("j");
		String result = test.getYos1();
		assertEquals("j",result);	
	}
	@Test
	public void testSetYos2() {		
		test.setYos2("n");
		String result = test.getYos2();
		assertEquals("n",result);	
	}
	@Test
	public void testSetYos3() {		
		test.setYos3("m");
		String result = test.getYos3();
		assertEquals("m",result);	
	}


}
