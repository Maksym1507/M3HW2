using M3HW2.Models;
using M3HW2.Services.Abstractions;
using Newtonsoft.Json;

namespace M3HW2.Services
{
    public class AlphabetConfigurationService : IAlphabetConfigurationService
    {
        public void SerializeAlphabet(Alphabet alphabet, string filePath)
        {
            var json = JsonConvert.SerializeObject(alphabet);
            File.WriteAllText(filePath, json);
        }

        public Alphabet DeserializeAlphabet(string filePath)
        {
            var configFile = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Alphabet>(configFile);
        }
    }
}
