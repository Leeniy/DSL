package Aufgabe_1;

public class Userbuilder {
    
    private User user;

    public Userbuilder(){
        this.user = new User();
    }

    public Userbuilder name (String name){
        this.user.setName(name);
        return this;
    }

    public Userbuilder age (int age){
        this.user.setAge(age);
        return this;
    }

    public User build(){
        return this.user;
    }

}
