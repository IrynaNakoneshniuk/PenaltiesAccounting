using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
namespace PenaltiesAccounting
{
    internal static class TextArrayOutput
    {
        public  static string [] ?TextForOutPut;
        public static int Size = 40;
        static TextArrayOutput()
        {
            TextForOutPut = new string[Size];
        }
        public static void TextOutput()
        {
            TextForOutPut[0]= "Введіть ім'я: ";
            TextForOutPut[1] = "По батькві: ";
            TextForOutPut[2] = "Прізвище: ";
            TextForOutPut[3] = "Ідентифікаційний код: ";
            TextForOutPut[4] = "Створіть пароль: ";
            TextForOutPut[5] = "Повторіть пароль: ";
            TextForOutPut[6] = "Номер та серія посвідчення:   ";
            TextForOutPut[7] = "Структурна одиниця: ";
            TextForOutPut[8] = "Дата створення акаунту: ";
            TextForOutPut[9] = "Невірний формат";
            TextForOutPut[10] = "Ввведіть номер протоколу: ";
            TextForOutPut[11] ="Введіть ідентифікаційний номер:  ";
            TextForOutPut[12] ="Ввведіть суму штрафу: ";
            TextForOutPut[13] ="Введіть дату накладення штрафу: ";
            TextForOutPut[14] ="Введіть номер автомобіля";
            TextForOutPut[15] ="Введіть емейл";
            TextForOutPut[16] = "Введіть пароль";
            TextForOutPut[17] = "Вітаємо";
            TextForOutPut[18] = "Користувача не знайдено!";
            TextForOutPut[19] = "Зробіть вибір: ";
            TextForOutPut[20] = "Для виходу натисніть 1";
            TextForOutPut[21] = "<1.Детальна інформація про штрафи";
            TextForOutPut[22] = "Меню";
            TextForOutPut[23] = "<1.Увійти";
            TextForOutPut[24] = "<2.Реєстрація";
            TextForOutPut[25] = "<3.Вихід";
            TextForOutPut[26] = "<1.Увійти як користувач";
            TextForOutPut[27] = "<2.Увійти як представник виконачого органу";
            TextForOutPut[28] = "<1.Зареєструватись як представник виконачого органу";
            TextForOutPut[29] = "<2.Зареєструватись як користувач";
            TextForOutPut[30] = "1<Зареєструвати штраф!";
            TextForOutPut[31] = "2<Головна сторінка!";
            TextForOutPut[32] = "1<Перевірити наявність штрафів";
            TextForOutPut[33] = "2<Головна сторінка!";
            TextForOutPut[34] = "1<Зареєструвати протокол порушення ПДР";
            TextForOutPut[35] = "2<Зареєструвати адмінстративний протокол";
            TextForOutPut[36] = "5<Список штрафів";
            TextForOutPut[37] = "1<Додати протокол";
        }
    }
}
