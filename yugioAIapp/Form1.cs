using System.Net.Http.Json;

namespace yugioAIapp
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient httpClient = new HttpClient();

        private List<Card>? cards;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var url = "https://raw.githubusercontent.com/overworked/yugioh-cards/master/output/cards.json";
                cards = await httpClient.GetFromJsonAsync<List<Card>>(url);
                if (cards != null)
                {
                    listBoxCards.DataSource = cards;
                    listBoxCards.DisplayMember = nameof(Card.name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load cards: {ex.Message}");
            }
        }

        private async void listBoxCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCards.SelectedItem is not Card card)
                return;

            var imageUrl = $"https://raw.githubusercontent.com/Perham94/YGOAnimeMangaHQPics/master/{card.id}.png";
            try
            {
                await using var stream = await httpClient.GetStreamAsync(imageUrl);
                pictureBoxCard.Image = Image.FromStream(stream);
            }
            catch
            {
                pictureBoxCard.Image = null;
            }
        }
    }

    public class Card
    {
        public int id { get; set; }
        public string? name { get; set; }
    }
}
