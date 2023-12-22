namespace HR;

public class Person{
    public int id{get;set;}
    public string firstName{get;set;}
    public string lastName{get;set;}

    // public void SetFirstName(string f){

    //         this.firstName = f;

    // }
    
    // public string GetFirstName(){
    //         return this.firstName;
        
    // }
    

//    public void SetLastName(string l){

//             this.lastName = l;

//     }
    
//     public string GetLastName(){
//             return this.lastName;
        
//     }

    public Person(){
        this.id = 45;
        this.firstName = "Ameya";
        this.lastName = "Kulkarni";
    }

    public Person(int i, string f, string l){
        this.id = i;
        this.firstName = f;
        this.lastName = l;
    }

    public string ToString(){
        return "[ id=" + this.id + "first name=" + this.firstName + "last name=" + this.lastName + "]";
    }
}