using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text;

namespace курсовая_работаа
{
    public partial class Form2 : Form
    {
        public string SelectedFunction { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateUIForFunction();
        }

        private void UpdateUIForFunction()
        {
            // Скрываем все поля
            HideAllFields();

            // Показываем нужные поля и формулу
            switch (SelectedFunction)
            {
                case "Линейная":
                    lblFormula.Text = "y = k * x + b";
                    ShowField(lblK, txtK);
                    ShowField(lblB, txtB);
                    break;
                case "Квадратичная":
                    lblFormula.Text = "y = a * x² + b * x + c";
                    ShowField(lblA, txtA);
                    ShowField(lblB, txtB);
                    ShowField(lblC, txtC);
                    break;
                case "Кубическая":
                    lblFormula.Text = "y = a * x³ + b * x² + c * x + d";
                    ShowField(lblA, txtA);
                    ShowField(lblB, txtB);
                    ShowField(lblC, txtC);
                    ShowField(lblD, txtD);
                    break;
                case "Синусоида":
                    lblFormula.Text = "y = A * sin(ω * x + φ)";
                    ShowField(lblAmplitude, txtAmplitude);
                    ShowField(lblOmega, txtOmega);
                    ShowField(lblPhi, txtPhi);
                    break;
                case "Косинусоида":
                    lblFormula.Text = "y = A * cos(ω * x + φ)";
                    ShowField(lblAmplitude, txtAmplitude);
                    ShowField(lblOmega, txtOmega);
                    ShowField(lblPhi, txtPhi);
                    break;
                case "Тангенсоида":
                    lblFormula.Text = "y = A * tg(ω * x + φ)";
                    ShowField(lblAmplitude, txtAmplitude);
                    ShowField(lblOmega, txtOmega);
                    ShowField(lblPhi, txtPhi);
                    break;
                case "Экспонента":
                    lblFormula.Text = "y = a * e^(b * x)";
                    ShowField(lblA, txtA);
                    ShowField(lblB, txtB);
                    break;
                case "Логарифмическая":
                    lblFormula.Text = "y = a * ln(x) + b";
                    ShowField(lblA, txtA);
                    ShowField(lblB, txtB);
                    break;
                case "Модуль":
                    lblFormula.Text = "y = k * |x|";
                    ShowField(lblK, txtK);
                    break;
                case "Обратная пропорциональность":
                    lblFormula.Text = "y = k / x";
                    ShowField(lblK, txtK);
                    break;
            }
        }

        private void HideAllFields()
        {
            if (lblK != null) { lblK.Visible = false; txtK.Visible = false; }
            if (lblB != null) { lblB.Visible = false; txtB.Visible = false; }
            if (lblA != null) { lblA.Visible = false; txtA.Visible = false; }
            if (lblC != null) { lblC.Visible = false; txtC.Visible = false; }
            if (lblD != null) { lblD.Visible = false; txtD.Visible = false; }
            if (lblAmplitude != null) { lblAmplitude.Visible = false; txtAmplitude.Visible = false; }
            if (lblOmega != null) { lblOmega.Visible = false; txtOmega.Visible = false; }
            if (lblPhi != null) { lblPhi.Visible = false; txtPhi.Visible = false; }
        }

        private void ShowField(Label label, TextBox textBox)
        {
            if (label != null) label.Visible = true;
            if (textBox != null) textBox.Visible = true;
        }

