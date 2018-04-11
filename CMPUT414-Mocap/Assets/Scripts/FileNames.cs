using System.IO;
using System.Collections.Generic;

public class FileNames
{
	public List<string> fileString = new List<string>(); 
	public FileNames ()
	{
		string path = Directory.GetCurrentDirectory();
		path = path + @"/Assets/Resources";
		DirectoryInfo d = new DirectoryInfo(@path);
		FileInfo[] Files = d.GetFiles("*.fbx");
		foreach(FileInfo file in Files )
		{
            string fileName = file.Name.Remove(file.Name.Length - 4);
            fileString.Add(fileName);

		}
	}
}

