using System;
using System.Net.Http.Headers;

public class CacheableImpl : ICacheable
{
    public Cache CreateCache(int size)
    {
        Cache cache = new Cache(size);
        return cache;
    }
    public void OpenNewApp(App app, Cache cache)
    {
        if(cache.currentSize == 0)
        {
            cache.head.app = app;
        }
        else if (cache.currentSize > 0)
        {
            Node currNode = cache.head;
            int count = cache.currentSize;
            int found = 0;
            if (count == cache.fixedSize)
            {
                while (count > 0)
                {
                    if (currNode.app.appName == app.appName)
                    {
                        found = 1;
                        Console.WriteLine("Found in Cache!");
                        currNode.prev.next = currNode.next;
                        Node temp;
                        temp = cache.head;
                        currNode.next = temp;
                        cache.head = currNode;
                        cache.head.prev = null;
                        Console.WriteLine("Current App is " + cache.head.app.appName);
                    }
                    count--;
                }
                if(found == 0)
                {
                    Console.WriteLine("Not Found in cache!");
                    Node tempTail;
                    tempTail = cache.tail;
                    cache.tail = tempTail.prev;
                    cache.tail.next = null;
                }
                return;
            }
            
        }
    }
    public void CloseApp(App app, Cache cache)
    {

    }
    public void ShowCache(Cache cache)
    {
        int count = cache.fixedSize;
        Node currentNode = cache.head;
        while(count > 0)
        {
            Console.WriteLine(cache.fixedSize + " ");
            count--;
        }
    }

}

