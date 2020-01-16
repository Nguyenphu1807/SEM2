/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author MyPC
 */
public class Circle {
    //private instance variable
    private double radius;
    private String color;
    
    //contructor khoi tao doi tuong 
    public Circle(){
        radius = 5;
        color = "blue";
    }
    
    public Circle(double radius){
        this.radius = radius;
    }
    
    public Circle(String color){
        this.color = color;
    }
    
    public Circle(double radius , String color){
        this.color = color;
        this.radius = radius;
    }
    
    
    /**
     * lay ra ban kinh
     * @return 
     */
    public double getRadius(){
        return radius;
    }
    /**
     * lay ra mau sac
     */
        public String getColor(){
        return color;
    }
    /**
     * lay ra dien tich
     * @return 
     */
    public double getArea(){
        return radius * radius * Math.PI;
    }
        @Override
    public String toString() {
        return "Circle{" + "radius=" + radius + ", color=" + color + '}';
    }
    
    
}
