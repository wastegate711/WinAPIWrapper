﻿using System;
using System.Runtime.InteropServices;

namespace WinApi.User32.Structs
{
    /// <summary>
    /// Содержит сведения о имитированном событии мыши.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MouseInput
    {
        /// <summary>
        /// Абсолютные данные указываются как координата x мыши.
        /// Абсолютное положение мыши или объем движения с момента создания последнего события
        /// мыши в зависимости от значения элемента dwFlags.
        /// </summary>
        public int dx;

        /// <summary>
        /// Абсолютные данные указываются как координата Y мыши.
        /// Абсолютное положение мыши или объем движения с момента создания последнего
        /// события мыши в зависимости от значения элемента dwFlags.
        /// </summary>
        public int dy;

        /// <summary>
        /// Если dwFlags содержит MOUSEEVENTF_WHEEL, mouseData указывает величину перемещения колесика.
        /// Положительное значение указывает, что колесо повернулось вперед, от пользователя;
        /// отрицательное значение указывает, что колесо повернулось назад к пользователю.
        /// Один щелчок колесиком определяется как WHEEL_DELTA, то есть 120.
        /// Windows Vista: если dwFlags содержит MOUSEEVENTF_HWHEEL, то dwData указывает величину перемещения колесика.
        /// Положительное значение указывает, что колесо повернулось вправо; Отрицательное значение указывает,
        /// что колесо было повернулось влево. Один щелчок колесиком определяется как WHEEL_DELTA, то есть 120.
        /// Если dwFlags не содержит MOUSEEVENTF_WHEEL, MOUSEEVENTF_XDOWN или MOUSEEVENTF_XUP,
        /// значение mouseData должно быть равно нулю.
        /// Если dwFlags содержит MOUSEEVENTF_XDOWN или MOUSEEVENTF_XUP, mouseData указывает,
        /// какие кнопки X были нажаты или отпущены. Это значение может быть любым сочетанием следующих флагов.
        /// XBUTTON1 = 0x0001 Задает значение, если первая кнопка X нажата или отпущена.
        /// XBUTTON1 = 0x0002 Задает значение , если вторая кнопка X нажата или отпущена.
        /// </summary>
        public uint mouseData;

        /// <summary>
        /// Набор битовых флагов, указывающих различные аспекты движения мыши и нажатий кнопок.
        /// Биты в этом элементе могут быть любым разумным сочетанием следующих значений.
        /// Битовые флаги, указывающие состояние кнопки мыши, задаются для указания изменений в состоянии,
        /// а не текущих условий. Например, если левая кнопка мыши нажата и удерживается, MOUSEEVENTF_LEFTDOWN
        /// устанавливается при первом нажатии левой кнопки, но не для последующих движений.
        /// Аналогичным образом MOUSEEVENTF_LEFTUP устанавливается только при первом освобождении кнопки.
        /// Нельзя одновременно указать флаг MOUSEEVENTF_WHEEL и флаг MOUSEEVENTF_XDOWN или MOUSEEVENTF_XUP
        /// в параметре dwFlags , так как для них обоих требуется использовать поле mouseData.
        /// https://learn.microsoft.com/ru-ru/windows/win32/api/winuser/ns-winuser-mouseinput#members
        /// </summary>
        public uint dwFlags;

        /// <summary>
        /// Отметка времени для события в миллисекундах. Если этот параметр равен 0, система предоставит свою собственную отметку времени.
        /// </summary>
        public uint time;

        /// <summary>
        /// 
        /// </summary>
        public IntPtr dwExtraInfo;
    }
}