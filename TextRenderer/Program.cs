Console.WriteLine("specify the path to the directory");
string Path = Console.ReadLine();
FileInfo file = GetFile(Path);
var text = File.ReadAllText(file.FullName);
Console.WriteLine(text);

Console.ReadLine();

 FileInfo GetFile(string path)
{
    Path = path;
    DirectoryInfo directoryInfo = new DirectoryInfo(path);
    FileInfo fileWithMaxDate = null;

    if (Directory.Exists(path))
    {
        var files = directoryInfo.GetFiles("*.txt");
        DateTime maxdate = DateTime.MinValue;
        
        
        foreach (var fileInfo in files)
        {
            if (maxdate < fileInfo.CreationTime)
            {
                maxdate = fileInfo.CreationTime;
                fileWithMaxDate = fileInfo;
            }
        }
     

    }

    return fileWithMaxDate;
}
