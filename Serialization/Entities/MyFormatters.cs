using System;
using System.IO;
using System.Runtime.Serialization;

namespace Serialization.Entities
{
    public static class MyFormatters
    {

       public static void MySoapFormatter(IFormatter formatter, string filename, Pessoa pessoa)
        {
            try
            {
                FileStream file = File.Create(filename);
                formatter.Serialize(file, pessoa);
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
