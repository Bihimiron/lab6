## Завдання 2: Використання колекції Stack<T>

Заданий рядок символів, який закінчується “;”. Рядок може містити відкриваючі та закриваючі фігурні, круглі, квадратні, кутові дужки. Розробити програму, яка перевіряє, чи вірно розміщені дужки у рядку. При цьому необхідно, щоб виконувались наступні правила:

1. Кожна відкриваюча дужка повинна мати справа таку саму закриваючу дужку. Зворотне твердження також має бути вірним.

2. Відкриваючі та закриваючі пари дужок різних типів мають бути правильно розташовані відповідно один одного.

   Приклад коректного рядка: `({x-y-z}*[x+2y]-(z+4x));`
   
   Приклад некоректного рядка: `([x-y-z}*[x+2y)-{z+4x)].`

Розв'язок оформити у вигляді окремого методу `IsCorrect`, що приймає введений рядок та повертає логічне значення, яке відповідає на питання – чи коректний заданий рядок. Крім того, метод має повертати кількість вдало оброблених символів рядка за допомогою параметра метода.

## Завдання 3: Використання колекції Queue<T>

Задана деяка послідовність натуральних чисел. Надрукувати в порядку збільшення N таких чисел послідовності, в розкладання яких на прості множники входять тільки прості числа A, B, C у будь-якій комбінації.

Наприклад, якщо A = 2, В = 3, С = 5, то перші 10 чисел будуть 2, 3, 4, 5, 6, 8, 9, 10, 12, 15.

Підказка: оптимальним буде використання класу `Queue<int>` у якості приватного поля (можливо кілька разів).

Розв'язок оформити у вигляді окремого класу, в який інкапсульовано рішення. В конструктор класу передаються значення А, В, С. Наявний відкритий метод, що приймає значення N та повертає список `List<int>`, який містить перші N чисел послідовності.

```csharp
interface ILab8QueuePartBasicLevel
{
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }
    
    /// <summary>
    /// Method returns list of elements, that can be divided by A, B or C in ascending order
    /// </summary>
    /// <param name="N">Lenght of sequence (number of elements)</param>
    /// <returns>List of elements, that can be divided by A, B or C in ascending order</returns>
    public List<int> GetSequence(int N);
}
```
### Додаткове завдання (3 бали): реалізація інтерфейсу `IEnumerable<int>`

Додатково до основного завдання реалізуйте інтерфейс `IEnumerable<int>` у класі-результаті, який буде повертати ітератор, генеруючи дану послідовність натуральних чисел на ходу у методі `MoveNext()`.

```csharp
/// <summary>
/// Interface also implement IEnumerable, that iterate via sequence, generating elements in MoveNext() method
/// </summary>
interface ILab8QueuePartAdvancedLevel : ILab8QueuePartBasicLevel, IEnumerable<int>
{
    /// <summary>
    /// Method returns list of elements, that can be divided by A, B or C in ascending order
    /// </summary>
    /// <param name="N">Length of sequence (number of elements)</param>
    /// <param name="startIndex">Number of element, from which sequence starts (0 - sequence will not skip elements)</param>
    /// <returns>List of elements, that can be divided by A, B or C in ascending order</returns>
    public List<int> GetSequence(int startIndex, int N);
}
