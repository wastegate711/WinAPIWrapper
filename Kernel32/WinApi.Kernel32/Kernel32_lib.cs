using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace WinApi.Kernel32
{
    public class Kernel32_lib
    {
        private const string LibraryName = "Kernel32.dll";

        /// <summary>
        /// Запрашивает код последней ошибки вызывающего потока.
        /// Описание кодов https://docs.microsoft.com/en-us/windows/win32/debug/system-error-codes
        /// Прредпочтительней использовать GetLastWin32Error(), а если используется .NET 6 и поздние версии,
        /// то предпочтительней использовать  GetLastPInvokeError()
        /// </summary>
        /// <returns>Вернет код ошибки.</returns>
        [DllImport(LibraryName)]
        public static extern uint GetLastError();

        /// <summary>
        /// Издает звуковой сигнал.
        /// </summary>
        /// <param name="freq">Частота.</param>
        /// <param name="duration">Продолжительность.</param>
        /// <returns>Вернет не нулевой результат при успешном срабатывании.</returns>
        [DllImport(LibraryName, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Beep(uint freq, uint duration);

        /// <summary>
        /// Закрывает дескриптор открытого объекта.
        /// </summary>
        /// <param name="handle">Дескриптор.</param>
        /// <returns>Вернет не нулевой результат при успешном срабатывании.</returns>
        [DllImport(LibraryName,SetLastError = true)]
        [return:MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr handle);

        /// <summary>
        /// Копирует существующий файл в новый файл в кодировке ANSI.
        /// </summary>
        /// <param name="lpExistingFileName">Имя существующего файла.</param>
        /// <param name="lpNewFileName">Имя нового файла.</param>
        /// <param name="bFailIfExists">Файл существует?</param>
        /// <returns></returns>
        [DllImport(LibraryName,SetLastError = true)]
        [return:MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFile(
            [param: MarshalAs(UnmanagedType.LPStr)]
            string lpExistingFileName,
            [param: MarshalAs(UnmanagedType.LPStr)]
            string lpNewFileName,
            [param: MarshalAs(UnmanagedType.Bool)] bool bFailIfExists);
    }
}