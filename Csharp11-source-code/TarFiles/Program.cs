using System;
using System.Formats.Tar;

Console.WriteLine();

var srcDirectory = @"./Source";

var filename = @"./TarFiles/myTar.tar"; // Directory should exist

// create tar file
TarFile.CreateFromDirectory(
    sourceDirectoryName: srcDirectory,
    destinationFileName: filename,
    includeBaseDirectory: false);
Console.WriteLine("Tar file created");

// read from tar file
var destDirectory = @"./Destination"; // Directory should exist

TarFile.ExtractToDirectory(sourceFileName: filename,
    destinationDirectoryName: destDirectory,
    overwriteFiles: true);
Console.WriteLine("Tar file read successfully");

Console.WriteLine();