package com.pattern.structural.proxy;

public class RemoteIpm implements Remote {

    public void turnOn()
    {
        System.out.println("TURN ON");
    }

    public  void turnOff()
    {
        System.out.println("TURN OFF");
    }
}
