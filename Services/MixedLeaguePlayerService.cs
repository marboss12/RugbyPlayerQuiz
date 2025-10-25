using RugbyPlayerQuiz.Models;

namespace RugbyPlayerQuiz.Services;

public class MixedLeaguePlayerService
{
    private readonly List<Player> _players;
    private readonly Random _random;

    public MixedLeaguePlayerService(IPlayerService playerService)
    {
        _random = new Random();


        // Берем всех игроков из основного сервиса (Чемпионат России)
        var russianPlayers = playerService.GetPlayers();

        // Добавляем игроков высшей лиги напрямую в этот же список
        var higherLeaguePlayers = new List<Player>
        {
    new Player {Name = "Артур Чинчаладзе", Team = "Высшая лига", Position = "", ImageUrl = "arturchinchaladze.jpg"},
    new Player {Name = "Артем Курочкин", Team = "Высшая лига", Position = "", ImageUrl = "artyomkurochkin.jpg"},
    new Player {Name = "Максим Аскаров", Team = "Высшая лига", Position = "", ImageUrl = "askarovmaksim.png"},
    new Player {Name = "Борис Никишкин", Team = "Высшая лига", Position = "", ImageUrl = "borisnikishkin.jpg"},
    new Player {Name = "Булат Сабиров", Team = "Высшая лига", Position = "", ImageUrl = "bulatsabirov.jpg"},
    new Player {Name = "Булат Шамсутдинов", Team = "Высшая лига", Position = "", ImageUrl = "bulatshamsutdinov.jpg"},
    new Player {Name = "Данил Тарасенок", Team = "Высшая лига", Position = "", ImageUrl = "daniiltarasenok.jpg"},
    new Player {Name = "Денис Фомин", Team = "Высшая лига", Position = "", ImageUrl = "denisfomin.jpg"},
    new Player {Name = "Дмитрий Нагернюк", Team = "Высшая лига", Position = "", ImageUrl = "dmitriynagernuk.jpg"},
    new Player {Name = "Дмитрий Никифоров", Team = "Высшая лига", Position = "", ImageUrl = "dmitriynikiforov.jpg"},
    new Player {Name = "Дмитрий Перов", Team = "Высшая лига", Position = "", ImageUrl = "dmitriyperov.jpg"},
    new Player {Name = "Григорий Померанцев", Team = "Высшая лига", Position = "", ImageUrl = "grigoriypomerantsev.jpg"},
    new Player {Name = "Григорий Уваров", Team = "Высшая лига", Position = "", ImageUrl = "grigoriyuvarov.jpg"},
    new Player {Name = "Игорь Матченя", Team = "Высшая лига", Position = "", ImageUrl = "igormatchenya.jpg"},
    new Player {Name = "Игорь Снисаренко", Team = "Высшая лига", Position = "", ImageUrl = "igorsnisarenko.jpg"},
    new Player {Name = "Илья Алифиров", Team = "Высшая лига", Position = "", ImageUrl = "ilyaalifirov.jpg"},
    new Player {Name = "Илья Гусев", Team = "Высшая лига", Position = "", ImageUrl = "ilyagusev.jpg"},
    new Player {Name = "Илья Назаров", Team = "Высшая лига", Position = "", ImageUrl = "ilyanazarov.jpg"},
    new Player {Name = "Иустин Петрушка", Team = "Высшая лига", Position = "", ImageUrl = "iustinpetrushka.jpg"},
    new Player {Name = "Иван Иванов", Team = "Высшая лига", Position = "", ImageUrl = "ivanovivan.png"},
    new Player {Name = "Александр Касютич", Team = "Высшая лига", Position = "", ImageUrl = "kasjutichaleksandr.png"},
    new Player {Name = "Кирилл Баранов", Team = "Высшая лига", Position = "", ImageUrl = "kirillbaranov.jpg"},
    new Player {Name = "Лука Челидзе", Team = "Высшая лига", Position = "", ImageUrl = "lukachelidze.jpg"},
    new Player {Name = "Максим Максименко", Team = "Высшая лига", Position = "", ImageUrl = "maksimenkomaksim.png"},
    new Player {Name = "Максим Кабанов", Team = "Высшая лига", Position = "", ImageUrl = "maksinkabanov.jpg"},
    new Player {Name = "Максим Малинин", Team = "Высшая лига", Position = "", ImageUrl = "maksinmalinin.jpg"},
    new Player {Name = "Максим Мартынов", Team = "Высшая лига", Position = "", ImageUrl = "maksinmartynov.jpg"},
    new Player {Name = "Александр Маршуба", Team = "Высшая лига", Position = "", ImageUrl = "marshubaaleksandr.png"},
    new Player {Name = "Матвей Цивнель", Team = "Высшая лига", Position = "", ImageUrl = "matveycivnel.jpg"},
    new Player {Name = "Михаил Пучков", Team = "Высшая лига", Position = "", ImageUrl = "mihailpuchkov.jpg"},
    new Player {Name = "Михаил Сидоров", Team = "Высшая лига", Position = "", ImageUrl = "mihailsidorov.png"},
    new Player {Name = "Мирсобиржон Ибрагимов", Team = "Высшая лига", Position = "", ImageUrl = "mirsobirzhonibragimov.jpg"},
    new Player {Name = "Никита Блинцов", Team = "Высшая лига", Position = "", ImageUrl = "nikitablincov.jpg"},
    new Player {Name = "Никита Мозоль", Team = "Высшая лига", Position = "", ImageUrl = "nikitamozol.jpg"},
    new Player {Name = "Никита Шипулин", Team = "Высшая лига", Position = "", ImageUrl = "nikitashipulin.jpg"},
    new Player {Name = "Николай Шматков", Team = "Высшая лига", Position = "", ImageUrl = "nikolayshmatkov.jpg"},
    new Player {Name = "Нико Шаматава", Team = "Высшая лига", Position = "", ImageUrl = "nikoshamatava.jpg"},
    new Player {Name = "Олег Ажнакин", Team = "Высшая лига", Position = "", ImageUrl = "olegazhnakin.jpg"},
    new Player {Name = "Олег Кириллов", Team = "Высшая лига", Position = "", ImageUrl = "olegkirillov.jpg"},
    new Player {Name = "Олег Сидельников", Team = "Высшая лига", Position = "", ImageUrl = "olegsidelnikov.jpg"},
    new Player {Name = "Павел Елизаров", Team = "Высшая лига", Position = "", ImageUrl = "pavelelizarov.jpg"},
    new Player {Name = "Павел Гусаков", Team = "Высшая лига", Position = "", ImageUrl = "pavelgusakov.jpg"},
    new Player {Name = "Павел Косоруков", Team = "Высшая лига", Position = "", ImageUrl = "pavelkosorukov.jpg"},
    new Player {Name = "Павел Жиляев", Team = "Высшая лига", Position = "", ImageUrl = "pavelzhilyaev.jpg"},
    new Player {Name = "Роман Шох", Team = "Высшая лига", Position = "", ImageUrl = "romanshoh.jpg"},
    new Player {Name = "Руслан Бабаев", Team = "Высшая лига", Position = "", ImageUrl = "ruslanbabaev.jpg"},
    new Player {Name = "Руслан Цагараев", Team = "Высшая лига", Position = "", ImageUrl = "ruslancagaraev.jpg"},
    new Player {Name = "Сергей Ефремов", Team = "Высшая лига", Position = "", ImageUrl = "sergeyefremov.jpg"},
    new Player {Name = "Сергей Гресев", Team = "Высшая лига", Position = "", ImageUrl = "sergeygresev.jpg"},
    new Player {Name = "Степан Вознюк", Team = "Высшая лига", Position = "", ImageUrl = "stepanvoznyuk.jpg"},
    new Player {Name = "Виктор Яков", Team = "Высшая лига", Position = "", ImageUrl = "victoryackov.jpg"},
    new Player {Name = "Владимир Мальков", Team = "Высшая лига", Position = "", ImageUrl = "vladimirmalkov.jpg"},
    new Player {Name = "Владислав Жилин", Team = "Высшая лига", Position = "", ImageUrl = "vladislavzhilin.jpg"},
    new Player {Name = "Вячеслав Рыжков", Team = "Высшая лига", Position = "", ImageUrl = "vyacheslavryzhkov.jpg"},
    new Player {Name = "Ярослав Еременко", Team = "Высшая лига", Position = "", ImageUrl = "yaroslaveremenko.jpg"},
    new Player {Name = "Ярослав Гаманов", Team = "Высшая лига", Position = "", ImageUrl = "yaroslavgamanov.jpg"},
    new Player {Name = "Ярослав Сазонов", Team = "Высшая лига", Position = "", ImageUrl = "yaroslavsazonov.jpg"},
    new Player {Name = "Юрий Чижов", Team = "Высшая лига", Position = "", ImageUrl = "yurichizhov.jpg"},
    new Player {Name = "Алексей Быков", Team = "Высшая лига", Position = "", ImageUrl = "alekseybykov.jpg"},
    new Player {Name = "Алексей Пестов", Team = "Высшая лига", Position = "", ImageUrl = "alekseypestov.jpg"},
    new Player {Name = "Андрей Гарбузов", Team = "Высшая лига", Position = "", ImageUrl = "andreygarbuzov.jpg"},
    new Player {Name = "Роберт Априкян", Team = "Высшая лига", Position = "", ImageUrl = "robertaprikyan.jpg"},
    new Player {Name = "Леонид Югов", Team = "Высшая лига", Position = "", ImageUrl = "leonidyugov.png"},
new Player {Name = "Никита Скачко", Team = "Высшая лига", Position = "", ImageUrl = "nikitaskachko.png"},
new Player {Name = "Николай Гилев", Team = "Высшая лига", Position = "", ImageUrl = "nikolaygilev.png"},
new Player {Name = "Родион Скачко", Team = "Высшая лига", Position = "", ImageUrl = "rodionskachko.png"},
new Player {Name = "Сергей Гилев", Team = "Высшая лига", Position = "", ImageUrl = "sergeygilev.png"},
new Player {Name = "Сергей Полежаев", Team = "Высшая лига", Position = "", ImageUrl = "sergeypolezhaev.png"},
new Player {Name = "Степан Дягтерев", Team = "Высшая лига", Position = "", ImageUrl = "stepandyagterev.png"},
new Player {Name = "Владимир Аксенов", Team = "Высшая лига", Position = "", ImageUrl = "vladimiraksenov.png"},
new Player {Name = "Владислав Стариченко", Team = "Высшая лига", Position = "", ImageUrl = "vladislavstarichenko.png"},
new Player {Name = "Юрий Кочетков", Team = "Высшая лига", Position = "", ImageUrl = "yuriikochetkov.png"},
new Player {Name = "Иван Бачурин", Team = "Высшая лига", Position = "", ImageUrl = "bachurinivan.png"},
new Player {Name = "Даниил Степин", Team = "Высшая лига", Position = "", ImageUrl = "daniilstepin.png"},
new Player {Name = "Дмитрий Комиссаров", Team = "Высшая лига", Position = "", ImageUrl = "dmitryikomissarov.png"},
new Player {Name = "Дмитрий Крымов", Team = "Высшая лига", Position = "", ImageUrl = "dmitryikrymov.png"},
new Player {Name = "Илья Фролов", Team = "Высшая лига", Position = "", ImageUrl = "ilyafrolov.png"},
new Player {Name = "Иван Ботов", Team = "Высшая лига", Position = "", ImageUrl = "ivansbotov.png"}

        };


        _players = new List<Player>();
        _players.AddRange(russianPlayers);
        _players.AddRange(higherLeaguePlayers);
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
            [10] = new() { "Эксперт российского регби!", "Знаток всех лиг России", "Настоящий фанат регби" },
            [9] = new() { "Профессиональный скаут", "Разбираетесь во всех лигах", "Перспективный аналитик" },
            [8] = new() { "Опытный болельщик", "Знаете все команды", "Будущий комментатор" },
            [7] = new() { "Хорошее знание лиг", "Стабильный результат", "Потенциальный тренер" },
            [6] = new() { "Неплохой уровень", "Знаете основные команды", "Перспективный игрок" },
            [5] = new() { "Средний результат", "Нужно больше практики", "Изучайте обе лиги" },
            [4] = new() { "Требуется улучшение", "Смотрите матчи обеих лиг", "Новичок в российском регби" },
            [3] = new() { "Слабовато для двух лиг", "Фокусируйтесь на одной лиге", "Нужно учить команды" },
            [2] = new() { "Включайте записи игр", "Начните с основ", "Посещайте больше матчей" },
            [1] = new() { "Вы бывали на регби?", "Изучайте состав команд", "Тренируйтесь усерднее" },
            [0] = new() { "Первый шаг навстречу", "Время изучать регби с нуля", "ДЮСШ ждет вас" }
        };

        var key = score >= 10 ? 10 : score;
        var availableStatuses = statuses[key];
        return availableStatuses[_random.Next(availableStatuses.Count)];
    }
}