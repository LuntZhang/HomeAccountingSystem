using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeAccountingSystem.BLL;

namespace HomeAccountingSystem.MainUserControl
{
    public partial class ControlChartUserControl : UserControl
    {
        public ControlChartUserControl()
        {
            InitializeComponent();
        }

        private void ControlChartUserControl_Load(object sender, EventArgs e)
        {
            DateTime startTime = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-01"));
            DateTime endTime = DateTime.Now;

            DataTable dt = ExpendAccountsManager.Instance.getConsumerUseData(startTime, endTime);
            if(dt ==null || dt.Rows.Count == 0)
            {
                return;
            }
            // 消费用途
            List<string> xData = new List<string>();
            // 所占总消费比率
            List<decimal> yData = new List<decimal>();
            // 总金额
            decimal  totalMoney = 0;
            foreach (DataRow item in dt.Rows)
            {
                xData.Add(item["v_zclx_name"].ToString()) ;
                yData.Add(Convert.ToDecimal(decimal.Parse(item["f_zc_money"].ToString()).ToString("0.00")));
                totalMoney += Convert.ToDecimal(decimal.Parse(item["f_zc_money"].ToString()).ToString("0.00")) ;
            }
            this.chartExpendData.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧 
            this.chartExpendData.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。 
            this.chartExpendData.Series[0].Points.DataBindXY(xData, yData);

        }
    }
}
