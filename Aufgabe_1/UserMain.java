package Aufgabe_1;

public class UserMain {
    
    public static void main(String[] args) {
        
        User user = new Userbuilder()
                    .name("Mustermann")
                    .age(21)
                    .build();
        
        user.getInfo();
    }
}
