namespace WinApi.User32.Enums
{
    /// <summary>
    /// Показаны имена символьных констант, шестнадцатеричные значения и эквиваленты мыши или
    /// клавиатуры для кодов виртуальных ключей, используемых системой.
    /// </summary>
    public enum VirtualKey
    {
        /// <summary>
        /// Левая кнопка мыши.
        /// </summary>
        VK_LBUTTON = 0x01,

        /// <summary>
        /// Правая кнопка мыши.
        /// </summary>
        VK_RBUTTON = 0x02,

        /// <summary>
        /// Обработка контроля и прерывания.
        /// </summary>
        VK_CANCEL = 0x03,

        /// <summary>
        /// Средняя кнопка мыши.
        /// </summary>
        VK_MBUTTON = 0x04,

        /// <summary>
        /// Кнопка мыши X1.
        /// </summary>
        VK_XBUTTON1 = 0x05,

        /// <summary>
        /// Кнопка мыши X2.
        /// </summary>
        VK_XBUTTON2 = 0x06,

        /// <summary>
        /// Зарезервировано.
        /// </summary>
        VK_Empty_1 = 0x07,

        /// <summary>
        /// Backspace.
        /// </summary>
        VK_BACK = 0x08,

        /// <summary>
        /// Tab.
        /// </summary>
        VK_TAB = 0x09,

        /// <summary>
        /// Зарезервировано.
        /// </summary>
        VK_Empty_2 = 0x0A,

        /// <summary>
        /// Зарезервировано.
        /// </summary>
        VK_Empty_3 = 0x0B,

        /// <summary>
        /// Клавиша CLEAR.
        /// </summary>
        VK_CLEAR = 0x0C,

        /// <summary>
        /// Клавиша ВВОД.
        /// </summary>
        VK_RETURN = 0x0D,

        /// <summary>
        /// Не присвоено.
        /// </summary>
        VK_Empty_4 = 0x0E,

        /// <summary>
        /// Не присвоено.
        /// </summary>
        VK_Empty_5 = 0x0F,

        /// <summary>
        /// Клавиша SHIFT.
        /// </summary>
        VK_SHIFT = 0x10,

        /// <summary>
        /// Клавиша CTRL.
        /// </summary>
        VK_CONTROL = 0x11,

        /// <summary>
        /// ALT - клавиша
        /// </summary>
        VK_MENU = 0x12,

        /// <summary>
        /// Клавиша PAUSE
        /// </summary>
        VK_PAUSE = 0x13,

        /// <summary>
        /// Клавиша CAPS LOCK
        /// </summary>
        VK_CAPITAL = 0x14,

        /// <summary>
        /// Режим "Кана" редактора метода ввода
        /// </summary>
        VK_KANA = 0x15,

        /// <summary>
        /// Режим "Хангыль" редактора метода ввода
        /// </summary>
        VK_HANGUL = 0x15,

        /// <summary>
        /// IME включено
        /// </summary>
        VK_IME_ON = 0x16,

        /// <summary>
        /// Режим "Джунджа" редактора метода ввода
        /// </summary>
        VK_JUNJA = 0x17,

        /// <summary>
        /// Последний режим редактора метода ввода
        /// </summary>
        VK_FINAL = 0x18,

        /// <summary>
        /// Режим "Ханджа" редактора метода ввода
        /// </summary>
        VK_HANJA = 0x19,

        /// <summary>
        /// Режим "Кандзи" редактора метода ввода
        /// </summary>
        VK_KANJI = 0x19,

        /// <summary>
        /// IME выкл.
        /// </summary>
        VK_IME_OFF = 0x1A,

        /// <summary>
        /// Клавиша ESC
        /// </summary>
        VK_ESCAPE = 0x1B,

        /// <summary>
        /// Преобразование в редакторе метода ввода
        /// </summary>
        VK_CONVERT = 0x1C,

        /// <summary>
        /// Нет преобразования в редакторе метода ввода
        /// </summary>
        VK_NONCONVERT = 0x1D,

        /// <summary>
        /// Принять IME
        /// </summary>
        VK_ACCEPT = 0x1E,

