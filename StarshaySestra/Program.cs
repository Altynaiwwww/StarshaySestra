using Telegram.Bot;
using Telegram.Bot.Polling;
using Message = Telegram.Bot.Types.Message;
using Update = Telegram.Bot.Types.Update;

using System.Security.Cryptography.X509Certificates;
using StarshaySestra.StarshaySestraDAL.Entity;
using Telegram.Bot.Types;
using User = Telegram.Bot.Types.User;
using Telegram.Bots.Types;
using Telegram.Bot.Types.ReplyMarkups;
using InlineKeyboardMarkup = Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Telegram.Bots.Requests;

namespace Bot
{
    public class Program
    {
        static TelegramBotClient botClient = new TelegramBotClient("6239769324:AAE8BbkP2v0d4dyNbx45UEkvBOuBmNdSs7g");


        private enum BotState
        {
            MainMenu,
            Sos,
            Sex,
            Period,
            SocialNetworks,
            DadAndMom
        }

        static async Task Main()
        {
            var cancellationTokenSource = new CancellationTokenSource();


            var token = new CancellationTokenSource();
            var canceltoken = token.Token;
            var reOpt = new ReceiverOptions { AllowedUpdates = { } };


            await botClient.ReceiveAsync(OnMessage, ErrorAsync, reOpt, canceltoken);

        }

        private static Task ErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken canceltoken)
        {
            throw new NotImplementedException();
        }




        



