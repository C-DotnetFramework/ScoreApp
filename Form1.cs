using ScoreApp.scoreDB;

namespace ScoreApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Retrieve()
        {
            listBox1.Items.Clear();

            using (ScoreDbContext context = new ScoreDbContext())
            {
                var list = context.Scores.ToList();

                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Name";

            Retrieve();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selected = listBox1.SelectedItem as Score;

            if (selected != null)
            {
                if(DialogResult.Yes == MessageBox.Show("정말 삭제하시겠습니까?",
                    "경고", MessageBoxButtons.YesNo))
                {
                    using(ScoreDbContext context = new ScoreDbContext())
                    {
                        var item = 
                            context.Scores.First(p => p.Id == selected.Id);

                        context.Scores.Remove(item);

                        context.SaveChanges();
                    }

                    Retrieve();
                }
            }
                    
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            if(DialogResult.OK == form.ShowDialog())
            {
                try
                {
                    using (ScoreDbContext context = new ScoreDbContext())
                    {
                        context.Scores.Add(form.scoreData);

                        context.SaveChanges();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("데이터베이스 오류" + ex.Message);
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var selected = listBox1.SelectedItem as Score;

            AddForm form = new AddForm();
            form.scoreData = selected;

            if (DialogResult.OK == form.ShowDialog())
            {
                System.Diagnostics.Debug.WriteLine(selected.Id);
                using(ScoreDbContext context = new ScoreDbContext())
                {
                    var item = 
                        context.Scores.First(p => p.Id == selected.Id);

                    item.Id = form.scoreData.Id;
                    item.Name = form.scoreData.Name;
                    item.Kor = form.scoreData.Kor;
                    item.Eng = form.scoreData.Eng;
                    item.Math = form.scoreData.Math;

                    context.SaveChanges();

                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem as Score;

            TotalTextBox.Text = (item.Kor + item.Eng + item.Math).ToString();
        }
    }
}