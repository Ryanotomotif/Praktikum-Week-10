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

namespace Praktikum_Week_10
{
	public partial class FormHasilPertandingan : Form
	{
		public FormHasilPertandingan()
		{
			InitializeComponent();
		}

		static string connectionString = "server=localhost;uid=root;pwd=;database=premier_league;";
		public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
		public MySqlCommand sqlCommand;
		public MySqlDataAdapter sqlAdapter;
		public string sqlQuery;

		DataTable dtTeamAway = new DataTable();
		DataTable dtTeamHome = new DataTable();
        DataTable dtMatchDate = new DataTable();
        DataTable dtHasilMatch = new DataTable();

        private void FormHasilPertandingan_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT t.team_id as `ID Tim`, t.team_name as `Nama Tim`, m.manager_name as `Nama Manager`, IF(m2.manager_name IS NULL,'----',m2.manager_name) as `Nama Asisten Manager`,p.player_name as `Nama Kapten`, home_stadium as `Stadium`, capacity as `Kapasitas` FROM team t LEFT JOIN manager m2 ON  t.assmanager_id = m2.manager_id ,manager m, player p WHERE t.manager_id = m.manager_id AND t.captain_id = p.player_id ;";
			sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamHome);
            sqlAdapter.Fill(dtTeamAway);
            comboHome.DataSource = dtTeamHome;
            comboHome.DisplayMember = "Nama Tim";
            comboHome.ValueMember = "ID Tim";
            comboAway.DataSource = dtTeamAway;
            comboAway.DisplayMember = "Nama Tim";
        }

        private void comboHome_SelectedIndexChanged_1(object sender, EventArgs e)
		{
            int posisiIndex = comboHome.SelectedIndex;
            labHomeManager.Text = dtTeamHome.Rows[posisiIndex]["Nama Manager"].ToString();
            labHomeKapten.Text = dtTeamHome.Rows[posisiIndex]["Nama Kapten"].ToString();
            labStadium.Text = dtTeamHome.Rows[posisiIndex]["Stadium"].ToString();
            labCapacity.Text = dtTeamHome.Rows[posisiIndex]["Kapasitas"].ToString();
        }

		private void comboAway_SelectedIndexChanged_1(object sender, EventArgs e)
		{
            int posisiIndex = comboAway.SelectedIndex;
            labAwayManager.Text = dtTeamAway.Rows[posisiIndex]["Nama Manager"].ToString();
            labAwayKapten.Text = dtTeamAway.Rows[posisiIndex]["Nama Kapten"].ToString();
        }

		private void btn_chck_Click(object sender, EventArgs e)
		{
            comboHome.ValueMember = "ID Tim";
            comboAway.ValueMember = "ID Tim";
            sqlQuery = "select dm.`minute` as 'minute', if ((dm.team_id = '" + comboHome.SelectedValue.ToString() + "' and dm.type != 'GW') or(dm.team_id = '" + comboHome.SelectedValue.ToString() + "' and dm.type = 'GW') , p.player_name,' ') as 'Player Name 1', if ((dm.team_id = '" + comboHome.SelectedValue.ToString() + "' and dm.type != 'GW') or(dm.team_id = '" + comboAway.SelectedValue.ToString() + "' and dm.type = 'GW') , if (dm.type = 'CY','YELLOW CARD',if (dm.type = 'CR', 'RED CARD',if (dm.type = 'GO', 'GOAL',if (dm.type = 'GP','GOAL PENALTY',if (dm.type = 'GW', 'OWN GOAL','PENALTY MISS'))))),' ') as 'Type 1', if ((dm.team_id = '" + comboAway.SelectedValue.ToString() + "' and dm.type != 'GW') OR(dm.team_id = '" + comboAway.SelectedValue.ToString() + "' and dm.type = 'GW'), p.player_name,' ') as 'Player Name 2', if ((dm.team_id = '" + comboAway.SelectedValue.ToString() + "' and dm.type != 'GW') OR(dm.team_id = '" + comboAway.SelectedValue.ToString() + "' and dm.type = 'GW'),if (dm.type = 'CY','YELLOW CARD',if (dm.type = 'CR', 'RED CARD',if (dm.type = 'GO', 'GOAL',if (dm.type = 'GP','GOAL PENALTY',if (dm.type = 'GW', 'OWN GOAL','PENALTY MISS'))))),' ') as 'Type 2' from dmatch dm, `match`, team t1, team t2, player p where p.player_id = dm.player_id and dm.match_id =`match`.match_id and t1.team_id =`match`.team_home and t2.team_id =`match`.team_away and `match`.team_home = '" + comboHome.SelectedValue.ToString() + "' and `match`.team_away = '" + comboAway.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHasilMatch);
            Dgv_match.DataSource = dtHasilMatch;

            comboHome.ValueMember = "ID Tim";
            comboAway.ValueMember = "ID Tim";
            sqlQuery = "select date_format(`match`.match_date, '%d %M %Y') as 'Tanggal', concat(`match`.goal_home,' - ', `match`.goal_away) as 'Skor', dm.match_id as 'match_id', dm.`minute` as 'minute', dm.team_id as 'team_id', dm.player_id as 'player_id', dm.`type` as 'type', dm.`delete` as 'delete' from dmatch dm, `match`, team t1, team t2 where dm.match_id =`match`.match_id and t1.team_id =`match`.team_home and t2.team_id =`match`.team_away and `match`.team_home = '" + comboHome.SelectedValue.ToString() + "' and `match`.team_away = '" + comboAway.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatchDate);
            lbl_tgl.Text = dtMatchDate.Rows[0]["Tanggal"].ToString();
            lbl_skor.Text = dtMatchDate.Rows[0]["Skor"].ToString();
        }
	}
}
