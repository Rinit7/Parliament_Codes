#Author:Swanit Rivankar
#RollNo:2452
#Title:Parliament of India
#Start Date:9 July 2024
#Modified Date:26 July 2024
#Description:This program is implementing the working of parliament of India. It contains various classes to add members to Rajya Sabha and Lok Sabha and also to add the President.

class Member:
    def __init__(self, name, party):
        self.name = name
        self.party = party

class Loksabha:
    def __init__(self):
        self.members = []
    
    def enter_lok_members(self):
        c = int(input("Enter the number of members you want to enter:\n"))
        print("Enter the Members:")
        for i in range(c):
            name = input(f"Enter member {i+1} name: ")
            party = input(f"Enter member {i+1} party: ")
            self.members.append(Member(name, party))
    
    def show_details(self):
        print("Loksabha Details\nMaximum members: 552\nTerm: 5 Years\nRole: Represents the people of India\n")

    def show_member_details(self):
        if len(self.members) == 0:
            print("No members to display.")
        else:
            print("Loksabha Members:")
            for i, member in enumerate(self.members):
                print(f"Member {i+1}: {member.name}, Party: {member.party}")

class Rajyasabha:
    def __init__(self):
        self.members = []
    
    def enter_raj_members(self):
        c = int(input("Enter the number of members you want to enter:\n"))
        print("Enter the Members:")
        for i in range(c):
            name = input(f"Enter member {i+1} name: ")
            party = input(f"Enter member {i+1} party: ")
            self.members.append(Member(name, party))
    
    def show_details(self):
        print("Rajyasabha Details\nMaximum members: 250\nTerm: 6 Years\nRole: Represents the states and union territories\n")

    def show_member_details(self):
        if len(self.members) == 0:
            print("No members to display.")
        else:
            print("Rajyasabha Members:")
            for i, member in enumerate(self.members):
                print(f"Member {i+1}: {member.name}, Party: {member.party}")

class President:
    def __init__(self):
        self.pname =""
        self.year = 0
    
    def enter_pres_details(self):
        self.pname = input("Enter the name of the President:\n")
        self.year = int(input("Enter the year:\n"))
    
    def show_details(self):
        if self.pname == "":
            print("President Details not entered")
        else:
            print(f"President Details\nName: {self.pname}\nYear: {self.year}\nRole: The president is a part of the parliament and plays a ceremonial role\n")

def main():
    l1 = Loksabha()
    r1 = Rajyasabha()
    p1 = President()

    while True:
        print("\nEnter Your Choice:")
        print("1: To Enter Loksabha Members")
        print("2: To display Loksabha Members")
        print("3: To Enter Rajyasabha Members")
        print("4: To display Rajyasabha Members")
        print("5: To Enter President Details")
        print("6: To Show President Details")
        print("7: To display Loksabha Details")
        print("8: To display Rajyasabha Details")
        print("9: Exit")
        
        s = int(input())
        
        if s == 1:
            l1.enter_lok_members()
        elif s == 2:
            l1.show_member_details()
        elif s == 3:
            r1.enter_raj_members()
        elif s == 4:
            r1.show_member_details()
        elif s == 5:
            p1.enter_pres_details()
        elif s == 6:
            p1.show_details()
        elif s == 7:
            l1.show_details()
        elif s == 8:
            r1.show_details()
        elif s == 9:
            print("End Of Code.")
            break
        else:
            print("Invalid choice. Please try again.")

if __name__ == "__main__":
    main()
