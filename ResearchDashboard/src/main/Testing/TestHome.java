package com.example.ResearchDashboard.Testing;

import static org.junit.Assert.*;

import org.junit.Test;

import com.example.ResearchDashboard.Home;

public class TestHome {
	
	Home test = new Home();

	@Test
	public void testcountry() {
		test.setCountry("g");
		String result = test.getCountry();
		assertEquals("g",result);
	}
	
	@Test
	public void testProvince() {
		test.setProvince("f");
		String result = test.getProvince();
		assertEquals("f",result);
	}
	
	@Test
	public void testSetcountry() {
		test.setCountry("k");
		String result = test.getCountry();
		assertEquals("k",result);
	}
	
	@Test
	public void testSetProvince() {
		test.setProvince("b");
		String result = test.getProvince();
		assertEquals("b",result);
	}

}
