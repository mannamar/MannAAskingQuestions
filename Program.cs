// Amardeep Mann
// 10-17-2022
// Mini Challenge #3 - "Asking Questions"
// Ask the user for their name, ask them what time they woke up, and ouput a sentence to the console which includes both inputs
// Peer reviewed by : Ulises Ortega
// Review Comments: I like the way the code is been written, is easy to understand and follow, I like how you went from the Do while with yes no and Y n providing more options to the user, and after that goes into an if statement depending on the Do While, The play again feauture works as coded requesting the user for valid input in case they enter other than the provided options, good Job :)
// Github link: https://github.com/peedrama/MannAAskingQuestions

Console.Clear();

bool playAgain = true;

do {
  Console.WriteLine("Hey bud. What's your name?");

  string userName = Console.ReadLine();

  Console.WriteLine("\nOh yeah. What time did you wake up today?");

  string wakeTime = Console.ReadLine();

  Console.WriteLine("\n" + userName + " woke up at " + wakeTime + " today! Wild\n");

  string response = "";
  do {
    Console.WriteLine("Do you want to play again? (Please enter \"y\" or \"n\")");
    response = Console.ReadLine().ToLower();
  } while (response != "yes" && response != "no" && response != "y" && response != "n");

  if (response == "no" || response == "n") {
    playAgain = false;
    Console.WriteLine("\nGoodbye then!");
  } else {
    Console.WriteLine("");
  }

} while (playAgain);