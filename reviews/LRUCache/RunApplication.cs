using System;

public class RunApplication
{
    public static void Main(String[] args)
    {
        ICacheable cacheManager = new CacheableImpl();

        App app = new App("gallery");
        Cache cache = cacheManager.CreateCache(5);
        cacheManager.ShowCache(cache);
    }
}