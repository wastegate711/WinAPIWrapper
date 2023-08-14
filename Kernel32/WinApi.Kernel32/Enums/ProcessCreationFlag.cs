﻿namespace WinApi.Kernel32.Enums
{
    public enum ProcessCreationFlag : uint
    {
        /// <summary>
        /// Дочерние процессы процесса, связанного с заданием, не связаны с заданием.
        /// Если вызывающий процесс не связан с заданием, эта константа не действует.
        /// Если вызывающий процесс связан с заданием, задание должно установить ограничение
        /// JOB_OBJECT_LIMIT_BREAKAWAY_OK.
        /// </summary>
        CREATE_BREAKAWAY_FROM_JOB = 0x01000000,

        /// <summary>
        /// Новый процесс не наследует режим ошибки вызывающего процесса.
        /// Вместо этого новый процесс получает режим ошибки по умолчанию.
        /// Эта функция особенно полезна для многопоточных приложений оболочки,
        /// которые работают с отключенными серьезными ошибками.
        /// По умолчанию новый процесс наследует режим ошибки вызывающего объекта.
        /// Установка этого флага изменяет это поведение по умолчанию.
        /// </summary>
        CREATE_DEFAULT_ERROR_MODE = 0x04000000,

        /// <summary>
        /// Новый процесс имеет новую консоль вместо того,
        /// чтобы наследовать консоль своего родителя (по умолчанию).
        /// Дополнительные сведения см. в разделе Создание консоли.
        /// Этот флаг нельзя использовать с DETACHED_PROCESS.
        /// </summary>
        CREATE_NEW_CONSOLE = 0x00000010,

        /// <summary>
        /// Новый процесс является корневым процессом новой группы процессов.
        /// В группу процессов входят все процессы, являющиеся потомками этого корневого процесса.
        /// Идентификатор процесса новой группы процессов совпадает с идентификатором процесса,
        /// который возвращается в параметре lpProcessInformation.
        /// Группы процессов используются функцией GenerateConsoleCtrlEvent для включения
        /// отправки сигнала CTRL+BREAK группе консольных процессов.
        /// Если этот флаг установлен, сигналы CTRL+C будут отключены для всех процессов в новой группе процессов.
        /// Этот флаг игнорируется, если он указан с помощью CREATE_NEW_CONSOLE.
        /// </summary>
        CREATE_NEW_PROCESS_GROUP = 0x00000200,

        /// <summary>
        /// Процесс представляет собой консольное приложение, которое запускается без окна консоли.
        /// Поэтому дескриптор консоли для приложения не задан.
        /// Этот флаг игнорируется, если приложение не является консольным или
        /// используется либо с CREATE_NEW_CONSOLE, либо с DETACHED_PROCESS.
        /// </summary>
        CREATE_NO_WINDOW = 0x08000000,

        /// <summary>
        /// Процесс должен быть запущен как защищенный процесс.
        /// Система ограничивает доступ к защищенным процессам и потокам защищенных процессов.
        /// Дополнительные сведения о том, как процессы могут взаимодействовать с защищенными процессами, см.
        /// в разделе Безопасность процессов и права доступа.
        /// https://docs.microsoft.com/en-us/windows/win32/procthread/process-security-and-access-rights
        /// </summary>
        CREATE_PROTECTED_PROCESS = 0x00040000,

        /// <summary>
        /// Позволяет вызывающей стороне выполнить дочерний процесс,
        /// который обходит ограничения процесса, которые обычно автоматически применяются к процессу.
        /// </summary>
        CREATE_PRESERVE_CODE_AUTHZ_LEVEL = 0x02000000,

        /// <summary>
        /// Этот флаг разрешает запуск безопасных процессов, которые выполняются
        /// в среде безопасности на основе виртуализации.
        /// </summary>
        CREATE_SECURE_PROCESS = 0x00400000,

        /// <summary>
        /// Этот флаг действителен только при запуске 16-битного приложения на базе Windows.
        /// Если установлено, новый процесс запускается на частной виртуальной машине DOS (VDM).
        /// По умолчанию все 16-разрядные приложения на базе Windows работают как потоки в одном общем VDM.
        /// Преимущество отдельного запуска состоит в том, что сбой прерывает работу только одного модуля VDM.
        /// </summary>
        CREATE_SEPARATE_WOW_VDM = 0x00000800,

        /// <summary>
        /// Флаг действителен только при запуске 16-битного приложения на базе Windows.
        /// Если переключатель DefaultSeparateVDM в разделе Windows файла WIN.INI имеет значение TRUE,
        /// этот флаг переопределяет переключатель. Новый процесс запускается на общей виртуальной машине DOS.
        /// </summary>
        CREATE_SHARED_WOW_VDM = 0x00001000,

        /// <summary>
        /// Основной поток нового процесса создается в приостановленном состоянии и
        /// не запускается до тех пор, пока не будет вызвана функция ResumeThread.
        /// </summary>
        CREATE_SUSPENDED = 0x00000004,

        /// <summary>
        /// Если этот флаг установлен, блок среды, на который указывает lpEnvironment,
        /// использует символы Unicode. В противном случае блок среды использует символы ANSI.
        /// </summary>
        CREATE_UNICODE_ENVIRONMENT = 0x00000400,

        /// <summary>
        /// Вызывающий поток запускает и отлаживает новый процесс.
        /// Он может получать все связанные события отладки с помощью функции WaitForDebugEvent.
        /// </summary>
        DEBUG_ONLY_THIS_PROCESS = 0x00000002,

        /// <summary>
        /// Вызывающий поток запускает и отлаживает новый процесс и все дочерние процессы,
        /// созданные новым процессом. Он может получать все связанные события отладки
        /// с помощью функции WaitForDebugEvent.
        /// Процесс, использующий DEBUG_PROCESS, становится корнем цепочки отладки.
        /// Это продолжается до тех пор, пока не будет создан другой процесс в цепочке с помощью DEBUG_PROCESS.
        /// Если этот флаг сочетается с DEBUG_ONLY_THIS_PROCESS, вызывающая программа отлаживает только новый процесс,
        /// а не какие-либо дочерние процессы.
        /// </summary>
        DEBUG_PROCESS = 0x00000001,

        /// <summary>
        /// Для консольных процессов новый процесс не наследует консоль своего родителя (по умолчанию).
        /// Новый процесс может позже вызвать функцию AllocConsole для создания консоли.
        /// Дополнительные сведения см. в разделе Создание консоли.
        /// Это значение нельзя использовать с CREATE_NEW_CONSOLE.
        /// </summary>
        DETACHED_PROCESS = 0x00000008,

        /// <summary>
        /// Процесс создается с расширенной информацией о запуске;
        /// параметр lpStartupInfo указывает структуру STARTUPINFOEX.
        /// Windows Server 2003 и Windows XP: это значение не поддерживается.
        /// </summary>
        EXTENDED_STARTUPINFO_PRESENT = 0x00080000,

        /// <summary>
        /// Процесс наследует родство своего родителя.
        /// Если родительский процесс имеет потоки более чем в одной группе процессоров,
        /// новый процесс наследует групповое родство произвольной группы, используемой родительским процессом.
        /// Windows Server 2008, Windows Vista, Windows Server 2003 и Windows XP: это значение не поддерживается.
        /// </summary>
        INHERIT_PARENT_AFFINITY = 0x00010000
    }
}