        private static async Task OnMessage(ITelegramBotClient botClient, Update update,
          CancellationToken cancellationToken)
        {
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                var user = update.ToString();
                if (message.Text.ToLower() == "/start")
                {

                    InlineKeyboardMarkup keyboardMarkupStart = new InlineKeyboardMarkup
                        (InlineKeyboardButton.WithCallbackData(text: "Согласие", callbackData: "soglasen"));

                    await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Дисклеймер, данный бот разработан любящими сестрами для своих сестренок," +
                        " ввиде не принужденного разговора о этапах взросление и понятий своего тела ",
                        replyMarkup: keyboardMarkupStart, cancellationToken: cancellationToken);

                }

            }
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.CallbackQuery)
            {
                await HandleCallbackQuery(update, (TelegramBotClient)botClient);
            }


            //if (update.Type == Telegram.Bot.Types.Enums.UpdateType.MessageEventArgs xuyna) 
            //{
            //    await botClient.DeleteMessageAsync(
            //            chatId: e.Message.Chat.Id,
            //            messageId: e.Message.MessageId);
            //}

            static async Task HandleCallbackQuery(Update update, TelegramBotClient botClient)
            {
                var callbackQuery1 = update.CallbackQuery;






                switch (callbackQuery1.Data)
                {
                    case "soglasen":
                        var mainMenu = new ReplyKeyboardMarkup(
                            new[]
                            {
                                           new[]
                                           {
                                              new KeyboardButton("SOS"),
                                             
                                              
                                           },
                                           new[]
                                           {
                                               new KeyboardButton("Секс"),
                                           },
                                           new[]
                                           {
                                            new KeyboardButton("Как распознать арбузера?")
                                           },
                                           new[]
                                           {
                                           new KeyboardButton("Соц.сети и массовое информация ")
                                           },
                                           new[]
                                           {
                                            new KeyboardButton("Отношения с родителями "),
                                           }



                            }
                              );

                        await botClient.SendTextMessageAsync(
                      chatId: callbackQuery1.Message.Chat.Id,
                      text: "Выберите тему",
                      replyMarkup: mainMenu,
                      parseMode: Telegram.Bot.Types.Enums.ParseMode.Html
                      );
                        break;
                    default:

                        break;
                }

            }



            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                var callbackData = update.CallbackQuery;


                switch (message.Text)
                {
                    case "SOS":
                        var SOS = new ReplyKeyboardMarkup(new KeyboardButton[][]
                        {
                          new KeyboardButton[]
                          {
                           new KeyboardButton("Психолог"),
                          },
                          new KeyboardButton[]
                          {
                           new KeyboardButton("Адвокат"),
                          },
                          new KeyboardButton[]
                          {
                          new KeyboardButton("Юрист"),
                          },
                          new KeyboardButton[]
                          {
                            new KeyboardButton("Гинеколог")
                          },
                          new KeyboardButton[]
                          {
                            new KeyboardButton("Шелтер"),
                          },
                          new KeyboardButton[]
                          {
                            new KeyboardButton("Терапевт")
                          },
                          new KeyboardButton[]
                          {
                             new KeyboardButton("Назад")
                          }


                        });

                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "ободряющая поддержка",
                            replyMarkup: SOS);
                        break;


                    case "Отношения с родителями":
                        var parents = new ReplyKeyboardMarkup(new KeyboardButton[][]
                        {
                            new KeyboardButton[]
                            {
                             new KeyboardButton("как сепарироватся"),
                            },
                            new KeyboardButton[]
                            {
                             new KeyboardButton("родители и развод"),
                            },
                            new KeyboardButton[]
                            {
                            new KeyboardButton("Назад")
                            }


                        });
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "ободряющая поддержка",
                          replyMarkup: parents);
                        break;


                    case "Соц.сети и массовое информация":
                        var socials = new ReplyKeyboardMarkup(new KeyboardButton[][]
                        {
                            new KeyboardButton[]
                            {
                              new KeyboardButton("цифровая гигиена"),
                            },
                            new KeyboardButton []
                            {
                              new KeyboardButton("инста как фильтр"),
                            },
                            new KeyboardButton []
                            {
                              new KeyboardButton("Назад")
                            }

                        });
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "ободряющая поддержка",
                         replyMarkup: socials);
                        break;


                    case "Секс":
                        var sex = new ReplyKeyboardMarkup(new KeyboardButton[][]
                        {
                           new KeyboardButton[]
                           {
                             new KeyboardButton("методы защиты")
                           },
                           new KeyboardButton[]
                           {
                             new KeyboardButton("половое образование"),
                           },
                           new KeyboardButton[]
                           {
                             new KeyboardButton("месячные"),
                           },
                           new KeyboardButton[]
                           {
                             new KeyboardButton("Назад")
                           }


                        });
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "ободряющая поддержка",
                       replyMarkup: sex);
                        break;


                    case "Как распознать арбузера?":
                        var abuse = new ReplyKeyboardMarkup(new KeyboardButton[][]
                        {
                            new KeyboardButton[]
                            {
                                new KeyboardButton("виды отношений"),
                            },
                            new KeyboardButton[]
                            {
                             new KeyboardButton("душевное состояние"),
                            },
                            new KeyboardButton[]
                            {
                            new KeyboardButton("Назад")
                            }
                        });
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "ободряющая поддержка",
                      replyMarkup: abuse);
                        break;

                   
                }

            }



            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                var callbackData = update.CallbackQuery;

                switch (message.Text)
                {

                    case "как сепарироватся":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Сепарация от родителей в психологии — процесс трансформации отношений с родителями в сторону большего равенства, паритетности отношений родителей и взрослеющих детей. " +
                            "Процесс приводит к перестройке функционирования всей семейной системы родительской семьи и обусловливает достижение личностной автономии юношами/девушками в когнитивной, аффективной и поведенческой сферах. Процесс включает в себя изменение самосознания юношей/девушек, " +
                            "которое отражается в изменении образа Я, развитии осознания себя как отдельного уникального индивида, отличного от интериоризованных образов родителей, изменении образов родителей в направлении их реалистичности. " +
                            "Сепарация от родителей закладывает основы для гармоничных отношений с семьей, партнёром и собственными детьми.");
                        break;

                    case "родители и развод":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Развод давно стал привычным явлением в нашей жизни. При этом на жизнь конкретной семьи и особенно детей развод оказывает большое влияние. " +
                            "А вот будет ли это влияние негативным или тем более травмирующим, напрямую зависит от позиции взрослых.\r\n\r\nИнформированность ребенка\r\nРазвод сильно меняет жизнь детей." +
                            " В любом возрасте, если ребенок уже владеет речью, он будет пытаться понять, что произошло, почему это произошло, можно ли это как-то исправить. " +
                            "И чем младше дитя, чем сильнее в нем естественный детский эгоцентризм, тем больше вероятность, что он будет считать себя причиной произошедшего." +
                            "Поэтому, если ребенок умеет говорить, с ним надо разговаривать, опираясь на факты, избегая прямых или косвенных обвинений, принимая ответственность за это решение." +
                            "Часто в таких ситуациях родителям бывает полезно обратиться за консультацией к специалисту, чтобы разобраться, что и как говорить, чего говорить не стоит, как организовать весь этот непростой процесс. " +
                            "Главная задача родителей – свести к минимуму негативное влияние развода на психологическое состояние своего ребенка.");
                        break;

                    case "цифровая гигиена":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "В цифровом пространстве есть свои правила гигиены. К использованию интернета и потреблению информации стоит относиться так же, как к потреблению в физическом мире. " +
                            "Кстати, поколение Z воспринимает эту идею достаточно легко, поскольку границы между реальным и виртуальным миром для него несколько размыты.\r\n\r\nВот 10 базовых приемов информационной безопасности, о которых нужно знать и говорить детям и подросткам:" +
                            "Не давайте свой телефон незнакомым людям, которым якобы нужно срочно позвонить. Вы же не хотите, чтобы в руки незнакомцев попал разблокированный телефон?\r\nИспользуйте длинные и надежные пароли, а также биометрию и двухфакторную аутентификацию, особенно для платежей и денежных переводов." +
                            " Использование удобных коротких паролей может плохо кончиться.\r\nМеньше рассказывайте о себе в интернете. Думайте, кому и что вы говорите. Злоумышленники могут использовать раскрытые вашими же руками личные данные, чтобы атаковать вас." +
                            "Не принимайте запросы на дружбу от незнакомых людей в социальных сетях. Как минимум, это может кончиться валом рекламного спама. Про более скверные сценарии пишут в таблоидах каждый день.\r\nСледите за тем, какие приложения получают на ваших устройствах доступ и к чему. Новой игре совершенно не обязательно знать, где вы сейчас находитесь или иметь доступ к камере или микрофону." +
                            " \r\nОбновляйте программы и операционные системы на всех устройствах (не только мобильных). Разработчики не зря едят свой хлеб и в новых версиях добавляют не только красивые кнопки, но и закрывают уязвимости.");
                        break;

                    case "инста как фильтр":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Как известно, в Инстаграме обитают только идеальные люди: у них светлые счастливые лица без морщинок, фигуры без жиринки, путешествия по пять раз в год, секс дважды в день, вечная любовь, дорогие подарки и пакетики из ЦУМа.\r\n\r\n" +
                            "И на всём такой фильтр, типа под старину. На модели легинсы за 50 тысяч, но снято как будто на дедовский «Зенит», шоб лампово.\r\n\r\nОчевидно, что почти всё, что вы видите в «Инстаграме», — ложь. Вот почему.Некоторые так обманывают себя\r\nОтдельная категория инстаграмного обмана — истории об идеальных отношениях.\r\n\r\n" +
                            "Представьте, что у вас действительно идеальные отношения: ваш партнёр вам во всём нравится, у вас счастливая семья, вы наслаждаетесь жизнью, друг другом, сексом, едой, совместными делами. Есть ли хоть одна причина вам сейчас выставлять это напоказ?\r\n\r\nА теперь представьте, что у пары отношения трещат по швам. " +
                            "Чтобы как-то компенсировать эту тревогу, некоторые люди начинают создавать видимость счастливой пары: совместные фотосессии, показная нежность, подарки. Расчёт на то, что если показать всем друзьям свою большую любовь, то вероятность сохранить отношения резко возрастает.\r\n\r\nЭто такое нерациональное, почти магическое мышление." +
                            " Как будто хочешь увидеть подтверждение внешнего мира, что вы идеальная пара. Но когда об этом думаешь головой, понимаешь, что никакие отношения не спасти красивой фотосессией.\r\n\r\n");
                        break;


                    case "методы защиты":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Методы предохранения - это различные способы, которые используются для предотвращения нежелательной беременности и защиты от инфекций, передающихсяовым путем. Существует множество методов предохранения, включая:\r\n" +
                            "Кондомы - это тонкие резиновые изделия, которые надеваются на половой член мужчины или влагалище женщины для защиты от беременности и инфекций.\r\nГормональные методы - это методы, которые используют гормоны для предотвращения беременности. Это может быть таблетка, пластыр, кольцо или укол.\r\n" +
                            "Спираль - это маленькое устройство, которое вставляется в матку и предотвращает беременность.\r\nПрерванный половой акт - это метод, при котором мужчина выводит половой член из влагалища женщины перед эякуляцией.\r\n" +
                            "Диафрагма - это купообразный предмет, который вставляется во влагалище женщины для предотвращения беременности.\r\nСтерилизация - это хирургическая процедура, которая предотвращает беременность путем удаления или блокирования яичников у женщин или сперматических протоков у мужчин.\r\n" +
                            "Вагинальные суппозитии - это метод, при котором во влагалище вводятся специальные средства, которые убивают сперматозоиды и предотвращают беременность.\r\nВажно помнить, что каждый метод предохранения имеет свои преимущества и недостатки, и выбор метода должен основываться на индивидуальных потребностях и предпочтениях." +
                            " Также важно использовать методы предохранения правильно и регулярно, чтобы обеспечить максимальную защиту.");
                        break;



                    case "половое образование":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Половое образование - это процесс обучения людей знаниям и навыкам, связанным с сексуальностью, отношениями и репродуктивным здоровьем. " +
                            "Оноключает в себя информацию о физиологии человеческого тела, методах предохранения, защите от инфекций, передающихся половым путем, а также о том, как строитьдоровые отношения и уважать себя и других.\r\n" +
                            "Половое образование может проводиться в школах, университетах, медицинских учреждениях и других местах. Оно может быть представлено в различных форматах, включ лекции, семинары, онлайн-курсы и индивидуальные консультации.\r\n" +
                            "Цель полового образования - помочь людям принимать осознанные решения в отношении своей сексуальной жизни, уменьшить риск нежелательной беременности и защитить от инфекций, передающихся половым путем. " +
                            "Оно также помогает людям понимать, как строить здоровые отношения, уважать себя и других, и справляться с проблемами, связанными с сексуальностью.\r\nВажно помнить, что половое образование должно быть доступно для всех людей, независимо от их возраста, пола, сексуальной ориентации и культурных убеждений. " +
                            "Оно должно быть представлено в объективной и информативной форме, чтобы помочь людям принимать осознанные решения в отношении своей сексуальной жизни.");
                        break;

                    case "месячные":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Месячные (менструация) - это естественный процесс, который происходит у женщин в период полового созревания и сван с ежемесячным отторжением внутреннего слоя матки. " +
                            "Менструация начинается в снем в возрасте 12-13 лет и продолжается до примерно 45-50 лет, когда наступает менопауза.\r\nМенструация обыч длится от 3 до 7 дней и сопровождается кровотечением из влагалища. " +
                            "Во время месячных женщины могут испытывать различные симптомы, такие как боли внизу живота, головные би, усталость, раздражительность и другие.\r\nМесячные являются естественным процессом и не представляют угрозы для здоровья женщины. Однако, если месячные сопровождаются сильными болями или кровотечением, необходимо обратиться к врачу для диагностики и лечения.");
                        break;

                    case "виды отношений":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Моральное насилие - это форма насилия, которая может проявляться в различных формах и воздействовать на психологическое и эмоционаное состояние человека. Некоторые виды морального насилия включают в себя:\r\n" +
                            "Унижение - это форма насилия, при которой человека унижают, оскорбляют или уничижают его достоинство.\r\nИзоляция - это форма насилия, при которой человека изолируют от общества, лишая его возможности общаться с другими людьми.\r\nУгрозы - это форма насилия, приой человека запугивают, угрожают ему или его близким.\r\n" +
                            "Контроль - это форма насилия, при которой человека контролируют, ограничивают его свободу действий и выбора.");
                        break;

                    case "душевное состояние":
                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "Душевные болезни - это широкий спектр психических расстройств, которые могут влиять на мышление, настроение и поведение человека. Ноторые из наиболее распространенных видов душевных болезней включают в себя:\r\n" +
                            "Депрессия - это расстройство настроения, которое характеризуется глубокой печалью, отсутствием интереса к жизни и утратой удовольствия от ранее приятных вещей.\r\nБиполярное расстройство - это психическое заболевание, которое характеризуется периодами эйфории и перодами глубокой депрессии.\r\n" +
                            "Шизофрения - это психическое расстройство, которое влияет на мышление, восприятие и поведение человека. Характеризуется галлюцинациями, бредом и нарушением мышления.\r\nТревожные расстройства - это группа психических заболеваний, которые характеризуются чрезмерной тревогой, страхом и беспокойством.\r\n" +
                            "Расстройства личности - это группа психических заболеваний, которые влияют на способность человека взаодействовать с другими людьми и адаптироваться к окружающей среде.\r\nРасстройства питания - это группа психических заболеваний, которые характеризуются нарушением пищевого поведения и восприятия своего тела.\r\n" +
                            "Зависимости - это психические заболевания, которые связаны с чрезмерным употреблением алкоголя, наркотиков, табака или других веществ.\r\nВажно помнить, что душевные болезни могут иметь различные причины и проявляться в различных формах. Если у вас есть подозрения на наличие душевной болезни, обратитесь к врачу для диагностики и лечения.");
                        break;
                    default:
                        break;

                }

            }
                       

            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message) 
            {
                var message = update.Message;
                var callbackData = update.CallbackQuery;

                switch (message.Text) 
                {
                    case "Психолог":                   
                        await botClient.ForwardMessageAsync(5757636931, update.Message.Chat.Id, 
                            update.Message.MessageId);
                        break;
                        case "Терапевт":
                        await botClient.ForwardMessageAsync(1052213789, update.Message.Chat.Id, update.Message.MessageId);

                        break;


                    case "Адвокат":
                        await botClient.ForwardMessageAsync(530783154, update.Message.Chat.Id, update.Message.MessageId);

                        break;

                    case "Гинеколог":
                        await botClient.ForwardMessageAsync(1020296599, update.Message.Chat.Id, update.Message.MessageId);

                        break;

                    case "Юрист":
                        await botClient.ForwardMessageAsync(1358080376, update.Message.Chat.Id, update.Message.MessageId);

                        break;

                    case "Шелтер":
                        await botClient.ForwardMessageAsync(1095898322, update.Message.Chat.Id, update.Message.MessageId);

                        break;
                }
            }


            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                var callbackData = update.CallbackQuery;
                switch (message.Text)
                {
                    case "Назад":
                        var mainMenu = new ReplyKeyboardMarkup(
                          new[]
                          {
                                           new[]
                                           {
                                              new KeyboardButton("SOS"),
                                              new KeyboardButton("Отношения с родителями "),
                                              new KeyboardButton("Соц.сети и массовое информация ")
                                           },
                                           new[]
                                           {
                                               new KeyboardButton("Секс"),
                                               new KeyboardButton("Как распознать арбузера?")
                                           }
                          });

                        await botClient.SendTextMessageAsync(chatId: message.Chat.Id, text: "дисклеймер",
                      replyMarkup: mainMenu);
                        break;
                    default:

                        break;


                }

            }


        }
    }
}

  




