using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace _6b6tStatsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void FetchStatsButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a valid username.");
                return;
            }

            statusLabel.Text = "Fetching stats... Please wait.";
            var stats = await FetchStats(username);
            DisplayStats(stats);
        }

        private async Task<System.Collections.Generic.Dictionary<string, (string, string, string)>> FetchStats(string username)
        {
            var url = $"https://www.6b6t.org/en/stats/{username}";
            var stats = new System.Collections.Generic.Dictionary<string, (string, string, string)>();

            try
            {
                using (var client = new HttpClient())
                {
                    var html = await client.GetStringAsync(url);
                    var doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);

                    var rows = doc.DocumentNode.SelectNodes("//tr[td]");
                    if (rows != null)
                    {
                        foreach (var row in rows)
                        {
                            var statName = row.SelectSingleNode(".//p[@class='my-auto']")?.InnerText.Trim();
                            var statValues = row.SelectNodes(".//td")?.Select(td => td.InnerText.Trim()).ToArray();

                            if (statName != null && statValues?.Length >= 3)
                            {
                                stats[statName] = (statValues[1], statValues[2], statValues[3]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching stats: {ex.Message}");
            }

            return stats;
        }

        private void DisplayStats(System.Collections.Generic.Dictionary<string, (string, string, string)> stats)
        {
            statusLabel.Text = "Stats fetched successfully!";

            // Clear existing data
            statsDataGridView.Rows.Clear();

            foreach (var stat in stats)
            {
                statsDataGridView.Rows.Add(stat.Key, stat.Value.Item1, stat.Value.Item2, stat.Value.Item3);
            }
        }
    }
}
