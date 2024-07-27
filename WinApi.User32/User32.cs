using System.Drawing;
using System.Runtime.InteropServices;
using WinApi.User32.Structs;

namespace WinApi.User32
{
    public class User32
    {
        const string libraryName = "User32.dll";

        /// <summary>
        /// Положение курсора всегда указывается в координатах экрана и не зависит
        /// от режима отображения окна, содержащего курсор.
        /// Вызывающий процесс должен иметь WINSTA_READATTRIBUTES доступ к оконной станции.
        /// Рабочий стол для ввода должен быть текущим рабочим столом при вызове GetCursorPos.
        /// Вызовите OpenInputDesktop, чтобы определить, является ли текущий рабочий
        /// стол рабочим столом ввода. Если это не так, вызовите SetThreadDesktop с HDESK,
        /// возвращаемым OpenInputDesktop, чтобы переключиться на этот рабочий стол.
        /// </summary>
        /// <param name="lpPoint">Указатель на структуру System.Drawing.Point</param>
        /// <returns>Возвращает ненулевое значение в случае успеха или ноль
        /// в противном случае. Чтобы получить расширенную информацию об ошибке,
        /// вызовите GetLastError.</returns>
        [DllImport(libraryName, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(out Point lpPoint);
    }
}