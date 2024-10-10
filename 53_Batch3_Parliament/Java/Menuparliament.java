//Author:Swanit Rivankar
//RollNo:2452
//Title:Parliament of India
//Start Date:9 July 2024
//Modified Date:23 July 2024
//Description:This program is implementing the working of parliament of India. It contains various classes to add members to Rajya Sabha and Lok Sabha and also to add the President.


import java.util.Scanner;
public class Menuparliament {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        String pname, vice_p;
        int pterm, pyear, lok_mem, raj_mem, com, t;
        President p1 = new President();
        Parliament l1 = new Loksabha();
        Parliament l2 = new Rajyasabha();
        boolean f=true;
        while(f==true) {
        System.out.print("\nEnter Your Choice:\n1:Enter President Details\n2:Add LokSabha members\n3:Add RajyaSabha Members\n4:Display president Details\n5:Display Loksabha Details\n6:Display Rajyasabha Details\n7:EXIT\n");
        t = s.nextInt();
        switch (t) {
            case 1:
                System.out.printf("\nEnter President name, term and year:\n");
                pname = s.next();
                pterm = s.nextInt();
                pyear = s.nextInt();
                p1.add_president(pname, pterm, pyear);
                break;

            case 2:
                System.out.printf("\nEnter number of LokSabha members to add:\n");
                lok_mem = s.nextInt();
                for (int i = 0; i < lok_mem; i++) {
                    System.out.printf("\nEnter member name and party:\n");
                    String memberName = s.next();
                    String party = s.next();
                    l1.add_member_lok(memberName, party);
                }
                break;

            case 3:
            	System.out.printf("\nEnter number of RajyaSabha members to add:\n");
                raj_mem = s.nextInt();
                for (int i = 0; i < raj_mem; i++) {
                    System.out.printf("\nEnter member name and party:\n");
                    String memberName = s.next();
                    String party = s.next();
                    l2.add_member_raj(memberName, party);
                }
                break;
                
            case 4:
            	p1.display_info();
            	break;
            	
            case 5:
            	l1.display_members_lok();
            	break;
            
            case 6:
            	l2.display_members_raj();
            	break;
            	
            case 7:
            	System.out.println("End Of Code");
            	f=false;
            	break;

            default:
                break;
        }
        }
    }
}
