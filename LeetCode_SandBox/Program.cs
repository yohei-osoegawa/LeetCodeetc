using System;

namespace LeetCode_SandBox {
    class Program {
        static void Main(string[] args) {
            var input = "hello world";
            var output = System.Text.Json.JsonSerializer.Serialize(input);
            Console.WriteLine(output);
        }
    }
}
