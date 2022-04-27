using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Windows.Forms;

namespace E_Arşiv_Fatura
{
    class DataBase
    {
        string dbName;
        string provider;
        string dataSource;
        public OleDbConnection baglanti;
        public DataSet dataset = new DataSet();
        OleDbDataAdapter adapter;
        public DataBase(string provider, string dataSource, string dbName)
        {
            this.dbName = "\\" + dbName;
            this.provider = "Provider=" + provider;
            this.dataSource = "Data Source=" + dataSource;
        }

        public void dbBaglanti()
        {
            baglanti = new OleDbConnection(provider + dataSource + dbName);
            try
            {
                baglanti = new OleDbConnection(provider + dataSource + dbName);
            }
            catch (System.InvalidOperationException e)
            {
                MessageBox.Show("Database'e erişilemiyor !" + Environment.NewLine +
                    "Hata :" + e.Message);
                return;
            }
            adapter = new OleDbDataAdapter("Select * from Musteriler", baglanti);
            baglanti.Open();
            adapter.Fill(dataset);
            baglanti.Close();
        }

        public void VeriEkle(string tcKimlik, string unvan, string adi, string soyadi, int ulke, string vergiDairesi, string adres, string not)
        {
            OleDbCommand komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "insert into Musteriler (tc_kimlik_numarasi, unvan, ad, soyad, ulke, vergi_dairesi, adres, metin_not)" +
                " values (@tckimlik,@unvan,@ad,@soyad,@ulke,@vergidairesi,@adres,@metin_not)";
            komut.Parameters.AddWithValue("@tckimlik", tcKimlik);
            komut.Parameters.AddWithValue("@unvan", unvan);
            komut.Parameters.AddWithValue("@ad", adi);
            komut.Parameters.AddWithValue("@soyad", soyadi);
            komut.Parameters.AddWithValue("@ulke", ulke);
            komut.Parameters.AddWithValue("@vergidairesi", vergiDairesi);
            komut.Parameters.AddWithValue("@adres", adres);
            komut.Parameters.AddWithValue("@metin_not", not.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void NotGuncelle(string guncellenecekTc, string yeniNot)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "update Musteriler set metin_not = '" + yeniNot + "' where tc_kimlik_numarasi = '" + guncellenecekTc + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public ArrayList SearchDataByTC(string vergiNumarasi)
        {
            ArrayList dizi = new ArrayList();
            baglanti.Open();
            string sorguMetni = $"select * from Musteriler Where tc_kimlik_numarasi = '{vergiNumarasi}'";
            OleDbDataAdapter sorgu = new OleDbDataAdapter(sorguMetni, baglanti);
            DataSet dsHafiza = new DataSet();
            sorgu.Fill(dsHafiza);
            baglanti.Close();
            for(int i = 0; i < dsHafiza.Tables[0].Columns.Count; i++) { dizi.Add(dsHafiza.Tables[0].Rows[0][i]); }
            return dizi;
        }

        public bool Contains(string vergiNumarasi)
        {
            baglanti.Open();
            string sorguMetni = $"select * from Musteriler Where tc_kimlik_numarasi = '{vergiNumarasi}'";
            OleDbDataAdapter sorgu = new OleDbDataAdapter(sorguMetni, baglanti);
            DataSet dsHafiza = new DataSet();
            sorgu.Fill(dsHafiza);
            baglanti.Close();
            if (dsHafiza.Tables[0].Rows.Count > 0) { return true; } else { return false; }
        }
    }
}
