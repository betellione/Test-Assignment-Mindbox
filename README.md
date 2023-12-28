# Test-Assignment-Mindbox
# Shapes Library

Библиотека Shapes - это простой проект на языке C#, предоставляющий интерфейсы и классы для представления геометрических форм и вычисления их площадей. В настоящее время в нее включены интерфейс `IShape` и две его реализации: `Circle` и `Triangle`. Кроме того, проект включает в себя набор тестов для проверки корректности функционала.


## Особенности
- Интерфейс `IShape` для представления общей геометрической формы.
- Класс `Circle` для моделирования кругов с радиусом и вычислением площади.
- Класс `Triangle` для моделирования треугольников с длинами сторон, вычислением площади и определением прямого угла.

## Начало работы

### Необходимые предустановки
- Установленный [.NET SDK](https://dotnet.microsoft.com/download) на вашем компьютере.

### Установка
1. Клонировать репозиторий: `git clone https://github.com/betellione/Test-Assignment-Mindbox.git`
2. Перейти в каталог проекта: `cd ShapesLibrary`

## Использование

### Круг
```csharp
// Создать новый экземпляр класса Circle с указанным радиусом
Circle circle = new Circle(5.0);

// Вычислить площадь круга
double area = circle.CalculateArea();
Console.WriteLine($"Площадь круга: {area}");
```

### Треугольник
```csharp
// Создать новый экземпляр класса Triangle с тремя длинами сторон
Triangle triangle = new Triangle(3.0, 4.0, 5.0);

// Проверить, является ли треугольник прямоугольным
bool isRightTriangle = triangle.IsRight;
Console.WriteLine($"Прямоугольный треугольник: {isRightTriangle}");

// Вычислить площадь треугольника
double area = triangle.CalculateArea();
Console.WriteLine($"Площадь треугольника: {area}");
```

## Тестирование
В проекте есть тестирование

## Вклад
Приветствуются вклады! Если у вас есть идеи для улучшений или вы обнаружили какие-либо проблемы, пожалуйст

а, создайте [issue](https://github.com/betellione/Test-Assignment-Mindbox/issues) или предложите [pull request](https://github.com/betellione/Test-Assignment-Mindbox/pulls).

## Лицензия
Этот проект лицензирован в соответствии с лицензией MIT - подробности см. в файле [LICENSE](LICENSE).