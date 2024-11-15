using System;
using System.Runtime.InteropServices;

namespace WinApi.User32.Structs
{
    /// <summary>
    /// Содержит сведения о событии имитации клавиатуры.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct KeyBoardInput
    {
        /// <summary>
        /// Код должен быть значением в диапазоне от 1 до 254. Если элемент dwFlags указывает
        /// KEYEVENTF_UNICODE, wVk должен иметь значение 0.
        /// </summary>
        public ushort wVk;

        /// <summary>
        /// Код аппаратного сканирования ключа.
        /// Если dwFlags указывает KEYEVENTF_UNICODE, wScan задает символ Юникода,
        /// который должен быть отправлен в приложение переднего плана.
        /// </summary>
        public ushort wScan;

        /// <summary>
        /// Задает различные аспекты нажатия клавиши.
        /// Этот элемент может быть определенным сочетанием следующих значений.
        /// </summary>
        public long dwFlags;

        /// <summary>
        /// Метка времени для события в миллисекундах.
        /// Если этот параметр равен нулю, система предоставит собственную метку времени.
        /// </summary>
        public long time;

        /// <summary>
        /// Дополнительное значение, связанное с нажатием клавиши.
        /// Для получения этих сведений используйте функцию GetMessageExtraInfo .
        /// </summary>
        public long dwExtraInfo;
    }
}