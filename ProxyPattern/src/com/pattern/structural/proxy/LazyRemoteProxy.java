package com.pattern.structural.proxy;

public class LazyRemoteProxy implements Remote
{
    private RemoteIpm remote = null ;

    public void turnOn() {
        System.out.println("Wrapee"+ this.remote);
        if (this.remote == null) this.remote = new RemoteIpm();
        this.remote.turnOn();
    }

    public void turnOff() {
        System.out.println("Wrapee"+ this.remote);
        if (this.remote == null) this.remote = new RemoteIpm();
        this.remote.turnOff();
    }
}
