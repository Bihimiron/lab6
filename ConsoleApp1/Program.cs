

using ConsoleApp1;

var incorrectEx = "([x-y-z}*[x+2y)-{z+4x)].";
var correctEx = "({x-y-z}*[x+2y]-(z+4x));";

Console.WriteLine($"first expr {BracketValidator.IsCorrect(incorrectEx, out var processedChars1)}," +
                  $" processed chars: {processedChars1}");
Console.WriteLine($"second expr {BracketValidator.IsCorrect(correctEx, out var processedChars2)}," +
                  $" processed chars: {processedChars2}");

var lab = new Lab8QueuePartBasicLevel(2, 3, 5);
var list = lab.GetSequence(10);

Console.WriteLine(string.Join(',', list));
