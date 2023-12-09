//using ScoreApp.scoreDB;
using ScoreApp.univDB;

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

            update();
        }

        void update()
        {
            using (var db = new ScoreDbContext())
            {
                label4.Text = db.Scores.Count().ToString();

                //label9.Text = db.Scores.Sum(p => p.Kor).ToString(); //���� ���� �հ�

                label10.Text = db.Scores.Average(p => p.Kor).ToString(); //���� ���� ���, p => p.Kor�� ���ٽ�

                //db.Scores.//���⼭ �ְ� ���� ����� ���! �̷��� �ؼ� ���ϴ� ���� ����� �� ����.

                label14.Text = db.Scores.Average(p => p.Math).ToString();

                label15.Text = db.Scores.Average(p => p.Eng).ToString();

                label16.Text = db.Scores.OrderByDescending(p => p.Kor).First().Name; //������ ���� ���� �л� �� �̸��� �����´�. OrderByDescending�� �������� ����??

                label18.Text = db.Scores.OrderByDescending(p => p.Kor + p.Eng + p.Math).First().Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new ScoreDbContext())
            {
                db.Scores.Add(new Score()
                {
                    Id = new System.Random().Next(),
                    Name = textBox1.Text,
                    Kor = int.Parse(textBox2.Text),
                    Eng = int.Parse(textBox2.Text),
                    Math = int.Parse(textBox2.Text)
                });
                db.SaveChanges();
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selected = listBox1.SelectedItem as Score;

            if (selected != null)
            {
                if (DialogResult.Yes == MessageBox.Show("���� �����Ͻðڽ��ϱ�?",
                    "���", MessageBoxButtons.YesNo))
                {
                    using (ScoreDbContext context = new ScoreDbContext())
                    {
                        var item = context.Scores.First(p => p.Id == selected.Id);

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
            if (DialogResult.OK == form.ShowDialog())
            {
                try
                {
                    using (ScoreDbContext context = new ScoreDbContext())
                    {
                        context.Scores.Add(form.scoreData);

                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("�����ͺ��̽� ����" + ex.Message);
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
                using (ScoreDbContext context = new ScoreDbContext())
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

            AvgTextBox.Text = ((item.Kor + item.Eng + item.Math) / 3).ToString();
        }

        private void TotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}