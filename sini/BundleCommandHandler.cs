﻿
using sini;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

public static class BundleCommandHandler
{
    public static void Execute(FileInfo output, string language, bool note, bool removeEmptyLines, bool sort,string authorName, bool createRsp)
    {
        try
        {


            if (createRsp)
            {
                using (File.Create("rsp.rsp"))
                {
                    File.WriteAllText("rsp.rsp", "sini\nbundle\n");
                    //Output
                }
            }
            //        Console.WriteLine("output file name");
            //        string oPut = Console.ReadLine();
            //        if (oPut != null)
            //        {
            //            File.AppendAllText("rsp.rsp", "-o\n" + oPut + "\n");
            //        }
            //        //remove
            //        Console.WriteLine("remove empty lines?(enter true only if needed)");
            //        bool rmvL = Convert.ToBoolean(Console.ReadLine());
            //        if (rmvL)
            //        {
            //            File.AppendAllText("rsp.rsp", "-r\n");
            //        }
            //        //language
            //        List<string> languages = new List<string>();
            //        languages.Add("sql");
            //        languages.Add("text");
            //        languages.Add("text");
            //        languages.Add("all");
            //        Console.WriteLine("enter expected language (file extention)(or all)");
            //        string lang = Console.ReadLine();
            //        if (lang != null)
            //        {
            //            if (languages.Contains(lang))
            //                File.AppendAllText("rsp.rsp", "-l\n" + lang + "\n");
            //            else
            //                throw new languagexception();
            //        }
            //        //ath
            //        Console.WriteLine("enter author name (or empty line )");
            //        string atr = Console.ReadLine();
            //        if (atr != null)
            //        {
            //            File.AppendAllText("rsp.rsp", "-a\n" + atr + "\n");
            //        }
            //        //note
            //        Console.WriteLine("sould write relative path?(enter true only if needed)");
            //        bool nt = Convert.ToBoolean(Console.ReadLine());
            //        if (nt)
            //        {
            //            File.AppendAllText("rsp.rsp", "-n\n");
            //        }
            //        //sort
            //        Console.WriteLine("sort by name/ press e to sort by extention");
            //        string sortBy = Console.ReadLine();
            //        if (sortBy != null)
            //        {
            //            File.AppendAllText("rsp.rsp", "-s\n");
            //        }
            //        return;
            //    }
            //}
        /*
            if (createRsp==false && string.IsNullOrWhiteSpace(language))
            {
                throw new languagexception();
                return;
            }
            // 1.  קבציםלסדר סוג 
            string extension = language == "all" ? "*" : language;
            var files = Directory.GetFiles(Directory.GetCurrentDirectory(), $"*.{extension}");
            
            var sortedFiles = !sort
            ? files.OrderBy(Path.GetFileName)
            : files.OrderBy(file => Path.GetExtension(file));
            Console.WriteLine(output.FullName);
            
            using (File.Create(output.FullName))
            {

                if (!string.IsNullOrEmpty(authorName))
                    File.WriteAllText(output.FullName, $"# {authorName}" + Environment.NewLine);
                else;
                // File.WriteAllText (output.FullName,"");



                foreach (var file in sortedFiles)
                    {
                        if (note)
                        {
                            //לסדר קובץ יחסי
                           // File.AppendAllText(output.FullName, $"# {Path.GetRelativePath(Directory.GetCurrentDirectory(), Path.GetFileName(file))}" + Environment.NewLine);
                        }
                        var lines = File.ReadAllLines(file);

                        var nonEmptyLines = removeEmptyLines
                            ? lines.Where(line => !string.IsNullOrWhiteSpace(line))
                            : lines;

                    //File.AppendAllText(output.FullName, nonEmptyLines.ToString());
                }

                Console.WriteLine($"Files bundled successfully into {output.FullName}");
                    
                }
            
          */      
        }
        catch (DirectoryNotFoundException ex)
        {
            //לעשות עוד מלא catch
            Console.WriteLine($"invalid file name or path  {ex}");
        }
        catch (System.FormatException ex)
        {
            //לעשות עוד מלא catch
            Console.WriteLine($"invalid input  {ex}");
        }
        catch (languagexception ex)
        {
            //לעשות עוד מלא catch
            Console.WriteLine($"invalid input  {ex}");
        }
       // System.Exception
    }
}
