using System.Globalization;


// Get path for current directory
string curpath = Directory.GetCurrentDirectory();
Console.WriteLine($"Current directory is {curpath}");
List<string> thedirs = new List<string>(Directory.EnumerateDirectories(curpath));

//TODO: Get total files
thedirs = new List<string>(Directory.EnumerateFileSystemEntries(curpath));


int total = 0;
int totalExcel = 0;
int totalWord = 0;
int totalPP = 0;
long totalSize = 0;
long totalExcelSize = 0;
long totalWordSize = 0;
long totalPPSize = 0;


foreach (string dir in thedirs )
{
    if (dir.EndsWith("docx") | dir.EndsWith("xlsx") | dir.EndsWith("pptx")) 
        try
         {
             FileInfo fi = new FileInfo(dir);
             totalSize+= fi.Length;
             total++;
             
         } 
        catch (Exception e)
         {
             Console.WriteLine($"Exception: {e}");
             
         }
    if (dir.EndsWith("xlsx"))
    {
        FileInfo fi = new FileInfo(dir);
        totalExcel++;
        totalExcelSize += fi.Length;
    }
    if (dir.EndsWith("docx"))
    {
        FileInfo fi = new FileInfo(dir);
        totalWord++;        
        totalWordSize += fi.Length;

    }
    if (dir.EndsWith("pptx"))
    {
        FileInfo fi = new FileInfo(dir);
        totalPPSize += fi.Length;
        totalPP++;        
    }
}


const string filename = "results.txt";
if (File.Exists(filename))
{
    File.Delete(filename);
}
else
{
    using(StreamWriter sw = File.CreateText(filename))
    {
        sw.WriteLine($"~~~~ Results ~~~~");
        sw.WriteLine($"Total Files: {total}");
        sw.WriteLine($"Excel Count: {totalExcel}");
        sw.WriteLine($"Word Count: {totalWord}");
        sw.WriteLine($"PowerPoint Count: {totalPP}");
        sw.WriteLine($"----");
        sw.WriteLine($"Total Size: {totalSize.ToString("N0")}");
        sw.WriteLine($"Excel Size: {totalExcelSize.ToString("N0")}");
        sw.WriteLine($"Word Size: {totalWordSize.ToString("N0")}");
        sw.WriteLine($"PowerPoint Size: {totalPPSize.ToString("N0")}");

    }
}

//Console.WriteLine($"Total Files: {total}");
//Console.WriteLine($"Total Size: {totalSize}"); // format later
//
//Console.WriteLine($"Excel Count: {totalExcel}");
//Console.WriteLine($"Word Count: {totalWord}");
//Console.WriteLine($"PowerPoint Count: {totalPP}");
//
//Console.WriteLine($"Excel Size: {totalExcelSize}");
//Console.WriteLine($"Word Size: {totalWordSize}");
//Console.WriteLine($"PowerPoint Size: {totalPPSize}");



//TODO: Get excel files


//TODO: Get word files



//TODO: Get powerpoint files

// ----

//TODO: Get total size 



//TODO: Get excel size 
//


//TODO: Get word size 


//TODO: Get powerpoint size 