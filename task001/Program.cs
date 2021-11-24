/*## Консольная игра "Угадай число"

Комп загадывает число (в некотором отрезке), 
у игрока есть несколько попыток, чтобы угадать это число
Игрок вводит различные числа, комп считает количество попыток,
а также "говорит" введенное число больше или меньше загаданного.


1. Нам необходимо задать исходные (обозначить условия). Отрезок (минимальное и максимальное значение), количество попыток. Один способ - задать как константы, второй способ - запросить у игрока. 
2. Инициализировать игру. Загадываем число и приветсвуем игрока, объясняем условия игры.
3. Делаем ход. Запрашиваем и получаем от игрока число. Сравниваем это число с загаданным, изменяем количество попыток и выводим результат.
4. Завершение игры (Если человек угадал, либо потратил все попытки). Либо предложить сыграть еще раз.

* GameInit() - метод, который задает все исходные значения в вашей игре.
* MakeMove() - ходы, задаются этим методом.
* RequestNumber() - запрос числа у игрока, обработка нештатных ситуаций.
* CheckNumber(int PlayesrNumber, int SecretNumber)
* GameOver(bool winner) - */


int minValue=0;
int maxValue=100;
int attempt=7;
int SecretNumber = new Random().Next(1,100);


int GameInit()
{
    Console.WriteLine ("Вас привествует игра 'Угадай число'. Вам )
    minValue = RequestNumber("Введите нижнюю границу интервала"); 
    maxValue = RequestNumber("Введите верхнюю границу интервала"); 
    
    Console.WriteLine($"Я загадал число от {minValue} до {maxValue}. У Вас есть {attempt} попыток, чтобы его отгадать");
}

int RequestNumber(string message)
{
    Console.WriteLine(message);
    string line = Console.ReadLine();  
    return Convert.ToInt32(line);
}

int Attempt (int )
{
    x=maxValue-minValue;
    while (x>0)
    x=x/2;
    count++;
    return
}
int i = 0;

int CheckNumber(int UserNumber, int SecretNumber)
{
while (i<attempt)
    {
        Console.Write("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());    
        if (a > n)
        {
            Console.WriteLine("Нужно меньше");
        }
        else if (a < n) 
        {
            Console.WriteLine("Нужно больше");
        }
        else if (a == n)
        {
            Console.WriteLine("УРА! Вы выиграли! За "+ (i+1) +" попыток"); 
            break;
            
        }
        i++;
       
    }
if (i==7) {Console.WriteLine("Вы проиграли");
}
