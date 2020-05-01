package org.mano.example;

public class Student {
	private String StudentID;
	
	private String Race, Gender, Language,Suburb; //Home??
	//private Boolean NBT;
	
	public Student(String id, String race, String gen, String lang, String sub) {
		StudentID = id;
		Race = race;
		Gender = gen;
		Language = lang;
		Suburb = sub;
		//NBT = nbt;
	}
	
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
	
	public String getSuburb() {
		return Suburb;
	}
	
	public void setSuburb(String sub) {
		Suburb = sub;
	}
	
	

}
