﻿namespace Zadanie3.Utils;

public static class Global
{
    public static readonly string BaseDataDirPath =
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "Studia_2022",
            "numerki_2022"
            );

    public static readonly double DoubleTolerance = 1e-10;

    public static void EnsureDirectoryIsValid(bool writePath = false)
    {
        if (!Directory.Exists(BaseDataDirPath))
        {
            Directory.CreateDirectory(BaseDataDirPath);
        }

        try
        {
            using var fs = File.Create(
                Path.Combine(BaseDataDirPath, Path.GetRandomFileName()),
                1,
                FileOptions.DeleteOnClose);
        }
        catch (Exception e)
        {
            throw new Exception("Base Directory has no write access right!", e);
        }

        if (writePath) Console.WriteLine($"Data path = {BaseDataDirPath}");
    }
}