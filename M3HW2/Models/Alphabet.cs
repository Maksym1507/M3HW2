namespace M3HW2.Models
{
    public class Alphabet
    {
        public Dictionary<string, string> Alphabets { get; set; } = new Dictionary<string, string>()
        {
            ["en-US"] = "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            ["uk-UA"] = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЮЯ"
        };
    }
}
