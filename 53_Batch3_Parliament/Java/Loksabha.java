//Author:Swanit Rivankar
//RollNo:2452
//Title:Parliament of India
//Start Date:9 July 2024
//Modified Date:23 July 2024
//Description:This program is implementing the working of parliament of India. It contains various classes to add members to Rajya Sabha and Lok Sabha and also to add the President.

import java.util.ArrayList;
import java.util.List;

class Loksabha extends Parliament{
    List<Mem> members = new ArrayList<>();

    void add_member_lok(String name, String party) {
        members.add(new Mem(name, party));
    }

    void display_members_lok() {
    	System.out.println("\nLokSabha Details:");
    	System.out.println("Role: Represents the people of India\nMaximum members: 552\nTerm: 5 Years");
    	System.out.println("\nLokSabha Members:");
    	if(members.isEmpty()) {
    		System.out.println("No Members added");
    	}
    	else {
    		for (Mem member : members) {
                System.out.println("Name: " + member.name + ", Party: " + member.party);
            }
    	}
        
    }
}
