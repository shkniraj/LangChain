// See https://aka.ms/new-console-template for more information
using LangChain.Providers;
using LangChain.Providers.Ollama;
using static LangChain.Chains.Chain;

var provider = new OllamaProvider();
var llm = new OllamaChatModel(provider, id: "phi3:mini").UseConsoleForDebug();

var prompt = """
explain async/await.
""";

var chain = Set(prompt) | LLM(llm);
var answer = await chain.RunAsync("text");
Console.WriteLine(answer);

Console.WriteLine("Hello, World!");
