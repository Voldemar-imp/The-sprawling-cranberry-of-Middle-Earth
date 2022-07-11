using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string heroName;
            string enemyName;
            string heroBattelMessage = "";
            int enemyDamage;
            int enemyDamageMin = 30;
            int enemyDamageMax = 100;
            int orksSummon;
            int orksSummonMin = 0;
            int orksSummonMax = 4;
            int orksCount = 0;
            int oneOrkDamage = 30;
            int ollOrksDamage;
            int heroDamage = 0;
            int heroDamageMin = 10;
            int heroDamageMax = 50;
            int heroDamageModifier = 4;
            int heroDamageModifierRound = 0;
            Random random = new Random();            
            int heroHealth = 1000;
            int heroDanseHeal = 200;
            int enemyHealth = 1000;
            int bottelCount = 20;
            int outOfBottlesDamage = 50;
            int windowWidth = 150;
            int windowHeight = 45;
            int cursorPositionWidth;
            int cursorPositionHeight;
            bool gameIsContinues = true;

            Console.SetWindowSize(windowWidth, windowHeight);
            // title of the game
            cursorPositionWidth = windowWidth / 3;
            cursorPositionHeight = 1;
            Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
            Console.WriteLine("--------Добро пожаловать в игру:-------");
            Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
            Console.WriteLine("The sprawling cranberry of Middle-Earth ");
            Console.ReadKey();
            // legend of the game
            cursorPositionWidth = 3;
            cursorPositionHeight = 5;
            heroName = "Boris 40Degrees";
            Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
            Console.WriteLine("Вашего героя зовут: " + heroName);
            Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
            Console.WriteLine("Помогите в извечной битве Бора с Ослом!");
            Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
            Console.WriteLine("Установите самый справедливый порядок в Средиземье!");
            Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
            Console.WriteLine("Уничтожьте кровавый режим и его приспешников!");
            Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
            enemyName = "Banderlog ShadowOfCommunism";
            Console.WriteLine("Управляемый великим и ужасным: " + enemyName);
            Console.ReadKey();
            Console.Clear();

            while (gameIsContinues)
            {
                //title of the game
                cursorPositionWidth = windowWidth / 3;
                cursorPositionHeight = 1;
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                Console.WriteLine("--------Добро пожаловать в игру:-------");
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                Console.WriteLine("The sprawling cranberry of Middle-Earth ");
                // hero's hitbar
                cursorPositionWidth = 3;
                cursorPositionHeight = windowHeight * 1 / 5;
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                Console.WriteLine("Ваш герой: " + heroName);
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                Console.WriteLine("Здоровье: " + heroHealth);
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                Console.WriteLine("Бутылок водки в инвентаре: " + bottelCount);
               
                if (heroDamageModifierRound >=1 ) 
                {
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Под градусом еще: " + heroDamageModifierRound + " хода");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if(bottelCount <= 0 && heroDamageModifierRound <= 0)
                {
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Мучает сушняк");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else 
                {
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);                    
                    Console.WriteLine("Действующие статусы: отсутствуют");
                }

                //hero's abilities
                cursorPositionWidth = windowWidth / 3;
                cursorPositionHeight = windowHeight * 4 / 5;
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                Console.WriteLine("Нажмите цифру ссоответствующую доступным способностям: ");
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                Console.WriteLine("1 - дыхнуть перегаром (нанести случайное количество урона)");
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                Console.WriteLine("2 - Накатить стопарь (- 1 бутылка водки)  " +
                    "(следующие {0} ходов Х{0} урона)", heroDamageModifier);
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                Console.WriteLine("3 - Призвать рыжего эльфа Чубайласа  (эффективен против Орков)");
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                Console.WriteLine("4 - Зажигательный танец (нужно накатить (2), лечит {0} здоровья)", heroDanseHeal);
                //enemy hitbar
                cursorPositionWidth = windowWidth * 2/ 3;
                cursorPositionHeight = windowHeight * 1 / 5;
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                Console.WriteLine("Ваш противник: " + enemyName);
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                Console.WriteLine("Здоровье: " + enemyHealth);
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                Console.WriteLine("Призванно орков-пионеров: " + orksCount);
                //player actions
                cursorPositionWidth = 3;
                cursorPositionHeight = windowHeight * 4 / 5 ;
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight);
                Console.Write("Какое действие вы хотите сделать:");
                userInput = Console.ReadLine();

                while (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4")
                {
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight);
                    Console.WriteLine("Неправильно введена команда           ");
                    Console.ReadKey();
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight);
                    Console.Write("Какое действие вы хотите сделать:");
                    userInput = Console.ReadLine();
                }

                switch (userInput)
                {
                    case "1":
                        if (heroDamageModifierRound >= 1)
                        {
                            heroDamageModifierRound--;
                            heroDamage = random.Next(heroDamageMin, heroDamageMax) * heroDamageModifier;
                            heroBattelMessage = heroName + " дыхнул перегаром на " + enemyName +
                                " и после недавно выпитого нанес усиленный урон - " + heroDamage;
                        }
                        else
                        {
                            heroDamage = random.Next(heroDamageMin, heroDamageMax);
                            heroBattelMessage = heroName + " дыхнул перегаром на " + enemyName + 
                                " и нанес " + heroDamage + " урона.";
                        }
                        break;
                    case "2":
                        heroDamage = 0;
                        if (bottelCount >= 1)
                        {
                            bottelCount--;
                            heroDamageModifierRound = heroDamageModifier;
                            heroBattelMessage = heroName + " накатил пару стопарей и стал более опасным \n " +
                                "на " + heroDamageModifierRound + " хода (- 1 бутылка).";
                        }
                        else 
                        {
                            heroBattelMessage = heroName + " кричит: кончилась водка! ПАМАГИТЕ!!!";
                        }
                        break;
                    case "3":
                        heroDamageModifierRound--;
                        if (orksCount != 0)
                        {                            
                            ollOrksDamage = orksCount * oneOrkDamage;
                            orksCount = 0;
                            heroBattelMessage = heroName + " призывает рыжего эльфа Чубайласа. " +
                                "Который впаривает Оркам-пионерам ваучеры. \n" +
                                "Обманутые орки устраивают дебош в своем лагере. " +
                                "Нанося, тем самым, делу революции " + ollOrksDamage + " урона. \n" +
                                "После чего расходятся по домам.";
                        }
                        else 
                        {
                            bottelCount--;
                            heroBattelMessage = heroName + " призывает рыжего эльфа Чубайласа. " +
                                "Не найдя кому можно впанить свои ваучеры, " +
                                "Чубайлас зебирает у героя бутылку водки. \n" +
                                "После чего печально удалятся в лес, чтобы пьянствовать в одиночестве (- 1 бутылка).";
                        }
                        break;
                    case "4":
                        heroDamage = 0;

                        if (heroDamageModifierRound >= 1)
                        {                            
                            heroDamageModifierRound--;
                            heroHealth += heroDanseHeal;
                            heroBattelMessage = heroName + " устраивает зажигательный танец, " +
                                "поднимая настроение себе и окружающим.\n" +
                                "После выступления гереой чувствует " +
                                "себе значительно лучше и восстанавливает " + heroDanseHeal + " здоровья.";
                        }
                        else 
                        {
                            heroBattelMessage = heroName + " начинает напевать: \n" +
                                "Женщина, не танцую, Женщина, я не танцую \n" +
                                "Никого я не рисую. Не умею, не танцую. \n\n Ничего не происходит.";
                        }
                        break;
                }

                //battle events
                cursorPositionWidth = 0;
                cursorPositionHeight = windowHeight * 2 / 5 ;
                enemyDamage = random.Next(enemyDamageMin, enemyDamageMax);
                heroHealth -= enemyDamage;
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                Console.WriteLine("{0} наносит {1} урона", enemyName, enemyDamage);
                enemyHealth -= heroDamage;                            
                bottelCount -= orksCount;

                if (orksCount != 0 && bottelCount > orksCount)
                {
                    heroHealth -= oneOrkDamage;
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    Console.WriteLine("Орков всего {0}. Орки отбирают у героя {0}  бутылок водки." +
                        " Один из орков дает в глаз герою на {1} урона.", orksCount, oneOrkDamage);
                }
                else if (orksCount != 0 && bottelCount <= orksCount && bottelCount >=1)
                {
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    ollOrksDamage = orksCount * oneOrkDamage;
                    heroHealth -= ollOrksDamage; 
                    Console.WriteLine("Орков всего {0}. Орки отбирают у героя " +
                        "все оставшиеся бутылки водки. После чего избивают его, " +
                        "нанося {1} урона.", orksCount, ollOrksDamage);
                }
                else if (orksCount != 0 && bottelCount <= 0)
                {
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    ollOrksDamage = orksCount * oneOrkDamage;
                    heroHealth -= ollOrksDamage;
                    Console.WriteLine("Орков всего {0}. Орки, не найдя у героя бутылок водки," +
                        " избивают его, нанося {1} урона.", orksCount, ollOrksDamage);
                }

                orksSummon = random.Next(orksSummonMin, orksSummonMax + 1);
                orksCount += orksSummon;
                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                Console.WriteLine (enemyName + " призывает ещё " + orksSummon + " Орков-пионеров.");
               
                if (bottelCount <= 0 && heroDamageModifierRound <=0)
                {
                    bottelCount = 0;
                    heroHealth -= outOfBottlesDamage;
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    Console.WriteLine("Герой страдает от сушняка и получает {0} урона.", outOfBottlesDamage);
                }
                else if (bottelCount <= 0) 
                { 
                    bottelCount = 0; 
                }

                Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);                
                Console.WriteLine(heroBattelMessage);
                heroBattelMessage = "";
                Console.ReadKey();
                Console.Clear();

                if (enemyHealth <= 0 && heroHealth <= 0)
                {
                    gameIsContinues = false;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    cursorPositionWidth = windowWidth/4;
                    cursorPositionHeight = windowHeight / 2 -1;
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    Console.WriteLine("Оба противника {0} и {1} пали в жестокой борьбе.", heroName, enemyName);
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    Console.WriteLine("В Средиземье воцарилась анархия!");
                }
                else if (enemyHealth <= 0)
                {
                    gameIsContinues = false;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    cursorPositionWidth = windowWidth / 4;
                    cursorPositionHeight = windowHeight / 2 - 3;
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    Console.WriteLine("{0} в жестокой борьбе одолел {1}", heroName, enemyName);
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    Console.WriteLine("{0} получил трофеи: малиновый пиджак, мерина 600-го, " +
                        "ящик печенья и банку варенья!", heroName);
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    Console.WriteLine("Теперь все знают его под именем: Alexsander White.");
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    Console.WriteLine("Средиземье познало леденящие душу прелести настоящей свободы!");
                }
                else if (heroHealth <= 0)
                {
                    gameIsContinues = false;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    cursorPositionWidth = windowWidth / 4;
                    cursorPositionHeight = windowHeight / 2 -3;
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    Console.WriteLine("{1} в жестокой борьбе одолел {0}.", heroName, enemyName);
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    Console.WriteLine("{0} был необуздан в желаниях своих.", enemyName);
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    Console.WriteLine("Как начал добро причинять налево-направо, " +
                        "пользу наносить, да ласкам подвергать!");
                    Console.SetCursorPosition(cursorPositionWidth, cursorPositionHeight++);
                    Console.WriteLine("С тех пор все в Средиземье ходили скучные да вялые!");
                }
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Спасибо за то, что играли в: The sprawling cranberry of Middle-Earth.");
        }
    }
}
