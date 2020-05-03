package com.example.ResearchDashboard.Testing;

import static org.junit.Assert.*;

import org.junit.Test;

import com.example.ResearchDashboard.Student;

public class TestStudent {
	Student test = new Student();

	@Test
	public void testId() {
		test.setID("Q");
		String result = test.getId();
		assertEquals(result, "Q");			
	}
	@Test
	public void testRace() {
		test.setRace("W");
		String result = test.getRace();
		assertEquals(result, "W");			
	}
	@Test
	public void testGender() {
		test.setGender("E");
		String result = test.getGender();
		assertEquals(result, "E");			
	}
	@Test
	public void testLanguage() {
		test.setLanguage("R");
		String result = test.getLanguage();
		assertEquals(result, "R");			
	}
	
	@Test
	public void testSetId() {
		test.setID("k");
		String result = test.getId();
		assertEquals(result, "k");			
	}
	@Test
	public void testSetRace() {
		test.setRace("g");
		String result = test.getRace();
		assertEquals(result, "g");			
	}
	@Test
	public void testSetGender() {
		test.setGender("b");
		String result = test.getGender();
		assertEquals(result, "b");			
	}
	@Test
	public void testSetLanguage() {
		test.setLanguage("f");
		String result = test.getLanguage();
		assertEquals(result, "f");			
	}
	


}