        /// <summary>
        /// Запрос на изменение режима редактора метода ввода
        /// </summary>
        VK_MODECHANGE = 0x1F,

        /// <summary>
        /// ПРОБЕЛ
        /// </summary>
        VK_SPACE = 0x20,

        /// <summary>
        /// Клавиша PAGE UP
        /// </summary>
        VK_PRIOR = 0x21,

        /// <summary>
        /// КЛАВИША PAGE DOWN
        /// </summary>
        VK_NEXT = 0x22,

        /// <summary>
        /// Клавиша END
        /// </summary>
        VK_END = 0x23,

        /// <summary>
        /// HOME
        /// </summary>
        VK_HOME = 0x24,

        /// <summary>
        /// КЛАВИША СТРЕЛКА ВЛЕВО
        /// </summary>
        VK_LEFT = 0x25,

        /// <summary>
        /// КЛАВИША СТРЕЛКА ВВЕРХ
        /// </summary>
        VK_UP = 0x26,

        /// <summary>
        /// КЛАВИША СТРЕЛКА ВПРАВО
        /// </summary>
        VK_RIGHT = 0x27,

        /// <summary>
        /// КЛАВИША СТРЕЛКА ВНИЗ
        /// </summary>
        VK_DOWN = 0x28,

        /// <summary>
        /// Клавиша SELECT
        /// </summary>
        VK_SELECT = 0x29,

        /// <summary>
        /// Клавиша PRINT
        /// </summary>
        VK_PRINT = 0x2A,

        /// <summary>
        /// Клавиша EXECUTE
        /// </summary>
        VK_EXECUTE = 0x2B,

        /// <summary>
        /// КЛАВИША PRINT SCREEN
        /// </summary>
        VK_SNAPSHOT = 0x2C,

        /// <summary>
        /// Insert
        /// </summary>
        VK_INSERT = 0x2D,

        /// <summary>
        /// Клавиша DEL
        /// </summary>
        VK_DELETE = 0x2E,

        /// <summary>
        /// Клавиша HELP
        /// </summary>
        VK_HELP = 0x2F,

        /// <summary>
        /// цифра 0
        /// </summary>
        VK_0 = 0x30,

        /// <summary>
        /// цифра 1
        /// </summary>
        VK_1 = 0x31,

        /// <summary>
        /// цифра 2
        /// </summary>
        VK_2 = 0x32,

        /// <summary>
        /// цифра 3
        /// </summary>
        VK_3 = 0x33,

        /// <summary>
        /// цифра 4
        /// </summary>
        VK_4 = 0x34,

        /// <summary>
        /// цифра 5
        /// </summary>
        VK_5 = 0x35,

        /// <summary>
        /// цифра 6
        /// </summary>
        VK_6 = 0x36,

        /// <summary>
        /// цифра 7
        /// </summary>
        VK_7 = 0x37,

        /// <summary>
        /// цифра 8
        /// </summary>
        VK_8 = 0x38,

        /// <summary>
        /// цифра 9
        /// </summary>
        VK_9 = 0x39,

        /// <summary>
        /// Клавиша A
        /// </summary>
        VK_KEY = 0x41,

        /// <summary>
        /// Клавиша B
        /// </summary>
        VK_B = 0x42,

        /// <summary>
        /// Клавиша C
        /// </summary>
        VK_C = 0x43,

        /// <summary>
        /// Клавиша D
        /// </summary>
        VK_D = 0x44,

        /// <summary>
        /// Клавиша E
        /// </summary>
        VK_E = 0x45,

        /// <summary>
        /// Клавиша F
        /// </summary>
        VK_F = 0x46,

        /// <summary>
        /// Клавиша G
        /// </summary>
        VK_G = 0x47,

        /// <summary>
        /// Клавиша H
        /// </summary>
        VK_H = 0x48,

        /// <summary>
        /// Клавиша I
        /// </summary>
        VK_I = 0x49,

        /// <summary>
        /// Клавиша J
        /// </summary>
        VK_J = 0x4A
    }
}