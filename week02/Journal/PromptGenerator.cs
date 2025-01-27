public class PromptGenerator
{
    // Lista de preguntas
    private List<string> _prompts;

    // Constructor: inicializa la lista de preguntas
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    // Método para obtener una pregunta aleatoria
    public string GetRandomPrompt()
    {
        Random random = new Random(); // Crea un objeto Random para generar números aleatorios
        return _prompts[random.Next(_prompts.Count)]; // Devuelve una pregunta aleatoria
    }
}
