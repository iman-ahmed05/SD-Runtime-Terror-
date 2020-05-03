package com.example.ResearchDashboard.Testing;

import static org.junit.Assert.*;

import org.junit.Test;

import com.example.ResearchDashboard.Enrollment;

public class TestEnrollment {
	
	Enrollment test = new Enrollment();

	@Test
	public void testCourseInfo() {
		test.setCourseInfo("G");
		String result = test.getCourseInfo();
		assertEquals(result,"G");
	}
	
	@Test
	public void testStudentId() {
		test.setStudnetId("H");
		String result = test.getStudentId();
		assertEquals(result,"H");
	}
	
	@Test
	public void testSetCourseInfo() {
		test.setCourseInfo("j");
		String result = test.getCourseInfo();
		assertEquals(result,"j");
	}
	
	@Test
	public void testSetStudentId() {
		test.setStudnetId("k");
		String result = test.getStudentId();
		assertEquals(result,"k");
	}

}
