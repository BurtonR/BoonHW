using System;
using System.IO;
using System.Linq;

namespace BoonHomework
{
    public class SPVisualizer
    {
        public void Visualize(string folderPath)
        {
            foreach (var file in Directory.EnumerateFiles(folderPath, "*.sql"))
            {
                var spCall = "EXEC ";

                var contents = File.ReadAllText(file);

                if (contents.Contains(spCall) || contents.Contains(spCall.ToLower()))
                {
                    Console.Write(file.Substring(file.LastIndexOf('\\')));

                    using (var reader = new StreamReader(file))
                    {
                        var x = 0;
                        string execLine;

                        while ((execLine = reader.ReadLine()) != null)
                        {
                            if (!execLine.Contains(spCall) && !execLine.Contains(spCall.ToLower())) continue;

                            Console.Write(x == 0 ? " calls: " : " and ");
                                
                            var spName = execLine.Split(' ').ToArray();
                            Console.Write(spName[2]);

                            x++;
                        }
                    }

                    Console.WriteLine();
                }
            }

            Console.Read();
        }
    }
}
