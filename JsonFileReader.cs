using Newtonsoft.Json;

namespace TestGenerics
{
	public class JsonFileReader<T>
	{
		public T ReadJson(string filePath)
		{
			string jsonContent = System.IO.File.ReadAllText(filePath);
			return JsonConvert.DeserializeObject<T>(jsonContent);
		}
	}
}
