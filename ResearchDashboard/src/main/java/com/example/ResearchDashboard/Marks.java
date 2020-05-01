package org.mano.example;

public class Marks {
	private String STUDENT_NUM, AGG_YOS1, AGG_YOS2, AGG_YOS3, PROG_O_YOS1, PROG_O_YOS2, PROG_O_YOS3, FINAL_OUT;
	private String YOS1_OUT, YOS2_OUT, YOS3_OUT;
	private int AGG_ID;
	
	public Marks(String Student_num, String Agg_yos1, String Agg_yos2, String agg_yos3, String Prog1, String Prog2, String Prog3, String FinalOut, int agg_id, String Yos1, String Yos2, String Yos3 ) {
		STUDENT_NUM = Student_num;
		AGG_YOS1 = Agg_yos1;
		AGG_YOS2 = Agg_yos2;
		AGG_YOS3 = agg_yos3;
		PROG_O_YOS1 = Prog1;
		PROG_O_YOS2 = Prog2;
		PROG_O_YOS3 = Prog3;
		FINAL_OUT = FinalOut;
		AGG_ID = agg_id;
		YOS1_OUT = Yos1;
		YOS2_OUT = Yos2;
		YOS3_OUT =	Yos3;
	}
	
	public int getId() {
		return AGG_ID;
	}
	
	public void setID(int id) {
		AGG_ID = id;
	}
	
	public String getStudent_Num() {
		return STUDENT_NUM;
	}
	
	public void setStudent_Num(String Student_num) {
		STUDENT_NUM = Student_num;
	}
	
	public String getAGG_yos1() {
		return AGG_YOS1;
	}
	
	public void setAgg_yos1(String yos1) {
		AGG_YOS1 = yos1;
	}
	
	public String getAGG_yos2() {
		return AGG_YOS2;
	}
	
	public void setAgg_yos2(String yos2) {
		AGG_YOS2 = yos2;
	}
	
	public String getAGG_yos3() {
		return AGG_YOS3;
	}
	
	public void setAgg_yos3(String yos3) {
		AGG_YOS1 = yos3;
	}
	
	public String getProg_yos1() {
		return PROG_O_YOS1;
	}
	
	public void setProg_yos1(String yos1) {
		PROG_O_YOS1 = yos1;
	}
	public String getProg_yos2() {
		return PROG_O_YOS2;
	}
	
	public void setProg_yos2(String yos2) {
		PROG_O_YOS2 = yos2;
	}
	
	public String getProg_yos3() {
		return PROG_O_YOS3;
	}
	
	public void setProg_yos3(String yos3) {
		PROG_O_YOS3 = yos3;
	}
	
	public String getYos1() {
		return YOS1_OUT;
	}
	
	public void setYos1(String yos1) {
		YOS1_OUT = yos1;
	}
	public String getYos2() {
		return YOS2_OUT;
	}
	
	public void setYos2(String yos2) {
		YOS2_OUT = yos2;
	}
	
	public String getYos3() {
		return YOS3_OUT;
	}
	
	public void setYos3(String yos3) {
		YOS3_OUT = yos3;
	}
	
	public String getFinal() {
		return FINAL_OUT;
	}
	
	public void setFinal(String f) {
		FINAL_OUT = f;
	}

}
