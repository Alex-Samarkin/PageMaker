﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageMakerLib
{
    public static class About
    {
        /// <summary>
        /// строка выводится "как есть"
        /// </summary>
        public static string Description = @"
Создадим простой редактор HTML документов (несколько устаревший, естественно)
1. HTML документ состоит из более-менее фиксированного заголовка <head> и тела <body>
2. Содержимое документа является набором абзацев (тег <p>)
3. Абзацы можно выравнивать align
4. Текст в абзаце набирается единым шрифтом font
5. Можно задать гарнитуру шрифта, размер и цвет
6. Более правильно использовать таблицу стилей, естественно :)

Таким образом, мы должны создать:
Общий класс - HTML документ
В нем присутствует класс заголовка
в нем присутствует текст как массив абзацев
Абзац это содержание, шрифт и выравнивание
Логично собрать выравниевание и шрифт в два класса и соединиить их в стиль абзаца

Для удобства эти классы вынесены в отдельную библиотеку (обратите внимание на два проекта)
Библиотека подключается к основному проекту в два шага:
1. Добавляется ссылка (контекстное меню в пункте Ссылки или Reference - в зависимости от языка студии
2. Добавляется соответствующий using PageMakerLib

При компиляции отслеживаются зависимости PageMaker от PageMakerLib и сначала при необходимости 
компилируется библиотека, а затем - главный проект.

Вы видите статический класс, который выдает это описание в консоль, библиотека уже подключена.
";
    }
}
