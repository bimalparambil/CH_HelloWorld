using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_HelloWorld
{
    public class HelloWorldChild: HelloWorldBase
    {
        public static string GetHelloWorld (string path, string fileName)
		{
			string filePath = Path.Combine(path, fileName);

			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			File.WriteAllText(filePath, hello);

			return "Saved to file at "+filePath;
		}
    }
}
