namespace PhanBaoTrung_Buoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> li_sky = new List<SinhVien>();

        private void btn_save_Click(object sender, EventArgs e)
        {/*
            SinhVien sky = new SinhVien();
            sky.setMSSV(txt_mssv.Text);
            sky.setHoTen(txt_ht.Text);
            sky.setGioiTinh(txt_gt.Text);
            sky.setDiaChi(txt_dc.Text);

            MessageBox.Show(
                "Mã Sinh Viên:" + sky.getMSSV() +
                "\nHọ Tên:" + sky.getHoTen() +
                "\nGiới Tinh:" + sky.getGioiTinh() +
                "\nNgày Sinh:" + sky.getNgaySinh() +
                "\nĐịa Chỉ:" + sky.getDiaChi()
                );*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sky = new SinhVien(txt_mssv.Text, txt_ht.Text, txt_gt.Text, dt_ns.Value, txt_dc.Text);
            li_sky.Add(sky);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_sky;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            li_sky.Remove(li_sky[0]);
            dataGridView1 .DataSource = null;
            dataGridView1.DataSource = li_sky; 
        }
    }
}
