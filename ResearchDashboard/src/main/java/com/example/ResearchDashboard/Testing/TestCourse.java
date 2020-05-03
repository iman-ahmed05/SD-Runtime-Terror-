package com.example.ResearchDashboard.Testing;

import static org.junit.Assert.*;

import org.junit.Test;

import com.example.ResearchDashboard.Course;

public class TestCourse {
	
	Course test = new Course();

	@Test
	public void testcoursecode() {
		test.setCourseCode("g");
		String result = test.getCourseCode();
		assertEquals("g",result);
	}
	@Test
	public void testcoursename() {
		test.setCourseName("h");
		String result = test.getCourseName();
		assertEquals("h",result);
	}
	@Test
	public void testSetcoursecode() {
		test.setCourseCode("k");
		String result = test.getCourseCode();
		assertEquals("k",result);
	}
	
	@Test
	public void testsetcoursename() {
		test.setCourseName("f");
		String result = test.getCourseName();
		assertEquals("f",result);
	}

}
