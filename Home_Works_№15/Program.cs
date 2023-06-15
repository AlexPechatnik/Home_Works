Console.Write("Введи целое число от 1 до 7: ");
int numberA = int.Parse(Console.ReadLine());
switch (numberA)
{
    case 1: 
    Console.Write("Сегодня рабочий день ");
        break;
      
      case 2: 
    Console.Write("Сегодня рабочий день ");
        break;
    
      case 3: 
    Console.Write("Сегодня рабочий день ");
        break;

      case 4: 
    Console.Write("Сегодня рабочий день ");
        break;

      case 5: 
    Console.Write("Сегодня рабочий день ");
        break;    

      case 6: 
    Console.Write("Сегодня выходной ");
        break;

      case 7: 
    Console.Write("Сегодня выходной ");
        break;    
    
    default:
    Console.Write("в недели 7 дней, попробуй снова  ");
     break;

}