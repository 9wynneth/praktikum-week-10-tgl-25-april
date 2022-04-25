using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace praktikum_11_April_week_8
{

    public partial class FormHasilPertandingan : Form
    {
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //sebagai data koneksi ke DBMSnya
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter; 
        public string sqlQuery;
        DataTable dtPlayerHome = new DataTable();
        DataTable dtPlayerAway = new DataTable();
        public string idTeamAway;
        public string idTeamHome;
        public FormHasilPertandingan()
        {
            InitializeComponent();
        }

        private void FormHasilPertandingan_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
           
            sqlQuery = "SELECT t.team_name as 'Nama Tim',t.team_id as 'ID_Team', m.manager_id as 'ID_Manager' FROM team t, manager m WHERE m.manager_id=t.manager_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayerHome);
            cBoxHomeTeam.DataSource = dtPlayerHome;
            cBoxHomeTeam.DisplayMember = "Nama Tim";
            cBoxHomeTeam.ValueMember = "ID_Manager";
            sqlQuery = "SELECT team_name as 'Nama Tim',t.team_id as 'ID_Team', m.manager_id as 'ID_Manager' FROM team t, manager m WHERE m.manager_id=t.manager_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayerAway);
            cBoxAwayTeam.DataSource = dtPlayerAway;
            cBoxAwayTeam.DisplayMember = "Nama Tim";
            cBoxAwayTeam.ValueMember = "ID_Manager";
        }

        private void cBoxHomeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtHome = new DataTable();
                // 
                idTeamHome= dtPlayerHome.Rows[cBoxHomeTeam.SelectedIndex][1].ToString();
                //MessageBox.Show(idTeamHome);
                sqlQuery = "SELECT m.manager_name, p.player_name, Concat(t.home_stadium, ', ',t.city), t.capacity FROM manager m, team t, player p WHERE m.manager_id=t.manager_id and  p.player_id=t.captain_id and m.manager_id='" + cBoxHomeTeam.SelectedValue.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtHome);
                lbl_ManagerHome.Text = dtHome.Rows[0][0].ToString();
                lbl_CaptainHome.Text = dtHome.Rows[0][1].ToString();
                lbl_StadiumOutput.Text = dtHome.Rows[0][2].ToString();
                lbl_CapacityOutput.Text = dtHome.Rows[0][3].ToString();
                // 

            }
            catch (Exception )
            {
                //MessageBox.Show(ex.Message);
            }
            
        }

        private void cBoxAwayTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtAway = new DataTable();
                idTeamAway = dtPlayerAway.Rows[cBoxAwayTeam.SelectedIndex][1].ToString();
                // 
                sqlQuery = "SELECT m.manager_name, p.player_name FROM manager m, team t, player p WHERE m.manager_id=t.manager_id and  p.player_id=t.captain_id and m.manager_id='" + cBoxAwayTeam.SelectedValue.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtAway);
                lbl_ManagerAway.Text = dtAway.Rows[0][0].ToString();
                lbl_CaptainAway.Text = dtAway.Rows[0][1].ToString();
                // 

            }
            catch (Exception)
            {

            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            try 
            { 
            DataTable tanggalSkor = new DataTable();
            sqlQuery = "SELECT date_format(m.match_date, '%e %M %Y') as 'Tanggal', Concat(m.goal_home, '-', m.goal_away) as 'SKOR'FROM `match` m WHERE m.team_home = '"+idTeamHome+"'and m.team_away = '"+ idTeamAway + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(tanggalSkor);
            lbl_HasilTanggal.Text = tanggalSkor.Rows[0][0].ToString();
            lbl_HasilSkor.Text = tanggalSkor.Rows[0][1].ToString();

            DataTable matchDetail = new DataTable();
            sqlQuery = "SELECT d.`minute` as 'Minute', if (d.`type` = 'GW', if (d.team_id != m.team_home, p.player_name,''), if (p.team_id = m.team_home, p.player_name, '' )) as 'Player Name 1',if (d.`type` = 'GW', if (d.team_id != m.team_home, 'OWN GOAL' ,''), if (p.team_id = m.team_home, if (d.`type` = 'CY', 'YELLOW CARD', if (d.`type` = 'CR', 'RED CARD',  if (d.`type` = 'GO', 'GOAL',  if (d.`type` = 'GP', 'GOAL PENALTY',  if (d.`type` = 'GW', 'OWN GOAL', if (d.`type` = 'PM', 'PENALTY MISS', p.player_name)))))), '')) as 'Tipe 1', if (d.`type` = 'GW', if (d.team_id != m.team_away, p.player_name,''), if (p.team_id = m.team_away, p.player_name, '' )) as 'Player Name 2', if (d.`type` = 'GW', if (d.team_id != m.team_away, 'OWN GOAL' ,''), if (p.team_id = m.team_away,if (d.`type` = 'CY', 'YELLOW CARD', if (d.`type` = 'CR', 'RED CARD',  if (d.`type` = 'GO', 'GOAL',  if (d.`type` = 'GP', 'GOAL PENALTY',  if (d.`type` = 'GW', 'OWN GOAL', if (d.`type` = 'PM', 'PENALTY MISS', p.player_name)))))), '')) as 'Tipe 2' FROM dmatch d, `match` m, player p WHERE d.match_id = m.match_id AND p.player_id = d.player_id AND m.team_home = '"+idTeamHome+"' AND m.team_away = '"+idTeamAway+"'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(matchDetail);
            dataGridView_Detail.DataSource = matchDetail;
            }
            catch (Exception)
            {

            }
        }
    }
}
