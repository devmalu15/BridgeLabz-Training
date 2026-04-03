using System;

public interface ICacheable
{
    Cache CreateCache(int size);
    void OpenNewApp(App app, Cache cache);
    void CloseApp(App app, Cache cache);
    void ShowCache(Cache cache);
}