using System;
public class PrompyGenerator
{
     public List<string> _prompts = new List<string>();

     public string GetRandomPrompt()
     {
        foreach (Entry _promp in _prompts)
        {
            _promp.DisplayAll();
        }
        return "";
     }
}