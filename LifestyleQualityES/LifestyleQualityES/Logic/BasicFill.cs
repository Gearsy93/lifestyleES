using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifestyleQualityES.Model
{
    internal static class BasicFill
    {
        public static KnowledgeBase InitialFill()
        {
            Domain d1 = new Domain("Да/Нет", false);
            d1.AddDomainValue(new DomainValue("Да", d1));
            d1.AddDomainValue(new DomainValue("Нет", d1));
            Domain d2 = new Domain("Выполняется/Не выполняется", false);
            d2.AddDomainValue(new DomainValue("Выполняется", d2));
            d2.AddDomainValue(new DomainValue("Не выполняется", d2));
            Domain d3 = new Domain("Часто/Умеренно/Редко", false);
            d3.AddDomainValue(new DomainValue("Часто", d3));
            d3.AddDomainValue(new DomainValue("Умеренно", d3));
            d3.AddDomainValue(new DomainValue("Редко", d3));
            Domain d4 = new Domain("Отклоняется не более, чем на 12%/Отклоняется более, чем на 12%", false);
            d4.AddDomainValue(new DomainValue("Отклоняется не более, чем на 12%", d4));
            d4.AddDomainValue(new DomainValue("Отклоняется более, чем на 12%", d4));
            Domain d5 = new Domain("Основная/Подготовительная/Специальная", false);
            d5.AddDomainValue(new DomainValue("Основная", d5));
            d5.AddDomainValue(new DomainValue("Подготовительная", d5));
            d5.AddDomainValue(new DomainValue("Специальная", d5));
            Domain d6 = new Domain("Напрямую связана со спортом/Не связана со спортом", false);
            d6.AddDomainValue(new DomainValue("Напрямую связана со спортом", d6));
            d6.AddDomainValue(new DomainValue("Не связана со спортом", d6));
            Domain d7 = new Domain("Подвижный/Сидячий", false);
            d7.AddDomainValue(new DomainValue("Подвижный", d7));
            d7.AddDomainValue(new DomainValue("Сидячий", d7));
            Domain d8 = new Domain("Спортивный клуб/Активных отдых/Спортивные игры/Гимнастика/Йога/Ничего из перечисленного", false);
            d8.AddDomainValue(new DomainValue("Спортивный клуб", d8));
            d8.AddDomainValue(new DomainValue("Активных отдых", d8));
            d8.AddDomainValue(new DomainValue("Спортивные игры", d8));
            d8.AddDomainValue(new DomainValue("Гимнастика", d8));
            d8.AddDomainValue(new DomainValue("Йога", d8));
            d8.AddDomainValue(new DomainValue("Ничего из перечисленного", d8));
            Domain d9 = new Domain("Редко/Постоянно", false);
            d9.AddDomainValue(new DomainValue("Редко", d9));
            d9.AddDomainValue(new DomainValue("Постоянно", d9));
            Domain d10 = new Domain("Не потребляю вообще/По праздникам/Чаще раза в 2 недели", false);
            d10.AddDomainValue(new DomainValue("Не потребляю вообще", d10));
            d10.AddDomainValue(new DomainValue("По праздникам", d10));
            d10.AddDomainValue(new DomainValue("Чаще раза в 2 недели", d10));
            Domain d11 = new Domain("Более 7/Менее 7", false);
            d11.AddDomainValue(new DomainValue("Более 7", d11));
            d11.AddDomainValue(new DomainValue("Менее 7", d11));
            Domain d12 = new Domain("Воздушные ванны/Солнечные ванны/Контрастный душ/Обливание холодной водой/Ничего из перечисленного", false);
            d12.AddDomainValue(new DomainValue("Воздушные ванны", d12));
            d12.AddDomainValue(new DomainValue("Солнечные ванны", d12));
            d12.AddDomainValue(new DomainValue("Контрастный душ", d12));
            d12.AddDomainValue(new DomainValue("Обливание холодной водой", d12));
            d12.AddDomainValue(new DomainValue("Ничего из перечисленного", d12));
            Domain d13 = new Domain("Часто/Редко", false);
            d13.AddDomainValue(new DomainValue("Часто", d13));
            d13.AddDomainValue(new DomainValue("Редко", d13));
            Domain d14 = new Domain("Очень низкий/Низкий/Ниже среднего/Средний/Выше среднего/Высокий/Очень высокий", false);
            d14.AddDomainValue(new DomainValue("Очень низкий", d14));
            d14.AddDomainValue(new DomainValue("Низкий", d14));
            d14.AddDomainValue(new DomainValue("Ниже среднего", d14));
            d14.AddDomainValue(new DomainValue("Средний", d14));
            d14.AddDomainValue(new DomainValue("Выше среднего", d14));
            d14.AddDomainValue(new DomainValue("Высокий", d14));
            d14.AddDomainValue(new DomainValue("Очень высокий", d14));
            Domain d15 = new Domain("Целочисленный", true);
            for (int i = 0; i <= 12; i++)
            {
                d15.AddDomainValue(new NumericDomainValue(i.ToString(), d15));
            }

            List<Domain> domains = new List<Domain>();
            domains.AddRange(new Domain[] { d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15 });

            Variable v1 = new AskedVariable("Рецепт врача", d1, "У вас есть рецепт врача?");
            Variable v2 = new AskedVariable("Потребление нежелательных блюд", d1, "Вы потребляете нежелательные блюда?");
            Variable v3 = new AskedVariable("Потребление рекомендованных блюд", d1, "Вы потребляете рекомендованные блюда?");
            Variable v4 = new AskedVariable("Потребление молока/мяса", d3, "Как часто вы потребляете мясо/молоко?");
            Variable v5 = new AskedVariable("Потребление суточной нормы калорий", d4, "Оцените ваше суточное потребление калорий");
            Variable v6 = new AskedVariable("Потребление жиров, растительных масел, сладостей", d3, "Вы часто потребляете жиры, растительные масла и сладости?");
            Variable v7 = new AskedVariable("Недостаток микроэлементов в рационе", d1, "У вас есть недостаток микроэлементов в рационе?");
            Variable v8 = new AskedVariable("Группа здоровья", d5, "Какая у вас групппа здоровья?");
            Variable v9 = new AskedVariable("Ежедневная деятельность", d6, "Ваша ежедневная деятельность");
            Variable v10 = new AskedVariable("Образ жизни", d7, "Какой у вас образ жзни?");
            Variable v11 = new AskedVariable("Регулярное выполнение спортивных мероприятий", d8, "У вас есть регулярность в спортивных мероприятиях?");
            Variable v12 = new AskedVariable("Упражнения/разминка в течение дня", d1, "Вы выполняете упражнения/разминку в течение дня?");
            Variable v13 = new AskedVariable("Выполнение упражнений, прописанных врачом", d1, "Вы выполняете упражнения, рекомендованные врачом?");
            Variable v14 = new AskedVariable("Несоблюдение ограничений группы здоровья", d9, "Вы часто не соблюдаете ограничения по группе здоровья?");
            Variable v15 = new AskedVariable("Потребление наркотических или психотропных веществ", d1, "Вы употребляете наркотические или психотропные вещества?");
            Variable v16 = new AskedVariable("Потребление алкоголя", d10, "Как часто вы употребляете алкоголь?");
            Variable v17 = new AskedVariable("Темное помещение для сна", d1, "У вас темное помещение для сна?");
            Variable v18 = new AskedVariable("Правильная поза сна", d1, "Вы соблюдаете правильную позу для сна?");
            Variable v19 = new AskedVariable("Часы сна", d11, "Сколько часов вы спите?");
            Variable v20 = new AskedVariable("Cоблюдение биоритмологического оптимума", d1, "Вы соблюдаете биоритмологический оптимум?");
            Variable v21 = new AskedVariable("Синхронизация часов сна", d1, "У вас синхронизированы часы сна?");
            Variable v22 = new AskedVariable("Уход за волосами", d1, "Вы ухаживаете за своими волосами?");
            Variable v23 = new AskedVariable("Уход за полостью рта", d1, "Вы ухаживаете за полостью рта?");
            Variable v24 = new AskedVariable("Уход за кожей", d1, "Вы ухаживаете за кожей?");
            Variable v25 = new AskedVariable("Закаливающие процедуры", d12, "Вы выполняете закаливающие процедуры?");
            Variable v26 = new AskedVariable("Профилактика ИППП", d1, "Вы соблюдаете профилактику ИППП?");
            Variable v27 = new AskedVariable("Социальная активность", d1, "У вас есть социальная активность?");
            Variable v28 = new AskedVariable("Депрессивное состояние", d13, "У вас часто случаются депрессивные состояния?");
            Variable v29 = new AskedVariable("Правильное выражение эмоций", d1, "Вы правильно выражаете эмоции?");
            Variable v30 = new AskedVariable("Посещение психолога/психиатра", d1, "Вы посещаете психолога/психиатра?");
            Variable v31 = new AskedVariable("Снятие стресса/тревоги", d1, "Вы снимаете стресс/тревогу?");
            Variable v32 = new AskedVariable("Избегание конфликтов", d1, "Вы избегаете конфликты?");

            Variable v33 = new DeducibleVariable("Норма питательных элементов", d2);
            Variable v34 = new DeducibleVariable("Соблюдение диеты", d1);
            Variable v35 = new DeducibleVariable("Правильно питание", d15);
            Variable v36 = new DeducibleVariable("Достаточно нагрузки в течение дня", d1);
            Variable v37 = new DeducibleVariable("Правильная физическая активность", d15);
            Variable v38 = new DeducibleVariable("Нагрузка в соответствии с ограничениями группы", d1);
            Variable v39 = new DeducibleVariable("Наличие вредных привычек", d15);
            Variable v40 = new DeducibleVariable("Правильный отдых", d15);
            Variable v41 = new DeducibleVariable("Здоровый сон", d1);
            Variable v42 = new DeducibleVariable("Нарушение биоритмов", d1);
            Variable v43 = new DeducibleVariable("Условия здорового сна", d1);
            Variable v44 = new DeducibleVariable("Правильная гигиена", d1);
            Variable v45 = new DeducibleVariable("Защита иммунитета", d1);
            Variable v46 = new DeducibleVariable("Защита от заболеваний", d15);
            Variable v47 = new DeducibleVariable("Позитивный образ жизни", d1);
            Variable v48 = new DeducibleVariable("Психологическая гибкость", d1);
            Variable v49 = new DeducibleVariable("Правильная псих - эмоциональная культура", d15);
            Variable v50 = new DeducibleVariable("Качество образа жизни", d14);


            Variable v6_1 = new DeducibleVariable("Часть 5 правила", d1);
            Variable v7_1 = new DeducibleVariable("Часть 7 правила", d1);
            Variable v12_1 = new DeducibleVariable("Часть 12 правила", d1);
            Variable v12_fx_1 = new DeducibleVariable("Часть 12_fx правила", d1);
            Variable v26_1 = new DeducibleVariable("Часть 26 правила", d1);
            Variable v38_1 = new DeducibleVariable("Часть 38 правила", d1);
            Variable v43_1 = new DeducibleVariable("Часть 43-44 правил", d1);


            List<Variable> variables = new List<Variable>();
            variables.AddRange(new Variable[] { v1, v2, v3, v4, v5, v6, v6_1, v7, v7_1, v8, v9, v10, v11, v12, v12_1, v12_fx_1, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v26_1, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v38_1, v39, v40, v41, v42, v43, v43_1, v44, v45, v46, v47, v48, v49, v50 });

            //Rule Section
            /*IF: DOCREC = 1 AND UNGDISH = 2 AND RECDISH = 1
            THEN: DIET = 1
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ ИМЕЕТ РЕЦЕПТ У ВРАЧА, НЕ ПОТРЕБЛЯЕТ НЕЖЕЛАТЕЛЬНЫЕ БЛЮДА И ПОТРЕБЛЯЕТ РЕКОМЕНДОВАННЫЕ БЛЮДА, ТО ОН СОБЛЮДАЕТ ДИЕТУ*/
            Fact R1f1 = new SingleFact(v1, d1.GetValueByString("Да"));
            Fact R1f2 = new SingleFact(v2, d1.GetValueByString("Нет"));
            Fact R1f3 = new SingleFact(v3, d1.GetValueByString("Да"));
            Premise R1p = new Premise(FactOperator.Сonjunction);
            R1p.AddFact(R1f1);
            R1p.AddFact(R1f2);
            R1p.AddFact(R1f3);
            SingleFact R1c = new SingleFact(v34, d1.GetValueByString("Да"));
            string R1ex = "Если пользователь имеет рецепт у врача, не потребляет нежелательные блюда и потребляет рекомендованные блюда, то он соблюдает диету";
            Rule R1 = new Rule("R1", R1ex, R1p, R1c);


            /*IF: DOCREC = 1 AND UNGDISH = 1
            THEN: DIET = 2
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ ИМЕЕТ РЕЦЕПТ У ВРАЧА И ПОТРЕБЛЯЕТ НЕЖЕЛАТЕЛЬНЫЕ БЛЮДА, ТО ОН НЕ СОБЛЮДАЕТ ДИЕТУ*/
            Fact R2f1 = new SingleFact(v1, d1.GetValueByString("Да"));
            Fact R2f2 = new SingleFact(v2, d1.GetValueByString("Да"));
            Premise R2p = new Premise(FactOperator.Сonjunction);
            R2p.AddFact(R2f1);
            R2p.AddFact(R2f2);
            SingleFact R2c = new SingleFact(v34, d1.GetValueByString("Нет"));
            string R2ex = "Если пользователь имеет рецепт у врача и потребляет нежелательные блюда, то он не соблюдает диету";
            Rule R2 = new Rule("R2", R2ex, R2p, R2c);

            /*IF: DOCREC = 1 AND RECDISH = 2
            THEN: DIET = 2
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ ИМЕЕТ РЕЦЕПТ У ВРАЧА И НЕ ПОТРЕБЛЯЕТ РЕКОМЕНДОВАННЫЕ БЛЮДА, ТО НЕ СОБЛЮДАЕТ ДИЕТУ*/
            Fact R3f1 = new SingleFact(v1, d1.GetValueByString("Да"));
            Fact R3f2 = new SingleFact(v3, d1.GetValueByString("Нет"));
            Premise R3p = new Premise(FactOperator.Сonjunction);
            R3p.AddFact(R3f1);
            R3p.AddFact(R3f2);
            SingleFact R3c = new SingleFact(v34, d1.GetValueByString("Нет"));
            string R3ex = "Если пользователь имеет рецепт у врача и не потребляет рекомендованные блюда, то не соблюдает диету";
            Rule R3 = new Rule("R3", R3ex, R3p, R3c);

            /*IF: DOCREC = 2 AND MMCONS = 2 AND DAYCAL = 1 AND FVSCONS = 3 AND TRLCK = 2
            THEN: NUTRNORM = 1
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ НЕ ИМЕЕТ РЕЦЕПТ У ВРАЧА, ЕГО ПОТРЕБЛЕНИЕ МЯСА УМЕРЕННОЕ, ПОТРЕБЛЕНИЕ СУТОЧНОЙ НОРМЫ КАЛОРИЙ ОТКЛОНЯЕТСЯ НЕ БОЛЕЕ, ЧЕМ НА 12 %; ПОТРЕБЛЯЕТ ЖИРЫ, РАСТИТЕЛЬНЫЕ МАСЛА, СЛАДОСТИ РЕДКО И НЕ ИМЕЕТ НЕДОСТАТОК МИКРОЭЛЕМЕНТОВ В РАЦИОНЕ, ТО ЕГО НОРМА ПИТАТЕЛЬНЫХ ЭЛЕМЕНТОВ ВЫПОЛНЯЕТСЯ*/
            Fact R4f1 = new SingleFact(v1, d1.GetValueByString("Нет"));
            Fact R4f2 = new SingleFact(v4, d3.GetValueByString("Умеренно"));
            Fact R4f3 = new SingleFact(v5, d4.GetValueByString("Отклоняется не более, чем на 12%"));
            Fact R4f4 = new SingleFact(v6, d3.GetValueByString("Редко"));
            Fact R4f5 = new SingleFact(v7, d1.GetValueByString("Нет"));
            Premise R4p = new Premise(FactOperator.Сonjunction);
            R4p.AddFact(R4f1);
            R4p.AddFact(R4f2);
            R4p.AddFact(R4f3);
            R4p.AddFact(R4f4);
            R4p.AddFact(R4f5);
            SingleFact R4c = new SingleFact(v33, d2.GetValueByString("Выполняется"));
            string R4ex = "Если пользователь не имеет рецепт у врача, его потребление мяса умеренное, потребление суточной нормы калорий отклоняется не более, чем на 12 %; потребляет жиры, растительные масла, сладости редко и не имеет недостаток микроэлементов в рационе, то его норма питательных элементов выполняется";
            Rule R4 = new Rule("R4", R4ex, R4p, R4c);

            /*IF: DOCREC = 2 AND(MMCONS = 1 OR MMCONS = 3)
            THEN: NUTRNORM = 2
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ НЕ ИМЕЕТ РЕЦЕПТ У ВРАЧА И ЕГО ПОТРЕБЛЕНИЕ МЯСА / МОЛОКА ЧАСТО / РЕДКО, ТО ЕГО НОРМА ПИТАТЕЛЬНЫХ ЭЛЕМЕНТОВ НЕ ВЫПОЛНЯЕТСЯ*/
            // 1
            // IF: MMCONS = 1 OR MMCONS = 3
            //THEN v6_1 = 1
            //REASON: Часть 6 правила
            Fact R5_1f1 = new SingleFact(v4, d3.GetValueByString("Часто"));
            Fact R5_1f2 = new SingleFact(v4, d3.GetValueByString("Редко"));
            Premise R5_1p = new Premise(FactOperator.Disjunction);
            R5_1p.AddFact(R5_1f1);
            R5_1p.AddFact(R5_1f2);
            SingleFact R5_1c = new SingleFact(v6_1, d1.GetValueByString("Да"));
            string R5_1ex = "Часть 5 правила";
            Rule R5_1 = new Rule("R5_1", R5_1ex, R5_1p, R5_1c);

            // 2  5
            Fact R5f1 = new SingleFact(v1, d1.GetValueByString("Нет"));
            Fact R5f2 = new SingleFact(v6_1, d1.GetValueByString("Да"));
            Premise R5p = new Premise(FactOperator.Сonjunction);
            R5p.AddFact(R5f1);
            R5p.AddFact(R5f2);
            SingleFact R5c = new SingleFact(v33, d2.GetValueByString("Не выполняется"));
            string R5ex = "Если пользователь не имеет рецепт у врача и его потребление мяса / молока часто / редко, то его норма питательных элементов не выполняется";
            Rule R5 = new Rule("R5", R5ex, R5p, R5c);

            /*IF: DOCREC = 2 AND DAYCAL = 2
            THEN: NUTRNORM = 2
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ НЕ ИМЕЕТ РЕЦЕПТ У ВРАЧА И ЕГО ПОТРЕБЛЕНИЕ СУТОЧНОЙ НОРМЫ КАЛОРИЙ ОТКЛОНЯЕТСЯ БОЛЕЕ, ЧЕМ НА 12 %, ТО ЕГО НОРМА ПИТАТЕЛЬНЫХ ЭЛЕМЕНТОВ НЕ ВЫПОЛНЯЕТСЯ*/
            Fact R6f1 = new SingleFact(v1, d1.GetValueByString("Нет"));
            Fact R6f2 = new SingleFact(v5, d4.GetValueByString("Отклоняется более, чем на 12%"));
            Premise R6p = new Premise(FactOperator.Сonjunction);
            R6p.AddFact(R6f1);
            R6p.AddFact(R6f2);
            SingleFact R6c = new SingleFact(v33, d2.GetValueByString("Не выполняется"));
            string R6ex = "Если пользователь не имеет рецепт у врача и его потребление суточной нормы калорий отклоняется более, чем на 12 %, то его норма питательных элементов не выполняется";
            Rule R6 = new Rule("R6", R6ex, R6p, R6c);

            /*IF: DOCREC = 2 AND(FVSCONS = 3 OR FVSCONS = 2)
            THEN: NUTRNORM = 2
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ НЕ ИМЕЕТ РЕЦЕПТ У ВРАЧА И ЕГО ПОТРЕБЛЕНИЕ ЖИРОВ, РАСТИТЕЛЬНЫХ МАСЕЛ, СЛАДОСТЕЙ УМЕРЕННО ИЛИ ЧАСТО, ТО ЕГО НОРМА ПИТАТЕЛЬНЫХ ЭЛЕМЕНТОВ НЕ ВЫПОЛНЯЕТСЯ*/
            // 1
            // IF: FVSCONS = 3 OR FVSCONS = 2
            //THEN v7_1 = 1
            //REASON: Часть 7 правила
            Fact R7_1f1 = new SingleFact(v6, d3.GetValueByString("Умеренно"));
            Fact R7_1f2 = new SingleFact(v6, d3.GetValueByString("Часто"));
            Premise R7_1p = new Premise(FactOperator.Disjunction);
            R7_1p.AddFact(R7_1f1);
            R7_1p.AddFact(R7_1f2);
            SingleFact R7_1c = new SingleFact(v7_1, d1.GetValueByString("Да"));
            string R7_1ex = "Часть 7 правила";
            Rule R7_1 = new Rule("R7_1", R7_1ex, R7_1p, R7_1c);

            //2
            Fact R7f1 = new SingleFact(v1, d1.GetValueByString("Нет"));
            Fact R7f2 = new SingleFact(v7_1, d1.GetValueByString("Да"));
            Premise R7p = new Premise(FactOperator.Сonjunction);
            R7p.AddFact(R7f1);
            R7p.AddFact(R7f2);
            SingleFact R7c = new SingleFact(v33, d2.GetValueByString("Не выполняется"));
            string R7ex = "Если пользователь не имеет рецепт у врача и его потребление жиров, растительных масел, сладостей умеренно или часто, то его норма питательных элементов не выполняется";
            Rule R7 = new Rule("R7", R7ex, R7p, R7c);

            /*IF: DOCREC = 2 AND TRLCK = 1
            THEN: NUTRNORM = 2
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ НЕ ИМЕЕТ РЕЦЕПТ У ВРАЧА, И ОН ИМЕЕТ НЕДОСТАТОК МИКРОЭЛЕМЕНТОВ В РАЦИОНЕ, ТО ЕГО НОРМА ПИТАТЕЛЬНЫХ ЭЛЕМЕНТОВ НЕ ВЫПОЛНЯЕТСЯ*/
            Fact R8f1 = new SingleFact(v1, d1.GetValueByString("Нет"));
            Fact R8f2 = new SingleFact(v7, d1.GetValueByString("Да"));
            Premise R8p = new Premise(FactOperator.Сonjunction);
            R8p.AddFact(R8f1);
            R8p.AddFact(R8f2);
            SingleFact R8c = new SingleFact(v33, d2.GetValueByString("Не выполняется"));
            string R8ex = "Если пользователь не имеет рецепт у врача и его потребление жиров, растительных масел, сладостей умеренно или часто, то его норма питательных элементов не выполняется";
            Rule R8 = new Rule("R8", R8ex, R8p, R8c);

            /*IF: DIET = 1 OR NUTRNORM = 1
            THEN: RHGNUT = 1
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ СОБЛЮДАЕТ ДИЕТУ ИЛИ ВЫПОЛНЯЕТ НОРМУ ПИТАТЕЛЬНЫХ ЭЛЕМЕНТОВ, ТО У НЕГО ПРАВИЛЬНОЕ ПИТАНИЕ*/
            Fact R9f1 = new SingleFact(v34, d1.GetValueByString("Да"));
            Fact R9f2 = new SingleFact(v33, d2.GetValueByString("Выполняется"));
            Premise R9p = new Premise(FactOperator.Disjunction);
            R9p.AddFact(R9f1);
            R9p.AddFact(R9f2);
            SingleFact R9c = new SingleFact(v35, d15.GetValueByString("1"));
            string R9ex = "Если пользователь соблюдает диету или выполняет норму питательных элементов, то у него правильное питание";
            Rule R9 = new Rule("R9", R9ex, R9p, R9c);

            /*IF: DIET = 2 AND NUTRNORM = 2
            THEN: RHGNUT = 2
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ НЕ СОБЛЮДАЕТ ДИЕТУ И НЕ ВЫПОЛНЯЕТ НОРМУ ПИТАТЕЛЬНЫХ ЭЛЕМЕНТОВ, ТО У НЕГО НЕПРАВИЛЬНОЕ ПИТАНИЕ*/
            Fact R10f1 = new SingleFact(v34, d1.GetValueByString("Нет"));
            Fact R10f2 = new SingleFact(v33, d2.GetValueByString("Не выполняется"));
            Premise R10p = new Premise(FactOperator.Disjunction);
            R10p.AddFact(R10f1);
            R10p.AddFact(R10f2);
            SingleFact R10c = new SingleFact(v35, d15.GetValueByString("2"));
            string R10ex = "Если пользователь не соблюдает диету и не выполняет норму питательных элементов, то у него неправильное питание";
            Rule R10 = new Rule("R10", R10ex, R10p, R10c);

            /*IF: HLTGR = 1 AND DAYACT = 1
            THEN: RHGPHYS = 1
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ ОСНОВНАЯ ГРУППА ЗДОРОВЬЯ И ЕГО ЕЖЕДНЕВНАЯ ДЕЯТЕЛЬНОСТЬ СВЯЗАНА СО СПОРТОМ, ТО ЕГО ПРАВИЛЬНАЯ ФИЗИЧЕСКАЯ АКТИВНОСТЬ*/
            Fact R11f1 = new SingleFact(v8, d5.GetValueByString("Основная"));
            Fact R11f2 = new SingleFact(v9, d6.GetValueByString("Напрямую связана со спортом"));
            Premise R11p = new Premise(FactOperator.Сonjunction);
            R11p.AddFact(R11f1);
            R11p.AddFact(R11f2);
            SingleFact R11c = new SingleFact(v37, d15.GetValueByString("1"));
            string R11ex = "Если у пользователя основная группа здоровья и его ежедневная деятельность связана со спортом, то его правильная физическая активность";
            Rule R11 = new Rule("R11", R11ex, R11p, R11c);

            /*IF: (HLTGR = 1 AND DAYACT = 2 AND LFSTL = 2) AND(RGLSP = 1 OR RGLSP = 2 OR RGLSP = 3 OR RGLSP = 4 OR RGLSP = 5)
            THEN: DYLLD = 1
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ ОСНОВНАЯ ГРУППА ЗДОРОВЬЯ, ЕГО ЕЖЕДНЕВНАЯ ДЕЯТЕЛЬНОСТЬ НЕ СВЯЗАНА СО СПОРТОМ, ОН ВЕДЕТ СИДЯЧИЙ ОБРАЗ ЖИЗНИ И ИЗ СПОРТИВНЫХ МЕРОПРИЯТИЙ ЗАНИМАЕТСЯ В СПОРТИВНОМ КЛУБЕ/ АКТИВНЫХ ОТДЫХОМ / СПОРТИВНЫМИ ИГРАМИ / ГИМНАСТИКОЙ / ЙОГОЙ, ТО У НЕГО ДОСТАТОЧНО НАГРУЗКИ В ТЕЧЕНИЕ ДНЯ*/
            // 1
            // IF: RGLSP = 1 OR RGLSP = 2 OR RGLSP = 3 OR RGLSP = 4 OR RGLSP = 5
            //THEN v12_1 = 1
            //REASON: Часть 12 правила
            Fact R12_1f1 = new SingleFact(v11, d8.GetValueByString("Спортивный клуб"));
            Fact R12_1f2 = new SingleFact(v11, d8.GetValueByString("Активных отдых"));
            Fact R12_1f3 = new SingleFact(v11, d8.GetValueByString("Спортивные игры"));
            Fact R12_1f4 = new SingleFact(v11, d8.GetValueByString("Гимнастика"));
            Fact R12_1f5 = new SingleFact(v11, d8.GetValueByString("Йога"));
            Premise R12_1p = new Premise(FactOperator.Disjunction);
            R12_1p.AddFact(R12_1f1);
            R12_1p.AddFact(R12_1f2);
            R12_1p.AddFact(R12_1f3);
            R12_1p.AddFact(R12_1f4);
            R12_1p.AddFact(R12_1f5);
            SingleFact R12_1c = new SingleFact(v12_1, d1.GetValueByString("Да"));
            string R12_1ex = "Часть 12 правила";
            Rule R12_1 = new Rule("R12_1", R12_1ex, R12_1p, R12_1c);

            //2
            Fact R12f1 = new SingleFact(v8, d5.GetValueByString("Основная"));
            Fact R12f2 = new SingleFact(v9, d6.GetValueByString("Не связана со спортом"));
            Fact R12f3 = new SingleFact(v10, d7.GetValueByString("Сидячий"));
            Fact R12f4 = new SingleFact(v12_1, d1.GetValueByString("Да"));
            Premise R12p = new Premise(FactOperator.Сonjunction);
            R12p.AddFact(R12f1);
            R12p.AddFact(R12f2);
            R12p.AddFact(R12f3);
            R12p.AddFact(R12f4);
            SingleFact R12c = new SingleFact(v36, d1.GetValueByString("Да"));
            string R12ex = "Если у пользователя основная группа здоровья, его ежедневная деятельность не связана со спортом, он ведет сидячий образ жизни и из спортивных мероприятий занимается в спортивном клубе/ активных отдыхом / спортивными играми / гимнастикой / йогой, то у него достаточно нагрузки в течение дня";
            Rule R12 = new Rule("R12", R12ex, R12p, R12c);

            /*IF: HLTGR = 2 AND LFSTL = 2 AND(RGLSP = 1 OR RGLSP = 2 OR RGLSP = 3 OR RGLSP = 4 OR RGLSP = 5)
            THEN: LIMLD = 1
            REASON: ЕСЛИ У ЧЕЛОВЕКА ПОДГОТОВИТЕЛЬНАЯ ГРУППА ЗДОРОВЬЯ, ЕГО ОБРАЗ ЖИЗНИ СИДЯЧИЙ И ИЗ СПОРТИВНЫХ МЕРОПРИЯТИЙ ЗАНИМАЕТСЯ В СПОРТИВНОМ КЛУБЕ / АКТИВНЫХ ОТДЫХОМ / СПОРТИВНЫМИ ИГРАМИ / ГИМНАСТИКОЙ / ЙОГОЙ, ТО У НЕГО НАГРУЗКА В СООТВЕТСТВИИ С ОГРАНИЧЕНИЯМИ ГРУППЫ ЗДОРОВЬЯ*/
            // 1
            // IF: RGLSP = 1 OR RGLSP = 2 OR RGLSP = 3 OR RGLSP = 4 OR RGLSP = 5
            // THEN: v56_1 = 1
            Fact R12_fx_1f1 = new SingleFact(v11, d8.GetValueByString("Спортивный клуб"));
            Fact R12_fx_1f2 = new SingleFact(v11, d8.GetValueByString("Активных отдых"));
            Fact R12_fx_1f3 = new SingleFact(v11, d8.GetValueByString("Спортивные игры"));
            Fact R12_fx_1f4 = new SingleFact(v11, d8.GetValueByString("Гимнастика"));
            Fact R12_fx_1f5 = new SingleFact(v11, d8.GetValueByString("Йога"));
            Premise R12_fx_1p = new Premise(FactOperator.Disjunction);
            R12_fx_1p.AddFact(R12_fx_1f1);
            R12_fx_1p.AddFact(R12_fx_1f2);
            R12_fx_1p.AddFact(R12_fx_1f3);
            R12_fx_1p.AddFact(R12_fx_1f4);
            R12_fx_1p.AddFact(R12_fx_1f5);
            SingleFact R12_fx_1c = new SingleFact(v12_fx_1, d1.GetValueByString("Да"));
            string R12_fx_1ex = "Часть 12_fx правила";
            Rule R12_fx_1 = new Rule("R12_fx_1", R12_fx_1ex, R12_fx_1p, R12_fx_1c);

            //2
            Fact R12_fxf1 = new SingleFact(v8, d5.GetValueByString("Подготовительная"));
            Fact R12_fxf2 = new SingleFact(v10, d7.GetValueByString("Сидячий"));
            Fact R12_fxf3 = new SingleFact(v12_fx_1, d1.GetValueByString("Да"));
            Premise R12_fxp = new Premise(FactOperator.Сonjunction);
            R12_fxp.AddFact(R12_fxf1);
            R12_fxp.AddFact(R12_fxf2);
            R12_fxp.AddFact(R12_fxf3);
            SingleFact R12_fxc = new SingleFact(v38, d1.GetValueByString("Да"));
            string R12_fxex = "Если у человека подготовительная группа здоровья, его образ жизни сидячий и из спортивных мероприятий занимается в спортивном клубе / активных отдыхом / спортивными играми / гимнастикой / йогой, то у него нагрузка в соответствии с ограничениями группы здоровья";
            Rule R12_fx = new Rule("12_fx", R12_fxex, R12_fxp, R12_fxc);

            /*IF: HLTGR = 1 AND DAYACT = 2 AND LFSTL = 2 AND RGLSP = 6
            THEN: DYLLD = 2
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ ОСНОВНАЯ ГРУППА ЗДОРОВЬЯ, ЕГО ЕЖЕДНЕВНАЯ ДЕЯТЕЛЬНОСТЬ НЕ СВЯЗАНА СО СПОРТОМ, ОН ВЕДЕТ СИДЯЧИЙ ОБРАЗ ЖИЗНИ И ИЗ ОН НИЧЕМ НЕ ЗАНИМАЕТСЯ ИЗ ПЕРЕЧИСЛЕННЫХ СПОРТИВНЫХ МЕРОПРИЯТИЙ, ТО У НЕГО НЕДОСТАТОЧНО НАГРУЗКИ В ТЕЧЕНИЕ ДНЯ*/
            Fact R13f1 = new SingleFact(v8, d5.GetValueByString("Основная"));
            Fact R13f2 = new SingleFact(v9, d6.GetValueByString("Не связана со спортом"));
            Fact R13f3 = new SingleFact(v10, d7.GetValueByString("Сидячий"));
            Fact R13f4 = new SingleFact(v11, d8.GetValueByString("Ничего из перечисленного"));
            Premise R13p = new Premise(FactOperator.Сonjunction);
            R13p.AddFact(R13f1);
            R13p.AddFact(R13f2);
            R13p.AddFact(R13f3);
            R13p.AddFact(R13f4);
            SingleFact R13c = new SingleFact(v36, d1.GetValueByString("Нет"));
            string R13ex = "Если у пользователя основная группа здоровья, его ежедневная деятельность не связана со спортом, он ведет сидячий образ жизни и из он ничем не занимается из перечисленных спортивных мероприятий, то у него недостаточно нагрузки в течение дня";
            Rule R13 = new Rule("R13", R13ex, R13p, R13c);

            /*IF: HLTGR = 1 AND DAYACT = 2 AND LFSTL = 1 AND DYLGYM = 1
            THEN: DYLLD = 1
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ ОСНОВНАЯ ГРУППА ЗДОРОВЬЯ, ЕГО ЕЖЕДНЕВНАЯ ДЕЯТЕЛЬНОСТЬ НЕ СВЯЗАНА СО СПОРТОМ, ОН ВЕДЕТ ПОДВИЖНЫЙ ОБРАЗ ЖИЗНИ, И ОН ВЫПОЛНЯЕТ РАЗМИНКУ В ТЕЧЕНИЕ ДНЯ, ТО У НЕГО ДОСТАТОЧНО НАГРУЗКИ В ТЕЧЕНИЕ ДНЯ*/
            Fact R14f1 = new SingleFact(v8, d5.GetValueByString("Основная"));
            Fact R14f2 = new SingleFact(v9, d6.GetValueByString("Не связана со спортом"));
            Fact R14f3 = new SingleFact(v10, d7.GetValueByString("Подвижный"));
            Fact R14f4 = new SingleFact(v12, d1.GetValueByString("Да"));
            Premise R14p = new Premise(FactOperator.Сonjunction);
            R14p.AddFact(R14f1);
            R14p.AddFact(R14f2);
            R14p.AddFact(R14f3);
            R14p.AddFact(R14f4);
            SingleFact R14c = new SingleFact(v36, d1.GetValueByString("Да"));
            string R14ex = "Если у пользователя основная группа здоровья, его ежедневная деятельность не связана со спортом, он ведет подвижный образ жизни, и он выполняет разминку в течение дня, то у него достаточно нагрузки в течение дня";
            Rule R14 = new Rule("R14", R14ex, R14p, R14c);

            /*IF: HLTGR = 1 AND DAYACT = 2 AND LFSTL = 1 AND DYLGYM = 2
            THEN: DYLLD = 2
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ ОСНОВНАЯ ГРУППА ЗДОРОВЬЯ, ЕГО ЕЖЕДНЕВНАЯ ДЕЯТЕЛЬНОСТЬ НЕ СВЯЗАНА СО СПОРТОМ, ОН ВЕДЕТ ПОДВИЖНЫЙ ОБРАЗ ЖИЗНИ, И ОН НЕ ВЫПОЛНЯЕТ РАЗМИНКУ В ТЕЧЕНИЕ ДНЯ, ТО У НЕГО НЕДОСТАТОЧНО НАГРУЗКИ В ТЕЧЕНИЕ ДНЯ*/
            Fact R15f1 = new SingleFact(v8, d5.GetValueByString("Основная"));
            Fact R15f2 = new SingleFact(v9, d6.GetValueByString("Не связана со спортом"));
            Fact R15f3 = new SingleFact(v10, d7.GetValueByString("Подвижный"));
            Fact R15f4 = new SingleFact(v12, d1.GetValueByString("Нет"));
            Premise R15p = new Premise(FactOperator.Сonjunction);
            R15p.AddFact(R15f1);
            R15p.AddFact(R15f2);
            R15p.AddFact(R15f3);
            R15p.AddFact(R15f4);
            SingleFact R15c = new SingleFact(v36, d1.GetValueByString("Нет"));
            string R15ex = "Если у пользователя основная группа здоровья, его ежедневная деятельность не связана со спортом, он ведет подвижный образ жизни, и он не выполняет разминку в течение дня, то у него недостаточно нагрузки в течение дня";
            Rule R15 = new Rule("R15", R15ex, R15p, R15c);

            /*IF: HLTGR = 3 AND DOCEX = 1 AND HLTRSTR = 1
            THEN: LIMLD = 1
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ СПЕЦИАЛЬНАЯ ГРУППА ЗДОРОВЬЯ, И ОН ВЫПОЛНЯЕТ УПРАЖНЕНИЯ, ПРЕДПИСАННЫЕ ВРАЧОМ, СОБЛЮДАЕТ ОГРАНИЧЕНИЯ ГРУППЫ ЗДОРОВЬЯ, ТО У НЕГО НАГРУЗКА В СООТВЕТСТВИИ С ОГРАНИЧЕНИЯМИ ГРУППЫ ЗДОРОВЬЯ*/
            Fact R16f1 = new SingleFact(v8, d5.GetValueByString("Специальная"));
            Fact R16f2 = new SingleFact(v13, d1.GetValueByString("Да"));
            Fact R16f3 = new SingleFact(v14, d9.GetValueByString("Редко"));
            Premise R16p = new Premise(FactOperator.Сonjunction);
            R16p.AddFact(R16f1);
            R16p.AddFact(R16f2);
            R16p.AddFact(R16f3);
            SingleFact R16c = new SingleFact(v38, d1.GetValueByString("Да"));
            string R16ex = "Если у пользователя специальная группа здоровья, и он выполняет упражнения, предписанные врачом, соблюдает ограничения группы здоровья, то у него нагрузка в соответствии с ограничениями группы здоровья";
            Rule R16 = new Rule("R16", R16ex, R16p, R16c);

            /*IF: HLTGR = 3 AND DOCEX = 2
            THEN: LIMLD = 2
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ СПЕЦИАЛЬНАЯ ГРУППА ЗДОРОВЬЯ И ОН НЕ ВЫПОЛНЯЕТ УПРАЖНЕНИЯ, ПРЕДПИСАННЫЕ ВРАЧОМ, ТО У НЕГО НАГРУЗКА НЕ В СООТВЕТСТВИИ С ОГРАНИЧЕНИЯМИ ГРУППЫ ЗДОРОВЬЯ*/
            Fact R17f1 = new SingleFact(v8, d5.GetValueByString("Специальная"));
            Fact R17f2 = new SingleFact(v13, d1.GetValueByString("Нет"));
            Premise R17p = new Premise(FactOperator.Сonjunction);
            R17p.AddFact(R17f1);
            R17p.AddFact(R17f2);
            SingleFact R17c = new SingleFact(v38, d1.GetValueByString("Нет"));
            string R17ex = "Если у пользователя специальная группа здоровья и он не выполняет упражнения, предписанные врачом, то у него нагрузка не в соответствии с ограничениями группы здоровья";
            Rule R17 = new Rule("R17", R17ex, R17p, R17c);

            /*IF: HLTGR = 3 AND DOCEX = 1 AND HLTRSTR = 2
            THEN: LIMLD = 2
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ СПЕЦИАЛЬНАЯ ГРУППА ЗДОРОВЬЯ, И ОН ВЫПОЛНЯЕТ УПРАЖНЕНИЯ, ПРЕДПИСАННЫЕ ВРАЧОМ, НО НЕСОБЛЮДАЕТ ОГРАНИЧЕНИЯ ГРУППЫ ЗДОРОВЬЯ, ТО У НЕГО НАГРУЗКА НЕ В СООТВЕТСТВИИ С ОГРАНИЧЕНИЯМИ ГРУППЫ ЗДОРОВЬЯ*/
            Fact R18f1 = new SingleFact(v8, d5.GetValueByString("Специальная"));
            Fact R18f2 = new SingleFact(v13, d1.GetValueByString("Да"));
            Fact R18f3 = new SingleFact(v14, d9.GetValueByString("Постоянно"));
            Premise R18p = new Premise(FactOperator.Сonjunction);
            R18p.AddFact(R18f1);
            R18p.AddFact(R18f2);
            R18p.AddFact(R18f3);
            SingleFact R18c = new SingleFact(v38, d1.GetValueByString("Нет"));
            string R18ex = "Если у пользователя специальная группа здоровья, и он выполняет упражнения, предписанные врачом, но несоблюдает ограничения группы здоровья, то у него нагрузка не в соответствии с ограничениями группы здоровья";
            Rule R18 = new Rule("R18", R18ex, R18p, R18c);

            /*IF: HLTGR = 2 AND LFSTL = 2 AND RGLSP = 6
            THEN: LIMLD = 2
            REASON: ЕСЛИ У ЧЕЛОВЕКА ПОДГОТОВИТЕЛЬНАЯ ГРУППА ЗДОРОВЬЯ, ЕГО ОБРАЗ ЖИЗНИ СИДЯЧИЙ И ОН НЕ ЗАНИМАЕТСЯ НИЧЕМ ИЗ СПИСКА СПОРТИВНЫХ МЕРОПРИЯТИЙ, ТО У НЕГО НАГРУЗКА НЕ В СООТВЕТСТВИИ С ОГРАНИЧЕНИЯМИ ГРУППЫ ЗДОРОВЬЯ*/
            Fact R19f1 = new SingleFact(v8, d5.GetValueByString("Подготовительная"));
            Fact R19f2 = new SingleFact(v10, d7.GetValueByString("Сидячий"));
            Fact R19f3 = new SingleFact(v11, d8.GetValueByString("Ничего из перечисленного"));
            Premise R19p = new Premise(FactOperator.Сonjunction);
            R19p.AddFact(R19f1);
            R19p.AddFact(R19f2);
            R19p.AddFact(R19f3);
            SingleFact R19c = new SingleFact(v38, d1.GetValueByString("Нет"));
            string R19ex = "Если у человека подготовительная группа здоровья, его образ жизни сидячий и он не занимается ничем из списка спортивных мероприятий, то у него нагрузка не в соответствии с ограничениями группы здоровья";
            Rule R19 = new Rule("R19", R19ex, R19p, R19c);

            /*IF: HLTGR = 2 AND LFSTL = 1 AND DYLGYM = 1 AND HLTRSTR = 1
            THEN: LIMLD = 1
            REASON: ЕСЛИ У ЧЕЛОВЕКА ПОДГОТОВИТЕЛЬНАЯ ГРУППА ЗДОРОВЬЯ, ЕГО ОБРАЗ ЖИЗНИ ПОДВИЖНЫЙ, ОН ВЫПОЛНЯЕТ УПРАЖНЕНИЯ / РАЗМИНКУ В ТЕЧЕНИЕ ДНЯ С СОБЛЮДЕНИЕМ ОГРАНИЧЕНИЙ ГРУППЫ ЗДОРОВЬЯ, ТО У НЕГО НАГРУЗКА В СООТВЕТСТВИИ С ОГРАНИЧЕНИЯМИ ГРУППЫ*/
            Fact R20f1 = new SingleFact(v8, d5.GetValueByString("Подготовительная"));
            Fact R20f2 = new SingleFact(v10, d7.GetValueByString("Подвижный"));
            Fact R20f3 = new SingleFact(v12, d1.GetValueByString("Да"));
            Fact R20f4 = new SingleFact(v14, d9.GetValueByString("Редко"));
            Premise R20p = new Premise(FactOperator.Сonjunction);
            R20p.AddFact(R20f1);
            R20p.AddFact(R20f2);
            R20p.AddFact(R20f3);
            R20p.AddFact(R20f4);
            SingleFact R20c = new SingleFact(v38, d1.GetValueByString("Да"));
            string R20ex = "Если у человека подготовительная группа здоровья, его образ жизни подвижный, он выполняет упражнения / разминку в течение дня с соблюдением ограничений группы здоровья, то у него нагрузка в соответствии с ограничениями группы";
            Rule R20 = new Rule("R20", R20ex, R20p, R20c);

            /*IF: HLTGR = 2 AND LFSTL = 1 AND DYLGYM = 1 AND HLTRSTR = 2
            THEN: LIMLD = 2
            REASON: ЕСЛИ У ЧЕЛОВЕКА ПОДГОТОВИТЕЛЬНАЯ ГРУППА ЗДОРОВЬЯ, ЕГО ОБРАЗ ЖИЗНИ ПОДВИЖНЫЙ, ОН ВЫПОЛНЯЕТ УПРАЖНЕНИЯ / РАЗМИНКУ В ТЕЧЕНИЕ ДНЯ С БЕЗ СОБЛЮДЕНИЯ ОГРАНИЧЕНИЙ ГРУППЫ ЗДОРОВЬЯ, ТО У НЕГО НАГРУЗКА НЕ В СООТВЕТСТВИИ С ОГРАНИЧЕНИЯМИ ГРУППЫ*/
            Fact R21f1 = new SingleFact(v8, d5.GetValueByString("Подготовительная"));
            Fact R21f2 = new SingleFact(v10, d7.GetValueByString("Подвижный"));
            Fact R21f3 = new SingleFact(v12, d1.GetValueByString("Да"));
            Fact R21f4 = new SingleFact(v14, d9.GetValueByString("Постоянно"));
            Premise R21p = new Premise(FactOperator.Сonjunction);
            R21p.AddFact(R21f1);
            R21p.AddFact(R21f2);
            R21p.AddFact(R21f3);
            R21p.AddFact(R21f4);
            SingleFact R21c = new SingleFact(v38, d1.GetValueByString("Нет"));
            string R21ex = "Если у человека подготовительная группа здоровья, его образ жизни подвижный, он выполняет упражнения / разминку в течение дня с без соблюдения ограничений группы здоровья, то у него нагрузка не в соответствии с ограничениями группы";
            Rule R21 = new Rule("R21", R21ex, R21p, R21c);

            /*IF: HLTGR = 2 AND LFSTL = 1 AND DYLGYM = 2
            THEN: LIMLD = 2
            REASON: ЕСЛИ У ЧЕЛОВЕКА ПОДГОТОВИТЕЛЬНАЯ ГРУППА ЗДОРОВЬЯ, ЕГО ОБРАЗ ЖИЗНИ ПОДВИЖНЫЙ, ОН НЕ ВЫПОЛНЯЕТ УПРАЖНЕНИЯ/ РАЗМИНКУ В ТЕЧЕНИЕ ДНЯ, ТО У НЕГО НАГРУЗКА НЕ В СООТВЕТСТВИИ С ОГРАНИЧЕНИЯМИ ГРУППЫ*/
            Fact R22f1 = new SingleFact(v8, d5.GetValueByString("Подготовительная"));
            Fact R22f2 = new SingleFact(v10, d7.GetValueByString("Подвижный"));
            Fact R22f3 = new SingleFact(v12, d1.GetValueByString("Нет"));
            Premise R22p = new Premise(FactOperator.Сonjunction);
            R22p.AddFact(R22f1);
            R22p.AddFact(R22f2);
            R22p.AddFact(R22f3);
            SingleFact R22c = new SingleFact(v38, d1.GetValueByString("Нет"));
            string R22ex = "Если у человека подготовительная группа здоровья, его образ жизни подвижный, он не выполняет упражнения/ разминку в течение дня, то у него нагрузка не в соответствии с ограничениями группы";
            Rule R22 = new Rule("R22", R22ex, R22p, R22c);

            /*IF: DYLLD = 1 OR LIMLD = 1
            THEN: RHGPHYS = 1
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ ДОСТАТОЧНО НАГРУЗКИ В ТЕЧЕНИЕ ДНЯ ИЛИ НАГРУЗКА В СООТВЕТСТВИИ С ОГРАНИЧЕНИЯМИ ГРУППЫ ЗДОРОВЬЯ, ТО У НЕГО ПРАВИЛЬНАЯ ФИЗИЧЕСКАЯ АКТИВНОСТЬ*/
            Fact R23f1 = new SingleFact(v36, d1.GetValueByString("Да"));
            Fact R23f2 = new SingleFact(v38, d1.GetValueByString("Да"));
            Premise R23p = new Premise(FactOperator.Disjunction);
            R23p.AddFact(R23f1);
            R23p.AddFact(R23f2);
            SingleFact R23c = new SingleFact(v37, d15.GetValueByString("1"));
            string R23ex = "Если у пользователя достаточно нагрузки в течение дня или нагрузка в соответствии с ограничениями группы здоровья, то у него правильная физическая активность";
            Rule R23 = new Rule("R23", R23ex, R23p, R23c);

            /*IF: DYLLD = 2 AND LIMLD = 2
            THEN: RHGPHYS = 2
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ НЕДОСТАТОЧНО НАГРУЗКИ В ТЕЧЕНИЕ ДНЯ И НАГРУЗКА НЕ В СООТВЕТСТВИИ С ОГРАНИЧЕНИЯМИ ФИЗИЧЕСКОЙ ГРУППЫ, ТО У НЕГО НЕПРАВИЛЬНАЯ ФИЗИЧЕСКАЯ АКТИВНОСТЬ*/
            Fact R24f1 = new SingleFact(v36, d1.GetValueByString("Нет"));
            Fact R24f2 = new SingleFact(v38, d1.GetValueByString("Нет"));
            Premise R24p = new Premise(FactOperator.Disjunction);
            R24p.AddFact(R24f1);
            R24p.AddFact(R24f2);
            SingleFact R24c = new SingleFact(v37, d15.GetValueByString("2"));
            string R24ex = "Если у пользователя недостаточно нагрузки в течение дня и нагрузка не в соответствии с ограничениями физической группы, то у него неправильная физическая активность";
            Rule R24 = new Rule("R24", R24ex, R24p, R24c);

            /*IF: PSYCONS = 1
            THEN: LFSTLQL = "ОЧЕНЬ НИЗКИЙ"
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ ПОТРЕБЛЯЕТ НАРКОТИЧЕСКИЕ ИЛИ ПСИХОТРОПНЫЕ ВЕЩЕСТВА, ТО У НЕГО САМЫЙ НИЗКИЙ УРОВЕНЬ КАЧЕСТВА ОБРАЗА ЖИЗНИ*/
            Fact R25f1 = new SingleFact(v15, d1.GetValueByString("Да"));
            Premise R25p = new Premise(FactOperator.Disjunction);
            R25p.AddFact(R25f1);
            SingleFact R25c = new SingleFact(v50, d14.GetValueByString("Очень низкий"));
            string R25ex = "Если пользователь потребляет наркотические или психотропные вещества, то у него самый низкий уровень качества образа жизни";
            Rule R25 = new Rule("R25", R25ex, R25p, R25c);

            /*IF: PSYCONS = 2 AND(ALCCON = 1 OR ALCCON = 2)
            THEN: RGHHAB = 1
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ НЕ ПОТРЕБЛЯЕТ НАРКОТИЧЕСКИЕ ИЛИ ПСИХОТРОПНЫЕ ВЕЩЕСТВА И ПОТРЕБЛЯЕТ АЛКОГОЛЬ ВООБЩЕ ИЛИ ТОЛЬКО ПО ПРАЗДНИКАМ, ТО У НЕГО НЕТ ВРЕДНЫХ ПРИВЫЧЕК*/
            // 1
            // IF: ALCCON = 1 OR ALCCON = 2
            // THEN: v26_1 = 1
            Fact R26_1f1 = new SingleFact(v16, d10.GetValueByString("Не потребляю вообще"));
            Fact R26_1f2 = new SingleFact(v16, d10.GetValueByString("По праздникам"));
            Premise R26_1p = new Premise(FactOperator.Disjunction);
            R26_1p.AddFact(R26_1f1);
            R26_1p.AddFact(R26_1f2);
            SingleFact R26_1c = new SingleFact(v26_1, d1.GetValueByString("Да"));
            string R26_1ex = "Часть 26 правила";
            Rule R26_1 = new Rule("R26_1", R26_1ex, R26_1p, R26_1c);

            //2
            Fact R26f1 = new SingleFact(v15, d1.GetValueByString("Нет"));
            Fact R26f2 = new SingleFact(v26_1, d1.GetValueByString("Да"));
            Premise R26p = new Premise(FactOperator.Сonjunction);
            R26p.AddFact(R26f1);
            R26p.AddFact(R26f2);
            SingleFact R26c = new SingleFact(v39, d15.GetValueByString("1"));
            string R26ex = "Если пользователь не потребляет наркотические или психотропные вещества и потребляет алкоголь вообще или только по праздникам, то у него нет вредных привычек";
            Rule R26 = new Rule("R26", R26ex, R26p, R26c);

            /*IF: ALCCON = 3 OR PSYCONS = 1
            THEN: RGHHAB = 2
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ ПОТРЕБЛЯЕТ АЛКОГОЛЬ ЧАЩЕ ЧЕМ, РАЗ В 2 НЕДЕЛИ, ТО У НЕГО ЕСТЬ ВРЕДНЫЕ ПРИВЫЧКИ*/
            Fact R27f1 = new SingleFact(v15, d1.GetValueByString("Да"));
            Fact R27f2 = new SingleFact(v16, d10.GetValueByString("Чаще раза в 2 недели"));
            Premise R27p = new Premise(FactOperator.Disjunction);
            R27p.AddFact(R27f1);
            R27p.AddFact(R27f2);
            SingleFact R27c = new SingleFact(v39, d15.GetValueByString("2"));
            string R27ex = "Если пользователь потребляет алкоголь чаще чем, раз в 2 недели, или употрябляет наркотические вещества, то у него есть вредные привычки";
            Rule R27 = new Rule("R27", R27ex, R27p, R27c);

            /*IF: DRKRM = 2 OR SLPOSE = 2
           THEN: SLPCOND = 2
           REASON: ЕСЛИ ЧЕЛОВЕК НЕ СПИТ В ТЕМНОМ ПОМЕЩЕНИИ ИЛИ НЕ СОБЛЮДАЕТ ПОЗУ ДЛЯ СНА, ТО НЕ СОБЛЮДАЕТ УСЛОВИЯ ПРАВИЛЬНОГО СНА*/
            Fact R28f1 = new SingleFact(v17, d1.GetValueByString("Нет"));
            Fact R28f2 = new SingleFact(v18, d1.GetValueByString("Нет"));
            Premise R28p = new Premise(FactOperator.Disjunction);
            R28p.AddFact(R28f1);
            R28p.AddFact(R28f2);
            SingleFact R28c = new SingleFact(v43, d1.GetValueByString("Нет"));
            string R28ex = "Если человек не спит в темном помещении или не соблюдает позу для сна, то не соблюдает условия правильного сна";
            Rule R28 = new Rule("R28", R28ex, R28p, R28c);

            /*IF: DRKRM = 1 AND SLPOSE = 1
            THEN: SLPCOND = 1
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ СПИТ В ТЕМНОМ ПОМЕЩЕНИИ И СОБЛЮДАЕТ ПОЗУ ДЛЯ СНА, ЧТО ОН СОБЛЮДАЕТ УСЛОВИЯ ПРАВИЛЬНОГО СНА*/
            Fact R29f1 = new SingleFact(v17, d1.GetValueByString("Да"));
            Fact R29f2 = new SingleFact(v18, d1.GetValueByString("Да"));
            Premise R29p = new Premise(FactOperator.Сonjunction);
            R29p.AddFact(R29f1);
            R29p.AddFact(R29f2);
            SingleFact R29c = new SingleFact(v43, d1.GetValueByString("Да"));
            string R29ex = "Если пользователь спит в темном помещении и соблюдает позу для сна, что он соблюдает условия правильного сна";
            Rule R29 = new Rule("R29", R29ex, R29p, R29c);

            /*IF: SLPTM = 2 OR SLPCOND = 2
            THEN: HLTSL = 2
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ СПИТ МЕНЕЕ 7 ЧАСОВ ИЛИ НЕ СОБЛЮДАЕТ УСЛОВИЯ ЗДОРОВОГО СНА, ТО У НЕГО НЕЗДОРОВЫЙ СОН*/
            Fact R30f1 = new SingleFact(v19, d11.GetValueByString("Менее 7"));
            Fact R30f2 = new SingleFact(v43, d1.GetValueByString("Нет"));
            Premise R30p = new Premise(FactOperator.Disjunction);
            R30p.AddFact(R30f1);
            R30p.AddFact(R30f2);
            SingleFact R30c = new SingleFact(v41, d1.GetValueByString("Нет"));
            string R30ex = "Если пользователь спит менее 7 часов или не соблюдает условия здорового сна, то у него нездоровый сон";
            Rule R30 = new Rule("R30", R30ex, R30p, R30c);

            /*IF: SLPTM = 1 AND SLPCOND = 1
            THEN: HLTSL = 1
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ СПИТ НЕ МЕНЕЕ 7 ЧАСОВ И СОБЛЮДАЕТ УСЛОВИЯ ЗДОРОВОГО СНА, ТО У НЕГО ЗДОРОВЫЙ СОН*/
            Fact R31f1 = new SingleFact(v19, d11.GetValueByString("Более 7"));
            Fact R31f2 = new SingleFact(v43, d1.GetValueByString("Да"));
            Premise R31p = new Premise(FactOperator.Сonjunction);
            R31p.AddFact(R31f1);
            R31p.AddFact(R31f2);
            SingleFact R31c = new SingleFact(v41, d1.GetValueByString("Да"));
            string R31ex = "Если пользователь спит не менее 7 часов и соблюдает условия здорового сна, то у него здоровый сон";
            Rule R31 = new Rule("R31", R31ex, R31p, R31c);

            /*IF: BIOOPT = 2 OR SLSYNC = 2
            THEN: BIOVIO = 1
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ НЕ СОБЛЮДАЕТ БИОРИТМОЛОГИЧЕСКИЙ ОПТИМУМ ИЛИ СИНХРОНИЗАЦИЮ ЧАСОВ СНА, ТО У НЕГО ЕСТЬ НАРУШЕНИЯ БИОРИМТОВ*/
            Fact R32f1 = new SingleFact(v20, d1.GetValueByString("Нет"));
            Fact R32f2 = new SingleFact(v21, d1.GetValueByString("Нет"));
            Premise R32p = new Premise(FactOperator.Disjunction);
            R32p.AddFact(R32f1);
            R32p.AddFact(R32f2);
            SingleFact R32c = new SingleFact(v42, d1.GetValueByString("Да"));
            string R32ex = "Если пользователь не соблюдает биоритмологический оптимум или синхронизацию часов сна, то у него есть нарушения биоримтов";
            Rule R32 = new Rule("R32", R32ex, R32p, R32c);

            /*IF: BIOOPT = 1 AND SLSYNC = 1
            THEN: BIOVIO = 2
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ СОБЛЮДАЕТ БИОРИТМОЛОГИЧЕСКИЙ ОПТИМУМ И СИНХРОНИЗАЦИЮ ЧАСОВ СНА, ТО У НЕГО НЕТ НАРУШЕНИЯ БИОРИМТОВ*/
            Fact R33f1 = new SingleFact(v20, d1.GetValueByString("Да"));
            Fact R33f2 = new SingleFact(v21, d1.GetValueByString("Да"));
            Premise R33p = new Premise(FactOperator.Сonjunction);
            R33p.AddFact(R33f1);
            R33p.AddFact(R33f2);
            SingleFact R33c = new SingleFact(v42, d1.GetValueByString("Нет"));
            string R33ex = "Если пользователь соблюдает биоритмологический оптимум и синхронизацию часов сна, то у него нет нарушения биоримтов";
            Rule R33 = new Rule("R33", R33ex, R33p, R33c);

            /*IF: HLTSL = 2 OR BIOVIO = 1
            THEN: RGHRST = 2
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ НЕЗДОРОВЫЙ СОН ИЛИ ЕСТЬ НАРУШЕНИЯ БИОРИМТОВ, ТО У НЕГО НЕПРАВИЛЬНЫЙ ОТДЫХ*/
            Fact R34f1 = new SingleFact(v41, d1.GetValueByString("Нет"));
            Fact R34f2 = new SingleFact(v42, d1.GetValueByString("Да"));
            Premise R34p = new Premise(FactOperator.Disjunction);
            R34p.AddFact(R34f1);
            R34p.AddFact(R34f2);
            SingleFact R34c = new SingleFact(v40, d15.GetValueByString("2"));
            string R34ex = "Если у пользователя нездоровый сон или есть нарушения биоримтов, то у него неправильный отдых";
            Rule R34 = new Rule("R34", R34ex, R34p, R34c);

            /*IF: HLTSL = 1 AND BIOVIO = 2
            THEN: RGHRST = 1
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ ЗДОРОВЫЙ СОН И НЕТ НАРУШЕНИЯ БИОРИМТОВ, ТО У НЕГО ПРАВИЛЬНЫЙ ОТДЫХ*/
            Fact R35f1 = new SingleFact(v41, d1.GetValueByString("Да"));
            Fact R35f2 = new SingleFact(v42, d1.GetValueByString("Нет"));
            Premise R35p = new Premise(FactOperator.Сonjunction);
            R35p.AddFact(R35f1);
            R35p.AddFact(R35f2);
            SingleFact R35c = new SingleFact(v40, d15.GetValueByString("1"));
            string R35ex = "Если у пользователя здоровый сон и нет нарушения биоримтов, то у него правильный отдых";
            Rule R35 = new Rule("R35", R35ex, R35p, R35c);

            /*IF: HRCARE = 2 OR MTHCARE = 2 OR SKCARE = 2
            THEN: RGHHY = 2
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ НЕ УХАЖИВАЕТ ЗА ВОЛОСАМИ ИЛИ ПОЛОСТЬЮ РТА, ИЛИ КОЖЕЙ, ТО У НЕГО НЕПРАВИЛЬНАЯ ГИГИЕНА*/
            Fact R36f1 = new SingleFact(v23, d1.GetValueByString("Нет"));
            Fact R36f2 = new SingleFact(v23, d1.GetValueByString("Нет"));
            Fact R36f3 = new SingleFact(v24, d1.GetValueByString("Нет"));
            Premise R36p = new Premise(FactOperator.Disjunction);
            R36p.AddFact(R36f1);
            R36p.AddFact(R36f2);
            R36p.AddFact(R36f3);
            SingleFact R36c = new SingleFact(v44, d1.GetValueByString("Нет"));
            string R36ex = "Если пользователь не ухаживает за волосами или полостью рта, или кожей, то у него неправильная гигиена";
            Rule R36 = new Rule("R36", R36ex, R36p, R36c);

            /*IF: HRCARE = 1 AND MTHCARE = 1 AND SKCARE = 1
            THEN: RGHHY = 1
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ УХАЖИВАЕТ ЗА ВОЛОСАМИ, ПОЛОСТЬЮ РТА И КОЖЕЙ, ТО У НЕГО ПРАВИЛЬНАЯ ГИГИЕНА*/
            Fact R37f1 = new SingleFact(v22, d1.GetValueByString("Да"));
            Fact R37f2 = new SingleFact(v23, d1.GetValueByString("Да"));
            Fact R37f3 = new SingleFact(v24, d1.GetValueByString("Да"));
            Premise R37p = new Premise(FactOperator.Сonjunction);
            R37p.AddFact(R37f1);
            R37p.AddFact(R37f2);
            R37p.AddFact(R37f3);
            SingleFact R37c = new SingleFact(v44, d1.GetValueByString("Да"));
            string R37ex = "Если пользователь ухаживает за волосами, полостью рта и кожей, то у него правильная гигиена";
            Rule R37 = new Rule("R37", R37ex, R37p, R37c);

            /*IF: TEMPPR = 5 OR STIPR = 2
            THEN: IMCARE = 2
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ НЕ СОБЛЮДАЕТ НИ ОДНУ ИЗ ПЕРЕЧИСЛЕННЫХ ЗАКАЛИВАЮЩИХ ПРОЦЕДУР ИЛИ НЕ СОБЛЮДАЕТ ПРОФИЛАКТИКУ ИППП, ТО У НЕГО ИММУНИТЕТ НЕЗАЩИЩЕН*/
            Fact R38f1 = new SingleFact(v25, d12.GetValueByString("Ничего из перечисленного"));
            Fact R38f2 = new SingleFact(v26, d1.GetValueByString("Нет"));
            Premise R38p = new Premise(FactOperator.Disjunction);
            R38p.AddFact(R38f1);
            R38p.AddFact(R38f2);
            SingleFact R38c = new SingleFact(v45, d1.GetValueByString("Нет"));
            string R38ex = "Если пользователь не соблюдает ни одну из перечисленных закаливающих процедур или не соблюдает профилактику иппп, то у него иммунитет незащищен";
            Rule R38 = new Rule("R38", R38ex, R38p, R38c);


            /*IF: (TEMPPR = 1 OR TEMPPR = 2 OR TEMPPR = 3 OR TEMPPR = 4) AND STIPR = 1
            THEN: IMCARE = 1
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ ПРИНИМАЕТ ВОЗДУШНЫЕ ВАННЫ / СОЛНЕЧНЫЕ ВАННЫ / КОНТРАСТНЫЙ ДУШ / ПРОХОДИТ ПРОЦЕДУРЫ ОБЛИВАНИЯ ХОЛОДНОЙ ВОДОЙ И СОБЛЮДАЕТ ПРОФИЛАКТИКУ ИППП, ТО У НЕГО ИММУНИТЕТ ЗАЩИЩЕН*/
            // 1
            // IF: TEMPPR = 1 OR TEMPPR = 2 OR TEMPPR = 3 OR TEMPPR = 4
            // THEN: v38_1 = 1
            Fact R39_1f1 = new SingleFact(v25, d12.GetValueByString("Воздушные ванны"));
            Fact R39_1f2 = new SingleFact(v25, d12.GetValueByString("Солнечные ванны"));
            Fact R39_1f3 = new SingleFact(v25, d12.GetValueByString("Контрастный душ"));
            Fact R39_1f4 = new SingleFact(v25, d12.GetValueByString("Обливание холодной водой"));
            Premise R39_1p = new Premise(FactOperator.Disjunction);
            R39_1p.AddFact(R39_1f1);
            R39_1p.AddFact(R39_1f2);
            R39_1p.AddFact(R39_1f3);
            R39_1p.AddFact(R39_1f4);
            SingleFact R39_1c = new SingleFact(v38_1, d1.GetValueByString("Да"));
            string R39_1ex = "Часть 38 правила";
            Rule R39_1 = new Rule("R39_1", R39_1ex, R39_1p, R39_1c);

            // 2
            Fact R39f1 = new SingleFact(v38_1, d1.GetValueByString("Да"));
            Fact R39f2 = new SingleFact(v26, d1.GetValueByString("Да"));
            Premise R39p = new Premise(FactOperator.Сonjunction);
            R39p.AddFact(R39f1);
            R39p.AddFact(R39f2);
            SingleFact R39c = new SingleFact(v45, d1.GetValueByString("Да"));
            string R39ex = "Если пользователь принимает воздушные ванны / солнечные ванны / контрастный душ / проходит процедуры обливания холодной водой и соблюдает профилактику иппп, то у него иммунитет защищен";
            Rule R39 = new Rule("R39", R39ex, R39p, R39c);

            /*IF: RGHHY = 2 OR IMCARE = 2
            THEN: DISPR = 2
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ НЕ СОБЛЮДАЕТ ПРАВИЛЬНУЮ ГИГИЕНУ ИЛИ ЕГО ИММУНИТЕТ НЕЗАЩИЩЁН, ТО ОН НЕ ЗАЩИЩЕН ОТ ЗАБОЛЕВАНИЙ*/
            Fact R40f1 = new SingleFact(v44, d1.GetValueByString("Нет"));
            Fact R40f2 = new SingleFact(v45, d1.GetValueByString("Нет"));
            Premise R40p = new Premise(FactOperator.Disjunction);
            R40p.AddFact(R40f1);
            R40p.AddFact(R40f2);
            SingleFact R40c = new SingleFact(v46, d15.GetValueByString("2"));
            string R40ex = "Если пользователь не соблюдает правильную гигиену или его иммунитет незащищён, то он не защищен от заболеваний";
            Rule R40 = new Rule("R40", R40ex, R40p, R40c);

            /*IF: RGHHY = 1 AND IMCARE = 1
            THEN: DISPR = 1
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ СОБЛЮДАЕТ ПРАВИЛЬНУЮ ГИГИЕНУ И ЕГО ИММУНИТЕТ ЗАЩИЩЕН, ТО ОН ЗАЩИЩЕН ОТ ЗАБОЛЕВАНИЙ*/
            Fact R41f1 = new SingleFact(v44, d1.GetValueByString("Да"));
            Fact R41f2 = new SingleFact(v45, d1.GetValueByString("Да"));
            Premise R41p = new Premise(FactOperator.Сonjunction);
            R41p.AddFact(R41f1);
            R41p.AddFact(R41f2);
            SingleFact R41c = new SingleFact(v46, d15.GetValueByString("1"));
            string R41ex = "Если пользователь соблюдает правильную гигиену и его иммунитет защищен, то он защищен от заболеваний";
            Rule R41 = new Rule("R41", R41ex, R41p, R41c);

            /*IF: SCACT = 1 AND DEPCOND = 1 AND EMEXP = 1
            THEN: PSSTL = 1
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ ПРИСУТСТВУЕТ СОЦИАЛЬНАЯ АКТИВНОСТЬ, РЕДКОЕ ДЕПРЕССИВНОЕ СОСТОЯНИЕ И ОН ПРАВИЛЬНО ВЫРАЖАЕТ ЭМОЦИИ, ТО У НЕГО ПОЗИТИВНЫЙ ОБРАЗ ЖИЗНИ*/
            Fact R42f1 = new SingleFact(v27, d1.GetValueByString("Да"));
            Fact R42f2 = new SingleFact(v28, d13.GetValueByString("Редко"));
            Fact R42f3 = new SingleFact(v29, d1.GetValueByString("Да"));
            Premise R42p = new Premise(FactOperator.Сonjunction);
            R42p.AddFact(R42f1);
            R42p.AddFact(R42f2);
            R42p.AddFact(R42f3);
            SingleFact R42c = new SingleFact(v47, d1.GetValueByString("Да"));
            string R42ex = "Если у пользователя присутствует социальная активность, редкое депрессивное состояние и он правильно выражает эмоции, то у него позитивный образ жизни";
            Rule R42 = new Rule("R42", R42ex, R42p, R42c);

            /*IF: (SCACT = 2 OR DEPCOND = 2 OR EMEXP = 2) AND PSYVIS = 1
            THEN: PSSTL = 1
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ НЕТ СОЦИАЛЬНОЙ АКТИВНОСТИ ИЛИ ЧАСТОЕ ДЕПРЕССИВНОЕ СОСТОЯНИЕ ИЛИ НЕПРАВИЛЬНОЕ ВЫРАЖЕНИЙ ЭМОЦИЙ, ПРИ ЭТОМ ОН ХОДИТ К ПСИХОЛОГУ / ПСИХИАТРУ, ТО У НЕГО ПОЗИТИВНЫЙ ОБРАЗ ЖИЗНИ*/
            // 1
            // IF: SCACT = 2 OR DEPCOND = 2 OR EMEXP = 2
            // THEN v43_1 = 1
            Fact R43_1f1 = new SingleFact(v27, d1.GetValueByString("Нет"));
            Fact R43_1f2 = new SingleFact(v28, d13.GetValueByString("Часто"));
            Fact R43_1f3 = new SingleFact(v29, d1.GetValueByString("Нет"));
            Premise R43_1p = new Premise(FactOperator.Disjunction);
            R43_1p.AddFact(R43_1f1);
            R43_1p.AddFact(R43_1f2);
            R43_1p.AddFact(R43_1f3);
            SingleFact R43_1c = new SingleFact(v43_1, d1.GetValueByString("Да"));
            string R43_1ex = "Часть 43-44 правил";
            Rule R43_1 = new Rule("R43_1", R43_1ex, R43_1p, R43_1c);

            // 2
            Fact R43f1 = new SingleFact(v43_1, d1.GetValueByString("Да"));
            Fact R43f2 = new SingleFact(v30, d1.GetValueByString("Да"));
            Premise R43p = new Premise(FactOperator.Сonjunction);
            R43p.AddFact(R43f1);
            R43p.AddFact(R43f2);
            SingleFact R43c = new SingleFact(v47, d1.GetValueByString("Да"));
            string R43ex = "Если у пользователя нет социальной активности или частое депрессивное состояние или неправильное выражений эмоций, при этом он ходит к психологу / психиатру, то у него позитивный образ жизни";
            Rule R43 = new Rule("R43", R43ex, R43p, R43c);

            /*IF: (SCACT = 2 OR DEPCOND = 2 OR EMEXP = 2) AND PSYVIS = 2
            THEN: PSSTL = 2
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ НЕТ СОЦИАЛЬНАЯ АКТИВНОСТЬ ИЛИ ЧАСТОЕ ДЕПРЕССИВНОЕ СОСТОЯНИЕ ИЛИ НЕПРАВИЛЬНОЕ ВЫРАЖЕНИЙ ЭМОЦИЙ, ПРИ ЭТОМ ОН НЕ ХОДИТ К ПСИХОЛОГУ/ ПСИХИАТРУ, ТО У НЕГО НЕ ПОЗИТИВНЫЙ ОБРАЗ ЖИЗНИ*/
            Fact R44f1 = new SingleFact(v43_1, d1.GetValueByString("Да"));
            Fact R44f2 = new SingleFact(v30, d1.GetValueByString("Нет"));
            Premise R44p = new Premise(FactOperator.Сonjunction);
            R44p.AddFact(R44f1);
            R44p.AddFact(R44f2);
            SingleFact R44c = new SingleFact(v47, d1.GetValueByString("Нет"));
            string R44ex = "Если у пользователя нет социальная активность или частое депрессивное состояние или неправильное выражений эмоций, при этом он не ходит к психологу / психиатру, то у него не позитивный образ жизни";
            Rule R44 = new Rule("R44", R44ex, R44p, R44c);

            /*IF: SRRLF = 2 OR CNFAV = 1
            THEN: STRSFLX = 2
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ НЕ СНИМАЕТ ТРЕВОГУ / СТРЕСС ИЛИ ИЗБЕГАЕТ КОНФЛИКТОВ, ТО У НЕГО НЕТ ПСИХОЛОГИЧЕСКОЙ ГИБКОСТИ*/
            Fact R45f1 = new SingleFact(v31, d1.GetValueByString("Нет"));
            Fact R45f2 = new SingleFact(v32, d1.GetValueByString("Да"));
            Premise R45p = new Premise(FactOperator.Disjunction);
            R45p.AddFact(R45f1);
            R45p.AddFact(R45f2);
            SingleFact R45c = new SingleFact(v48, d1.GetValueByString("Нет"));
            string R45ex = "Если пользователь не снимает тревогу / стресс или избегает конфликтов, то у него нет психологической гибкости";
            Rule R45 = new Rule("R45", R45ex, R45p, R45c);

            /*IF: SRRLF = 1 AND CNFAV = 2
            THEN: STRSFLX = 1
            REASON: ЕСЛИ ПОЛЬЗОВАТЕЛЬ СНИМАЕТ ТРЕВОГУ/ СТРЕСС И НЕ ИЗБЕГАЕТ КОНФЛИКТОВ, ТО У НЕГО ЕСТЬ ПСИХОЛОГИЧЕСКАЯ ГИБКОСТЬ*/
            Fact R46f1 = new SingleFact(v31, d1.GetValueByString("Да"));
            Fact R46f2 = new SingleFact(v32, d1.GetValueByString("Нет"));
            Premise R46p = new Premise(FactOperator.Сonjunction);
            R46p.AddFact(R46f1);
            R46p.AddFact(R46f2);
            SingleFact R46c = new SingleFact(v48, d1.GetValueByString("Да"));
            string R46ex = "Если пользователь снимает тревогу/ стресс и не избегает конфликтов, то у него есть психологическая гибкость";
            Rule R46 = new Rule("R46", R46ex, R46p, R46c);

            /*IF: PSSTL = 2 OR STRSFLX = 2
            THEN: RGHPSY = 2
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ НЕ ПОЗИТИВНЫЙ ОБРАЗ ЖИЗНИ ИЛИ НЕТ ПСИХОЛОГИЧЕСКОЙ ГИБКОСТИ, ТО У НЕГО НЕПРАВИЛЬНАЯ ПСИХОЭМОЦИОНАЛЬНАЯ КУЛЬТУРА*/
            Fact R47f1 = new SingleFact(v47, d1.GetValueByString("Нет"));
            Fact R47f2 = new SingleFact(v48, d1.GetValueByString("Нет"));
            Premise R47p = new Premise(FactOperator.Disjunction);
            R47p.AddFact(R47f1);
            R47p.AddFact(R47f2);
            SingleFact R47c = new SingleFact(v49, d15.GetValueByString("2"));
            string R47ex = "Если у пользователя не позитивный образ жизни или нет психологической гибкости, то у него неправильная психоэмоциональная культура";
            Rule R47 = new Rule("R47", R47ex, R47p, R47c);

            /*IF: PSSTL = 1 AND STRSFLX = 1
            THEN: RGHPSY = 1
            REASON: ЕСЛИ У ПОЛЬЗОВАТЕЛЯ ПОЗИТИВНЫЙ ОБРАЗ ЖИЗНИ И ЕСТЬ ПСИХОЛОГИЧЕСКАЯ ГИБКОСТЬ, ТО У НЕГО ПРАВИЛЬНАЯ ПСИХОЭМОЦИОНАЛЬНАЯ КУЛЬТУРА*/
            Fact R48f1 = new SingleFact(v47, d1.GetValueByString("Да"));
            Fact R48f2 = new SingleFact(v48, d1.GetValueByString("Да"));
            Premise R48p = new Premise(FactOperator.Сonjunction);
            R48p.AddFact(R48f1);
            R48p.AddFact(R48f2);
            SingleFact R48c = new SingleFact(v49, d15.GetValueByString("1"));
            string R48ex = "Если у пользователя позитивный образ жизни и есть психологическая гибкость, то у него правильная психоэмоциональная культура";
            Rule R48 = new Rule("R48", R48ex, R48p, R48c);

            /*IF: RHGNUT + RHGPHYS + RGHHAB + RGHRST + DISPR + RGHPSY = 6
            THEN: LFSTLQL = "ОЧЕНЬ ВЫСОКИЙ"
            REASON: ЕСЛИ ВСЕ КРИТЕРИИ ЗДОРОВОГО ОБРАЗА ЖИЗНИ ВЫПОЛНЯЮТСЯ, НО УРОВЕНЬ КАЧЕСТВА ОБРАЗА ЖИЗНИ ОЧЕНЬ ВЫСОКИЙ*/
            List<Variable> R49f1vars = new List<Variable>();
            R49f1vars.AddRange(new Variable[] { v35, v37, v39, v40, v46, v49 });
            Fact R49f1 = new AdditiveFact(R49f1vars, (NumericDomainValue)d15.GetValueByString("6"));
            Premise R49p = new Premise(FactOperator.Disjunction);
            R49p.AddFact(R49f1);
            SingleFact R49c = new SingleFact(v50, d14.GetValueByString("Очень высокий"));
            string R49ex = "Если все критерии здорового образа жизни выполняются, то уровень качества образа жизни очень высокий";
            Rule R49 = new Rule("R49", R49ex, R49p, R49c);

            /*IF: RHGNUT + RHGPHYS + RGHHAB + RGHRST + DISPR + RGHPSY = 7
            THEN: LFSTLQL = "ВЫСОКИЙ"
            REASON: ЕСЛИ 5 КРИТЕРИЕВ ЗДОРОВОГО ОБРАЗА ЖИЗНИ НЕ ВЫПОЛНЯЕТСЯ, НО УРОВЕНЬ КАЧЕСТВА ОБРАЗА ЖИЗНИ ВЫСОКИЙ*/
            List<Variable> R50f1vars = new List<Variable>();
            R50f1vars.AddRange(new Variable[] { v35, v37, v39, v40, v46, v49 });
            Fact R50f1 = new AdditiveFact(R50f1vars, (NumericDomainValue)d15.GetValueByString("7"));
            Premise R50p = new Premise(FactOperator.Disjunction);
            R50p.AddFact(R50f1);
            SingleFact R50c = new SingleFact(v50, d14.GetValueByString("Очень высокий"));
            string R50ex = "Если 5 критериев здорового образа жизни выполняются, то уровень качества образа жизни очень высокий";
            Rule R50 = new Rule("R50", R50ex, R50p, R50c);

            /*IF: RHGNUT + RHGPHYS + RGHHAB + RGHRST + DISPR + RGHPSY = 8
            THEN: LFSTLQL = "ВЫШЕ СРЕДНЕГО"
            REASON: ЕСЛИ ДВА КРИТЕРИЯ ЗДОРОВОГО ОБРАЗА ЖИЗНИ НЕ ВЫПОЛНЯЮТСЯ, НО УРОВЕНЬ КАЧЕСТВА ОБРАЗА ЖИЗНИ ВЫШЕ СРЕДНЕГО*/
            List<Variable> R51f1vars = new List<Variable>();
            R51f1vars.AddRange(new Variable[] { v35, v37, v39, v40, v46, v49 });
            Fact R51f1 = new AdditiveFact(R51f1vars, (NumericDomainValue)d15.GetValueByString("8"));
            Premise R51p = new Premise(FactOperator.Disjunction);
            R51p.AddFact(R51f1);
            SingleFact R51c = new SingleFact(v50, d14.GetValueByString("Выше среднего"));
            string R51ex = "Если два критерия здорового образа жизни не выполняются, но уровень качества образа жизни выше среднего";
            Rule R51 = new Rule("R51", R51ex, R51p, R51c);

            /*IF: RHGNUT + RHGPHYS + RGHHAB + RGHRST + DISPR + RGHPSY = 9
            THEN: LFSTLQL = "СРЕДНИЙ"
            REASON: ЕСЛИ ТРИ КРИТЕРИЯ ЗДОРОВОГО ОБРАЗА ЖИЗНИ НЕ ВЫПОЛНЯЮТСЯ, НО УРОВЕНЬ КАЧЕСТВА ОБРАЗА ЖИЗНИ СРЕДНИЙ*/
            List<Variable> R52f1vars = new List<Variable>();
            R52f1vars.AddRange(new Variable[] { v35, v37, v39, v40, v46, v49 });
            Fact R52f1 = new AdditiveFact(R52f1vars, (NumericDomainValue)d15.GetValueByString("9"));
            Premise R52p = new Premise(FactOperator.Disjunction);
            R52p.AddFact(R52f1);
            SingleFact R52c = new SingleFact(v50, d14.GetValueByString("Средний"));
            string R52ex = "Если три критерия здорового образа жизни не выполняются, но уровень качества образа жизни средний";
            Rule R52 = new Rule("R52", R52ex, R52p, R52c);

            /*IF: RHGNUT + RHGPHYS + RGHHAB + RGHRST + DISPR + RGHPSY = 10
            THEN: LFSTLQL = "НИЖЕ СРЕДНЕГО"
            REASON: ЕСЛИ ЧЕТЫРЕ КРИТЕРИЯ ЗДОРОВОГО ОБРАЗА ЖИЗНИ НЕ ВЫПОЛНЯЮТСЯ, НО УРОВЕНЬ КАЧЕСТВА ОБРАЗА ЖИЗНИ НИЖЕ СРЕДНЕГО*/
            List<Variable> R53f1vars = new List<Variable>();
            R53f1vars.AddRange(new Variable[] { v35, v37, v39, v40, v46, v49 });
            Fact R53f1 = new AdditiveFact(R53f1vars, (NumericDomainValue)d15.GetValueByString("10"));
            Premise R53p = new Premise(FactOperator.Disjunction);
            R53p.AddFact(R53f1);
            SingleFact R53c = new SingleFact(v50, d14.GetValueByString("Ниже среднего"));
            string R53ex = "Если четыре критерия здорового образа жизни не выполняются, но уровень качества образа жизни ниже среднего";
            Rule R53 = new Rule("R53", R53ex, R53p, R53c);

            /*IF: RHGNUT + RHGPHYS + RGHHAB + RGHRST + DISPR + RGHPSY = 11
            THEN: LFSTLQL = "НИЗКИЙ"
            REASON: ЕСЛИ ПЯТЬ КРИТЕРИЕВ ЗДОРОВОГО ОБРАЗА ЖИЗНИ НЕ ВЫПОЛНЯЮТСЯ, НО УРОВЕНЬ КАЧЕСТВА ОБРАЗА ЖИЗНИ НИЗКИЙ*/
            List<Variable> R54f1vars = new List<Variable>();
            R54f1vars.AddRange(new Variable[] { v35, v37, v39, v40, v46, v49 });
            Fact R54f1 = new AdditiveFact(R54f1vars, (NumericDomainValue)d15.GetValueByString("11"));
            Premise R54p = new Premise(FactOperator.Disjunction);
            R54p.AddFact(R54f1);
            SingleFact R54c = new SingleFact(v50, d14.GetValueByString("Низкий"));
            string R54ex = "Если пять критериев здорового образа жизни не выполняются, но уровень качества образа жизни низкий";
            Rule R54 = new Rule("R54", R54ex, R54p, R54c);

            /*IF: RHGNUT + RHGPHYS + RGHHAB + RGHRST + DISPR + RGHPSY = 12
            THEN: LFSTLQL = "ОЧЕНЬ НИЗКИЙ"
            REASON: ЕСЛИ ВСЕ КРИТЕРИИ ЗДОРОВОГО ОБРАЗА ЖИЗНИ НЕ ВЫПОЛНЯЮТСЯ, НО УРОВЕНЬ КАЧЕСТВА ОБРАЗА ЖИЗНИ ОЧЕНЬ НИЗКИЙ*/
            List<Variable> R55f1vars = new List<Variable>();
            R55f1vars.AddRange(new Variable[] { v35, v37, v39, v40, v46, v49 });
            Fact R55f1 = new AdditiveFact(R55f1vars, (NumericDomainValue)d15.GetValueByString("12"));
            Premise R55p = new Premise(FactOperator.Disjunction);
            R55p.AddFact(R55f1);
            SingleFact R55c = new SingleFact(v50, d14.GetValueByString("Очень низкий"));
            string R55ex = "Если все критерии здорового образа жизни не выполняются, но уровень качества образа жизни очень низкий";
            Rule R55 = new Rule("R55", R55ex, R55p, R55c);

            List<Rule> rules = new List<Rule>();
            rules.AddRange(new Rule[] { R1, R2, R3, R4, R5, R5_1, R6, R7, R7_1, R8, R9, R10, R11, R12, R12_1, R12_fx, R12_fx_1, R13, R14, R15, R16, R17, R18, R19, R20, R21, R22, R23, R24, R25, R26, R26_1, R27, R28, R29, R30, R31, R32, R33, R34, R35, R36, R37, R38, R39, R39_1, R40, R41, R42, R43, R43_1, R44, R45, R46, R47, R48, R49, R50, R51, R52, R53, R54, R55 });

            return new KnowledgeBase(domains, variables, rules);
        }
    }
}
