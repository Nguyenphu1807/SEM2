/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lab2;

/**
 *
 * @author MyPC
 */
public class book {
    public static void main(String[] args) {
        Author codeLearn = new Author("Code Learn","abc@gmail.com","m");
        System.out.println("codeLearn");
        codeLearn.setEmail("abcde@gmail.com");
        System.out.println("name is : " + codeLearn.getName());
        System.out.println("email is : " + codeLearn.getEmail());
        System.out.println("gender is : " + codeLearn.getGender());
    }
    
}
