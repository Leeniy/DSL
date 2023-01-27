package Aufgabe_1;

public class User {
    private String name;
    private int age;

        public String getName(){
            return name;
        }

        public void setName(String name){
            this.name = name;
        }

        public int getAge(){
            return age;
        }

        public void setAge(int age){
            this.age = age;
        }

        public void getInfo(){
            System.out.println("Username ist "+ name+ " und der User ist "+ age+ " Jahre alt.");
        }

}