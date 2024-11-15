using System;
using System.Drawing;
using System.Runtime.InteropServices;
using WinApi.Kernel32.Structs;
using WinApi.User32.Enums;
using WinApi.User32.Structs;

namespace WinApi.User32
{
    public class User32
    {
        const string libraryName = "User32.dll";

        /// <summary>
        /// Извлекает дескриптор в окно верхнего уровня, имя класса и имя окна которого соответствуют указанным строкам.
        /// Эта функция не выполняет поиск дочерних окон. Эта функция не выполняет поиск с учетом регистра.
        /// Для поиска дочерних окон, начиная с указанного дочернего окна, используйте функцию FindWindowEx .
        /// </summary>
        /// <param name="className">Имя класса или атом класса, созданный при предыдущем вызове функции
        /// RegisterClass или RegisterClassEx. Атом должен быть в нижнем порядке слово lpClassName;
        /// Слово высокого порядка должно быть равно нулю.
        /// Если lpClassName указывает на строку, она указывает имя класса окна. Имя класса может быть любым именем,
        /// зарегистрированным с помощью RegisterClass или RegisterClassEx, или любым из предопределенных
        /// имен классов элементов управления.Если lpClassName имеет значение NULL, оно находит любое окно,
        /// заголовок которого соответствует параметру lpWindowName .</param>
        /// <param name="windowName">Имя окна (заголовок окна). Если этот параметр имеет значение NULL, все имена окон совпадают.</param>
        /// <returns>Если функция выполняется успешно, возвращаемое значение представляет собой дескриптор для окна
        /// с указанным именем класса и именем окна.Если функция завершается сбоем, возвращается значение NULL.
        /// Эта функция не изменяет значение последней ошибки.</returns>
        [DllImport(libraryName, CharSet = CharSet.Ansi)]
        public static extern IntPtr FindWindowA(string className, string windowName);

