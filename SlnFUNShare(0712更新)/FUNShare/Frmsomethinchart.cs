using FUNShare.Models;//搭配類別管理的資料夾
using FUNShare;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FUNShare
{
    public partial class Frmsomethinchart : Form
    {
        public Frmsomethinchart()
        {
            InitializeComponent();
        }
        FUNShareEntities dbcontext = new FUNShareEntities();//連DB
        //FUNShareEntities1 dbcontext = new FUNShareEntities1();//本地DB
        CSupplierManage manage= new CSupplierManage();
        private void button8_Click(object sender, EventArgs e)
        {
            var q = dbcontext.Products.AsEnumerable()
                     .OrderBy(item=>item.UnitPrice)
                     .GroupBy(item => manage.MyGroup(item))
                     .Select(g => new
                    {
                        商品分類 = g.Key,
                        類別總數 = g.Count(),
                        類別平均單價 = $"{g.Average(i => i.UnitPrice):c2}",
                        分群 = g.ToList()
                    }).ToList();

            dataGridView1.DataSource = q;
            treeView1.Nodes.Clear();
            foreach (var group in q)
            {
                TreeNode node = treeView1.Nodes.Add($"{group.商品分類}({group.類別總數})");
                foreach (var item in group.分群)
                {
                    node.Nodes.Add($"產品名稱:{item.Product_Name}  產品價格:{item.UnitPrice:c2}");
                }
            }
            // 清空圖表
            chart1.Series.Clear();
            chart1.DataSource = q;
            chart1.Series.Add(new Series("價格")
            {
                ChartType = SeriesChartType.Pie,
                XValueMember = "商品分類",
                YValueMembers = "類別總數"
            });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var q = from p in dbcontext.Orders
                    group p by p.Order_Time.Year into g
                    from g1 in (from p in g
                                group p by p.Order_Time.Month)
                    group g1 by g.Key into g2
                    orderby g2.Key
                    select new
                    {
                        年份 = g2.Key,
                        訂單月份總數 = g2.Count(),
                        分群 = g2
                    };

            dataGridView1.DataSource = q.ToList();
            treeView1.Nodes.Clear();
            foreach (var yearGroup in q)
            {
                TreeNode yearNode = treeView1.Nodes.Add($"{yearGroup.年份}({yearGroup.訂單月份總數})");
                foreach (var monthGroup in yearGroup.分群)
                {
                    TreeNode monthNode = yearNode.Nodes.Add($"{monthGroup.Key}/{monthGroup.Count()}");
                    foreach (var item in monthGroup)
                    {
                        monthNode.Nodes.Add($"訂單編號:{item.Order_ID}訂購人姓名:{item.Customer_Infomation.Name} 訂購時間:{item.Order_Time}");
                    }
                }
            }
            //chart
            // 綁定資料到圖表
            chart1.Series.Clear();
            foreach (var yearGroup in q)
            {
                var series = new Series($"{yearGroup.年份}({yearGroup.訂單月份總數})");
                series.ChartType = SeriesChartType.Spline;

                foreach (var monthGroup in yearGroup.分群)
                {
                    series.Points.AddXY(monthGroup.Key, monthGroup.Count());
                }

                chart1.Series.Add(series);
            }

            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var q = (from o in dbcontext.Orders
                    group o by o.Order_Time.Year into g
                    select new
                    {
                        年分 = g.Key,
                        總數 = g.Count(),
                        分群 = g
                    }).ToList();
            dataGridView1.DataSource = q;
            //treeView
            treeView1.Nodes.Clear();
            foreach (var group in q)
            {
                TreeNode node = treeView1.Nodes.Add($"{group.年分}({group.總數})");
                foreach (var year in group.分群)//搭配var q用
                {
                    node.Nodes.Add($"訂單編號:{year.Order_ID} 訂購人姓名:{year.Customer_Infomation.Name}");
                }
            }
            //chart
            // 清空圖表
            chart1.Series.Clear();
            chart1.DataSource = q;
            chart1.Series.Add(new Series("訂單總數")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "年分",
                YValueMembers = "總數"
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var q1 = from i in dbcontext.Order_Detail.AsEnumerable()
                     select new { price = dbcontext.Products.AsEnumerable().Where(x => x.Product_ID == i.Product_Detail.Product_ID).Select(x => x.UnitPrice).FirstOrDefault() };
           // dataGridView1.DataSource= q1;
            MessageBox.Show($"今年度總共賺取:{q1.Sum(x=>x.price)}。請各位同仁再努利一點");
           // q1.Sum(p => (float)p.UnitPrice * p.Stock):c2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var qOrderAmount = from od in dbcontext.Order_Detail
                               select new
                               {
                                   ProductID = od.Product_Detail.Product_ID,
                                   Price = dbcontext.Products.AsEnumerable().Where(x => x.Product_ID == od.Product_Detail.Product_ID).Select(x => x.UnitPrice).FirstOrDefault()
                               };

            var qGroupByID = from amount in qOrderAmount
                             group amount by amount.ProductID into g
                             select new
                             {
                                 ID = g.Key,
                                 ProductName = dbcontext.Products.Where(x=>x.Product_ID== g.Key).Select(x=>x.Product_Name).FirstOrDefault(),
                                 TotalAmount = g.Sum(x => x.Price),
                             };

            dataGridView1.DataSource = qGroupByID.OrderByDescending(x=>x.TotalAmount).Take(5).ToList();

            treeView1.Nodes.Clear();
            chart1.Series.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var q = from p in dbcontext.Products
                    orderby p.UnitPrice descending
                    select new
                    {
                        產品價格 = p.UnitPrice,
                        產品名稱 = p.Product_Name
                    };
            dataGridView1.DataSource = q.Take(5).ToList();
            treeView1.Nodes.Clear();
            chart1.Series.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var orders = dbcontext.Orders.ToList();

            // 取得所有年份的數據
            var years = orders.Select(o => o.Order_Time.Year).Distinct().ToList();

            // 儲存每個年份的成長率
            var growthRates = new List<double>();

            // 計算每個年份的成長率
            for (int i = 1; i < years.Count; i++)
            {
                var previousYearData = orders.Where(o => o.Order_Time.Year == years[i - 1]).ToList();
                var currentYearData = orders.Where(o => o.Order_Time.Year == years[i]).ToList();

                // 計算年度成長率
                double growthRate = CalculateYearlyGrowthRate(previousYearData, currentYearData);
                growthRates.Add(growthRate);
            }

            // 將年份和對應的成長率組合成一個匿名類型的集合
            var q = years.Skip(1).Zip(growthRates, (year, rate) => new { 訂單年份 = year, 銷售成長率 = rate }).OrderBy(item => item.訂單年份);

            // 設定 DataGridView 的資料來源
            dataGridView1.DataSource = q.ToList();
            // 設定圖表的資料來源
            chart1.Series.Clear();
            chart1.Series.Add("成長率");
            chart1.Series["成長率"].ChartType = SeriesChartType.Bar;
            chart1.Series["成長率"].XValueMember = "訂單年份";
            chart1.Series["成長率"].YValueMembers = "銷售成長率";
            chart1.DataSource = q.ToList();

            // 設定圖表的 X 軸和 Y 軸
            chart1.ChartAreas[0].AxisX.Title = "訂單年份";
            chart1.ChartAreas[0].AxisY.Title = "銷售成長率";
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }
        static double CalculateYearlyGrowthRate(List<Order> previousYearData, List<Order> currentYearData)
        {
            // 計算前一年的總數值
            double previousYearTotal = previousYearData.Sum(o => o.Order_Time.Year);

            // 計算當前年份的總數值
            double currentYearTotal = currentYearData.Sum(o => o.Order_Time.Year);

            // 計算年度成長率
            double growthRate = (currentYearTotal - previousYearTotal) / previousYearTotal * 100;

            return growthRate;
        }
    }
}