        // Вычисление значения функции в точке x
        private double CalculateY(double x)
        {
            try
            {
                switch (SelectedFunction)
                {
                    case "Линейная":
                        double k = double.Parse(txtK.Text);
                        double b = double.Parse(txtB.Text);
                        return k * x + b;

                    case "Квадратичная":
                        double a = double.Parse(txtA.Text);
                        double b2 = double.Parse(txtB.Text);
                        double c = double.Parse(txtC.Text);
                        return a * x * x + b2 * x + c;

                    case "Кубическая":
                        double a3 = double.Parse(txtA.Text);
                        double b3 = double.Parse(txtB.Text);
                        double c3 = double.Parse(txtC.Text);
                        double d = double.Parse(txtD.Text);
                        return a3 * x * x * x + b3 * x * x + c3 * x + d;

                    case "Синусоида":
                        double A = double.Parse(txtAmplitude.Text);
                        double omega = double.Parse(txtOmega.Text);
                        double phi = double.Parse(txtPhi.Text);
                        return A * Math.Sin(omega * x + phi);

                    case "Косинусоида":
                        double A2 = double.Parse(txtAmplitude.Text);
                        double omega2 = double.Parse(txtOmega.Text);
                        double phi2 = double.Parse(txtPhi.Text);
                        return A2 * Math.Cos(omega2 * x + phi2);

                    case "Тангенсоида":
                        double A3 = double.Parse(txtAmplitude.Text);
                        double omega3 = double.Parse(txtOmega.Text);
                        double phi3 = double.Parse(txtPhi.Text);
                        return A3 * Math.Tan(omega3 * x + phi3);

                    case "Экспонента":
                        double aExp = double.Parse(txtA.Text);
                        double bExp = double.Parse(txtB.Text);
                        return aExp * Math.Exp(bExp * x);

                    case "Логарифмическая":
                        double aLog = double.Parse(txtA.Text);
                        double bLog = double.Parse(txtB.Text);
                        if (x > 0)
                            return aLog * Math.Log(x) + bLog;
                        else
                            return double.NaN;

                    case "Модуль":
                        double kMod = double.Parse(txtK.Text);
                        return kMod * Math.Abs(x);

                    case "Обратная пропорциональность":
                        double kInv = double.Parse(txtK.Text);
                        if (x != 0)
                            return kInv / x;
                        else
                            return double.NaN;

                    default:
                        return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        // Построение графика

        private void btnGraph_Click(object sender, EventArgs e)
        {
            try
            {
                // Очищаем старый график
                chartGraph.Series.Clear();

                // Создаём новую серию
                Series series = new Series();
                series.Name = "График функции";
                series.ChartType = SeriesChartType.Line;
                series.Color = System.Drawing.Color.Blue;
                series.BorderWidth = 3;

                // Интервал от -5 до 5, шаг 0.01
                for (double x = -5; x <= 5; x += 0.01)
                {
                    double y = CalculateY(x);

                    // Проверяем, что y - нормальное число
                    if (!double.IsInfinity(y) && !double.IsNaN(y) && Math.Abs(y) < 100)
                    {
                        series.Points.AddXY(x, y);
                    }
                }

                chartGraph.Series.Add(series);

                // Настройка осей
                chartGraph.ChartAreas[0].AxisX.Minimum = -5;
                chartGraph.ChartAreas[0].AxisX.Maximum = 5;
                chartGraph.ChartAreas[0].AxisY.Minimum = -5;
                chartGraph.ChartAreas[0].AxisY.Maximum = 5;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        // Исследование функции
        private void btnResearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Область определения 
                if (lblDomain != null) lblDomain.Text = GetRange();

                // Чётность/нечётность 
                if (labelParity != null) labelParity.Text = GetParity();

                // Периодичность 
                if (lblPeriod != null) lblPeriod.Text = GetPeriodicity();

                // Монотонность 
                if (lblMonot != null) lblMonot.Text = GetMonot();

                // Экстремумы 
                if (lblExtrema != null) lblExtrema.Text = FindExtremums();

                // Нули функции 
                if (lblZeros != null) lblZeros.Text = FindZeros();

                // Область значений 
                if (lblRange != null) lblRange.Text = GetRange();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        // Область определения
        private string GetDomain()
        {
            switch (SelectedFunction)
            {
                case "Линейная":
                case "Квадратичная":
                case "Кубическая":
                case "Синусоида":
                case "Косинусоида":
                case "Экспонента":
                case "Модуль":
                    return "Все действительные числа (ℝ)";
                case "Тангенсоида":
                    return "Все числа, кроме π/2 + πk";
                case "Логарифмическая":
                    return "x > 0 (положительные числа)";
                case "Обратная пропорциональность":
                    return "Все числа, кроме 0";
                default:
                    return "Не определено";
            }
        }

        // Чётность/нечётность
        private string GetParity()
        {
            switch (SelectedFunction)
            {
                case "Линейная":
                    double k = double.Parse(txtK.Text);
                    double b = double.Parse(txtB.Text);
                    if (b == 0 && k != 0) return "нечётная ";
                    else if (b != 0 && k == 0) return "чётная";
                    else return "общего вида";

                case "Квадратичная":
                    double b2 = double.Parse(txtB.Text);
                    if (b2 == 0) return "чётная";
                    else return "общего вида ";

                case "Кубическая":
                    double b3 = double.Parse(txtB.Text);
                    double d = double.Parse(txtD.Text);
                    if (b3 == 0 && d == 0) return "нечётная";
                    else return "общего вида";

                case "Синусоида":
                    return "нечётная";
                case "Косинусоида":
                    return "чётная";
                case "Тангенсоида":
                    return "нечётная";
                case "Экспонента":
                    return "ни чётная, ни нечётная";
                case "Логарифмическая":
                    return "ни чётная, ни нечётная";
                case "Модуль":
                    return "чётная";
                case "Обратная пропорциональность":
                    return "нечётная";
                default:
                    return "не определено";
            }
        }

        // Периодичность
        private string GetPeriodicity()
        {
            switch (SelectedFunction)
            {
                case "Синусоида":
                case "Косинусоида":
                    return "Периодическая";
                case "Тангенсоида":
                    return "Периодическая";
                default:
                    return "Непериодическая";
            }
        }

        // Монотонность
        private string GetMonot()
        {
            switch (SelectedFunction)
            {
                case "Линейная":
                    double k = double.Parse(txtK.Text);
                    if (k > 0) return "возрастает";
                    else if (k < 0) return "убывает";
                    else return "постоянная";

                case "Квадратичная":
                    double a = double.Parse(txtA.Text);
                    if (a > 0) return "убывает до вершины, затем возрастает";
                    else if (a < 0) return "возрастает до вершины, затем убывает";
                    else return "линейная функция (a = 0)";

                case "Кубическая":
                    double a3 = double.Parse(txtA.Text);
                    if (a3 > 0) return "возрастает на всей области";
                    else if (a3 < 0) return "убывает на всей области";
                    else return "квадратичная/линейная (a = 0)";

                case "Синусоида":
                    return "чередует возрастание и убывание";
                case "Косинусоида":
                    return "чередует возрастание и убывание";
                case "Тангенсоида":
                    return "возрастает на каждом интервале";
                case "Экспонента":
                    double aExp = double.Parse(txtA.Text);
                    double bExp = double.Parse(txtB.Text);
                    if (aExp > 0 && bExp > 0) return "возрастает";
                    else if (aExp > 0 && bExp < 0) return "убывает";
                    else if (aExp < 0 && bExp > 0) return "убывает";
                    else return "постоянная (a = 0)";
                case "Логарифмическая":
                    double aLog = double.Parse(txtA.Text);
                    if (aLog > 0) return "возрастает";
                    else if (aLog < 0) return "убывает";
                    else return "постоянная (a = 0)";
                case "Модуль":
                    double kMod = double.Parse(txtK.Text);
                    if (kMod > 0) return "убывает на (-∞;0], возрастает на [0;+∞)";
                    else if (kMod < 0) return "возрастает на (-∞;0], убывает на [0;+∞)";
                    else return "постоянная";
                case "Обратная пропорциональность":
                    double kInv = double.Parse(txtK.Text);
                    if (kInv > 0) return "убывает на (-∞;0) и на (0;+∞)";
                    else if (kInv < 0) return "возрастает на (-∞;0) и на (0;+∞)";
                    else return "постоянная";
                default:
                    return "не определено";
            }
        }

        // Экстремумы
        private string FindExtremums()
        {
            switch (SelectedFunction)
            {
                case "Линейная":
                    return "нет экстремумов";

                case "Квадратичная":
                    double a = double.Parse(txtA.Text);
                    double b = double.Parse(txtB.Text);
                    double c = double.Parse(txtC.Text);

                    if (a == 0) return "не квадратичная функция";

                    double xVertex = -b / (2 * a);
                    double yVertex = a * xVertex * xVertex + b * xVertex + c;

                    if (a > 0)
                        return $"минимум: {yVertex:F2} (x = {xVertex:F2})";
                    else
                        return $"максимум: {yVertex:F2} (x = {xVertex:F2})";

                case "Кубическая":
                    return "нет экстремумов";

                case "Синусоида":
                    double A = double.Parse(txtAmplitude.Text);
                    return $"максимум: {A}, минимум: {-A}";

                case "Косинусоида":
                    double A2 = double.Parse(txtAmplitude.Text);
                    return $"максимум: {A2}, минимум: {-A2}";

                case "Тангенсоида":
                    return "нет экстремумов";

                case "Экспонента":
                    return "нет экстремумов)";

                case "Логарифмическая":
                    return "нет экстремумов";

                case "Модуль":
                    double k = double.Parse(txtK.Text);
                    if (k > 0)
                        return $"минимум: 0 (x = 0)";
                    else if (k < 0)
                        return $"максимум: 0 (x = 0)";
                    else
                        return "постоянная функция y = 0";

                case "Обратная пропорциональность":
                    return "нет экстремумов";

                default:
                    return "не определено";
            }
        }


        // Нули функции 
        private string FindZeros()
        {
            switch (SelectedFunction)
            {
                case "Линейная":
                    double k = double.Parse(txtK.Text);
                    double b = double.Parse(txtB.Text);
                    if (k == 0)
                        return b == 0 ? "все x (функция y = 0)" : "нет нулей (постоянная ≠ 0)";
                    else
                        return $"x = {(-b / k):F2}";

                case "Квадратичная":
                    double a = double.Parse(txtA.Text);
                    double b2 = double.Parse(txtB.Text);
                    double c = double.Parse(txtC.Text);

                    if (a == 0) return "не квадратичная функция";

                    double D = b2 * b2 - 4 * a * c;
                    if (D < 0) return "нет действительных корней";
                    if (Math.Abs(D) < 0.0001) return $"x = {(-b2 / (2 * a)):F2} (один корень)";

                    double x1 = (-b2 - Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b2 + Math.Sqrt(D)) / (2 * a);
                    return $"x₁ = {x1:F2}, x₂ = {x2:F2}";

                case "Синусоида":
                    double phi = double.Parse(txtPhi.Text);
                    double omega = double.Parse(txtOmega.Text);
                    return $"x = -φ/ω + πk/ω, k ∈ ℤ";

                case "Косинусоида":
                    double phi2 = double.Parse(txtPhi.Text);
                    double omega2 = double.Parse(txtOmega.Text);
                    return $"x = (π/2 - φ)/ω + πk/ω, k ∈ ℤ";

                default:
                    return "вычисляется приближённо (см. интервал [-5;5])";
            }
        }

        // Область значений
        private string GetRange()
        {
            double minY = double.MaxValue;
            double maxY = double.MinValue;

            for (double x = -5; x <= 5; x += 0.1)
            {
                double y = CalculateY(x);
                if (!double.IsInfinity(y) && !double.IsNaN(y))
                {
                    if (y < minY) minY = y;
                    if (y > maxY) maxY = y;
                }
            }

            return $"y ∈ [{minY:F2}; {maxY:F2}] (на интервале x∈[-5;5])";
        }

        // Сохранение
        private void btnSave_Click(object sender, EventArgs e)
        {
                try
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
                    saveFileDialog.DefaultExt = "txt";
                    saveFileDialog.FileName = $"Исследование_{SelectedFunction}_{DateTime.Now:yyyyMMdd_HHmmss}";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Формируем содержимое
                        string content = $"ИССЛЕДОВАНИЕ ФУНКЦИИ\n\n";
                        content += $"Функция: {SelectedFunction}\n";
                        content += $"Формула: {lblFormula.Text}\n\n";
                        content += $"РЕЗУЛЬТАТЫ:\n";
                        content += $"Область определения: {GetDomain()}\n";
                        content += $"Чётность/нечётность: {GetParity()}\n";
                        content += $"Периодичность: {GetPeriodicity()}\n";
                        content += $"Монотонность: {GetMonot()}\n";
                        content += $"Экстремумы: {FindExtremums()}\n";
                        content += $"Нули функции: {FindZeros()}\n";
                        content += $"Область значений: {GetRange()}\n\n";

                        System.IO.File.WriteAllText(saveFileDialog.FileName, content, Encoding.UTF8);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        // На главную
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 != null) form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}