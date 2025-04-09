namespace Poketcher.Services;

public class UserDbService
{
    private readonly string _dbFileName = "user.db";

    public string GetUserDbPath()
    {
        return Path.Combine(FileSystem.AppDataDirectory, _dbFileName);
    }

    public async Task ExportDbAsync(string exportPath)
    {
        string dbPath = GetUserDbPath();

        if (File.Exists(dbPath))
        {
            using var sourceStream = File.OpenRead(dbPath);
            using var destinationStream = File.Create(exportPath);
            await sourceStream.CopyToAsync(destinationStream);
        }
    }

    public async Task ImportDbAsync(string importPath)
    {
        string dbPath = GetUserDbPath();

        if (File.Exists(importPath))
        {
            using var sourceStream = File.OpenRead(importPath);
            using var destinationStream = File.Create(dbPath);
            await sourceStream.CopyToAsync(destinationStream);
        }
    }
}
