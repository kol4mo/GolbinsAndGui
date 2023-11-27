namespace GolbinsAndGui.model
{
    internal class Response
    {
        public string responseText { get; set; }
        public Dictionary<string, Response> dialogueOptions { get; set; }
    }
}
