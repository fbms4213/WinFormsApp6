using System.Text.Json;

namespace MovieApp.Forms;

public partial class MainForm : Form
{
    const string _apikey = "580270e";
    const string _url = $"http://www.omdbapi.com/?apikey={_apikey}&";

    public MainForm()
    {
        InitializeComponent();
    }

    private async void btn_search_Click(object sender, EventArgs e)
    {
        string search = $"{_url}t={txt_search.Text}";
        using HttpClient client = new();


        var jsonResult = await client.GetStringAsync(search);
        var movie = JsonSerializer.Deserialize<Movie>(jsonResult);
        pictureBox1.LoadAsync(movie?.Poster);


        //var jsonResult = client.GetStringAsync(search).Result;

        //var movie = JsonSerializer.Deserialize<Movie>(jsonResult);
        //pictureBox1.Load(movie?.Poster);
    }
}
