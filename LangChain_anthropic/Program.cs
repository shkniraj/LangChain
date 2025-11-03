// See https://aka.ms/new-console-template for more information
using DotNetEnv;
using LangChain.Providers;
using LangChain.Providers.Anthropic;

Env.Load();

var apiKey = Environment.GetEnvironmentVariable("ANTHROPIC_API_KEY")
                     ?? throw new InvalidOperationException("ANTHROPIC_API_KEY not set");

var provider = new AnthropicProvider(apiKey);

var chat = new AnthropicChatModel(provider, "claude-4.5-sonnet");

var reply = await chat.GenerateAsync("Explain Deeplearning");
Console.WriteLine(reply);