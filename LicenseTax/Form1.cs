using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        #region "Events"
        private void Form1_Load(object sender, EventArgs e)
        {
            this.init();

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.init();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbx_Control();
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            this.dtp1.Visible = false;
            this.dtp2.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;
        }
        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            this.dtp1.Visible = true;
            this.dtp2.Visible = true;
            this.label5.Visible = true;
            this.label6.Visible = true;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            TimeSpan ts1 = new TimeSpan(dtp1.Value.Ticks);
            TimeSpan ts2 = new TimeSpan(dtp2.Value.Ticks);
            TimeSpan ts = ts2.Subtract(ts1);

           
            
                this.lblResult.Text =
                "使用期間 :" + this.dtp1.Value.ToString("yyyy / MM / dd") + "至" +
                this.dtp2.Value.ToString("yyyy / MM / dd") + "\r\n" +
                "計算天數 : " + ts.Days.ToString() + "天" + "\r\n" +
                "用途 :" + this.cbxType1.Text + "\r\n" +
                "汽缸CC數／馬達馬力 :" + this.cbxType2.Text + "\r\n" +
                "計算公式 : " + "\r\n" +
                "應納稅額 : "+"共"+"元";
        }

        #endregion
        #region "Custom methods"

        public Vehicle[] CarTypeList; 
        private void init() 
        {
            this.rad1.Checked = true; 
            this.lblResult.Text = "";   
            

            List<Vehicle> list = new List<Vehicle>(); 
            list.Add(new Motorbike());
            list.Add(new Truck());
            list.Add(new Bus());
            list.Add(new Car());
            list.Add(new OperatingVehicle());

            cbxType1.DataSource = list;  
            cbxType1.DisplayMember = "Name"; 
            cbxType1.SelectedItem = 0;


        }
        private void cbx_Control()
        {
            var test = (Vehicle)cbxType1.SelectedItem;
            cbxType2.DataSource = test.CCType;
            cbxType2.DisplayMember = "CCType";
            cbxType2.SelectedItem = 0;
        }
        

        #endregion
        public class Vehicle 
        {
            public string Name { get; set; }
            public string[] CCType;


            public Dictionary<string, int>  ccType = new Dictionary<string, int>();
            public decimal CalcuateTax(int years,int ccTypeCost)
            {
                return years * ccTypeCost;
            }


        }
        public class Motorbike : Vehicle 
        {

            public Motorbike()
            {
                Name = "機車";
                CCType = new string[] {
                 "150以下/12HP以下(12.2PS以下)"
                ,"151-250/12.1-20HP(12.3-20.3PS)"
                ,"251-500/20.1HP以上(20.4PS以上)"
                ," 501-600"
                ," 601-1200"
                ," 1201-1800"
                ," 1800以上"};

                ccType.Add("150以下/12HP以下(12.2PS以下)", 0);
                ccType.Add("151-250/12.1-20HP(12.3-20.3PS)", 800);
                ccType.Add("251-500/20.1HP以上(20.4PS以上)", 1620);
                ccType.Add("501-600)", 2160);
                ccType.Add("601-1200", 4320);
                ccType.Add("1201-1800", 7120);
                ccType.Add("1800以上", 11230);
            }

        }
        public class Truck : Vehicle
        {
            public Truck()
            {
                Name = "貨車";
                CCType = new string[]{
                 "500以下"
                ,"501-600"
                ,"601-1200"
                ,"1201-2400"
                ,"2401-3000/138HP以下(140.1PS以下)"
                ,"3001-3600"
                ,"3601-4200/138.1HP-200HP(140.2-203.0PS)"
                ,"4201-4800"
                ,"4801-5400/200.1HP-247HP(203.1-250.7PS)"
                ,"5401-6000"
                ,"6001-6600/247.1HP-286HP(250.8-290.3PS)"
                ,"6601-7200"
                ,"7201-7800/286.1HP-336HP(290.4-341.0PS)"
                ,"7801-8400"
                ,"8401-9000/336.1HP-361HP(341.1-366.4PS)"
                ,"9001-9600"
                ,"9601-10200/361HP以上(366.5PS以上)"
                ,"10201以上" }; 
            }
        }
        public class Bus : Vehicle
        {
            public Bus()
            {
                Name = "大客車";
                CCType = new string[]{
                 "600以下"
                ,"601-1200"
                ,"1201-2400"
                ,"2401-3000/138HP以下(140.1PS以下)"
                ,"3001-3600"
                ,"3601-4200/138.1HP-200HP(140.2-203.0PS)"
                ,"4201-4800"
                ,"4801-5400/200.1HP-247HP(203.1-250.7PS)"
                ,"5401-6000"
                ,"6001-6600/247.1HP-286HP(250.8-290.3PS)"
                ,"6601-7200"
                ,"7201-7800/286.1HP-336HP(290.4-341.0PS)"
                ,"7801-8400"
                ,"8401-9000/336.1HP-361HP(341.1-366.4PS)"
                ,"9001-9600"
                ,"9601-10200/361HP以上(366.5PS以上)"
                ,"10201以上"};
            }
        }
        public class Car : Vehicle
        {
            public Car()
            {
                Name = "自用小客車";
                CCType = new string[] {
                 "500以下/38HP以下(38.6PS以下)"
                ,"501-600/38.1-56HP(38.7-56.8PS)"
                ,"601-1200/56.1-83HP(56.9-84.2PS)"
                ,"1201-1800/83.1-182HP(84.3-184.7PS)"
                ,"1801-2400/182.1-262HP(184.8-265.9PS)"
                ,"2401-3000/262.1-322HP(266.0-326.8PS)"
                ,"3001-4200/322.1-414HP(326.9-420.2PS)"
                ,"4201-5400/414.1HP-469HP(420.3-476.0PS)"
                ,"5401-6600/469.1HP-509HP(476.1-516.6PS)"
                ,"6601-7800/509.1HP以上(516.7PS)以上"
                ,"7801以上"};
            }
        }
        public class OperatingVehicle : Vehicle
        {
            public OperatingVehicle()
            {
                Name = "營業用小客車";
                CCType = new string[]{
                 "500以下/38HP以下(38.6PS以下)"
                ,"501-600/38.1-56HP(38.7-56.8PS)"
                ,"601-1200/56.1-83HP(56.9-84.2PS)"
                ,"1201-1800/83.1-182HP(84.3-184.7PS)"
                ,"1801-2400/182.1-262HP(184.8-265.9PS)"
                ,"2401-3000/262.1-322HP(266.0-326.8PS)"
                ,"3001-4200/322.1-414HP(326.9-420.2PS)"
                ,"4201-5400/414.1HP-469HP(420.3-476.0PS)"
                ,"5401-6600/469.1HP-509HP(476.1-516.6PS)"
                ,"6601-7800/509.1HP以上(516.7PS)以上"
                ,"7801以上"};
            }
        }
    }
}
