package com.example.ResearchDashboard.Testing;

import static org.junit.Assert.*;

import org.junit.Test;
import com.example.ResearchDashboard.Age;
public class AgeTest {
	
	Age  test = new Age();
	

	@Test
	public void testAgeID() {	
		test.setID(123456);
		int result = test.getId();
		assertEquals(123456,result);
	}
	@Test
	public void testAgeDropOutGrad() {		
		test.setDropOut(0);
		int result = test.getDropOutGrad();
		assertEquals(0,result);
	}
	@Test
	public void testAgeYearsInSys() {
		test.setYearsInSys(01);
		int result = test.getYearsInSys();
		assertEquals(01,result);
	}
	@Test
	public void testAgeStudentId() {	
		test.setStudentId("ex");
		String result = test.getStudentId();
		assertEquals("ex",result);
	}
	@Test
	public void testAgeFirstYear() {
		test.setFirstYear(2);
		int result = test.getFirstYear();
		assertEquals(2,result);
	}
	
	@Test
	public void testSetAgeID() {
		test.setID(345678);
		int result = test.getId();
		assertEquals(345678,result);
	}
	@Test
	public void testSetAgeDropOutGrad() {
		test.setDropOut(1);
		int result = test.getDropOutGrad();
		assertEquals(1,result);
	}
	@Test
	public void testSetAgeYearsInSys() {	
		test.setYearsInSys(2);
		int result = test.getYearsInSys();
		assertEquals(2,result);
	}
	@Test
	public void testSetAgeStudentId() {	
		test.setStudentId("r");
		String result = test.getStudentId();
		assertEquals("r",result);
	}
	@Test
	public void testSetAgeFirstYear() {	
		test.setFirstYear(8);
		int result = test.getFirstYear();
		assertEquals(8,result);
	}


}
