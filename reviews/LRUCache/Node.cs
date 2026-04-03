using System;

public class Node
{
    public App app {get; set;}
    public Node next {get; set;}

    public Node prev{get; set;}


    public Node(App app)
    {
        this.app = app;
        this.next = null;
        this.prev = null;
    }
}