using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Globalization;

namespace Parserr
{
    public partial class GoBack2 : Form
    {
        public GoBack2()
        {
            InitializeComponent();
            InitializeContextMenu();
        }
        private int currentPage = 1;
        private string currentLanguage = "";
        private const int maxPages = 20;
        public void InitializeContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
        }
        public async void GoOver_Click(object sender, EventArgs e)
        {
            string language = comboBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(language))
            {
                MessageBox.Show("Укажите язык");
                return;
            }
            currentLanguage = language;
            currentPage = 1;
            await SearchBooks(currentLanguage);
        }
        private void GoBack2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[]
        {
            "Python", "Java", "C#", "JavaScript", "C++", "Go", "Ruby", "PHP", "Rust"
        });
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;//автозаполнение
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;//источник - элементы списка

        }
        private const int booksPerPage = 20; //количество книг на одной странице
        private int displayedPage = 1;

        private void UpdateListViewPage(int page)
        {
            listViewBooks.Items.Clear();
            displayedPage = page;

            // Прямой расчет индексов
            int startIndex = (page - 1) * booksPerPage;
            int endIndex = Math.Min(startIndex + booksPerPage, allBooks.Count);

            // Поочередное добавление элементов
            for (int i = startIndex; i < endIndex; i++)
            {
                listViewBooks.Items.Add(allBooks[i]);
            }
        }


        private List<ListViewItem> allBooks = new List<ListViewItem>();

        public async Task SearchBooks(string language)
        {
            allBooks.Clear();
            listViewBooks.Items.Clear();

            if (!int.TryParse(CountBooks.Text.Trim(), out int targetCount) || targetCount <= 0)
            {
                MessageBox.Show("Количество книг указано не корректно");
                return;
            }

            int loadedCount = 0;
            int currentPage = 1;

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");

            using (var driver = new ChromeDriver(options))
            {
                while (loadedCount < targetCount && currentPage <= maxPages)
                {
                    string url = $"https://www.amazon.com/s?k={Uri.EscapeDataString(language)}&i=stripbooks-intl-ship&page={currentPage}"; //даём ссылку
                    driver.Navigate().GoToUrl(url);//посещаем данную ссылку
                    Thread.Sleep(5000); //засыпаем чтобы страница загрузилась

                    var items = driver.FindElements(By.CssSelector("div.s-main-slot div.s-result-item")); //помещаем все элементы в переменную

                    foreach (var item in items)//проходимся по этим элементам
                    {
                        try
                        {
                            string title = item.FindElement(By.CssSelector("span")).Text;//отбираем название книги

                            string author = "Неизвестен";//вначале автор неизвестен
                            try
                            {
                                var authorLink = item.FindElement(By.CssSelector("a.a-size-base.a-link-normal")); //пытаемся найти автора
                                author = authorLink.Text.Trim();//если нащли автора, записываем в переменную типа стринг
                            }
                            catch { }

                            string price = "Не указана";//изначально цена не указана
                            try
                            {
                                var priceWhole = item.FindElements(By.CssSelector(".a-price-whole"));
                                var priceFraction = item.FindElements(By.CssSelector(".a-price-fraction"));
                                if (priceWhole.Any() && priceFraction.Any())
                                {
                                    price = $"{priceWhole[0].Text}.{priceFraction[0].Text}";
                                }

                            }
                            catch { }

                            string releaseDate = "Не указана";//вначале дата не указана
                            try
                            {
                                var dateElement = item.FindElement(By.CssSelector("span.a-size-base.a-color-secondary.a-text-normal")); //затем мы находим дату
                                releaseDate = dateElement.Text.Trim();//записываем дату в переменную типа стринг
                            }
                            catch { }

                            string rating = "Нет рейтинга";//вначале рейтинг не известен
                            try
                            {
                                var ratingElement = item.FindElement(By.CssSelector("span.a-size-base.s-underline-text"));//затем находим рейтиг
                                rating = ratingElement.Text.Trim();//переписываем рейтинг в переменную типа стринг
                            }
                            catch { }

                            string productUrl = item.FindElement(By.CssSelector("a")).GetAttribute("href");//теперь находим ссылку на товар
                            if (!productUrl.StartsWith("http"))
                                productUrl = "https://www.amazon.com" + productUrl; //делаем ссылку полной

                            var listItem = new ListViewItem(new[] { title, author, rating, releaseDate, price }); //создаём новый элемент списка
                            listItem.Tag = productUrl;//в тег записываем ссылку на товар, чтобы название было кликабельным

                            allBooks.Add(listItem);//перекидываем элемент в общий список
                            loadedCount++;//увеличиваем счётчик загруженных книг

                            if (loadedCount >= targetCount)
                                break; //если достигли нужного количества, выходим из цикла
                        }
                        catch { continue; }
                    }

                    currentPage++;//переходим на следующую страницу
                }

                driver.Quit();//закрываем драйвер
            }

            UpdateListViewPage(1);//

            if (listViewBooks.Items.Count == 0)
            {
                MessageBox.Show("Ни одна книга не найдена!"); //если общий список оказывается пустым, сообщаем об этом
            }
        }
        private void listViewBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewBooks_ItemActivate_1(object sender, EventArgs e)
        {
            if (listViewBooks.SelectedItems.Count > 0)
            {
                string url = listViewBooks.SelectedItems[0].Tag.ToString();//берём ссылку из тега
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true }); //открываем ссылку в браузере
            }
        }


        public decimal ParseDecimal(string text)//метод для парсинга цены
        {
            if (string.IsNullOrEmpty(text) || text == "Не указана")
                return 0m;

            try
            {
                var match = Regex.Match(text, @"(\d+[\.,]\d{1,2})");
                if (match.Success)
                {
                    string numberStr = match.Groups[1].Value.Replace(',', '.'); //заменяем в строке запятую на точку
                    if (decimal.TryParse(numberStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal result))//пытаемся распарсить строку
                    {
                        return result;
                    }
                }

                match = Regex.Match(text, @"(\d+)");//если не получилось, пытаемся найти просто целое число
                if (match.Success && decimal.TryParse(match.Groups[1].Value, out decimal intResult))//пытаемся распарсить строку
                {
                    return intResult;
                }
            }
            catch
            {
            }

            return 0m;
        }

        public DateTime ParseDate(string text)
        {
            return DateTime.TryParse(text, out var date) ? date : DateTime.MinValue; //если не получилось распарсить, возвращаем минимальное значение даты
        }

        public int ParseInt(string text)//метод для парсинга рейтинга
        {
            return int.TryParse(text.Replace(",", "").Split(' ')[0], out var num) ? num : 0;//если не получилось распарсить, возвращаем 0
        }


        private async void Next_Click(object sender, EventArgs e)
        {
            int maxPage = (int)Math.Ceiling(allBooks.Count / (double)booksPerPage);//вычисляем максимальное количество страниц
            if (displayedPage < maxPage)
            {
                UpdateListViewPage(displayedPage + 1);
            }
        }

        private async void Before_Click(object sender, EventArgs e)
        {
            if (displayedPage > 1)
            {
                UpdateListViewPage(displayedPage - 1);
            }
        }

        private int sortColumn = -1;//какой столбец сейчас отсортирован
        private bool sortAscending = true;//по возрастанию или убыванию
        private void listViewBooks_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == sortColumn)
                sortAscending = !sortAscending;
            else
            {
                sortColumn = e.Column;
                sortAscending = true;
            }

            allBooks.Sort((x, y) => //определяем логику сортировки
            {
                string xText = x.SubItems[sortColumn].Text;
                string yText = y.SubItems[sortColumn].Text;

                switch (sortColumn)
                {
                    case 2: // Рейтинг
                        int xRating = ParseInt(xText);
                        int yRating = ParseInt(yText);
                        return sortAscending
                            ? xRating.CompareTo(yRating)
                            : yRating.CompareTo(xRating);

                    case 3: // Дата
                        DateTime xDate = ParseDate(xText);
                        DateTime yDate = ParseDate(yText);
                        return sortAscending
                            ? xDate.CompareTo(yDate)
                            : yDate.CompareTo(xDate);

                    case 4: // Цена
                        decimal xPrice = ParseDecimal(xText);
                        decimal yPrice = ParseDecimal(yText);
                        return sortAscending
                            ? xPrice.CompareTo(yPrice)
                            : yPrice.CompareTo(xPrice);

                    default: // Текст
                        return sortAscending
                            ? string.Compare(xText, yText)
                            : string.Compare(yText, xText);
                }
            });

            UpdateListViewPage(1);
        }

        private void listViewBooks_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
