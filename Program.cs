Console.WriteLine("Ingresa el contenido de la carta que el Grinch abrió");
string? letter = Console.ReadLine();

if(isValid(letter)) Console.WriteLine("La carta es válida");
else Console.WriteLine("La carta no es válida");

bool isValid(string letter)
{
  int bracket = 0;
  int pos = 0;
  while (pos < letter.Length)
  {
    switch (letter[pos])
    {
      case '(':
        bracket++;
        if (letter[pos + 1] == ')') return false;
        break;
      case ')':
        if (bracket > 0) bracket--;
        else return false;
        break;
      case '{':
      case '}':
      case '[':
      case ']':
        return false;
    }
    pos++;
  }
  return bracket == 0;
}
