using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using pbd2json.Properties;

namespace pbd2json{
	internal class Program{
		private static void Main(string[] args){
			try{
				string text = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
				string fullPath = Path.GetFullPath(args[0]);
				string text2 = Path.Combine(text, "out.json");
				Directory.CreateDirectory(text);
				using (ZipArchive zipArchive = new ZipArchive(new MemoryStream(Resources.pbd2json))){
					foreach (ZipArchiveEntry zipArchiveEntry in zipArchive.Entries){
						using (FileStream fileStream = new FileStream(Path.Combine(text, zipArchiveEntry.FullName), FileMode.Create)){
							using (Stream stream = zipArchiveEntry.Open()){
								stream.CopyTo(fileStream);
							}
						}
					}
				}
				Process process = Process.Start(new ProcessStartInfo(Path.Combine(text, "tvpwin32.exe")){
					Arguments = string.Concat(new string[]{
						text,
						" -in=",
						Uri.EscapeDataString(fullPath),
						" -out=",
						Uri.EscapeDataString(fullPath+".json")
					}),
					RedirectStandardError = true,
					RedirectStandardOutput = true,
					UseShellExecute = false
				});
				process.BeginOutputReadLine();
				process.BeginErrorReadLine();
				process.WaitForExit();
				Console.WriteLine(File.ReadAllText(fullPath+".json"));
				Directory.Delete(text,true);
				//Console.WriteLine(text);
			}
			catch{
			}
		}
	}
}
