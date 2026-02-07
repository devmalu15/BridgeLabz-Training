using System;

public class Cache
{
    public int fixedSize {get; set;}
    public Node head {get; set;}
    public Node tail {get; set;}

    public int currentSize {get; set;}

    public Cache(int fixedSize)
    {
        this.fixedSize = fixedSize;
        this.head = null;
        this.tail = null;
        this.currentSize = 0;
    }
}