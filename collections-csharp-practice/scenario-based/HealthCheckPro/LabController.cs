using System;

public class LabController
{
    [PublicAPIAttribute]
    public void GetTestList() { }

    [RequiresAuthAttribute]
    public void DownloadReport() { }

    public void InternalSync() { }
}