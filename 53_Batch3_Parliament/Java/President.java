//Author:Swanit Rivankar
//RollNo:2452
//Title:Parliament of India
//Start Date:9 July 2024
//Modified Date:23 July 2024
//Description:This program is implementing the working of parliament of India. It contains various classes to add members to Rajya Sabha and Lok Sabha and also to add the President.

public class President{
	int term, year_elec;
	public String pname;
	
	President(){
		this.pname=null;
		this.term=0;
		this.year_elec=0;
	}
	void add_president(String pname, int term, int year_elec) {
		this.pname=pname;
		this.term=term;
		this.year_elec=year_elec;
	}
	
	void display_info() {
		System.out.println("\nPresident Info");
		System.out.printf("Name:"+pname+"\nTerm:"+term+"\nYear Elected:"+year_elec+"\n");
	}
}
