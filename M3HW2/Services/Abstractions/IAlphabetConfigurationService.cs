using M3HW2.Models;

namespace M3HW2.Services.Abstractions
{
    public interface IAlphabetConfigurationService
    {
        void SerializeAlphabet(Alphabet alphabet, string filePath);

        Alphabet DeserializeAlphabet(string filePath);
    }
}