        /// <summary>
        /// Извлекает дескриптор для окна верхнего уровня, имя класса и имя окна которого соответствуют указанным строкам.
        /// Эта функция не выполняет поиск дочерних окон. Эта функция не выполняет поиск с учетом регистра.
        /// Для поиска дочерних окон, начиная с указанного дочернего окна, используйте функцию FindWindowEx .
        /// </summary>
        /// <param name="className">Имя класса или атом класса, созданный предыдущим вызовом функции
        /// RegisterClass или RegisterClassEx . Атом должен быть в нижнем порядке в слове lpClassName;
        /// Слово высокого порядка должно быть равно нулю. Если lpClassName указывает на строку,
        /// она указывает имя класса окна. Имя класса может быть любым именем, зарегистрированным
        /// в RegisterClass или RegisterClassEx, или любым из предопределенных имен класса элементов управления.
        /// Если lpClassName имеет значение NULL, он находит любое окно, заголовок которого
        /// соответствует параметру lpWindowName .</param>
        /// <param name="windowName">Имя окна (название окна). Если этот параметр имеет значение NULL,
        /// все имена окон совпадают.</param>
        /// <returns>Если функция выполняется успешно, возвращаемое значение представляет собой дескриптор
        /// окна с указанным именем класса и именем окна. Если функция завершается сбоем, возвращается значение NULL.
        /// Эта функция не изменяет значение последней ошибки.</returns>
        [DllImport(libraryName, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindowW(string className, string windowName);

        /// <summary>
        /// Положение курсора всегда указывается в координатах экрана и не зависит
        /// от режима отображения окна, содержащего курсор.
        /// Вызывающий процесс должен иметь WINSTA_READATTRIBUTES доступ к оконной станции.
        /// Рабочий стол для ввода должен быть текущим рабочим столом при вызове GetCursorPos.
        /// Вызовите OpenInputDesktop, чтобы определить, является ли текущий рабочий
        /// стол рабочим столом ввода. Если это не так, вызовите SetThreadDesktop с HDESK,
        /// возвращаемым OpenInputDesktop, чтобы переключиться на этот рабочий стол.
        /// </summary>
        /// <param name="lpPoint">Указатель на структуру WinApi.User32.Structs.POINT</param>
        /// <returns>Возвращает ненулевое значение в случае успеха или ноль
        /// в противном случае. Чтобы получить расширенную информацию об ошибке,
        /// вызовите GetLastError.</returns>
        [DllImport(libraryName, SetLastError = true, EntryPoint = "GetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(out POINT lpPoint);

        /// <summary>
        /// Перемещает курсор в указанные координаты экрана. Если новые координаты
        /// находятся за пределами прямоугольника экрана, установленного последним
        /// вызовом функции ClipCursor, система автоматически корректирует координаты
        /// таким образом, чтобы курсор оставался внутри прямоугольника.
        /// </summary>
        /// <param name="x">Новая координата x курсора в экранных координатах.</param>
        /// <param name="y">Новая координата y курсора в экранных координатах.</param>
        /// <returns>Возвращает ненулевое значение в случае успеха или ноль в
        /// противном случае. Чтобы получить расширенную информацию об ошибке,
        /// вызовите GetLastError.</returns>
        [DllImport(libraryName, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCursorPos(int x, int y);

        /// <summary>
        /// Переносит поток, создавший указанное окно, на передний план и активирует окно.
        /// Ввод с помощью клавиатуры направляется в окно, и для пользователя изменяются различные визуальные подсказки.
        /// Система назначает потоку, создавщему окно переднего плана, немного более высокий приоритет, чем другим потокам.
        /// Информация по ньюанасам. https://learn.microsoft.com/ru-ru/windows/win32/api/winuser/nf-winuser-setforegroundwindow#remarks
        /// </summary>
        /// <param name="hWnd">Дескриптор окна, которое должно быть активировано и выведено на передний план.</param>
        /// <returns>Если окно было выведено на передний план, возвращаемое значение не равно нулю.
        /// Если окно не было выведено на передний план, возвращаемое значение равно нулю.</returns>
        [DllImport(libraryName)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// Изменяет размер, положение и порядок Z дочернего, всплывающего окна или окна верхнего уровня.
        /// Эти окна упорядочены в соответствии с их внешним видом на экране.
        /// Самое верхнее окно получает наивысший ранг и является первым окном в порядке Z.
        /// </summary>
        /// <param name="hWnd">Дескриптор окна.</param>
        /// <param name="hWndAfter">Дескриптор окна перед расположенным окном в порядке Z.
        /// Этот параметр должен быть дескриптором окна или одним из следующих значений.</param>
        /// <param name="x">Новое положение левой части окна в клиентских координатах.</param>
        /// <param name="y">Новое положение верхней части окна в клиентских координатах.</param>
        /// <param name="cx">Новая ширина окна (в пикселях).</param>
        /// <param name="cy">Новая высота окна (в пикселях).</param>
        /// <param name="flags">Флаги определения размера и расположения окна.
        /// Этот параметр может быть сочетанием следующих значений.
        /// https://learn.microsoft.com/ru-ru/windows/win32/api/winuser/nf-winuser-setwindowpos#parameters</param>
        /// <returns>Если функция выполняется успешно, возвращается ненулевое значение.
        /// Если функция выполняется неудачно, возвращается нулевое значение.
        /// Дополнительные сведения об ошибке можно получить, вызвав GetLastError.</returns>
        [DllImport(libraryName, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndAfter, int x, int y, int cx, int cy, uint flags);

        /// <summary>
        /// Открывает рабочий стол, который получает данные, введенные пользователем.
        /// </summary>
        /// <param name="dwFlags">Этот параметр может быть равен нулю или следующему значению.
        /// DF_ALLOWOTHERACCOUNTHOOK=0x0001 - Позволяет процессам, запущенным в других учетных записях на рабочем столе,
        /// устанавливать перехватчики в этом процессе.</param>
        /// <param name="fInherit">Если это значение равно TRUE, процессы, созданные этим процессом,
        /// наследуют дескриптор. В противном случае процессы не наследуют этот дескриптор.</param>
        /// <param name="dwDesiredAccess">Флаг доступа к рабочему столу.</param>
        /// <returns>Если функция выполняется успешно, возвращаемое значение представляет собой дескриптор рабочего стола,
        /// который получает входные данные пользователя.
        /// Если функция завершается сбоем, возвращается значение NULL.
        /// Дополнительные сведения об ошибке можно получить, вызвав GetLastError.</returns>
        [DllImport(libraryName, SetLastError = true)]
        public static extern IntPtr OpenInputDesktop(
            long dwFlags,
            [param:MarshalAs(UnmanagedType.Bool)]
            bool fInherit,
            int dwDesiredAccess);

        /// <summary>
        /// Закрывает открытый дескриптор для объекта рабочего стола.
        /// </summary>
        /// <param name="hDesktop">Дескриптор для закрываемого рабочего стола.
        /// Не указывайте дескриптор, возвращаемый функцией GetThreadDesktop .</param>
        /// <returns>Если функция выполняется успешно, возвращается ненулевое значение.
        /// Если функция выполняется неудачно, возвращается нулевое значение.
        /// Дополнительные сведения об ошибке можно получить, вызвав GetLastError.</returns>
        [DllImport(libraryName, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseDesktop(IntPtr hDesktop);

        /// <summary>
        /// Создает новый рабочий стол, связывает его с текущей оконной станцией вызывающего процесса и назначает
        /// его вызывающему потоку. Вызывающий процесс должен иметь связанную оконную станцию,
        /// назначенную системой во время создания процесса или заданную функцией SetProcessWindowStation .
        /// </summary>
        /// <param name="lpszDesktop">Имя создаваемого рабочего стола. Имена рабочих столов не учитывают регистр
        /// и не могут содержать символы обратной косой черты (\).</param>
        /// <param name="lpszDevice">Защищены; значение должно иметь значение NULL.</param>
        /// <param name="pDevmode">Защищены; значение должно иметь значение NULL.</param>
        /// <param name="dvFlags">Этот параметр может быть равен нулю или следующему значению.
        /// DF_ALLOWOTHERACCOUNTHOOK=0x0001</param>
        /// <param name="dwDesiredAccess">Доступ к рабочему столу. Список значений см.
        /// в https://learn.microsoft.com/ru-ru/windows/desktop/winstation/desktop-security-and-access-rights</param>
        /// <param name="lpsa">Элемент lpSecurityDescriptor структуры задает дескриптор безопасности для нового рабочего стола.
        /// Если этот параметр имеет значение NULL, рабочий стол наследует дескриптор безопасности от родительской станции окна.</param>
        /// <returns>Если функция выполнена успешно, возвращаемое значение будет дескриптором для только что созданного рабочего стола.
        /// Если указанный рабочий стол уже существует, функция выполняется успешно и возвращает дескриптор существующему рабочему столу.</returns>
        [DllImport(libraryName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr CreateDesktopA(
            [param:MarshalAs(UnmanagedType.LPStr)]
            string lpszDesktop,
            [param:MarshalAs(UnmanagedType.LPStr)]
            string lpszDevice,
            ref Devmodea pDevmode,
            int dvFlags,
            int dwDesiredAccess,
            ref SecurityAttributes lpsa);

        /// <summary>
        /// Создает новый рабочий стол, связывает его с текущей станцией окна вызывающего процесса и
        /// назначает его вызывающему потоку. Вызывающий процесс должен иметь связанную оконную станцию,
        /// назначенную системой во время создания процесса или заданную функцией SetProcessWindowStation .
        /// </summary>
        /// <param name="lpszDesktop">Имя создаваемого рабочего стола. Имена рабочих столов не учитывают регистр
        /// и могут не содержать символы обратной косой черты (\).</param>
        /// <param name="lpszDevice">Защищены; значение должно иметь значение NULL.</param>
        /// <param name="pDevmode">Защищены; значение должно иметь значение NULL.</param>
        /// <param name="dwFlags">Этот параметр может быть равен нулю или следующему значению.</param>
        /// <param name="dwDesiredAccess">Этот параметр должен включать право доступа DESKTOP_CREATEWINDOW ,
        /// так как для создания окна внутри CreateDesktop использует дескриптор.</param>
        /// <param name="lpsa">Указатель на структуру SECURITY_ATTRIBUTES , которая определяет,
        /// может ли возвращенный дескриптор наследоваться дочерними процессами. Если lpsa имеет значение NULL,
        /// дескриптор не может быть унаследован.</param>
        /// <returns>Если функция выполняется успешно, возвращаемое значение будет дескриптором только что созданного рабочего стола.
        /// Если указанный рабочий стол уже существует, функция выполняется успешно и возвращает дескриптор 
        /// существующему рабочему столу.</returns>
        [DllImport(libraryName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateDesktopW(
            [param:MarshalAs(UnmanagedType.LPWStr)]
            string lpszDesktop,
            [param:MarshalAs(UnmanagedType.LPWStr)]
            string lpszDevice,
            ref Devmodea pDevmode,
            int dwFlags,
            int dwDesiredAccess,
            ref SecurityAttributes lpsa);

        /// <summary>
        /// Назначает указанную оконную станцию вызывающему процессу.
        /// Это позволяет процессу получать доступ к объектам в оконной станции, таким как рабочие столы,
        /// буфер обмена и глобальные атомы. Все последующие операции на оконной станции используют права доступа,
        /// предоставленные hWinSta.
        /// </summary>
        /// <param name="hWinSta">Дескриптор оконной станции.</param>
        /// <returns></returns>
        [DllImport(libraryName, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessWindowStation(IntPtr hWinSta);

        /// <summary>
        /// Извлекает дескриптор в текущую станцию окон для вызывающего процесса.
        /// </summary>
        /// <returns>Если функция выполняется успешно, возвращаемое значение будет дескриптором оконной станции.
        /// Если функция завершается сбоем, возвращается значение NULL.</returns>
        [DllImport (libraryName, SetLastError = true)]
        public static extern IntPtr GetProcessWindowStation();

        /// <summary>
        /// Синтезирует нажатия клавиш, движения мыши и нажатия кнопок.
        /// </summary>
        /// <param name="countStruct">Число структур в массиве.</param>
        /// <param name="input">Массив структур INPUT.
        /// Каждая структура представляет событие для вставки в поток ввода с клавиатуры или мыши.</param>
        /// <param name="size">Размер (в байтах) структуры INPUT.
        /// Если cbSize не соответствует размеру структуры INPUT , функция завершается ошибкой.</param>
        /// <returns>Функция возвращает количество событий, успешно вставляемых в поток ввода с клавиатуры или мыши.
        /// Если функция возвращает ноль, входные данные уже заблокированы другим потоком.
        /// Дополнительные сведения об ошибке можно получить, вызвав GetLastError.</returns>
        [DllImport(libraryName, SetLastError = true)]
        public static extern uint SendInput(uint countStruct, ref Input input, int size);
    }
}