package com.pattern.structural.proxy;

public class Program {
    public  static void main (String[] args)
    {
        Remote remoteProxy = new LazyRemoteProxy();
        remoteProxy.turnOn();
        remoteProxy.turnOff();
    }
}
