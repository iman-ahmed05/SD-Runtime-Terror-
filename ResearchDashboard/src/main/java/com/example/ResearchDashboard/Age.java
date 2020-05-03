package com.example.ResearchDashboard;

public class Age {
	private int AgeID, FirstYear, DropOutOrGrad, Years_In_Sys;
	private String StudentID;
	
	public int getId() {
		return AgeID;
	}
	
	public void setID(int id) {
		AgeID = id;
	}
	
	public int getFirstYear() {
		return FirstYear;
	}
	
	public void setFirstYear(int firstyear) {
		FirstYear = firstyear;
	}

	public int getDropOutGrad() {
		return DropOutOrGrad;
	}
	
	public void setDropOut(int dropoutgrad) {
		DropOutOrGrad = dropoutgrad;
	}
	
	public int getYearsInSys() {
		return Years_In_Sys;
	}
	
	public void setYearsInSys(int years) {
		Years_In_Sys = years;
	}
	
	public String getStudentId() {
		return StudentID;
	}
	
	public void setStudentId(String Studentid) {
		StudentID = Studentid;
	}

}
