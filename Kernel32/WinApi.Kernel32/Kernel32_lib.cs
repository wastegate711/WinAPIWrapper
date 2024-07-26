using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using WinApi.Kernel32.Structs;

namespace WinApi.Kernel32
{
    public class Kernel32Lib
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
        /// Удаляет директорию в кодировке ANSI.
        /// Директорию нельзя удалить, если в ней есть файлы.
        /// </summary>
        /// <param name="pathName">Директория.</param>
        /// <returns>Вернет не нулевой результат при успешном срабатывании.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveDirectoryA([param: MarshalAs(UnmanagedType.LPStr)] string pathName);

        /// <summary>
        /// Удаляет директорию в кодировке UNICODE.
        /// Директорию нельзя удалить, если в ней есть файлы.
        /// </summary>
        /// <param name="pathName">Директория.</param>
        /// <returns>Вернет не нулевой результат при успешном срабатывании.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveDirectoryW([param: MarshalAs(UnmanagedType.LPWStr)] string pathName);

        /// <summary>
        /// Создает или открывает именованый или без имянный Mutex в кодировке ANSI.
        /// </summary>
        /// <param name="mutexAttributes">Дескриптор безопасности (опциональный)</param>
        /// <param name="initialOwner">Вызывающий поток является влядельцем Mutex? (Опционально)</param>
        /// <param name="name">Имя объекта Mutex.
        /// https://docs.microsoft.com/en-us/windows/win32/termserv/kernel-object-namespaces</param>
        /// <returns>Если функция завершится успешно, то вернет дескриптор Mutex,
        /// но если такой Mutex существует, то вернет дескриптор Mutex и ошибку ERROR_ALREADY_EXISTS = 0xB7</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr CreateMutexA(
            IntPtr mutexAttributes,
            [param: MarshalAs(UnmanagedType.Bool)] bool initialOwner,
            [param: MarshalAs(UnmanagedType.LPStr)] string name);


        /// <summary>
        /// Создает или открывает именованый или без имянный Mutex в кодировке UNICODE.
        /// </summary>
        /// <param name="mutexAttributes">Дескриптор безопасности (опциональный)</param>
        /// <param name="initialOwner">Вызывающий поток является влядельцем Mutex? (Опционально)</param>
        /// <param name="name">Имя объекта Mutex.
        /// https://docs.microsoft.com/en-us/windows/win32/termserv/kernel-object-namespaces</param>
        /// <returns>Если функция завершится успешно, то вернет дескриптор Mutex,
        /// но если такой Mutex существует, то вернет дескриптор Mutex и ошибку ERROR_ALREADY_EXISTS = 0xB7</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateMutexW(
            IntPtr mutexAttributes,
            [param: MarshalAs(UnmanagedType.Bool)] bool initialOwner,
            [param: MarshalAs(UnmanagedType.LPWStr)] string name);

        /// <summary>
        /// Создает или открывает именованый или без имянный Mutex в кодировке ANSI.
        /// </summary>
        /// <param name="mutexSecurityAttributes">Дескриптор безопасности (опционально).</param>
        /// <param name="name">Имя объекта Mutex (опционально).
        /// Если name совпадает с именем существующего события, семафора, ожидаемого таймера,
        /// задания или объекта сопоставления файлов, функция завершается ошибкой, и функция GetLastError
        /// возвращает ERROR_INVALID_HANDLE. Это происходит потому, что эти объекты используют
        /// одно и то же пространство имен.
        /// https://docs.microsoft.com/en-us/windows/win32/termserv/kernel-object-namespaces</param>
        /// <param name="flags">Флаг CREATE_MUTEX_INITIAL_OWNER, может быть установлен в 0 или 1.</param>
        /// <param name="desiredAccess">Маска доступа.</param>
        /// <returns>Если функция завершится успешно, то вернет дескриптор Mutex,
        /// но если такой Mutex существует, то вернет дескриптор Mutex и ошибку ERROR_ALREADY_EXISTS = 0xB7</returns>
        /// 
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr CreateMutexExA(
            IntPtr mutexSecurityAttributes,
            [param: MarshalAs(UnmanagedType.LPStr)] string name,
            uint flags,
            uint desiredAccess);

        /// <summary>
        /// Создает или открывает именованый или без имянный Mutex в кодировке UNICODE.
        /// </summary>
        /// <param name="mutexSecurityAttributes">Дескриптор безопасности (опционально).</param>
        /// <param name="name">Имя объекта Mutex (опционально).
        /// Если name совпадает с именем существующего события, семафора, ожидаемого таймера,
        /// задания или объекта сопоставления файлов, функция завершается ошибкой, и функция GetLastError
        /// возвращает ERROR_INVALID_HANDLE. Это происходит потому, что эти объекты используют
        /// одно и то же пространство имен.
        /// https://docs.microsoft.com/en-us/windows/win32/termserv/kernel-object-namespaces</param>
        /// <param name="flags">Флаг CREATE_MUTEX_INITIAL_OWNER, может быть установлен в 0 или 1.</param>
        /// <param name="desiredAccess">Маска доступа.</param>
        /// <returns>Если функция завершится успешно, то вернет дескриптор Mutex,
        /// но если такой Mutex существует, то вернет дескриптор Mutex и ошибку ERROR_ALREADY_EXISTS = 0xB7</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateMutexExW(
            IntPtr mutexSecurityAttributes,
            [param: MarshalAs(UnmanagedType.LPWStr)] string name,
            uint flags,
            uint desiredAccess);

        /// <summary>
        /// Приостанавливает выполнение текущего потока до тех пор,
        /// пока не истечет интервал времени ожидания.
        /// </summary>
        /// <param name="milliseconds">Интервал ожидания.</param>
        [DllImport(LibraryName)]
        public static extern void Sleep(uint milliseconds);

        /// <param name="applicationName">
        /// Имя модуля, который необходимо выполнить.
        /// Этот модуль может быть приложением для Windows.
        /// Это может быть модуль другого типа (например, MS-DOS или OS/2),
        /// если на локальном компьютере имеется соответствующая подсистема.
        ///Строка может указывать полный путь и имя файла исполняемого модуля или
        /// частичное имя. В случае частичного имени функция использует текущий диск и
        /// текущий каталог для завершения спецификации.
        /// Функция не будет использовать путь поиска.
        /// Этот параметр должен включать расширение имени файла;
        /// расширение по умолчанию не предполагается.(Опционально) В кодировке ANSI</param>
        /// <param name="commandLine">Командная строка, которую нужно выполнить.(Опционально)
        /// Максимальная длина этой строки составляет 32 767 символов.</param>
        /// <param name="processAttributes">Дескриптор безопасности процесса.(Опционально)</param>
        /// <param name="threadAttributes">Дескриптор безопасности потока.(Опционально)</param>
        /// <param name="inheritHandles">Если этот параметр имеет значение TRUE,
        /// каждый наследуемый дескриптор в вызывающем процессе наследуется новым процессом.
        /// Если параметр равен FALSE, дескрипторы не наследуются.
        /// Обратите внимание, что унаследованные дескрипторы имеют,
        /// то же значение и права доступа, что и исходные дескрипторы.</param>
        /// <param name="creationFlags">Флаги, управляющие классом приоритета и созданием процесса.
        /// ProcessCreationFlag</param>
        /// <param name="environment">Указатель на блок окружения для нового процесса.
        /// Если этот параметр имеет значение NULL,
        /// новый процесс использует среду вызывающего процесса.(Опционально)</param>
        /// <param name="currentDirectory">Полный путь к текущему каталогу процесса.
        /// Строка также может указывать путь UNC.
        ///Если этот параметр имеет значение NULL, новый процесс будет иметь тот же текущий диск и каталог,
        /// что и вызывающий процесс.
        /// (Эта функция предоставляется в первую очередь для оболочек, которым необходимо запустить
        /// приложение и указать его начальный диск и рабочий каталог.)</param>
        /// <param name="startupInfo"></param>
        /// <param name="processInformation"></param>
        /// <returns></returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateProcessA(
            [param: MarshalAs(UnmanagedType.LPStr)] string applicationName,
            [param: MarshalAs(UnmanagedType.LPStr)] ref string commandLine,
            IntPtr processAttributes,
                IntPtr threadAttributes,
            [param: MarshalAs(UnmanagedType.Bool)] bool inheritHandles,
            uint creationFlags,
            IntPtr environment,
            [param: MarshalAs(UnmanagedType.LPStr)] string currentDirectory,
            IntPtr startupInfo,
            out IntPtr processInformation);

        /// <summary>
        /// Загружает динамическую библиотеку в кодировке ANSI.
        /// </summary>
        /// <param name="libFileName">Имя библиотеки.</param>
        /// <returns>Если функция завершается успешно, возвращаемое значение является дескриптором модуля.
        /// Если функция завершается ошибкой, возвращаемое значение равно NULL. Чтобы получить расширенную информацию об ошибке,
        /// вызовите GetLastError.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr LoadLibraryA([param: MarshalAs(UnmanagedType.LPStr)] string libFileName);

        /// <summary>
        /// Загружает динамическую библиотеку в кодировке Unicode.
        /// </summary>
        /// <param name="libFileName">Имя библиотеки.</param>
        /// <returns>Если функция завершается успешно, возвращаемое значение является дескриптором модуля.
        /// Если функция завершается ошибкой, возвращаемое значение равно NULL. Чтобы получить расширенную информацию об ошибке,
        /// вызовите GetLastError.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr LoadLibraryW([param: MarshalAs(UnmanagedType.LPWStr)] string libFileName);

        /// <summary>
        /// Загружает динамическую библиотеку в кодировке ANSI.
        /// </summary>
        /// <param name="libFileName">Имя библиотеки.</param>
        /// <param name="hFile">Этот параметр зарезервирован для использования в будущем. Он должен быть NULL.</param>
        /// <param name="flag">Действие, которое необходимо выполнить при загрузке модуля. Если флаги не указаны,
        /// поведение этой функции идентично поведению функции LoadLibrary.
        /// https://learn.microsoft.com/en-us/windows/win32/api/libloaderapi/nf-libloaderapi-loadlibraryexa</param>
        /// <returns>Если функция завершается успешно, возвращаемое значение является дескриптором модуля.
        /// Если функция завершается ошибкой, возвращаемое значение равно NULL.
        /// Чтобы получить расширенную информацию об ошибке, вызовите GetLastError.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr LoadLibraryExA(
            [param: MarshalAs(UnmanagedType.LPStr)]
            string libFileName,
            IntPtr hFile, 
            uint flag);

        /// <summary>
        /// Загружает динамическую библиотеку в кодировке Unicode.
        /// </summary>
        /// <param name="libFileName">Имя библиотеки.</param>
        /// <param name="hFile">Этот параметр зарезервирован для использования в будущем. Он должен быть NULL.</param>
        /// <param name="flag">Действие, которое необходимо выполнить при загрузке модуля. Если флаги не указаны,
        /// поведение этой функции идентично поведению функции LoadLibrary.
        /// https://learn.microsoft.com/en-us/windows/win32/api/libloaderapi/nf-libloaderapi-loadlibraryexa</param>
        /// <returns>Если функция завершается успешно, возвращаемое значение является дескриптором модуля.
        /// Если функция завершается ошибкой, возвращаемое значение равно NULL.
        /// Чтобы получить расширенную информацию об ошибке, вызовите GetLastError.</returns>
        [DllImport(LibraryName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr LoadLibraryExW(
            [param: MarshalAs(UnmanagedType.LPWStr)]
            string libFileName,
            IntPtr hFile,
            uint flag);

        /// <summary>
        /// Освобождает загруженный модуль библиотеки динамической компоновки (DLL).
        /// </summary>
        /// <param name="hFile">Дескриптор загруженного библиотечного модуля.</param>
        /// <returns>Если функция завершается успешно, возвращаемое true.
        /// Если функция завершается ошибкой, возвращаемое значение false.
        /// Чтобы получить расширенную информацию об ошибке, вызовите функцию GetLastError.</returns>
        [DllImport(LibraryName,SetLastError = true)]
        [return:MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeLibrary(IntPtr hFile);

        /// <summary>
        /// Извлекает идентификатор указанного процесса.
        /// </summary>
        /// <param name="hFile">Дескриптор процесса.
        /// Дескриптор должен иметь права доступа PROCESS_QUERY_INFORMATION или PROCESS_QUERY_LIMITED_INFORMATION.
        /// Для получения дополнительной информации см.
        /// https://learn.microsoft.com/en-us/windows/win32/procthread/process-security-and-access-rights</param>
        /// <returns>Если функция завершается успешно, возвращаемое значение является идентификатором процесса.
        /// Если функция завершается ошибкой, возвращаемое значение равно нулю.
        /// Чтобы получить расширенную информацию об ошибке, вызовите GetLastError.</returns>
        [DllImport(LibraryName, SetLastError = true)]
        public static extern ulong GetProcessId(IntPtr hFile);
    }
}


























