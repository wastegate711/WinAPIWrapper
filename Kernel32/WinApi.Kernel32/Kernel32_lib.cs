using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using WinApi.Kernel32.Structs;

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
        [DllImport(LibraryName, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr handle);

        /// <summary>
        /// Копирует существующий файл в новый файл в кодировке ANSI.
        /// </summary>
        /// <param name="lpExistingFileName">Имя существующего файла.</param>
        /// <param name="lpNewFileName">Имя нового файла.</param>
        /// <param name="bFailIfExists">Файл существует?</param>
        /// <returns>Вернет не нулевой результат при успешном срабатывании.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFile(
            [param: MarshalAs(UnmanagedType.LPStr)]
            string lpExistingFileName,
            [param: MarshalAs(UnmanagedType.LPStr)]
            string lpNewFileName,
            [param: MarshalAs(UnmanagedType.Bool)] bool bFailIfExists);

        /// <summary>
        /// Копирует существующий файл в новый файл в кодировке UNICODE.
        /// </summary>
        /// <param name="existingFileName">Имя существующего файла.</param>
        /// <param name="newFileName">Имя нового файла</param>
        /// <param name="failIfExists">Файл существует?</param>
        /// <returns>Вернет не нулевой результат при успешном срабатывании.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFileW(
            [param: MarshalAs(UnmanagedType.LPWStr)]
            string existingFileName,
            [param: MarshalAs(UnmanagedType.LPWStr)]
            string newFileName,
            [param: MarshalAs(UnmanagedType.Bool)] bool failIfExists);

        /// <summary>
        /// Создает директорию в кодировке ANSI
        /// </summary>
        /// <param name="pathName">Путь.</param>
        /// <param name="securityDescriptor">Дескриптор безопасности.</param>
        /// <returns>Вернет не нулевой результат при успешном срабатывании.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryA(
            [param: MarshalAs(UnmanagedType.LPStr)]
            string pathName,
            IntPtr securityDescriptor);

        /// <summary>  
        /// Создает директорию в кодировке UNICODE.
        /// </summary>
        /// <param name="pathName">Директория.</param>
        /// <param name="securityDescriptor">Дескриптор безопасности.</param>
        /// <returns>Вернет не нулевой результат при успешном срабатывании.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryW(
            [param: MarshalAs(UnmanagedType.LPWStr)]
            string pathName,
            IntPtr securityDescriptor);

        /// <summary>
        /// Создает директорию в кодировке UNICODE.
        /// </summary>
        /// <param name="templateDirectory">Путь к директории.</param>
        /// <param name="newDirectory">Новая директория.</param>
        /// <param name="securityAttributes">Дескриптор безопасности.</param>
        /// <returns>Вернет не нулевой результат при успешном срабатывании.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryExW(
            [param: MarshalAs(UnmanagedType.LPWStr)]
            string templateDirectory,
            [param: MarshalAs(UnmanagedType.LPWStr)]
            string newDirectory,
            IntPtr securityAttributes);

        /// <summary>
        /// Создает директорию в кодировке ANSI.
        /// </summary>
        /// <param name="templateDirectory">Путь к директории.</param>
        /// <param name="newDirectory">Новая директория.</param>
        /// <param name="securityAttributes">Дескриптор безопасности.</param>
        /// <returns>Вернет не нулевой результат при успешном срабатывании.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryExA(
            [param: MarshalAs(UnmanagedType.LPStr)]
            string templateDirectory,
            [param: MarshalAs(UnmanagedType.LPStr)]
            string newDirectory,
            IntPtr securityAttributes);

        /// <summary>
        /// Удаляет файл.
        /// </summary>
        /// <param name="fileName">Файл в кодировке ANSI</param>
        /// <returns>Вернет не нулевой результат при успешном срабатывании.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFileA([param: MarshalAs(UnmanagedType.LPStr)] string fileName);

        /// <summary>
        /// Удаляет файл.
        /// </summary>
        /// <param name="fileName">Файл в кодировке UNICODE</param>
        /// <returns>Вернет не нулевой результат при успешном срабатывании.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFileW([param: MarshalAs(UnmanagedType.LPWStr)] string fileName);

        /// <summary>
        /// Запрашивает у системы текущую директорию.
        /// </summary>
        /// <param name="bufferLength">Длина буфера.
        /// Необходимо указывать 0 иначе исключение AccessViolationException надо разобраться.</param>
        /// <param name="buffer"></param>
        /// <returns>Если завершилось успешно вернет количество записаных байт</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Auto)]
        public static extern uint GetCurrentDirectory(
            uint bufferLength,
            [param: MarshalAs(UnmanagedType.LPStr)]
            out StringBuilder buffer);

        /// <summary>
        /// Создает и открывает файл в кодировке ANSI.
        /// </summary>
        /// <param name="fileName">Имя файла.</param>
        /// <param name="desiredAccess">Режим доступа.</param>
        /// <param name="shareMode">Режим общего доступа.</param>
        /// <param name="securityAttributes">Дескриптор безопасности.</param>
        /// <param name="creationDisposition">Выполняемые действия с файлами.</param>
        /// <param name="flagsAndAttributes">Атрибуты файла.</param>
        /// <param name="templateFile">Дескриптор файла шаблона, должен быть NULL.</param>
        /// <returns>При успешном выполнении вернет дескриптор файла.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr CreateFileA(
            [param: MarshalAs(UnmanagedType.LPStr)]
            string fileName,
            uint desiredAccess,
            uint shareMode,
            IntPtr securityAttributes,
            uint creationDisposition,
            uint flagsAndAttributes,
            IntPtr templateFile);

        /// <summary>
        /// Создает и открывает файл в кодировке UNICODE.
        /// </summary>
        /// <param name="fileName">Имя файла.</param>
        /// <param name="desiredAccess">Режим доступа.</param>
        /// <param name="shareMode">Режим общего доступа.</param>
        /// <param name="securityAttributes">Дескриптор безопасности.</param>
        /// <param name="creationDisposition">Выполняемые действия с файлами.</param>
        /// <param name="flagsAndAttributes">Атрибуты файла.</param>
        /// <param name="templateFile">Дескриптор файла шаблона, должен быть NULL.</param>
        /// <returns>При успешном выполнении вернет дескриптор файла.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateFileW(
            [param: MarshalAs(UnmanagedType.LPWStr)]
            string fileName,
            uint desiredAccess,
            uint shareMode,
            IntPtr securityAttributes,
            uint creationDisposition,
            uint flagsAndAttributes,
            IntPtr templateFile);

        /// <summary>
        /// Читает файл.(необходимо протестировать работу.)
        /// </summary>
        /// <param name="file">Имя файла.</param>
        /// <param name="buffer">Массив в который будет ити чтение.</param>
        /// <param name="numberOfBytesToRead">Количество байт для чтения.</param>
        /// <param name="numberOfBytesRead">Количество прочитаных байт,
        /// если операция чтения происходит асинхронно, то этот параметр должен быть равен 0.</param>
        /// <param name="structure">Дескриптор структуры.</param>
        /// <returns>Вернет не нулевой результат при успешном срабатывании.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadFile(
            IntPtr file,
            out StringBuilder buffer,
            uint numberOfBytesToRead,
            out uint? numberOfBytesRead,
            ref IntPtr structure);

        /// <summary>
        /// Удаляет директорию в кодировке UNICODE.
        /// Директорию нельзя удалить, если в ней есть файлы.
        /// </summary>
        /// <param name="pathName">Директория.</param>
        /// <returns>Вернет не нулевой результат при успешном срабатывании.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveDirectoryW([param: MarshalAs(UnmanagedType.LPWStr)] string pathName);
    }
}