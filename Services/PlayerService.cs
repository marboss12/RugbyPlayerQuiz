using RugbyPlayerQuiz.Models;
namespace RugbyPlayerQuiz.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly List<Player> _players;
        private readonly Random _random;

        public PlayerService()
        {
            _random = new Random();
            _players = new List<Player>
        {
                new Player
{Name = "Никита Акулинчев", Team = "Металлург", Position = "Замок", ImageUrl = "akulinichev.png"},
new Player
{Name = "Алексей Коворотуша", Team = "Металлург", Position = "", ImageUrl = "kovorotusha.png"},
new Player
{Name = "Илья Саглаев", Team = "Металлург", Position = "", ImageUrl = "saglaev.png"},
new Player
{Name = "Дмитрий Сипкин", Team = "Металлург", Position = "", ImageUrl = "sipkin.png"},
new Player
{Name = "Денис Тальянов", Team = "Металлург", Position = "", ImageUrl = "talyanov.png"},
new Player
{Name = "Мамука Хечикови", Team = "Металлург", Position = "", ImageUrl = "hechikovi.png"},
new Player
{Name = "Георгий Кузин", Team = "Металлург", Position = "", ImageUrl = "kuzin.png"},
new Player
{Name = "Роман Сенченко", Team = "Металлург", Position = "", ImageUrl = "senchenko.png"},
new Player
{Name = "Кирилл Кузьмичев", Team = "Металлург", Position = "", ImageUrl = "kuzmichjov.png"},
new Player
{Name = "Димитрий Кларк Сенкам Йимга", Team = "Металлург", Position = "", ImageUrl = "senkam.png"},
new Player
{Name = "Павел Волощук", Team = "Металлург", Position = "", ImageUrl = "voloshhuk.png"},
new Player
{Name = "Сергей Беленков", Team = "Металлург", Position = "", ImageUrl = "belenkov.png"},
new Player
{Name = "Олег Белобров", Team = "Металлург", Position = "", ImageUrl = "belobrov.png"},
new Player
{Name = "Алексей Бернаучиc", Team = "Металлург", Position = "", ImageUrl = "bernauchis.png"},
new Player
{Name = "Виталий Безматерных", Team = "Металлург", Position = "", ImageUrl = "bezmaternyh.png"},
new Player
{Name = "Алексей Наставшев", Team = "Металлург", Position = "", ImageUrl = "nastavsheva.png"},
new Player
{Name = "Николай Серков", Team = "Металлург", Position = "", ImageUrl = "serkov.png"},
new Player
{Name = "Сайвали Искандаров", Team = "Металлург", Position = "", ImageUrl = "iskandarov.png"},
new Player
{Name = "Кирилл Гавричков", Team = "Металлург", Position = "", ImageUrl = "gavrichkov.png"},
new Player
{Name = "Франсуа Кляйнханс", Team = "Металлург", Position = "", ImageUrl = "klyajnhans.png"},
new Player
{Name = "Александр Новик", Team = "Металлург", Position = "", ImageUrl = "novik.png"},
new Player
{Name = "Никита Шалунов", Team = "Металлург", Position = "", ImageUrl = "shalunov.png"},
new Player
{Name = "Олег Сибиряков", Team = "Металлург", Position = "", ImageUrl = "sibiryakov.png"},
new Player
{Name = "Никита Егоров", Team = "Металлург", Position = "", ImageUrl = "egorovnikita.png"},
new Player
{Name = "Петр Коник", Team = "Металлург", Position = "", ImageUrl = "konik.png"},
new Player
{Name = "Иван Парфёнов", Team = "Металлург", Position = "", ImageUrl = "parfjonov.png"},
new Player
{Name = "Семен Гарманов", Team = "Металлург", Position = "", ImageUrl = "garmanov.png"},
new Player {Name = "Алексей Бурдин", Team = "Стрела - Ак Барс", Position = "Хукер", ImageUrl = "burdin.png"},
new Player {Name = "Магомед Давудов", Team = "Стрела - Ак Барс", Position = "Столб", ImageUrl = "davudovm.png"},
new Player {Name = "Шамиль Давудов", Team = "Стрела - Ак Барс", Position = "Столб", ImageUrl = "davudovs.png"},
new Player {Name = "Герман Давыдов", Team = "Стрела - Ак Барс", Position = "Замок", ImageUrl = "davydovg.png"},
new Player {Name = "Антон Дроздов", Team = "Стрела - Ак Барс", Position = "Фланкер", ImageUrl = "drozdov.png"},
new Player {Name = "Богдан Федотко", Team = "Стрела - Ак Барс", Position = "Восьмой", ImageUrl = "fedotko.png"},
new Player {Name = "Тагир Гаджиев", Team = "Стрела - Ак Барс", Position = "Центровой", ImageUrl = "gadzhiev.png"},
new Player {Name = "Айдар Гафаров", Team = "Стрела - Ак Барс", Position = "Фулбэк", ImageUrl = "gafarov.png"},
new Player {Name = "Дин Гордон", Team = "Стрела - Ак Барс", Position = "Флай-хав", ImageUrl = "gordon.png"},
new Player {Name = "Омари Гриняев", Team = "Стрела - Ак Барс", Position = "Скрам-хав", ImageUrl = "grinyaev.png"},
new Player {Name = "Степан Хохлов", Team = "Стрела - Ак Барс", Position = "Винг", ImageUrl = "hohlov.png"},
new Player {Name = "Деон Карстенс", Team = "Стрела - Ак Барс", Position = "Винг", ImageUrl = "karstens.png"},
new Player {Name = "Андрей Карзанов", Team = "Стрела - Ак Барс", Position = "Центровой", ImageUrl = "karzanov.png"},
new Player {Name = "Николай Казаликашвили", Team = "Стрела - Ак Барс", Position = "Проп", ImageUrl = "kazalikashvili.png"},
new Player {Name = "Рикерт Корфф", Team = "Стрела - Ак Барс", Position = "Фланкер", ImageUrl = "korff.png"},
new Player {Name = "Эдмунд Людик", Team = "Стрела - Ак Барс", Position = "Фулбэк", ImageUrl = "ljudik.png"},
new Player {Name = "Якобус Мараис", Team = "Стрела - Ак Барс", Position = "Флай-хав", ImageUrl = "marais.png"},
new Player {Name = "Иван Нежданов", Team = "Стрела - Ак Барс", Position = "Замок", ImageUrl = "nezhdanov.png"},
new Player {Name = "Владислав Перестяк", Team = "Стрела - Ак Барс", Position = "Проп", ImageUrl = "perestyak.png"},
new Player {Name = "Арсений Петрушинин", Team = "Стрела - Ак Барс", Position = "Столб", ImageUrl = "petrushinin.png"},
new Player {Name = "Артем Радченко", Team = "Стрела - Ак Барс", Position = "Скрам-хав", ImageUrl = "radchenko.png"},
new Player {Name = "Роман Рощин", Team = "Стрела - Ак Барс", Position = "Фланкер", ImageUrl = "roshhin.png"},
new Player {Name = "Максим Шевцов", Team = "Стрела - Ак Барс", Position = "Винг", ImageUrl = "shevcov.png"},
new Player {Name = "Владислав Созонов", Team = "Стрела - Ак Барс", Position = "Замок", ImageUrl = "sozonov.png"},
new Player {Name = "Роберт Сутидзе", Team = "Стрела - Ак Барс", Position = "Проп", ImageUrl = "sutidze.png"},
new Player {Name = "Антон Сычев", Team = "Стрела - Ак Барс", Position = "Центровой", ImageUrl = "sychev.png"},
new Player {Name = "Станислав Тимошенко", Team = "Стрела - Ак Барс", Position = "Фулбэк", ImageUrl = "timoshenko.png"},
new Player {Name = "Евгений Ткаченко", Team = "Стрела - Ак Барс", Position = "Винг", ImageUrl = "tkachenko.png"},
new Player {Name = "Йоханнес Тромп", Team = "Стрела - Ак Барс", Position = "Центровой", ImageUrl = "tromp.png"},
new Player {Name = "Никита Вавилин", Team = "Стрела - Ак Барс", Position = "Фланкер", ImageUrl = "vavilin.png"},
new Player {Name = "Дамеон Вентер", Team = "Стрела - Ак Барс", Position = "Хукер", ImageUrl = "venter.png"},
new Player {Name = "Григорий Войтенко", Team = "Стрела - Ак Барс", Position = "Столб", ImageUrl = "vojtenko.png"},
new Player {Name = "Гиорги Закашвили", Team = "Стрела - Ак Барс", Position = "Замок", ImageUrl = "zakashvili.png"},
new Player {Name = "Виталий Живатов", Team = "Стрела - Ак Барс", Position = "Скрам-хав", ImageUrl = "zhivatov.png"},
new Player {Name = "Егор Зыков", Team = "Стрела - Ак Барс", Position = "Восьмой", ImageUrl = "zykov.png"},

new Player {Name = "Илья Даценко", Team = "Слава Москва", Position = "Центровой", ImageUrl = "dacenko.jpg"},
new Player {Name = "Иван Дорофеев", Team = "Слава Москва", Position = "Фланкер", ImageUrl = "dorofeev.jpg"},
new Player {Name = "Вадим Егоров", Team = "Слава Москва", Position = "Фулбэк", ImageUrl = "egorov.jpg"},
new Player {Name = "Лейтон Экстин", Team = "Слава Москва", Position = "Винг", ImageUrl = "exteen.jpg"},
new Player {Name = "Глеб Фарков", Team = "Слава Москва", Position = "Проп", ImageUrl = "farkov.jpg"},
new Player {Name = "Игорь Федоров", Team = "Слава Москва", Position = "Замок", ImageUrl = "fedorov.jpg"},
new Player {Name = "Владимир Гераськин", Team = "Слава Москва", Position = "Столб", ImageUrl = "geraskin.jpg"},
new Player {Name = "Герман Годлюк", Team = "Слава Москва", Position = "Скрам-хав", ImageUrl = "godluk.jpg"},
new Player {Name = "Кирилл Голосницкий", Team = "Слава Москва", Position = "Центровой", ImageUrl = "golos.png"},
new Player {Name = "Михаил Грачев", Team = "Слава Москва", Position = "Флай-хав", ImageUrl = "grachev.jpg"},
new Player {Name = "Болдуин Хансен", Team = "Слава Москва", Position = "Восьмой", ImageUrl = "hansen.jpg"},
new Player {Name = "Максим Хильчук", Team = "Слава Москва", Position = "Винг", ImageUrl = "hilchuk.jpg"},
new Player {Name = "Андрей Игрецов", Team = "Слава Москва", Position = "Фланкер", ImageUrl = "igrecov.jpg"},
new Player {Name = "Александр Кабанов", Team = "Слава Москва", Position = "Замок", ImageUrl = "kabanov.jpg"},
new Player {Name = "Леонид Калинин", Team = "Слава Москва", Position = "Центровой", ImageUrl = "kalinin.jpg"},
new Player {Name = "Олег Киносьян", Team = "Слава Москва", Position = "Винг", ImageUrl = "kinosyan.jpg"},
new Player {Name = "Борис Концелидзе", Team = "Слава Москва", Position = "Проп", ImageUrl = "koncelidze.jpg"},
new Player {Name = "Сергей Козлов", Team = "Слава Москва", Position = "Столб", ImageUrl = "kozlov.jpg"},
new Player {Name = "Даниил Круглик", Team = "Слава Москва", Position = "Скрам-хав", ImageUrl = "kruglik.jpg"},
new Player {Name = "Владислав Лесников", Team = "Слава Москва", Position = "Фланкер", ImageUrl = "lesnikov.jpg"},
new Player {Name = "Владимир Левый", Team = "Слава Москва", Position = "Фулбэк", ImageUrl = "leviy.jpg"},
new Player {Name = "Кирилл Лыков", Team = "Слава Москва", Position = "Восьмой", ImageUrl = "lykov.jpg"},
new Player {Name = "Арноут Малербе", Team = "Слава Москва", Position = "Замок", ImageUrl = "malerbe.jpg"},
new Player {Name = "Евгений Мишечкин", Team = "Слава Москва", Position = "Флай-хав", ImageUrl = "mishechkin.jpg"},
new Player {Name = "Вадим Мочалин", Team = "Слава Москва", Position = "Хукер", ImageUrl = "mochalin.jpg"},
new Player {Name = "Антон Наставшев", Team = "Слава Москва", Position = "Проп", ImageUrl = "nastavshev.jpg"},
new Player {Name = "Михаил Панкратов", Team = "Слава Москва", Position = "Винг", ImageUrl = "pankratov.jpg"},
new Player {Name = "Дмитрий Пархоменко", Team = "Слава Москва", Position = "Центровой", ImageUrl = "parhomenko.jpg"},
new Player {Name = "Сергей Перехода", Team = "Слава Москва", Position = "Фланкер", ImageUrl = "perehoda.jpg"},
new Player {Name = "Николай Почечуев", Team = "Слава Москва", Position = "Столб", ImageUrl = "pochechuev.jpg"},
new Player {Name = "Даниил Погодаев", Team = "Слава Москва", Position = "Винг", ImageUrl = "pogodaev.png"},
new Player {Name = "Денис Райко", Team = "Слава Москва", Position = "Фулбэк", ImageUrl = "rayko.jpg"},
new Player {Name = "Джонатан Ренсбург", Team = "Слава Москва", Position = "Замок", ImageUrl = "rensburg.jpg"},
new Player {Name = "Даниил Рябцев", Team = "Слава Москва", Position = "Скрам-хав", ImageUrl = "ryabcev.jpg"},
new Player {Name = "Артем Рыбаулин", Team = "Слава Москва", Position = "Флай-хав", ImageUrl = "rybaulin.jpg"},
new Player {Name = "Рамис Сафаров", Team = "Слава Москва", Position = "Винг", ImageUrl = "safarov.jpg"},
new Player {Name = "Нодари Самхарадзе", Team = "Слава Москва", Position = "Проп", ImageUrl = "samharadze.jpg"},
new Player {Name = "Даниил Шарабуркин", Team = "Слава Москва", Position = "Центровой", ImageUrl = "sharaburkin.jpg"},
new Player {Name = "Гиорги Схиртладзе", Team = "Слава Москва", Position = "Хукер", ImageUrl = "shirtladze.jpg"},
new Player {Name = "Павел Штейзель", Team = "Слава Москва", Position = "Фланкер", ImageUrl = "shteyzel.jpg"},
new Player {Name = "Савелий Слабодкин", Team = "Слава Москва", Position = "Восьмой", ImageUrl = "slabodkin.jpg"},
new Player {Name = "Даниил Солдатов", Team = "Слава Москва", Position = "Столб", ImageUrl = "soldatov.jpg"},
new Player {Name = "Денис Степин", Team = "Слава Москва", Position = "Винг", ImageUrl = "stepin.jpg"},
new Player {Name = "Николози Сухашвили", Team = "Слава Москва", Position = "Проп", ImageUrl = "suhashvili.jpg"},
new Player {Name = "Морне Юбер", Team = "Слава Москва", Position = "Центровой", ImageUrl = "uber.jpg"},
new Player {Name = "Алишан Умаров", Team = "Слава Москва", Position = "Флай-хав", ImageUrl = "umarov.jpg"},
new Player {Name = "Вадим Егоров", Team = "Слава Москва", Position = "Фулбэк", ImageUrl = "vadegorov.jpg"},
new Player {Name = "Брендон Вилки", Team = "Слава Москва", Position = "Замок", ImageUrl = "vilki.jpg"},
new Player {Name = "Кортни Виннаар", Team = "Слава Москва", Position = "Винг", ImageUrl = "vinnar.jpg"},
new Player {Name = "Богдан Виноградов", Team = "Слава Москва", Position = "Скрам-хав", ImageUrl = "vinogradov.jpg"},
new Player {Name = "Гюнтер Янсе Ван Вюрен", Team = "Слава Москва", Position = "Фланкер", ImageUrl = "vuuren.jpg"},
new Player {Name = "Роман Журавлев", Team = "Слава Москва", Position = "Восьмой", ImageUrl = "zhuravlev.jpg"},
new Player {Name = "Игорь Абрамов", Team = "Слава Москва", Position = "Хукер", ImageUrl = "abramov.jpg"},
new Player {Name = "Егор Алексеев", Team = "Слава Москва", Position = "Столб", ImageUrl = "alekseev.jpg"},
new Player {Name = "Николай Балесков", Team = "Слава Москва", Position = "Центровой", ImageUrl = "baleskov.jpg"},
new Player {Name = "Джейден Барон", Team = "Слава Москва", Position = "Флай-хав", ImageUrl = "baron.jpg"},
new Player {Name = "Ян Баженов", Team = "Слава Москва", Position = "Замок", ImageUrl = "bazhenov.jpg"},
new Player {Name = "Максим Берцов", Team = "Слава Москва", Position = "Фланкер", ImageUrl = "bercov.jpg"},
new Player {Name = "Даниил Березовский", Team = "Слава Москва", Position = "Винг", ImageUrl = "berezovskiy.jpg"},
new Player {Name = "Роман Чекалин", Team = "Слава Москва", Position = "Скрам-хав", ImageUrl = "chekalin.jpg"},
new Player {Name = "Иван Чепрага", Team = "Слава Москва", Position = "Проп", ImageUrl = "chepraga.jpg"},

new Player {Name = "Александр Агеев", Team = "ВВА Подмосковье", Position = "Центровой", ImageUrl = "ageev.jpg"},
new Player {Name = "Никита Арлашов", Team = "ВВА Подмосковье", Position = "Фланкер", ImageUrl = "arlashov.jpg"},
new Player {Name = "Илья Бабаев", Team = "ВВА Подмосковье", Position = "Проп", ImageUrl = "babaev.jpg"},
new Player {Name = "Александр Давыдов", Team = "ВВА Подмосковье", Position = "Замок", ImageUrl = "davydov.jpg"},
new Player {Name = "Дмитрий Дрождин", Team = "ВВА Подмосковье", Position = "Скрам-хав", ImageUrl = "drozhdin.jpg"},
new Player {Name = "Джурабек Джураев", Team = "ВВА Подмосковье", Position = "Столб", ImageUrl = "dzhuraev.jpg"},
new Player {Name = "Александр Иванов", Team = "ВВА Подмосковье", Position = "Фулбэк", ImageUrl = "ivanov.jpg"},
new Player {Name = "Владислав Капустянский", Team = "ВВА Подмосковье", Position = "Замок", ImageUrl = "kapusta.jpg"},
new Player {Name = "Евгений Кароннов", Team = "ВВА Подмосковье", Position = "Винг", ImageUrl = "karonnov.jpg"},
new Player {Name = "Александр Казаков", Team = "ВВА Подмосковье", Position = "Центровой", ImageUrl = "kazakov.jpg"},
new Player {Name = "Иван Кравцов", Team = "ВВА Подмосковье", Position = "Флай-хав", ImageUrl = "kravtsov.jpg"},
new Player {Name = "Даниил Крылаткин", Team = "ВВА Подмосковье", Position = "Винг", ImageUrl = "krylatkin.jpg"},
new Player {Name = "Егор Кулешов", Team = "ВВА Подмосковье", Position = "Фланкер", ImageUrl = "kuleshov.jpg"},
new Player {Name = "Виктор Кузнецов", Team = "ВВА Подмосковье", Position = "Восьмой", ImageUrl = "kuznetsov.jpg"},
new Player {Name = "Сергей Лютиков", Team = "ВВА Подмосковье", Position = "Столб", ImageUrl = "lutikov.jpg"},
new Player {Name = "Сархан Марданов", Team = "ВВА Подмосковье", Position = "Хукер", ImageUrl = "mardanov.jpg"},
new Player {Name = "Сергей Мотов", Team = "ВВА Подмосковье", Position = "Центровой", ImageUrl = "motov.jpg"},
new Player {Name = "Сергей Мысин", Team = "ВВА Подмосковье", Position = "Фулбэк", ImageUrl = "mysin.jpg"},
new Player {Name = "Александр Никитин", Team = "ВВА Подмосковье", Position = "Проп", ImageUrl = "nikitin.jpg"},
new Player {Name = "Кирилл Панарин", Team = "ВВА Подмосковье", Position = "Винг", ImageUrl = "panarin.jpg"},
new Player {Name = "Иван Покарев", Team = "ВВА Подмосковье", Position = "Скрам-хав", ImageUrl = "pokarev.jpg"},
new Player {Name = "Илья Шаповалов", Team = "ВВА Подмосковье", Position = "Фланкер", ImageUrl = "shapovalov.jpg"},
new Player {Name = "Станислав Шмелев", Team = "ВВА Подмосковье", Position = "Замок", ImageUrl = "shmelev.jpg"},
new Player {Name = "Дмитрий Сиделев", Team = "ВВА Подмосковье", Position = "Флай-хав", ImageUrl = "sidelev.jpg"},
new Player {Name = "Алексей Скобиола", Team = "ВВА Подмосковье", Position = "Восьмой", ImageUrl = "skobiola.jpg"},
new Player {Name = "Кирилл Собачкин", Team = "ВВА Подмосковье", Position = "Хукер", ImageUrl = "sobachkin.jpg"},
new Player {Name = "Грант Товмасян", Team = "ВВА Подмосковье", Position = "Винг", ImageUrl = "tovmasyan.jpg"},
new Player {Name = "Сергей Тришин", Team = "ВВА Подмосковье", Position = "Проп", ImageUrl = "trishin.jpg"},
new Player {Name = "Михаил Жлутков", Team = "ВВА Подмосковье", Position = "Центровой", ImageUrl = "zhlutkov.jpg"},

new Player {Name = "Ислам Абдулкадиров", Team = "Красный Яр", Position = "Центровой", ImageUrl = "abdulkadirov.png"},
new Player {Name = "Кирилл Алюк", Team = "Красный Яр", Position = "Фланкер", ImageUrl = "aljuk.png"},
new Player {Name = "Виктор Архип", Team = "Енисей-СТМ", Position = "Проп", ImageUrl = "arhip.png"},
new Player {Name = "Кылычбек Азанов", Team = "Енисей-СТМ", Position = "Скрам-хав", ImageUrl = "azanov.png"},
new Player {Name = "Бека Мамрикишвили", Team = "Енисей-СТМ", Position = "Винг", ImageUrl = "beka.png"},
new Player {Name = "Артем Борзенков", Team = "Енисей-СТМ", Position = "Замок", ImageUrl = "borzenkov.png"},
new Player {Name = "Алексей Цейцин", Team = "Енисей-СТМ", Position = "Флай-хав", ImageUrl = "cejcin.png"},
new Player {Name = "Владимир Чабан", Team = "Енисей-СТМ", Position = "Столб", ImageUrl = "chaban.png"},
new Player {Name = "Денис Цурупа", Team = "Енисей-СТМ", Position = "Хукер", ImageUrl = "curupa.png"},
new Player {Name = "Эрл Даури", Team = "Енисей-СТМ", Position = "Восьмой", ImageUrl = "dauri.png"},
new Player {Name = "Василий Дорофеев", Team = "Енисей-СТМ", Position = "Фулбэк", ImageUrl = "dorofeevvas.png"},
new Player {Name = "Павел Фиц", Team = "Енисей-СТМ", Position = "Центровой", ImageUrl = "ficp.png"},
new Player {Name = "Степан Фиц", Team = "Енисей-СТМ", Position = "Винг", ImageUrl = "fics.png"},
new Player {Name = "Евгений Гольштейн", Team = "Енисей-СТМ", Position = "Фланкер", ImageUrl = "golshtejn.png"},
new Player {Name = "Дмитрий Гриценко", Team = "Енисей-СТМ", Position = "Замок", ImageUrl = "gricenko.png"},
new Player {Name = "Гуга Хантадзе", Team = "Енисей-СТМ", Position = "Проп", ImageUrl = "hantadze.png"},
new Player {Name = "Роман Ходин", Team = "Енисей-СТМ", Position = "Столб", ImageUrl = "hodin.png"},
new Player {Name = "Александр Худяков", Team = "Енисей-СТМ", Position = "Скрам-хав", ImageUrl = "hudyakov.png"},
new Player {Name = "Александр Ильин", Team = "Енисей-СТМ", Position = "Фулбэк", ImageUrl = "ilin.png"},
new Player {Name = "Александр Кадиров", Team = "Енисей-СТМ", Position = "Винг", ImageUrl = "kadirov.png"},
new Player {Name = "Дмитрий Кузеро", Team = "Енисей-СТМ", Position = "Центровой", ImageUrl = "kuzero.png"},
new Player {Name = "Владислав Лазарев", Team = "Енисей-СТМ", Position = "Флай-хав", ImageUrl = "lazarev.png"},
new Player {Name = "Данил Лосенков", Team = "Енисей-СТМ", Position = "Хукер", ImageUrl = "losenkov.png"},
new Player {Name = "Анеле Лунгиса", Team = "Енисей-СТМ", Position = "Восьмой", ImageUrl = "lungisa.png"},
new Player {Name = "Шамиль Магомедов", Team = "Енисей-СТМ", Position = "Фланкер", ImageUrl = "magomedov.png"},
new Player {Name = "Валерий Морозов", Team = "Енисей-СТМ", Position = "Проп", ImageUrl = "morozov.png"},
new Player {Name = "Даниил Николаев", Team = "Енисей-СТМ", Position = "Замок", ImageUrl = "nikolaev.png"},
new Player {Name = "Гор Петросян", Team = "Енисей-СТМ", Position = "Винг", ImageUrl = "petrosyan.png"},
new Player {Name = "Данил Попов", Team = "Енисей-СТМ", Position = "Столб", ImageUrl = "popov.png"},
new Player {Name = "Лоуренс Преториус", Team = "Енисей-СТМ", Position = "Флай-хав", ImageUrl = "pretorius.png"},
new Player {Name = "Евгений Пронин", Team = "Енисей-СТМ", Position = "Скрам-хав", ImageUrl = "pronin.png"},
new Player {Name = "Михаел Ратиашвили", Team = "Енисей-СТМ", Position = "Проп", ImageUrl = "ratiashvili.png"},
new Player {Name = "Йоханнес Эдриан Ретиф", Team = "Енисей-СТМ", Position = "Центровой", ImageUrl = "retif.png"},
new Player {Name = "Никита Романов", Team = "Енисей-СТМ", Position = "Фулбэк", ImageUrl = "romanov.png"},
new Player {Name = "Антон Рудой", Team = "Енисей-СТМ", Position = "Восьмой", ImageUrl = "rudoj.png"},
new Player {Name = "Хушнуд Сангинов", Team = "Енисей-СТМ", Position = "Фланкер", ImageUrl = "sanginov.png"},
new Player {Name = "Даниил Семенов", Team = "Енисей-СТМ", Position = "Замок", ImageUrl = "semjonov.png"},
new Player {Name = "Николай Семенов", Team = "Енисей-СТМ", Position = "Хукер", ImageUrl = "semjonovn.png"},
new Player {Name = "Андрей Шакура", Team = "Енисей-СТМ", Position = "Винг", ImageUrl = "shakura.png"},
new Player {Name = "Дилан Смит", Team = "Енисей-СТМ", Position = "Центровой", ImageUrl = "smit.png"},
new Player {Name = "Дмитрий Сухин", Team = "Енисей-СТМ", Position = "Столб", ImageUrl = "suhin.png"},
new Player {Name = "Джейсон Таумалоло", Team = "Красный Яр", Position = "Проп", ImageUrl = "taumalolo.png"},
new Player {Name = "Буркуталы Тойчуев", Team = "Красный Яр", Position = "Фланкер", ImageUrl = "tojchuev.png"},

new Player {Name = "Де Ан Аккерман", Team = "Красный Яр", Position = "Центровой", ImageUrl = "akkerman.png"},
new Player {Name = "Никита Барышников", Team = "Красный Яр", Position = "Фланкер", ImageUrl = "baryshnikov.png"},
new Player {Name = "Александр Белослудцев", Team = "Красный Яр", Position = "Проп", ImageUrl = "belosludtsev.png"},
new Player {Name = "Азамат Битиев", Team = "Красный Яр", Position = "Замок", ImageUrl = "bitiev.png"},
new Player {Name = "Александр Будыченко", Team = "Красный Яр", Position = "Скрам-хав", ImageUrl = "budychenko.png"},
new Player {Name = "Никита Чурашов", Team = "Красный Яр", Position = "Столб", ImageUrl = "churashov.png"},
new Player {Name = "Карел Дю Пре", Team = "Красный Яр", Position = "Флай-хав", ImageUrl = "dupre.png"},
new Player {Name = "Евгений Елгин", Team = "Красный Яр", Position = "Винг", ImageUrl = "elgin.png"},
new Player {Name = "Франсуа Эстерхейзен", Team = "Красный Яр", Position = "Фулбэк", ImageUrl = "esterheisen.png"},
new Player {Name = "Максим Гаргалык", Team = "Красный Яр", Position = "Хукер", ImageUrl = "gargalyk.png"},
new Player {Name = "Рамиль Гайсин", Team = "Красный Яр", Position = "Центровой", ImageUrl = "gaysin.png"},
new Player {Name = "Дмитрий Герасимов", Team = "Красный Яр", Position = "Восьмой", ImageUrl = "gerasimov.png"},
new Player {Name = "Максим Кемаев", Team = "Красный Яр", Position = "Фланкер", ImageUrl = "kemaev.png"},
new Player {Name = "Виталий Климов", Team = "Красный Яр", Position = "Винг", ImageUrl = "klimov.png"},
new Player {Name = "Виктор Кононов", Team = "Красный Яр", Position = "Проп", ImageUrl = "kononov.png"},
new Player {Name = "Дмитрий Кротов", Team = "Красный Яр", Position = "Замок", ImageUrl = "krotov.png"},
new Player {Name = "Рашид Магомедсаидов", Team = "Красный Яр", Position = "Столб", ImageUrl = "magomed.png"},
new Player {Name = "Антон Макаренко", Team = "Красный Яр", Position = "Скрам-хав", ImageUrl = "makarenko.png"},
new Player {Name = "Евгений Малышкин", Team = "Красный Яр", Position = "Флай-хав", ImageUrl = "malyshkin.png"},
new Player {Name = "Тимур Маслов", Team = "Красный Яр", Position = "Фулбэк", ImageUrl = "maslov.png"},
new Player {Name = "Давит Месхи", Team = "Красный Яр", Position = "Центровой", ImageUrl = "meshi.png"},
new Player {Name = "Алексей Михальцов", Team = "Красный Яр", Position = "Хукер", ImageUrl = "mihaltsov.png"},
new Player {Name = "Виталий Немцев", Team = "Красный Яр", Position = "Фланкер", ImageUrl = "nemtsev.png"},
new Player {Name = "Данил Онищенко", Team = "Красный Яр", Position = "Винг", ImageUrl = "onischenko.png"},
new Player {Name = "Николас Оостхузен", Team = "Красный Яр", Position = "Восьмой", ImageUrl = "oosthoosen.png"},
new Player {Name = "Данил Орлик", Team = "Красный Яр", Position = "Проп", ImageUrl = "orlik.png"},
new Player {Name = "Мартинус Йоханнес Пельцер", Team = "Красный Яр", Position = "Замок", ImageUrl = "pelcer.png"},
new Player {Name = "Артем Ровский", Team = "Красный Яр", Position = "Столб", ImageUrl = "rovskiy.png"},
new Player {Name = "Ефим Рябищук", Team = "Красный Яр", Position = "Скрам-хав", ImageUrl = "ryabischuk.png"},
new Player {Name = "Алексей Щербань", Team = "Красный Яр", Position = "Флай-хав", ImageUrl = "scherban.png"},
new Player {Name = "Степан Серяков", Team = "Красный Яр", Position = "Фулбэк", ImageUrl = "seryakov.png"},
new Player {Name = "Данил Шумерин", Team = "Красный Яр", Position = "Центровой", ImageUrl = "shumerin.png"},
new Player {Name = "Денис Симпликевич", Team = "Красный Яр", Position = "Винг", ImageUrl = "simplikevich.png"},
new Player {Name = "Ульрих Стендер", Team = "Красный Яр", Position = "Хукер", ImageUrl = "stender.png"},
new Player {Name = "Андрей Темнов", Team = "Красный Яр", Position = "Фланкер", ImageUrl = "temnov.png"},
new Player {Name = "Владимир Тонкошкуров", Team = "Красный Яр", Position = "Восьмой", ImageUrl = "tonkoshkurov.png"},
new Player {Name = "Константин Узунов", Team = "Красный Яр", Position = "Проп", ImageUrl = "uzunov.png"},
new Player {Name = "Питер Якобс", Team = "Красный Яр", Position = "Замок", ImageUrl = "yakobs.png"},

new Player {Name = "Арчил Абесадзе", Team = "Локомотив", Position = "Центровой", ImageUrl = "abesadze.jpg"},
new Player {Name = "Алексей Башев", Team = "Локомотив", Position = "Центровой", ImageUrl = "bashev.png"},
new Player {Name = "Ника Цирекидзе", Team = "Локомотив", Position = "Центровой", ImageUrl = "czirekidze.png"},
new Player {Name = "Лев Дерксен", Team = "Локомотив", Position = "Центровой", ImageUrl = "derksen.png"},
new Player {Name = "Аллен Стефан Де Вит", Team = "Локомотив", Position = "Центровой", ImageUrl = "devit.png"},
new Player {Name = "Джереми Джордаан", Team = "Локомотив", Position = "Центровой", ImageUrl = "dzhordaan.png"},
new Player {Name = "Никита Филиппов", Team = "Локомотив", Position = "Центровой", ImageUrl = "filippov.png"},
new Player {Name = "Александр Гудок", Team = "Локомотив", Position = "Центровой", ImageUrl = "gudok.png"},
new Player {Name = "Валерий Хлутков", Team = "Локомотив", Position = "Центровой", ImageUrl = "hlutkov.png"},
new Player {Name = "Крис Холлис", Team = "Локомотив", Position = "Центровой", ImageUrl = "hollis.png"},
new Player {Name = "Тамерлан Хубаев", Team = "Локомотив", Position = "Центровой", ImageUrl = "hubaev.png"},
new Player {Name = "Богдан Киреев", Team = "Локомотив", Position = "Центровой", ImageUrl = "kireev.png"},
new Player {Name = "Дмитрий Кровяков", Team = "Локомотив", Position = "Центровой", ImageUrl = "krovyakov.png"},
new Player {Name = "Павел Кураев", Team = "Локомотив", Position = "Центровой", ImageUrl = "kuraev.png"},
new Player {Name = "Магомед Курбанов", Team = "Локомотив", Position = "Центровой", ImageUrl = "kurbanov.png"},
new Player {Name = "Никита Максимов", Team = "Локомотив", Position = "Центровой", ImageUrl = "maksimov.png"},
new Player {Name = "Стефан Малан", Team = "Локомотив", Position = "Центровой", ImageUrl = "malan.png"},
new Player {Name = "Денис Машкин", Team = "Локомотив", Position = "Центровой", ImageUrl = "mashkin.png"},
new Player {Name = "Франко Нодье", Team = "Локомотив", Position = "Центровой", ImageUrl = "node.png"},
new Player {Name = "Иван Овчинников", Team = "Локомотив", Position = "Центровой", ImageUrl = "ovchinnikov.png"},
new Player {Name = "Владимир Подрезов", Team = "Локомотив", Position = "Центровой", ImageUrl = "podrezov.png"},
new Player {Name = "Андрей Поливалов", Team = "Локомотив", Position = "Центровой", ImageUrl = "polivalov.png"},
new Player {Name = "Даниил Потиханов", Team = "Локомотив", Position = "Центровой", ImageUrl = "potihanov.png"},
new Player {Name = "Александр Рябов", Team = "Локомотив", Position = "Центровой", ImageUrl = "ryabov.png"},
new Player {Name = "Сергей Секисов", Team = "Локомотив", Position = "Центровой", ImageUrl = "sekisov.png"},
new Player {Name = "Михаил Смагин", Team = "Локомотив", Position = "Центровой", ImageUrl = "smagin.png"},
new Player {Name = "Павел Сошин", Team = "Локомотив", Position = "Центровой", ImageUrl = "soshin.png"},
new Player {Name = "Денис Сёмин", Team = "Локомотив", Position = "Центровой", ImageUrl = "syomin.png"},
new Player {Name = "Тиаан Ван дер Мерве", Team = "Локомотив", Position = "Центровой", ImageUrl = "vandemerve.png"},
new Player {Name = "Эбнер Ван Ринен", Team = "Локомотив", Position = "Центровой", ImageUrl = "vanrinen.png"},
new Player {Name = "Руди Ван Ройен", Team = "Локомотив", Position = "Центровой", ImageUrl = "vanrojen.png"},
new Player {Name = "Александр Вознюк", Team = "Локомотив", Position = "Центровой", ImageUrl = "voznyuk.png"},
new Player {Name = "Андрей Янюшкин", Team = "Локомотив", Position = "Центровой", ImageUrl = "yanyushkin.png"},
new Player {Name = "Сергей Янюшкин", Team = "Локомотив", Position = "Центровой", ImageUrl = "yanyushkinsergej.png"},
new Player {Name = "Вадим Жарков", Team = "Локомотив", Position = "Центровой", ImageUrl = "zharkov.png"}
            };
        }

    public List<Player> GetPlayers() => _players;

        public Player GetRandomPlayer()
        {
            return _players[_random.Next(_players.Count)];
        }

        public List<Player> GetRandomOptions(Player correctPlayer, int count)
        {
            var options = new List<Player> { correctPlayer };
            var availablePlayers = _players.Where(p => p.Name != correctPlayer.Name).ToList();

            while (options.Count < count && availablePlayers.Count > 0)
            {
                var randomPlayer = availablePlayers[_random.Next(availablePlayers.Count)];
                options.Add(randomPlayer);
                availablePlayers.Remove(randomPlayer);
            }

            return options.OrderBy(x => _random.Next()).ToList();
        }

        public string GetPlayerStatus(int score)
        {
            var statuses = new Dictionary<int, List<string>>
            {
                [10] = new() { "Легенда регби!", "Мэтр мирового регби", "Будущая звезда Кубка Мира", "Вы Игорь Артемьев?"},
                [9] = new() { "Профессиональный регбист", "Ключевой игрок сборной", "Первухин ждет вас на просмотр" },
                [8] = new() { "Перспективный игрок", "Будущий чемпион", "Реализация с краю"},
                [7] = new() { "Любитель регби", "Опытный игрок", "Победитель Финала Четырех"},
                [6] = new() { "Новичок в регби", "Начинающий игрок" , "Тренер Высшей лиги"},
                [5] = new() { "Болельщик", "Собирайтесь в Читу" , "Пляжное регби"},
                [4] = new() { "Нужно практиковаться.", "Посмотрите еще матчи!" , "Фили ваш уровень"},
                [3] = new() { "Слабовато.", "Регби - не ваша тема?" , "Вы не допущены до 3 тайма"},
                [2] = new() { "Просто зритель", "Случайный болельщик", "Попробуйте футбол" },
                [1] = new() { "Попробуй еще раз!", "Может, лучше в шахматы?" },
                [0] = new() { "Это провал.", "ДЮСШ Южное Тушино ждет вас", }
            };

            var key = score >= 10 ? 10 : score;
            var availableStatuses = statuses[key];
            return availableStatuses[_random.Next(availableStatuses.Count)];
        }
    }
}