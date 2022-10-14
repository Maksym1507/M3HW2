using M3HW2.Configs;
using M3HW2.Models;

namespace M3HW2.Services.Abstractions
{
    public interface IAlphabetConfigurationService
    {
        void SerializeAlphabet(AlphabetConfig alphabet, string filePath);

        AlphabetConfig DeserializeAlphabet(string filePath);
    }
}
