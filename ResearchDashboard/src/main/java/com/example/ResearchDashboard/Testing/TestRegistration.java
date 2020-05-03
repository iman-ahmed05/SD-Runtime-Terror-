package com.example.ResearchDashboard.Testing;

import static org.junit.Assert.*;

import org.junit.Test;

import com.example.ResearchDashboard.Registration;

public class TestRegistration {
	Registration test = new Registration();

	@Test
	public void testStart_Year() {
		test.setStart_Year(1);
		int result = test.getStart_Year();
		assertEquals(1,result);
	}
	@Test
	public void testReg_Start() {
		test.setReg_Start(2);
		int result = test.getReg_Start();
		assertEquals(2,result);
	}
	@Test
	public void testReg_End() {
		test.setReg_End(3);
		int result = test.getReg_End();
		assertEquals(3,result);
	}
	@Test
	public void testgetID()  {
		test.setID(4) ;
		int result = test.getID() ;
		assertEquals(4,result);
	}
	@Test
	public void testStudent_Num() {
		test.setStudent_Num("u");
		String result = test.getStudent_Num();
		assertEquals("u",result);
	}
	
	@Test
	public void testSetStart_Year() {
		test.setStart_Year(2);
		int result = test.getStart_Year();
		assertEquals(2,result);
	}
	@Test
	public void testSetReg_Start() {
		test.setReg_Start(6);
		int result = test.getReg_Start();
		assertEquals(6,result);
	}
	@Test
	public void testSetReg_End() {
		test.setReg_End(8);
		int result = test.getReg_End();
		assertEquals(8,result);
	}
	@Test
	public void testSetID()  {
		test.setID(5) ;
		int result = test.getID() ;
		assertEquals(5,result);
	}
	@Test
	public void testSetStudent_Num() {
		 test.setStudent_Num("j");
		String result = test.getStudent_Num();
		assertEquals("j",result);
	}
	

}
