using System;
using System.Windows.Forms;

namespace AdvancedFileSearcher
{
    /**
     * Класс для вспомогательных методов
     */
    public static class Utils
    {
        // Поиск вхождения подстроки в строке
        public static bool FindText(string target, string keyword, bool regCase = false)
        {
            if (!string.IsNullOrEmpty(target))
            {
                if (regCase)
                {
                    if (target.IndexOf(keyword) > -1) return true;
                }
                else if (target.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) > -1)
                    return true;
            }
            return false;
        }

        // Вывод сообщения
        public static void ShowMessage(string text)
        {
            MessageBox.Show(text);
        }
    }
}
