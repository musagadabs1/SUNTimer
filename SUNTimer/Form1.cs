using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUNTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int interval = 1;
            //string timeOfTheDay = DateTime.Now.ToShortTimeString();
            //string comma = ",";
            //lblDayOfTheWeek.Text = string.Format( "{0}{1}", DateTime.Now.DayOfWeek.ToString(), comma);

        }

        private void tmrDayTime_Tick(object sender, EventArgs e)
        {
            lblDayTimeDisplay.Text = DateTime.Now.ToString();
            string comma = ",";
            lblDayOfTheWeek.Text = string.Format("{0}{1}", DateTime.Now.DayOfWeek.ToString(), comma);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;              
                  
        }

        private void startOperation()
        {
            // getting root path
            string rootLocation = typeof(Program).Assembly.Location;
            string fullFilePath = "bell-ringing-01.wav";
            //string fullFilePath = "vchorddm.wav";



            var currentDay = DateTime.Now.DayOfWeek;
            switch (currentDay)
            {
                case DayOfWeek.Sunday:
                    if (!sundayOff.Checked)
                    {
                        var currentTime = DateTime.Now;

                        var set1stTimeStart = dtpSun1stStart.Value.ToShortTimeString();
                        var set1stTimeSEnd = dtpSun1stEnd.Value.ToShortTimeString();

                        var set2ndTimeStart = dtpSun2ndStart.Value.ToShortTimeString();
                        var set2ndTimeSEnd = dtpSun2ndEnd.Value.ToShortTimeString();

                        //var set3rdTimeStart = dtpSun3rdStart.Value.ToShortTimeString();
                        //var set3rdTimeSEnd = dtpSun3rdEnd.Value.ToShortTimeString();

                        //var set4thTimeStart = dtpSun4thStart.Value.ToShortTimeString();
                        //var set4thTimeSEnd = dtpSun4thEnd.Value.ToShortTimeString();

                        //var set5thTimeStart = dtpSun5thStart.Value.ToShortTimeString();
                        //var set5thTimeSEnd = dtpSun5thEnd.Value.ToShortTimeString();

                        string sTime = currentTime.ToShortTimeString();

                        if (set1stTimeStart == sTime || set1stTimeSEnd == sTime)
                        {
                            if (!chkSun1st.Checked)
                            {
                                //TODO: Ring bell @"d:\bell-ringing-01.wav"
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }
                            

                        }
                        if (set2ndTimeStart == sTime || set2ndTimeSEnd == sTime)
                        {
                            if (!chkSun2nd.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }   
                            

                        }
                        //if (set3rdTimeStart == sTime || set3rdTimeSEnd == sTime)
                        //{
                        //    //TODO: Ring bell
                        //    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"d:\bell-ringing-01.wav");
                        //    player.Play();

                        //}
                        //if (set4thTimeStart == sTime || set4thTimeSEnd == sTime)
                        //{
                        //    //TODO: Ring bell
                        //    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"d:\bell-ringing-01.wav");
                        //    player.Play();

                        //}
                        //if (set5thTimeStart == sTime || set5thTimeSEnd == sTime)
                        //{
                        //    //TODO: Ring bell
                        //    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"d:\bell-ringing-01.wav");
                        //    player.Play();

                        //}

                    }
                    break;
                case DayOfWeek.Monday:
                    if (!mondayOff.Checked)
                    {
                        var currentTime = DateTime.Now;

                        var set1stTimeStart = dtpMon1stStart.Value.ToShortTimeString();
                        var set1stTimeSEnd = dtpMon1stEnd.Value.ToShortTimeString();

                        var set2ndTimeStart = dtpMon2ndStart.Value.ToShortTimeString();
                        var set2ndTimeSEnd = dtpMon2ndEnd.Value.ToShortTimeString();

                        var set3rdTimeStart = dtpMon3rdStart.Value.ToShortTimeString();
                        var set3rdTimeSEnd = dtpMon3rdEnd.Value.ToShortTimeString();

                        var set4thTimeStart = dtpMon4thStart.Value.ToShortTimeString();
                        var set4thTimeSEnd = dtpMon4thEnd.Value.ToShortTimeString();

                        var set5thTimeStart = dtpMon5thStart.Value.ToShortTimeString();
                        var set5thTimeSEnd = dtpMon5thEnd.Value.ToShortTimeString();

                        string sTime = currentTime.ToShortTimeString();

                        if (set1stTimeStart == sTime || set1stTimeSEnd == sTime)
                        {
                            if (!chkMon1st.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set2ndTimeStart == sTime || set2ndTimeSEnd == sTime)
                        {
                            if (!chkMon2nd.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set3rdTimeStart == sTime || set3rdTimeSEnd == sTime)
                        {
                            if (!chkMon3rd.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set4thTimeStart == sTime || set4thTimeSEnd == sTime)
                        {
                            if (!chkMon4th.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }
                            

                        }
                        if (set5thTimeStart == sTime || set5thTimeSEnd == sTime)
                        {
                            if (!chkMon5thP.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                    }
                    break;
                case DayOfWeek.Tuesday:
                    if (!tuesdayOff.Checked)
                    {
                        var currentTime = DateTime.Now;

                        var set1stTimeStart = dtpTue1stStart.Value.ToShortTimeString(); 
                        var set1stTimeSEnd = dtpTue1stEnd.Value.ToShortTimeString();

                        var set2ndTimeStart = dtpTue2ndStart.Value.ToShortTimeString();
                        var set2ndTimeSEnd = dtpTue2ndEnd.Value.ToShortTimeString();

                        var set3rdTimeStart = dtpTue3rdStart.Value.ToShortTimeString();
                        var set3rdTimeSEnd = dtpTue3rdEnd.Value.ToShortTimeString();

                        var set4thTimeStart = dtpTue4thStart.Value.ToShortTimeString();
                        var set4thTimeSEnd = dtpTue4thEnd.Value.ToShortTimeString();

                        var set5thTimeStart = dtpTue5thStart.Value.ToShortTimeString();
                        var set5thTimeSEnd = dtpTue5thEnd.Value.ToShortTimeString();

                        string sTime = currentTime.ToShortTimeString();

                        if (set1stTimeStart == sTime || set1stTimeSEnd == sTime)
                        {
                            if (!chkTue1st.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set2ndTimeStart == sTime || set2ndTimeSEnd == sTime)
                        {
                            if (!chkTue2nd.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set3rdTimeStart == sTime || set3rdTimeSEnd == sTime)
                        {
                            if (!chkTue3rd.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set4thTimeStart == sTime || set4thTimeSEnd == sTime)
                        {
                            if (!chkTue4th.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set5thTimeStart == sTime || set5thTimeSEnd == sTime)
                        {
                            if (!chkTue5th.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                    }
                    break;
                case DayOfWeek.Wednesday:
                    if (!wednessdayOff.Checked)
                    {
                        var currentTime = DateTime.Now;

                        var set1stTimeStart = dtpWed1stStart.Value.ToShortTimeString();
                        var set1stTimeSEnd = dtpWed1stEnd.Value.ToShortTimeString();

                        var set2ndTimeStart = dtpWed2ndStart.Value.ToShortTimeString();
                        var set2ndTimeSEnd = dtpWed2ndEnd.Value.ToShortTimeString();

                        var set3rdTimeStart = dtpWed3rdStart.Value.ToShortTimeString();
                        var set3rdTimeSEnd = dtpWed3rdEnd.Value.ToShortTimeString();

                        var set4thTimeStart = dtpWed4thStart.Value.ToShortTimeString();
                        var set4thTimeSEnd = dtpWed4thEnd.Value.ToShortTimeString();

                        var set5thTimeStart = dtpWed5thStart.Value.ToShortTimeString();
                        var set5thTimeSEnd = dtpWed5thEnd.Value.ToShortTimeString();

                        string sTime = currentTime.ToShortTimeString();

                        if (set1stTimeStart == sTime || set1stTimeSEnd == sTime)
                        {
                            if (!chkWed1st.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set2ndTimeStart == sTime || set2ndTimeSEnd == sTime)
                        {
                            if (!chkWed2nd.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set3rdTimeStart == sTime || set3rdTimeSEnd == sTime)
                        {
                            if (!chkWed3rd.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set4thTimeStart == sTime || set4thTimeSEnd == sTime)
                        {
                            if (!chkWed4th.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set5thTimeStart == sTime || set5thTimeSEnd == sTime)
                        {
                            if (!chkWed5th.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                    }
                    break;
                case DayOfWeek.Thursday:
                    //case DayOfWeek.Wednesday:
                    if (!thursdayOff.Checked)
                    {
                        var currentTime = DateTime.Now;

                        var set1stTimeStart = dtpThur1stStart.Value.ToShortTimeString();
                        var set1stTimeSEnd = dtpThur1stEnd.Value.ToShortTimeString();

                        var set2ndTimeStart = dtpThur2ndStart.Value.ToShortTimeString();
                        var set2ndTimeSEnd = dtpThur2ndEnd.Value.ToShortTimeString();

                        var set3rdTimeStart = dtpThur3rdStart.Value.ToShortTimeString();
                        var set3rdTimeSEnd = dtpThur3rdEnd.Value.ToShortTimeString();

                        var set4thTimeStart = dtpThur4thStart.Value.ToShortTimeString();
                        var set4thTimeSEnd = dtpThur4thEnd.Value.ToShortTimeString();

                        var set5thTimeStart = dtpThur5thStart.Value.ToShortTimeString();
                        var set5thTimeSEnd = dtpThur5thEnd.Value.ToShortTimeString();

                        string sTime = currentTime.ToShortTimeString();

                        if (set1stTimeStart == sTime || set1stTimeSEnd == sTime)
                        {
                            if (!chkThur1st.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set2ndTimeStart == sTime || set2ndTimeSEnd == sTime)
                        {
                            if (!chkThur2nd.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set3rdTimeStart == sTime || set3rdTimeSEnd == sTime)
                        {
                            if (!chkThur3rd.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set4thTimeStart == sTime || set4thTimeSEnd == sTime)
                        {
                            if (!chkThur4th.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set5thTimeStart == sTime || set5thTimeSEnd == sTime)
                        {
                            if (!chkThur5th.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                    }
                    break;
                case DayOfWeek.Friday:
                    if (!fridayOff.Checked)
                    {
                        var currentTime = DateTime.Now;

                        var set1stTimeStart = dtpFri1stStart.Value.ToShortTimeString();
                        var set1stTimeSEnd = dtpFri1stEnd.Value.ToShortTimeString();

                        var set2ndTimeStart = dtpFri2ndStart.Value.ToShortTimeString();
                        var set2ndTimeSEnd = dtpFri2ndEnd.Value.ToShortTimeString();

                        var set3rdTimeStart = dtpFri3rdStart.Value.ToShortTimeString();
                        var set3rdTimeSEnd = dtpFri3rdEnd.Value.ToShortTimeString();

                        var set4thTimeStart = dtpFri4thStart.Value.ToShortTimeString();
                        var set4thTimeSEnd = dtpFri4thEnd.Value.ToShortTimeString();

                        var set5thTimeStart = dtpFri5thStart.Value.ToShortTimeString();
                        var set5thTimeSEnd = dtpFri5thEnd.Value.ToShortTimeString();

                        string sTime = currentTime.ToShortTimeString();

                        if (set1stTimeStart == sTime || set1stTimeSEnd == sTime)
                        {
                            if (!chkFri1st.Checked)
                            {
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set2ndTimeStart == sTime || set2ndTimeSEnd == sTime)
                        {
                            if (!chkFri2nd.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set3rdTimeStart == sTime || set3rdTimeSEnd == sTime)
                        {
                            if (!chkFri3rd.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set4thTimeStart == sTime || set4thTimeSEnd == sTime)
                        {
                            if (!chkFri4th.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set5thTimeStart == sTime || set5thTimeSEnd == sTime)
                        {
                            if (!chkFri5th.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                    }
                    break;
                case DayOfWeek.Saturday:
                    if (!saturdayOff.Checked)
                    {
                        var currentTime = DateTime.Now;

                        var set1stTimeStart = dtpSat1stStart.Value.ToShortTimeString();
                        var set1stTimeSEnd = dtpSat1stEnd.Value.ToShortTimeString();

                        var set2ndTimeStart = dtpSat2ndStart.Value.ToShortTimeString();
                        var set2ndTimeSEnd = dtpSat2ndEnd.Value.ToShortTimeString();

                        //var set3rdTimeStart = dtpSat3rdStart.Value.ToShortTimeString();
                        //var set3rdTimeSEnd = dtpSat3rdEnd.Value.ToShortTimeString();

                        //var set4thTimeStart = dtpSat4thStart.Value.ToShortTimeString();
                        //var set4thTimeSEnd = dtpSat4thEnd.Value.ToShortTimeString();

                        //var set5thTimeStart = dtpSat5thStart.Value.ToShortTimeString();
                        //var set5thTimeSEnd = dtpSat5thEnd.Value.ToShortTimeString();

                        string sTime = currentTime.ToShortTimeString();

                        if (set1stTimeStart == sTime || set1stTimeSEnd == sTime)
                        {
                            if (!chkSat1st.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        if (set2ndTimeStart == sTime || set2ndTimeSEnd == sTime)
                        {
                            if (!chkSat2nd.Checked)
                            {
                                //TODO: Ring bell
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                                player.Play();
                            }

                        }
                        //if (set3rdTimeStart == sTime || set3rdTimeSEnd == sTime)
                        //{
                        //    //TODO: Ring bell
                        //    System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                        //    player.Play();

                        //}
                        //if (set4thTimeStart == sTime || set4thTimeSEnd == sTime)
                        //{
                        //    //TODO: Ring bell
                        //    System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                        //    player.Play();

                        //}
                        //if (set5thTimeStart == sTime || set5thTimeSEnd == sTime)
                        //{
                        //    //TODO: Ring bell
                        //    System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullFilePath);
                        //    player.Play();

                        //}
                    }
                    break;
                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startOperation();
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
            //player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void dateTimePicker67_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mondayOff_CheckedChanged(object sender, EventArgs e)
        {
            if (mondayOff.Checked)
            {
                dtpMon1stEnd.Enabled = false;
                dtpMon1stStart.Enabled = false;
                dtpMon2ndEnd.Enabled = false;
                dtpMon2ndStart.Enabled = false;
                dtpMon3rdEnd.Enabled = false;
                dtpMon3rdStart.Enabled = false;
                dtpMon4thEnd.Enabled = false;
                dtpMon4thStart.Enabled = false;
                dtpMon5thEnd.Enabled = false;
                dtpMon5thStart.Enabled = false;
                chkMon1st.Enabled = false;
                chkMon2nd.Enabled = false;
                chkMon3rd.Enabled = false;
                chkMon4th.Enabled = false;
                chkMon5thP.Enabled = false;

                chkMon1st.Checked = false;
                chkMon2nd.Checked = false;
                chkMon3rd.Checked = false;
                chkMon4th.Checked = false;
                chkMon5thP.Checked = false;

            }
            else
            {
                dtpMon1stEnd.Enabled = true;
                dtpMon1stStart.Enabled = true;
                dtpMon2ndEnd.Enabled = true;
                dtpMon2ndStart.Enabled = true;
                dtpMon3rdEnd.Enabled = true;
                dtpMon3rdStart.Enabled = true;
                dtpMon4thEnd.Enabled = true;
                dtpMon4thStart.Enabled = true;
                dtpMon5thEnd.Enabled = true;
                dtpMon5thStart.Enabled = true;
                chkMon1st.Enabled = true;
                chkMon2nd.Enabled = true;
                chkMon3rd.Enabled = true;
                chkMon4th.Enabled = true;
                chkMon5thP.Enabled = true;
            }
        }

        private void tuesdayOff_CheckedChanged(object sender, EventArgs e)
        {
            if (tuesdayOff.Checked)
            {
                dtpTue1stEnd.Enabled = false;
                dtpTue1stStart.Enabled = false;
                dtpTue2ndEnd.Enabled = false;
                dtpTue2ndStart.Enabled = false;
                dtpTue3rdEnd.Enabled = false;
                dtpTue3rdStart.Enabled = false;
                dtpTue4thEnd.Enabled = false;
                dtpTue4thStart.Enabled = false;
                dtpTue5thEnd.Enabled = false;
                dtpTue5thStart.Enabled = false;
                chkTue1st.Enabled = false;
                chkTue2nd.Enabled = false;
                chkTue3rd.Enabled = false;
                chkTue4th.Enabled = false;
                chkTue5th.Enabled = false;

                chkTue1st.Checked = false;
                chkTue2nd.Checked = false;
                chkTue3rd.Checked = false;
                chkTue4th.Checked = false;
                chkTue5th.Checked = false;

            }
            else
            {
                dtpTue1stEnd.Enabled = true;
                dtpTue1stStart.Enabled = true;
                dtpTue2ndEnd.Enabled = true;
                dtpTue2ndStart.Enabled = true;
                dtpTue3rdEnd.Enabled = true;
                dtpTue3rdStart.Enabled = true;
                dtpTue4thEnd.Enabled = true;
                dtpTue4thStart.Enabled = true;
                dtpTue5thEnd.Enabled = true;
                dtpTue5thStart.Enabled = true;
                chkTue1st.Enabled = true;
                chkTue2nd.Enabled = true;
                chkTue3rd.Enabled = true;
                chkTue4th.Enabled = true;
                chkTue5th.Enabled = true;
            }
        }

        private void wednessdayOff_CheckedChanged(object sender, EventArgs e)
        {
            if ( wednessdayOff.Checked)
            {
                dtpWed1stEnd.Enabled = false;
                dtpWed1stStart.Enabled = false;
                dtpWed2ndEnd.Enabled = false;
                dtpWed2ndStart.Enabled = false;
                dtpWed3rdEnd.Enabled = false;
                dtpWed3rdStart.Enabled = false;
                dtpWed4thEnd.Enabled = false;
                dtpWed4thStart.Enabled = false;
                dtpWed5thEnd.Enabled = false;
                dtpWed5thStart.Enabled = false;
                chkWed1st.Enabled = false;
                chkWed2nd.Enabled = false;
                chkWed3rd.Enabled = false;
                chkWed4th.Enabled = false;
                chkWed5th.Enabled = false;

                chkWed1st.Checked = false;
                chkWed2nd.Checked = false;
                chkWed3rd.Checked = false;
                chkWed4th.Checked = false;
                chkWed5th.Checked = false;

            }
            else
            {
                dtpWed1stEnd.Enabled = true;
                dtpWed1stStart.Enabled = true;
                dtpWed2ndEnd.Enabled = true;
                dtpWed2ndStart.Enabled = true;
                dtpWed3rdEnd.Enabled = true;
                dtpWed3rdStart.Enabled = true;
                dtpWed4thEnd.Enabled = true;
                dtpWed4thStart.Enabled = true;
                dtpWed5thEnd.Enabled = true;
                dtpWed5thStart.Enabled = true;
                chkWed1st.Enabled = true;
                chkWed2nd.Enabled = true;
                chkWed3rd.Enabled = true;
                chkWed4th.Enabled = true;
                chkWed5th.Enabled = true;
            }
        }

        private void thursdayOff_CheckedChanged(object sender, EventArgs e)
        {
            if (thursdayOff.Checked)
            {
                dtpThur1stEnd.Enabled = false;
                dtpThur1stStart.Enabled = false;
                dtpThur2ndEnd.Enabled = false;
                dtpThur2ndStart.Enabled = false;
                dtpThur3rdEnd.Enabled = false;
                dtpThur3rdStart.Enabled = false;
                dtpThur4thEnd.Enabled = false;
                dtpThur4thStart.Enabled = false;
                dtpThur5thEnd.Enabled = false;
                dtpThur5thStart.Enabled = false;
                chkThur1st.Enabled = false;
                chkThur2nd.Enabled = false;
                chkThur3rd.Enabled = false;
                chkThur4th.Enabled = false;
                chkThur5th.Enabled = false;

                chkThur1st.Checked = false;
                chkThur2nd.Checked = false;
                chkThur3rd.Checked = false;
                chkThur4th.Checked = false;
                chkThur5th.Checked = false;

            }
            else
            {
                dtpThur1stEnd.Enabled = true;
                dtpThur1stStart.Enabled = true;
                dtpThur2ndEnd.Enabled = true;
                dtpThur2ndStart.Enabled = true;
                dtpThur3rdEnd.Enabled = true;
                dtpThur3rdStart.Enabled = true;
                dtpThur4thEnd.Enabled = true;
                dtpThur4thStart.Enabled = true;
                dtpThur5thEnd.Enabled = true;
                dtpThur5thStart.Enabled = true;
                chkThur1st.Enabled = true;
                chkThur2nd.Enabled = true;
                chkThur3rd.Enabled = true;
                chkThur4th.Enabled = true;
                chkThur5th.Enabled = true;
            }
        }

        private void fridayOff_CheckedChanged(object sender, EventArgs e)
        {
            if (fridayOff.Checked)
            {
                dtpFri1stEnd.Enabled = false;
                dtpFri1stStart.Enabled = false;
                dtpFri2ndEnd.Enabled = false;
                dtpFri2ndStart.Enabled = false;
                dtpFri3rdEnd.Enabled = false;
                dtpFri3rdStart.Enabled = false;
                dtpFri4thEnd.Enabled = false;
                dtpFri4thStart.Enabled = false;
                dtpFri5thEnd.Enabled = false;
                dtpFri5thStart.Enabled = false;
                chkFri1st.Enabled = false;
                chkFri2nd.Enabled = false;
                chkFri3rd.Enabled = false;
                chkFri4th.Enabled = false;
                chkFri5th.Enabled = false;

                chkFri1st.Checked = false;
                chkFri2nd.Checked = false;
                chkFri3rd.Checked = false;
                chkFri4th.Checked = false;
                chkFri5th.Checked = false;


            }
            else
            {
                dtpFri1stEnd.Enabled = true;
                dtpFri1stStart.Enabled = true;
                dtpFri2ndEnd.Enabled = true;
                dtpFri2ndStart.Enabled = true;
                dtpFri3rdEnd.Enabled = true;
                dtpFri3rdStart.Enabled = true;
                dtpFri4thEnd.Enabled = true;
                dtpFri4thStart.Enabled = true;
                dtpFri5thEnd.Enabled = true;
                dtpFri5thStart.Enabled = true;
                chkFri1st.Enabled = true;
                chkFri2nd.Enabled = true;
                chkFri3rd.Enabled = true;
                chkFri4th.Enabled = true;
                chkFri5th.Enabled = true;
            }
        }

        private void saturdayOff_CheckedChanged(object sender, EventArgs e)
        {
            if (saturdayOff.Checked)
            {
                dtpSat1stEnd.Enabled = false;
                dtpSat1stStart.Enabled = false;
                dtpSat2ndEnd.Enabled = false;
                dtpSat2ndStart.Enabled = false;
                dtpSat3rdEnd.Enabled = false;
                dtpSat3rdStart.Enabled = false;
                dtpSat4thEnd.Enabled = false;
                dtpSat4thStart.Enabled = false;
                dtpSat5thEnd.Enabled = false;
                dtpSat5thStart.Enabled = false;
                chkSat1st.Enabled = false;
                chkSat2nd.Enabled = false;
                chkSat3rd.Enabled = false;
                chkSat4th.Enabled = false;
                chkSat5th.Enabled = false;

                chkSat1st.Checked = false;
                chkSat2nd.Checked = false;
                chkSat3rd.Checked = false;
                chkSat4th.Checked = false;
                chkSat5th.Checked = false;

            }
            else
            {
                dtpSat1stEnd.Enabled = true;
                dtpSat1stStart.Enabled = true;
                dtpSat2ndEnd.Enabled = true;
                dtpSat2ndStart.Enabled = true;
                dtpSat3rdEnd.Enabled = true;
                dtpSat3rdStart.Enabled = true;
                dtpSat4thEnd.Enabled = true;
                dtpSat4thStart.Enabled = true;
                dtpSat5thEnd.Enabled = true;
                dtpSat5thStart.Enabled = true;
                chkSat1st.Enabled = true;
                chkSat2nd.Enabled = true;
                chkSat3rd.Enabled = true;
                chkSat4th.Enabled = true;
                chkSat5th.Enabled = true;


            }
        }

        private void sundayOff_CheckedChanged(object sender, EventArgs e)
        {
            if (sundayOff.Checked)
            {
                dtpSun1stEnd.Enabled = false;
                dtpSun1stStart.Enabled = false;
                dtpSun2ndEnd.Enabled = false;
                dtpSun2ndStart.Enabled = false;
                dtpSun3rdEnd.Enabled = false;
                dtpSun3rdStart.Enabled = false;
                dtpSun4thEnd.Enabled = false;
                dtpSun4thStart.Enabled = false;
                dtpSun5thEnd.Enabled = false;
                dtpSun5thStart.Enabled = false;
                chkSun1st.Enabled = false;
                chkSun2nd.Enabled = false;
                chkSun3rd.Enabled = false;
                chkSun4th.Enabled = false;
                chkSun5th.Enabled = false;

                chkSun1st.Checked = false;
                chkSun2nd.Checked = false;
                chkSun3rd.Checked = false;
                chkSun4th.Checked = false;
                chkSun5th.Checked = false;
            }
            else
            {
                dtpSun1stEnd.Enabled = true;
                dtpSun1stStart.Enabled = true;
                dtpSun2ndEnd.Enabled = true;
                dtpSun2ndStart.Enabled = true;
                dtpSun3rdEnd.Enabled = true;
                dtpSun3rdStart.Enabled = true;
                dtpSun4thEnd.Enabled = true;
                dtpSun4thStart.Enabled = true;
                dtpSun5thEnd.Enabled = true;
                dtpSun5thStart.Enabled = true;
                chkSun1st.Enabled = true;
                chkSun2nd.Enabled = true;
                chkSun3rd.Enabled = true;
                chkSun4th.Enabled = true;
                chkSun5th.Enabled = true;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSun2nd.Checked)
            {
                dtpSun2ndEnd.Enabled = false;
                dtpSun2ndStart.Enabled = false;
            }
            else
            {
                dtpSun2ndEnd.Enabled = true;
                dtpSun2ndStart.Enabled = true;
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThur4th.Checked)
            {
                dtpThur4thEnd.Enabled = false;
                dtpThur4thStart.Enabled = false;
            }
            else
            {
                dtpThur4thEnd.Enabled = true;
                dtpThur4thStart.Enabled = true;
            }
        }

        private void chkMon1st_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMon1st.Checked)
            {
                dtpMon1stStart.Enabled = false;
                dtpMon1stEnd.Enabled = false;
            }
            else
            {
                dtpMon1stStart.Enabled = true;
                dtpMon1stEnd.Enabled = true;
            }
        }

        private void chkTue1st_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTue1st.Checked)
            {
                dtpTue1stEnd.Enabled = false;
                dtpTue1stStart.Enabled = false;
            }
            else
            {
                dtpTue1stEnd.Enabled = true;
                dtpTue1stStart.Enabled = true;
            }
        }

        private void dtpTue1stStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkMon2nd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMon2nd.Checked)
            {
                dtpMon2ndEnd.Enabled = false;
                dtpMon2ndStart.Enabled = false;
            }
            else
            {
                dtpMon2ndEnd.Enabled = true;
                dtpMon2ndStart.Enabled = true;
            }
            
        }

        private void chkMon3rd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMon3rd.Checked)
            {
                dtpMon3rdEnd.Enabled = false;
                dtpMon3rdStart.Enabled = false;
            }
            else
            {
                dtpMon3rdEnd.Enabled = true;
                dtpMon3rdStart.Enabled = true;
            }
        }

        private void chkMon4th_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMon4th.Checked)
            {
                dtpMon4thEnd.Enabled = false;
                dtpMon4thStart.Enabled = false;
            }
            else
            {
                dtpMon4thEnd.Enabled = true;
                dtpMon4thStart.Enabled = true;
            }
        }

        private void chkMon5thP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMon5thP.Checked)
            {
                dtpMon5thEnd.Enabled = false;
                dtpMon5thStart.Enabled = false;
            }
            else
            {
                dtpMon5thEnd.Enabled = true;
                dtpMon5thStart.Enabled = true;
            }
        }

        private void chkTue2nd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTue2nd.Checked)
            {
                dtpTue2ndEnd.Enabled = false;
                dtpTue2ndStart.Enabled = false;
            }
            else
            {
                dtpTue2ndEnd.Enabled = true;
                dtpTue2ndStart.Enabled = true;
            }
        }

        private void chkTue3rd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTue3rd.Checked)
            {
                dtpTue3rdEnd.Enabled = false;
                dtpTue3rdStart.Enabled = false;
            }
            else
            {
                dtpTue3rdEnd.Enabled = true;
                dtpTue3rdStart.Enabled = true;
            }
        }

        private void chkTue4th_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTue4th.Checked)
            {
                dtpTue4thEnd.Enabled = false;
                dtpTue4thStart.Enabled = false;
            }
            else
            {
                dtpTue4thEnd.Enabled = true;
                dtpTue4thStart.Enabled = true;
            }
        }

        private void chkTue5th_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTue5th.Checked)
            {
                dtpTue5thEnd.Enabled = false;
                dtpTue5thStart.Enabled = false;
            }
            else
            {
                dtpTue5thEnd.Enabled = true;
                dtpTue5thStart.Enabled = true;
            }
        }

        private void chkWed1st_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWed1st.Checked)
            {
                dtpWed1stEnd.Enabled = false;
                dtpWed1stStart.Enabled = false;
            }
            else
            {
                dtpWed1stEnd.Enabled = true;
                dtpWed1stStart.Enabled = true;
            }
        }

        private void chkWed2nd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWed2nd.Checked)
            {
                dtpWed2ndEnd.Enabled = false;
                dtpWed2ndStart.Enabled = false;
            }
            else
            {
                dtpWed2ndEnd.Enabled = true;
                dtpWed2ndStart.Enabled = true;
            }
        }

        private void chkWed3rd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWed3rd.Checked)
            {
                dtpWed3rdEnd.Enabled = false;
                dtpWed3rdStart.Enabled = false;
            }
            else
            {
                dtpWed3rdEnd.Enabled = true;
                dtpWed3rdStart.Enabled = true;
            }
        }

        private void chkWed4th_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWed4th.Checked)
            {
                dtpWed4thEnd.Enabled = false;
                dtpWed4thStart.Enabled = false;
            }
            else
            {
                dtpWed4thEnd.Enabled = true;
                dtpWed4thStart.Enabled = true;
            }
            
        }

        private void chkWed5th_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWed5th.Checked)
            {
                dtpWed5thEnd.Enabled = false;
                dtpWed5thStart.Enabled = false;
            }
            else
            {
                dtpWed5thEnd.Enabled = true;
                dtpWed5thStart.Enabled = true;
            }
        }

        private void chkThur1st_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThur1st.Checked)
            {
                dtpThur1stEnd.Enabled = false;
                dtpThur1stStart.Enabled = false;
            }
            else
            {
                dtpThur1stEnd.Enabled = true;
                dtpThur1stStart.Enabled = true;
            }
        }

        private void chkThur2nd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThur2nd.Checked)
            {
                dtpThur2ndEnd.Enabled = false;
                dtpThur2ndStart.Enabled = false;
            }
            else
            {
                dtpThur2ndEnd.Enabled = true;
                dtpThur2ndStart.Enabled = true;
            }
        }

        private void chkThur3rd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThur3rd.Checked)
            {
                dtpThur3rdEnd.Enabled = false;
                dtpThur3rdStart.Enabled = false;
            }
            else
            {
                dtpThur3rdEnd.Enabled = true;
                dtpThur3rdStart.Enabled = true;
            }
        }

        private void chkThur5th_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThur5th.Checked)
            {
                dtpThur5thStart.Enabled = false;
                dtpThur5thEnd.Enabled = false;
            }
            else
            {
                dtpThur5thStart.Enabled = true;
                dtpThur5thEnd.Enabled = true;
            }
        }

        private void chkFri1st_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFri1st.Checked)
            {
                dtpFri1stEnd.Enabled = false;
                dtpFri1stStart.Enabled = false;
            }
            else
            {
                dtpFri1stEnd.Enabled = true;
                dtpFri1stStart.Enabled = true;
            }
        }

        private void chkFri2nd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFri2nd.Checked)
            {
                dtpFri2ndEnd.Enabled = false;
                dtpFri2ndStart.Enabled = false;
            }
            else
            {
                dtpFri2ndEnd.Enabled = true;
                dtpFri2ndStart.Enabled = true;
            }
        }

        private void chkFri3rd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFri3rd.Checked)
            {
                dtpFri3rdEnd.Enabled = false;
                dtpFri3rdStart.Enabled = false;
            }
            else
            {
                dtpFri3rdEnd.Enabled = true;
                dtpFri3rdStart.Enabled = true;
            }
        }

        private void chkFri4th_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFri4th.Checked)
            {
                dtpFri4thEnd.Enabled = false;
                dtpFri4thStart.Enabled = false;
            }
            else
            {
                dtpFri4thEnd.Enabled = true;
                dtpFri4thStart.Enabled = true;
            }
        }

        private void chkFri5th_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFri5th.Checked)
            {
                dtpFri5thEnd.Enabled = false;
                dtpFri5thStart.Enabled = false;
            }
            else
            {
                dtpFri5thEnd.Enabled = true;
                dtpFri5thStart.Enabled = true;
            }
        }

        private void chkSat1st_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSat1st.Checked)
            {
                   dtpSat1stEnd.Enabled = false;
                   dtpSat1stStart.Enabled = false;
            }
            else
            {
                dtpSat1stEnd.Enabled = true;
                dtpSat1stStart.Enabled = true;
            }
        }

        private void chkSat2nd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSat2nd.Checked)
            {
                dtpSat2ndEnd.Enabled = false;
                dtpSat2ndStart.Enabled = false;
            }
            else
            {
                dtpSat2ndEnd.Enabled = true;
                dtpSat2ndStart.Enabled = true;
            }
        }

        private void chkSat3rd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSat3rd.Checked)
            {
                dtpSat3rdEnd.Enabled = false;
                dtpSat3rdStart.Enabled = false;
            }
            else
            {
                dtpSat3rdEnd.Enabled = true;
                dtpSat3rdStart.Enabled = true;
            }
        }

        private void chkSat4th_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSat4th.Checked)
            {
                dtpSat4thEnd.Enabled = false;
                dtpSat4thStart.Enabled = false;
            }
            else
            {
                dtpSat4thEnd.Enabled = true;
                dtpSat4thStart.Enabled = true;
            }
        }

        private void chkSat5th_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSat5th.Checked)
            {
                dtpSat5thEnd.Enabled = false;
                dtpSat5thStart.Enabled = false;
            }
            else
            {
                dtpSat5thEnd.Enabled = true;
                dtpSat5thStart.Enabled = true;
            }
        }

        private void chkSun1st_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSun1st.Checked)
            {
                dtpSun1stEnd.Enabled = false;
                dtpSun1stStart.Enabled = false;
            }
            else
            {
                dtpSun1stEnd.Enabled = true;
                dtpSun1stStart.Enabled = true;
            }
        }

        private void chkSun3rd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSun3rd.Checked)
            {
                dtpSun3rdEnd.Enabled = false;
                dtpSun3rdStart.Enabled = false;
            }
            else
            {
                dtpSun3rdEnd.Enabled = true;
                dtpSun3rdStart.Enabled = true;
            }
        }

        private void chkSun4th_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSun4th.Checked)
            {
                dtpSun4thEnd.Enabled = false;
                dtpSun4thStart.Enabled = false;
            }
            else
            {
                dtpSun4thEnd.Enabled = true;
                dtpSun4thStart.Enabled = true;
            }
        }

        private void chkSun5th_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSun5th.Checked)
            {
                dtpSun5thEnd.Enabled = false;
                dtpSun5thStart.Enabled = false;
            }
            else
            {
                dtpSun5thEnd.Enabled = true;
                dtpSun5thStart.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
