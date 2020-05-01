package org.mano.example;

public class Registration {
	private int Start_Year, Reg_Start, Reg_End, Registration_ID;
	private String Student_Num;
	
	public void setStart_Year(int start) {
		this.Start_Year = start;
	}
	
	public int getStart_Year() {
		return Start_Year;
	}
	
	public void setReg_Start(int start) {
		this.Reg_Start = start;
	}
	
	public int getReg_Start() {
		return Reg_Start ;
	}
	
	public void setReg_End(int end) {
		this.Reg_End = end;
	}
	
	public int getReg_End() {
		return Reg_End ;
	}
	
	public void setID(int id) {
		this.Registration_ID = id;
	}
	
	public int getID() {
		return Registration_ID ;
	}
	
	public void setStudent_Num(String num) {
		this.Student_Num = num;
	}
	
	public String getStudent_Num() {
		return Student_Num;
	}

}
