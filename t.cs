Console.WriteLine("1");

void function () {
  Console.WriteLine("2");
  throw new Exception();
  Console.WriteLine("3");
}

Console.WriteLine("4");

try {
  Console.WriteLine("5");
  function();
  Console.WriteLine("6");
} catch (Exception E) {
  Console.WriteLine("7");
}

Console.WriteLine("8");
