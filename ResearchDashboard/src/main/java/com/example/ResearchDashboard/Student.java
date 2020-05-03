package com.example.ResearchDashboard;

public class Student {
	private String StudentID;
	
	private String Race, Gender, Language; 
	
	public String getId() {
		return StudentID;
	}
	
	public void setID(String id) {
		StudentID = id;
	}
	
	public String getRace() {
		return Race;
	}
	
	public void setRace(String race) {
		Race = race;
	}
	
	public String getGender() {
		return Gender;
	}
	
	public void setGender(String gen) {
		Gender = gen;
	}
	
	public String getLanguage() {
		return Language;
	}
	
	public void setLanguage(String lang) {
		Language = lang;
	}

}
