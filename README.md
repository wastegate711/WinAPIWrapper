# WinAPIWrapper
Содержит экспортированные функции Win API.

Список библиотек:

## Kernel32

Для подключения нужно использовать класс "kernel32_lib"

``` C#
static void Main(string[] args)
{
    Kernel32_Lib.Beep(1500, 1000);
}
```

## User32

Для подключения нужно использовать класс "User32"

``` c#
static void Main(string[] args)
{
     User32.GetCursorPos(out POINT pt);
     Console.WriteLine($"X={pt.X} - Y={pt.Y}");
}
```
